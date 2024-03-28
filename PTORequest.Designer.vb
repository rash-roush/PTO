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
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        MonthCalendar1 = New MonthCalendar()
        MonthCalendar2 = New MonthCalendar()
        Label2 = New Label()
        High = New CheckedListBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(552, 1278)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 68)
        Button1.TabIndex = 0
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(280, 47)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(176, 31)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(280, 102)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(176, 31)
        TextBox5.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 6
        Label1.Text = "Label1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(131, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 25)
        Label3.TabIndex = 8
        Label3.Text = "Employee ID : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(131, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 25)
        Label4.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(131, 108)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 25)
        Label5.TabIndex = 10
        Label5.Text = "Reason :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(132, 163)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 25)
        Label6.TabIndex = 11
        Label6.Text = "Select Priority :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(99, 438)
        Label7.Name = "Label7"
        Label7.Size = New Size(150, 25)
        Label7.TabIndex = 12
        Label7.Text = "Select Start Date :"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(280, 438)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 13
        ' 
        ' MonthCalendar2
        ' 
        MonthCalendar2.Location = New Point(280, 752)
        MonthCalendar2.Name = "MonthCalendar2"
        MonthCalendar2.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(99, 752)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 14
        Label2.Text = "Select End Date :"
        ' 
        ' High
        ' 
        High.FormattingEnabled = True
        High.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        High.Location = New Point(280, 172)
        High.Name = "High"
        High.Size = New Size(176, 144)
        High.TabIndex = 16
        ' 
        ' PTORequest
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 1395)
        Controls.Add(High)
        Controls.Add(MonthCalendar2)
        Controls.Add(Label2)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Name = "PTORequest"
        Text = "PTORequest"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents Label2 As Label
    Friend WithEvents High As CheckedListBox
End Class
