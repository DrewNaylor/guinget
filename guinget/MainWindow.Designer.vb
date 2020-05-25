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
        Me.panelMainPkgArea = New System.Windows.Forms.Panel()
        Me.toolstripMainWindow = New System.Windows.Forms.ToolStrip()
        Me.toolstripbuttonRefreshCache = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbuttonApplyChanges = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbuttonProperties = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstriptextboxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.toolstripbuttonSearch = New System.Windows.Forms.ToolStripButton()
        Me.splitcontainerSidebarAndPkgList = New System.Windows.Forms.SplitContainer()
        Me.panelSidebarHolder = New System.Windows.Forms.Panel()
        Me.tabcontrolSidebar = New System.Windows.Forms.TabControl()
        Me.tabpageSearchTerms = New System.Windows.Forms.TabPage()
        Me.tablelayoutpanelSearchTerms = New System.Windows.Forms.TableLayoutPanel()
        Me.listboxSearchTerms = New System.Windows.Forms.ListBox()
        Me.buttonClearSearchTerms = New System.Windows.Forms.Button()
        Me.tabpageStatus = New System.Windows.Forms.TabPage()
        Me.listboxStatusTab = New System.Windows.Forms.ListBox()
        Me.tabpageSource = New System.Windows.Forms.TabPage()
        Me.tabpageSections = New System.Windows.Forms.TabPage()
        Me.tabpageCustomFilters = New System.Windows.Forms.TabPage()
        Me.panelMainForm = New System.Windows.Forms.Panel()
        Me.tabpageArchitecture = New System.Windows.Forms.TabPage()
        Me.listboxSections = New System.Windows.Forms.ListBox()
        Me.listboxSourceTab = New System.Windows.Forms.ListBox()
        Me.listboxCustomFilters = New System.Windows.Forms.ListBox()
        Me.listboxArchitecture = New System.Windows.Forms.ListBox()
        Me.contextmenuSearchTerm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearSelectedSearchTermToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllSearchTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menustripMainWindow.SuspendLayout()
        CType(Me.splitcontainerMainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerMainWindow.Panel1.SuspendLayout()
        Me.splitcontainerMainWindow.Panel2.SuspendLayout()
        Me.splitcontainerMainWindow.SuspendLayout()
        CType(Me.datagridviewPackageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextmenustripPackageMenu.SuspendLayout()
        Me.panelMainPkgArea.SuspendLayout()
        Me.toolstripMainWindow.SuspendLayout()
        CType(Me.splitcontainerSidebarAndPkgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerSidebarAndPkgList.Panel1.SuspendLayout()
        Me.splitcontainerSidebarAndPkgList.Panel2.SuspendLayout()
        Me.splitcontainerSidebarAndPkgList.SuspendLayout()
        Me.panelSidebarHolder.SuspendLayout()
        Me.tabcontrolSidebar.SuspendLayout()
        Me.tabpageSearchTerms.SuspendLayout()
        Me.tablelayoutpanelSearchTerms.SuspendLayout()
        Me.tabpageStatus.SuspendLayout()
        Me.tabpageSource.SuspendLayout()
        Me.tabpageSections.SuspendLayout()
        Me.tabpageCustomFilters.SuspendLayout()
        Me.panelMainForm.SuspendLayout()
        Me.tabpageArchitecture.SuspendLayout()
        Me.contextmenuSearchTerm.SuspendLayout()
        Me.SuspendLayout()
        '
        'menustripMainWindow
        '
        Me.menustripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menustripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menustripMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menustripMainWindow.Name = "menustripMainWindow"
        Me.menustripMainWindow.Size = New System.Drawing.Size(992, 28)
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
        Me.splitcontainerMainWindow.Size = New System.Drawing.Size(691, 569)
        Me.splitcontainerMainWindow.SplitterDistance = 363
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
        Me.datagridviewPackageList.Size = New System.Drawing.Size(691, 363)
        Me.datagridviewPackageList.StandardTab = True
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
        Me.textboxPackageDetails.Size = New System.Drawing.Size(691, 202)
        Me.textboxPackageDetails.TabIndex = 0
        '
        'panelMainPkgArea
        '
        Me.panelMainPkgArea.Controls.Add(Me.splitcontainerMainWindow)
        Me.panelMainPkgArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainPkgArea.Location = New System.Drawing.Point(0, 0)
        Me.panelMainPkgArea.Name = "panelMainPkgArea"
        Me.panelMainPkgArea.Size = New System.Drawing.Size(691, 569)
        Me.panelMainPkgArea.TabIndex = 2
        '
        'toolstripMainWindow
        '
        Me.toolstripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbuttonRefreshCache, Me.toolstripbuttonApplyChanges, Me.ToolStripSeparator2, Me.toolstripbuttonProperties, Me.ToolStripSeparator1, Me.toolstriptextboxSearch, Me.toolstripbuttonSearch})
        Me.toolstripMainWindow.Location = New System.Drawing.Point(0, 28)
        Me.toolstripMainWindow.Name = "toolstripMainWindow"
        Me.toolstripMainWindow.Size = New System.Drawing.Size(992, 27)
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
        'splitcontainerSidebarAndPkgList
        '
        Me.splitcontainerSidebarAndPkgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitcontainerSidebarAndPkgList.Location = New System.Drawing.Point(0, 0)
        Me.splitcontainerSidebarAndPkgList.Name = "splitcontainerSidebarAndPkgList"
        '
        'splitcontainerSidebarAndPkgList.Panel1
        '
        Me.splitcontainerSidebarAndPkgList.Panel1.Controls.Add(Me.panelSidebarHolder)
        '
        'splitcontainerSidebarAndPkgList.Panel2
        '
        Me.splitcontainerSidebarAndPkgList.Panel2.Controls.Add(Me.panelMainPkgArea)
        Me.splitcontainerSidebarAndPkgList.Size = New System.Drawing.Size(992, 569)
        Me.splitcontainerSidebarAndPkgList.SplitterDistance = 297
        Me.splitcontainerSidebarAndPkgList.TabIndex = 3
        '
        'panelSidebarHolder
        '
        Me.panelSidebarHolder.Controls.Add(Me.tabcontrolSidebar)
        Me.panelSidebarHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSidebarHolder.Location = New System.Drawing.Point(0, 0)
        Me.panelSidebarHolder.Name = "panelSidebarHolder"
        Me.panelSidebarHolder.Size = New System.Drawing.Size(297, 569)
        Me.panelSidebarHolder.TabIndex = 0
        '
        'tabcontrolSidebar
        '
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSearchTerms)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageStatus)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageCustomFilters)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSections)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSource)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageArchitecture)
        Me.tabcontrolSidebar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolSidebar.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrolSidebar.Name = "tabcontrolSidebar"
        Me.tabcontrolSidebar.SelectedIndex = 0
        Me.tabcontrolSidebar.Size = New System.Drawing.Size(297, 569)
        Me.tabcontrolSidebar.TabIndex = 0
        '
        'tabpageSearchTerms
        '
        Me.tabpageSearchTerms.Controls.Add(Me.tablelayoutpanelSearchTerms)
        Me.tabpageSearchTerms.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSearchTerms.Name = "tabpageSearchTerms"
        Me.tabpageSearchTerms.Size = New System.Drawing.Size(289, 540)
        Me.tabpageSearchTerms.TabIndex = 4
        Me.tabpageSearchTerms.Text = "Search terms"
        Me.tabpageSearchTerms.UseVisualStyleBackColor = True
        '
        'tablelayoutpanelSearchTerms
        '
        Me.tablelayoutpanelSearchTerms.ColumnCount = 1
        Me.tablelayoutpanelSearchTerms.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tablelayoutpanelSearchTerms.Controls.Add(Me.buttonClearSearchTerms, 0, 1)
        Me.tablelayoutpanelSearchTerms.Controls.Add(Me.listboxSearchTerms, 0, 0)
        Me.tablelayoutpanelSearchTerms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelSearchTerms.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelSearchTerms.Name = "tablelayoutpanelSearchTerms"
        Me.tablelayoutpanelSearchTerms.RowCount = 2
        Me.tablelayoutpanelSearchTerms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelSearchTerms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tablelayoutpanelSearchTerms.Size = New System.Drawing.Size(289, 540)
        Me.tablelayoutpanelSearchTerms.TabIndex = 1
        '
        'listboxSearchTerms
        '
        Me.listboxSearchTerms.ContextMenuStrip = Me.contextmenuSearchTerm
        Me.listboxSearchTerms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSearchTerms.FormattingEnabled = True
        Me.listboxSearchTerms.IntegralHeight = False
        Me.listboxSearchTerms.ItemHeight = 16
        Me.listboxSearchTerms.Location = New System.Drawing.Point(3, 3)
        Me.listboxSearchTerms.Name = "listboxSearchTerms"
        Me.listboxSearchTerms.Size = New System.Drawing.Size(283, 494)
        Me.listboxSearchTerms.TabIndex = 0
        '
        'buttonClearSearchTerms
        '
        Me.buttonClearSearchTerms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonClearSearchTerms.Location = New System.Drawing.Point(3, 503)
        Me.buttonClearSearchTerms.Name = "buttonClearSearchTerms"
        Me.buttonClearSearchTerms.Size = New System.Drawing.Size(283, 34)
        Me.buttonClearSearchTerms.TabIndex = 1
        Me.buttonClearSearchTerms.Text = "Clear all search terms"
        Me.buttonClearSearchTerms.UseVisualStyleBackColor = True
        '
        'tabpageStatus
        '
        Me.tabpageStatus.Controls.Add(Me.listboxStatusTab)
        Me.tabpageStatus.Location = New System.Drawing.Point(4, 25)
        Me.tabpageStatus.Name = "tabpageStatus"
        Me.tabpageStatus.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageStatus.Size = New System.Drawing.Size(289, 540)
        Me.tabpageStatus.TabIndex = 1
        Me.tabpageStatus.Text = "Status"
        Me.tabpageStatus.UseVisualStyleBackColor = True
        '
        'listboxStatusTab
        '
        Me.listboxStatusTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxStatusTab.FormattingEnabled = True
        Me.listboxStatusTab.IntegralHeight = False
        Me.listboxStatusTab.ItemHeight = 16
        Me.listboxStatusTab.Location = New System.Drawing.Point(3, 3)
        Me.listboxStatusTab.Name = "listboxStatusTab"
        Me.listboxStatusTab.Size = New System.Drawing.Size(283, 534)
        Me.listboxStatusTab.TabIndex = 0
        '
        'tabpageSource
        '
        Me.tabpageSource.Controls.Add(Me.listboxSourceTab)
        Me.tabpageSource.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSource.Name = "tabpageSource"
        Me.tabpageSource.Size = New System.Drawing.Size(289, 540)
        Me.tabpageSource.TabIndex = 2
        Me.tabpageSource.Text = "Source"
        Me.tabpageSource.UseVisualStyleBackColor = True
        '
        'tabpageSections
        '
        Me.tabpageSections.Controls.Add(Me.listboxSections)
        Me.tabpageSections.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSections.Name = "tabpageSections"
        Me.tabpageSections.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageSections.Size = New System.Drawing.Size(289, 540)
        Me.tabpageSections.TabIndex = 0
        Me.tabpageSections.Text = "Categories"
        Me.tabpageSections.UseVisualStyleBackColor = True
        '
        'tabpageCustomFilters
        '
        Me.tabpageCustomFilters.Controls.Add(Me.listboxCustomFilters)
        Me.tabpageCustomFilters.Location = New System.Drawing.Point(4, 25)
        Me.tabpageCustomFilters.Name = "tabpageCustomFilters"
        Me.tabpageCustomFilters.Size = New System.Drawing.Size(289, 540)
        Me.tabpageCustomFilters.TabIndex = 3
        Me.tabpageCustomFilters.Text = "Custom filters"
        Me.tabpageCustomFilters.UseVisualStyleBackColor = True
        '
        'panelMainForm
        '
        Me.panelMainForm.Controls.Add(Me.splitcontainerSidebarAndPkgList)
        Me.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainForm.Location = New System.Drawing.Point(0, 55)
        Me.panelMainForm.Name = "panelMainForm"
        Me.panelMainForm.Size = New System.Drawing.Size(992, 569)
        Me.panelMainForm.TabIndex = 4
        '
        'tabpageArchitecture
        '
        Me.tabpageArchitecture.Controls.Add(Me.listboxArchitecture)
        Me.tabpageArchitecture.Location = New System.Drawing.Point(4, 25)
        Me.tabpageArchitecture.Name = "tabpageArchitecture"
        Me.tabpageArchitecture.Size = New System.Drawing.Size(289, 540)
        Me.tabpageArchitecture.TabIndex = 5
        Me.tabpageArchitecture.Text = "Architecture"
        Me.tabpageArchitecture.UseVisualStyleBackColor = True
        '
        'listboxSections
        '
        Me.listboxSections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSections.FormattingEnabled = True
        Me.listboxSections.IntegralHeight = False
        Me.listboxSections.ItemHeight = 16
        Me.listboxSections.Location = New System.Drawing.Point(3, 3)
        Me.listboxSections.Name = "listboxSections"
        Me.listboxSections.Size = New System.Drawing.Size(283, 534)
        Me.listboxSections.TabIndex = 1
        '
        'listboxSourceTab
        '
        Me.listboxSourceTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSourceTab.FormattingEnabled = True
        Me.listboxSourceTab.IntegralHeight = False
        Me.listboxSourceTab.ItemHeight = 16
        Me.listboxSourceTab.Location = New System.Drawing.Point(0, 0)
        Me.listboxSourceTab.Name = "listboxSourceTab"
        Me.listboxSourceTab.Size = New System.Drawing.Size(289, 540)
        Me.listboxSourceTab.TabIndex = 1
        '
        'listboxCustomFilters
        '
        Me.listboxCustomFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxCustomFilters.FormattingEnabled = True
        Me.listboxCustomFilters.IntegralHeight = False
        Me.listboxCustomFilters.ItemHeight = 16
        Me.listboxCustomFilters.Location = New System.Drawing.Point(0, 0)
        Me.listboxCustomFilters.Name = "listboxCustomFilters"
        Me.listboxCustomFilters.Size = New System.Drawing.Size(289, 540)
        Me.listboxCustomFilters.TabIndex = 1
        '
        'listboxArchitecture
        '
        Me.listboxArchitecture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxArchitecture.FormattingEnabled = True
        Me.listboxArchitecture.IntegralHeight = False
        Me.listboxArchitecture.ItemHeight = 16
        Me.listboxArchitecture.Location = New System.Drawing.Point(0, 0)
        Me.listboxArchitecture.Name = "listboxArchitecture"
        Me.listboxArchitecture.Size = New System.Drawing.Size(289, 540)
        Me.listboxArchitecture.TabIndex = 1
        '
        'contextmenuSearchTerm
        '
        Me.contextmenuSearchTerm.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenuSearchTerm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearSelectedSearchTermToolStripMenuItem, Me.ToolStripSeparator3, Me.ClearAllSearchTermsToolStripMenuItem})
        Me.contextmenuSearchTerm.Name = "contextmenuSearchTerm"
        Me.contextmenuSearchTerm.Size = New System.Drawing.Size(269, 86)
        '
        'ClearSelectedSearchTermToolStripMenuItem
        '
        Me.ClearSelectedSearchTermToolStripMenuItem.Name = "ClearSelectedSearchTermToolStripMenuItem"
        Me.ClearSelectedSearchTermToolStripMenuItem.Size = New System.Drawing.Size(268, 24)
        Me.ClearSelectedSearchTermToolStripMenuItem.Text = "Clear selected search term(s)"
        '
        'ClearAllSearchTermsToolStripMenuItem
        '
        Me.ClearAllSearchTermsToolStripMenuItem.Name = "ClearAllSearchTermsToolStripMenuItem"
        Me.ClearAllSearchTermsToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.ClearAllSearchTermsToolStripMenuItem.Text = "Clear all search terms"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(265, 6)
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(992, 624)
        Me.Controls.Add(Me.panelMainForm)
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
        Me.panelMainPkgArea.ResumeLayout(False)
        Me.toolstripMainWindow.ResumeLayout(False)
        Me.toolstripMainWindow.PerformLayout()
        Me.splitcontainerSidebarAndPkgList.Panel1.ResumeLayout(False)
        Me.splitcontainerSidebarAndPkgList.Panel2.ResumeLayout(False)
        CType(Me.splitcontainerSidebarAndPkgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitcontainerSidebarAndPkgList.ResumeLayout(False)
        Me.panelSidebarHolder.ResumeLayout(False)
        Me.tabcontrolSidebar.ResumeLayout(False)
        Me.tabpageSearchTerms.ResumeLayout(False)
        Me.tablelayoutpanelSearchTerms.ResumeLayout(False)
        Me.tabpageStatus.ResumeLayout(False)
        Me.tabpageSource.ResumeLayout(False)
        Me.tabpageSections.ResumeLayout(False)
        Me.tabpageCustomFilters.ResumeLayout(False)
        Me.panelMainForm.ResumeLayout(False)
        Me.tabpageArchitecture.ResumeLayout(False)
        Me.contextmenuSearchTerm.ResumeLayout(False)
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
    Friend WithEvents panelMainPkgArea As Panel
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
    Friend WithEvents splitcontainerSidebarAndPkgList As SplitContainer
    Friend WithEvents panelMainForm As Panel
    Friend WithEvents panelSidebarHolder As Panel
    Friend WithEvents tabcontrolSidebar As TabControl
    Friend WithEvents tabpageSections As TabPage
    Friend WithEvents tabpageStatus As TabPage
    Friend WithEvents tabpageSource As TabPage
    Friend WithEvents tabpageCustomFilters As TabPage
    Friend WithEvents tabpageSearchTerms As TabPage
    Friend WithEvents listboxSearchTerms As ListBox
    Friend WithEvents tablelayoutpanelSearchTerms As TableLayoutPanel
    Friend WithEvents buttonClearSearchTerms As Button
    Friend WithEvents listboxStatusTab As ListBox
    Friend WithEvents tabpageArchitecture As TabPage
    Friend WithEvents listboxSections As ListBox
    Friend WithEvents listboxSourceTab As ListBox
    Friend WithEvents listboxCustomFilters As ListBox
    Friend WithEvents listboxArchitecture As ListBox
    Friend WithEvents contextmenuSearchTerm As ContextMenuStrip
    Friend WithEvents ClearSelectedSearchTermToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllSearchTermsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
