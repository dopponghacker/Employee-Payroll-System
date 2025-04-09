Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class PayGeneration
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private employeeId As Integer
    Private loggedInUsername As String
    Private currentPayPeriod As String

    Public Sub New(empId As Integer, username As String)
        InitializeComponent()
        employeeId = empId
        loggedInUsername = username
    End Sub

    Private Sub PayGeneration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        LoadUserProfile()
        InitializeForm()
        LoadSalariesByCategory()
        CalculateNetSalary()
    End Sub

    Private Sub LoadUserProfile()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT e.FirstName, e.LastName, e.ProfilePicture " &
                                      "FROM Employees e " &
                                      "JOIN Accounts a ON e.EmployeeID = a.EmployeeID " &
                                      "WHERE a.Username = @Username"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", loggedInUsername)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            Dim fullName As String = reader("FirstName").ToString() & " " & reader("LastName").ToString()
                            TextUserNameLabel.Text = fullName

                            If Not IsDBNull(reader("ProfilePicture")) Then
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
    End Sub

    Private Sub InitializeForm()
        TextDateLabel.Text = DateTime.Now.ToString("dd MMMM yyyy")
        currentPayPeriod = DateTime.Now.ToString("MMMM yyyy")

        TextBoxBasicSalary.ReadOnly = True
        TextBoxAllowance.ReadOnly = True
        TextBoxDeductions.ReadOnly = True
        TextBoxNetSalary.ReadOnly = True

        TextNetSalaryLabel.Font = New Font(TextNetSalaryLabel.Font, FontStyle.Bold)
        TextBoxNetSalary.Font = New Font(TextBoxNetSalary.Font.FontFamily, 10, FontStyle.Bold)
        TextBoxNetSalary.ForeColor = Color.Green
    End Sub

    Private Sub LoadSalariesByCategory()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim categoryQuery As String = "SELECT Category FROM Employees WHERE EmployeeID = @EmployeeID"
                Dim category As String = ""

                Using command As New SqlCommand(categoryQuery, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing Then category = result.ToString()
                End Using

                ' Assign salary based on category
                Dim basicSalary As Decimal = 0
                Dim allowance As Decimal = 0
                Dim deduction As Decimal = 0

                Select Case category.ToLower()
                    Case "junior"
                        basicSalary = 40000
                        allowance = 10000
                        deduction = 3000
                    Case "mid"
                        basicSalary = 70000
                        allowance = 20000
                        deduction = 5000
                    Case "senior"
                        basicSalary = 100000
                        allowance = 30000
                        deduction = 8000
                    Case Else
                        basicSalary = 50000
                        allowance = 15000
                        deduction = 4000
                End Select

                TextBoxBasicSalary.Text = basicSalary.ToString("N2")
                TextBoxAllowance.Text = allowance.ToString("N2")
                TextBoxDeductions.Text = deduction.ToString("N2")

            Catch ex As Exception
                MessageBox.Show("Error loading salaries by category: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub CalculateNetSalary()
        Try
            Dim basic = If(String.IsNullOrEmpty(TextBoxBasicSalary.Text), 0, Decimal.Parse(TextBoxBasicSalary.Text))
            Dim allowances = If(String.IsNullOrEmpty(TextBoxAllowance.Text), 0, Decimal.Parse(TextBoxAllowance.Text))
            Dim deductions = If(String.IsNullOrEmpty(TextBoxDeductions.Text), 0, Decimal.Parse(TextBoxDeductions.Text))

            Dim netSalary = basic + allowances - deductions
            TextBoxNetSalary.Text = netSalary.ToString("N2")

            If netSalary < 0 Then
                TextBoxNetSalary.ForeColor = Color.Red
                TextNetSalaryLabel.ForeColor = Color.Red
            Else
                TextBoxNetSalary.ForeColor = Color.Green
                TextNetSalaryLabel.ForeColor = SystemColors.ControlText
            End If
        Catch ex As FormatException
            MessageBox.Show("Invalid number format in salary components", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub GeneratePaySlipButton_Click(sender As Object, e As EventArgs) Handles GeneratePaySlipButton.Click
        If Decimal.Parse(TextBoxNetSalary.Text) <= 0 Then
            MessageBox.Show("Net salary must be positive to generate payslip", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim transaction As SqlTransaction = connection.BeginTransaction()

                Try
                    Dim payrollId As Integer = InsertPayrollHeader(connection, transaction)
                    transaction.Commit()

                    MessageBox.Show("Payslip generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error generating payslip: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Catch ex As Exception
                MessageBox.Show("Error connecting to database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Function InsertPayrollHeader(conn As SqlConnection, trans As SqlTransaction) As Integer
        Dim query = "INSERT INTO Payroll (EmployeeID, PayPeriod, PayDate, BasicSalary, Allowances, Deductions, NetSalary, Status) " &
                    "VALUES (@EmployeeID, @PayPeriod, @PayDate, @BasicSalary, @Allowances, @Deductions, @NetSalary, 'Generated'); " &
                    "SELECT SCOPE_IDENTITY();"

        Using cmd As New SqlCommand(query, conn, trans)
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId)
            cmd.Parameters.AddWithValue("@PayPeriod", currentPayPeriod)
            cmd.Parameters.AddWithValue("@PayDate", DateTime.Now)
            cmd.Parameters.AddWithValue("@BasicSalary", Decimal.Parse(TextBoxBasicSalary.Text))
            cmd.Parameters.AddWithValue("@Allowances", Decimal.Parse(TextBoxAllowance.Text))
            cmd.Parameters.AddWithValue("@Deductions", Decimal.Parse(TextBoxDeductions.Text))
            cmd.Parameters.AddWithValue("@NetSalary", Decimal.Parse(TextBoxNetSalary.Text))
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub ClearForm()
        TextBoxBasicSalary.Text = "0.00"
        TextBoxAllowance.Text = "0.00"
        TextBoxDeductions.Text = "0.00"
        TextBoxNetSalary.Text = "0.00"
    End Sub

    Private Sub PaymentHistoryButton_Click(sender As Object, e As EventArgs) Handles PaymentHistoryButton.Click
        Dim historyForm As New PaymentHistory(employeeId, loggedInUsername)
        historyForm.Show()
        Me.Hide()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim employeeForm As New employeeForm(loggedInUsername)
        employeeForm.Show()
        Me.Close()
    End Sub

    Private Sub SalaryComponent_TextChanged(sender As Object, e As EventArgs) Handles _
        TextBoxBasicSalary.TextChanged,
        TextBoxAllowance.TextChanged,
        TextBoxDeductions.TextChanged
        CalculateNetSalary()
    End Sub

    Private Sub TextPayGenerationLabel_Click(sender As Object, e As EventArgs) Handles TextPayGenerationLabel.Click
        ' Optional label click handler
    End Sub
End Class
