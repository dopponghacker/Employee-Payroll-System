Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class Signup
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private profilePictureBytes As Byte() = Nothing

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxCategory.Items.AddRange({"Manager", "Developer", "Accountant", "HR", "Intern"})
        ComboBoxGender.Items.AddRange({"Male", "Female", "Other"})
        ComboBoxDepartment.Items.AddRange({"HR", "Finance", "IT", "Operations", "Sales"})

        ' Set default date (18 years ago)
        DateTimePickerDob.Value = DateTime.Now.AddYears(-18)
    End Sub

    Private Sub SignButton_Click(sender As Object, e As EventArgs) Handles SignButton.Click
        If Not ValidateInputs() Then Exit Sub

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Try
                    ' Check if email exists
                    If EmailExists(TextBoxEmail.Text, connection, transaction) Then
                        MessageBox.Show("Email already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        transaction.Rollback()
                        Return
                    End If

                    ' Check if username exists
                    If UsernameExists(TextBoxUsername.Text, connection, transaction) Then
                        MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        transaction.Rollback()
                        Return
                    End If

                    ' Insert employee
                    Dim employeeId As Integer = InsertEmployee(connection, transaction)

                    ' Insert account
                    InsertAccount(employeeId, connection, transaction)

                    transaction.Commit()
                    MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Open EmployeeForm directly
                    Dim employeeForm As New employeeForm(TextBoxUsername.Text)
                    employeeForm.Show()
                    Me.Close() ' Close the signup form
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error during registration: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Catch ex As Exception
                MessageBox.Show("Error connecting to database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function InsertEmployee(connection As SqlConnection, transaction As SqlTransaction) As Integer
        Dim query As String = "INSERT INTO Employees (FirstName, LastName, Email, Phone, DateOfBirth, " &
                             "Category, Gender, Department, ProfilePicture, HireDate, BasicSalary) " &
                             "VALUES (@FirstName, @LastName, @Email, @Phone, @DateOfBirth, " &
                             "@Category, @Gender, @Department, @ProfilePicture, @HireDate, @BasicSalary); " &
                             "SELECT SCOPE_IDENTITY();"

        Using command As New SqlCommand(query, connection, transaction)
            command.Parameters.AddWithValue("@FirstName", TextBoxFirstName.Text)
            command.Parameters.AddWithValue("@LastName", TextBoxLastName.Text)
            command.Parameters.AddWithValue("@Email", TextBoxEmail.Text)
            command.Parameters.AddWithValue("@Phone", TextBoxPhone.Text)
            command.Parameters.AddWithValue("@DateOfBirth", DateTimePickerDob.Value)
            command.Parameters.AddWithValue("@Category", ComboBoxCategory.SelectedItem.ToString())
            command.Parameters.AddWithValue("@Gender", ComboBoxGender.SelectedItem.ToString())
            command.Parameters.AddWithValue("@Department", ComboBoxDepartment.SelectedItem.ToString())
            command.Parameters.AddWithValue("@ProfilePicture", If(profilePictureBytes IsNot Nothing, profilePictureBytes, DBNull.Value))
            command.Parameters.AddWithValue("@HireDate", DateTime.Now)
            command.Parameters.AddWithValue("@BasicSalary", 0) ' Default salary

            Return Convert.ToInt32(command.ExecuteScalar())
        End Using
    End Function

    Private Sub InsertAccount(employeeId As Integer, connection As SqlConnection, transaction As SqlTransaction)
        Dim query As String = "INSERT INTO Accounts (EmployeeID, Username, Password, Role) " &
                             "VALUES (@EmployeeID, @Username, @Password, @Role)"

        Using command As New SqlCommand(query, connection, transaction)
            command.Parameters.AddWithValue("@EmployeeID", employeeId)
            command.Parameters.AddWithValue("@Username", TextBoxUsername.Text)
            command.Parameters.AddWithValue("@Password", HashPassword(TextBoxPassword.Text))
            command.Parameters.AddWithValue("@Role", "Employee") ' Default role
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Function EmailExists(email As String, connection As SqlConnection, transaction As SqlTransaction) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Employees WHERE Email = @Email"
        Using command As New SqlCommand(query, connection, transaction)
            command.Parameters.AddWithValue("@Email", email)
            Return Convert.ToInt32(command.ExecuteScalar()) > 0
        End Using
    End Function

    Private Function UsernameExists(username As String, connection As SqlConnection, transaction As SqlTransaction) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Accounts WHERE Username = @Username"
        Using command As New SqlCommand(query, connection, transaction)
            command.Parameters.AddWithValue("@Username", username)
            Return Convert.ToInt32(command.ExecuteScalar()) > 0
        End Using
    End Function

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function

    Private Function ValidateInputs() As Boolean
        ' Validate required fields
        If String.IsNullOrWhiteSpace(TextBoxFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxLastName.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxEmail.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxPhone.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxUsername.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxPassword.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxComfirmPassword.Text) Then
            MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate email format
        If Not Regex.IsMatch(TextBoxEmail.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") Then
            MessageBox.Show("Invalid email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate phone number
        If Not Regex.IsMatch(TextBoxPhone.Text, "^\d{10}$") Then
            MessageBox.Show("Phone number must be 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate password match
        If TextBoxPassword.Text <> TextBoxComfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate password strength
        If TextBoxPassword.Text.Length < 8 OrElse
           Not Regex.IsMatch(TextBoxPassword.Text, "\d") OrElse
           Not Regex.IsMatch(TextBoxPassword.Text, "[^a-zA-Z0-9]") Then
            MessageBox.Show("Password must be at least 8 characters with a number and special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub UploadPictureButton_Click(sender As Object, e As EventArgs) Handles UploadPictureButton.Click
        Dim openFileDialog As New OpenFileDialog() With {
            .Title = "Select Profile Picture",
            .Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png",
            .Multiselect = False
        }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim filePath As String = openFileDialog.FileName
                profilePictureBytes = File.ReadAllBytes(filePath)

                Using ms As New MemoryStream(profilePictureBytes)
                    UserProfilePicture.Image = Image.FromStream(ms)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error uploading picture: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                profilePictureBytes = Nothing
                UserProfilePicture.Image = Nothing
            End Try
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBoxFirstName.Clear()
        TextBoxLastName.Clear()
        TextBoxEmail.Clear()
        TextBoxPhone.Clear()
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        TextBoxComfirmPassword.Clear()
        DateTimePickerDob.Value = Date.Now.AddYears(-18)
        ComboBoxCategory.SelectedIndex = -1
        ComboBoxGender.SelectedIndex = -1
        ComboBoxDepartment.SelectedIndex = -1
        UserProfilePicture.Image = Nothing
        profilePictureBytes = Nothing
        TextBoxFirstName.Focus()
    End Sub

    Private Sub BackButton(sender As Object, e As EventArgs)

    End Sub

    Private Sub SendBacktologinButton_Click(sender As Object, e As EventArgs) Handles SendBacktologinButton.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class