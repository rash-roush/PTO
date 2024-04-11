Public Class DBHandler
    ' temporary DB:
    Private employeeDatabase As New List(Of String)

    ' Form's constructor or Load event to populate your "database"
    Private Sub DBHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the list with some employee IDs
        employeeDatabase.Add("81777")
        employeeDatabase.Add("63930")
        employeeDatabase.Add("42170")
        employeeDatabase.Add("11111")
        ' Add more as needed
    End Sub

    ' This event is triggered when the Enter button is clicked

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub user(sender As Object, e As EventArgs)

    End Sub

    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if the textbox is empty
        If TextBox1.Text = String.Empty Then
            MessageBox.Show("Enter a valid Employee Id.", "Error")
            Return
        End If

        ' Check if the entered ID exists in the "database"
        Dim enteredID As String = TextBox1.Text
        If employeeDatabase.Contains(enteredID) Then
            ' The ID exists, you can proceed with opening the MainPage or whatever action is needed
            MainPage.Show()
        Else
            ' The ID does not exist, show an error message
            MessageBox.Show("Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
