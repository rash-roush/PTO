Public Class Employee
    Public Property ID As String
    Public Property Title As String

    Public Sub New(ByVal id As String, ByVal title As String)
        Me.ID = id
        Me.Title = title
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class