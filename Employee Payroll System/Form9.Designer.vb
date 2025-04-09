<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayGeneration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PayGeneration))
        HomeButton = New Button()
        GeneratePaySlipButton = New Button()
        PaymentHistoryButton = New Button()
        TextBoxBasicSalary = New TextBox()
        Panel1 = New Panel()
        UserProfilePicture = New PictureBox()
        TextPayGenerationLabel = New Label()
        TextUserNameLabel = New Label()
        TextDeductionsLabel = New Label()
        TextBasicSalaryLabel = New Label()
        TextAllowanceLabel = New Label()
        TextBoxAllowance = New TextBox()
        TextDateLabel = New Label()
        TextBoxDeductions = New TextBox()
        TextNetSalaryLabel = New Label()
        TextBoxNetSalary = New TextBox()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' HomeButton
        ' 
        HomeButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(607, 623)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(181, 76)
        HomeButton.TabIndex = 3
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = False
        ' 
        ' GeneratePaySlipButton
        ' 
        GeneratePaySlipButton.BackColor = Color.LimeGreen
        GeneratePaySlipButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GeneratePaySlipButton.ForeColor = Color.White
        GeneratePaySlipButton.Location = New Point(138, 624)
        GeneratePaySlipButton.Name = "GeneratePaySlipButton"
        GeneratePaySlipButton.Size = New Size(199, 62)
        GeneratePaySlipButton.TabIndex = 1
        GeneratePaySlipButton.Text = "Generate PaySlip"
        GeneratePaySlipButton.UseVisualStyleBackColor = False
        ' 
        ' PaymentHistoryButton
        ' 
        PaymentHistoryButton.BackColor = Color.Red
        PaymentHistoryButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PaymentHistoryButton.ForeColor = Color.White
        PaymentHistoryButton.Location = New Point(373, 623)
        PaymentHistoryButton.Name = "PaymentHistoryButton"
        PaymentHistoryButton.Size = New Size(190, 63)
        PaymentHistoryButton.TabIndex = 2
        PaymentHistoryButton.Text = "Payment Histroy"
        PaymentHistoryButton.UseVisualStyleBackColor = False
        ' 
        ' TextBoxBasicSalary
        ' 
        TextBoxBasicSalary.BackColor = Color.DodgerBlue
        TextBoxBasicSalary.Font = New Font("Poppins Medium", 12F, FontStyle.Bold)
        TextBoxBasicSalary.ForeColor = Color.White
        TextBoxBasicSalary.Location = New Point(336, 204)
        TextBoxBasicSalary.Multiline = True
        TextBoxBasicSalary.Name = "TextBoxBasicSalary"
        TextBoxBasicSalary.Size = New Size(256, 77)
        TextBoxBasicSalary.TabIndex = 52
        TextBoxBasicSalary.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(UserProfilePicture)
        Panel1.Controls.Add(TextPayGenerationLabel)
        Panel1.Controls.Add(TextUserNameLabel)
        Panel1.Location = New Point(-82, -1)
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
        ' TextPayGenerationLabel
        ' 
        TextPayGenerationLabel.AutoSize = True
        TextPayGenerationLabel.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPayGenerationLabel.ForeColor = Color.White
        TextPayGenerationLabel.Location = New Point(265, 0)
        TextPayGenerationLabel.Name = "TextPayGenerationLabel"
        TextPayGenerationLabel.Size = New Size(409, 83)
        TextPayGenerationLabel.TabIndex = 18
        TextPayGenerationLabel.Text = "Pay Generation"
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
        ' TextDeductionsLabel
        ' 
        TextDeductionsLabel.AutoSize = True
        TextDeductionsLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextDeductionsLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextDeductionsLabel.Location = New Point(133, 414)
        TextDeductionsLabel.Name = "TextDeductionsLabel"
        TextDeductionsLabel.Size = New Size(197, 53)
        TextDeductionsLabel.TabIndex = 48
        TextDeductionsLabel.Text = "Deductions"
        ' 
        ' TextBasicSalaryLabel
        ' 
        TextBasicSalaryLabel.AutoSize = True
        TextBasicSalaryLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBasicSalaryLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextBasicSalaryLabel.Location = New Point(123, 216)
        TextBasicSalaryLabel.Name = "TextBasicSalaryLabel"
        TextBasicSalaryLabel.Size = New Size(207, 53)
        TextBasicSalaryLabel.TabIndex = 49
        TextBasicSalaryLabel.Text = "Basic Salary"
        ' 
        ' TextAllowanceLabel
        ' 
        TextAllowanceLabel.AutoSize = True
        TextAllowanceLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextAllowanceLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextAllowanceLabel.Location = New Point(133, 310)
        TextAllowanceLabel.Name = "TextAllowanceLabel"
        TextAllowanceLabel.Size = New Size(181, 53)
        TextAllowanceLabel.TabIndex = 50
        TextAllowanceLabel.Text = "Allowance"
        ' 
        ' TextBoxAllowance
        ' 
        TextBoxAllowance.BackColor = Color.DodgerBlue
        TextBoxAllowance.Font = New Font("Poppins Medium", 12F, FontStyle.Bold)
        TextBoxAllowance.ForeColor = Color.White
        TextBoxAllowance.Location = New Point(336, 297)
        TextBoxAllowance.Multiline = True
        TextBoxAllowance.Name = "TextBoxAllowance"
        TextBoxAllowance.Size = New Size(256, 77)
        TextBoxAllowance.TabIndex = 52
        TextBoxAllowance.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextDateLabel
        ' 
        TextDateLabel.AutoSize = True
        TextDateLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextDateLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextDateLabel.Location = New Point(336, 135)
        TextDateLabel.Name = "TextDateLabel"
        TextDateLabel.Size = New Size(230, 53)
        TextDateLabel.TabIndex = 49
        TextDateLabel.Text = "(March 2024)"
        TextDateLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBoxDeductions
        ' 
        TextBoxDeductions.BackColor = Color.DodgerBlue
        TextBoxDeductions.Font = New Font("Poppins Medium", 12F, FontStyle.Bold)
        TextBoxDeductions.ForeColor = Color.White
        TextBoxDeductions.Location = New Point(336, 400)
        TextBoxDeductions.Multiline = True
        TextBoxDeductions.Name = "TextBoxDeductions"
        TextBoxDeductions.Size = New Size(256, 77)
        TextBoxDeductions.TabIndex = 52
        TextBoxDeductions.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextNetSalaryLabel
        ' 
        TextNetSalaryLabel.AutoSize = True
        TextNetSalaryLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextNetSalaryLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextNetSalaryLabel.Location = New Point(133, 508)
        TextNetSalaryLabel.Name = "TextNetSalaryLabel"
        TextNetSalaryLabel.Size = New Size(179, 53)
        TextNetSalaryLabel.TabIndex = 48
        TextNetSalaryLabel.Text = "Net Salary"
        ' 
        ' TextBoxNetSalary
        ' 
        TextBoxNetSalary.BackColor = Color.DodgerBlue
        TextBoxNetSalary.Font = New Font("Poppins Medium", 12F, FontStyle.Bold)
        TextBoxNetSalary.ForeColor = Color.White
        TextBoxNetSalary.Location = New Point(336, 494)
        TextBoxNetSalary.Multiline = True
        TextBoxNetSalary.Name = "TextBoxNetSalary"
        TextBoxNetSalary.Size = New Size(256, 77)
        TextBoxNetSalary.TabIndex = 52
        TextBoxNetSalary.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(294, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(325, 53)
        Label1.TabIndex = 49
        Label1.Text = " PAYROLL SUMMARY"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PayGeneration
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(913, 756)
        Controls.Add(HomeButton)
        Controls.Add(GeneratePaySlipButton)
        Controls.Add(PaymentHistoryButton)
        Controls.Add(TextBoxNetSalary)
        Controls.Add(TextBoxDeductions)
        Controls.Add(TextBoxAllowance)
        Controls.Add(TextBoxBasicSalary)
        Controls.Add(TextNetSalaryLabel)
        Controls.Add(Panel1)
        Controls.Add(TextDeductionsLabel)
        Controls.Add(Label1)
        Controls.Add(TextDateLabel)
        Controls.Add(TextBasicSalaryLabel)
        Controls.Add(TextAllowanceLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimizeBox = False
        Name = "PayGeneration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pay Generation"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents HomeButton As Button
    Friend WithEvents GeneratePaySlipButton As Button
    Friend WithEvents PaymentHistoryButton As Button
    Friend WithEvents TextBoxBasicSalary As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextPayGenerationLabel As Label
    Friend WithEvents TextUserNameLabel As Label
    Friend WithEvents TextDeductionsLabel As Label
    Friend WithEvents TextBasicSalaryLabel As Label
    Friend WithEvents TextAllowanceLabel As Label
    Friend WithEvents TextBoxAllowance As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextDateLabel As Label
    Friend WithEvents TextBoxDeductions As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextNetSalaryLabel As Label
    Friend WithEvents TextBoxNetSalary As TextBox
    Friend WithEvents Label1 As Label
End Class
