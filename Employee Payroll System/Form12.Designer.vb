<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewReport))
        DataGridViewViewReport = New DataGridView()
        ComboBoxSelectMonthYear = New ComboBox()
        HomeButton = New Button()
        CloseButton = New Button()
        ExportToPDFButton = New Button()
        TextSelectMonthYearLabel = New Label()
        Panel1 = New Panel()
        UserProfilePicture = New PictureBox()
        TextViewReportsLabel = New Label()
        TextUserNameLabel = New Label()
        RadioButtonAttendanceReport = New RadioButton()
        RadioButtonLeaveReport = New RadioButton()
        CType(DataGridViewViewReport, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridViewViewReport
        ' 
        DataGridViewViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewViewReport.Location = New Point(41, 216)
        DataGridViewViewReport.Name = "DataGridViewViewReport"
        DataGridViewViewReport.RowHeadersWidth = 51
        DataGridViewViewReport.Size = New Size(1349, 335)
        DataGridViewViewReport.TabIndex = 81
        ' 
        ' ComboBoxSelectMonthYear
        ' 
        ComboBoxSelectMonthYear.Font = New Font("Poppins Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBoxSelectMonthYear.FormattingEnabled = True
        ComboBoxSelectMonthYear.Location = New Point(702, 164)
        ComboBoxSelectMonthYear.Name = "ComboBoxSelectMonthYear"
        ComboBoxSelectMonthYear.Size = New Size(252, 40)
        ComboBoxSelectMonthYear.TabIndex = 3
        ' 
        ' HomeButton
        ' 
        HomeButton.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        HomeButton.Font = New Font("Poppins", 10.8F, FontStyle.Bold)
        HomeButton.ForeColor = Color.Blue
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = ContentAlignment.TopCenter
        HomeButton.Location = New Point(825, 579)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(181, 76)
        HomeButton.TabIndex = 6
        HomeButton.Text = "Home"
        HomeButton.TextAlign = ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = False
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.Red
        CloseButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseButton.ForeColor = Color.White
        CloseButton.Location = New Point(593, 579)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(190, 63)
        CloseButton.TabIndex = 5
        CloseButton.Text = "Close"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' ExportToPDFButton
        ' 
        ExportToPDFButton.BackColor = Color.DodgerBlue
        ExportToPDFButton.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ExportToPDFButton.ForeColor = Color.White
        ExportToPDFButton.Location = New Point(365, 579)
        ExportToPDFButton.Name = "ExportToPDFButton"
        ExportToPDFButton.Size = New Size(190, 63)
        ExportToPDFButton.TabIndex = 4
        ExportToPDFButton.Text = "Export to PDF"
        ExportToPDFButton.UseVisualStyleBackColor = False
        ' 
        ' TextSelectMonthYearLabel
        ' 
        TextSelectMonthYearLabel.AutoSize = True
        TextSelectMonthYearLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold)
        TextSelectMonthYearLabel.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TextSelectMonthYearLabel.Location = New Point(455, 157)
        TextSelectMonthYearLabel.Name = "TextSelectMonthYearLabel"
        TextSelectMonthYearLabel.Size = New Size(249, 41)
        TextSelectMonthYearLabel.TabIndex = 72
        TextSelectMonthYearLabel.Text = "Select Month/Year: "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Panel1.Controls.Add(UserProfilePicture)
        Panel1.Controls.Add(TextViewReportsLabel)
        Panel1.Controls.Add(TextUserNameLabel)
        Panel1.Location = New Point(-12, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1487, 81)
        Panel1.TabIndex = 74
        ' 
        ' UserProfilePicture
        ' 
        UserProfilePicture.Image = CType(resources.GetObject("UserProfilePicture.Image"), Image)
        UserProfilePicture.Location = New Point(1228, 18)
        UserProfilePicture.Name = "UserProfilePicture"
        UserProfilePicture.Size = New Size(81, 56)
        UserProfilePicture.SizeMode = PictureBoxSizeMode.Zoom
        UserProfilePicture.TabIndex = 21
        UserProfilePicture.TabStop = False
        ' 
        ' TextViewReportsLabel
        ' 
        TextViewReportsLabel.AutoSize = True
        TextViewReportsLabel.Font = New Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextViewReportsLabel.ForeColor = Color.White
        TextViewReportsLabel.Location = New Point(555, 0)
        TextViewReportsLabel.Name = "TextViewReportsLabel"
        TextViewReportsLabel.Size = New Size(350, 83)
        TextViewReportsLabel.TabIndex = 18
        TextViewReportsLabel.Text = "View Reports"
        ' 
        ' TextUserNameLabel
        ' 
        TextUserNameLabel.AutoSize = True
        TextUserNameLabel.Font = New Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextUserNameLabel.ForeColor = Color.DodgerBlue
        TextUserNameLabel.Location = New Point(1062, 32)
        TextUserNameLabel.Name = "TextUserNameLabel"
        TextUserNameLabel.Size = New Size(160, 30)
        TextUserNameLabel.TabIndex = 18
        TextUserNameLabel.Text = "Dominic Oppong"
        ' 
        ' RadioButtonAttendanceReport
        ' 
        RadioButtonAttendanceReport.AutoSize = True
        RadioButtonAttendanceReport.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        RadioButtonAttendanceReport.Font = New Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButtonAttendanceReport.ForeColor = Color.White
        RadioButtonAttendanceReport.Location = New Point(543, 107)
        RadioButtonAttendanceReport.Name = "RadioButtonAttendanceReport"
        RadioButtonAttendanceReport.Size = New Size(198, 34)
        RadioButtonAttendanceReport.TabIndex = 1
        RadioButtonAttendanceReport.TabStop = True
        RadioButtonAttendanceReport.Text = "Attendance Report"
        RadioButtonAttendanceReport.UseVisualStyleBackColor = False
        ' 
        ' RadioButtonLeaveReport
        ' 
        RadioButtonLeaveReport.AutoSize = True
        RadioButtonLeaveReport.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        RadioButtonLeaveReport.Font = New Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButtonLeaveReport.ForeColor = Color.White
        RadioButtonLeaveReport.Location = New Point(756, 107)
        RadioButtonLeaveReport.Name = "RadioButtonLeaveReport"
        RadioButtonLeaveReport.Size = New Size(150, 34)
        RadioButtonLeaveReport.TabIndex = 2
        RadioButtonLeaveReport.TabStop = True
        RadioButtonLeaveReport.Text = "Leave Report "
        RadioButtonLeaveReport.UseVisualStyleBackColor = False
        ' 
        ' ViewReport
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1430, 687)
        Controls.Add(RadioButtonLeaveReport)
        Controls.Add(RadioButtonAttendanceReport)
        Controls.Add(DataGridViewViewReport)
        Controls.Add(ComboBoxSelectMonthYear)
        Controls.Add(HomeButton)
        Controls.Add(CloseButton)
        Controls.Add(ExportToPDFButton)
        Controls.Add(TextSelectMonthYearLabel)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "ViewReport"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Report"
        CType(DataGridViewViewReport, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(UserProfilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridViewViewReport As DataGridView
    Friend WithEvents ComboBoxSelectMonthYear As ComboBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ExportToPDFButton As Button
    Friend WithEvents TextSelectMonthYearLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UserProfilePicture As PictureBox
    Friend WithEvents TextViewReportsLabel As Label
    Friend WithEvents TextUserNameLabel As Label
    Friend WithEvents RadioButtonAttendanceReport As RadioButton
    Friend WithEvents RadioButtonLeaveReport As RadioButton
End Class
