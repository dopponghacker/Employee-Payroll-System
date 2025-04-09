<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        TextResetPasswordLabel = New Label()
        Panel2 = New Panel()
        TextBoxNewPassword = New TextBox()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        TextBoxRegisteredEmail = New TextBox()
        PictureBox2 = New PictureBox()
        TextPayroolLabel = New Label()
        PictureBox1 = New PictureBox()
        ResetPasswordButton = New FontAwesome.Sharp.IconButton()
        Panel3 = New Panel()
        TextBoxVerifyEmail = New TextBox()
        PictureBox4 = New PictureBox()
        Panel4 = New Panel()
        TextBoxComfirmNewPassword = New TextBox()
        PictureBox5 = New PictureBox()
        BackToLoginButton = New FontAwesome.Sharp.IconButton()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextResetPasswordLabel
        ' 
        TextResetPasswordLabel.AutoSize = True
        TextResetPasswordLabel.Font = New Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextResetPasswordLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextResetPasswordLabel.Location = New Point(76, 48)
        TextResetPasswordLabel.Name = "TextResetPasswordLabel"
        TextResetPasswordLabel.Size = New Size(352, 70)
        TextResetPasswordLabel.TabIndex = 73
        TextResetPasswordLabel.Text = "Reset Password"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBoxNewPassword)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(56, 287)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(391, 56)
        Panel2.TabIndex = 74
        ' 
        ' TextBoxNewPassword
        ' 
        TextBoxNewPassword.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBoxNewPassword.BorderStyle = BorderStyle.FixedSingle
        TextBoxNewPassword.Font = New Font("Poppins", 11.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxNewPassword.ForeColor = Color.Gray
        TextBoxNewPassword.Location = New Point(68, 10)
        TextBoxNewPassword.Multiline = True
        TextBoxNewPassword.Name = "TextBoxNewPassword"
        TextBoxNewPassword.Size = New Size(304, 36)
        TextBoxNewPassword.TabIndex = 3
        TextBoxNewPassword.Text = "New Password"
        TextBoxNewPassword.UseSystemPasswordChar = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 6)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(62, 48)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBoxRegisteredEmail)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(56, 147)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(391, 56)
        Panel1.TabIndex = 75
        ' 
        ' TextBoxRegisteredEmail
        ' 
        TextBoxRegisteredEmail.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBoxRegisteredEmail.BorderStyle = BorderStyle.FixedSingle
        TextBoxRegisteredEmail.Font = New Font("Poppins", 11.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxRegisteredEmail.ForeColor = Color.Gray
        TextBoxRegisteredEmail.Location = New Point(68, 10)
        TextBoxRegisteredEmail.Multiline = True
        TextBoxRegisteredEmail.Name = "TextBoxRegisteredEmail"
        TextBoxRegisteredEmail.Size = New Size(304, 35)
        TextBoxRegisteredEmail.TabIndex = 1
        TextBoxRegisteredEmail.Text = " Enter your registered email"
        TextBoxRegisteredEmail.UseSystemPasswordChar = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(62, 48)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' TextPayroolLabel
        ' 
        TextPayroolLabel.AutoSize = True
        TextPayroolLabel.Font = New Font("Poppins", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPayroolLabel.Location = New Point(509, 92)
        TextPayroolLabel.Name = "TextPayroolLabel"
        TextPayroolLabel.RightToLeft = RightToLeft.Yes
        TextPayroolLabel.Size = New Size(372, 156)
        TextPayroolLabel.TabIndex = 77
        TextPayroolLabel.Text = "Employee " & vbCrLf & "Payroll System"
        TextPayroolLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(505, 242)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(367, 268)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 76
        PictureBox1.TabStop = False
        ' 
        ' ResetPasswordButton
        ' 
        ResetPasswordButton.BackColor = Color.Red
        ResetPasswordButton.Cursor = Cursors.Hand
        ResetPasswordButton.Font = New Font("Poppins SemiBold", 10.8F, FontStyle.Bold)
        ResetPasswordButton.ForeColor = Color.White
        ResetPasswordButton.IconChar = FontAwesome.Sharp.IconChar.None
        ResetPasswordButton.IconColor = Color.Black
        ResetPasswordButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        ResetPasswordButton.Location = New Point(56, 462)
        ResetPasswordButton.Name = "ResetPasswordButton"
        ResetPasswordButton.Size = New Size(189, 48)
        ResetPasswordButton.TabIndex = 5
        ResetPasswordButton.Text = " Rest Password"
        ResetPasswordButton.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TextBoxVerifyEmail)
        Panel3.Controls.Add(PictureBox4)
        Panel3.Location = New Point(56, 209)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(391, 56)
        Panel3.TabIndex = 75
        ' 
        ' TextBoxVerifyEmail
        ' 
        TextBoxVerifyEmail.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBoxVerifyEmail.BorderStyle = BorderStyle.FixedSingle
        TextBoxVerifyEmail.Font = New Font("Poppins", 11.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxVerifyEmail.ForeColor = Color.Gray
        TextBoxVerifyEmail.Location = New Point(68, 10)
        TextBoxVerifyEmail.Multiline = True
        TextBoxVerifyEmail.Name = "TextBoxVerifyEmail"
        TextBoxVerifyEmail.Size = New Size(304, 35)
        TextBoxVerifyEmail.TabIndex = 2
        TextBoxVerifyEmail.Text = "Verify Email"
        TextBoxVerifyEmail.UseSystemPasswordChar = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(3, 7)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(62, 48)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(TextBoxComfirmNewPassword)
        Panel4.Controls.Add(PictureBox5)
        Panel4.Location = New Point(56, 366)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(391, 56)
        Panel4.TabIndex = 74
        ' 
        ' TextBoxComfirmNewPassword
        ' 
        TextBoxComfirmNewPassword.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TextBoxComfirmNewPassword.BorderStyle = BorderStyle.FixedSingle
        TextBoxComfirmNewPassword.Font = New Font("Poppins", 11.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxComfirmNewPassword.ForeColor = Color.Gray
        TextBoxComfirmNewPassword.Location = New Point(68, 10)
        TextBoxComfirmNewPassword.Multiline = True
        TextBoxComfirmNewPassword.Name = "TextBoxComfirmNewPassword"
        TextBoxComfirmNewPassword.Size = New Size(304, 36)
        TextBoxComfirmNewPassword.TabIndex = 4
        TextBoxComfirmNewPassword.Text = "Confirm New Password"
        TextBoxComfirmNewPassword.UseSystemPasswordChar = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(3, 6)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(62, 48)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 7
        PictureBox5.TabStop = False
        ' 
        ' BackToLoginButton
        ' 
        BackToLoginButton.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        BackToLoginButton.Cursor = Cursors.Hand
        BackToLoginButton.Font = New Font("Poppins SemiBold", 10.8F, FontStyle.Bold)
        BackToLoginButton.ForeColor = Color.White
        BackToLoginButton.IconChar = FontAwesome.Sharp.IconChar.None
        BackToLoginButton.IconColor = Color.Black
        BackToLoginButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        BackToLoginButton.Location = New Point(258, 462)
        BackToLoginButton.Name = "BackToLoginButton"
        BackToLoginButton.Size = New Size(189, 48)
        BackToLoginButton.TabIndex = 6
        BackToLoginButton.Text = "Back to Login"
        BackToLoginButton.UseVisualStyleBackColor = False
        ' 
        ' ForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 610)
        Controls.Add(BackToLoginButton)
        Controls.Add(ResetPasswordButton)
        Controls.Add(TextPayroolLabel)
        Controls.Add(PictureBox1)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(TextResetPasswordLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ForgotPassword"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Forgot Password"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextResetPasswordLabel As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxNewPassword As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxRegisteredEmail As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextPayroolLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents ResetPasswordButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBoxVerifyEmail As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBoxComfirmNewPassword As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Private WithEvents BackToLoginButton As FontAwesome.Sharp.IconButton
End Class
