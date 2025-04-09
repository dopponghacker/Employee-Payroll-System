<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendanceDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendanceDetails))
        FilterButton = New Button()
        Panel1 = New Panel()
        UserProfilePicture = New PictureBox()
        TextAttendanceDetailsLabel = New Label()
        TextStartDateLabel = New Label()
        DataGridViewAttendance = New DataGridView()
        TextEndDateLabel = New Label()
        HomeButton = New Button()
        DateTimePickerEndDate = New DateTimePicker()
        DateTimePickerStartDate = New DateTimePicker()
        ExportButton = New Button()
        SaveFileDialog1 = New SaveFileDialog()
        Panel1.SuspendLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' FilterButton
        ' 
        FilterButton.BackColor = Color.Red
        FilterButton.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FilterButton.ForeColor = Color.White
        FilterButton.Location = New Point(127, 200)
        FilterButton.Name = "FilterButton"
        FilterButton.Size = New Size(164, 63)
        FilterButton.TabIndex = 3
        FilterButton.Text = "Filter"
        FilterButton.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(UserProfilePicture)
        Panel1.Controls.Add(TextAttendanceDetailsLabel)
        Panel1.Location = New Point(-25, -10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1215, 81)
        Panel1.TabIndex = 29
        ' 
        ' UserProfilePicture
        ' 
        UserProfilePicture.Image = CType(resources.GetObject("UserProfilePicture.Image"), Image)
        UserProfilePicture.Location = New Point(1041, 16)
        UserProfilePicture.Name = "UserProfilePicture"
        UserProfilePicture.Size = New Size(76, 56)
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        UserProfilePicture.TabIndex = 21
        UserProfilePicture.TabStop = False
        ' 
        ' TextAttendanceDetailsLabel
        ' 
        TextAttendanceDetailsLabel.AutoSize = True
        TextAttendanceDetailsLabel.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextAttendanceDetailsLabel.ForeColor = Color.White
        TextAttendanceDetailsLabel.Location = New Point(386, 7)
        TextAttendanceDetailsLabel.Name = "TextAttendanceDetailsLabel"
        TextAttendanceDetailsLabel.Size = New Size(500, 83)
        TextAttendanceDetailsLabel.TabIndex = 18
        TextAttendanceDetailsLabel.Text = "Attendance Details"
        ' 
        ' TextStartDateLabel
        ' 
        TextStartDateLabel.AutoSize = True
        TextStartDateLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextStartDateLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextStartDateLabel.Location = New Point(127, 144)
        TextStartDateLabel.Name = "TextStartDateLabel"
        TextStartDateLabel.Size = New Size(177, 53)
        TextStartDateLabel.TabIndex = 28
        TextStartDateLabel.Text = "Start Date"
        ' 
        ' DataGridViewAttendance
        ' 
        DataGridViewAttendance.BackgroundColor = Color.DodgerBlue
        DataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewAttendance.Location = New Point(86, 269)
        DataGridViewAttendance.Name = "DataGridViewAttendance"
        DataGridViewAttendance.RowHeadersWidth = 51
        DataGridViewAttendance.Size = New Size(981, 282)
        DataGridViewAttendance.TabIndex = 34
        ' 
        ' TextEndDateLabel
        ' 
        TextEndDateLabel.AutoSize = True
        TextEndDateLabel.Font = New Font("Poppins SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextEndDateLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextEndDateLabel.Location = New Point(598, 144)
        TextEndDateLabel.Name = "TextEndDateLabel"
        TextEndDateLabel.Size = New Size(159, 53)
        TextEndDateLabel.TabIndex = 28
        TextEndDateLabel.Text = "End Date"
        ' 
        ' HomeButton
        ' 
        HomeButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(622, 609)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(144, 76)
        HomeButton.TabIndex = 6
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = False
        ' 
        ' DateTimePickerEndDate
        ' 
        DateTimePickerEndDate.Location = New Point(752, 157)
        DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        DateTimePickerEndDate.Size = New Size(250, 27)
        DateTimePickerEndDate.TabIndex = 2
        ' 
        ' DateTimePickerStartDate
        ' 
        DateTimePickerStartDate.Location = New Point(310, 157)
        DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        DateTimePickerStartDate.Size = New Size(250, 27)
        DateTimePickerStartDate.TabIndex = 1
        ' 
        ' ExportButton
        ' 
        ExportButton.BackColor = Color.LimeGreen
        ExportButton.Font = New Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExportButton.ForeColor = Color.White
        ExportButton.Location = New Point(396, 613)
        ExportButton.Name = "ExportButton"
        ExportButton.Size = New Size(164, 63)
        ExportButton.TabIndex = 5
        ExportButton.Text = "Export"
        ExportButton.UseVisualStyleBackColor = False
        ' 
        ' AttendanceDetails
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1192, 814)
        Controls.Add(DateTimePickerStartDate)
        Controls.Add(DateTimePickerEndDate)
        Controls.Add(HomeButton)
        Controls.Add(ExportButton)
        Controls.Add(FilterButton)
        Controls.Add(Panel1)
        Controls.Add(TextEndDateLabel)
        Controls.Add(TextStartDateLabel)
        Controls.Add(DataGridViewAttendance)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "AttendanceDetails"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Attendance Details"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents FilterButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextAttendanceDetailsLabel As Label
    Friend WithEvents TextStartDateLabel As Label
    Friend WithEvents DataGridViewAttendance As DataGridView
    Friend WithEvents TextEndDateLabel As Label
    Friend WithEvents HomeButton As Button
    Friend WithEvents DateTimePickerEndDate As DateTimePicker
    Friend WithEvents DateTimePickerStartDate As DateTimePicker
    Friend WithEvents ExportButton As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
