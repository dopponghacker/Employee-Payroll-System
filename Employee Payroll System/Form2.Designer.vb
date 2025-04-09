Imports FontAwesome.Sharp

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup))
        SignButton = New IconButton()
        SignupLabel = New Label()
        TextPayroolLabel = New Label()
        UserProfilePicture = New PictureBox()
        TextFirstNameLabel = New Label()
        TextLastNameLabel = New Label()
        TextEmailLabel = New Label()
        TextPhoneLabel = New Label()
        TextUsernameLabel = New Label()
        TextPasswordLabel = New Label()
        TextComfirmPasswordLabel = New Label()
        TextDobLabel = New Label()
        TextBoxFirstName = New TextBox()
        TextBoxLastName = New TextBox()
        TextBoxEmail = New TextBox()
        TextBoxPhone = New TextBox()
        TextBoxUsername = New TextBox()
        TextBoxPassword = New TextBox()
        DateTimePickerDob = New DateTimePicker()
        TextBoxComfirmPassword = New TextBox()
        TextCategoryLabel = New Label()
        ComboBoxCategory = New ComboBox()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        UploadPictureButton = New Button()
        ComboBoxGender = New ComboBox()
        ComboBoxDepartment = New ComboBox()
        TextDepartmentLabel = New Label()
        ClearButton = New IconButton()
        SendBacktologinButton = New Button()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SignButton
        ' 
        SignButton.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        SignButton.Font = New Font("Poppins SemiBold", 10.8F, FontStyle.Bold)
        SignButton.ForeColor = Color.White
        SignButton.IconChar = IconChar.None
        SignButton.IconColor = Color.Black
        SignButton.IconFont = IconFont.Auto
        SignButton.Location = New Point(27, 477)
        SignButton.Name = "SignButton"
        SignButton.Size = New Size(455, 49)
        SignButton.TabIndex = 7
        SignButton.Text = "SignUp"
        SignButton.UseVisualStyleBackColor = False
        ' 
        ' SignupLabel
        ' 
        SignupLabel.AutoSize = True
        SignupLabel.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignupLabel.Location = New Point(217, 72)
        SignupLabel.Name = "SignupLabel"
        SignupLabel.RightToLeft = RightToLeft.Yes
        SignupLabel.Size = New Size(130, 49)
        SignupLabel.TabIndex = 14
        SignupLabel.Text = "Sign Up"
        SignupLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TextPayroolLabel
        ' 
        TextPayroolLabel.AutoSize = True
        TextPayroolLabel.Font = New Font("Poppins", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPayroolLabel.Location = New Point(550, 53)
        TextPayroolLabel.Name = "TextPayroolLabel"
        TextPayroolLabel.RightToLeft = RightToLeft.Yes
        TextPayroolLabel.Size = New Size(605, 78)
        TextPayroolLabel.TabIndex = 15
        TextPayroolLabel.Text = "Employee Payroll System"
        TextPayroolLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UserProfilePicture
        ' 
        UserProfilePicture.BorderStyle = BorderStyle.FixedSingle
        UserProfilePicture.Image = CType(resources.GetObject("UserProfilePicture.Image"), Image)
        UserProfilePicture.Location = New Point(986, 176)
        UserProfilePicture.Name = "UserProfilePicture"
        UserProfilePicture.Size = New Size(228, 279)
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        UserProfilePicture.TabIndex = 12
        UserProfilePicture.TabStop = False
        ' 
        ' TextFirstNameLabel
        ' 
        TextFirstNameLabel.AutoSize = True
        TextFirstNameLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextFirstNameLabel.Location = New Point(27, 184)
        TextFirstNameLabel.Margin = New Padding(1, 0, 1, 0)
        TextFirstNameLabel.Name = "TextFirstNameLabel"
        TextFirstNameLabel.Size = New Size(119, 33)
        TextFirstNameLabel.TabIndex = 19
        TextFirstNameLabel.Text = "First Name"
        ' 
        ' TextLastNameLabel
        ' 
        TextLastNameLabel.AutoSize = True
        TextLastNameLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextLastNameLabel.Location = New Point(27, 241)
        TextLastNameLabel.Margin = New Padding(1, 0, 1, 0)
        TextLastNameLabel.Name = "TextLastNameLabel"
        TextLastNameLabel.Size = New Size(118, 33)
        TextLastNameLabel.TabIndex = 19
        TextLastNameLabel.Text = "Last Name"
        ' 
        ' TextEmailLabel
        ' 
        TextEmailLabel.AutoSize = True
        TextEmailLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextEmailLabel.Location = New Point(23, 286)
        TextEmailLabel.Margin = New Padding(1, 0, 1, 0)
        TextEmailLabel.Name = "TextEmailLabel"
        TextEmailLabel.Size = New Size(68, 33)
        TextEmailLabel.TabIndex = 19
        TextEmailLabel.Text = "Email"
        ' 
        ' TextPhoneLabel
        ' 
        TextPhoneLabel.AutoSize = True
        TextPhoneLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPhoneLabel.Location = New Point(23, 336)
        TextPhoneLabel.Margin = New Padding(1, 0, 1, 0)
        TextPhoneLabel.Name = "TextPhoneLabel"
        TextPhoneLabel.Size = New Size(77, 33)
        TextPhoneLabel.TabIndex = 19
        TextPhoneLabel.Text = "Phone"
        ' 
        ' TextUsernameLabel
        ' 
        TextUsernameLabel.AutoSize = True
        TextUsernameLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextUsernameLabel.Location = New Point(475, 287)
        TextUsernameLabel.Margin = New Padding(1, 0, 1, 0)
        TextUsernameLabel.Name = "TextUsernameLabel"
        TextUsernameLabel.Size = New Size(116, 33)
        TextUsernameLabel.TabIndex = 19
        TextUsernameLabel.Text = "Username"
        ' 
        ' TextPasswordLabel
        ' 
        TextPasswordLabel.AutoSize = True
        TextPasswordLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPasswordLabel.Location = New Point(478, 339)
        TextPasswordLabel.Margin = New Padding(1, 0, 1, 0)
        TextPasswordLabel.Name = "TextPasswordLabel"
        TextPasswordLabel.Size = New Size(109, 33)
        TextPasswordLabel.TabIndex = 19
        TextPasswordLabel.Text = "Password"
        ' 
        ' TextComfirmPasswordLabel
        ' 
        TextComfirmPasswordLabel.AutoSize = True
        TextComfirmPasswordLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextComfirmPasswordLabel.Location = New Point(478, 390)
        TextComfirmPasswordLabel.Margin = New Padding(1, 0, 1, 0)
        TextComfirmPasswordLabel.Name = "TextComfirmPasswordLabel"
        TextComfirmPasswordLabel.Size = New Size(201, 33)
        TextComfirmPasswordLabel.TabIndex = 19
        TextComfirmPasswordLabel.Text = "Comfirm Password"
        ' 
        ' TextDobLabel
        ' 
        TextDobLabel.AutoSize = True
        TextDobLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextDobLabel.Location = New Point(23, 428)
        TextDobLabel.Margin = New Padding(1, 0, 1, 0)
        TextDobLabel.Name = "TextDobLabel"
        TextDobLabel.Size = New Size(135, 33)
        TextDobLabel.TabIndex = 19
        TextDobLabel.Text = "Date of Birth"
        ' 
        ' TextBoxFirstName
        ' 
        TextBoxFirstName.BackColor = Color.LightGray
        TextBoxFirstName.Location = New Point(147, 176)
        TextBoxFirstName.Margin = New Padding(1)
        TextBoxFirstName.Multiline = True
        TextBoxFirstName.Name = "TextBoxFirstName"
        TextBoxFirstName.Size = New Size(312, 43)
        TextBoxFirstName.TabIndex = 1
        ' 
        ' TextBoxLastName
        ' 
        TextBoxLastName.BackColor = Color.LightGray
        TextBoxLastName.Location = New Point(147, 231)
        TextBoxLastName.Margin = New Padding(1)
        TextBoxLastName.Multiline = True
        TextBoxLastName.Name = "TextBoxLastName"
        TextBoxLastName.Size = New Size(312, 43)
        TextBoxLastName.TabIndex = 2
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.BackColor = Color.LightGray
        TextBoxEmail.Location = New Point(147, 280)
        TextBoxEmail.Margin = New Padding(1)
        TextBoxEmail.Multiline = True
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(312, 43)
        TextBoxEmail.TabIndex = 3
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.BackColor = Color.LightGray
        TextBoxPhone.Location = New Point(147, 328)
        TextBoxPhone.Margin = New Padding(1)
        TextBoxPhone.Multiline = True
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(312, 43)
        TextBoxPhone.TabIndex = 4
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.BackColor = Color.LightGray
        TextBoxUsername.Location = New Point(599, 277)
        TextBoxUsername.Margin = New Padding(1)
        TextBoxUsername.Multiline = True
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(312, 44)
        TextBoxUsername.TabIndex = 10
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.BackColor = Color.LightGray
        TextBoxPassword.Location = New Point(599, 329)
        TextBoxPassword.Margin = New Padding(1)
        TextBoxPassword.Multiline = True
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(312, 44)
        TextBoxPassword.TabIndex = 11
        ' 
        ' DateTimePickerDob
        ' 
        DateTimePickerDob.CalendarMonthBackground = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DateTimePickerDob.Location = New Point(160, 428)
        DateTimePickerDob.Margin = New Padding(1)
        DateTimePickerDob.Name = "DateTimePickerDob"
        DateTimePickerDob.Size = New Size(299, 27)
        DateTimePickerDob.TabIndex = 6
        ' 
        ' TextBoxComfirmPassword
        ' 
        TextBoxComfirmPassword.BackColor = Color.LightGray
        TextBoxComfirmPassword.Location = New Point(681, 380)
        TextBoxComfirmPassword.Margin = New Padding(1)
        TextBoxComfirmPassword.Multiline = True
        TextBoxComfirmPassword.Name = "TextBoxComfirmPassword"
        TextBoxComfirmPassword.Size = New Size(230, 44)
        TextBoxComfirmPassword.TabIndex = 12
        ' 
        ' TextCategoryLabel
        ' 
        TextCategoryLabel.AutoSize = True
        TextCategoryLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextCategoryLabel.Location = New Point(475, 233)
        TextCategoryLabel.Margin = New Padding(1, 0, 1, 0)
        TextCategoryLabel.Name = "TextCategoryLabel"
        TextCategoryLabel.Size = New Size(106, 33)
        TextCategoryLabel.TabIndex = 19
        TextCategoryLabel.Text = "Category"
        ' 
        ' ComboBoxCategory
        ' 
        ComboBoxCategory.FormattingEnabled = True
        ComboBoxCategory.Location = New Point(603, 231)
        ComboBoxCategory.Margin = New Padding(1)
        ComboBoxCategory.Name = "ComboBoxCategory"
        ComboBoxCategory.Size = New Size(312, 28)
        ComboBoxCategory.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 382)
        Label4.Margin = New Padding(1, 0, 1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 33)
        Label4.TabIndex = 19
        Label4.Text = "Gender"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(27, 543)
        DataGridView1.Margin = New Padding(1)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 102
        DataGridView1.Size = New Size(1187, 127)
        DataGridView1.TabIndex = 23
        ' 
        ' UploadPictureButton
        ' 
        UploadPictureButton.BackColor = Color.Blue
        UploadPictureButton.Font = New Font("Poppins SemiBold", 9.900001F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UploadPictureButton.ForeColor = Color.White
        UploadPictureButton.Location = New Point(1010, 469)
        UploadPictureButton.Margin = New Padding(1)
        UploadPictureButton.Name = "UploadPictureButton"
        UploadPictureButton.Size = New Size(185, 57)
        UploadPictureButton.TabIndex = 15
        UploadPictureButton.Text = "Upload Picture"
        UploadPictureButton.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxGender
        ' 
        ComboBoxGender.FormattingEnabled = True
        ComboBoxGender.Location = New Point(147, 384)
        ComboBoxGender.Name = "ComboBoxGender"
        ComboBoxGender.Size = New Size(312, 28)
        ComboBoxGender.TabIndex = 5
        ' 
        ' ComboBoxDepartment
        ' 
        ComboBoxDepartment.FormattingEnabled = True
        ComboBoxDepartment.Location = New Point(612, 176)
        ComboBoxDepartment.Name = "ComboBoxDepartment"
        ComboBoxDepartment.Size = New Size(299, 28)
        ComboBoxDepartment.TabIndex = 8
        ' 
        ' TextDepartmentLabel
        ' 
        TextDepartmentLabel.AutoSize = True
        TextDepartmentLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextDepartmentLabel.Location = New Point(478, 176)
        TextDepartmentLabel.Margin = New Padding(1, 0, 1, 0)
        TextDepartmentLabel.Name = "TextDepartmentLabel"
        TextDepartmentLabel.Size = New Size(134, 33)
        TextDepartmentLabel.TabIndex = 19
        TextDepartmentLabel.Text = "Department"
        ' 
        ' ClearButton
        ' 
        ClearButton.BackColor = Color.Red
        ClearButton.Font = New Font("Poppins SemiBold", 10.8F, FontStyle.Bold)
        ClearButton.ForeColor = Color.White
        ClearButton.IconChar = IconChar.None
        ClearButton.IconColor = Color.Black
        ClearButton.IconFont = IconFont.Auto
        ClearButton.Location = New Point(599, 469)
        ClearButton.Name = "ClearButton"
        ClearButton.Size = New Size(132, 46)
        ClearButton.TabIndex = 13
        ClearButton.Text = "Clear"
        ClearButton.UseVisualStyleBackColor = False
        ' 
        ' SendBacktologinButton
        ' 
        SendBacktologinButton.BackColor = Color.LimeGreen
        SendBacktologinButton.Font = New Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SendBacktologinButton.ForeColor = Color.White
        SendBacktologinButton.Location = New Point(758, 469)
        SendBacktologinButton.Name = "SendBacktologinButton"
        SendBacktologinButton.Size = New Size(176, 46)
        SendBacktologinButton.TabIndex = 14
        SendBacktologinButton.Text = "Back to Login"
        SendBacktologinButton.TextAlign = ContentAlignment.BottomCenter
        SendBacktologinButton.UseVisualStyleBackColor = False
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1301, 691)
        Controls.Add(SendBacktologinButton)
        Controls.Add(ClearButton)
        Controls.Add(ComboBoxDepartment)
        Controls.Add(ComboBoxGender)
        Controls.Add(UploadPictureButton)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBoxCategory)
        Controls.Add(DateTimePickerDob)
        Controls.Add(TextBoxComfirmPassword)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(TextBoxPhone)
        Controls.Add(TextBoxEmail)
        Controls.Add(TextBoxLastName)
        Controls.Add(TextBoxFirstName)
        Controls.Add(TextComfirmPasswordLabel)
        Controls.Add(TextDepartmentLabel)
        Controls.Add(TextCategoryLabel)
        Controls.Add(TextPasswordLabel)
        Controls.Add(TextUsernameLabel)
        Controls.Add(Label4)
        Controls.Add(TextDobLabel)
        Controls.Add(TextPhoneLabel)
        Controls.Add(TextEmailLabel)
        Controls.Add(TextLastNameLabel)
        Controls.Add(TextFirstNameLabel)
        Controls.Add(SignButton)
        Controls.Add(SignupLabel)
        Controls.Add(TextPayroolLabel)
        Controls.Add(UserProfilePicture)
        Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
        Margin = New Padding(1)
        MaximizeBox = False
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sign up"
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim signup = TryCast(obj, Signup)
        Return signup IsNot Nothing AndAlso
               EqualityComparer(Of IconButton).Default.Equals(CancelButton, signup.CancelButton)
    End Function

    Friend WithEvents SignButton As FontAwesome.Sharp.IconButton
    Friend WithEvents SignupLabel As Label
    Friend WithEvents TextPayroolLabel As Label
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextFirstNameLabel As Label
    Friend WithEvents TextLastNameLabel As Label
    Friend WithEvents TextEmailLabel As Label
    Friend WithEvents TextPhoneLabel As Label
    Friend WithEvents TextUsernameLabel As Label
    Friend WithEvents TextPasswordLabel As Label
    Friend WithEvents TextComfirmPasswordLabel As Label
    Friend WithEvents TextDobLabel As Label
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents DateTimePickerDob As DateTimePicker
    Friend WithEvents TextBoxComfirmPassword As TextBox
    Friend WithEvents TextCategoryLabel As Label
    Friend WithEvents ComboBoxCategory As ComboBox
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents CancelButton As FontAwesome.Sharp.IconButton
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UploadPictureButton As Button
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents ComboBoxDepartment As ComboBox
    Friend WithEvents TextDepartmentLabel As Label
    Friend WithEvents ClearButton As FontAwesome.Sharp.IconButton
    Friend WithEvents CancelButton1 As IconButton
    Friend WithEvents SendBacktologinButton As Button
End Class
