Imports System.Windows.Controls

Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        PercentageLabel.Text = ProgressBar1.Value & "%"
        If (ProgressBar1.Value = 100) Then
            Timer1.Stop()
            Me.Hide()
            Dim loginForm As New Login()
            loginForm.Show()
        End If
    End Sub
End Class