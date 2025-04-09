Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class EmployeeForm
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private loggedInUsername As String
    Private employeeId As Integer
    Private currentUserRole As String

    Public Sub New(username As String)
        InitializeComponent()
        loggedInUsername = username
    End Sub

    Public Sub New(username As String, currentUserRole As String)
        Me.New(username)
        Me.currentUserRole = currentUserRole
    End Sub

    Private Sub EmployeeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployeeDetails()
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom ' Ensures image fits nicely
    End Sub

    Private Sub LoadEmployeeDetails()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT e.*, a.Role FROM Employees e " &
                                      "JOIN Accounts a ON e.EmployeeID = a.EmployeeID " &
                                      "WHERE a.Username = @Username"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", loggedInUsername)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            employeeId = Convert.ToInt32(reader("EmployeeID"))
                            TextWelcomeLabel.Text = "Welcome, " & reader("FirstName").ToString() & " " & reader("LastName").ToString()
                            TextBoxLastPaySlip.Text = "Last PaySlip: " & GetLastPaySlip(employeeId)
                            TextBoxPendingClaims.Text = "Pending Claims: " & GetPendingClaims(employeeId)
                            TextBoxLeaveBalance.Text = "Leave Balance: " & GetLeaveBalance(employeeId)

                            ' Load profile picture if it exists
                            If Not IsDBNull(reader("ProfilePicture")) Then
                                Dim profilePicBytes As Byte() = DirectCast(reader("ProfilePicture"), Byte())
                                Using ms As New MemoryStream(profilePicBytes)
                                    UserProfilePicture.Image = Image.FromStream(ms)
                                End Using
                            Else
                                UserProfilePicture.Image = Nothing ' or a default image
                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading employee details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function GetLastPaySlip(employeeId As Integer) As String
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT TOP 1 NetSalary FROM Payroll WHERE EmployeeID = @EmployeeID ORDER BY PayDate DESC"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    Dim result = command.ExecuteScalar()
                    Return If(result IsNot Nothing, "GHC" & result.ToString(), "N/A")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching last payslip: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "N/A"
            End Try
        End Using
    End Function

    Private Function GetPendingClaims(employeeId As Integer) As String
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM Claims WHERE EmployeeID = @EmployeeID AND Status = 'Pending'"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    Return command.ExecuteScalar().ToString()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching pending claims: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "0"
            End Try
        End Using
    End Function

    Private Function GetLeaveBalance(employeeId As Integer) As String
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT DaysRemaining FROM EmployeeLeaveBalance WHERE EmployeeID = @EmployeeID"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)

                    Dim result = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Return result.ToString() & " days"
                    Else
                        ' Auto insert if missing
                        Dim insertQuery As String = "INSERT INTO EmployeeLeaveBalance (EmployeeID, DaysRemaining) VALUES (@EmployeeID, 30)"
                        Using insertCmd As New SqlCommand(insertQuery, connection)
                            insertCmd.Parameters.AddWithValue("@EmployeeID", employeeId)
                            insertCmd.ExecuteNonQuery()
                        End Using
                        Return "30 days"
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching leave balance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "0 days"
            End Try
        End Using
    End Function


    ' Navigation Button Events
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        LoadEmployeeDetails()
    End Sub

    Private Sub ClaimEntryButton_Click(sender As Object, e As EventArgs) Handles ClaimEntryButton.Click
        Dim claimForm As New ClaimEntry(employeeId, loggedInUsername)
        claimForm.Show()
        Me.Hide()
    End Sub

    Private Sub LeaveEntryButton_Click(sender As Object, e As EventArgs) Handles LeaveEntryButton.Click
        Dim leaveForm As New LeaveEntry(employeeId, loggedInUsername)
        leaveForm.Show()
        Me.Hide()
    End Sub

    Private Sub AttendanceDetailsButton_Click(sender As Object, e As EventArgs) Handles AttendanceDetailsButton.Click
        Dim attendanceForm As New AttendanceDetails(employeeId, loggedInUsername)
        attendanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub EmployeeDetailsButton_Click(sender As Object, e As EventArgs) Handles EmployeeDetailsButton.Click
        Dim detailsForm As New EmployeeDetails(employeeId, loggedInUsername)
        detailsForm.Show()
        Me.Hide()
    End Sub

    Private Sub PayGenerationButton_Click(sender As Object, e As EventArgs) Handles PayGenerationButton.Click
        Dim payForm As New PayGeneration(employeeId, loggedInUsername)
        payForm.Show()
        Me.Hide()
    End Sub

    Private Sub ViewPaySlipButton_Click(sender As Object, e As EventArgs)
        Dim paySlipForm As New ViewPaySlip(employeeId, loggedInUsername)
        paySlipForm.Show
        Hide
    End Sub

    Private Sub ViewReportButton_Click(sender As Object, e As EventArgs) Handles ViewReportButton.Click
        Dim reportForm As New ViewReport(employeeId, loggedInUsername)
        reportForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoanEntryButton_Click(sender As Object, e As EventArgs) Handles LoanEntryButton.Click
        Dim loanForm As New LoanEntry(employeeId, loggedInUsername)
        loanForm.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateProfileButton_Click(sender As Object, e As EventArgs) Handles UpdateProfileButton.Click
        Dim updateForm As New EmployeeDetails(employeeId, loggedInUsername)
        updateForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Dim loginForm As New Login()
        loginForm.Show()
        Me.Close()
    End Sub
End Class
