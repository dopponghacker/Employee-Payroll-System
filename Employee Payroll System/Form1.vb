Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class Login
    Private Const UsernamePlaceholder As String = "Enter your username"
    Private Const PasswordPlaceholder As String = "Enter your password"
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private currentUserRole As String = String.Empty

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPlaceholder(TextBoxUsername, UsernamePlaceholder)
        ApplyPlaceholder(TextBoxPassword, PasswordPlaceholder, isPassword:=True)
        TextBoxUsername.Focus()
    End Sub

    ' ========== Placeholder Logic ==========

    Private Sub ApplyPlaceholder(txtBox As TextBox, placeholder As String, Optional isPassword As Boolean = False)
        txtBox.Text = placeholder
        txtBox.ForeColor = Color.Gray
        txtBox.Tag = "placeholder"
        If isPassword Then txtBox.UseSystemPasswordChar = False
    End Sub

    Private Sub RemovePlaceholder(txtBox As TextBox, placeholder As String, Optional isPassword As Boolean = False)
        If txtBox.Text = placeholder AndAlso txtBox.Tag?.ToString() = "placeholder" Then
            txtBox.Text = ""
            txtBox.ForeColor = Color.Black
            txtBox.Tag = "text"
            If isPassword Then txtBox.UseSystemPasswordChar = True ' ✅ Mask password here
        End If
    End Sub


    Private Sub RestorePlaceholder(txtBox As TextBox, placeholder As String, Optional isPassword As Boolean = False)
        If String.IsNullOrWhiteSpace(txtBox.Text) Then
            txtBox.Text = placeholder
            txtBox.ForeColor = Color.Gray
            txtBox.Tag = "placeholder"
            txtBox.UseSystemPasswordChar = False ' Reset masking when placeholder appears
        End If
    End Sub

    ' ========== Placeholder Events ==========

    Private Sub TextBoxUsername_Enter(sender As Object, e As EventArgs) Handles TextBoxUsername.Enter
        RemovePlaceholder(TextBoxUsername, UsernamePlaceholder)
    End Sub

    Private Sub TextBoxUsername_Leave(sender As Object, e As EventArgs) Handles TextBoxUsername.Leave
        RestorePlaceholder(TextBoxUsername, UsernamePlaceholder)
    End Sub

    Private Sub TextBoxPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxPassword.Enter
        RemovePlaceholder(TextBoxPassword, PasswordPlaceholder, isPassword:=True)
    End Sub

    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave
        RestorePlaceholder(TextBoxPassword, PasswordPlaceholder, isPassword:=True)
    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged
        ' Only enable masking if the tag is not "placeholder"
        If TextBoxPassword.Tag?.ToString() <> "placeholder" Then
            TextBoxPassword.UseSystemPasswordChar = True
        End If
    End Sub



    ' ========== Login Logic ==========

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim username As String = TextBoxUsername.Text
        Dim password As String = TextBoxPassword.Text

        If username = UsernamePlaceholder OrElse password = PasswordPlaceholder Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidateCredentials(username, password) Then
            Dim employeeForm As New employeeForm(username, currentUserRole)
            employeeForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateCredentials(username As String, password As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT Password, Role FROM Accounts WHERE Username = @Username"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim storedPassword As String = reader("Password").ToString()
                            If VerifyPassword(password, storedPassword) Then
                                currentUserRole = If(reader.IsDBNull(reader.GetOrdinal("Role")), "User", reader("Role").ToString())
                                Return True
                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error validating credentials: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return False
    End Function

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function

    Private Function VerifyPassword(inputPassword As String, storedHash As String) As Boolean
        Return String.Equals(HashPassword(inputPassword), storedHash, StringComparison.Ordinal)
    End Function

    ' ========== Navigation Buttons ==========

    Private Sub SignUpButton_Click(sender As Object, e As EventArgs) Handles SignupButton.Click
        Dim signupForm As New Signup()
        signupForm.Show()
        Me.Hide()
    End Sub

    Private Sub ForgotPasswordButton_Click(sender As Object, e As EventArgs) Handles TextForgetPasswordButton.Click
        Dim forgotPasswordForm As New ForgotPassword()
        forgotPasswordForm.Show()
        Me.Hide()
    End Sub
End Class

