<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeaveEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LeaveEntry))
        ComboBoxLeaveType = New ComboBox()
        HomeButton = New Button()
        SubmitButton = New Button()
        CancelButton = New Button()
        TextBoxReason = New TextBox()
        Panel1 = New Panel()
        UserProfilePicture = New PictureBox()
        TextLeaveEntryLabel = New Label()
        TextUserNameLabel = New Label()
        TextReasonLabel = New Label()
        TextLeaveTypeLabel = New Label()
        TextStartDateLabel = New Label()
        DateTimePickerStartDate = New DateTimePicker()
        TextEndDateLabel = New Label()
        DateTimePickerEndDate = New DateTimePicker()
        Panel1.SuspendLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBoxLeaveType
        ' 
        ComboBoxLeaveType.BackColor = Color.DodgerBlue
        ComboBoxLeaveType.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold)
        ComboBoxLeaveType.ForeColor = Color.White
        ComboBoxLeaveType.FormattingEnabled = True
        ComboBoxLeaveType.Location = New Point(326, 136)
        ComboBoxLeaveType.Name = "ComboBoxLeaveType"
        ComboBoxLeaveType.Size = New Size(256, 40)
        ComboBoxLeaveType.TabIndex = 1
        ' 
        ' HomeButton
        ' 
        HomeButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(565, 504)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(181, 76)
        HomeButton.TabIndex = 7
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = False
        ' 
        ' SubmitButton
        ' 
        SubmitButton.BackColor = Color.DodgerBlue
        SubmitButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubmitButton.ForeColor = Color.White
        SubmitButton.Location = New Point(196, 506)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(146, 62)
        SubmitButton.TabIndex = 5
        SubmitButton.Text = "Submit"
        SubmitButton.UseVisualStyleBackColor = False
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.Red
        CancelButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CancelButton.ForeColor = Color.White
        CancelButton.Location = New Point(374, 505)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(108, 63)
        CancelButton.TabIndex = 6
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' TextBoxReason
        ' 
        TextBoxReason.BackColor = Color.DodgerBlue
        TextBoxReason.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold)
        TextBoxReason.ForeColor = Color.White
        TextBoxReason.Location = New Point(326, 324)
        TextBoxReason.Multiline = True
        TextBoxReason.Name = "TextBoxReason"
        TextBoxReason.Size = New Size(300, 124)
        TextBoxReason.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(UserProfilePicture)
        Panel1.Controls.Add(TextLeaveEntryLabel)
        Panel1.Controls.Add(TextUserNameLabel)
        Panel1.Location = New Point(-34, -4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1215, 81)
        Panel1.TabIndex = 29
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
        ' TextLeaveEntryLabel
        ' 
        TextLeaveEntryLabel.AutoSize = True
        TextLeaveEntryLabel.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextLeaveEntryLabel.ForeColor = Color.White
        TextLeaveEntryLabel.Location = New Point(331, 2)
        TextLeaveEntryLabel.Name = "TextLeaveEntryLabel"
        TextLeaveEntryLabel.Size = New Size(312, 83)
        TextLeaveEntryLabel.TabIndex = 18
        TextLeaveEntryLabel.Text = "Leave Entry"
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
        TextReasonLabel.Location = New Point(177, 359)
        TextReasonLabel.Name = "TextReasonLabel"
        TextReasonLabel.Size = New Size(143, 53)
        TextReasonLabel.TabIndex = 26
        TextReasonLabel.Text = "Reason "
        ' 
        ' TextLeaveTypeLabel
        ' 
        TextLeaveTypeLabel.AutoSize = True
        TextLeaveTypeLabel.Font = New Font("Poppins SemiBold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextLeaveTypeLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextLeaveTypeLabel.Location = New Point(126, 121)
        TextLeaveTypeLabel.Name = "TextLeaveTypeLabel"
        TextLeaveTypeLabel.Size = New Size(194, 53)
        TextLeaveTypeLabel.TabIndex = 27
        TextLeaveTypeLabel.Text = "Leave Type"
        ' 
        ' TextStartDateLabel
        ' 
        TextStartDateLabel.AutoSize = True
        TextStartDateLabel.Font = New Font("Poppins SemiBold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextStartDateLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextStartDateLabel.Location = New Point(143, 189)
        TextStartDateLabel.Name = "TextStartDateLabel"
        TextStartDateLabel.Size = New Size(177, 53)
        TextStartDateLabel.TabIndex = 28
        TextStartDateLabel.Text = "Start Date"
        ' 
        ' DateTimePickerStartDate
        ' 
        DateTimePickerStartDate.Location = New Point(326, 202)
        DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        DateTimePickerStartDate.Size = New Size(256, 27)
        DateTimePickerStartDate.TabIndex = 2
        ' 
        ' TextEndDateLabel
        ' 
        TextEndDateLabel.AutoSize = True
        TextEndDateLabel.Font = New Font("Poppins SemiBold", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextEndDateLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextEndDateLabel.Location = New Point(161, 255)
        TextEndDateLabel.Name = "TextEndDateLabel"
        TextEndDateLabel.Size = New Size(159, 53)
        TextEndDateLabel.TabIndex = 28
        TextEndDateLabel.Text = "End Date"
        ' 
        ' DateTimePickerEndDate
        ' 
        DateTimePickerEndDate.Location = New Point(326, 268)
        DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        DateTimePickerEndDate.Size = New Size(256, 27)
        DateTimePickerEndDate.TabIndex = 3
        ' 
        ' LeaveEntry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(973, 625)
        Controls.Add(DateTimePickerEndDate)
        Controls.Add(DateTimePickerStartDate)
        Controls.Add(ComboBoxLeaveType)
        Controls.Add(HomeButton)
        Controls.Add(SubmitButton)
        Controls.Add(CancelButton)
        Controls.Add(TextBoxReason)
        Controls.Add(Panel1)
        Controls.Add(TextReasonLabel)
        Controls.Add(TextLeaveTypeLabel)
        Controls.Add(TextEndDateLabel)
        Controls.Add(TextStartDateLabel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "LeaveEntry"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Leave Entry"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBoxLeaveType As ComboBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents SubmitButton As Button
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents CancelButton As Button
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents TextBoxReason As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextLeaveEntryLabel As Label
    Friend WithEvents TextUserNameLabel As Label
    Friend WithEvents TextReasonLabel As Label
    Friend WithEvents TextLeaveTypeLabel As Label
    Friend WithEvents TextStartDateLabel As Label
    Friend WithEvents DateTimePickerStartDate As DateTimePicker
    Friend WithEvents TextEndDateLabel As Label
    Friend WithEvents DateTimePickerEndDate As DateTimePicker
End Class
