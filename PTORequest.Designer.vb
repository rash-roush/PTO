<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PTORequest
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
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox5 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        MonthCalendar1 = New MonthCalendar()
        MonthCalendar2 = New MonthCalendar()
        Label2 = New Label()
        High = New CheckedListBox()
        Label1 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(442, 1022)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 54)
        Button1.TabIndex = 0
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(152, 9)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(142, 27)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(152, 53)
        TextBox5.Margin = New Padding(2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(142, 27)
        TextBox5.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 13)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 8
        Label3.Text = "Employee ID : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 57)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 57)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 10
        Label5.Text = "Reason :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(34, 101)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 20)
        Label6.TabIndex = 11
        Label6.Text = "Select Priority :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(34, 257)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 20)
        Label7.TabIndex = 12
        Label7.Text = "Select Start Date :"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(162, 257)
        MonthCalendar1.Margin = New Padding(7)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 13
        ' 
        ' MonthCalendar2
        ' 
        MonthCalendar2.Location = New Point(553, 257)
        MonthCalendar2.Margin = New Padding(7)
        MonthCalendar2.Name = "MonthCalendar2"
        MonthCalendar2.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(433, 257)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 20)
        Label2.TabIndex = 14
        Label2.Text = "Select End Date :"
        ' 
        ' High
        ' 
        High.FormattingEnabled = True
        High.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        High.Location = New Point(152, 109)
        High.Margin = New Padding(2)
        High.Name = "High"
        High.Size = New Size(142, 114)
        High.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(357, 54)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 21
        Label1.Text = "Last name :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(357, 54)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 20)
        Label8.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(357, 10)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(88, 20)
        Label9.TabIndex = 19
        Label9.Text = "First name : "
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(476, 50)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(142, 27)
        TextBox2.TabIndex = 18
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(476, 6)
        TextBox3.Margin = New Padding(2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(142, 27)
        TextBox3.TabIndex = 17
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(662, 491)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 44)
        Button2.TabIndex = 22
        Button2.Text = "Enter"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' PTORequest
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(828, 547)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Label8)
        Controls.Add(Label9)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(High)
        Controls.Add(MonthCalendar2)
        Controls.Add(Label2)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox5)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Margin = New Padding(2)
        Name = "PTORequest"
        Text = "PTORequest"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents High As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
End Class
