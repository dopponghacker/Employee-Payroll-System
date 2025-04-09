Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class PaymentHistory
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private employeeId As Integer
    Private loggedInUsername As String

    Public Sub New(empId As Integer, username As String)
        InitializeComponent()
        employeeId = empId
        loggedInUsername = username
    End Sub

    Private Sub PaymentHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage
        LoadUserProfile()
        InitializeDataGridView()
        LoadPaymentHistory()
        LoadYearFilters()
    End Sub

    Private Sub LoadUserProfile()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query = "SELECT e.FirstName, e.LastName, e.ProfilePicture 
                             FROM Employees e 
                             JOIN Accounts a ON e.EmployeeID = a.EmployeeID 
                             WHERE a.Username = @Username"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", loggedInUsername)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            TextUserNameLabel.Text = $"{reader("FirstName")} {reader("LastName")}"
                            If Not IsDBNull(reader("ProfilePicture")) Then
                                Dim bytes = CType(reader("ProfilePicture"), Byte())
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

    Private Sub InitializeDataGridView()
        With DataGridViewPaymentHistory
            .AutoGenerateColumns = False
            .AllowUserToAddRows = False
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersVisible = False
            .Columns.Clear()

            .Columns.Add("colPayrollID", "PayrollID")
            .Columns("colPayrollID").Visible = False

            .Columns.Add("colPayPeriod", "Pay Period")
            .Columns.Add("colBasicSalary", "Basic Salary")
            .Columns.Add("colNetSalary", "Net Salary")
            .Columns.Add("colStatus", "Status")

            .Columns("colBasicSalary").DefaultCellStyle.Format = "GHC,0.00"
            .Columns("colNetSalary").DefaultCellStyle.Format = "GHC,0.00"
        End With
    End Sub

    Private Sub LoadPaymentHistory(Optional yearFilter As String = "")
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query = "SELECT PayrollID, PayPeriod, BasicSalary, NetSalary, Status 
                             FROM Payroll 
                             WHERE EmployeeID = @EmployeeID"

                If Not String.IsNullOrEmpty(yearFilter) Then
                    query &= " AND PayPeriod LIKE @YearFilter"
                End If
                query &= " ORDER BY PayDate DESC"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    If Not String.IsNullOrEmpty(yearFilter) Then
                        command.Parameters.AddWithValue("@YearFilter", "%" & yearFilter & "%")
                    End If

                    Using reader As SqlDataReader = command.ExecuteReader()
                        DataGridViewPaymentHistory.Rows.Clear()
                        While reader.Read()
                            DataGridViewPaymentHistory.Rows.Add(
                                reader("PayrollID"),
                                reader("PayPeriod").ToString(),
                                Convert.ToDecimal(reader("BasicSalary")),
                                Convert.ToDecimal(reader("NetSalary")),
                                reader("Status").ToString()
                            )
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading payment history: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadYearFilters()
        ComboBoxFilteryear.Items.Clear()
        ComboBoxFilteryear.Items.Add("All Years")

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query = "SELECT DISTINCT RIGHT(PayPeriod, 4) AS Year 
                             FROM Payroll 
                             WHERE EmployeeID = @EmployeeID 
                             ORDER BY Year DESC"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ComboBoxFilteryear.Items.Add(reader("Year").ToString())
                        End While
                    End Using
                End Using

                ComboBoxFilteryear.SelectedIndex = 0
            Catch ex As Exception
                MessageBox.Show("Error loading year filters: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ComboBoxFilteryear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFilteryear.SelectedIndexChanged
        Dim selected = ComboBoxFilteryear.SelectedItem.ToString()
        LoadPaymentHistory(If(selected = "All Years", "", selected))
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim search = TextBoxSearch.Text.ToLower()
        For Each row As DataGridViewRow In DataGridViewPaymentHistory.Rows
            row.Visible = row.Cells.Cast(Of DataGridViewCell).Any(Function(c) c.Value IsNot Nothing AndAlso c.Value.ToString().ToLower().Contains(search))
        Next
    End Sub

    Private Sub PrintSelectedButton_Click(sender As Object, e As EventArgs) Handles PrintSelectedButton.Click
        If DataGridViewPaymentHistory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a payment record to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedRow = DataGridViewPaymentHistory.SelectedRows(0)
        Dim payrollIdObj = selectedRow.Cells("colPayrollID").Value

        If payrollIdObj IsNot Nothing AndAlso Integer.TryParse(payrollIdObj.ToString(), Nothing) Then
            Dim payrollId = Convert.ToInt32(payrollIdObj)
            Dim payslipForm As New ViewPaySlip(employeeId, loggedInUsername, payrollId)
            payslipForm.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Invalid Payroll ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ExportToExcelButton_Click(sender As Object, e As EventArgs) Handles ExportToExcelButton.Click
        Dim sfd As New SaveFileDialog With {
            .Filter = "CSV Files (*.csv)|*.csv",
            .FileName = "Payment_History_Export.csv"
        }

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Using sw As New StreamWriter(sfd.FileName)
                    ' Headers
                    Dim headers = DataGridViewPaymentHistory.Columns.Cast(Of DataGridViewColumn).
                        Where(Function(c) c.Visible).Select(Function(c) c.HeaderText)
                    sw.WriteLine(String.Join(",", headers))

                    ' Data rows
                    For Each row As DataGridViewRow In DataGridViewPaymentHistory.Rows
                        If row.Visible Then
                            Dim values = row.Cells.Cast(Of DataGridViewCell).
                                Where(Function(c) c.Visible).
                                Select(Function(c) If(c.Value IsNot Nothing, c.Value.ToString(), ""))
                            sw.WriteLine(String.Join(",", values))
                        End If
                    Next
                End Using

                MessageBox.Show("Export successful.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error exporting: " & ex.Message)
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

    Private Sub ViewPayslipButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class
