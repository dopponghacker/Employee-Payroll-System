Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient
Imports System.Windows.Input

Public Class EmployeeDetails
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private employeeId As Integer
    Private loggedInUsername As String
    Private profilePictureBytes As Byte() = Nothing

    Public Sub New(empId As Integer, username As String)
        InitializeComponent()
        employeeId = empId
        loggedInUsername = username
    End Sub

    Private Sub EmployeeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeData()
    End Sub

    Private Sub LoadEmployeeData()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT FirstName, LastName, Email, Phone, Gender, " &
                                    "DateOfBirth, Department, Category, Position, " &
                                    "HireDate, ProfilePicture " &
                                    "FROM Employees WHERE EmployeeID = @EmployeeID"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Personal Information
                            TextBoxFirstName.Text = reader("FirstName").ToString()
                            TextBoxLastName.Text = reader("LastName").ToString()
                            Label1email.Text = reader("Email").ToString()
                            TextBoxPhone.Text = reader("Phone").ToString()
                            TextBoxGender.Text = reader("Gender").ToString()

                            ' Date of Birth
                            If Not IsDBNull(reader("DateOfBirth")) Then
                                TextBoxDob.Text = Convert.ToDateTime(reader("DateOfBirth")).ToString("yyyy-MM-dd")
                            End If

                            ' Professional Information
                            TextBoxDepartment.Text = reader("Department").ToString()
                            TextBoxCategory.Text = reader("Category").ToString()
                            TextBoxPosition.Text = reader("Position").ToString()

                            ' Hire Date
                            If Not IsDBNull(reader("HireDate")) Then
                                Label2hiredate.Text = Convert.ToDateTime(reader("HireDate")).ToString("yyyy-MM-dd")
                            End If

                            ' Profile Picture
                            If Not IsDBNull(reader("ProfilePicture")) Then
                                profilePictureBytes = DirectCast(reader("ProfilePicture"), Byte())
                                Using ms As New MemoryStream(profilePictureBytes)
                                    UserProfilePicture.Image = Image.FromStream(ms)
                                End Using
                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading employee data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub UploadButton_Click(sender As Object, e As EventArgs) Handles UploadButton.Click
        Dim openFileDialog As New OpenFileDialog() With {
            .Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png",
            .Title = "Select Profile Picture"
        }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim filePath As String = openFileDialog.FileName
                Dim fileInfo As New FileInfo(filePath)

                If fileInfo.Length > 5 * 1024 * 1024 Then ' 5MB limit
                    MessageBox.Show("File size must be less than 5MB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                profilePictureBytes = File.ReadAllBytes(filePath)
                UserProfilePicture.Image = Image.FromFile(filePath)
            Catch ex As Exception
                MessageBox.Show("Error uploading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If String.IsNullOrWhiteSpace(TextBoxFirstName.Text) OrElse
           String.IsNullOrWhiteSpace(TextBoxLastName.Text) Then
            MessageBox.Show("First Name and Last Name are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE Employees SET " &
                                    "FirstName = @FirstName, " &
                                    "LastName = @LastName, " &
                                    "Phone = @Phone, " &
                                    "Gender = @Gender, " &
                                    "DateOfBirth = @DateOfBirth, " &
                                    "Department = @Department, " &
                                    "Category = @Category, " &
                                    "Position = @Position"

                ' Add profile picture if uploaded
                If profilePictureBytes IsNot Nothing Then
                    query &= ", ProfilePicture = @ProfilePicture"
                End If

                query &= " WHERE EmployeeID = @EmployeeID"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FirstName", TextBoxFirstName.Text)
                    command.Parameters.AddWithValue("@LastName", TextBoxLastName.Text)
                    command.Parameters.AddWithValue("@Phone", TextBoxPhone.Text)
                    command.Parameters.AddWithValue("@Gender", TextBoxGender.Text)

                    ' Date of Birth
                    If Date.TryParse(TextBoxDob.Text, Nothing) Then
                        command.Parameters.AddWithValue("@DateOfBirth", TextBoxDob.Text)
                    Else
                        command.Parameters.AddWithValue("@DateOfBirth", DBNull.Value)
                    End If

                    ' Professional Information
                    command.Parameters.AddWithValue("@Department", TextBoxDepartment.Text)
                    command.Parameters.AddWithValue("@Category", TextBoxCategory.Text)
                    command.Parameters.AddWithValue("@Position", TextBoxPosition.Text)

                    ' Profile Picture
                    If profilePictureBytes IsNot Nothing Then
                        command.Parameters.AddWithValue("@ProfilePicture", profilePictureBytes)
                    End If

                    command.Parameters.AddWithValue("@EmployeeID", employeeId)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Employee details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating employee details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim employeeForm As New employeeForm(loggedInUsername)
        employeeForm.Show()
        Me.Close()
    End Sub

    Private Sub TextBoxPosition_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPosition.TextChanged

    End Sub
End Class