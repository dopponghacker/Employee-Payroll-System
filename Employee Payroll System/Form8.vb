Imports Microsoft.Data.SqlClient
Imports System.IO

Public Class LoanEntry
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private employeeId As Integer
    Private loggedInUsername As String
    Private profilePictureBytes As Byte() = Nothing

    Public Sub New(empId As Integer, username As String)
        InitializeComponent()
        employeeId = empId
        loggedInUsername = username
    End Sub

    Private Sub LoanEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        LoadUserProfile()
        InitializeForm()
        LoadLoanHistory()
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
                                profilePictureBytes = DirectCast(reader("ProfilePicture"), Byte())
                                Using ms As New MemoryStream(profilePictureBytes)
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
        ComboBoxLoanType.Items.AddRange({"Personal Loan", "Emergency Loan", "Education Loan", "Housing Loan", "Medical Loan"})
        ComboBoxLoanType.SelectedIndex = 0

        TextBoxAmount.Text = "0.00"
        TextBoxAmount.ForeColor = Color.Gray

        TextBoxReason.Multiline = True
        TextBoxReason.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub LoadLoanHistory()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT LoanID, LoanType, Amount, ApplicationDate, Status " &
                                      "FROM Loans " &
                                      "WHERE EmployeeID = @EmployeeID " &
                                      "ORDER BY ApplicationDate DESC"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    DataGridViewLoanHistory.AutoGenerateColumns = False
                    DataGridViewLoanHistory.Columns.Clear()

                    Dim idCol As New DataGridViewTextBoxColumn()
                    idCol.Name = "colLoanID"
                    idCol.HeaderText = "Loan ID"
                    idCol.DataPropertyName = "LoanID"
                    DataGridViewLoanHistory.Columns.Add(idCol)

                    Dim typeCol As New DataGridViewTextBoxColumn()
                    typeCol.Name = "colLoanType"
                    typeCol.HeaderText = "Type"
                    typeCol.DataPropertyName = "LoanType"
                    DataGridViewLoanHistory.Columns.Add(typeCol)

                    Dim amountCol As New DataGridViewTextBoxColumn()
                    amountCol.Name = "colAmount"
                    amountCol.HeaderText = "Amount"
                    amountCol.DataPropertyName = "Amount"
                    amountCol.DefaultCellStyle.Format = "C2"
                    DataGridViewLoanHistory.Columns.Add(amountCol)

                    Dim dateCol As New DataGridViewTextBoxColumn()
                    dateCol.Name = "colApplicationDate"
                    dateCol.HeaderText = "Application Date"
                    dateCol.DataPropertyName = "ApplicationDate"
                    dateCol.DefaultCellStyle.Format = "dd/MM/yyyy"
                    DataGridViewLoanHistory.Columns.Add(dateCol)

                    Dim statusCol As New DataGridViewTextBoxColumn()
                    statusCol.Name = "colStatus"
                    statusCol.HeaderText = "Status"
                    statusCol.DataPropertyName = "Status"
                    DataGridViewLoanHistory.Columns.Add(statusCol)

                    DataGridViewLoanHistory.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading loan history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim loanType As String = ComboBoxLoanType.SelectedItem?.ToString()
        Dim amount As Decimal
        Dim reason As String = TextBoxReason.Text

        If String.IsNullOrEmpty(loanType) Then
            MessageBox.Show("Please select a loan type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Decimal.TryParse(TextBoxAmount.Text, amount) OrElse amount <= 0 Then
            MessageBox.Show("Please enter a valid loan amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(reason) Then
            MessageBox.Show("Please enter a reason for the loan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Loans (EmployeeID, LoanType, Amount, ApplicationDate, Reason, Status) " &
                                      "VALUES (@EmployeeID, @LoanType, @Amount, @ApplicationDate, @Reason, 'Pending')"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    command.Parameters.AddWithValue("@LoanType", loanType)
                    command.Parameters.AddWithValue("@Amount", amount)
                    command.Parameters.AddWithValue("@ApplicationDate", DateTime.Now)
                    command.Parameters.AddWithValue("@Reason", reason)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Loan application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearFields()
                        LoadLoanHistory()
                    Else
                        MessageBox.Show("Failed to submit loan application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error submitting loan application: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ClearFields()
        If ComboBoxLoanType.Items.Count > 0 Then
            ComboBoxLoanType.SelectedIndex = 0
        End If
        TextBoxAmount.Text = "0.00"
        TextBoxAmount.ForeColor = Color.Gray
        TextBoxReason.Clear()
    End Sub

    Private Sub TextBoxAmount_Enter(sender As Object, e As EventArgs) Handles TextBoxAmount.Enter
        If TextBoxAmount.Text = "0.00" Then
            TextBoxAmount.Text = ""
            TextBoxAmount.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBoxAmount_Leave(sender As Object, e As EventArgs) Handles TextBoxAmount.Leave
        If String.IsNullOrEmpty(TextBoxAmount.Text) Then
            TextBoxAmount.Text = "0.00"
            TextBoxAmount.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim employeeForm As New employeeForm(loggedInUsername)
        employeeForm.Show()
        Me.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel Loan Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ClearFields()
        End If
    End Sub

    Private Sub DataGridViewLoanHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLoanHistory.CellContentClick
        ' Optional: Handle click on loan record
    End Sub
End Class
