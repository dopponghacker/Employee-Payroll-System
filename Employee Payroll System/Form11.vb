Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient
Imports DrawingImage = System.Drawing.Image
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ViewPaySlip
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private employeeId As Integer
    Private loggedInUsername As String
    Private paySlipId As Integer

    Public Sub New(empId As Integer, username As String, Optional paySlipID As Integer = 0)
        InitializeComponent()
        employeeId = empId
        loggedInUsername = username
        Me.paySlipId = paySlipID
    End Sub

    Private Sub ViewPaySlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        LoadUserProfile()
        LoadPaySlipData()
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
                                Dim bytes = DirectCast(reader("ProfilePicture"), Byte())
                                Using ms As New MemoryStream(bytes)
                                    UserProfilePicture.Image = DrawingImage.FromStream(ms)
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

    Private Sub LoadPaySlipData()
        If paySlipId <= 0 Then
            MessageBox.Show("No payroll ID was provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query = "SELECT p.PayPeriod, p.BasicSalary, p.Allowances, p.Deductions, p.NetSalary, e.FirstName, e.LastName, e.Position " &
                            "FROM Payroll p JOIN Employees e ON p.EmployeeID = e.EmployeeID " &
                            "WHERE p.PayrollID = @PaySlipID AND p.EmployeeID = @EmployeeID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@PaySlipID", paySlipId)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            TextEmployeeName.Text = $"{reader("FirstName")} {reader("LastName")}"
                            TextPosition.Text = reader("Position").ToString()
                            TextPayPeriod.Text = reader("PayPeriod").ToString()
                            TextBasicSalary.Text = $"GHC{Convert.ToDecimal(reader("BasicSalary")):N2}"
                            TextAllowances.Text = $"GHC{Convert.ToDecimal(reader("Allowances")):N2}"
                            TextDeductions.Text = $"GHC{Convert.ToDecimal(reader("Deductions")):N2}"
                            TextNetSalary.Text = $"GHC{Convert.ToDecimal(reader("NetSalary")):N2}"

                            TextNetSalary.ForeColor = If(Convert.ToDecimal(reader("NetSalary")) < 0, Color.Red, Color.Green)
                        Else
                            MessageBox.Show("Pay slip not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading pay slip: " & ex.Message)
                Me.Close()
            End Try
        End Using
    End Sub

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        SaveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf"
        SaveFileDialog1.FileName = $"PaySlip_{loggedInUsername}_{DateTime.Now:yyyyMMdd}.pdf"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim doc As New Document()
                PdfWriter.GetInstance(doc, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                doc.Open()

                ' Fonts
                Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD)
                Dim contentFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12)

                ' Title
                doc.Add(New Paragraph($"PAY SLIP FOR {TextPayPeriod.Text}", titleFont))
                doc.Add(New Paragraph(Environment.NewLine))

                ' Employee Info
                doc.Add(New Paragraph($"Employee: {TextEmployeeName.Text}", contentFont))
                doc.Add(New Paragraph($"Position: {TextPosition.Text}", contentFont))
                doc.Add(New Paragraph(Environment.NewLine))

                ' Salary Info
                doc.Add(New Paragraph($"Basic Salary: {TextBasicSalary.Text}", contentFont))
                doc.Add(New Paragraph($"Allowances: {TextAllowances.Text}", contentFont))
                doc.Add(New Paragraph($"Deductions: {TextDeductions.Text}", contentFont))
                doc.Add(New Paragraph(Environment.NewLine))

                ' Net Salary Formatting
                Dim netSalaryValue As Decimal = Decimal.Parse(TextNetSalary.Text.Replace("GHC", "").Trim())
                Dim netSalaryColor = If(netSalaryValue < 0, BaseColor.RED, BaseColor.GREEN)
                Dim netSalaryFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, netSalaryColor)
                doc.Add(New Paragraph($"NET SALARY: GHC{netSalaryValue:N2}", netSalaryFont))

                doc.Close()

                MessageBox.Show("Pay slip saved as PDF successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving PDF: " & ex.Message)
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
