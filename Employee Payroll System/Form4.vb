Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Data.SqlClient

Public Class ClaimEntry
    Private connectionString As String = "Server=localhost;Database=PayrollSystem;Integrated Security=True;TrustServerCertificate=True"
    Private employeeId As Integer
    Private loggedInUsername As String
    Private filePath As String = Nothing

    Public Sub New(empId As Integer, username As String)
        InitializeComponent()
        employeeId = empId
        loggedInUsername = username
    End Sub

    Private Sub ClaimEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

                            If Not IsDBNull(reader("ProfilePicture")) AndAlso reader("ProfilePicture") IsNot Nothing Then
                                Dim profilePicBytes As Byte() = DirectCast(reader("ProfilePicture"), Byte())
                                Using ms As New MemoryStream(profilePicBytes)
                                    UserProfilePicture.Image = Image.FromStream(ms)
                                End Using
                            Else
                                UserProfilePicture.Image = Nothing
                            End If
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading profile picture: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        LoadClaimTypes()
        LoadPendingClaims()
    End Sub


    Private Sub LoadProfilePicture()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT e.ProfilePicture FROM Employees e " &
                                      "JOIN Accounts a ON e.EmployeeID = a.EmployeeID " &
                                      "WHERE a.Username = @Username"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", loggedInUsername)

                    Dim result = command.ExecuteScalar()
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        Dim profilePicBytes As Byte() = DirectCast(result, Byte())
                        Using ms As New MemoryStream(profilePicBytes)
                            UserProfilePicture.Image = Image.FromStream(ms)
                        End Using
                    Else
                        UserProfilePicture.Image = Nothing
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading profile picture: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LoadClaimTypes()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                ' Check if ClaimTypes table is empty
                Dim countQuery As String = "SELECT COUNT(*) FROM ClaimTypes"
                Using countCmd As New SqlCommand(countQuery, connection)
                    Dim count As Integer = Convert.ToInt32(countCmd.ExecuteScalar())
                    If count = 0 Then
                        Dim insertDefaults As String = "
                            INSERT INTO ClaimTypes (TypeName) VALUES
                            ('Medical Reimbursement'),
                            ('Transport Reimbursement'),
                            ('Fuel Allowance'),
                            ('Mobile Allowance'),
                            ('Internet Reimbursement'),
                            ('Client Entertainment'),
                            ('Travel Expenses'),
                            ('Training/Certification Fees'),
                            ('Office Supplies'),
                            ('Uniform Reimbursement')"
                        Using insertCmd As New SqlCommand(insertDefaults, connection)
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using

                ' Load claim types
                Dim query As String = "SELECT TypeName FROM ClaimTypes ORDER BY TypeName"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ComboBoxClaimType.Items.Clear()
                        While reader.Read()
                            ComboBoxClaimType.Items.Add(reader("TypeName").ToString())
                        End While
                    End Using
                End Using

                If ComboBoxClaimType.Items.Count > 0 Then
                    ComboBoxClaimType.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading claim types: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub FileUploadButton_Click(sender As Object, e As EventArgs) Handles FileUploadButton.Click
        Dim openFileDialog As New OpenFileDialog() With {
            .Title = "Select Supporting Document",
            .Filter = "PDF Files (*.pdf)|*.pdf|Word Documents (*.doc;*.docx)|*.doc;*.docx|Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png",
            .Multiselect = False
        }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            filePath = openFileDialog.FileName
            MessageBox.Show("File uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub SubmitClaimButton_Click(sender As Object, e As EventArgs) Handles SubmitClaimButton.Click
        Dim claimType As String = ComboBoxClaimType.SelectedItem?.ToString()
        Dim claimAmount As Decimal
        Dim description As String = TextBoxDescription.Text

        If String.IsNullOrEmpty(claimType) Then
            MessageBox.Show("Please select a claim type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not Decimal.TryParse(TextBoxAmount.Text, claimAmount) OrElse claimAmount <= 0 Then
            MessageBox.Show("Please enter a valid claim amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If String.IsNullOrWhiteSpace(description) Then
            MessageBox.Show("Please enter a description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If filePath Is Nothing Then
            MessageBox.Show("Please upload a supporting document.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Claims (EmployeeID, ClaimType, ClaimAmount, Description, FilePath, Status, ClaimDate) " &
                                      "VALUES (@EmployeeID, @ClaimType, @ClaimAmount, @Description, @FilePath, 'Pending', @ClaimDate)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    command.Parameters.AddWithValue("@ClaimType", claimType)
                    command.Parameters.AddWithValue("@ClaimAmount", claimAmount)
                    command.Parameters.AddWithValue("@Description", description)
                    command.Parameters.AddWithValue("@FilePath", filePath)
                    command.Parameters.AddWithValue("@ClaimDate", DateTime.Now)

                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Claim submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearFields()
                        LoadPendingClaims()
                    Else
                        MessageBox.Show("Failed to submit claim.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error submitting claim: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub LoadPendingClaims()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT ClaimID, ClaimType, ClaimAmount, Description, ClaimDate " &
                                      "FROM Claims " &
                                      "WHERE EmployeeID = @EmployeeID AND Status = 'Pending' " &
                                      "ORDER BY ClaimDate DESC"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeID", employeeId)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    PendingClaimsDataGridView.AutoGenerateColumns = False
                    PendingClaimsDataGridView.Columns.Clear()

                    Dim idCol As New DataGridViewTextBoxColumn()
                    idCol.Name = "colClaimID"
                    idCol.HeaderText = "Claim ID"
                    idCol.DataPropertyName = "ClaimID"
                    idCol.Visible = False
                    PendingClaimsDataGridView.Columns.Add(idCol)

                    Dim typeCol As New DataGridViewTextBoxColumn()
                    typeCol.Name = "colClaimType"
                    typeCol.HeaderText = "Type"
                    typeCol.DataPropertyName = "ClaimType"
                    PendingClaimsDataGridView.Columns.Add(typeCol)

                    Dim amountCol As New DataGridViewTextBoxColumn()
                    amountCol.Name = "colClaimAmount"
                    amountCol.HeaderText = "Amount"
                    amountCol.DataPropertyName = "ClaimAmount"
                    amountCol.DefaultCellStyle.Format = "C2"
                    PendingClaimsDataGridView.Columns.Add(amountCol)

                    Dim dateCol As New DataGridViewTextBoxColumn()
                    dateCol.Name = "colClaimDate"
                    dateCol.HeaderText = "Date"
                    dateCol.DataPropertyName = "ClaimDate"
                    dateCol.DefaultCellStyle.Format = "dd/MM/yyyy"
                    PendingClaimsDataGridView.Columns.Add(dateCol)

                    PendingClaimsDataGridView.DataSource = table
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading pending claims: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub ClearFields()
        If ComboBoxClaimType.Items.Count > 0 Then
            ComboBoxClaimType.SelectedIndex = 0
        End If
        TextBoxAmount.Clear()
        TextBoxDescription.Clear()
        filePath = Nothing
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Dim employeeForm As New employeeForm(loggedInUsername)
        employeeForm.Show()
        Me.Close()
    End Sub

    Private Sub PendingClaimsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PendingClaimsDataGridView.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow = PendingClaimsDataGridView.Rows(e.RowIndex)
            Dim claimId As Integer = Convert.ToInt32(selectedRow.Cells("colClaimID").Value)
            Dim claimDetails As String = $"Claim Type: {selectedRow.Cells("colClaimType").Value}" & vbCrLf &
                                         $"Amount: {selectedRow.Cells("colClaimAmount").Value:C2}" & vbCrLf &
                                         $"Date: {selectedRow.Cells("colClaimDate").Value:dd/MM/yyyy}"
            MessageBox.Show(claimDetails, "Claim Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ViewPendingClaimsButton_Click(sender As Object, e As EventArgs) Handles ViewPendingClaimsButton.Click
        LoadPendingClaims()
    End Sub


End Class
