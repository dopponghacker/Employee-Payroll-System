<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClaimEntry))
        TextUserNameLabel = New Label()
        TextClaimTypeLabel = New Label()
        Panel1 = New Panel()
        UserProfilePicture = New PictureBox()
        Label3 = New Label()
        TextAmountLabel = New Label()
        TextBoxAmount = New TextBox()
        FileUploadButton = New Button()
        Label5 = New Label()
        TextBoxDescription = New TextBox()
        ViewPendingClaimsButton = New Button()
        SubmitClaimButton = New Button()
        Label6 = New Label()
        HomeButton = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        PendingClaimsDataGridView = New DataGridView()
        ComboBoxClaimType = New ComboBox()
        Panel1.SuspendLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(PendingClaimsDataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextUserNameLabel
        ' 
        TextUserNameLabel.AutoSize = True
        TextUserNameLabel.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextUserNameLabel.ForeColor = Color.DodgerBlue
        TextUserNameLabel.Location = New Point(865, 27)
        TextUserNameLabel.Name = "TextUserNameLabel"
        TextUserNameLabel.Size = New Size(160, 30)
        TextUserNameLabel.TabIndex = 18
        TextUserNameLabel.Text = "Dominic Oppong"
        ' 
        ' TextClaimTypeLabel
        ' 
        TextClaimTypeLabel.AutoSize = True
        TextClaimTypeLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextClaimTypeLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextClaimTypeLabel.Location = New Point(166, 134)
        TextClaimTypeLabel.Name = "TextClaimTypeLabel"
        TextClaimTypeLabel.Size = New Size(194, 53)
        TextClaimTypeLabel.TabIndex = 18
        TextClaimTypeLabel.Text = "Claim Type"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(UserProfilePicture)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextUserNameLabel)
        Panel1.Location = New Point(-42, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1215, 81)
        Panel1.TabIndex = 19
        ' 
        ' UserProfilePicture
        ' 
        UserProfilePicture.Image = CType(resources.GetObject("UserProfilePicture.Image"), Image)
        UserProfilePicture.Location = New Point(1041, 13)
        UserProfilePicture.Name = "UserProfilePicture"
        UserProfilePicture.Size = New Size(76, 56)
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        UserProfilePicture.TabIndex = 21
        UserProfilePicture.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(455, 2)
        Label3.Name = "Label3"
        Label3.Size = New Size(317, 83)
        Label3.TabIndex = 18
        Label3.Text = "Claim Entry"
        ' 
        ' TextAmountLabel
        ' 
        TextAmountLabel.AutoSize = True
        TextAmountLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextAmountLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextAmountLabel.Location = New Point(201, 214)
        TextAmountLabel.Name = "TextAmountLabel"
        TextAmountLabel.Size = New Size(146, 53)
        TextAmountLabel.TabIndex = 18
        TextAmountLabel.Text = "Amount"
        ' 
        ' TextBoxAmount
        ' 
        TextBoxAmount.BackColor = Color.DodgerBlue
        TextBoxAmount.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold)
        TextBoxAmount.ForeColor = Color.White
        TextBoxAmount.Location = New Point(366, 199)
        TextBoxAmount.Multiline = True
        TextBoxAmount.Name = "TextBoxAmount"
        TextBoxAmount.Size = New Size(256, 83)
        TextBoxAmount.TabIndex = 2
        ' 
        ' FileUploadButton
        ' 
        FileUploadButton.BackColor = Color.LimeGreen
        FileUploadButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FileUploadButton.ForeColor = Color.White
        FileUploadButton.Location = New Point(799, 143)
        FileUploadButton.Name = "FileUploadButton"
        FileUploadButton.Size = New Size(164, 63)
        FileUploadButton.TabIndex = 4
        FileUploadButton.Text = "File Upload"
        FileUploadButton.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label5.Location = New Point(166, 330)
        Label5.Name = "Label5"
        Label5.Size = New Size(204, 53)
        Label5.TabIndex = 18
        Label5.Text = "Description "
        ' 
        ' TextBoxDescription
        ' 
        TextBoxDescription.BackColor = Color.DodgerBlue
        TextBoxDescription.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold)
        TextBoxDescription.ForeColor = Color.White
        TextBoxDescription.Location = New Point(366, 288)
        TextBoxDescription.Multiline = True
        TextBoxDescription.Name = "TextBoxDescription"
        TextBoxDescription.Size = New Size(378, 127)
        TextBoxDescription.TabIndex = 3
        ' 
        ' ViewPendingClaimsButton
        ' 
        ViewPendingClaimsButton.BackColor = Color.Red
        ViewPendingClaimsButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ViewPendingClaimsButton.ForeColor = Color.White
        ViewPendingClaimsButton.Location = New Point(191, 456)
        ViewPendingClaimsButton.Name = "ViewPendingClaimsButton"
        ViewPendingClaimsButton.Size = New Size(213, 63)
        ViewPendingClaimsButton.TabIndex = 5
        ViewPendingClaimsButton.Text = "View Pending Claims"
        ViewPendingClaimsButton.TextAlign = ContentAlignment.MiddleRight
        ViewPendingClaimsButton.UseVisualStyleBackColor = False
        ' 
        ' SubmitClaimButton
        ' 
        SubmitClaimButton.BackColor = Color.DodgerBlue
        SubmitClaimButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitClaimButton.ForeColor = Color.White
        SubmitClaimButton.Location = New Point(476, 443)
        SubmitClaimButton.Name = "SubmitClaimButton"
        SubmitClaimButton.Size = New Size(205, 76)
        SubmitClaimButton.TabIndex = 6
        SubmitClaimButton.Text = "Submit Claim"
        SubmitClaimButton.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label6.Location = New Point(758, 209)
        Label6.Name = "Label6"
        Label6.Size = New Size(249, 26)
        Label6.TabIndex = 18
        Label6.Text = "Upload Supporting Documents "
        ' 
        ' HomeButton
        ' 
        HomeButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(771, 443)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(181, 76)
        HomeButton.TabIndex = 7
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PendingClaimsDataGridView
        ' 
        PendingClaimsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PendingClaimsDataGridView.Location = New Point(366, 548)
        PendingClaimsDataGridView.Name = "PendingClaimsDataGridView"
        PendingClaimsDataGridView.RowHeadersWidth = 51
        PendingClaimsDataGridView.Size = New Size(415, 131)
        PendingClaimsDataGridView.TabIndex = 23
        ' 
        ' ComboBoxClaimType
        ' 
        ComboBoxClaimType.BackColor = Color.DodgerBlue
        ComboBoxClaimType.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold)
        ComboBoxClaimType.ForeColor = Color.White
        ComboBoxClaimType.FormattingEnabled = True
        ComboBoxClaimType.Location = New Point(366, 143)
        ComboBoxClaimType.Name = "ComboBoxClaimType"
        ComboBoxClaimType.Size = New Size(256, 40)
        ComboBoxClaimType.TabIndex = 1
        ' 
        ' ClaimEntry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1153, 691)
        Controls.Add(ComboBoxClaimType)
        Controls.Add(PendingClaimsDataGridView)
        Controls.Add(HomeButton)
        Controls.Add(SubmitClaimButton)
        Controls.Add(ViewPendingClaimsButton)
        Controls.Add(FileUploadButton)
        Controls.Add(TextBoxDescription)
        Controls.Add(TextBoxAmount)
        Controls.Add(Panel1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextClaimTypeLabel)
        Controls.Add(TextAmountLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ClaimEntry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Claim Entry"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(PendingClaimsDataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextUserNameLabel As Label
    Friend WithEvents TextClaimTypeLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextAmountLabel As Label
    Friend WithEvents TextBoxClaimType As TextBox
    Friend WithEvents TextBoxAmount As TextBox
    Friend WithEvents FileUploadButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents ViewPendingClaimsButton As Button
    Friend WithEvents SubmitClaimButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents HomeButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PendingClaimsDataGridView As DataGridView
    Friend WithEvents ComboBoxClaimType As ComboBox
End Class
