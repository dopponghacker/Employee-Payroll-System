
Friend Class EemployeeForm
    Private employeeID As Integer

    Public Sub New(employeeID As Integer)
        Me.employeeID = employeeID
    End Sub

    Friend Sub Show()
        Throw New NotImplementedException()
    End Sub
End Class
