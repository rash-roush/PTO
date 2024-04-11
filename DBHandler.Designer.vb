<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DBHandler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBHandler))
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CheckedListBox1 = New CheckedListBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(441, 20)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(226, 31)
        TextBox1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(259, 24)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 25)
        Label1.TabIndex = 4
        Label1.Text = "Employee ID: "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(512, 352)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 58)
        Button1.TabIndex = 3
        Button1.Text = "Enter"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(225, 180)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label2 test
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(259, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 25)
        Label2.TabIndex = 7
        Label2.Text = "Role : "
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Employee", "Manager", "Human Resources", "Accountant"})
        CheckedListBox1.Location = New Point(487, 167)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(180, 144)
        CheckedListBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(448, 88)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(219, 31)
        TextBox2.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(259, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 25)
        Label3.TabIndex = 10
        Label3.Text = "Password :"
        ' 
        ' DBHandler
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 446)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(CheckedListBox1)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Margin = New Padding(2)
        Name = "DBHandler"
        Text = "DB Handler"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label

End Class
