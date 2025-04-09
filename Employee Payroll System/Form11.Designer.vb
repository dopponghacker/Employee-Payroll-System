<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPaySlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewPaySlip))
        HomeButton = New Button()
        DownloadButton = New Button()
        CloseButton = New Button()
        Panel1 = New Panel()
        UserProfilePicture = New PictureBox()
        TextPaySlipLabel = New Label()
        TextUserNameLabel = New Label()
        TextBasicSalaryLabel = New Label()
        TextBasicSalary = New Label()
        TextAllowancesLabel = New Label()
        TextAllowances = New Label()
        TextDeductionsLabel = New Label()
        TextDeductions = New Label()
        TextNetSalaryLabel = New Label()
        TextNetSalary = New Label()
        SaveFileDialog1 = New SaveFileDialog()
        Label1 = New Label()
        TextEmployeeNameLabel = New Label()
        TextEmployeeName = New Label()
        TextPositionLabel = New Label()
        TextPosition = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        TextPayPeriodLabel = New Label()
        TextPayPeriod = New Label()
        Panel1.SuspendLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' HomeButton
        ' 
        HomeButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(417, 704)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(181, 76)
        HomeButton.TabIndex = 2
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = False
        ' 
        ' DownloadButton
        ' 
        DownloadButton.BackColor = Color.LimeGreen
        DownloadButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DownloadButton.ForeColor = Color.White
        DownloadButton.Location = New Point(126, 718)
        DownloadButton.Name = "DownloadButton"
        DownloadButton.Size = New Size(245, 62)
        DownloadButton.TabIndex = 1
        DownloadButton.Text = "Download"
        DownloadButton.UseVisualStyleBackColor = False
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.Red
        CloseButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseButton.ForeColor = Color.White
        CloseButton.Location = New Point(630, 717)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(108, 63)
        CloseButton.TabIndex = 3
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(UserProfilePicture)
        Panel1.Controls.Add(TextPaySlipLabel)
        Panel1.Controls.Add(TextUserNameLabel)
        Panel1.Location = New Point(-88, -10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1215, 81)
        Panel1.TabIndex = 51
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
        ' TextPaySlipLabel
        ' 
        TextPaySlipLabel.AutoSize = True
        TextPaySlipLabel.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPaySlipLabel.ForeColor = Color.White
        TextPaySlipLabel.Location = New Point(395, 3)
        TextPaySlipLabel.Name = "TextPaySlipLabel"
        TextPaySlipLabel.Size = New Size(215, 83)
        TextPaySlipLabel.TabIndex = 18
        TextPaySlipLabel.Text = "PaySlip"
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
        ' TextBasicSalaryLabel
        ' 
        TextBasicSalaryLabel.AutoSize = True
        TextBasicSalaryLabel.BackColor = Color.Red
        TextBasicSalaryLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextBasicSalaryLabel.ForeColor = Color.White
        TextBasicSalaryLabel.Location = New Point(172, 417)
        TextBasicSalaryLabel.Name = "TextBasicSalaryLabel"
        TextBasicSalaryLabel.Size = New Size(173, 41)
        TextBasicSalaryLabel.TabIndex = 49
        TextBasicSalaryLabel.Text = "Basic Salary:"
        ' 
        ' TextBasicSalary
        ' 
        TextBasicSalary.AutoSize = True
        TextBasicSalary.BackColor = Color.Red
        TextBasicSalary.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextBasicSalary.ForeColor = Color.White
        TextBasicSalary.Location = New Point(501, 417)
        TextBasicSalary.Name = "TextBasicSalary"
        TextBasicSalary.Size = New Size(33, 41)
        TextBasicSalary.TabIndex = 50
        TextBasicSalary.Text = "$"
        ' 
        ' TextAllowancesLabel
        ' 
        TextAllowancesLabel.AutoSize = True
        TextAllowancesLabel.BackColor = Color.Red
        TextAllowancesLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextAllowancesLabel.ForeColor = Color.White
        TextAllowancesLabel.Location = New Point(172, 473)
        TextAllowancesLabel.Name = "TextAllowancesLabel"
        TextAllowancesLabel.Size = New Size(164, 41)
        TextAllowancesLabel.TabIndex = 49
        TextAllowancesLabel.Text = "Allowances:"
        ' 
        ' TextAllowances
        ' 
        TextAllowances.AutoSize = True
        TextAllowances.BackColor = Color.Red
        TextAllowances.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextAllowances.ForeColor = Color.White
        TextAllowances.Location = New Point(382, 167)
        TextAllowances.Name = "TextAllowances"
        TextAllowances.Size = New Size(33, 41)
        TextAllowances.TabIndex = 50
        TextAllowances.Text = "$"
        ' 
        ' TextDeductionsLabel
        ' 
        TextDeductionsLabel.AutoSize = True
        TextDeductionsLabel.BackColor = Color.Red
        TextDeductionsLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextDeductionsLabel.ForeColor = Color.White
        TextDeductionsLabel.Location = New Point(56, 235)
        TextDeductionsLabel.Name = "TextDeductionsLabel"
        TextDeductionsLabel.Size = New Size(162, 41)
        TextDeductionsLabel.TabIndex = 49
        TextDeductionsLabel.Text = "Deductions:"
        ' 
        ' TextDeductions
        ' 
        TextDeductions.AutoSize = True
        TextDeductions.BackColor = Color.Red
        TextDeductions.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextDeductions.ForeColor = Color.White
        TextDeductions.Location = New Point(382, 235)
        TextDeductions.Name = "TextDeductions"
        TextDeductions.Size = New Size(33, 41)
        TextDeductions.TabIndex = 50
        TextDeductions.Text = "$"
        ' 
        ' TextNetSalaryLabel
        ' 
        TextNetSalaryLabel.AutoSize = True
        TextNetSalaryLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextNetSalaryLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextNetSalaryLabel.Location = New Point(192, 634)
        TextNetSalaryLabel.Name = "TextNetSalaryLabel"
        TextNetSalaryLabel.Size = New Size(148, 41)
        TextNetSalaryLabel.TabIndex = 49
        TextNetSalaryLabel.Text = "Net Salary:"
        ' 
        ' TextNetSalary
        ' 
        TextNetSalary.AutoSize = True
        TextNetSalary.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextNetSalary.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextNetSalary.Location = New Point(490, 634)
        TextNetSalary.Name = "TextNetSalary"
        TextNetSalary.Size = New Size(33, 41)
        TextNetSalary.TabIndex = 50
        TextNetSalary.Text = "$"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(338, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 41)
        Label1.TabIndex = 49
        Label1.Text = " Employee Details"
        ' 
        ' TextEmployeeNameLabel
        ' 
        TextEmployeeNameLabel.AutoSize = True
        TextEmployeeNameLabel.BackColor = Color.DodgerBlue
        TextEmployeeNameLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextEmployeeNameLabel.ForeColor = Color.White
        TextEmployeeNameLabel.Location = New Point(29, 32)
        TextEmployeeNameLabel.Name = "TextEmployeeNameLabel"
        TextEmployeeNameLabel.Size = New Size(223, 41)
        TextEmployeeNameLabel.TabIndex = 49
        TextEmployeeNameLabel.Text = " Employee Name:"
        ' 
        ' TextEmployeeName
        ' 
        TextEmployeeName.AutoSize = True
        TextEmployeeName.BackColor = Color.DodgerBlue
        TextEmployeeName.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextEmployeeName.ForeColor = Color.White
        TextEmployeeName.Location = New Point(298, 32)
        TextEmployeeName.Name = "TextEmployeeName"
        TextEmployeeName.Size = New Size(89, 41)
        TextEmployeeName.TabIndex = 49
        TextEmployeeName.Text = "Name"
        ' 
        ' TextPositionLabel
        ' 
        TextPositionLabel.AutoSize = True
        TextPositionLabel.BackColor = Color.DodgerBlue
        TextPositionLabel.Font = New Font("Poppins", 12F, FontStyle.Bold)
        TextPositionLabel.ForeColor = Color.White
        TextPositionLabel.Location = New Point(38, 73)
        TextPositionLabel.Name = "TextPositionLabel"
        TextPositionLabel.Size = New Size(103, 35)
        TextPositionLabel.TabIndex = 49
        TextPositionLabel.Text = "Position:"
        ' 
        ' TextPosition
        ' 
        TextPosition.AutoSize = True
        TextPosition.BackColor = Color.DodgerBlue
        TextPosition.Font = New Font("Poppins", 12F, FontStyle.Bold)
        TextPosition.ForeColor = Color.White
        TextPosition.Location = New Point(298, 73)
        TextPosition.Name = "TextPosition"
        TextPosition.Size = New Size(97, 35)
        TextPosition.TabIndex = 49
        TextPosition.Text = "Position"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(338, 294)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 41)
        Label2.TabIndex = 49
        Label2.Text = "Payslip Details"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DodgerBlue
        Panel2.Controls.Add(TextEmployeeNameLabel)
        Panel2.Controls.Add(TextPositionLabel)
        Panel2.Controls.Add(TextEmployeeName)
        Panel2.Controls.Add(TextPosition)
        Panel2.Location = New Point(119, 134)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(633, 145)
        Panel2.TabIndex = 57
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Red
        Panel3.Controls.Add(TextPayPeriodLabel)
        Panel3.Controls.Add(TextPayPeriod)
        Panel3.Controls.Add(TextDeductionsLabel)
        Panel3.Controls.Add(TextAllowances)
        Panel3.Controls.Add(TextDeductions)
        Panel3.Location = New Point(119, 312)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(633, 302)
        Panel3.TabIndex = 57
        ' 
        ' TextPayPeriodLabel
        ' 
        TextPayPeriodLabel.AutoSize = True
        TextPayPeriodLabel.BackColor = Color.Red
        TextPayPeriodLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextPayPeriodLabel.ForeColor = Color.White
        TextPayPeriodLabel.Location = New Point(53, 47)
        TextPayPeriodLabel.Name = "TextPayPeriodLabel"
        TextPayPeriodLabel.Size = New Size(151, 41)
        TextPayPeriodLabel.TabIndex = 49
        TextPayPeriodLabel.Text = "Pay Period:"
        ' 
        ' TextPayPeriod
        ' 
        TextPayPeriod.AutoSize = True
        TextPayPeriod.BackColor = Color.Red
        TextPayPeriod.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextPayPeriod.ForeColor = Color.White
        TextPayPeriod.Location = New Point(382, 47)
        TextPayPeriod.Name = "TextPayPeriod"
        TextPayPeriod.Size = New Size(163, 41)
        TextPayPeriod.TabIndex = 50
        TextPayPeriod.Text = "Month-Year"
        ' 
        ' ViewPaySlip
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(872, 817)
        Controls.Add(HomeButton)
        Controls.Add(DownloadButton)
        Controls.Add(CloseButton)
        Controls.Add(Panel1)
        Controls.Add(TextNetSalaryLabel)
        Controls.Add(TextAllowancesLabel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBasicSalaryLabel)
        Controls.Add(TextNetSalary)
        Controls.Add(TextBasicSalary)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ViewPaySlip"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PaySlip"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents HomeButton As Button
    Friend WithEvents DownloadButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextPaySlipLabel As Label
    Friend WithEvents TextUserNameLabel As Label
    Friend WithEvents TextBasicSalaryLabel As Label
    Friend WithEvents TextBasicSalary As Label
    Friend WithEvents TextAllowancesLabel As Label
    Friend WithEvents TextAllowances As Label
    Friend WithEvents TextDeductionsLabel As Label
    Friend WithEvents TextDeductions As Label
    Friend WithEvents TextNetSalaryLabel As Label
    Friend WithEvents TextNetSalary As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents TextEmployeeNameLabel As Label
    Friend WithEvents TextEmployeeName As Label
    Friend WithEvents TextPositionLabel As Label
    Friend WithEvents TextPosition As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextPayPeriodLabel As Label
    Friend WithEvents TextPayPeriod As Label
End Class
