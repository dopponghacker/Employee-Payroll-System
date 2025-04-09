<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        TextPayroolLabel = New Label()
        PictureBox1 = New PictureBox()
        PercentageLabel = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(169, 361)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(569, 53)
        ProgressBar1.TabIndex = 0
        ' 
        ' Timer1
        ' 
        ' 
        ' TextPayroolLabel
        ' 
        TextPayroolLabel.AutoSize = True
        TextPayroolLabel.Font = New Font("Poppins", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextPayroolLabel.ForeColor = Color.White
        TextPayroolLabel.Location = New Point(140, 25)
        TextPayroolLabel.Name = "TextPayroolLabel"
        TextPayroolLabel.RightToLeft = RightToLeft.Yes
        TextPayroolLabel.Size = New Size(605, 78)
        TextPayroolLabel.TabIndex = 15
        TextPayroolLabel.Text = "Employee Payroll System"
        TextPayroolLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(266, 69)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(398, 305)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' PercentageLabel
        ' 
        PercentageLabel.AutoSize = True
        PercentageLabel.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PercentageLabel.ForeColor = Color.White
        PercentageLabel.Location = New Point(428, 317)
        PercentageLabel.Name = "PercentageLabel"
        PercentageLabel.RightToLeft = RightToLeft.Yes
        PercentageLabel.Size = New Size(115, 41)
        PercentageLabel.TabIndex = 15
        PercentageLabel.Text = "Loading"
        PercentageLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DodgerBlue
        Label2.Location = New Point(729, 45)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.Yes
        Label2.Size = New Size(69, 41)
        Label2.TabIndex = 15
        Label2.Text = "V.20"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' SplashScreen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        ClientSize = New Size(905, 437)
        Controls.Add(Label2)
        Controls.Add(TextPayroolLabel)
        Controls.Add(ProgressBar1)
        Controls.Add(PercentageLabel)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "SplashScreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splash Screen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextPayroolLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PercentageLabel As Label
    Friend WithEvents Label2 As Label
End Class
