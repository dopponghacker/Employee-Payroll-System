Friend Class PaymentHistoryForm
    Private currentEmployeeID As Integer
    Private currentUsername As String

    Public Sub New(currentEmployeeID As Integer, currentUsername As String)
        Me.currentEmployeeID = currentEmployeeID
        Me.currentUsername = currentUsername
    End Sub

    Friend Sub Show()
        Throw New NotImplementedException()
    End Sub
End Class
