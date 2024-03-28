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
        MenuStrip1 = New MenuStrip()
        UserToolStripMenuItem = New ToolStripMenuItem()
        PTORequestToolStripMenuItem = New ToolStripMenuItem()
        StartToolStripMenuItem = New ToolStripMenuItem()
        ModifyToolStripMenuItem = New ToolStripMenuItem()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        PTOHistoryToolStripMenuItem = New ToolStripMenuItem()
        PTODocumentationToolStripMenuItem = New ToolStripMenuItem()
        PTOPlanToolStripMenuItem = New ToolStripMenuItem()
        ScheduleToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip2 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator = New ToolStripSeparator()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator1 = New ToolStripSeparator()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        PrintPreviewToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator2 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator3 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        ToolsToolStripMenuItem = New ToolStripMenuItem()
        CustomizeToolStripMenuItem = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ContentsToolStripMenuItem = New ToolStripMenuItem()
        IndexToolStripMenuItem = New ToolStripMenuItem()
        SearchToolStripMenuItem = New ToolStripMenuItem()
        toolStripSeparator5 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        MenuStrip2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {UserToolStripMenuItem, PTORequestToolStripMenuItem, PTOHistoryToolStripMenuItem, PTODocumentationToolStripMenuItem, PTOPlanToolStripMenuItem, ScheduleToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 33)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' UserToolStripMenuItem
        ' 
        UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        UserToolStripMenuItem.Size = New Size(61, 29)
        UserToolStripMenuItem.Text = "user"
        ' 
        ' PTORequestToolStripMenuItem
        ' 
        PTORequestToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StartToolStripMenuItem, ModifyToolStripMenuItem, DeleteToolStripMenuItem})
        PTORequestToolStripMenuItem.Name = "PTORequestToolStripMenuItem"
        PTORequestToolStripMenuItem.Size = New Size(128, 29)
        PTORequestToolStripMenuItem.Text = "PTO Request"
        ' 
        ' StartToolStripMenuItem
        ' 
        StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        StartToolStripMenuItem.Size = New Size(171, 34)
        StartToolStripMenuItem.Text = "start"
        ' 
        ' ModifyToolStripMenuItem
        ' 
        ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        ModifyToolStripMenuItem.Size = New Size(171, 34)
        ModifyToolStripMenuItem.Text = "modify"
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(171, 34)
        DeleteToolStripMenuItem.Text = "delete"
        ' 
        ' PTOHistoryToolStripMenuItem
        ' 
        PTOHistoryToolStripMenuItem.Name = "PTOHistoryToolStripMenuItem"
        PTOHistoryToolStripMenuItem.Size = New Size(122, 29)
        PTOHistoryToolStripMenuItem.Text = "PTO History"
        ' 
        ' PTODocumentationToolStripMenuItem
        ' 
        PTODocumentationToolStripMenuItem.Name = "PTODocumentationToolStripMenuItem"
        PTODocumentationToolStripMenuItem.Size = New Size(188, 29)
        PTODocumentationToolStripMenuItem.Text = "PTO Documentation"
        ' 
        ' PTOPlanToolStripMenuItem
        ' 
        PTOPlanToolStripMenuItem.Name = "PTOPlanToolStripMenuItem"
        PTOPlanToolStripMenuItem.Size = New Size(98, 29)
        PTOPlanToolStripMenuItem.Text = "PTO Plan"
        ' 
        ' ScheduleToolStripMenuItem
        ' 
        ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        ScheduleToolStripMenuItem.Size = New Size(99, 29)
        ScheduleToolStripMenuItem.Text = "Schedule"
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.ImageScalingSize = New Size(24, 24)
        MenuStrip2.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ToolsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 33)
        MenuStrip2.TabIndex = 1
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, toolStripSeparator, SaveToolStripMenuItem, toolStripSeparator1, PrintToolStripMenuItem, PrintPreviewToolStripMenuItem, toolStripSeparator2, ToolStripMenuItem5, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), Image)
        NewToolStripMenuItem.ImageTransparentColor = Color.Magenta
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.N
        NewToolStripMenuItem.Size = New Size(328, 34)
        NewToolStripMenuItem.Text = "&New PTO Request"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), Image)
        OpenToolStripMenuItem.ImageTransparentColor = Color.Magenta
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.O
        OpenToolStripMenuItem.Size = New Size(328, 34)
        OpenToolStripMenuItem.Text = "&Open PTO Request"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(325, 6)
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), Image)
        SaveToolStripMenuItem.ImageTransparentColor = Color.Magenta
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(328, 34)
        SaveToolStripMenuItem.Text = "&Save"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(325, 6)
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), Image)
        PrintToolStripMenuItem.ImageTransparentColor = Color.Magenta
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.P
        PrintToolStripMenuItem.Size = New Size(328, 34)
        PrintToolStripMenuItem.Text = "&Print"
        ' 
        ' PrintPreviewToolStripMenuItem
        ' 
        PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), Image)
        PrintPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta
        PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        PrintPreviewToolStripMenuItem.Size = New Size(328, 34)
        PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        ' 
        ' toolStripSeparator2
        ' 
        toolStripSeparator2.Name = "toolStripSeparator2"
        toolStripSeparator2.Size = New Size(325, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(328, 34)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, toolStripSeparator3, SelectAllToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(58, 29)
        EditToolStripMenuItem.Text = "&Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Z
        UndoToolStripMenuItem.Size = New Size(337, 34)
        UndoToolStripMenuItem.Text = "&Delete PTO Request"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.Y
        RedoToolStripMenuItem.Size = New Size(337, 34)
        RedoToolStripMenuItem.Text = "&Modify PTO Request"
        ' 
        ' toolStripSeparator3
        ' 
        toolStripSeparator3.Name = "toolStripSeparator3"
        toolStripSeparator3.Size = New Size(334, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(337, 34)
        SelectAllToolStripMenuItem.Text = "Select &All"
        ' 
        ' ToolsToolStripMenuItem
        ' 
        ToolsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CustomizeToolStripMenuItem, OptionsToolStripMenuItem, ToolStripMenuItem1, ToolStripMenuItem2, ToolStripMenuItem3, ToolStripMenuItem4})
        ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        ToolsToolStripMenuItem.Size = New Size(69, 29)
        ToolsToolStripMenuItem.Text = "&Tools"
        ' 
        ' CustomizeToolStripMenuItem
        ' 
        CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        CustomizeToolStripMenuItem.Size = New Size(274, 34)
        CustomizeToolStripMenuItem.Text = "&Schedule"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(274, 34)
        OptionsToolStripMenuItem.Text = "&PTO Plan"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ContentsToolStripMenuItem, IndexToolStripMenuItem, SearchToolStripMenuItem, toolStripSeparator5, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(65, 29)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' ContentsToolStripMenuItem
        ' 
        ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        ContentsToolStripMenuItem.Size = New Size(270, 34)
        ContentsToolStripMenuItem.Text = "&Contents"
        ' 
        ' IndexToolStripMenuItem
        ' 
        IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        IndexToolStripMenuItem.Size = New Size(270, 34)
        IndexToolStripMenuItem.Text = "&Index"
        ' 
        ' SearchToolStripMenuItem
        ' 
        SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        SearchToolStripMenuItem.Size = New Size(270, 34)
        SearchToolStripMenuItem.Text = "&Search"
        ' 
        ' toolStripSeparator5
        ' 
        toolStripSeparator5.Name = "toolStripSeparator5"
        toolStripSeparator5.Size = New Size(267, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(270, 34)
        AboutToolStripMenuItem.Text = "&About..."
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(274, 34)
        ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(274, 34)
        ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(274, 34)
        ToolStripMenuItem3.Text = "ToolStripMenuItem3"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(274, 34)
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(328, 34)
        ToolStripMenuItem5.Text = "&PTO History"
        ' 
        ' DBHandler
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        Controls.Add(MenuStrip2)
        MainMenuStrip = MenuStrip1
        Name = "DBHandler"
        Text = "DB Handler"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PTORequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PTOHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PTODocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PTOPlanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem

End Class
