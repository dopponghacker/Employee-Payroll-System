Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class AttendanceDetails
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private employeeId As Integer
    Private loggedInUsername As String

    Public Sub New(empId As Integer, username As String)
        InitializeComponent()
        employeeId = empId
        loggedInUsername = username
    End Sub

    Private Sub AttendanceDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set PictureBox mode
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        ' Load profile picture
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT e.ProfilePicture " &
                                      "FROM Employees e " &
                                      "JOIN Accounts a ON e.EmployeeID = a.EmployeeID " &
                                      "WHERE a.Username = @Username"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", loggedInUsername)
                    Dim result = command.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        Dim picBytes As Byte() = DirectCast(result, Byte())
                        Using ms As New MemoryStream(picBytes)
                            UserProfilePicture.Image = Image.FromStream(ms)
                        End Using
                    Else
                        UserProfilePicture.Image = Nothing ' Or set default image here
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading profile picture: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        ' Set form title and default filters
        Me.Text = "Attendance Records - " & loggedInUsername
        DateTimePickerStartDate.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        DateTimePickerEndDate.Value = DateTime.Now
        SetupDataGridView()
        LoadAttendanceData()
    End Sub

    Private Sub SetupDataGridView()
        DataGridViewAttendance.Columns.Clear()

        Dim cols As DataGridViewColumn() = {
            New DataGridViewTextBoxColumn() With {
                .Name = "colDate",
                .HeaderText = "Date",
                .Width = 100,
                .DefaultCellStyle = New DataGridViewCellStyle() With {
                    .Format = "yyyy-MM-dd",
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "colStatus",
                .HeaderText = "Status",
                .Width = 80,
                .DefaultCellStyle = New DataGridViewCellStyle() With {
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            },
            New DataGridViewTextBoxColumn() With {
                .Name = "colRemarks",
                .HeaderText = "Remarks",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            }
        }

        DataGridViewAttendance.Columns.AddRange(cols)
        DataGridViewAttendance.ReadOnly = True
        DataGridViewAttendance.AllowUserToAddRows = False
    End Sub

    Private Sub LoadAttendanceData()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT AttendanceDate AS Date, Status, Remarks " &
                                  "FROM Attendance " &
                                  "WHERE EmployeeID = @EmployeeID " &
                                  "AND AttendanceDate BETWEEN @StartDate AND @EndDate " &
                                  "ORDER BY AttendanceDate DESC"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    command.Parameters.AddWithValue("@StartDate", DateTimePickerStartDate.Value.Date)
                    command.Parameters.AddWithValue("@EndDate", DateTimePickerEndDate.Value.Date)

                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Show placeholder row if no data exists
                    If table.Rows.Count = 0 Then
                        table.Columns.Clear()
                        table.Columns.Add("Date")
                        table.Columns.Add("Status")
                        table.Columns.Add("Remarks")
                        table.Rows.Add("N/A", "No records found", "You have no attendance records yet.")
                    End If

                    DataGridViewAttendance.DataSource = table
                    ApplyStatusColorCoding()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading attendance records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ApplyStatusColorCoding()
        For Each row As DataGridViewRow In DataGridViewAttendance.Rows
            If Not row.IsNewRow AndAlso row.Cells("colStatus").Value IsNot Nothing Then
                Select Case row.Cells("colStatus").Value.ToString().ToLower()
                    Case "present"
                        row.DefaultCellStyle.BackColor = Color.LightGreen
                    Case "absent"
                        row.DefaultCellStyle.BackColor = Color.LightPink
                    Case "late"
                        row.DefaultCellStyle.BackColor = Color.LightYellow
                    Case "on leave"
                        row.DefaultCellStyle.BackColor = Color.LightBlue
                End Select
            End If
        Next
    End Sub

    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
        If DateTimePickerStartDate.Value > DateTimePickerEndDate.Value Then
            MessageBox.Show("End date cannot be before start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        LoadAttendanceData()
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        Try
            SaveFileDialog1.Filter = "CSV Files (*.csv)|*.csv"
            SaveFileDialog1.FileName = $"Attendance_{loggedInUsername}_{DateTime.Now:yyyyMMdd}.csv"

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Using writer As New StreamWriter(SaveFileDialog1.FileName)
                    writer.WriteLine("Date,Status,Remarks")
                    For Each row As DataGridViewRow In DataGridViewAttendance.Rows
                        If Not row.IsNewRow Then
                            writer.WriteLine($"{row.Cells("colDate").Value}," &
                                             $"{row.Cells("colStatus").Value}," &
                                             $"{row.Cells("colRemarks").Value}")
                        End If
                    Next
                End Using

                MessageBox.Show("Attendance data exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim employeeForm As New employeeForm(loggedInUsername)
        employeeForm.Show()
        Me.Close()
    End Sub

    Private Sub DateTimePickerStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerStartDate.ValueChanged
        If DateTimePickerStartDate.Value > DateTimePickerEndDate.Value Then
            DateTimePickerEndDate.Value = DateTimePickerStartDate.Value
        End If
    End Sub

    Private Sub DateTimePickerEndDate_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerEndDate.ValueChanged
        If DateTimePickerEndDate.Value < DateTimePickerStartDate.Value Then
            MessageBox.Show("End date cannot be before start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePickerEndDate.Value = DateTimePickerStartDate.Value
        End If
    End Sub

    Private Sub TextBoxSummary_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
