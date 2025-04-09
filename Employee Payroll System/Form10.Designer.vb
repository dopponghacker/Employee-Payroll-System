<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentHistory))
        HomeButton = New Button()
        PrintSelectedButton = New Button()
        ExportToExcelButton = New Button()
        TextBoxSearch = New TextBox()
        TextSearchLabel = New Label()
        Panel1 = New Panel()
        UserProfilePicture = New PictureBox()
        TextPaymentHistoryLabel = New Label()
        TextUserNameLabel = New Label()
        ComboBoxFilteryear = New ComboBox()
        TextFilterYearLabel = New Label()
        DataGridViewPaymentHistory = New DataGridView()
        CloseButton = New Button()
        SaveFileDialog1 = New SaveFileDialog()
        Panel1.SuspendLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewPaymentHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HomeButton
        ' 
        HomeButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(794, 553)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(181, 76)
        HomeButton.TabIndex = 6
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = False
        ' 
        ' PrintSelectedButton
        ' 
        PrintSelectedButton.BackColor = Color.LimeGreen
        PrintSelectedButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PrintSelectedButton.ForeColor = Color.White
        PrintSelectedButton.Location = New Point(97, 562)
        PrintSelectedButton.Name = "PrintSelectedButton"
        PrintSelectedButton.Size = New Size(199, 62)
        PrintSelectedButton.TabIndex = 3
        PrintSelectedButton.Text = "Print Selected"
        PrintSelectedButton.UseVisualStyleBackColor = False
        ' 
        ' ExportToExcelButton
        ' 
        ExportToExcelButton.BackColor = Color.DodgerBlue
        ExportToExcelButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExportToExcelButton.ForeColor = Color.White
        ExportToExcelButton.Location = New Point(332, 561)
        ExportToExcelButton.Name = "ExportToExcelButton"
        ExportToExcelButton.Size = New Size(190, 63)
        ExportToExcelButton.TabIndex = 4
        ExportToExcelButton.Text = "Export to Excel"
        ExportToExcelButton.UseVisualStyleBackColor = False
        ' 
        ' TextBoxSearch
        ' 
        TextBoxSearch.BackColor = Color.DodgerBlue
        TextBoxSearch.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBoxSearch.ForeColor = Color.White
        TextBoxSearch.Location = New Point(240, 87)
        TextBoxSearch.Multiline = True
        TextBoxSearch.Name = "TextBoxSearch"
        TextBoxSearch.Size = New Size(256, 53)
        TextBoxSearch.TabIndex = 1
        ' 
        ' TextSearchLabel
        ' 
        TextSearchLabel.AutoSize = True
        TextSearchLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextSearchLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextSearchLabel.Location = New Point(132, 94)
        TextSearchLabel.Name = "TextSearchLabel"
        TextSearchLabel.Size = New Size(102, 41)
        TextSearchLabel.TabIndex = 57
        TextSearchLabel.Text = "Search"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(UserProfilePicture)
        Panel1.Controls.Add(TextPaymentHistoryLabel)
        Panel1.Controls.Add(TextUserNameLabel)
        Panel1.Location = New Point(-34, -15)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1215, 81)
        Panel1.TabIndex = 62
        ' 
        ' UserProfilePicture
        ' 
        UserProfilePicture.Image = CType(resources.GetObject("UserProfilePicture.Image"), Image)
        UserProfilePicture.Location = New Point(1015, 22)
        UserProfilePicture.Name = "UserProfilePicture"
        UserProfilePicture.Size = New Size(76, 56)
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        UserProfilePicture.TabIndex = 21
        UserProfilePicture.TabStop = False
        ' 
        ' TextPaymentHistoryLabel
        ' 
        TextPaymentHistoryLabel.AutoSize = True
        TextPaymentHistoryLabel.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPaymentHistoryLabel.ForeColor = Color.White
        TextPaymentHistoryLabel.Location = New Point(358, 4)
        TextPaymentHistoryLabel.Name = "TextPaymentHistoryLabel"
        TextPaymentHistoryLabel.Size = New Size(439, 83)
        TextPaymentHistoryLabel.TabIndex = 18
        TextPaymentHistoryLabel.Text = "Payment History"
        ' 
        ' TextUserNameLabel
        ' 
        TextUserNameLabel.AutoSize = True
        TextUserNameLabel.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextUserNameLabel.ForeColor = Color.DodgerBlue
        TextUserNameLabel.Location = New Point(849, 36)
        TextUserNameLabel.Name = "TextUserNameLabel"
        TextUserNameLabel.Size = New Size(160, 30)
        TextUserNameLabel.TabIndex = 18
        TextUserNameLabel.Text = "Dominic Oppong"
        ' 
        ' ComboBoxFilteryear
        ' 
        ComboBoxFilteryear.FormattingEnabled = True
        ComboBoxFilteryear.Location = New Point(723, 100)
        ComboBoxFilteryear.Name = "ComboBoxFilteryear"
        ComboBoxFilteryear.Size = New Size(252, 28)
        ComboBoxFilteryear.TabIndex = 2
        ' 
        ' TextFilterYearLabel
        ' 
        TextFilterYearLabel.AutoSize = True
        TextFilterYearLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextFilterYearLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextFilterYearLabel.Location = New Point(543, 95)
        TextFilterYearLabel.Name = "TextFilterYearLabel"
        TextFilterYearLabel.Size = New Size(174, 41)
        TextFilterYearLabel.TabIndex = 57
        TextFilterYearLabel.Text = "Filter by Year"
        ' 
        ' DataGridViewPaymentHistory
        ' 
        DataGridViewPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPaymentHistory.Location = New Point(291, 167)
        DataGridViewPaymentHistory.Name = "DataGridViewPaymentHistory"
        DataGridViewPaymentHistory.RowHeadersWidth = 51
        DataGridViewPaymentHistory.Size = New Size(505, 346)
        DataGridViewPaymentHistory.TabIndex = 71
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.Red
        CloseButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseButton.ForeColor = Color.White
        CloseButton.Location = New Point(560, 561)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(190, 63)
        CloseButton.TabIndex = 5
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' PaymentHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1105, 677)
        Controls.Add(DataGridViewPaymentHistory)
        Controls.Add(ComboBoxFilteryear)
        Controls.Add(HomeButton)
        Controls.Add(PrintSelectedButton)
        Controls.Add(CloseButton)
        Controls.Add(ExportToExcelButton)
        Controls.Add(TextFilterYearLabel)
        Controls.Add(TextBoxSearch)
        Controls.Add(TextSearchLabel)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "PaymentHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment History"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewPaymentHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents PrintSelectedButton As Button
    Friend WithEvents ExportToExcelButton As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents TextSearchLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextPaymentHistoryLabel As Label
    Friend WithEvents TextUserNameLabel As Label
    Friend WithEvents ComboBoxFilteryear As ComboBox
    Friend WithEvents TextFilterYearLabel As Label
    Friend WithEvents DataGridViewPaymentHistory As DataGridView
    Friend WithEvents CloseButton As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
