<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        TextForgetPasswordButton = New Button()
        Panel2 = New Panel()
        TextBoxPassword = New TextBox()
        PictureBox3 = New PictureBox()
        Panel1 = New Panel()
        TextBoxUsername = New TextBox()
        PictureBox2 = New PictureBox()
        SignupButton = New FontAwesome.Sharp.IconButton()
        LoginButton = New FontAwesome.Sharp.IconButton()
        Label2 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        TextPayroolLabel = New Label()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextForgetPasswordButton
        ' 
        TextForgetPasswordButton.Font = New Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextForgetPasswordButton.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        TextForgetPasswordButton.Location = New Point(228, 350)
        TextForgetPasswordButton.Margin = New Padding(1)
        TextForgetPasswordButton.Name = "TextForgetPasswordButton"
        TextForgetPasswordButton.Size = New Size(204, 28)
        TextForgetPasswordButton.TabIndex = 3
        TextForgetPasswordButton.Text = "Forget password?"
        TextForgetPasswordButton.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(TextBoxPassword)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(41, 290)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(391, 56)
        Panel2.TabIndex = 17
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.BackColor = Color.White
        TextBoxPassword.BorderStyle = BorderStyle.FixedSingle
        TextBoxPassword.Font = New Font("Poppins", 11.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxPassword.ForeColor = Color.Gray
        TextBoxPassword.Location = New Point(68, 10)
        TextBoxPassword.Multiline = True
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PlaceholderText = "Enter your password"
        TextBoxPassword.Size = New Size(304, 36)
        TextBoxPassword.TabIndex = 2
        TextBoxPassword.UseSystemPasswordChar = True
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
        Panel1.Controls.Add(TextBoxUsername)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(41, 228)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(391, 56)
        Panel1.TabIndex = 18
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.BackColor = Color.White
        TextBoxUsername.BorderStyle = BorderStyle.FixedSingle
        TextBoxUsername.Font = New Font("Poppins", 11.1F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBoxUsername.ForeColor = Color.Gray
        TextBoxUsername.Location = New Point(68, 10)
        TextBoxUsername.Multiline = True
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.PlaceholderText = "Enter your username"
        TextBoxUsername.Size = New Size(304, 35)
        TextBoxUsername.TabIndex = 1
        TextBoxUsername.UseSystemPasswordChar = True
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
        ' SignupButton
        ' 
        SignupButton.BackColor = Color.Transparent
        SignupButton.Font = New Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignupButton.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        SignupButton.IconChar = FontAwesome.Sharp.IconChar.None
        SignupButton.IconColor = Color.Black
        SignupButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        SignupButton.Location = New Point(293, 457)
        SignupButton.Name = "SignupButton"
        SignupButton.Size = New Size(95, 38)
        SignupButton.TabIndex = 5
        SignupButton.Text = "Sign Up"
        SignupButton.UseVisualStyleBackColor = False
        ' 
        ' LoginButton
        ' 
        LoginButton.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        LoginButton.Cursor = Cursors.Hand
        LoginButton.Font = New Font("Poppins SemiBold", 10.8F, FontStyle.Bold)
        LoginButton.ForeColor = Color.White
        LoginButton.IconChar = FontAwesome.Sharp.IconChar.None
        LoginButton.IconColor = Color.Black
        LoginButton.IconFont = FontAwesome.Sharp.IconFont.Auto
        LoginButton.Location = New Point(41, 397)
        LoginButton.Name = "LoginButton"
        LoginButton.Size = New Size(391, 48)
        LoginButton.TabIndex = 4
        LoginButton.Text = "Login"
        LoginButton.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Location = New Point(60, 464)
        Label2.Name = "Label2"
        Label2.Size = New Size(227, 26)
        Label2.TabIndex = 14
        Label2.Text = "Don't you have an account?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(44, 148)
        Label3.Name = "Label3"
        Label3.RightToLeft = RightToLeft.No
        Label3.Size = New Size(350, 52)
        Label3.TabIndex = 11
        Label3.Text = "your payroll portal.  Access your information " & vbCrLf & "and manage your payments with ease."
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(41, 100)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.Yes
        Label1.Size = New Size(193, 49)
        Label1.TabIndex = 12
        Label1.Text = "Welcome to"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextPayroolLabel
        ' 
        TextPayroolLabel.AutoSize = True
        TextPayroolLabel.Font = New Font("Poppins", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPayroolLabel.Location = New Point(481, 77)
        TextPayroolLabel.Name = "TextPayroolLabel"
        TextPayroolLabel.RightToLeft = RightToLeft.Yes
        TextPayroolLabel.Size = New Size(372, 156)
        TextPayroolLabel.TabIndex = 13
        TextPayroolLabel.Text = "Employee " & vbCrLf & "Payroll System"
        TextPayroolLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(477, 227)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(367, 268)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(894, 572)
        Controls.Add(TextForgetPasswordButton)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(SignupButton)
        Controls.Add(LoginButton)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(TextPayroolLabel)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextForgetPasswordButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SignupButton As FontAwesome.Sharp.IconButton
    Private WithEvents LoginButton As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextPayroolLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
