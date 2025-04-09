Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class LeaveEntry
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private employeeId As Integer
    Private loggedInUsername As String

    Public Sub New(empId As Integer, username As String)
        InitializeComponent()
        employeeId = empId
        loggedInUsername = username
    End Sub

    Private Sub LeaveEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT e.FirstName, e.LastName, e.ProfilePicture " &
                                      "FROM Employees e JOIN Accounts a ON e.EmployeeID = a.EmployeeID " &
                                      "WHERE a.Username = @Username"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", loggedInUsername)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim fullName As String = reader("FirstName").ToString() & " " & reader("LastName").ToString()
                            TextUserNameLabel.Text = fullName
                            'incase of error delete this
                            If Not IsDBNull(reader("ProfilePicture")) AndAlso reader("ProfilePicture") IsNot Nothing Then
                                Dim picBytes As Byte() = DirectCast(reader("ProfilePicture"), Byte())
                                Using ms As New MemoryStream(picBytes)
                                    UserProfilePicture.Image = Image.FromStream(ms)
                                End Using
                            Else
                                UserProfilePicture.Image = Nothing
                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading user profile: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        DateTimePickerStartDate.Value = Date.Today
        DateTimePickerEndDate.Value = Date.Today.AddDays(1)
        LoadLeaveTypes()
    End Sub

    Private Sub LoadLeaveTypes()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT TypeName FROM LeaveTypes ORDER BY TypeName"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ComboBoxLeaveType.Items.Clear()
                        While reader.Read()
                            ComboBoxLeaveType.Items.Add(reader("TypeName").ToString())
                        End While
                    End Using
                End Using

                If ComboBoxLeaveType.Items.Count > 0 Then
                    ComboBoxLeaveType.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading leave types: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim leaveType As String = ComboBoxLeaveType.SelectedItem?.ToString()
        Dim startDate As Date = DateTimePickerStartDate.Value
        Dim endDate As Date = DateTimePickerEndDate.Value
        Dim reason As String = TextBoxReason.Text

        If String.IsNullOrEmpty(leaveType) Then
            MessageBox.Show("Please select a leave type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If startDate > endDate Then
            MessageBox.Show("End date cannot be before start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'Incase of any error I will delete this line of code
        If startDate < Date.Today Then
            MessageBox.Show("Start date cannot be in the past!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(reason) Then
            MessageBox.Show("Please enter a reason for your leave.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim leaveDays As Integer = (endDate - startDate).Days + 1

        If Not CheckLeaveBalance(leaveDays) Then

            Return
        End If


        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Try
                    Dim query As String = "INSERT INTO LeaveApplications (EmployeeID, LeaveType, StartDate, EndDate, Reason, Status) " &
                                          "VALUES (@EmployeeID, @LeaveType, @StartDate, @EndDate, @Reason, 'Pending');"

                    Using command As New SqlCommand(query, connection, transaction)
                        command.Parameters.AddWithValue("@EmployeeID", employeeId)
                        command.Parameters.AddWithValue("@LeaveType", leaveType)
                        command.Parameters.AddWithValue("@StartDate", startDate)
                        command.Parameters.AddWithValue("@EndDate", endDate)
                        command.Parameters.AddWithValue("@Reason", reason)
                        command.ExecuteNonQuery()
                    End Using

                    If leaveType <> "Unpaid" Then
                        UpdateLeaveBalance(leaveDays, connection, transaction)
                    End If


                    transaction.Commit()
                    MessageBox.Show("Leave application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearFields()
                Catch ex As Exception
                    transaction.Rollback()
                    Throw
                End Try
            Catch ex As Exception
                MessageBox.Show("Error submitting leave application: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function CheckLeaveBalance(requestedDays As Integer) As Boolean
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim query As String = "SELECT DaysRemaining FROM EmployeeLeaveBalance WHERE EmployeeID = @EmployeeID"
                Dim currentBalance As Integer

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    Dim result = command.ExecuteScalar()

                    If IsDBNull(result) OrElse result Is Nothing Then
                        ' Initialize with 30 days
                        query = "INSERT INTO EmployeeLeaveBalance (EmployeeID, DaysRemaining) VALUES (@EmployeeID, 30)"
                        Using insertCmd As New SqlCommand(query, connection)
                            insertCmd.Parameters.AddWithValue("@EmployeeID", employeeId)
                            insertCmd.ExecuteNonQuery()
                        End Using
                        currentBalance = 30
                    Else
                        currentBalance = Convert.ToInt32(result)
                    End If
                End Using

                If requestedDays > currentBalance Then
                    MessageBox.Show($"Not enough leave days remaining. You have {currentBalance} days left but requested {requestedDays} days.",
                                "Insufficient Leave", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                End If

                Return True

            Catch ex As Exception
                MessageBox.Show("Error checking leave balance: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End Using
    End Function





    Private Sub UpdateLeaveBalance(usedDays As Integer, connection As SqlConnection, transaction As SqlTransaction)
        Dim query As String = "UPDATE EmployeeLeaveBalance SET DaysRemaining = DaysRemaining - @UsedDays " &
                          "WHERE EmployeeID = @EmployeeID"

        Using command As New SqlCommand(query, connection, transaction)
            command.Parameters.AddWithValue("@EmployeeID", employeeId)
            command.Parameters.AddWithValue("@UsedDays", usedDays)
            command.ExecuteNonQuery()
        End Using
    End Sub


    Private Sub ClearFields()
        If ComboBoxLeaveType.Items.Count > 0 Then
            ComboBoxLeaveType.SelectedIndex = 0
        End If
        DateTimePickerStartDate.Value = Date.Today
        DateTimePickerEndDate.Value = Date.Today.AddDays(1)
        TextBoxReason.Clear()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ClearFields()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim employeeForm As New employeeForm(loggedInUsername)
        employeeForm.Show()
        Me.Close()
    End Sub

    Private Sub DateTimePickerStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerStartDate.ValueChanged
        If DateTimePickerEndDate.Value < DateTimePickerStartDate.Value Then
            DateTimePickerEndDate.Value = DateTimePickerStartDate.Value
        End If
    End Sub

    Private Sub DateTimePickerEndDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerEndDate.ValueChanged
        If DateTimePickerEndDate.Value < DateTimePickerStartDate.Value Then
            MessageBox.Show("End date cannot be before start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePickerEndDate.Value = DateTimePickerStartDate.Value
        End If
    End Sub

    Private Sub TextUserNameLabel_Click(sender As Object, e As EventArgs) Handles TextUserNameLabel.Click
        ' Optional: Handle if needed
    End Sub


End Class