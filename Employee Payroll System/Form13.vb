Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Data.SqlClient

Public Class ForgotPassword
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize placeholder text
        TextBoxRegisteredEmail.Text = "Enter your registered email"
        TextBoxRegisteredEmail.ForeColor = Color.Gray

        TextBoxVerifyEmail.Text = "Verify Email"
        TextBoxVerifyEmail.ForeColor = Color.Gray

        TextBoxNewPassword.Text = "New Password"
        TextBoxNewPassword.ForeColor = Color.Gray
        TextBoxNewPassword.UseSystemPasswordChar = False

        TextBoxComfirmNewPassword.Text = "Confirm New Password"
        TextBoxComfirmNewPassword.ForeColor = Color.Gray
        TextBoxComfirmNewPassword.UseSystemPasswordChar = False
    End Sub

    ' ========== Placeholder Handlers ==========

    ' Email
    Private Sub TextBoxRegisteredEmail_Enter(sender As Object, e As EventArgs) Handles TextBoxRegisteredEmail.Enter
        If TextBoxRegisteredEmail.Text = "Enter your registered email" Then
            TextBoxRegisteredEmail.Text = ""
            TextBoxRegisteredEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxRegisteredEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxRegisteredEmail.Leave
        If String.IsNullOrWhiteSpace(TextBoxRegisteredEmail.Text) Then
            TextBoxRegisteredEmail.Text = "Enter your registered email"
            TextBoxRegisteredEmail.ForeColor = Color.Gray
        End If
    End Sub

    ' Verify Email
    Private Sub TextBoxVerifyEmail_Enter(sender As Object, e As EventArgs) Handles TextBoxVerifyEmail.Enter
        If TextBoxVerifyEmail.Text = "Verify Email" Then
            TextBoxVerifyEmail.Text = ""
            TextBoxVerifyEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxVerifyEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxVerifyEmail.Leave
        If String.IsNullOrWhiteSpace(TextBoxVerifyEmail.Text) Then
            TextBoxVerifyEmail.Text = "Verify Email"
            TextBoxVerifyEmail.ForeColor = Color.Gray
        End If
    End Sub

    ' New Password
    Private Sub TextBoxNewPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxNewPassword.Enter
        If TextBoxNewPassword.Text = "New Password" Then
            TextBoxNewPassword.Text = ""
            TextBoxNewPassword.ForeColor = Color.Black
            TextBoxNewPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBoxNewPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxNewPassword.Leave
        If String.IsNullOrWhiteSpace(TextBoxNewPassword.Text) Then
            TextBoxNewPassword.Text = "New Password"
            TextBoxNewPassword.ForeColor = Color.Gray
            TextBoxNewPassword.UseSystemPasswordChar = False
        End If
    End Sub

    ' Confirm New Password
    Private Sub TextBoxComfirmNewPassword_Enter(sender As Object, e As EventArgs) Handles TextBoxComfirmNewPassword.Enter
        If TextBoxComfirmNewPassword.Text = "Confirm New Password" Then
            TextBoxComfirmNewPassword.Text = ""
            TextBoxComfirmNewPassword.ForeColor = Color.Black
            TextBoxComfirmNewPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBoxComfirmNewPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxComfirmNewPassword.Leave
        If String.IsNullOrWhiteSpace(TextBoxComfirmNewPassword.Text) Then
            TextBoxComfirmNewPassword.Text = "Confirm New Password"
            TextBoxComfirmNewPassword.ForeColor = Color.Gray
            TextBoxComfirmNewPassword.UseSystemPasswordChar = False
        End If
    End Sub

    ' ========== Logic ==========

    Private Sub ResetPasswordButton_Click(sender As Object, e As EventArgs) Handles ResetPasswordButton.Click
        Dim email = TextBoxRegisteredEmail.Text.Trim()
        Dim newPassword = TextBoxNewPassword.Text.Trim()
        Dim confirmPassword = TextBoxComfirmNewPassword.Text.Trim()

        If email = "" OrElse email = "Enter your registered email" Then
            MessageBox.Show("Please enter your registered email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not EmailExists(email) Then
            MessageBox.Show("Email not found in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If newPassword = "" OrElse newPassword = "New Password" OrElse
           confirmPassword = "" OrElse confirmPassword = "Confirm New Password" Then
            MessageBox.Show("Please fill in both password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If newPassword <> confirmPassword Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If CompletePasswordReset(email, newPassword) Then
            MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim loginForm As New Login()
            loginForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Failed to reset password. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function CompletePasswordReset(email As String, newPassword As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Dim getCurrentPasswordQuery = "SELECT Password FROM Accounts WHERE EmployeeID = (SELECT EmployeeID FROM Employees WHERE Email = @Email)"
                Dim getCurrentPasswordCmd As New SqlCommand(getCurrentPasswordQuery, connection, transaction)
                getCurrentPasswordCmd.Parameters.AddWithValue("@Email", email)
                Dim currentPassword = getCurrentPasswordCmd.ExecuteScalar()
                Dim currentPasswordHash = If(currentPassword Is DBNull.Value, "", currentPassword.ToString())

                Dim updateQuery = "
                    UPDATE Accounts
                    SET PreviousPassword = @PreviousPassword,
                        Password = @NewPassword,
                        PasswordResetRequired = 1
                    WHERE EmployeeID = (SELECT EmployeeID FROM Employees WHERE Email = @Email)"
                Dim updateCmd As New SqlCommand(updateQuery, connection, transaction)
                updateCmd.Parameters.AddWithValue("@PreviousPassword", currentPasswordHash)
                updateCmd.Parameters.AddWithValue("@NewPassword", HashPassword(newPassword))
                updateCmd.Parameters.AddWithValue("@Email", email)

                If updateCmd.ExecuteNonQuery() > 0 Then
                    transaction.Commit()
                    Return True
                Else
                    transaction.Rollback()
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Function EmailExists(email As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query = "SELECT COUNT(*) FROM Employees WHERE Email = @Email"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)
                Return Convert.ToInt32(command.ExecuteScalar()) > 0
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim hash = sha256.ComputeHash(bytes)
            Return Convert.ToBase64String(hash)
        End Using
    End Function

    Private Sub BackToLoginButton_Click(sender As Object, e As EventArgs) Handles BackToLoginButton.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close()
    End Sub
End Class
