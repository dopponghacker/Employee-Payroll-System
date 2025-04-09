<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeDetails))
        TextPersonalInformationLabel = New Label()
        Panel1 = New Panel()
        TextAttendenceDetailsLabel = New Label()
        UserProfilePicture = New PictureBox()
        TextBoxPosition = New TextBox()
        TextBoxPhone = New TextBox()
        TextBoxLastName = New TextBox()
        TextBoxFirstName = New TextBox()
        TextDepartmentLabel = New Label()
        TextCategoryLabel = New Label()
        TextHireDateLabel = New Label()
        TextPositionLabel = New Label()
        Label4 = New Label()
        TextDobLabel = New Label()
        TextPhoneLabel = New Label()
        TextEmailLabel = New Label()
        TextLastNameLabel = New Label()
        TextFirstNameLabel = New Label()
        TextBoxDob = New TextBox()
        TextBoxGender = New TextBox()
        TextBoxDepartment = New TextBox()
        TextBoxCategory = New TextBox()
        HomeButton = New Button()
        UpdateButton = New Button()
        UploadButton = New Button()
        Label1email = New Label()
        Label2hiredate = New Label()
        TextProfessionalInformationLabel = New Label()
        Panel1.SuspendLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextPersonalInformationLabel
        ' 
        TextPersonalInformationLabel.AutoSize = True
        TextPersonalInformationLabel.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPersonalInformationLabel.ForeColor = Color.DodgerBlue
        TextPersonalInformationLabel.Location = New Point(187, 111)
        TextPersonalInformationLabel.Name = "TextPersonalInformationLabel"
        TextPersonalInformationLabel.Size = New Size(326, 49)
        TextPersonalInformationLabel.TabIndex = 30
        TextPersonalInformationLabel.Text = "Personal Information"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(TextAttendenceDetailsLabel)
        Panel1.Location = New Point(-92, -7)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1215, 81)
        Panel1.TabIndex = 31
        ' 
        ' TextAttendenceDetailsLabel
        ' 
        TextAttendenceDetailsLabel.AutoSize = True
        TextAttendenceDetailsLabel.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextAttendenceDetailsLabel.ForeColor = Color.White
        TextAttendenceDetailsLabel.Location = New Point(279, 3)
        TextAttendenceDetailsLabel.Name = "TextAttendenceDetailsLabel"
        TextAttendenceDetailsLabel.Size = New Size(452, 83)
        TextAttendenceDetailsLabel.TabIndex = 18
        TextAttendenceDetailsLabel.Text = "Employee Details"
        ' 
        ' UserProfilePicture
        ' 
        UserProfilePicture.Image = CType(resources.GetObject("UserProfilePicture.Image"), Image)
        UserProfilePicture.Location = New Point(588, 170)
        UserProfilePicture.Name = "UserProfilePicture"
        UserProfilePicture.Size = New Size(177, 223)
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        UserProfilePicture.TabIndex = 21
        UserProfilePicture.TabStop = False
        ' 
        ' TextBoxPosition
        ' 
        TextBoxPosition.BackColor = Color.LightGray
        TextBoxPosition.Location = New Point(201, 670)
        TextBoxPosition.Margin = New Padding(1)
        TextBoxPosition.Multiline = True
        TextBoxPosition.Name = "TextBoxPosition"
        TextBoxPosition.Size = New Size(312, 44)
        TextBoxPosition.TabIndex = 8
        ' 
        ' TextBoxPhone
        ' 
        TextBoxPhone.BackColor = Color.LightGray
        TextBoxPhone.Location = New Point(201, 322)
        TextBoxPhone.Margin = New Padding(1)
        TextBoxPhone.Multiline = True
        TextBoxPhone.Name = "TextBoxPhone"
        TextBoxPhone.Size = New Size(312, 43)
        TextBoxPhone.TabIndex = 3
        ' 
        ' TextBoxLastName
        ' 
        TextBoxLastName.BackColor = Color.LightGray
        TextBoxLastName.Location = New Point(201, 225)
        TextBoxLastName.Margin = New Padding(1)
        TextBoxLastName.Multiline = True
        TextBoxLastName.Name = "TextBoxLastName"
        TextBoxLastName.Size = New Size(312, 43)
        TextBoxLastName.TabIndex = 2
        ' 
        ' TextBoxFirstName
        ' 
        TextBoxFirstName.BackColor = Color.LightGray
        TextBoxFirstName.Location = New Point(201, 170)
        TextBoxFirstName.Margin = New Padding(1)
        TextBoxFirstName.Multiline = True
        TextBoxFirstName.Name = "TextBoxFirstName"
        TextBoxFirstName.Size = New Size(312, 43)
        TextBoxFirstName.TabIndex = 1
        ' 
        ' TextDepartmentLabel
        ' 
        TextDepartmentLabel.AutoSize = True
        TextDepartmentLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextDepartmentLabel.Location = New Point(34, 566)
        TextDepartmentLabel.Margin = New Padding(1, 0, 1, 0)
        TextDepartmentLabel.Name = "TextDepartmentLabel"
        TextDepartmentLabel.Size = New Size(134, 33)
        TextDepartmentLabel.TabIndex = 40
        TextDepartmentLabel.Text = "Department"
        ' 
        ' TextCategoryLabel
        ' 
        TextCategoryLabel.AutoSize = True
        TextCategoryLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextCategoryLabel.Location = New Point(52, 623)
        TextCategoryLabel.Margin = New Padding(1, 0, 1, 0)
        TextCategoryLabel.Name = "TextCategoryLabel"
        TextCategoryLabel.Size = New Size(106, 33)
        TextCategoryLabel.TabIndex = 39
        TextCategoryLabel.Text = "Category"
        ' 
        ' TextHireDateLabel
        ' 
        TextHireDateLabel.AutoSize = True
        TextHireDateLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextHireDateLabel.Location = New Point(55, 732)
        TextHireDateLabel.Margin = New Padding(1, 0, 1, 0)
        TextHireDateLabel.Name = "TextHireDateLabel"
        TextHireDateLabel.Size = New Size(105, 33)
        TextHireDateLabel.TabIndex = 38
        TextHireDateLabel.Text = "Hire Date"
        ' 
        ' TextPositionLabel
        ' 
        TextPositionLabel.AutoSize = True
        TextPositionLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPositionLabel.Location = New Point(69, 678)
        TextPositionLabel.Margin = New Padding(1, 0, 1, 0)
        TextPositionLabel.Name = "TextPositionLabel"
        TextPositionLabel.Size = New Size(91, 33)
        TextPositionLabel.TabIndex = 37
        TextPositionLabel.Text = "Position"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(66, 381)
        Label4.Margin = New Padding(1, 0, 1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 33)
        Label4.TabIndex = 36
        Label4.Text = "Gender"
        ' 
        ' TextDobLabel
        ' 
        TextDobLabel.AutoSize = True
        TextDobLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextDobLabel.Location = New Point(34, 429)
        TextDobLabel.Margin = New Padding(1, 0, 1, 0)
        TextDobLabel.Name = "TextDobLabel"
        TextDobLabel.Size = New Size(135, 33)
        TextDobLabel.TabIndex = 35
        TextDobLabel.Text = "Date of Birth"
        ' 
        ' TextPhoneLabel
        ' 
        TextPhoneLabel.AutoSize = True
        TextPhoneLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPhoneLabel.Location = New Point(77, 330)
        TextPhoneLabel.Margin = New Padding(1, 0, 1, 0)
        TextPhoneLabel.Name = "TextPhoneLabel"
        TextPhoneLabel.Size = New Size(77, 33)
        TextPhoneLabel.TabIndex = 34
        TextPhoneLabel.Text = "Phone"
        ' 
        ' TextEmailLabel
        ' 
        TextEmailLabel.AutoSize = True
        TextEmailLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextEmailLabel.Location = New Point(86, 280)
        TextEmailLabel.Margin = New Padding(1, 0, 1, 0)
        TextEmailLabel.Name = "TextEmailLabel"
        TextEmailLabel.Size = New Size(68, 33)
        TextEmailLabel.TabIndex = 33
        TextEmailLabel.Text = "Email"
        ' 
        ' TextLastNameLabel
        ' 
        TextLastNameLabel.AutoSize = True
        TextLastNameLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextLastNameLabel.Location = New Point(50, 231)
        TextLastNameLabel.Margin = New Padding(1, 0, 1, 0)
        TextLastNameLabel.Name = "TextLastNameLabel"
        TextLastNameLabel.Size = New Size(118, 33)
        TextLastNameLabel.TabIndex = 42
        TextLastNameLabel.Text = "Last Name"
        ' 
        ' TextFirstNameLabel
        ' 
        TextFirstNameLabel.AutoSize = True
        TextFirstNameLabel.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextFirstNameLabel.Location = New Point(50, 177)
        TextFirstNameLabel.Margin = New Padding(1, 0, 1, 0)
        TextFirstNameLabel.Name = "TextFirstNameLabel"
        TextFirstNameLabel.Size = New Size(119, 33)
        TextFirstNameLabel.TabIndex = 32
        TextFirstNameLabel.Text = "First Name"
        ' 
        ' TextBoxDob
        ' 
        TextBoxDob.BackColor = Color.LightGray
        TextBoxDob.Location = New Point(201, 431)
        TextBoxDob.Margin = New Padding(1)
        TextBoxDob.Multiline = True
        TextBoxDob.Name = "TextBoxDob"
        TextBoxDob.Size = New Size(312, 43)
        TextBoxDob.TabIndex = 5
        ' 
        ' TextBoxGender
        ' 
        TextBoxGender.BackColor = Color.LightGray
        TextBoxGender.Location = New Point(201, 376)
        TextBoxGender.Margin = New Padding(1)
        TextBoxGender.Multiline = True
        TextBoxGender.Name = "TextBoxGender"
        TextBoxGender.Size = New Size(312, 43)
        TextBoxGender.TabIndex = 4
        ' 
        ' TextBoxDepartment
        ' 
        TextBoxDepartment.BackColor = Color.LightGray
        TextBoxDepartment.Location = New Point(201, 558)
        TextBoxDepartment.Margin = New Padding(1)
        TextBoxDepartment.Multiline = True
        TextBoxDepartment.Name = "TextBoxDepartment"
        TextBoxDepartment.Size = New Size(312, 44)
        TextBoxDepartment.TabIndex = 6
        ' 
        ' TextBoxCategory
        ' 
        TextBoxCategory.BackColor = Color.LightGray
        TextBoxCategory.Location = New Point(201, 615)
        TextBoxCategory.Margin = New Padding(1)
        TextBoxCategory.Multiline = True
        TextBoxCategory.Name = "TextBoxCategory"
        TextBoxCategory.Size = New Size(312, 44)
        TextBoxCategory.TabIndex = 7
        ' 
        ' HomeButton
        ' 
        HomeButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(602, 608)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(144, 76)
        HomeButton.TabIndex = 11
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = False
        ' 
        ' UpdateButton
        ' 
        UpdateButton.BackColor = Color.Red
        UpdateButton.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UpdateButton.ForeColor = Color.White
        UpdateButton.Location = New Point(592, 528)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(164, 63)
        UpdateButton.TabIndex = 10
        UpdateButton.Text = "Update"
        UpdateButton.UseVisualStyleBackColor = False
        ' 
        ' UploadButton
        ' 
        UploadButton.BackColor = Color.LimeGreen
        UploadButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UploadButton.ForeColor = Color.White
        UploadButton.Location = New Point(597, 404)
        UploadButton.Name = "UploadButton"
        UploadButton.Size = New Size(164, 63)
        UploadButton.TabIndex = 9
        UploadButton.Text = "Upload Pictue"
        UploadButton.UseVisualStyleBackColor = False
        ' 
        ' Label1email
        ' 
        Label1email.AutoSize = True
        Label1email.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1email.Location = New Point(201, 280)
        Label1email.Margin = New Padding(1, 0, 1, 0)
        Label1email.Name = "Label1email"
        Label1email.Size = New Size(68, 33)
        Label1email.TabIndex = 33
        Label1email.Text = "Email"
        ' 
        ' Label2hiredate
        ' 
        Label2hiredate.AutoSize = True
        Label2hiredate.Font = New Font("Poppins SemiBold", 11.1F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2hiredate.Location = New Point(201, 732)
        Label2hiredate.Margin = New Padding(1, 0, 1, 0)
        Label2hiredate.Name = "Label2hiredate"
        Label2hiredate.Size = New Size(129, 33)
        Label2hiredate.TabIndex = 38
        Label2hiredate.Text = "Hire of Date"
        ' 
        ' TextProfessionalInformationLabel
        ' 
        TextProfessionalInformationLabel.AutoSize = True
        TextProfessionalInformationLabel.Font = New Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextProfessionalInformationLabel.ForeColor = Color.DodgerBlue
        TextProfessionalInformationLabel.Location = New Point(135, 508)
        TextProfessionalInformationLabel.Name = "TextProfessionalInformationLabel"
        TextProfessionalInformationLabel.Size = New Size(378, 49)
        TextProfessionalInformationLabel.TabIndex = 30
        TextProfessionalInformationLabel.Text = "Professional Information"
        ' 
        ' EmployeeDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(835, 811)
        Controls.Add(UploadButton)
        Controls.Add(UpdateButton)
        Controls.Add(HomeButton)
        Controls.Add(TextBoxDepartment)
        Controls.Add(TextBoxCategory)
        Controls.Add(TextBoxPosition)
        Controls.Add(TextBoxDob)
        Controls.Add(TextBoxGender)
        Controls.Add(TextBoxPhone)
        Controls.Add(TextBoxLastName)
        Controls.Add(TextBoxFirstName)
        Controls.Add(TextDepartmentLabel)
        Controls.Add(TextCategoryLabel)
        Controls.Add(Label2hiredate)
        Controls.Add(TextHireDateLabel)
        Controls.Add(TextPositionLabel)
        Controls.Add(Label4)
        Controls.Add(TextDobLabel)
        Controls.Add(TextPhoneLabel)
        Controls.Add(Label1email)
        Controls.Add(TextEmailLabel)
        Controls.Add(TextLastNameLabel)
        Controls.Add(TextFirstNameLabel)
        Controls.Add(UserProfilePicture)
        Controls.Add(TextProfessionalInformationLabel)
        Controls.Add(TextPersonalInformationLabel)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "EmployeeDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Details"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextPersonalInformationLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextAttendenceDetailsLabel As Label
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextBoxPosition As TextBox
    Friend WithEvents TextBoxPhone As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents TextDepartmentLabel As Label
    Friend WithEvents TextCategoryLabel As Label
    Friend WithEvents TextHireDateLabel As Label
    Friend WithEvents TextPositionLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextDobLabel As Label
    Friend WithEvents TextPhoneLabel As Label
    Friend WithEvents TextEmailLabel As Label
    Friend WithEvents TextLastNameLabel As Label
    Friend WithEvents TextFirstNameLabel As Label
    Friend WithEvents TextBoxDob As TextBox
    Friend WithEvents TextBoxGender As TextBox
    Friend WithEvents TextBoxDepartment As TextBox
    Friend WithEvents TextBoxCategory As TextBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents UploadButton As Button
    Friend WithEvents Label1email As Label
    Friend WithEvents Label2hiredate As Label
    Friend WithEvents TextProfessionalInformationLabel As Label
End Class
