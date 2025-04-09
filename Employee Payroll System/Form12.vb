Imports System.Data.SqlClient
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.Data.SqlClient
Imports System.Drawing
Imports Image = System.Drawing.Image
Imports Font = System.Drawing.Font
Imports iText.Kernel.Geom
Imports PageSize = iTextSharp.text.PageSize


Public Class ViewReport
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private employeeId As Integer
    Private loggedInUsername As String

    Public Sub New(empId As Integer, username As String)
        InitializeComponent()
        employeeId = empId
        loggedInUsername = username
    End Sub

    Private Sub ViewReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage
        LoadUserProfile()
        InitializeForm()
        LoadMonthYearOptions()
        LoadCombinedReport()
    End Sub

    Private Sub LoadUserProfile()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query = "SELECT e.FirstName, e.LastName, e.ProfilePicture FROM Employees e JOIN Accounts a ON e.EmployeeID = a.EmployeeID WHERE a.Username = @Username"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", loggedInUsername)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            TextUserNameLabel.Text = $"{reader("FirstName")} {reader("LastName")}"
                            If Not IsDBNull(reader("ProfilePicture")) Then
                                Dim bytes As Byte() = CType(reader("ProfilePicture"), Byte())
                                Using ms As New MemoryStream(bytes)
                                    UserProfilePicture.Image = Image.FromStream(ms)
                                End Using
                            Else
                                UserProfilePicture.Image = Nothing
                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading profile: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub InitializeForm()
        TextViewReportsLabel.Text = "View Reports"
        TextViewReportsLabel.Font = New Font(TextViewReportsLabel.Font, FontStyle.Bold)

        With DataGridViewViewReport
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToAddRows = False
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub LoadMonthYearOptions()
        Try
            ComboBoxSelectMonthYear.Items.Clear()
            ComboBoxSelectMonthYear.Items.Add("All Records")

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query = "
                    SELECT DISTINCT FORMAT(AttendanceDate, 'MMMM yyyy') AS Period FROM Attendance WHERE EmployeeID = @EmployeeID
                    UNION
                    SELECT DISTINCT FORMAT(StartDate, 'MMMM yyyy') AS Period FROM LeaveApplications WHERE EmployeeID = @EmployeeID
                    ORDER BY Period DESC"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ComboBoxSelectMonthYear.Items.Add(reader("Period").ToString())
                        End While
                    End Using
                End Using
            End Using

            ComboBoxSelectMonthYear.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error loading period options: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadCombinedReport()
        Try
            Dim selectedPeriod = ComboBoxSelectMonthYear.SelectedItem.ToString()
            Dim isAttendance = RadioButtonAttendanceReport.Checked
            Dim filterPeriod As String = ""

            If selectedPeriod <> "All Records" Then
                filterPeriod = $"AND FORMAT({If(isAttendance, "AttendanceDate", "StartDate")}, 'MMMM yyyy') = '{selectedPeriod}'"
            End If

            Dim query As String = ""

            If isAttendance Then
                query = "
            SELECT AttendanceDate AS [Date], CheckIn, CheckOut, Status
            FROM Attendance
            WHERE EmployeeID = @EmployeeID " & filterPeriod
            Else
                query = "
            SELECT StartDate AS [Date], LeaveType, Status, EndDate, Comments
            FROM LeaveApplications
            WHERE EmployeeID = @EmployeeID " & filterPeriod
            End If

            Using connection As New SqlConnection(connectionString)
                Dim adapter As New SqlDataAdapter(query, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@EmployeeID", employeeId)

                Dim table As New DataTable()
                adapter.Fill(table)

                ' Add dummy row for empty attendance
                If isAttendance AndAlso table.Rows.Count = 0 Then
                    Dim dummyRow = table.NewRow()
                    dummyRow("Date") = Date.Today
                    dummyRow("Status") = "No attendance record found."
                    table.Rows.InsertAt(dummyRow, 0)
                End If

                DataGridViewViewReport.DataSource = Nothing
                DataGridViewViewReport.AutoGenerateColumns = True
                DataGridViewViewReport.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading report data: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateColumnVisibility()
        If DataGridViewViewReport.Columns.Count = 0 Then Return

        If RadioButtonAttendanceReport.Checked Then
            DataGridViewViewReport.Columns("colCheckIn").Visible = True
            DataGridViewViewReport.Columns("colCheckOut").Visible = True
            DataGridViewViewReport.Columns("colLeaveType").Visible = False
            DataGridViewViewReport.Columns("colEndDate").Visible = False
            DataGridViewViewReport.Columns("colComments").Visible = False
        ElseIf RadioButtonLeaveReport.Checked Then
            DataGridViewViewReport.Columns("colLeaveType").Visible = True
            DataGridViewViewReport.Columns("colEndDate").Visible = True
            DataGridViewViewReport.Columns("colComments").Visible = True
            DataGridViewViewReport.Columns("colCheckIn").Visible = False
            DataGridViewViewReport.Columns("colCheckOut").Visible = False
        End If
    End Sub

    Private Sub RadioButtonAttendanceReport_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAttendanceReport.CheckedChanged
        If RadioButtonAttendanceReport.Checked Then
            LoadCombinedReport()
        End If
    End Sub

    Private Sub RadioButtonLeaveReport_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonLeaveReport.CheckedChanged
        If RadioButtonLeaveReport.Checked Then
            LoadCombinedReport()
        End If
    End Sub


    Private Sub ComboBoxSelectMonthYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSelectMonthYear.SelectedIndexChanged
        LoadCombinedReport()
    End Sub

    ' ✅ Export to PDF Function
    Private Sub ExportToPDFButton_Click(sender As Object, e As EventArgs) Handles ExportToPDFButton.Click
        Dim sfd As New SaveFileDialog With {
            .Filter = "PDF Files (*.pdf)|*.pdf",
            .FileName = "ReportExport.pdf"
        }

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Dim pdfDoc As New Document(PageSize.A4, 10, 10, 10, 10)
                PdfWriter.GetInstance(pdfDoc, New FileStream(sfd.FileName, FileMode.Create))
                pdfDoc.Open()

                Dim table As New PdfPTable(DataGridViewViewReport.Columns.Count)
                For Each column As DataGridViewColumn In DataGridViewViewReport.Columns
                    table.AddCell(New Phrase(column.HeaderText))
                Next

                For Each row As DataGridViewRow In DataGridViewViewReport.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        table.AddCell(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""))
                    Next
                Next

                pdfDoc.Add(table)
                pdfDoc.Close()

                MessageBox.Show("Exported to PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error exporting PDF: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim empForm As New employeeForm(loggedInUsername)
        empForm.Show()
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class
