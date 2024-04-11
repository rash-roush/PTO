Public Class MainPage
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        For Each itemChecked In CheckedListBox1.CheckedItems
            Select Case itemChecked.ToString()
                Case "Document"
                    Dim frm As New PTODocumentation
                    frm.Show()
                Case "History"
                    Dim frm As New PTOHistory
                    frm.Show()
                Case "Plan"
                    Dim frm As New PTOPlan
                    frm.Show()
                Case "Request"
                    Dim frm As New PTORequest
                    frm.Show()
                Case "Schedule"
                    Dim frm As New Schedule
                    frm.Show()
            End Select
        Next
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class