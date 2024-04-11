<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        btnEnter = New Button()
        CheckedListBox1 = New CheckedListBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(178, 254)
        btnEnter.Margin = New Padding(4)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(118, 44)
        btnEnter.TabIndex = 0
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Document", "History", "Plan", "Request", "Schedule"})
        CheckedListBox1.Location = New Point(62, 77)
        CheckedListBox1.Margin = New Padding(4)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(198, 144)
        CheckedListBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 24)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 25)
        Label1.TabIndex = 2
        Label1.Text = "Select Option :"
        ' 
        ' MainPage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(321, 311)
        Controls.Add(Label1)
        Controls.Add(CheckedListBox1)
        Controls.Add(btnEnter)
        Margin = New Padding(4)
        Name = "MainPage"
        Text = "Main Page"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label1 As Label
End Class
