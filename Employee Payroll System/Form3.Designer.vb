<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeeForm))
        TextPayroolLabel = New Label()
        TextWelcomeLabel = New Label()
        Panel1 = New Panel()
        ViewReportButton = New Button()
        PayGenerationButton = New Button()
        LoanEntryButton = New Button()
        EmployeeDetailsButton = New Button()
        AttendanceDetailsButton = New Button()
        LeaveEntryButton = New Button()
        ClaimEntryButton = New Button()
        HomeButton = New Button()
        Label2 = New Label()
        PictureBoxPayroll = New PictureBox()
        LogOutButton = New Button()
        UserProfilePicture = New PictureBox()
        UpdateProfileButton = New Button()
        Label3 = New Label()
        Panel2 = New Panel()
        TextBoxLastPaySlip = New TextBox()
        TextBoxPendingClaims = New TextBox()
        TextBoxLeaveBalance = New TextBox()
        TextLastPaySlipLabel = New Label()
        TextPendingClaimsLabel = New Label()
        TextLeaveBalanceLabel = New Label()
        Panel1.SuspendLayout()
        CType(PictureBoxPayroll, ComponentModel.ISupportInitialize).BeginInit()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextPayroolLabel
        ' 
        TextPayroolLabel.AutoSize = True
        TextPayroolLabel.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPayroolLabel.Location = New Point(554, 96)
        TextPayroolLabel.Name = "TextPayroolLabel"
        TextPayroolLabel.RightToLeft = RightToLeft.Yes
        TextPayroolLabel.Size = New Size(646, 83)
        TextPayroolLabel.TabIndex = 16
        TextPayroolLabel.Text = "Employee Payroll System"
        TextPayroolLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextWelcomeLabel
        ' 
        TextWelcomeLabel.AutoSize = True
        TextWelcomeLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextWelcomeLabel.ForeColor = Color.DodgerBlue
        TextWelcomeLabel.Location = New Point(282, 54)
        TextWelcomeLabel.Name = "TextWelcomeLabel"
        TextWelcomeLabel.Size = New Size(439, 53)
        TextWelcomeLabel.TabIndex = 17
        TextWelcomeLabel.Text = "Welcome, Dominic Oppong"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(ViewReportButton)
        Panel1.Controls.Add(PayGenerationButton)
        Panel1.Controls.Add(LoanEntryButton)
        Panel1.Controls.Add(EmployeeDetailsButton)
        Panel1.Controls.Add(AttendanceDetailsButton)
        Panel1.Controls.Add(LeaveEntryButton)
        Panel1.Controls.Add(ClaimEntryButton)
        Panel1.Controls.Add(HomeButton)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(271, 791)
        Panel1.TabIndex = 19
        ' 
        ' ViewReportButton
        ' 
        ViewReportButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        ViewReportButton.ForeColor = Color.Blue
        ViewReportButton.Image = CType(resources.GetObject("ViewReportButton.Image"), Image)
        ViewReportButton.ImageAlign = ContentAlignment.TopCenter
        ViewReportButton.Location = New Point(27, 686)
        ViewReportButton.Name = "ViewReportButton"
        ViewReportButton.Size = New Size(206, 76)
        ViewReportButton.TabIndex = 8
        ViewReportButton.Text = "View Report"
        ViewReportButton.TextAlign = ContentAlignment.BottomCenter
        ViewReportButton.UseVisualStyleBackColor = True
        ' 
        ' PayGenerationButton
        ' 
        PayGenerationButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        PayGenerationButton.ForeColor = Color.Blue
        PayGenerationButton.Image = CType(resources.GetObject("PayGenerationButton.Image"), Image)
        PayGenerationButton.ImageAlign = ContentAlignment.TopCenter
        PayGenerationButton.Location = New Point(27, 592)
        PayGenerationButton.Name = "PayGenerationButton"
        PayGenerationButton.Size = New Size(206, 76)
        PayGenerationButton.TabIndex = 7
        PayGenerationButton.Text = "Pay Generation"
        PayGenerationButton.TextAlign = ContentAlignment.BottomCenter
        PayGenerationButton.UseVisualStyleBackColor = True
        ' 
        ' LoanEntryButton
        ' 
        LoanEntryButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        LoanEntryButton.ForeColor = Color.Blue
        LoanEntryButton.Image = CType(resources.GetObject("LoanEntryButton.Image"), Image)
        LoanEntryButton.ImageAlign = ContentAlignment.TopCenter
        LoanEntryButton.Location = New Point(27, 502)
        LoanEntryButton.Name = "LoanEntryButton"
        LoanEntryButton.Size = New Size(206, 76)
        LoanEntryButton.TabIndex = 6
        LoanEntryButton.Text = "Loan Entry"
        LoanEntryButton.TextAlign = ContentAlignment.BottomCenter
        LoanEntryButton.UseVisualStyleBackColor = True
        ' 
        ' EmployeeDetailsButton
        ' 
        EmployeeDetailsButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        EmployeeDetailsButton.ForeColor = Color.Blue
        EmployeeDetailsButton.Image = CType(resources.GetObject("EmployeeDetailsButton.Image"), Image)
        EmployeeDetailsButton.ImageAlign = ContentAlignment.TopCenter
        EmployeeDetailsButton.Location = New Point(27, 411)
        EmployeeDetailsButton.Name = "EmployeeDetailsButton"
        EmployeeDetailsButton.Size = New Size(206, 76)
        EmployeeDetailsButton.TabIndex = 5
        EmployeeDetailsButton.Text = "Employee Details"
        EmployeeDetailsButton.TextAlign = ContentAlignment.BottomCenter
        EmployeeDetailsButton.UseVisualStyleBackColor = True
        ' 
        ' AttendanceDetailsButton
        ' 
        AttendanceDetailsButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        AttendanceDetailsButton.ForeColor = Color.Blue
        AttendanceDetailsButton.Image = CType(resources.GetObject("AttendanceDetailsButton.Image"), Image)
        AttendanceDetailsButton.ImageAlign = ContentAlignment.TopCenter
        AttendanceDetailsButton.Location = New Point(27, 315)
        AttendanceDetailsButton.Name = "AttendanceDetailsButton"
        AttendanceDetailsButton.Size = New Size(206, 76)
        AttendanceDetailsButton.TabIndex = 4
        AttendanceDetailsButton.Text = "Attendance Details"
        AttendanceDetailsButton.TextAlign = ContentAlignment.BottomCenter
        AttendanceDetailsButton.UseVisualStyleBackColor = True
        ' 
        ' LeaveEntryButton
        ' 
        LeaveEntryButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        LeaveEntryButton.ForeColor = Color.Blue
        LeaveEntryButton.Image = CType(resources.GetObject("LeaveEntryButton.Image"), Image)
        LeaveEntryButton.ImageAlign = ContentAlignment.TopCenter
        LeaveEntryButton.Location = New Point(27, 224)
        LeaveEntryButton.Name = "LeaveEntryButton"
        LeaveEntryButton.Size = New Size(206, 76)
        LeaveEntryButton.TabIndex = 3
        LeaveEntryButton.Text = "Leave Entry"
        LeaveEntryButton.TextAlign = ContentAlignment.BottomCenter
        LeaveEntryButton.UseVisualStyleBackColor = True
        ' 
        ' ClaimEntryButton
        ' 
        ClaimEntryButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        ClaimEntryButton.ForeColor = Color.Blue
        ClaimEntryButton.Image = CType(resources.GetObject("ClaimEntryButton.Image"), Image)
        ClaimEntryButton.ImageAlign = ContentAlignment.TopCenter
        ClaimEntryButton.Location = New Point(27, 131)
        ClaimEntryButton.Name = "ClaimEntryButton"
        ClaimEntryButton.Size = New Size(206, 76)
        ClaimEntryButton.TabIndex = 2
        ClaimEntryButton.Text = "Claim Entry"
        ClaimEntryButton.TextAlign = ContentAlignment.BottomCenter
        ClaimEntryButton.UseVisualStyleBackColor = True
        ' 
        ' HomeButton
        ' 
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(27, 39)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(206, 76)
        HomeButton.TabIndex = 1
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(581, 729)
        Label2.Name = "Label2"
        Label2.Size = New Size(385, 30)
        Label2.TabIndex = 17
        Label2.Text = "Copyright 2025 @ Employee Payroll System"
        ' 
        ' PictureBoxPayroll
        ' 
        PictureBoxPayroll.Image = CType(resources.GetObject("PictureBoxPayroll.Image"), Image)
        PictureBoxPayroll.Location = New Point(299, 27)
        PictureBoxPayroll.Name = "PictureBoxPayroll"
        PictureBoxPayroll.Size = New Size(316, 208)
        PictureBoxPayroll.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxPayroll.TabIndex = 20
        PictureBoxPayroll.TabStop = False
        ' 
        ' LogOutButton
        ' 
        LogOutButton.BackColor = Color.Red
        LogOutButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        LogOutButton.ForeColor = Color.White
        LogOutButton.Image = CType(resources.GetObject("LogOutButton.Image"), Image)
        LogOutButton.ImageAlign = ContentAlignment.TopCenter
        LogOutButton.Location = New Point(1155, 702)
        LogOutButton.Name = "LogOutButton"
        LogOutButton.Size = New Size(188, 77)
        LogOutButton.TabIndex = 10
        LogOutButton.Text = "Logout"
        LogOutButton.TextAlign = ContentAlignment.BottomCenter
        LogOutButton.UseVisualStyleBackColor = False
        ' 
        ' UserProfilePicture
        ' 
        UserProfilePicture.Image = CType(resources.GetObject("UserProfilePicture.Image"), Image)
        UserProfilePicture.Location = New Point(1222, 27)
        UserProfilePicture.Name = "UserProfilePicture"
        UserProfilePicture.Size = New Size(108, 152)
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        UserProfilePicture.TabIndex = 20
        UserProfilePicture.TabStop = False
        ' 
        ' UpdateProfileButton
        ' 
        UpdateProfileButton.BackColor = Color.Blue
        UpdateProfileButton.Font = New Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateProfileButton.ForeColor = Color.White
        UpdateProfileButton.ImageAlign = ContentAlignment.TopCenter
        UpdateProfileButton.Location = New Point(1202, 185)
        UpdateProfileButton.Name = "UpdateProfileButton"
        UpdateProfileButton.Size = New Size(141, 48)
        UpdateProfileButton.TabIndex = 9
        UpdateProfileButton.Text = "Update profile"
        UpdateProfileButton.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(351, 355)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 53)
        Label3.TabIndex = 17
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel2.Controls.Add(TextBoxLastPaySlip)
        Panel2.Controls.Add(TextBoxPendingClaims)
        Panel2.Controls.Add(TextWelcomeLabel)
        Panel2.Controls.Add(TextBoxLeaveBalance)
        Panel2.Controls.Add(TextLastPaySlipLabel)
        Panel2.Controls.Add(TextPendingClaimsLabel)
        Panel2.Controls.Add(TextLeaveBalanceLabel)
        Panel2.Location = New Point(299, 297)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1044, 353)
        Panel2.TabIndex = 21
        ' 
        ' TextBoxLastPaySlip
        ' 
        TextBoxLastPaySlip.BackColor = Color.CornflowerBlue
        TextBoxLastPaySlip.Font = New Font("Poppins Medium", 12F, FontStyle.Bold)
        TextBoxLastPaySlip.ForeColor = Color.White
        TextBoxLastPaySlip.Location = New Point(681, 202)
        TextBoxLastPaySlip.Multiline = True
        TextBoxLastPaySlip.Name = "TextBoxLastPaySlip"
        TextBoxLastPaySlip.Size = New Size(262, 86)
        TextBoxLastPaySlip.TabIndex = 18
        TextBoxLastPaySlip.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxPendingClaims
        ' 
        TextBoxPendingClaims.BackColor = Color.CornflowerBlue
        TextBoxPendingClaims.Font = New Font("Poppins Medium", 12F, FontStyle.Bold)
        TextBoxPendingClaims.ForeColor = Color.White
        TextBoxPendingClaims.Location = New Point(386, 202)
        TextBoxPendingClaims.Multiline = True
        TextBoxPendingClaims.Name = "TextBoxPendingClaims"
        TextBoxPendingClaims.Size = New Size(262, 86)
        TextBoxPendingClaims.TabIndex = 18
        TextBoxPendingClaims.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBoxLeaveBalance
        ' 
        TextBoxLeaveBalance.BackColor = Color.CornflowerBlue
        TextBoxLeaveBalance.Font = New Font("Poppins Medium", 12F, FontStyle.Bold)
        TextBoxLeaveBalance.ForeColor = Color.White
        TextBoxLeaveBalance.Location = New Point(86, 203)
        TextBoxLeaveBalance.Multiline = True
        TextBoxLeaveBalance.Name = "TextBoxLeaveBalance"
        TextBoxLeaveBalance.Size = New Size(262, 86)
        TextBoxLeaveBalance.TabIndex = 18
        TextBoxLeaveBalance.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextLastPaySlipLabel
        ' 
        TextLastPaySlipLabel.AutoSize = True
        TextLastPaySlipLabel.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextLastPaySlipLabel.ForeColor = Color.White
        TextLastPaySlipLabel.Location = New Point(702, 151)
        TextLastPaySlipLabel.Name = "TextLastPaySlipLabel"
        TextLastPaySlipLabel.Size = New Size(199, 49)
        TextLastPaySlipLabel.TabIndex = 17
        TextLastPaySlipLabel.Text = "Last Pay Slip"
        ' 
        ' TextPendingClaimsLabel
        ' 
        TextPendingClaimsLabel.AutoSize = True
        TextPendingClaimsLabel.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPendingClaimsLabel.ForeColor = Color.White
        TextPendingClaimsLabel.Location = New Point(400, 150)
        TextPendingClaimsLabel.Name = "TextPendingClaimsLabel"
        TextPendingClaimsLabel.Size = New Size(248, 49)
        TextPendingClaimsLabel.TabIndex = 17
        TextPendingClaimsLabel.Text = "Pending Claims"
        ' 
        ' TextLeaveBalanceLabel
        ' 
        TextLeaveBalanceLabel.AutoSize = True
        TextLeaveBalanceLabel.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextLeaveBalanceLabel.ForeColor = Color.White
        TextLeaveBalanceLabel.Location = New Point(101, 151)
        TextLeaveBalanceLabel.Name = "TextLeaveBalanceLabel"
        TextLeaveBalanceLabel.Size = New Size(229, 49)
        TextLeaveBalanceLabel.TabIndex = 17
        TextLeaveBalanceLabel.Text = "Leave Balance"
        ' 
        ' employeeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1397, 791)
        Controls.Add(Panel2)
        Controls.Add(Label3)
        Controls.Add(UserProfilePicture)
        Controls.Add(TextPayroolLabel)
        Controls.Add(PictureBoxPayroll)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(UpdateProfileButton)
        Controls.Add(LogOutButton)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "employeeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Dashboard"
        Panel1.ResumeLayout(False)
        CType(PictureBoxPayroll, ComponentModel.ISupportInitialize).EndInit()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextPayroolLabel As Label
    Friend WithEvents TextWelcomeLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBoxPayroll As PictureBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents ViewReportButton As Button
    Friend WithEvents PayGenerationButton As Button
    Friend WithEvents LoanEntryButton As Button
    Friend WithEvents EmployeeDetailsButton As Button
    Friend WithEvents AttendanceDetailsButton As Button
    Friend WithEvents LeaveEntryButton As Button
    Friend WithEvents ClaimEntryButton As Button
    Friend WithEvents LogOutButton As Button
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents UpdateProfileButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxLeaveBalance As TextBox
    Friend WithEvents TextLeaveBalanceLabel As Label
    Friend WithEvents TextBoxLastPaySlip As TextBox
    Friend WithEvents TextBoxPendingClaims As TextBox
    Friend WithEvents TextLastPaySlipLabel As Label
    Friend WithEvents TextPendingClaimsLabel As Label
End Class
