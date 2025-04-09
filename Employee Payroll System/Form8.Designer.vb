<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoanEntry))
        ComboBoxLoanType = New ComboBox()
        HomeButton = New Button()
        SubmitButton = New Button()
        CancelButton = New Button()
        TextBoxReason = New TextBox()
        Panel1 = New Panel()
        UserProfilePicture = New PictureBox()
        TextLoanEntryLabel = New Label()
        TextUserNameLabel = New Label()
        TextReasonLabel = New Label()
        TextLeaveTypeLabel = New Label()
        TextStartDateLabel = New Label()
        TextBoxAmount = New TextBox()
        DataGridViewLoanHistory = New DataGridView()
        Panel1.SuspendLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewLoanHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBoxLoanType
        ' 
        ComboBoxLoanType.BackColor = Color.DodgerBlue
        ComboBoxLoanType.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold)
        ComboBoxLoanType.ForeColor = Color.White
        ComboBoxLoanType.FormattingEnabled = True
        ComboBoxLoanType.Location = New Point(339, 133)
        ComboBoxLoanType.Name = "ComboBoxLoanType"
        ComboBoxLoanType.Size = New Size(256, 40)
        ComboBoxLoanType.TabIndex = 1
        ' 
        ' HomeButton
        ' 
        HomeButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(408, 733)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(181, 76)
        HomeButton.TabIndex = 6
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = False
        ' 
        ' SubmitButton
        ' 
        SubmitButton.BackColor = Color.LimeGreen
        SubmitButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitButton.ForeColor = Color.White
        SubmitButton.Location = New Point(339, 414)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(146, 62)
        SubmitButton.TabIndex = 4
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = False
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.Red
        CancelButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CancelButton.ForeColor = Color.White
        CancelButton.Location = New Point(518, 414)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(108, 63)
        CancelButton.TabIndex = 5
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' TextBoxReason
        ' 
        TextBoxReason.BackColor = Color.DodgerBlue
        TextBoxReason.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold)
        TextBoxReason.ForeColor = Color.White
        TextBoxReason.Location = New Point(339, 284)
        TextBoxReason.Multiline = True
        TextBoxReason.Name = "TextBoxReason"
        TextBoxReason.Size = New Size(308, 124)
        TextBoxReason.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(UserProfilePicture)
        Panel1.Controls.Add(TextLoanEntryLabel)
        Panel1.Controls.Add(TextUserNameLabel)
        Panel1.Location = New Point(-92, -7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1215, 81)
        Panel1.TabIndex = 42
        ' 
        ' UserProfilePicture
        ' 
        UserProfilePicture.Image = CType(resources.GetObject("UserProfilePicture.Image"), Image)
        UserProfilePicture.Location = New Point(846, 16)
        UserProfilePicture.Name = "UserProfilePicture"
        UserProfilePicture.Size = New Size(76, 56)
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        UserProfilePicture.TabIndex = 21
        UserProfilePicture.TabStop = False
        ' 
        ' TextLoanEntryLabel
        ' 
        TextLoanEntryLabel.AutoSize = True
        TextLoanEntryLabel.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextLoanEntryLabel.ForeColor = Color.White
        TextLoanEntryLabel.Location = New Point(360, 4)
        TextLoanEntryLabel.Name = "TextLoanEntryLabel"
        TextLoanEntryLabel.Size = New Size(287, 83)
        TextLoanEntryLabel.TabIndex = 18
        TextLoanEntryLabel.Text = "Loan Entry"
        ' 
        ' TextUserNameLabel
        ' 
        TextUserNameLabel.AutoSize = True
        TextUserNameLabel.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextUserNameLabel.ForeColor = Color.DodgerBlue
        TextUserNameLabel.Location = New Point(680, 30)
        TextUserNameLabel.Name = "TextUserNameLabel"
        TextUserNameLabel.Size = New Size(160, 30)
        TextUserNameLabel.TabIndex = 18
        TextUserNameLabel.Text = "Dominic Oppong"
        ' 
        ' TextReasonLabel
        ' 
        TextReasonLabel.AutoSize = True
        TextReasonLabel.Font = New Font("Poppins SemiBold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextReasonLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextReasonLabel.Location = New Point(164, 319)
        TextReasonLabel.Name = "TextReasonLabel"
        TextReasonLabel.Size = New Size(143, 53)
        TextReasonLabel.TabIndex = 38
        TextReasonLabel.Text = "Reason "
        ' 
        ' TextLeaveTypeLabel
        ' 
        TextLeaveTypeLabel.AutoSize = True
        TextLeaveTypeLabel.Font = New Font("Poppins SemiBold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextLeaveTypeLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextLeaveTypeLabel.Location = New Point(156, 118)
        TextLeaveTypeLabel.Name = "TextLeaveTypeLabel"
        TextLeaveTypeLabel.Size = New Size(177, 53)
        TextLeaveTypeLabel.TabIndex = 39
        TextLeaveTypeLabel.Text = "Loan Type"
        ' 
        ' TextStartDateLabel
        ' 
        TextStartDateLabel.AutoSize = True
        TextStartDateLabel.Font = New Font("Poppins SemiBold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextStartDateLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextStartDateLabel.Location = New Point(156, 203)
        TextStartDateLabel.Name = "TextStartDateLabel"
        TextStartDateLabel.Size = New Size(146, 53)
        TextStartDateLabel.TabIndex = 41
        TextStartDateLabel.Text = "Amount"
        ' 
        ' TextBoxAmount
        ' 
        TextBoxAmount.BackColor = Color.DodgerBlue
        TextBoxAmount.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold)
        TextBoxAmount.ForeColor = Color.White
        TextBoxAmount.Location = New Point(339, 191)
        TextBoxAmount.Multiline = True
        TextBoxAmount.Name = "TextBoxAmount"
        TextBoxAmount.Size = New Size(256, 77)
        TextBoxAmount.TabIndex = 2
        ' 
        ' DataGridViewLoanHistory
        ' 
        DataGridViewLoanHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewLoanHistory.Location = New Point(156, 500)
        DataGridViewLoanHistory.Name = "DataGridViewLoanHistory"
        DataGridViewLoanHistory.RowHeadersWidth = 51
        DataGridViewLoanHistory.Size = New Size(674, 212)
        DataGridViewLoanHistory.TabIndex = 48
        ' 
        ' LoanEntry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(968, 840)
        Controls.Add(DataGridViewLoanHistory)
        Controls.Add(ComboBoxLoanType)
        Controls.Add(HomeButton)
        Controls.Add(SubmitButton)
        Controls.Add(CancelButton)
        Controls.Add(TextBoxAmount)
        Controls.Add(TextBoxReason)
        Controls.Add(Panel1)
        Controls.Add(TextReasonLabel)
        Controls.Add(TextLeaveTypeLabel)
        Controls.Add(TextStartDateLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "LoanEntry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Loan Entry"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewLoanHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxLoanType As ComboBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents TextBoxReason As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextLoanEntryLabel As Label
    Friend WithEvents TextUserNameLabel As Label
    Friend WithEvents TextReasonLabel As Label
    Friend WithEvents TextLeaveTypeLabel As Label
    Friend WithEvents TextStartDateLabel As Label
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents DataGridViewLoanHistory As DataGridView
End Class
