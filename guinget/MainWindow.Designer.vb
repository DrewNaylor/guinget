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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformMainWindow))
        Me.menustripMainWindow = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemImportPackages = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemExportPackages = New System.Windows.Forms.ToolStripMenuItem()
        Me.zFileMenuSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RunCMDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunCMDElevatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zFileMenuSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SidebarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zToolStripSeparatorViewMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.ListInstalledPackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowUpgradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshCacheMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateWingetSourcesMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.zSeparatorAfterRefreshPart = New System.Windows.Forms.ToolStripSeparator()
        Me.ApplyChangesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zSeparatorPackageListMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedSearchMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedPackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedPackagesActionDoNothingMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedPackagesActionInstallMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedPackagesActionUninstallMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedPackagesActionUpgradeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zSeparatorAfterActionsInSelectedPackagesMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectedPackagesSearchForLastSelectedID = New System.Windows.Forms.ToolStripMenuItem()
        Me.zSeparatorSelectedPackagesMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowInWingetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectedPackagesProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerifyManifestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindManifestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zSeparatorAboveEditWingetSettings = New System.Windows.Forms.ToolStripSeparator()
        Me.EditWingetSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditWingetSettingsAsAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToUseGuingetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenuToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.contextmenustripPackageMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DoNothingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UninstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zSeparatorAfterActionButtonsInPackageContextMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchForPackageIDFromContextMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.zSeparatorPackageContextMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowInwingetToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiesPackageContextMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitcontainerMainWindow = New System.Windows.Forms.SplitContainer()
        Me.panelPackageListHolder = New System.Windows.Forms.Panel()
        Me.datagridviewPackageList = New System.Windows.Forms.DataGridView()
        Me.PkgAction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PkgStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PkgName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FriendlyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LatestVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PkgDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Manifest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManifestType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelUpdatingPackageList = New System.Windows.Forms.Label()
        Me.textboxPackageDetails = New System.Windows.Forms.RichTextBox()
        Me.contextmenuPackageDetailsTextbox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.RightToLeftMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelMainPkgArea = New System.Windows.Forms.Panel()
        Me.toolstripMainWindow = New System.Windows.Forms.ToolStrip()
        Me.toolstripbuttonRefreshCache = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbuttonApplyChanges = New System.Windows.Forms.ToolStripButton()
        Me.zSeparatorApplyChangesAndProperties = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbuttonProperties = New System.Windows.Forms.ToolStripButton()
        Me.zSeparatorPropertiesAndSearchBox = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstriptextboxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.toolstripsplitbuttonSearch = New System.Windows.Forms.ToolStripSplitButton()
        Me.toolstripmenuitemAdvancedSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitcontainerSidebarAndPkgList = New System.Windows.Forms.SplitContainer()
        Me.panelSidebarHolder = New System.Windows.Forms.Panel()
        Me.buttonCloseSidebar = New System.Windows.Forms.Button()
        Me.comboboxSidebarTabSelector = New System.Windows.Forms.ComboBox()
        Me.tabcontrolSidebar = New System.Windows.Forms.TabControl()
        Me.tabpageSearchTerms = New System.Windows.Forms.TabPage()
        Me.listboxSearchTerms = New System.Windows.Forms.ListBox()
        Me.contextmenuSearchTerm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearSelectedSearchTermToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zSeparatorSearchSidebarContextMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllSearchTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabpageAction = New System.Windows.Forms.TabPage()
        Me.listboxActions = New System.Windows.Forms.ListBox()
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
        Me.SelectedPackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zCantFindThisPackagePropertiesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zSeparatorNoIdeaWhereThisIs = New System.Windows.Forms.ToolStripSeparator()
        Me.TypeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialogExportPackages = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialogImportPackages = New System.Windows.Forms.OpenFileDialog()
        Me.pictureboxFastResizePackageList = New System.Windows.Forms.PictureBox()
        Me.menustripMainWindow.SuspendLayout()
        Me.contextmenustripPackageMenu.SuspendLayout()
        CType(Me.splitcontainerMainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerMainWindow.Panel1.SuspendLayout()
        Me.splitcontainerMainWindow.Panel2.SuspendLayout()
        Me.splitcontainerMainWindow.SuspendLayout()
        Me.panelPackageListHolder.SuspendLayout()
        CType(Me.datagridviewPackageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextmenuPackageDetailsTextbox.SuspendLayout()
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
        Me.tabpageAction.SuspendLayout()
        Me.tabpageStatus.SuspendLayout()
        Me.tabpageCustomFilters.SuspendLayout()
        Me.tabpageSections.SuspendLayout()
        Me.tabpageSource.SuspendLayout()
        Me.tabpageArchitecture.SuspendLayout()
        Me.panelMainForm.SuspendLayout()
        Me.statusbarMainWindow.SuspendLayout()
        CType(Me.pictureboxFastResizePackageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menustripMainWindow
        '
        Me.menustripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menustripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.PackageToolStripMenuItem, Me.SelectedPackagesToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menustripMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menustripMainWindow.Name = "menustripMainWindow"
        Me.menustripMainWindow.Size = New System.Drawing.Size(1105, 28)
        Me.menustripMainWindow.TabIndex = 0
        Me.menustripMainWindow.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemImportPackages, Me.ToolStripMenuItemExportPackages, Me.zFileMenuSeparator2, Me.RunCMDToolStripMenuItem, Me.RunCMDElevatedToolStripMenuItem, Me.zFileMenuSeparator, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ToolStripMenuItemImportPackages
        '
        Me.ToolStripMenuItemImportPackages.Name = "ToolStripMenuItemImportPackages"
        Me.ToolStripMenuItemImportPackages.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ToolStripMenuItemImportPackages.Size = New System.Drawing.Size(377, 26)
        Me.ToolStripMenuItemImportPackages.Text = "I&mport packages..."
        '
        'ToolStripMenuItemExportPackages
        '
        Me.ToolStripMenuItemExportPackages.Name = "ToolStripMenuItemExportPackages"
        Me.ToolStripMenuItemExportPackages.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.ToolStripMenuItemExportPackages.Size = New System.Drawing.Size(377, 26)
        Me.ToolStripMenuItemExportPackages.Text = "Exp&ort packages..."
        '
        'zFileMenuSeparator2
        '
        Me.zFileMenuSeparator2.Name = "zFileMenuSeparator2"
        Me.zFileMenuSeparator2.Size = New System.Drawing.Size(374, 6)
        '
        'RunCMDToolStripMenuItem
        '
        Me.RunCMDToolStripMenuItem.Name = "RunCMDToolStripMenuItem"
        Me.RunCMDToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.RunCMDToolStripMenuItem.Size = New System.Drawing.Size(377, 26)
        Me.RunCMDToolStripMenuItem.Text = "Run &CMD"
        '
        'RunCMDElevatedToolStripMenuItem
        '
        Me.RunCMDElevatedToolStripMenuItem.Name = "RunCMDElevatedToolStripMenuItem"
        Me.RunCMDElevatedToolStripMenuItem.ShortcutKeys = CType((((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.RunCMDElevatedToolStripMenuItem.Size = New System.Drawing.Size(377, 26)
        Me.RunCMDElevatedToolStripMenuItem.Text = "Run CMD &elevated (UAC)"
        '
        'zFileMenuSeparator
        '
        Me.zFileMenuSeparator.Name = "zFileMenuSeparator"
        Me.zFileMenuSeparator.Size = New System.Drawing.Size(374, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(377, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SidebarToolStripMenuItem, Me.zToolStripSeparatorViewMenu, Me.ListInstalledPackagesToolStripMenuItem, Me.ShowUpgradesToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'SidebarToolStripMenuItem
        '
        Me.SidebarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SidebarToolStripMenuItem.Name = "SidebarToolStripMenuItem"
        Me.SidebarToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.SidebarToolStripMenuItem.Text = "&Sidebar"
        '
        'zToolStripSeparatorViewMenu
        '
        Me.zToolStripSeparatorViewMenu.Name = "zToolStripSeparatorViewMenu"
        Me.zToolStripSeparatorViewMenu.Size = New System.Drawing.Size(226, 6)
        '
        'ListInstalledPackagesToolStripMenuItem
        '
        Me.ListInstalledPackagesToolStripMenuItem.Name = "ListInstalledPackagesToolStripMenuItem"
        Me.ListInstalledPackagesToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ListInstalledPackagesToolStripMenuItem.Text = "I&nstalled packages..."
        '
        'ShowUpgradesToolStripMenuItem
        '
        Me.ShowUpgradesToolStripMenuItem.Name = "ShowUpgradesToolStripMenuItem"
        Me.ShowUpgradesToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ShowUpgradesToolStripMenuItem.Text = "&Available upgrades..."
        '
        'PackageToolStripMenuItem
        '
        Me.PackageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshCacheMenuButton, Me.UpdateWingetSourcesMenuButton, Me.zSeparatorAfterRefreshPart, Me.ApplyChangesMenuItem, Me.zSeparatorPackageListMenu, Me.SearchMenuItem, Me.AdvancedSearchMenuItem})
        Me.PackageToolStripMenuItem.Name = "PackageToolStripMenuItem"
        Me.PackageToolStripMenuItem.Size = New System.Drawing.Size(100, 24)
        Me.PackageToolStripMenuItem.Text = "&Package list"
        '
        'RefreshCacheMenuButton
        '
        Me.RefreshCacheMenuButton.Name = "RefreshCacheMenuButton"
        Me.RefreshCacheMenuButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefreshCacheMenuButton.Size = New System.Drawing.Size(288, 26)
        Me.RefreshCacheMenuButton.Text = "&Refresh cache"
        '
        'UpdateWingetSourcesMenuButton
        '
        Me.UpdateWingetSourcesMenuButton.Name = "UpdateWingetSourcesMenuButton"
        Me.UpdateWingetSourcesMenuButton.Size = New System.Drawing.Size(288, 26)
        Me.UpdateWingetSourcesMenuButton.Text = "&Update winget sources"
        '
        'zSeparatorAfterRefreshPart
        '
        Me.zSeparatorAfterRefreshPart.Name = "zSeparatorAfterRefreshPart"
        Me.zSeparatorAfterRefreshPart.Size = New System.Drawing.Size(285, 6)
        '
        'ApplyChangesMenuItem
        '
        Me.ApplyChangesMenuItem.Name = "ApplyChangesMenuItem"
        Me.ApplyChangesMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ApplyChangesMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.ApplyChangesMenuItem.Text = "Apply c&hanges..."
        '
        'zSeparatorPackageListMenu
        '
        Me.zSeparatorPackageListMenu.Name = "zSeparatorPackageListMenu"
        Me.zSeparatorPackageListMenu.Size = New System.Drawing.Size(285, 6)
        '
        'SearchMenuItem
        '
        Me.SearchMenuItem.Name = "SearchMenuItem"
        Me.SearchMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.SearchMenuItem.Text = "&Focus search box"
        '
        'AdvancedSearchMenuItem
        '
        Me.AdvancedSearchMenuItem.Name = "AdvancedSearchMenuItem"
        Me.AdvancedSearchMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.AdvancedSearchMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.AdvancedSearchMenuItem.Text = "Search &options..."
        '
        'SelectedPackagesToolStripMenuItem
        '
        Me.SelectedPackagesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectedPackagesActionDoNothingMenuItem, Me.SelectedPackagesActionInstallMenuItem, Me.SelectedPackagesActionUninstallMenuItem, Me.SelectedPackagesActionUpgradeMenuItem, Me.zSeparatorAfterActionsInSelectedPackagesMenu, Me.SelectedPackagesSearchForLastSelectedID, Me.zSeparatorSelectedPackagesMenu, Me.ShowInWingetToolStripMenuItem, Me.SelectedPackagesProperties})
        Me.SelectedPackagesToolStripMenuItem.Name = "SelectedPackagesToolStripMenuItem"
        Me.SelectedPackagesToolStripMenuItem.Size = New System.Drawing.Size(146, 24)
        Me.SelectedPackagesToolStripMenuItem.Text = "&Selected packages"
        '
        'SelectedPackagesActionDoNothingMenuItem
        '
        Me.SelectedPackagesActionDoNothingMenuItem.Name = "SelectedPackagesActionDoNothingMenuItem"
        Me.SelectedPackagesActionDoNothingMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.SelectedPackagesActionDoNothingMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.SelectedPackagesActionDoNothingMenuItem.Text = "Action: &Do nothing"
        '
        'SelectedPackagesActionInstallMenuItem
        '
        Me.SelectedPackagesActionInstallMenuItem.Name = "SelectedPackagesActionInstallMenuItem"
        Me.SelectedPackagesActionInstallMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.SelectedPackagesActionInstallMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.SelectedPackagesActionInstallMenuItem.Text = "Action: &Install"
        '
        'SelectedPackagesActionUninstallMenuItem
        '
        Me.SelectedPackagesActionUninstallMenuItem.Name = "SelectedPackagesActionUninstallMenuItem"
        Me.SelectedPackagesActionUninstallMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.SelectedPackagesActionUninstallMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.SelectedPackagesActionUninstallMenuItem.Text = "Action: &Uninstall"
        '
        'SelectedPackagesActionUpgradeMenuItem
        '
        Me.SelectedPackagesActionUpgradeMenuItem.Name = "SelectedPackagesActionUpgradeMenuItem"
        Me.SelectedPackagesActionUpgradeMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.SelectedPackagesActionUpgradeMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.SelectedPackagesActionUpgradeMenuItem.Text = "Action: U&pgrade"
        '
        'zSeparatorAfterActionsInSelectedPackagesMenu
        '
        Me.zSeparatorAfterActionsInSelectedPackagesMenu.Name = "zSeparatorAfterActionsInSelectedPackagesMenu"
        Me.zSeparatorAfterActionsInSelectedPackagesMenu.Size = New System.Drawing.Size(267, 6)
        '
        'SelectedPackagesSearchForLastSelectedID
        '
        Me.SelectedPackagesSearchForLastSelectedID.Name = "SelectedPackagesSearchForLastSelectedID"
        Me.SelectedPackagesSearchForLastSelectedID.Size = New System.Drawing.Size(270, 26)
        Me.SelectedPackagesSearchForLastSelectedID.Text = "&Search for package ID"
        '
        'zSeparatorSelectedPackagesMenu
        '
        Me.zSeparatorSelectedPackagesMenu.Name = "zSeparatorSelectedPackagesMenu"
        Me.zSeparatorSelectedPackagesMenu.Size = New System.Drawing.Size(267, 6)
        '
        'ShowInWingetToolStripMenuItem
        '
        Me.ShowInWingetToolStripMenuItem.Name = "ShowInWingetToolStripMenuItem"
        Me.ShowInWingetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ShowInWingetToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.ShowInWingetToolStripMenuItem.Text = "Show in &winget..."
        '
        'SelectedPackagesProperties
        '
        Me.SelectedPackagesProperties.Name = "SelectedPackagesProperties"
        Me.SelectedPackagesProperties.Size = New System.Drawing.Size(270, 26)
        Me.SelectedPackagesProperties.Text = "&Properties..."
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerifyManifestToolStripMenuItem, Me.FindManifestToolStripMenuItem, Me.zSeparatorAboveEditWingetSettings, Me.EditWingetSettingsToolStripMenuItem, Me.EditWingetSettingsAsAdminToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'VerifyManifestToolStripMenuItem
        '
        Me.VerifyManifestToolStripMenuItem.Name = "VerifyManifestToolStripMenuItem"
        Me.VerifyManifestToolStripMenuItem.Size = New System.Drawing.Size(328, 26)
        Me.VerifyManifestToolStripMenuItem.Text = "&Validate manifest"
        '
        'FindManifestToolStripMenuItem
        '
        Me.FindManifestToolStripMenuItem.Name = "FindManifestToolStripMenuItem"
        Me.FindManifestToolStripMenuItem.Size = New System.Drawing.Size(328, 26)
        Me.FindManifestToolStripMenuItem.Text = "Find manifest using version and ID..."
        '
        'zSeparatorAboveEditWingetSettings
        '
        Me.zSeparatorAboveEditWingetSettings.Name = "zSeparatorAboveEditWingetSettings"
        Me.zSeparatorAboveEditWingetSettings.Size = New System.Drawing.Size(325, 6)
        '
        'EditWingetSettingsToolStripMenuItem
        '
        Me.EditWingetSettingsToolStripMenuItem.Name = "EditWingetSettingsToolStripMenuItem"
        Me.EditWingetSettingsToolStripMenuItem.Size = New System.Drawing.Size(328, 26)
        Me.EditWingetSettingsToolStripMenuItem.Text = "&Edit winget settings"
        '
        'EditWingetSettingsAsAdminToolStripMenuItem
        '
        Me.EditWingetSettingsAsAdminToolStripMenuItem.Name = "EditWingetSettingsAsAdminToolStripMenuItem"
        Me.EditWingetSettingsAsAdminToolStripMenuItem.Size = New System.Drawing.Size(328, 26)
        Me.EditWingetSettingsAsAdminToolStripMenuItem.Text = "E&dit winget settings elevated (UAC)"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(328, 26)
        Me.OptionsToolStripMenuItem.Text = "&Options..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowToUseGuingetToolStripMenuItem, Me.HelpMenuToolStripSeparator, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HowToUseGuingetToolStripMenuItem
        '
        Me.HowToUseGuingetToolStripMenuItem.Name = "HowToUseGuingetToolStripMenuItem"
        Me.HowToUseGuingetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HowToUseGuingetToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.HowToUseGuingetToolStripMenuItem.Text = "&How to use guinget"
        Me.HowToUseGuingetToolStripMenuItem.ToolTipText = "Navigates to https://drew-naylor.com/guinget/How-to-use" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in your default browser." &
    ""
        '
        'HelpMenuToolStripSeparator
        '
        Me.HelpMenuToolStripSeparator.Name = "HelpMenuToolStripSeparator"
        Me.HelpMenuToolStripSeparator.Size = New System.Drawing.Size(243, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(246, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'contextmenustripPackageMenu
        '
        Me.contextmenustripPackageMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenustripPackageMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoNothingToolStripMenuItem, Me.InstallToolStripMenuItem, Me.UninstallToolStripMenuItem, Me.UpgradeToolStripMenuItem, Me.zSeparatorAfterActionButtonsInPackageContextMenu, Me.SearchForPackageIDFromContextMenu, Me.zSeparatorPackageContextMenu, Me.ShowInwingetToolStripMenuItem1, Me.PropertiesPackageContextMenuToolStripMenuItem})
        Me.contextmenustripPackageMenu.Name = "ContextMenuStrip1"
        Me.contextmenustripPackageMenu.Size = New System.Drawing.Size(225, 184)
        '
        'DoNothingToolStripMenuItem
        '
        Me.DoNothingToolStripMenuItem.Name = "DoNothingToolStripMenuItem"
        Me.DoNothingToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.DoNothingToolStripMenuItem.Text = "Action: &Do nothing"
        '
        'InstallToolStripMenuItem
        '
        Me.InstallToolStripMenuItem.Name = "InstallToolStripMenuItem"
        Me.InstallToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.InstallToolStripMenuItem.Text = "Action: &Install"
        '
        'UninstallToolStripMenuItem
        '
        Me.UninstallToolStripMenuItem.Name = "UninstallToolStripMenuItem"
        Me.UninstallToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.UninstallToolStripMenuItem.Text = "Action: &Uninstall"
        '
        'UpgradeToolStripMenuItem
        '
        Me.UpgradeToolStripMenuItem.Name = "UpgradeToolStripMenuItem"
        Me.UpgradeToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.UpgradeToolStripMenuItem.Text = "Action: U&pgrade"
        '
        'zSeparatorAfterActionButtonsInPackageContextMenu
        '
        Me.zSeparatorAfterActionButtonsInPackageContextMenu.Name = "zSeparatorAfterActionButtonsInPackageContextMenu"
        Me.zSeparatorAfterActionButtonsInPackageContextMenu.Size = New System.Drawing.Size(221, 6)
        '
        'SearchForPackageIDFromContextMenu
        '
        Me.SearchForPackageIDFromContextMenu.Name = "SearchForPackageIDFromContextMenu"
        Me.SearchForPackageIDFromContextMenu.Size = New System.Drawing.Size(224, 24)
        Me.SearchForPackageIDFromContextMenu.Text = "&Search for package ID"
        '
        'zSeparatorPackageContextMenu
        '
        Me.zSeparatorPackageContextMenu.Name = "zSeparatorPackageContextMenu"
        Me.zSeparatorPackageContextMenu.Size = New System.Drawing.Size(221, 6)
        '
        'ShowInwingetToolStripMenuItem1
        '
        Me.ShowInwingetToolStripMenuItem1.Name = "ShowInwingetToolStripMenuItem1"
        Me.ShowInwingetToolStripMenuItem1.Size = New System.Drawing.Size(224, 24)
        Me.ShowInwingetToolStripMenuItem1.Text = "Show in &winget..."
        '
        'PropertiesPackageContextMenuToolStripMenuItem
        '
        Me.PropertiesPackageContextMenuToolStripMenuItem.Name = "PropertiesPackageContextMenuToolStripMenuItem"
        Me.PropertiesPackageContextMenuToolStripMenuItem.Size = New System.Drawing.Size(224, 24)
        Me.PropertiesPackageContextMenuToolStripMenuItem.Text = "&Properties..."
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
        Me.splitcontainerMainWindow.Size = New System.Drawing.Size(830, 641)
        Me.splitcontainerMainWindow.SplitterDistance = 425
        Me.splitcontainerMainWindow.TabIndex = 4
        '
        'panelPackageListHolder
        '
        Me.panelPackageListHolder.Controls.Add(Me.datagridviewPackageList)
        Me.panelPackageListHolder.Controls.Add(Me.pictureboxFastResizePackageList)
        Me.panelPackageListHolder.Controls.Add(Me.labelUpdatingPackageList)
        Me.panelPackageListHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPackageListHolder.Location = New System.Drawing.Point(0, 0)
        Me.panelPackageListHolder.Margin = New System.Windows.Forms.Padding(2)
        Me.panelPackageListHolder.Name = "panelPackageListHolder"
        Me.panelPackageListHolder.Size = New System.Drawing.Size(830, 425)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridviewPackageList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewPackageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPackageList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PkgAction, Me.PkgStatus, Me.PkgName, Me.FriendlyName, Me.AvailableVersion, Me.LatestVersion, Me.PkgDescription, Me.Manifest, Me.ManifestType})
        Me.datagridviewPackageList.ContextMenuStrip = Me.contextmenustripPackageMenu
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridviewPackageList.DefaultCellStyle = DataGridViewCellStyle2
        Me.datagridviewPackageList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewPackageList.Location = New System.Drawing.Point(0, 0)
        Me.datagridviewPackageList.Margin = New System.Windows.Forms.Padding(2)
        Me.datagridviewPackageList.Name = "datagridviewPackageList"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridviewPackageList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridviewPackageList.RowHeadersVisible = False
        Me.datagridviewPackageList.RowHeadersWidth = 51
        Me.datagridviewPackageList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewPackageList.RowTemplate.Height = 24
        Me.datagridviewPackageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPackageList.ShowEditingIcon = False
        Me.datagridviewPackageList.Size = New System.Drawing.Size(830, 425)
        Me.datagridviewPackageList.StandardTab = True
        Me.datagridviewPackageList.TabIndex = 0
        '
        'PkgAction
        '
        Me.PkgAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PkgAction.HeaderText = "Action"
        Me.PkgAction.Items.AddRange(New Object() {"Do nothing", "Install", "Uninstall", "Upgrade"})
        Me.PkgAction.MinimumWidth = 6
        Me.PkgAction.Name = "PkgAction"
        Me.PkgAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PkgAction.Width = 76
        '
        'PkgStatus
        '
        Me.PkgStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PkgStatus.HeaderText = "Status"
        Me.PkgStatus.MinimumWidth = 6
        Me.PkgStatus.Name = "PkgStatus"
        Me.PkgStatus.ReadOnly = True
        Me.PkgStatus.Width = 77
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
        'LatestVersion
        '
        Me.LatestVersion.HeaderText = "Latest version"
        Me.LatestVersion.MinimumWidth = 6
        Me.LatestVersion.Name = "LatestVersion"
        Me.LatestVersion.ReadOnly = True
        Me.LatestVersion.Visible = False
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
        'ManifestType
        '
        Me.ManifestType.HeaderText = "ManifestType"
        Me.ManifestType.MinimumWidth = 6
        Me.ManifestType.Name = "ManifestType"
        Me.ManifestType.ReadOnly = True
        Me.ManifestType.Visible = False
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
        Me.labelUpdatingPackageList.Size = New System.Drawing.Size(228, 17)
        Me.labelUpdatingPackageList.TabIndex = 1
        Me.labelUpdatingPackageList.Text = "Loading package list, please wait..."
        '
        'textboxPackageDetails
        '
        Me.textboxPackageDetails.ContextMenuStrip = Me.contextmenuPackageDetailsTextbox
        Me.textboxPackageDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxPackageDetails.Location = New System.Drawing.Point(0, 0)
        Me.textboxPackageDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxPackageDetails.Name = "textboxPackageDetails"
        Me.textboxPackageDetails.ReadOnly = True
        Me.textboxPackageDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.textboxPackageDetails.Size = New System.Drawing.Size(830, 212)
        Me.textboxPackageDetails.TabIndex = 0
        Me.textboxPackageDetails.Text = resources.GetString("textboxPackageDetails.Text")
        '
        'contextmenuPackageDetailsTextbox
        '
        Me.contextmenuPackageDetailsTextbox.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenuPackageDetailsTextbox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.ToolStripSeparator2, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator1, Me.RightToLeftMenuItem})
        Me.contextmenuPackageDetailsTextbox.Name = "contextmenuPackageDetailsTextbox"
        Me.contextmenuPackageDetailsTextbox.Size = New System.Drawing.Size(257, 88)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(256, 24)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(253, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(256, 24)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(253, 6)
        '
        'RightToLeftMenuItem
        '
        Me.RightToLeftMenuItem.Name = "RightToLeftMenuItem"
        Me.RightToLeftMenuItem.Size = New System.Drawing.Size(256, 24)
        Me.RightToLeftMenuItem.Text = "Right to left Reading order"
        '
        'panelMainPkgArea
        '
        Me.panelMainPkgArea.Controls.Add(Me.splitcontainerMainWindow)
        Me.panelMainPkgArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainPkgArea.Location = New System.Drawing.Point(0, 0)
        Me.panelMainPkgArea.Margin = New System.Windows.Forms.Padding(2)
        Me.panelMainPkgArea.Name = "panelMainPkgArea"
        Me.panelMainPkgArea.Size = New System.Drawing.Size(830, 641)
        Me.panelMainPkgArea.TabIndex = 2
        '
        'toolstripMainWindow
        '
        Me.toolstripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbuttonRefreshCache, Me.toolstripbuttonApplyChanges, Me.zSeparatorApplyChangesAndProperties, Me.toolstripbuttonProperties, Me.zSeparatorPropertiesAndSearchBox, Me.toolstriptextboxSearch, Me.toolstripsplitbuttonSearch})
        Me.toolstripMainWindow.Location = New System.Drawing.Point(0, 28)
        Me.toolstripMainWindow.Name = "toolstripMainWindow"
        Me.toolstripMainWindow.Size = New System.Drawing.Size(1105, 27)
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
        Me.toolstripbuttonApplyChanges.Size = New System.Drawing.Size(119, 24)
        Me.toolstripbuttonApplyChanges.Text = "Apply changes..."
        Me.toolstripbuttonApplyChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'zSeparatorApplyChangesAndProperties
        '
        Me.zSeparatorApplyChangesAndProperties.Name = "zSeparatorApplyChangesAndProperties"
        Me.zSeparatorApplyChangesAndProperties.Size = New System.Drawing.Size(6, 27)
        '
        'toolstripbuttonProperties
        '
        Me.toolstripbuttonProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonProperties.Image = CType(resources.GetObject("toolstripbuttonProperties.Image"), System.Drawing.Image)
        Me.toolstripbuttonProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonProperties.Name = "toolstripbuttonProperties"
        Me.toolstripbuttonProperties.Size = New System.Drawing.Size(89, 24)
        Me.toolstripbuttonProperties.Text = "Properties..."
        Me.toolstripbuttonProperties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'zSeparatorPropertiesAndSearchBox
        '
        Me.zSeparatorPropertiesAndSearchBox.Name = "zSeparatorPropertiesAndSearchBox"
        Me.zSeparatorPropertiesAndSearchBox.Size = New System.Drawing.Size(6, 27)
        '
        'toolstriptextboxSearch
        '
        Me.toolstriptextboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toolstriptextboxSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.toolstriptextboxSearch.Name = "toolstriptextboxSearch"
        Me.toolstriptextboxSearch.Size = New System.Drawing.Size(250, 27)
        '
        'toolstripsplitbuttonSearch
        '
        Me.toolstripsplitbuttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripsplitbuttonSearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripmenuitemAdvancedSearch})
        Me.toolstripsplitbuttonSearch.Image = CType(resources.GetObject("toolstripsplitbuttonSearch.Image"), System.Drawing.Image)
        Me.toolstripsplitbuttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripsplitbuttonSearch.Name = "toolstripsplitbuttonSearch"
        Me.toolstripsplitbuttonSearch.Size = New System.Drawing.Size(72, 24)
        Me.toolstripsplitbuttonSearch.Text = "Search"
        '
        'toolstripmenuitemAdvancedSearch
        '
        Me.toolstripmenuitemAdvancedSearch.Name = "toolstripmenuitemAdvancedSearch"
        Me.toolstripmenuitemAdvancedSearch.Size = New System.Drawing.Size(199, 26)
        Me.toolstripmenuitemAdvancedSearch.Text = "Search &options..."
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
        Me.splitcontainerSidebarAndPkgList.Size = New System.Drawing.Size(1105, 641)
        Me.splitcontainerSidebarAndPkgList.SplitterDistance = 271
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
        Me.panelSidebarHolder.Size = New System.Drawing.Size(271, 641)
        Me.panelSidebarHolder.TabIndex = 0
        '
        'buttonCloseSidebar
        '
        Me.buttonCloseSidebar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCloseSidebar.AutoSize = True
        Me.buttonCloseSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonCloseSidebar.Location = New System.Drawing.Point(236, 4)
        Me.buttonCloseSidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonCloseSidebar.Name = "buttonCloseSidebar"
        Me.buttonCloseSidebar.Size = New System.Drawing.Size(27, 27)
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
        Me.comboboxSidebarTabSelector.Location = New System.Drawing.Point(10, 4)
        Me.comboboxSidebarTabSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.comboboxSidebarTabSelector.Name = "comboboxSidebarTabSelector"
        Me.comboboxSidebarTabSelector.Size = New System.Drawing.Size(213, 24)
        Me.comboboxSidebarTabSelector.TabIndex = 3
        '
        'tabcontrolSidebar
        '
        Me.tabcontrolSidebar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolSidebar.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSearchTerms)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageAction)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageStatus)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageCustomFilters)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSections)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSource)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageArchitecture)
        Me.tabcontrolSidebar.ItemSize = New System.Drawing.Size(0, 1)
        Me.tabcontrolSidebar.Location = New System.Drawing.Point(5, 32)
        Me.tabcontrolSidebar.Margin = New System.Windows.Forms.Padding(2)
        Me.tabcontrolSidebar.Name = "tabcontrolSidebar"
        Me.tabcontrolSidebar.SelectedIndex = 0
        Me.tabcontrolSidebar.Size = New System.Drawing.Size(262, 606)
        Me.tabcontrolSidebar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabcontrolSidebar.TabIndex = 2
        '
        'tabpageSearchTerms
        '
        Me.tabpageSearchTerms.Controls.Add(Me.listboxSearchTerms)
        Me.tabpageSearchTerms.Location = New System.Drawing.Point(4, 5)
        Me.tabpageSearchTerms.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageSearchTerms.Name = "tabpageSearchTerms"
        Me.tabpageSearchTerms.Size = New System.Drawing.Size(254, 597)
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
        Me.listboxSearchTerms.ItemHeight = 16
        Me.listboxSearchTerms.Items.AddRange(New Object() {"All"})
        Me.listboxSearchTerms.Location = New System.Drawing.Point(0, 0)
        Me.listboxSearchTerms.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxSearchTerms.Name = "listboxSearchTerms"
        Me.listboxSearchTerms.Size = New System.Drawing.Size(254, 597)
        Me.listboxSearchTerms.TabIndex = 2
        '
        'contextmenuSearchTerm
        '
        Me.contextmenuSearchTerm.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenuSearchTerm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearSelectedSearchTermToolStripMenuItem, Me.zSeparatorSearchSidebarContextMenu, Me.ClearAllSearchTermsToolStripMenuItem})
        Me.contextmenuSearchTerm.Name = "contextmenuSearchTerm"
        Me.contextmenuSearchTerm.Size = New System.Drawing.Size(253, 58)
        '
        'ClearSelectedSearchTermToolStripMenuItem
        '
        Me.ClearSelectedSearchTermToolStripMenuItem.Name = "ClearSelectedSearchTermToolStripMenuItem"
        Me.ClearSelectedSearchTermToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.ClearSelectedSearchTermToolStripMenuItem.Text = "Clear selected search term"
        '
        'zSeparatorSearchSidebarContextMenu
        '
        Me.zSeparatorSearchSidebarContextMenu.Name = "zSeparatorSearchSidebarContextMenu"
        Me.zSeparatorSearchSidebarContextMenu.Size = New System.Drawing.Size(249, 6)
        '
        'ClearAllSearchTermsToolStripMenuItem
        '
        Me.ClearAllSearchTermsToolStripMenuItem.Name = "ClearAllSearchTermsToolStripMenuItem"
        Me.ClearAllSearchTermsToolStripMenuItem.Size = New System.Drawing.Size(252, 24)
        Me.ClearAllSearchTermsToolStripMenuItem.Text = "Clear all search terms"
        '
        'tabpageAction
        '
        Me.tabpageAction.Controls.Add(Me.listboxActions)
        Me.tabpageAction.Location = New System.Drawing.Point(4, 5)
        Me.tabpageAction.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageAction.Name = "tabpageAction"
        Me.tabpageAction.Size = New System.Drawing.Size(254, 591)
        Me.tabpageAction.TabIndex = 6
        Me.tabpageAction.Text = "Action"
        Me.tabpageAction.UseVisualStyleBackColor = True
        '
        'listboxActions
        '
        Me.listboxActions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxActions.FormattingEnabled = True
        Me.listboxActions.IntegralHeight = False
        Me.listboxActions.ItemHeight = 16
        Me.listboxActions.Items.AddRange(New Object() {"All", "Do nothing", "Install", "Uninstall", "Upgrade"})
        Me.listboxActions.Location = New System.Drawing.Point(0, 0)
        Me.listboxActions.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxActions.Name = "listboxActions"
        Me.listboxActions.Size = New System.Drawing.Size(254, 591)
        Me.listboxActions.TabIndex = 2
        '
        'tabpageStatus
        '
        Me.tabpageStatus.Controls.Add(Me.listboxStatusTab)
        Me.tabpageStatus.Location = New System.Drawing.Point(4, 5)
        Me.tabpageStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageStatus.Name = "tabpageStatus"
        Me.tabpageStatus.Size = New System.Drawing.Size(254, 591)
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
        Me.listboxStatusTab.Items.AddRange(New Object() {"All", "Installed", "Not installed", "Unknown"})
        Me.listboxStatusTab.Location = New System.Drawing.Point(0, 0)
        Me.listboxStatusTab.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxStatusTab.Name = "listboxStatusTab"
        Me.listboxStatusTab.Size = New System.Drawing.Size(254, 591)
        Me.listboxStatusTab.TabIndex = 0
        '
        'tabpageCustomFilters
        '
        Me.tabpageCustomFilters.Controls.Add(Me.listboxCustomFilters)
        Me.tabpageCustomFilters.Location = New System.Drawing.Point(4, 5)
        Me.tabpageCustomFilters.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageCustomFilters.Name = "tabpageCustomFilters"
        Me.tabpageCustomFilters.Size = New System.Drawing.Size(254, 591)
        Me.tabpageCustomFilters.TabIndex = 3
        Me.tabpageCustomFilters.Text = "Custom filters"
        Me.tabpageCustomFilters.UseVisualStyleBackColor = True
        '
        'listboxCustomFilters
        '
        Me.listboxCustomFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxCustomFilters.FormattingEnabled = True
        Me.listboxCustomFilters.IntegralHeight = False
        Me.listboxCustomFilters.ItemHeight = 16
        Me.listboxCustomFilters.Items.AddRange(New Object() {"All"})
        Me.listboxCustomFilters.Location = New System.Drawing.Point(0, 0)
        Me.listboxCustomFilters.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxCustomFilters.Name = "listboxCustomFilters"
        Me.listboxCustomFilters.Size = New System.Drawing.Size(254, 591)
        Me.listboxCustomFilters.TabIndex = 1
        '
        'tabpageSections
        '
        Me.tabpageSections.Controls.Add(Me.listboxSections)
        Me.tabpageSections.Location = New System.Drawing.Point(4, 5)
        Me.tabpageSections.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageSections.Name = "tabpageSections"
        Me.tabpageSections.Size = New System.Drawing.Size(254, 591)
        Me.tabpageSections.TabIndex = 0
        Me.tabpageSections.Text = "Categories"
        Me.tabpageSections.UseVisualStyleBackColor = True
        '
        'listboxSections
        '
        Me.listboxSections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSections.FormattingEnabled = True
        Me.listboxSections.IntegralHeight = False
        Me.listboxSections.ItemHeight = 16
        Me.listboxSections.Items.AddRange(New Object() {"All"})
        Me.listboxSections.Location = New System.Drawing.Point(0, 0)
        Me.listboxSections.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxSections.Name = "listboxSections"
        Me.listboxSections.Size = New System.Drawing.Size(254, 591)
        Me.listboxSections.TabIndex = 1
        '
        'tabpageSource
        '
        Me.tabpageSource.Controls.Add(Me.listboxSourceTab)
        Me.tabpageSource.Location = New System.Drawing.Point(4, 5)
        Me.tabpageSource.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageSource.Name = "tabpageSource"
        Me.tabpageSource.Size = New System.Drawing.Size(254, 591)
        Me.tabpageSource.TabIndex = 2
        Me.tabpageSource.Text = "Source"
        Me.tabpageSource.UseVisualStyleBackColor = True
        '
        'listboxSourceTab
        '
        Me.listboxSourceTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSourceTab.FormattingEnabled = True
        Me.listboxSourceTab.IntegralHeight = False
        Me.listboxSourceTab.ItemHeight = 16
        Me.listboxSourceTab.Items.AddRange(New Object() {"All"})
        Me.listboxSourceTab.Location = New System.Drawing.Point(0, 0)
        Me.listboxSourceTab.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxSourceTab.Name = "listboxSourceTab"
        Me.listboxSourceTab.Size = New System.Drawing.Size(254, 591)
        Me.listboxSourceTab.TabIndex = 1
        '
        'tabpageArchitecture
        '
        Me.tabpageArchitecture.Controls.Add(Me.listboxArchitecture)
        Me.tabpageArchitecture.Location = New System.Drawing.Point(4, 5)
        Me.tabpageArchitecture.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageArchitecture.Name = "tabpageArchitecture"
        Me.tabpageArchitecture.Size = New System.Drawing.Size(254, 591)
        Me.tabpageArchitecture.TabIndex = 5
        Me.tabpageArchitecture.Text = "Architecture"
        Me.tabpageArchitecture.UseVisualStyleBackColor = True
        '
        'listboxArchitecture
        '
        Me.listboxArchitecture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxArchitecture.FormattingEnabled = True
        Me.listboxArchitecture.IntegralHeight = False
        Me.listboxArchitecture.ItemHeight = 16
        Me.listboxArchitecture.Items.AddRange(New Object() {"All"})
        Me.listboxArchitecture.Location = New System.Drawing.Point(0, 0)
        Me.listboxArchitecture.Margin = New System.Windows.Forms.Padding(2)
        Me.listboxArchitecture.Name = "listboxArchitecture"
        Me.listboxArchitecture.Size = New System.Drawing.Size(254, 591)
        Me.listboxArchitecture.TabIndex = 1
        '
        'panelMainForm
        '
        Me.panelMainForm.Controls.Add(Me.splitcontainerSidebarAndPkgList)
        Me.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainForm.Location = New System.Drawing.Point(0, 55)
        Me.panelMainForm.Margin = New System.Windows.Forms.Padding(2)
        Me.panelMainForm.Name = "panelMainForm"
        Me.panelMainForm.Size = New System.Drawing.Size(1105, 641)
        Me.panelMainForm.TabIndex = 4
        '
        'statusbarMainWindow
        '
        Me.statusbarMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusbarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripstatuslabelPackageCount, Me.toolstripstatusSplitter, Me.toolstripprogressbarLoadingPackages, Me.toolstripstatuslabelLoadingPackageCount})
        Me.statusbarMainWindow.Location = New System.Drawing.Point(0, 696)
        Me.statusbarMainWindow.Name = "statusbarMainWindow"
        Me.statusbarMainWindow.Size = New System.Drawing.Size(1105, 26)
        Me.statusbarMainWindow.TabIndex = 5
        Me.statusbarMainWindow.Text = "StatusStrip1"
        '
        'toolstripstatuslabelPackageCount
        '
        Me.toolstripstatuslabelPackageCount.Name = "toolstripstatuslabelPackageCount"
        Me.toolstripstatuslabelPackageCount.Size = New System.Drawing.Size(137, 20)
        Me.toolstripstatuslabelPackageCount.Text = "0 packages loaded."
        '
        'toolstripstatusSplitter
        '
        Me.toolstripstatusSplitter.Name = "toolstripstatusSplitter"
        Me.toolstripstatusSplitter.Size = New System.Drawing.Size(13, 20)
        Me.toolstripstatusSplitter.Text = "|"
        Me.toolstripstatusSplitter.Visible = False
        '
        'toolstripprogressbarLoadingPackages
        '
        Me.toolstripprogressbarLoadingPackages.Name = "toolstripprogressbarLoadingPackages"
        Me.toolstripprogressbarLoadingPackages.Size = New System.Drawing.Size(150, 18)
        Me.toolstripprogressbarLoadingPackages.Visible = False
        '
        'toolstripstatuslabelLoadingPackageCount
        '
        Me.toolstripstatuslabelLoadingPackageCount.Name = "toolstripstatuslabelLoadingPackageCount"
        Me.toolstripstatuslabelLoadingPackageCount.Size = New System.Drawing.Size(138, 20)
        Me.toolstripstatuslabelLoadingPackageCount.Text = "Loading packages..."
        Me.toolstripstatuslabelLoadingPackageCount.Visible = False
        '
        'SelectedPackageToolStripMenuItem
        '
        Me.SelectedPackageToolStripMenuItem.Name = "SelectedPackageToolStripMenuItem"
        Me.SelectedPackageToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SelectedPackageToolStripMenuItem.Text = "Selected package"
        '
        'zCantFindThisPackagePropertiesMenuItem
        '
        Me.zCantFindThisPackagePropertiesMenuItem.Name = "zCantFindThisPackagePropertiesMenuItem"
        Me.zCantFindThisPackagePropertiesMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.zCantFindThisPackagePropertiesMenuItem.Text = "Pa&ckage properties..."
        '
        'zSeparatorNoIdeaWhereThisIs
        '
        Me.zSeparatorNoIdeaWhereThisIs.Name = "zSeparatorNoIdeaWhereThisIs"
        Me.zSeparatorNoIdeaWhereThisIs.Size = New System.Drawing.Size(210, 6)
        '
        'TypeTimer
        '
        Me.TypeTimer.Interval = 325
        '
        'SaveFileDialogExportPackages
        '
        Me.SaveFileDialogExportPackages.DefaultExt = "json"
        Me.SaveFileDialogExportPackages.Filter = "JSON files|*.json|All files|*.*"
        Me.SaveFileDialogExportPackages.RestoreDirectory = True
        Me.SaveFileDialogExportPackages.Title = "Export Packages"
        '
        'OpenFileDialogImportPackages
        '
        Me.OpenFileDialogImportPackages.Filter = "JSON files|*.json|All files|*.*"
        Me.OpenFileDialogImportPackages.RestoreDirectory = True
        Me.OpenFileDialogImportPackages.Title = "Import Packages"
        '
        'pictureboxFastResizePackageList
        '
        Me.pictureboxFastResizePackageList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureboxFastResizePackageList.Location = New System.Drawing.Point(0, 0)
        Me.pictureboxFastResizePackageList.Name = "pictureboxFastResizePackageList"
        Me.pictureboxFastResizePackageList.Size = New System.Drawing.Size(830, 425)
        Me.pictureboxFastResizePackageList.TabIndex = 2
        Me.pictureboxFastResizePackageList.TabStop = False
        Me.pictureboxFastResizePackageList.Visible = False
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1105, 722)
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
        CType(Me.splitcontainerMainWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitcontainerMainWindow.ResumeLayout(False)
        Me.panelPackageListHolder.ResumeLayout(False)
        Me.panelPackageListHolder.PerformLayout()
        CType(Me.datagridviewPackageList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextmenuPackageDetailsTextbox.ResumeLayout(False)
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
        Me.tabpageAction.ResumeLayout(False)
        Me.tabpageStatus.ResumeLayout(False)
        Me.tabpageCustomFilters.ResumeLayout(False)
        Me.tabpageSections.ResumeLayout(False)
        Me.tabpageSource.ResumeLayout(False)
        Me.tabpageArchitecture.ResumeLayout(False)
        Me.panelMainForm.ResumeLayout(False)
        Me.statusbarMainWindow.ResumeLayout(False)
        Me.statusbarMainWindow.PerformLayout()
        CType(Me.pictureboxFastResizePackageList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents panelMainPkgArea As Panel
    Friend WithEvents toolstripMainWindow As ToolStrip
    Friend WithEvents toolstriptextboxSearch As ToolStripTextBox
    Friend WithEvents datagridviewPackageList As DataGridView
    Friend WithEvents contextmenustripPackageMenu As ContextMenuStrip
    Friend WithEvents toolstripbuttonRefreshCache As ToolStripButton
    Friend WithEvents zSeparatorApplyChangesAndProperties As ToolStripSeparator
    Friend WithEvents toolstripbuttonProperties As ToolStripButton
    Friend WithEvents zSeparatorPropertiesAndSearchBox As ToolStripSeparator
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
    Friend WithEvents tabpageArchitecture As TabPage
    Friend WithEvents listboxSections As ListBox
    Friend WithEvents listboxSourceTab As ListBox
    Friend WithEvents listboxCustomFilters As ListBox
    Friend WithEvents listboxArchitecture As ListBox
    Friend WithEvents contextmenuSearchTerm As ContextMenuStrip
    Friend WithEvents ClearSelectedSearchTermToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllSearchTermsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents zSeparatorSearchSidebarContextMenu As ToolStripSeparator
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
    Friend WithEvents zSeparatorPackageListMenu As ToolStripSeparator
    Friend WithEvents AdvancedSearchMenuItem As ToolStripMenuItem
    Friend WithEvents SearchMenuItem As ToolStripMenuItem
    Friend WithEvents comboboxSidebarTabSelector As ComboBox
    Friend WithEvents buttonCloseSidebar As Button
    Friend WithEvents FindManifestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SidebarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedPackagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedPackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents zCantFindThisPackagePropertiesMenuItem As ToolStripMenuItem
    Friend WithEvents zSeparatorNoIdeaWhereThisIs As ToolStripSeparator
    Friend WithEvents PropertiesPackageContextMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents zSeparatorPackageContextMenu As ToolStripSeparator
    Friend WithEvents SearchForPackageIDFromContextMenu As ToolStripMenuItem
    Friend WithEvents zSeparatorSelectedPackagesMenu As ToolStripSeparator
    Friend WithEvents SelectedPackagesSearchForLastSelectedID As ToolStripMenuItem
    Friend WithEvents SelectedPackagesProperties As ToolStripMenuItem
    Friend WithEvents SelectedPackagesActionDoNothingMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedPackagesActionInstallMenuItem As ToolStripMenuItem
    Friend WithEvents zSeparatorAfterActionsInSelectedPackagesMenu As ToolStripSeparator
    Friend WithEvents zSeparatorAfterActionButtonsInPackageContextMenu As ToolStripSeparator
    Friend WithEvents DoNothingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateWingetSourcesMenuButton As ToolStripMenuItem
    Friend WithEvents zSeparatorAfterRefreshPart As ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowInWingetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowInwingetToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents zSeparatorAboveEditWingetSettings As ToolStripSeparator
    Friend WithEvents EditWingetSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditWingetSettingsAsAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TypeTimer As Timer
    Friend WithEvents HowToUseGuingetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpMenuToolStripSeparator As ToolStripSeparator
    Friend WithEvents RunCMDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunCMDElevatedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents zFileMenuSeparator As ToolStripSeparator
    Friend WithEvents ListInstalledPackagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowUpgradesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents zToolStripSeparatorViewMenu As ToolStripSeparator
    Friend WithEvents tabpageAction As TabPage
    Friend WithEvents listboxActions As ListBox
    Friend WithEvents listboxStatusTab As ListBox
    Friend WithEvents SelectedPackagesActionUninstallMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedPackagesActionUpgradeMenuItem As ToolStripMenuItem
    Friend WithEvents UninstallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpgradeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialogExportPackages As SaveFileDialog
    Friend WithEvents OpenFileDialogImportPackages As OpenFileDialog
    Friend WithEvents ToolStripMenuItemExportPackages As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemImportPackages As ToolStripMenuItem
    Friend WithEvents zFileMenuSeparator2 As ToolStripSeparator
    Friend WithEvents PkgAction As DataGridViewComboBoxColumn
    Friend WithEvents PkgStatus As DataGridViewTextBoxColumn
    Friend WithEvents PkgName As DataGridViewTextBoxColumn
    Friend WithEvents FriendlyName As DataGridViewTextBoxColumn
    Friend WithEvents AvailableVersion As DataGridViewTextBoxColumn
    Friend WithEvents LatestVersion As DataGridViewTextBoxColumn
    Friend WithEvents PkgDescription As DataGridViewTextBoxColumn
    Friend WithEvents Manifest As DataGridViewTextBoxColumn
    Friend WithEvents ManifestType As DataGridViewTextBoxColumn
    Friend WithEvents textboxPackageDetails As RichTextBox
    Friend WithEvents contextmenuPackageDetailsTextbox As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents RightToLeftMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents pictureboxFastResizePackageList As PictureBox
End Class
