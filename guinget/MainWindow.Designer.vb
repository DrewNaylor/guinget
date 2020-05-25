<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aaformMainWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformMainWindow))
        Me.menustripMainWindow = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamplePackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerifyManifestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitcontainerMainWindow = New System.Windows.Forms.SplitContainer()
        Me.datagridviewPackageList = New System.Windows.Forms.DataGridView()
        Me.PkgAction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PkgStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PkgName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PkgDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contextmenustripPackageMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoNothingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.textboxPackageDetails = New System.Windows.Forms.TextBox()
        Me.panelMainWindow = New System.Windows.Forms.Panel()
        Me.toolstripMainWindow = New System.Windows.Forms.ToolStrip()
        Me.toolstripbuttonRefreshCache = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbuttonApplyChanges = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbuttonProperties = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstriptextboxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.toolstripbuttonSearch = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabpageSections = New System.Windows.Forms.TabPage()
        Me.tabpageAction = New System.Windows.Forms.TabPage()
        Me.tabpageSource = New System.Windows.Forms.TabPage()
        Me.tabpageCustomFilters = New System.Windows.Forms.TabPage()
        Me.tabpageSearchResults = New System.Windows.Forms.TabPage()
        Me.listboxSearchResults = New System.Windows.Forms.ListBox()
        Me.menustripMainWindow.SuspendLayout()
        CType(Me.splitcontainerMainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerMainWindow.Panel1.SuspendLayout()
        Me.splitcontainerMainWindow.Panel2.SuspendLayout()
        Me.splitcontainerMainWindow.SuspendLayout()
        CType(Me.datagridviewPackageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextmenustripPackageMenu.SuspendLayout()
        Me.panelMainWindow.SuspendLayout()
        Me.toolstripMainWindow.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabpageSearchResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'menustripMainWindow
        '
        Me.menustripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menustripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menustripMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menustripMainWindow.Name = "menustripMainWindow"
        Me.menustripMainWindow.Size = New System.Drawing.Size(818, 28)
        Me.menustripMainWindow.TabIndex = 0
        Me.menustripMainWindow.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExamplePackageToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ExamplePackageToolStripMenuItem
        '
        Me.ExamplePackageToolStripMenuItem.Name = "ExamplePackageToolStripMenuItem"
        Me.ExamplePackageToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.ExamplePackageToolStripMenuItem.Text = "Example package"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerifyManifestToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'VerifyManifestToolStripMenuItem
        '
        Me.VerifyManifestToolStripMenuItem.Name = "VerifyManifestToolStripMenuItem"
        Me.VerifyManifestToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.VerifyManifestToolStripMenuItem.Text = "&Verify manifest"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'splitcontainerMainWindow
        '
        Me.splitcontainerMainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitcontainerMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.splitcontainerMainWindow.Name = "splitcontainerMainWindow"
        Me.splitcontainerMainWindow.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitcontainerMainWindow.Panel1
        '
        Me.splitcontainerMainWindow.Panel1.Controls.Add(Me.datagridviewPackageList)
        '
        'splitcontainerMainWindow.Panel2
        '
        Me.splitcontainerMainWindow.Panel2.Controls.Add(Me.textboxPackageDetails)
        Me.splitcontainerMainWindow.Size = New System.Drawing.Size(542, 440)
        Me.splitcontainerMainWindow.SplitterDistance = 256
        Me.splitcontainerMainWindow.TabIndex = 1
        '
        'datagridviewPackageList
        '
        Me.datagridviewPackageList.AllowUserToAddRows = False
        Me.datagridviewPackageList.AllowUserToDeleteRows = False
        Me.datagridviewPackageList.AllowUserToOrderColumns = True
        Me.datagridviewPackageList.AllowUserToResizeRows = False
        Me.datagridviewPackageList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridviewPackageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPackageList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PkgAction, Me.PkgStatus, Me.PkgName, Me.AvailableVersion, Me.PkgDescription})
        Me.datagridviewPackageList.ContextMenuStrip = Me.contextmenustripPackageMenu
        Me.datagridviewPackageList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewPackageList.Location = New System.Drawing.Point(0, 0)
        Me.datagridviewPackageList.Name = "datagridviewPackageList"
        Me.datagridviewPackageList.RowHeadersWidth = 51
        Me.datagridviewPackageList.RowTemplate.Height = 24
        Me.datagridviewPackageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPackageList.ShowEditingIcon = False
        Me.datagridviewPackageList.Size = New System.Drawing.Size(542, 256)
        Me.datagridviewPackageList.TabIndex = 0
        '
        'PkgAction
        '
        Me.PkgAction.HeaderText = "Action"
        Me.PkgAction.Items.AddRange(New Object() {"Do nothing", "Install"})
        Me.PkgAction.MinimumWidth = 6
        Me.PkgAction.Name = "PkgAction"
        Me.PkgAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'PkgStatus
        '
        Me.PkgStatus.HeaderText = "Status"
        Me.PkgStatus.MinimumWidth = 6
        Me.PkgStatus.Name = "PkgStatus"
        Me.PkgStatus.ReadOnly = True
        '
        'PkgName
        '
        Me.PkgName.HeaderText = "Package"
        Me.PkgName.MinimumWidth = 6
        Me.PkgName.Name = "PkgName"
        Me.PkgName.ReadOnly = True
        '
        'AvailableVersion
        '
        Me.AvailableVersion.HeaderText = "Available version"
        Me.AvailableVersion.MinimumWidth = 6
        Me.AvailableVersion.Name = "AvailableVersion"
        Me.AvailableVersion.ReadOnly = True
        '
        'PkgDescription
        '
        Me.PkgDescription.HeaderText = "Description"
        Me.PkgDescription.MinimumWidth = 6
        Me.PkgDescription.Name = "PkgDescription"
        Me.PkgDescription.ReadOnly = True
        '
        'contextmenustripPackageMenu
        '
        Me.contextmenustripPackageMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenustripPackageMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionToolStripMenuItem})
        Me.contextmenustripPackageMenu.Name = "ContextMenuStrip1"
        Me.contextmenustripPackageMenu.Size = New System.Drawing.Size(122, 28)
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoNothingToolStripMenuItem, Me.InstallToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'DoNothingToolStripMenuItem
        '
        Me.DoNothingToolStripMenuItem.Name = "DoNothingToolStripMenuItem"
        Me.DoNothingToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.DoNothingToolStripMenuItem.Text = "Do nothing"
        '
        'InstallToolStripMenuItem
        '
        Me.InstallToolStripMenuItem.Name = "InstallToolStripMenuItem"
        Me.InstallToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.InstallToolStripMenuItem.Text = "Install"
        '
        'textboxPackageDetails
        '
        Me.textboxPackageDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxPackageDetails.Location = New System.Drawing.Point(0, 0)
        Me.textboxPackageDetails.Multiline = True
        Me.textboxPackageDetails.Name = "textboxPackageDetails"
        Me.textboxPackageDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxPackageDetails.Size = New System.Drawing.Size(542, 180)
        Me.textboxPackageDetails.TabIndex = 0
        '
        'panelMainWindow
        '
        Me.panelMainWindow.Controls.Add(Me.splitcontainerMainWindow)
        Me.panelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.panelMainWindow.Name = "panelMainWindow"
        Me.panelMainWindow.Size = New System.Drawing.Size(542, 440)
        Me.panelMainWindow.TabIndex = 2
        '
        'toolstripMainWindow
        '
        Me.toolstripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbuttonRefreshCache, Me.toolstripbuttonApplyChanges, Me.ToolStripSeparator2, Me.toolstripbuttonProperties, Me.ToolStripSeparator1, Me.toolstriptextboxSearch, Me.toolstripbuttonSearch})
        Me.toolstripMainWindow.Location = New System.Drawing.Point(0, 28)
        Me.toolstripMainWindow.Name = "toolstripMainWindow"
        Me.toolstripMainWindow.Size = New System.Drawing.Size(818, 27)
        Me.toolstripMainWindow.TabIndex = 0
        Me.toolstripMainWindow.Text = "ToolStrip1"
        '
        'toolstripbuttonRefreshCache
        '
        Me.toolstripbuttonRefreshCache.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonRefreshCache.Image = CType(resources.GetObject("toolstripbuttonRefreshCache.Image"), System.Drawing.Image)
        Me.toolstripbuttonRefreshCache.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonRefreshCache.Name = "toolstripbuttonRefreshCache"
        Me.toolstripbuttonRefreshCache.Size = New System.Drawing.Size(104, 24)
        Me.toolstripbuttonRefreshCache.Text = "Refresh cache"
        Me.toolstripbuttonRefreshCache.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolstripbuttonApplyChanges
        '
        Me.toolstripbuttonApplyChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonApplyChanges.Image = CType(resources.GetObject("toolstripbuttonApplyChanges.Image"), System.Drawing.Image)
        Me.toolstripbuttonApplyChanges.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonApplyChanges.Name = "toolstripbuttonApplyChanges"
        Me.toolstripbuttonApplyChanges.Size = New System.Drawing.Size(110, 24)
        Me.toolstripbuttonApplyChanges.Text = "Apply changes"
        Me.toolstripbuttonApplyChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'toolstripbuttonProperties
        '
        Me.toolstripbuttonProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonProperties.Image = CType(resources.GetObject("toolstripbuttonProperties.Image"), System.Drawing.Image)
        Me.toolstripbuttonProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonProperties.Name = "toolstripbuttonProperties"
        Me.toolstripbuttonProperties.Size = New System.Drawing.Size(80, 24)
        Me.toolstripbuttonProperties.Text = "Properties"
        Me.toolstripbuttonProperties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'toolstriptextboxSearch
        '
        Me.toolstriptextboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toolstriptextboxSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.toolstriptextboxSearch.Name = "toolstriptextboxSearch"
        Me.toolstriptextboxSearch.Size = New System.Drawing.Size(250, 27)
        '
        'toolstripbuttonSearch
        '
        Me.toolstripbuttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonSearch.Image = CType(resources.GetObject("toolstripbuttonSearch.Image"), System.Drawing.Image)
        Me.toolstripbuttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonSearch.Name = "toolstripbuttonSearch"
        Me.toolstripbuttonSearch.Size = New System.Drawing.Size(57, 24)
        Me.toolstripbuttonSearch.Text = "Search"
        Me.toolstripbuttonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.panelMainWindow)
        Me.SplitContainer1.Size = New System.Drawing.Size(818, 440)
        Me.SplitContainer1.SplitterDistance = 272
        Me.SplitContainer1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 440)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 440)
        Me.Panel2.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabpageSearchResults)
        Me.TabControl1.Controls.Add(Me.tabpageAction)
        Me.TabControl1.Controls.Add(Me.tabpageSource)
        Me.TabControl1.Controls.Add(Me.tabpageSections)
        Me.TabControl1.Controls.Add(Me.tabpageCustomFilters)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(272, 440)
        Me.TabControl1.TabIndex = 0
        '
        'tabpageSections
        '
        Me.tabpageSections.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSections.Name = "tabpageSections"
        Me.tabpageSections.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageSections.Size = New System.Drawing.Size(264, 411)
        Me.tabpageSections.TabIndex = 0
        Me.tabpageSections.Text = "Sections"
        Me.tabpageSections.UseVisualStyleBackColor = True
        '
        'tabpageAction
        '
        Me.tabpageAction.Location = New System.Drawing.Point(4, 25)
        Me.tabpageAction.Name = "tabpageAction"
        Me.tabpageAction.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAction.Size = New System.Drawing.Size(264, 411)
        Me.tabpageAction.TabIndex = 1
        Me.tabpageAction.Text = "Action"
        Me.tabpageAction.UseVisualStyleBackColor = True
        '
        'tabpageSource
        '
        Me.tabpageSource.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSource.Name = "tabpageSource"
        Me.tabpageSource.Size = New System.Drawing.Size(264, 411)
        Me.tabpageSource.TabIndex = 2
        Me.tabpageSource.Text = "Source"
        Me.tabpageSource.UseVisualStyleBackColor = True
        '
        'tabpageCustomFilters
        '
        Me.tabpageCustomFilters.Location = New System.Drawing.Point(4, 25)
        Me.tabpageCustomFilters.Name = "tabpageCustomFilters"
        Me.tabpageCustomFilters.Size = New System.Drawing.Size(264, 411)
        Me.tabpageCustomFilters.TabIndex = 3
        Me.tabpageCustomFilters.Text = "Custom filters"
        Me.tabpageCustomFilters.UseVisualStyleBackColor = True
        '
        'tabpageSearchResults
        '
        Me.tabpageSearchResults.Controls.Add(Me.listboxSearchResults)
        Me.tabpageSearchResults.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSearchResults.Name = "tabpageSearchResults"
        Me.tabpageSearchResults.Size = New System.Drawing.Size(264, 411)
        Me.tabpageSearchResults.TabIndex = 4
        Me.tabpageSearchResults.Text = "Search results"
        Me.tabpageSearchResults.UseVisualStyleBackColor = True
        '
        'listboxSearchResults
        '
        Me.listboxSearchResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSearchResults.FormattingEnabled = True
        Me.listboxSearchResults.ItemHeight = 16
        Me.listboxSearchResults.Location = New System.Drawing.Point(0, 0)
        Me.listboxSearchResults.Name = "listboxSearchResults"
        Me.listboxSearchResults.Size = New System.Drawing.Size(264, 411)
        Me.listboxSearchResults.TabIndex = 0
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(818, 495)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.toolstripMainWindow)
        Me.Controls.Add(Me.menustripMainWindow)
        Me.MainMenuStrip = Me.menustripMainWindow
        Me.Name = "aaformMainWindow"
        Me.Text = "guinget"
        Me.menustripMainWindow.ResumeLayout(False)
        Me.menustripMainWindow.PerformLayout()
        Me.splitcontainerMainWindow.Panel1.ResumeLayout(False)
        Me.splitcontainerMainWindow.Panel2.ResumeLayout(False)
        Me.splitcontainerMainWindow.Panel2.PerformLayout()
        CType(Me.splitcontainerMainWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitcontainerMainWindow.ResumeLayout(False)
        CType(Me.datagridviewPackageList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextmenustripPackageMenu.ResumeLayout(False)
        Me.panelMainWindow.ResumeLayout(False)
        Me.toolstripMainWindow.ResumeLayout(False)
        Me.toolstripMainWindow.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabpageSearchResults.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menustripMainWindow As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerifyManifestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents splitcontainerMainWindow As SplitContainer
    Friend WithEvents textboxPackageDetails As TextBox
    Friend WithEvents panelMainWindow As Panel
    Friend WithEvents toolstripMainWindow As ToolStrip
    Friend WithEvents toolstripbuttonSearch As ToolStripButton
    Friend WithEvents toolstriptextboxSearch As ToolStripTextBox
    Friend WithEvents ExamplePackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents datagridviewPackageList As DataGridView
    Friend WithEvents contextmenustripPackageMenu As ContextMenuStrip
    Friend WithEvents ActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoNothingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PkgAction As DataGridViewComboBoxColumn
    Friend WithEvents PkgStatus As DataGridViewTextBoxColumn
    Friend WithEvents PkgName As DataGridViewTextBoxColumn
    Friend WithEvents AvailableVersion As DataGridViewTextBoxColumn
    Friend WithEvents PkgDescription As DataGridViewTextBoxColumn
    Friend WithEvents toolstripbuttonRefreshCache As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents toolstripbuttonProperties As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolstripbuttonApplyChanges As ToolStripButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabpageSections As TabPage
    Friend WithEvents tabpageAction As TabPage
    Friend WithEvents tabpageSource As TabPage
    Friend WithEvents tabpageCustomFilters As TabPage
    Friend WithEvents tabpageSearchResults As TabPage
    Friend WithEvents listboxSearchResults As ListBox
End Class
