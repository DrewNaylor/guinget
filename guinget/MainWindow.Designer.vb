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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformMainWindow))
        Me.menustripMainWindow = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshCacheMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyChangesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.PackageContextMenuDropdown = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextmenustripPackageMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoNothingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PackagePropertiesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedSearchMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerifyManifestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitcontainerMainWindow = New System.Windows.Forms.SplitContainer()
        Me.panelPackageListHolder = New System.Windows.Forms.Panel()
        Me.datagridviewPackageList = New System.Windows.Forms.DataGridView()
        Me.PkgAction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PkgStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PkgName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FriendlyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PkgDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Manifest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelUpdatingPackageList = New System.Windows.Forms.Label()
        Me.textboxPackageDetails = New System.Windows.Forms.TextBox()
        Me.panelMainPkgArea = New System.Windows.Forms.Panel()
        Me.toolstripMainWindow = New System.Windows.Forms.ToolStrip()
        Me.toolstripbuttonRefreshCache = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbuttonApplyChanges = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbuttonProperties = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstriptextboxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.toolstripsplitbuttonSearch = New System.Windows.Forms.ToolStripSplitButton()
        Me.toolstripmenuitemAdvancedSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolstripButton = New System.Windows.Forms.ToolStripButton()
        Me.splitcontainerSidebarAndPkgList = New System.Windows.Forms.SplitContainer()
        Me.panelSidebarHolder = New System.Windows.Forms.Panel()
        Me.buttonCloseSidebar = New System.Windows.Forms.Button()
        Me.comboboxSidebarTabSelector = New System.Windows.Forms.ComboBox()
        Me.tabcontrolSidebar = New System.Windows.Forms.TabControl()
        Me.tabpageSearchTerms = New System.Windows.Forms.TabPage()
        Me.listboxSearchTerms = New System.Windows.Forms.ListBox()
        Me.contextmenuSearchTerm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearSelectedSearchTermToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllSearchTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabpageStatus = New System.Windows.Forms.TabPage()
        Me.listboxStatusTab = New System.Windows.Forms.ListBox()
        Me.tabpageCustomFilters = New System.Windows.Forms.TabPage()
        Me.listboxCustomFilters = New System.Windows.Forms.ListBox()
        Me.tabpageSections = New System.Windows.Forms.TabPage()
        Me.listboxSections = New System.Windows.Forms.ListBox()
        Me.tabpageSource = New System.Windows.Forms.TabPage()
        Me.listboxSourceTab = New System.Windows.Forms.ListBox()
        Me.tabpageArchitecture = New System.Windows.Forms.TabPage()
        Me.listboxArchitecture = New System.Windows.Forms.ListBox()
        Me.panelMainForm = New System.Windows.Forms.Panel()
        Me.statusbarMainWindow = New System.Windows.Forms.StatusStrip()
        Me.toolstripstatuslabelPackageCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripstatusSplitter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripprogressbarLoadingPackages = New System.Windows.Forms.ToolStripProgressBar()
        Me.toolstripstatuslabelLoadingPackageCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menustripMainWindow.SuspendLayout()
        Me.contextmenustripPackageMenu.SuspendLayout()
        CType(Me.splitcontainerMainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerMainWindow.Panel1.SuspendLayout()
        Me.splitcontainerMainWindow.Panel2.SuspendLayout()
        Me.splitcontainerMainWindow.SuspendLayout()
        Me.panelPackageListHolder.SuspendLayout()
        CType(Me.datagridviewPackageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMainPkgArea.SuspendLayout()
        Me.toolstripMainWindow.SuspendLayout()
        CType(Me.splitcontainerSidebarAndPkgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerSidebarAndPkgList.Panel1.SuspendLayout()
        Me.splitcontainerSidebarAndPkgList.Panel2.SuspendLayout()
        Me.splitcontainerSidebarAndPkgList.SuspendLayout()
        Me.panelSidebarHolder.SuspendLayout()
        Me.tabcontrolSidebar.SuspendLayout()
        Me.tabpageSearchTerms.SuspendLayout()
        Me.contextmenuSearchTerm.SuspendLayout()
        Me.tabpageStatus.SuspendLayout()
        Me.tabpageCustomFilters.SuspendLayout()
        Me.tabpageSections.SuspendLayout()
        Me.tabpageSource.SuspendLayout()
        Me.tabpageArchitecture.SuspendLayout()
        Me.panelMainForm.SuspendLayout()
        Me.statusbarMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'menustripMainWindow
        '
        Me.menustripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menustripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PackageToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menustripMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menustripMainWindow.Name = "menustripMainWindow"
        Me.menustripMainWindow.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.menustripMainWindow.Size = New System.Drawing.Size(794, 24)
        Me.menustripMainWindow.TabIndex = 0
        Me.menustripMainWindow.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'PackageToolStripMenuItem
        '
        Me.PackageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshCacheMenuButton, Me.ApplyChangesMenuItem, Me.ToolStripSeparator6, Me.PackageContextMenuDropdown, Me.ToolStripSeparator5, Me.PackagePropertiesMenuItem, Me.ToolStripSeparator4, Me.SearchMenuItem, Me.AdvancedSearchMenuItem})
        Me.PackageToolStripMenuItem.Name = "PackageToolStripMenuItem"
        Me.PackageToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.PackageToolStripMenuItem.Text = "&Package list"
        '
        'RefreshCacheMenuButton
        '
        Me.RefreshCacheMenuButton.Name = "RefreshCacheMenuButton"
        Me.RefreshCacheMenuButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefreshCacheMenuButton.Size = New System.Drawing.Size(188, 22)
        Me.RefreshCacheMenuButton.Text = "&Refresh cache"
        '
        'ApplyChangesMenuItem
        '
        Me.ApplyChangesMenuItem.Name = "ApplyChangesMenuItem"
        Me.ApplyChangesMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ApplyChangesMenuItem.Text = "&Apply changes..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(185, 6)
        '
        'PackageContextMenuDropdown
        '
        Me.PackageContextMenuDropdown.DropDown = Me.contextmenustripPackageMenu
        Me.PackageContextMenuDropdown.Name = "PackageContextMenuDropdown"
        Me.PackageContextMenuDropdown.Size = New System.Drawing.Size(188, 22)
        Me.PackageContextMenuDropdown.Text = "&Selected package"
        '
        'contextmenustripPackageMenu
        '
        Me.contextmenustripPackageMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenustripPackageMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionToolStripMenuItem})
        Me.contextmenustripPackageMenu.Name = "ContextMenuStrip1"
        Me.contextmenustripPackageMenu.OwnerItem = Me.PackageContextMenuDropdown
        Me.contextmenustripPackageMenu.Size = New System.Drawing.Size(110, 26)
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoNothingToolStripMenuItem, Me.InstallToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ActionToolStripMenuItem.Text = "&Action"
        '
        'DoNothingToolStripMenuItem
        '
        Me.DoNothingToolStripMenuItem.Name = "DoNothingToolStripMenuItem"
        Me.DoNothingToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DoNothingToolStripMenuItem.Text = "&Do nothing"
        '
        'InstallToolStripMenuItem
        '
        Me.InstallToolStripMenuItem.Name = "InstallToolStripMenuItem"
        Me.InstallToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.InstallToolStripMenuItem.Text = "&Install"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(185, 6)
        '
        'PackagePropertiesMenuItem
        '
        Me.PackagePropertiesMenuItem.Name = "PackagePropertiesMenuItem"
        Me.PackagePropertiesMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PackagePropertiesMenuItem.Text = "Pa&ckage properties..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(185, 6)
        '
        'SearchMenuItem
        '
        Me.SearchMenuItem.Name = "SearchMenuItem"
        Me.SearchMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SearchMenuItem.Text = "Search"
        '
        'AdvancedSearchMenuItem
        '
        Me.AdvancedSearchMenuItem.Name = "AdvancedSearchMenuItem"
        Me.AdvancedSearchMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AdvancedSearchMenuItem.Text = "A&dvanced search..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerifyManifestToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'VerifyManifestToolStripMenuItem
        '
        Me.VerifyManifestToolStripMenuItem.Name = "VerifyManifestToolStripMenuItem"
        Me.VerifyManifestToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerifyManifestToolStripMenuItem.Text = "&Verify manifest"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'splitcontainerMainWindow
        '
        Me.splitcontainerMainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitcontainerMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.splitcontainerMainWindow.Margin = New System.Windows.Forms.Padding(2)
        Me.splitcontainerMainWindow.Name = "splitcontainerMainWindow"
        Me.splitcontainerMainWindow.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitcontainerMainWindow.Panel1
        '
        Me.splitcontainerMainWindow.Panel1.Controls.Add(Me.panelPackageListHolder)
        '
        'splitcontainerMainWindow.Panel2
        '
        Me.splitcontainerMainWindow.Panel2.Controls.Add(Me.textboxPackageDetails)
        Me.splitcontainerMainWindow.Size = New System.Drawing.Size(583, 428)
        Me.splitcontainerMainWindow.SplitterDistance = 267
        Me.splitcontainerMainWindow.SplitterWidth = 3
        Me.splitcontainerMainWindow.TabIndex = 4
        '
        'panelPackageListHolder
        '
        Me.panelPackageListHolder.Controls.Add(Me.datagridviewPackageList)
        Me.panelPackageListHolder.Controls.Add(Me.labelUpdatingPackageList)
        Me.panelPackageListHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPackageListHolder.Location = New System.Drawing.Point(0, 0)
        Me.panelPackageListHolder.Margin = New System.Windows.Forms.Padding(2)
        Me.panelPackageListHolder.Name = "panelPackageListHolder"
        Me.panelPackageListHolder.Size = New System.Drawing.Size(583, 267)
        Me.panelPackageListHolder.TabIndex = 2
        '
        'datagridviewPackageList
        '
        Me.datagridviewPackageList.AllowUserToAddRows = False
        Me.datagridviewPackageList.AllowUserToDeleteRows = False
        Me.datagridviewPackageList.AllowUserToOrderColumns = True
        Me.datagridviewPackageList.AllowUserToResizeRows = False
        Me.datagridviewPackageList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridviewPackageList.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridviewPackageList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridviewPackageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPackageList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PkgAction, Me.PkgStatus, Me.PkgName, Me.FriendlyName, Me.AvailableVersion, Me.PkgDescription, Me.Manifest})
        Me.datagridviewPackageList.ContextMenuStrip = Me.contextmenustripPackageMenu
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridviewPackageList.DefaultCellStyle = DataGridViewCellStyle5
        Me.datagridviewPackageList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewPackageList.Location = New System.Drawing.Point(0, 0)
        Me.datagridviewPackageList.Margin = New System.Windows.Forms.Padding(2)
        Me.datagridviewPackageList.Name = "datagridviewPackageList"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridviewPackageList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.datagridviewPackageList.RowHeadersVisible = False
        Me.datagridviewPackageList.RowHeadersWidth = 51
        Me.datagridviewPackageList.RowTemplate.Height = 24
        Me.datagridviewPackageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPackageList.ShowEditingIcon = False
        Me.datagridviewPackageList.Size = New System.Drawing.Size(583, 267)
        Me.datagridviewPackageList.StandardTab = True
        Me.datagridviewPackageList.TabIndex = 0
        '
        'PkgAction
        '
        Me.PkgAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PkgAction.HeaderText = "Action"
        Me.PkgAction.Items.AddRange(New Object() {"Do nothing", "Install"})
        Me.PkgAction.MinimumWidth = 6
        Me.PkgAction.Name = "PkgAction"
        Me.PkgAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PkgAction.Width = 62
        '
        'PkgStatus
        '
        Me.PkgStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PkgStatus.HeaderText = "Status"
        Me.PkgStatus.MinimumWidth = 6
        Me.PkgStatus.Name = "PkgStatus"
        Me.PkgStatus.ReadOnly = True
        Me.PkgStatus.Width = 62
        '
        'PkgName
        '
        Me.PkgName.HeaderText = "Package"
        Me.PkgName.MinimumWidth = 6
        Me.PkgName.Name = "PkgName"
        Me.PkgName.ReadOnly = True
        '
        'FriendlyName
        '
        Me.FriendlyName.HeaderText = "Name"
        Me.FriendlyName.MinimumWidth = 6
        Me.FriendlyName.Name = "FriendlyName"
        Me.FriendlyName.ReadOnly = True
        '
        'AvailableVersion
        '
        Me.AvailableVersion.HeaderText = "Version"
        Me.AvailableVersion.MinimumWidth = 6
        Me.AvailableVersion.Name = "AvailableVersion"
        Me.AvailableVersion.ReadOnly = True
        Me.AvailableVersion.ToolTipText = "(will eventually only display latest version and have all older versions in a win" &
    "dow like Synaptic)"
        '
        'PkgDescription
        '
        Me.PkgDescription.HeaderText = "Description"
        Me.PkgDescription.MinimumWidth = 6
        Me.PkgDescription.Name = "PkgDescription"
        Me.PkgDescription.ReadOnly = True
        '
        'Manifest
        '
        Me.Manifest.HeaderText = "Manifest"
        Me.Manifest.MinimumWidth = 6
        Me.Manifest.Name = "Manifest"
        Me.Manifest.ReadOnly = True
        Me.Manifest.Visible = False
        '
        'labelUpdatingPackageList
        '
        Me.labelUpdatingPackageList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelUpdatingPackageList.AutoSize = True
        Me.labelUpdatingPackageList.Location = New System.Drawing.Point(2, 0)
        Me.labelUpdatingPackageList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelUpdatingPackageList.Name = "labelUpdatingPackageList"
        Me.labelUpdatingPackageList.Size = New System.Drawing.Size(173, 13)
        Me.labelUpdatingPackageList.TabIndex = 1
        Me.labelUpdatingPackageList.Text = "Loading package list, please wait..."
        '
        'textboxPackageDetails
        '
        Me.textboxPackageDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxPackageDetails.Location = New System.Drawing.Point(0, 0)
        Me.textboxPackageDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxPackageDetails.Multiline = True
        Me.textboxPackageDetails.Name = "textboxPackageDetails"
        Me.textboxPackageDetails.ReadOnly = True
        Me.textboxPackageDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxPackageDetails.Size = New System.Drawing.Size(583, 158)
        Me.textboxPackageDetails.TabIndex = 1
        Me.textboxPackageDetails.Text = resources.GetString("textboxPackageDetails.Text")
        '
        'panelMainPkgArea
        '
        Me.panelMainPkgArea.Controls.Add(Me.splitcontainerMainWindow)
        Me.panelMainPkgArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainPkgArea.Location = New System.Drawing.Point(0, 0)
        Me.panelMainPkgArea.Margin = New System.Windows.Forms.Padding(2)
        Me.panelMainPkgArea.Name = "panelMainPkgArea"
        Me.panelMainPkgArea.Size = New System.Drawing.Size(583, 428)
        Me.panelMainPkgArea.TabIndex = 2
        '
        'toolstripMainWindow
        '
        Me.toolstripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbuttonRefreshCache, Me.toolstripbuttonApplyChanges, Me.ToolStripSeparator2, Me.toolstripbuttonProperties, Me.ToolStripSeparator1, Me.toolstriptextboxSearch, Me.toolstripsplitbuttonSearch, Me.SearchToolstripButton})
        Me.toolstripMainWindow.Location = New System.Drawing.Point(0, 24)
        Me.toolstripMainWindow.Name = "toolstripMainWindow"
        Me.toolstripMainWindow.Size = New System.Drawing.Size(794, 25)
        Me.toolstripMainWindow.TabIndex = 6
        Me.toolstripMainWindow.TabStop = True
        Me.toolstripMainWindow.Text = "ToolStrip1"
        '
        'toolstripbuttonRefreshCache
        '
        Me.toolstripbuttonRefreshCache.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonRefreshCache.Image = CType(resources.GetObject("toolstripbuttonRefreshCache.Image"), System.Drawing.Image)
        Me.toolstripbuttonRefreshCache.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonRefreshCache.Name = "toolstripbuttonRefreshCache"
        Me.toolstripbuttonRefreshCache.Size = New System.Drawing.Size(84, 22)
        Me.toolstripbuttonRefreshCache.Text = "Refresh cache"
        Me.toolstripbuttonRefreshCache.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolstripbuttonApplyChanges
        '
        Me.toolstripbuttonApplyChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonApplyChanges.Image = CType(resources.GetObject("toolstripbuttonApplyChanges.Image"), System.Drawing.Image)
        Me.toolstripbuttonApplyChanges.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonApplyChanges.Name = "toolstripbuttonApplyChanges"
        Me.toolstripbuttonApplyChanges.Size = New System.Drawing.Size(98, 22)
        Me.toolstripbuttonApplyChanges.Text = "Apply changes..."
        Me.toolstripbuttonApplyChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripbuttonProperties
        '
        Me.toolstripbuttonProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonProperties.Image = CType(resources.GetObject("toolstripbuttonProperties.Image"), System.Drawing.Image)
        Me.toolstripbuttonProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonProperties.Name = "toolstripbuttonProperties"
        Me.toolstripbuttonProperties.Size = New System.Drawing.Size(73, 22)
        Me.toolstripbuttonProperties.Text = "Properties..."
        Me.toolstripbuttonProperties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstriptextboxSearch
        '
        Me.toolstriptextboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toolstriptextboxSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.toolstriptextboxSearch.Name = "toolstriptextboxSearch"
        Me.toolstriptextboxSearch.Size = New System.Drawing.Size(200, 25)
        '
        'toolstripsplitbuttonSearch
        '
        Me.toolstripsplitbuttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripsplitbuttonSearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripmenuitemAdvancedSearch})
        Me.toolstripsplitbuttonSearch.Image = CType(resources.GetObject("toolstripsplitbuttonSearch.Image"), System.Drawing.Image)
        Me.toolstripsplitbuttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripsplitbuttonSearch.Name = "toolstripsplitbuttonSearch"
        Me.toolstripsplitbuttonSearch.Size = New System.Drawing.Size(58, 22)
        Me.toolstripsplitbuttonSearch.Text = "Search"
        '
        'toolstripmenuitemAdvancedSearch
        '
        Me.toolstripmenuitemAdvancedSearch.Name = "toolstripmenuitemAdvancedSearch"
        Me.toolstripmenuitemAdvancedSearch.Size = New System.Drawing.Size(173, 22)
        Me.toolstripmenuitemAdvancedSearch.Text = "&Advanced search..."
        '
        'SearchToolstripButton
        '
        Me.SearchToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SearchToolstripButton.Image = CType(resources.GetObject("SearchToolstripButton.Image"), System.Drawing.Image)
        Me.SearchToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SearchToolstripButton.Name = "SearchToolstripButton"
        Me.SearchToolstripButton.Size = New System.Drawing.Size(46, 22)
        Me.SearchToolstripButton.Text = "Search"
        '
        'splitcontainerSidebarAndPkgList
        '
        Me.splitcontainerSidebarAndPkgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitcontainerSidebarAndPkgList.Location = New System.Drawing.Point(0, 0)
        Me.splitcontainerSidebarAndPkgList.Margin = New System.Windows.Forms.Padding(2)
        Me.splitcontainerSidebarAndPkgList.Name = "splitcontainerSidebarAndPkgList"
        '
        'splitcontainerSidebarAndPkgList.Panel1
        '
        Me.splitcontainerSidebarAndPkgList.Panel1.Controls.Add(Me.panelSidebarHolder)
        '
        'splitcontainerSidebarAndPkgList.Panel2
        '
        Me.splitcontainerSidebarAndPkgList.Panel2.Controls.Add(Me.panelMainPkgArea)
        Me.splitcontainerSidebarAndPkgList.Size = New System.Drawing.Size(794, 428)
        Me.splitcontainerSidebarAndPkgList.SplitterDistance = 208
        Me.splitcontainerSidebarAndPkgList.SplitterWidth = 3
        Me.splitcontainerSidebarAndPkgList.TabIndex = 5
        '
        'panelSidebarHolder
        '
        Me.panelSidebarHolder.Controls.Add(Me.buttonCloseSidebar)
        Me.panelSidebarHolder.Controls.Add(Me.comboboxSidebarTabSelector)
        Me.panelSidebarHolder.Controls.Add(Me.tabcontrolSidebar)
        Me.panelSidebarHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSidebarHolder.Location = New System.Drawing.Point(0, 0)
        Me.panelSidebarHolder.Margin = New System.Windows.Forms.Padding(2)
        Me.panelSidebarHolder.Name = "panelSidebarHolder"
        Me.panelSidebarHolder.Size = New System.Drawing.Size(208, 428)
        Me.panelSidebarHolder.TabIndex = 0
        '
        'buttonCloseSidebar
        '
        Me.buttonCloseSidebar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCloseSidebar.AutoSize = True
        Me.buttonCloseSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonCloseSidebar.Location = New System.Drawing.Point(177, 3)
        Me.buttonCloseSidebar.Name = "buttonCloseSidebar"
        Me.buttonCloseSidebar.Size = New System.Drawing.Size(24, 23)
        Me.buttonCloseSidebar.TabIndex = 4
        Me.buttonCloseSidebar.Text = "X"
        Me.buttonCloseSidebar.UseVisualStyleBackColor = True
        '
        'comboboxSidebarTabSelector
        '
        Me.comboboxSidebarTabSelector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxSidebarTabSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxSidebarTabSelector.FormattingEnabled = True
        Me.comboboxSidebarTabSelector.Items.AddRange(New Object() {"Search terms"})
        Me.comboboxSidebarTabSelector.Location = New System.Drawing.Point(8, 3)
        Me.comboboxSidebarTabSelector.Name = "comboboxSidebarTabSelector"
        Me.comboboxSidebarTabSelector.Size = New System.Drawing.Size(163, 21)
        Me.comboboxSidebarTabSelector.TabIndex = 3
        '
        'tabcontrolSidebar
        '
        Me.tabcontrolSidebar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolSidebar.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSearchTerms)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageStatus)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageCustomFilters)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSections)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSource)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageArchitecture)
        Me.tabcontrolSidebar.ItemSize = New System.Drawing.Size(0, 1)
        Me.tabcontrolSidebar.Location = New System.Drawing.Point(4, 26)
        Me.tabcontrolSidebar.Margin = New System.Windows.Forms.Padding(2)
        Me.tabcontrolSidebar.Name = "tabcontrolSidebar"
        Me.tabcontrolSidebar.SelectedIndex = 0
        Me.tabcontrolSidebar.Size = New System.Drawing.Size(201, 400)
        Me.tabcontrolSidebar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabcontrolSidebar.TabIndex = 2
        '
        'tabpageSearchTerms
        '
        Me.tabpageSearchTerms.Controls.Add(Me.listboxSearchTerms)
        Me.tabpageSearchTerms.Location = New System.Drawing.Point(4, 5)
        Me.tabpageSearchTerms.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageSearchTerms.Name = "tabpageSearchTerms"
        Me.tabpageSearchTerms.Size = New System.Drawing.Size(193, 391)
        Me.tabpageSearchTerms.TabIndex = 4
        Me.tabpageSearchTerms.Text = "Search terms"
        Me.tabpageSearchTerms.UseVisualStyleBackColor = True
        '
        'listboxSearchTerms
        '
        Me.listboxSearchTerms.ContextMenuStrip = Me.contextmenuSearchTerm
        Me.listboxSearchTerms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSearchTerms.FormattingEnabled = True
        Me.listboxSearchTerms.IntegralHeight = False
        Me.listboxSearchTerms.Items.AddRange(New Object() {"All"})
        Me.listboxSearchTerms.Location = New System.Drawing.Point(0, 0)
        Me.listboxSearchTerms.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxSearchTerms.Name = "listboxSearchTerms"
        Me.listboxSearchTerms.Size = New System.Drawing.Size(193, 391)
        Me.listboxSearchTerms.TabIndex = 2
        '
        'contextmenuSearchTerm
        '
        Me.contextmenuSearchTerm.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenuSearchTerm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearSelectedSearchTermToolStripMenuItem, Me.ToolStripSeparator3, Me.ClearAllSearchTermsToolStripMenuItem})
        Me.contextmenuSearchTerm.Name = "contextmenuSearchTerm"
        Me.contextmenuSearchTerm.Size = New System.Drawing.Size(213, 76)
        '
        'ClearSelectedSearchTermToolStripMenuItem
        '
        Me.ClearSelectedSearchTermToolStripMenuItem.Name = "ClearSelectedSearchTermToolStripMenuItem"
        Me.ClearSelectedSearchTermToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ClearSelectedSearchTermToolStripMenuItem.Text = "Clear selected search term"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(209, 6)
        '
        'ClearAllSearchTermsToolStripMenuItem
        '
        Me.ClearAllSearchTermsToolStripMenuItem.Name = "ClearAllSearchTermsToolStripMenuItem"
        Me.ClearAllSearchTermsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ClearAllSearchTermsToolStripMenuItem.Text = "Clear all search terms"
        '
        'tabpageStatus
        '
        Me.tabpageStatus.Controls.Add(Me.listboxStatusTab)
        Me.tabpageStatus.Location = New System.Drawing.Point(4, 5)
        Me.tabpageStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageStatus.Name = "tabpageStatus"
        Me.tabpageStatus.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageStatus.Size = New System.Drawing.Size(221, 391)
        Me.tabpageStatus.TabIndex = 1
        Me.tabpageStatus.Text = "Status"
        Me.tabpageStatus.UseVisualStyleBackColor = True
        '
        'listboxStatusTab
        '
        Me.listboxStatusTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxStatusTab.FormattingEnabled = True
        Me.listboxStatusTab.IntegralHeight = False
        Me.listboxStatusTab.Items.AddRange(New Object() {"All"})
        Me.listboxStatusTab.Location = New System.Drawing.Point(2, 2)
        Me.listboxStatusTab.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxStatusTab.Name = "listboxStatusTab"
        Me.listboxStatusTab.Size = New System.Drawing.Size(217, 387)
        Me.listboxStatusTab.TabIndex = 0
        '
        'tabpageCustomFilters
        '
        Me.tabpageCustomFilters.Controls.Add(Me.listboxCustomFilters)
        Me.tabpageCustomFilters.Location = New System.Drawing.Point(4, 5)
        Me.tabpageCustomFilters.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageCustomFilters.Name = "tabpageCustomFilters"
        Me.tabpageCustomFilters.Size = New System.Drawing.Size(221, 391)
        Me.tabpageCustomFilters.TabIndex = 3
        Me.tabpageCustomFilters.Text = "Custom filters"
        Me.tabpageCustomFilters.UseVisualStyleBackColor = True
        '
        'listboxCustomFilters
        '
        Me.listboxCustomFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxCustomFilters.FormattingEnabled = True
        Me.listboxCustomFilters.IntegralHeight = False
        Me.listboxCustomFilters.Items.AddRange(New Object() {"All"})
        Me.listboxCustomFilters.Location = New System.Drawing.Point(0, 0)
        Me.listboxCustomFilters.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxCustomFilters.Name = "listboxCustomFilters"
        Me.listboxCustomFilters.Size = New System.Drawing.Size(221, 391)
        Me.listboxCustomFilters.TabIndex = 1
        '
        'tabpageSections
        '
        Me.tabpageSections.Controls.Add(Me.listboxSections)
        Me.tabpageSections.Location = New System.Drawing.Point(4, 5)
        Me.tabpageSections.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageSections.Name = "tabpageSections"
        Me.tabpageSections.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageSections.Size = New System.Drawing.Size(221, 391)
        Me.tabpageSections.TabIndex = 0
        Me.tabpageSections.Text = "Categories"
        Me.tabpageSections.UseVisualStyleBackColor = True
        '
        'listboxSections
        '
        Me.listboxSections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSections.FormattingEnabled = True
        Me.listboxSections.IntegralHeight = False
        Me.listboxSections.Items.AddRange(New Object() {"All"})
        Me.listboxSections.Location = New System.Drawing.Point(2, 2)
        Me.listboxSections.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxSections.Name = "listboxSections"
        Me.listboxSections.Size = New System.Drawing.Size(217, 387)
        Me.listboxSections.TabIndex = 1
        '
        'tabpageSource
        '
        Me.tabpageSource.Controls.Add(Me.listboxSourceTab)
        Me.tabpageSource.Location = New System.Drawing.Point(4, 5)
        Me.tabpageSource.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageSource.Name = "tabpageSource"
        Me.tabpageSource.Size = New System.Drawing.Size(221, 391)
        Me.tabpageSource.TabIndex = 2
        Me.tabpageSource.Text = "Source"
        Me.tabpageSource.UseVisualStyleBackColor = True
        '
        'listboxSourceTab
        '
        Me.listboxSourceTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSourceTab.FormattingEnabled = True
        Me.listboxSourceTab.IntegralHeight = False
        Me.listboxSourceTab.Items.AddRange(New Object() {"All"})
        Me.listboxSourceTab.Location = New System.Drawing.Point(0, 0)
        Me.listboxSourceTab.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxSourceTab.Name = "listboxSourceTab"
        Me.listboxSourceTab.Size = New System.Drawing.Size(221, 391)
        Me.listboxSourceTab.TabIndex = 1
        '
        'tabpageArchitecture
        '
        Me.tabpageArchitecture.Controls.Add(Me.listboxArchitecture)
        Me.tabpageArchitecture.Location = New System.Drawing.Point(4, 5)
        Me.tabpageArchitecture.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageArchitecture.Name = "tabpageArchitecture"
        Me.tabpageArchitecture.Size = New System.Drawing.Size(221, 391)
        Me.tabpageArchitecture.TabIndex = 5
        Me.tabpageArchitecture.Text = "Architecture"
        Me.tabpageArchitecture.UseVisualStyleBackColor = True
        '
        'listboxArchitecture
        '
        Me.listboxArchitecture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxArchitecture.FormattingEnabled = True
        Me.listboxArchitecture.IntegralHeight = False
        Me.listboxArchitecture.Items.AddRange(New Object() {"All"})
        Me.listboxArchitecture.Location = New System.Drawing.Point(0, 0)
        Me.listboxArchitecture.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxArchitecture.Name = "listboxArchitecture"
        Me.listboxArchitecture.Size = New System.Drawing.Size(221, 391)
        Me.listboxArchitecture.TabIndex = 1
        '
        'panelMainForm
        '
        Me.panelMainForm.Controls.Add(Me.splitcontainerSidebarAndPkgList)
        Me.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainForm.Location = New System.Drawing.Point(0, 49)
        Me.panelMainForm.Margin = New System.Windows.Forms.Padding(2)
        Me.panelMainForm.Name = "panelMainForm"
        Me.panelMainForm.Size = New System.Drawing.Size(794, 428)
        Me.panelMainForm.TabIndex = 4
        '
        'statusbarMainWindow
        '
        Me.statusbarMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusbarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripstatuslabelPackageCount, Me.toolstripstatusSplitter, Me.toolstripprogressbarLoadingPackages, Me.toolstripstatuslabelLoadingPackageCount})
        Me.statusbarMainWindow.Location = New System.Drawing.Point(0, 477)
        Me.statusbarMainWindow.Name = "statusbarMainWindow"
        Me.statusbarMainWindow.Padding = New System.Windows.Forms.Padding(1, 0, 11, 0)
        Me.statusbarMainWindow.Size = New System.Drawing.Size(794, 22)
        Me.statusbarMainWindow.TabIndex = 5
        Me.statusbarMainWindow.Text = "StatusStrip1"
        '
        'toolstripstatuslabelPackageCount
        '
        Me.toolstripstatuslabelPackageCount.Name = "toolstripstatuslabelPackageCount"
        Me.toolstripstatuslabelPackageCount.Size = New System.Drawing.Size(107, 17)
        Me.toolstripstatuslabelPackageCount.Text = "0 packages loaded."
        '
        'toolstripstatusSplitter
        '
        Me.toolstripstatusSplitter.Name = "toolstripstatusSplitter"
        Me.toolstripstatusSplitter.Size = New System.Drawing.Size(10, 17)
        Me.toolstripstatusSplitter.Text = "|"
        Me.toolstripstatusSplitter.Visible = False
        '
        'toolstripprogressbarLoadingPackages
        '
        Me.toolstripprogressbarLoadingPackages.Name = "toolstripprogressbarLoadingPackages"
        Me.toolstripprogressbarLoadingPackages.Size = New System.Drawing.Size(120, 16)
        Me.toolstripprogressbarLoadingPackages.Visible = False
        '
        'toolstripstatuslabelLoadingPackageCount
        '
        Me.toolstripstatuslabelLoadingPackageCount.Name = "toolstripstatuslabelLoadingPackageCount"
        Me.toolstripstatuslabelLoadingPackageCount.Size = New System.Drawing.Size(111, 17)
        Me.toolstripstatuslabelLoadingPackageCount.Text = "Loading packages..."
        Me.toolstripstatuslabelLoadingPackageCount.Visible = False
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(794, 499)
        Me.Controls.Add(Me.panelMainForm)
        Me.Controls.Add(Me.statusbarMainWindow)
        Me.Controls.Add(Me.toolstripMainWindow)
        Me.Controls.Add(Me.menustripMainWindow)
        Me.MainMenuStrip = Me.menustripMainWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "aaformMainWindow"
        Me.Text = "guinget"
        Me.menustripMainWindow.ResumeLayout(False)
        Me.menustripMainWindow.PerformLayout()
        Me.contextmenustripPackageMenu.ResumeLayout(False)
        Me.splitcontainerMainWindow.Panel1.ResumeLayout(False)
        Me.splitcontainerMainWindow.Panel2.ResumeLayout(False)
        Me.splitcontainerMainWindow.Panel2.PerformLayout()
        CType(Me.splitcontainerMainWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitcontainerMainWindow.ResumeLayout(False)
        Me.panelPackageListHolder.ResumeLayout(False)
        Me.panelPackageListHolder.PerformLayout()
        CType(Me.datagridviewPackageList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMainPkgArea.ResumeLayout(False)
        Me.toolstripMainWindow.ResumeLayout(False)
        Me.toolstripMainWindow.PerformLayout()
        Me.splitcontainerSidebarAndPkgList.Panel1.ResumeLayout(False)
        Me.splitcontainerSidebarAndPkgList.Panel2.ResumeLayout(False)
        CType(Me.splitcontainerSidebarAndPkgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitcontainerSidebarAndPkgList.ResumeLayout(False)
        Me.panelSidebarHolder.ResumeLayout(False)
        Me.panelSidebarHolder.PerformLayout()
        Me.tabcontrolSidebar.ResumeLayout(False)
        Me.tabpageSearchTerms.ResumeLayout(False)
        Me.contextmenuSearchTerm.ResumeLayout(False)
        Me.tabpageStatus.ResumeLayout(False)
        Me.tabpageCustomFilters.ResumeLayout(False)
        Me.tabpageSections.ResumeLayout(False)
        Me.tabpageSource.ResumeLayout(False)
        Me.tabpageArchitecture.ResumeLayout(False)
        Me.panelMainForm.ResumeLayout(False)
        Me.statusbarMainWindow.ResumeLayout(False)
        Me.statusbarMainWindow.PerformLayout()
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
    Friend WithEvents toolstriptextboxSearch As ToolStripTextBox
    Friend WithEvents datagridviewPackageList As DataGridView
    Friend WithEvents contextmenustripPackageMenu As ContextMenuStrip
    Friend WithEvents ActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoNothingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents statusbarMainWindow As StatusStrip
    Friend WithEvents toolstripstatuslabelPackageCount As ToolStripStatusLabel
    Friend WithEvents toolstripstatuslabelLoadingPackageCount As ToolStripStatusLabel
    Friend WithEvents toolstripprogressbarLoadingPackages As ToolStripProgressBar
    Friend WithEvents toolstripstatusSplitter As ToolStripStatusLabel
    Friend WithEvents labelUpdatingPackageList As Label
    Friend WithEvents panelPackageListHolder As Panel
    Friend WithEvents toolstripsplitbuttonSearch As ToolStripSplitButton
    Friend WithEvents toolstripmenuitemAdvancedSearch As ToolStripMenuItem
    Friend WithEvents PackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshCacheMenuButton As ToolStripMenuItem
    Friend WithEvents ApplyChangesMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents PackageContextMenuDropdown As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents PackagePropertiesMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents AdvancedSearchMenuItem As ToolStripMenuItem
    Friend WithEvents PkgAction As DataGridViewComboBoxColumn
    Friend WithEvents PkgStatus As DataGridViewTextBoxColumn
    Friend WithEvents PkgName As DataGridViewTextBoxColumn
    Friend WithEvents FriendlyName As DataGridViewTextBoxColumn
    Friend WithEvents AvailableVersion As DataGridViewTextBoxColumn
    Friend WithEvents PkgDescription As DataGridViewTextBoxColumn
    Friend WithEvents Manifest As DataGridViewTextBoxColumn
    Friend WithEvents SearchMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolstripButton As ToolStripButton
    Friend WithEvents comboboxSidebarTabSelector As ComboBox
    Friend WithEvents buttonCloseSidebar As Button
End Class
