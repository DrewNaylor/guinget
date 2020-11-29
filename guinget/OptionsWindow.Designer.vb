<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionsWindow
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
        Me.tablelayoutpanelOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonDefaults = New System.Windows.Forms.Button()
        Me.tabcontrolOptions = New System.Windows.Forms.TabControl()
        Me.tabpagePackageDetails = New System.Windows.Forms.TabPage()
        Me.checkboxLastSelectedPackageDetails = New System.Windows.Forms.CheckBox()
        Me.tabpageSearch = New System.Windows.Forms.TabPage()
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch = New System.Windows.Forms.CheckBox()
        Me.checkboxRerunSearch = New System.Windows.Forms.CheckBox()
        Me.tabpageApplyChanges = New System.Windows.Forms.TabPage()
        Me.labelWhyElevate = New System.Windows.Forms.Label()
        Me.checkboxElevateWinget = New System.Windows.Forms.CheckBox()
        Me.checkboxInstallInteractively = New System.Windows.Forms.CheckBox()
        Me.tabpageLayout = New System.Windows.Forms.TabPage()
        Me.checkboxShowSidebar = New System.Windows.Forms.CheckBox()
        Me.tabpageRefreshCache = New System.Windows.Forms.TabPage()
        Me.panelExperimentalSettings = New System.Windows.Forms.Panel()
        Me.labelRequiresApplicationRestart = New System.Windows.Forms.Label()
        Me.labelCopyrightForRobocopy = New System.Windows.Forms.Label()
        Me.labelCopyrightForSevenZip = New System.Windows.Forms.Label()
        Me.checkboxHideUnfinishedControls = New System.Windows.Forms.CheckBox()
        Me.checkboxUseRobocopy = New System.Windows.Forms.CheckBox()
        Me.buttonBrowse7zExePath = New System.Windows.Forms.Button()
        Me.textbox7zExePath = New System.Windows.Forms.TextBox()
        Me.label7zExePath = New System.Windows.Forms.Label()
        Me.checkboxUse7zip = New System.Windows.Forms.CheckBox()
        Me.checkboxLoadFromDatabase = New System.Windows.Forms.CheckBox()
        Me.labelLoadLatestVersion = New System.Windows.Forms.Label()
        Me.labelLoadFromManifests = New System.Windows.Forms.Label()
        Me.checkboxShowOnlyLatestVersions = New System.Windows.Forms.CheckBox()
        Me.labelExperimentalSettingsHidden = New System.Windows.Forms.Label()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonOk = New System.Windows.Forms.Button()
        Me.SevenZExeOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tablelayoutpanelOptions.SuspendLayout()
        Me.tabcontrolOptions.SuspendLayout()
        Me.tabpagePackageDetails.SuspendLayout()
        Me.tabpageSearch.SuspendLayout()
        Me.tabpageApplyChanges.SuspendLayout()
        Me.tabpageLayout.SuspendLayout()
        Me.tabpageRefreshCache.SuspendLayout()
        Me.panelExperimentalSettings.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablelayoutpanelOptions
        '
        Me.tablelayoutpanelOptions.ColumnCount = 4
        Me.tablelayoutpanelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tablelayoutpanelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tablelayoutpanelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.tablelayoutpanelOptions.Controls.Add(Me.buttonDefaults, 0, 1)
        Me.tablelayoutpanelOptions.Controls.Add(Me.tabcontrolOptions, 0, 0)
        Me.tablelayoutpanelOptions.Controls.Add(Me.buttonCancel, 2, 1)
        Me.tablelayoutpanelOptions.Controls.Add(Me.buttonOk, 3, 1)
        Me.tablelayoutpanelOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelOptions.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.tablelayoutpanelOptions.Name = "tablelayoutpanelOptions"
        Me.tablelayoutpanelOptions.RowCount = 2
        Me.tablelayoutpanelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.94991!))
        Me.tablelayoutpanelOptions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.050093!))
        Me.tablelayoutpanelOptions.Size = New System.Drawing.Size(372, 431)
        Me.tablelayoutpanelOptions.TabIndex = 0
        '
        'buttonDefaults
        '
        Me.buttonDefaults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonDefaults.Location = New System.Drawing.Point(2, 402)
        Me.buttonDefaults.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonDefaults.Name = "buttonDefaults"
        Me.buttonDefaults.Size = New System.Drawing.Size(81, 27)
        Me.buttonDefaults.TabIndex = 6
        Me.buttonDefaults.Text = "Defaults"
        Me.buttonDefaults.UseVisualStyleBackColor = True
        '
        'tabcontrolOptions
        '
        Me.tablelayoutpanelOptions.SetColumnSpan(Me.tabcontrolOptions, 4)
        Me.tabcontrolOptions.Controls.Add(Me.tabpagePackageDetails)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageSearch)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageApplyChanges)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageLayout)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageRefreshCache)
        Me.tabcontrolOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolOptions.Location = New System.Drawing.Point(2, 2)
        Me.tabcontrolOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.tabcontrolOptions.Name = "tabcontrolOptions"
        Me.tabcontrolOptions.SelectedIndex = 0
        Me.tabcontrolOptions.Size = New System.Drawing.Size(368, 396)
        Me.tabcontrolOptions.TabIndex = 0
        '
        'tabpagePackageDetails
        '
        Me.tabpagePackageDetails.Controls.Add(Me.checkboxLastSelectedPackageDetails)
        Me.tabpagePackageDetails.Location = New System.Drawing.Point(4, 22)
        Me.tabpagePackageDetails.Name = "tabpagePackageDetails"
        Me.tabpagePackageDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpagePackageDetails.Size = New System.Drawing.Size(360, 370)
        Me.tabpagePackageDetails.TabIndex = 2
        Me.tabpagePackageDetails.Text = "Package Details"
        Me.tabpagePackageDetails.UseVisualStyleBackColor = True
        '
        'checkboxLastSelectedPackageDetails
        '
        Me.checkboxLastSelectedPackageDetails.AutoSize = True
        Me.checkboxLastSelectedPackageDetails.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxLastSelectedPackageDetails.Location = New System.Drawing.Point(6, 6)
        Me.checkboxLastSelectedPackageDetails.Name = "checkboxLastSelectedPackageDetails"
        Me.checkboxLastSelectedPackageDetails.Size = New System.Drawing.Size(267, 30)
        Me.checkboxLastSelectedPackageDetails.TabIndex = 0
        Me.checkboxLastSelectedPackageDetails.Text = "Show last-selected package details when selecting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "multiple packages"
        Me.checkboxLastSelectedPackageDetails.UseVisualStyleBackColor = True
        '
        'tabpageSearch
        '
        Me.tabpageSearch.Controls.Add(Me.checkboxUseExactMatchForLastSelectedPackageIDSearch)
        Me.tabpageSearch.Controls.Add(Me.checkboxRerunSearch)
        Me.tabpageSearch.Location = New System.Drawing.Point(4, 22)
        Me.tabpageSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageSearch.Name = "tabpageSearch"
        Me.tabpageSearch.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageSearch.Size = New System.Drawing.Size(360, 370)
        Me.tabpageSearch.TabIndex = 0
        Me.tabpageSearch.Text = "Search"
        Me.tabpageSearch.UseVisualStyleBackColor = True
        '
        'checkboxUseExactMatchForLastSelectedPackageIDSearch
        '
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.AutoSize = True
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.Location = New System.Drawing.Point(6, 28)
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.Name = "checkboxUseExactMatchForLastSelectedPackageIDSearch"
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.Size = New System.Drawing.Size(258, 17)
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.TabIndex = 3
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.Text = "Use exact match for selected package ID search"
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.UseVisualStyleBackColor = True
        '
        'checkboxRerunSearch
        '
        Me.checkboxRerunSearch.AutoSize = True
        Me.checkboxRerunSearch.Location = New System.Drawing.Point(6, 6)
        Me.checkboxRerunSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxRerunSearch.Name = "checkboxRerunSearch"
        Me.checkboxRerunSearch.Size = New System.Drawing.Size(186, 17)
        Me.checkboxRerunSearch.TabIndex = 0
        Me.checkboxRerunSearch.Text = "Re-run search after cache update"
        Me.checkboxRerunSearch.UseVisualStyleBackColor = True
        '
        'tabpageApplyChanges
        '
        Me.tabpageApplyChanges.Controls.Add(Me.labelWhyElevate)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxElevateWinget)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxInstallInteractively)
        Me.tabpageApplyChanges.Location = New System.Drawing.Point(4, 22)
        Me.tabpageApplyChanges.Name = "tabpageApplyChanges"
        Me.tabpageApplyChanges.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageApplyChanges.Size = New System.Drawing.Size(360, 370)
        Me.tabpageApplyChanges.TabIndex = 1
        Me.tabpageApplyChanges.Text = "Apply Changes"
        Me.tabpageApplyChanges.UseVisualStyleBackColor = True
        '
        'labelWhyElevate
        '
        Me.labelWhyElevate.AutoSize = True
        Me.labelWhyElevate.Location = New System.Drawing.Point(23, 46)
        Me.labelWhyElevate.Name = "labelWhyElevate"
        Me.labelWhyElevate.Size = New System.Drawing.Size(283, 52)
        Me.labelWhyElevate.TabIndex = 2
        Me.labelWhyElevate.Text = "Some packages require winget to be run elevated for them" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to install properly if " &
    "your account is a limited one." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This may not work on Windows 10 version 2004 as " &
    "it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "might say it couldn't run winget."
        '
        'checkboxElevateWinget
        '
        Me.checkboxElevateWinget.AutoSize = True
        Me.checkboxElevateWinget.Location = New System.Drawing.Point(6, 29)
        Me.checkboxElevateWinget.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxElevateWinget.Name = "checkboxElevateWinget"
        Me.checkboxElevateWinget.Size = New System.Drawing.Size(143, 17)
        Me.checkboxElevateWinget.TabIndex = 1
        Me.checkboxElevateWinget.Text = "Elevate winget with UAC"
        Me.checkboxElevateWinget.UseVisualStyleBackColor = True
        '
        'checkboxInstallInteractively
        '
        Me.checkboxInstallInteractively.AutoSize = True
        Me.checkboxInstallInteractively.Location = New System.Drawing.Point(6, 6)
        Me.checkboxInstallInteractively.Name = "checkboxInstallInteractively"
        Me.checkboxInstallInteractively.Size = New System.Drawing.Size(197, 17)
        Me.checkboxInstallInteractively.TabIndex = 0
        Me.checkboxInstallInteractively.Text = "Use interactive installation (winget -i)"
        Me.checkboxInstallInteractively.UseVisualStyleBackColor = True
        '
        'tabpageLayout
        '
        Me.tabpageLayout.Controls.Add(Me.checkboxShowSidebar)
        Me.tabpageLayout.Location = New System.Drawing.Point(4, 22)
        Me.tabpageLayout.Name = "tabpageLayout"
        Me.tabpageLayout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageLayout.Size = New System.Drawing.Size(360, 370)
        Me.tabpageLayout.TabIndex = 3
        Me.tabpageLayout.Text = "Layout"
        Me.tabpageLayout.UseVisualStyleBackColor = True
        '
        'checkboxShowSidebar
        '
        Me.checkboxShowSidebar.AutoSize = True
        Me.checkboxShowSidebar.Location = New System.Drawing.Point(5, 5)
        Me.checkboxShowSidebar.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxShowSidebar.Name = "checkboxShowSidebar"
        Me.checkboxShowSidebar.Size = New System.Drawing.Size(90, 17)
        Me.checkboxShowSidebar.TabIndex = 2
        Me.checkboxShowSidebar.Text = "Show sidebar"
        Me.checkboxShowSidebar.UseVisualStyleBackColor = True
        '
        'tabpageRefreshCache
        '
        Me.tabpageRefreshCache.Controls.Add(Me.panelExperimentalSettings)
        Me.tabpageRefreshCache.Controls.Add(Me.labelExperimentalSettingsHidden)
        Me.tabpageRefreshCache.Location = New System.Drawing.Point(4, 22)
        Me.tabpageRefreshCache.Name = "tabpageRefreshCache"
        Me.tabpageRefreshCache.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageRefreshCache.Size = New System.Drawing.Size(360, 370)
        Me.tabpageRefreshCache.TabIndex = 4
        Me.tabpageRefreshCache.Text = "Experimental"
        Me.tabpageRefreshCache.UseVisualStyleBackColor = True
        '
        'panelExperimentalSettings
        '
        Me.panelExperimentalSettings.AutoScroll = True
        Me.panelExperimentalSettings.Controls.Add(Me.Label1)
        Me.panelExperimentalSettings.Controls.Add(Me.NumericUpDown1)
        Me.panelExperimentalSettings.Controls.Add(Me.CheckBox1)
        Me.panelExperimentalSettings.Controls.Add(Me.labelRequiresApplicationRestart)
        Me.panelExperimentalSettings.Controls.Add(Me.labelCopyrightForRobocopy)
        Me.panelExperimentalSettings.Controls.Add(Me.labelCopyrightForSevenZip)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxHideUnfinishedControls)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxUseRobocopy)
        Me.panelExperimentalSettings.Controls.Add(Me.buttonBrowse7zExePath)
        Me.panelExperimentalSettings.Controls.Add(Me.textbox7zExePath)
        Me.panelExperimentalSettings.Controls.Add(Me.label7zExePath)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxUse7zip)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxLoadFromDatabase)
        Me.panelExperimentalSettings.Controls.Add(Me.labelLoadLatestVersion)
        Me.panelExperimentalSettings.Controls.Add(Me.labelLoadFromManifests)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxShowOnlyLatestVersions)
        Me.panelExperimentalSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelExperimentalSettings.Location = New System.Drawing.Point(3, 3)
        Me.panelExperimentalSettings.Name = "panelExperimentalSettings"
        Me.panelExperimentalSettings.Size = New System.Drawing.Size(354, 364)
        Me.panelExperimentalSettings.TabIndex = 4
        '
        'labelRequiresApplicationRestart
        '
        Me.labelRequiresApplicationRestart.AutoSize = True
        Me.labelRequiresApplicationRestart.Location = New System.Drawing.Point(18, 20)
        Me.labelRequiresApplicationRestart.Name = "labelRequiresApplicationRestart"
        Me.labelRequiresApplicationRestart.Size = New System.Drawing.Size(275, 26)
        Me.labelRequiresApplicationRestart.TabIndex = 12
        Me.labelRequiresApplicationRestart.Text = "Requires application restart. The rest of these options still" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "apply even if this" &
    " is on."
        '
        'labelCopyrightForRobocopy
        '
        Me.labelCopyrightForRobocopy.AutoSize = True
        Me.labelCopyrightForRobocopy.Location = New System.Drawing.Point(18, 293)
        Me.labelCopyrightForRobocopy.Name = "labelCopyrightForRobocopy"
        Me.labelCopyrightForRobocopy.Size = New System.Drawing.Size(238, 52)
        Me.labelCopyrightForRobocopy.TabIndex = 11
        Me.labelCopyrightForRobocopy.Text = "Robocopy is Copyright (C) Microsoft Corporation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Robocopy " &
    "may copy faster than the .NET copier," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "but it's not fully tested for this purpos" &
    "e."
        '
        'labelCopyrightForSevenZip
        '
        Me.labelCopyrightForSevenZip.AutoSize = True
        Me.labelCopyrightForSevenZip.Location = New System.Drawing.Point(18, 210)
        Me.labelCopyrightForSevenZip.Name = "labelCopyrightForSevenZip"
        Me.labelCopyrightForSevenZip.Size = New System.Drawing.Size(234, 39)
        Me.labelCopyrightForSevenZip.TabIndex = 10
        Me.labelCopyrightForSevenZip.Text = "7-Zip is Copyright (C) Igor Pavlov." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7-Zip may extract faster than the .NET extra" &
    "ctor," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "but it's not fully tested for this purpose." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'checkboxHideUnfinishedControls
        '
        Me.checkboxHideUnfinishedControls.AutoSize = True
        Me.checkboxHideUnfinishedControls.Location = New System.Drawing.Point(3, 3)
        Me.checkboxHideUnfinishedControls.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxHideUnfinishedControls.Name = "checkboxHideUnfinishedControls"
        Me.checkboxHideUnfinishedControls.Size = New System.Drawing.Size(245, 17)
        Me.checkboxHideUnfinishedControls.TabIndex = 0
        Me.checkboxHideUnfinishedControls.Text = "Hide unfinished controls and experimental stuff"
        Me.checkboxHideUnfinishedControls.UseVisualStyleBackColor = True
        '
        'checkboxUseRobocopy
        '
        Me.checkboxUseRobocopy.AutoSize = True
        Me.checkboxUseRobocopy.Location = New System.Drawing.Point(3, 276)
        Me.checkboxUseRobocopy.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxUseRobocopy.Name = "checkboxUseRobocopy"
        Me.checkboxUseRobocopy.Size = New System.Drawing.Size(319, 17)
        Me.checkboxUseRobocopy.TabIndex = 6
        Me.checkboxUseRobocopy.Text = "(Experimental) Use Robocopy to copy manifests and database"
        Me.checkboxUseRobocopy.UseVisualStyleBackColor = True
        '
        'buttonBrowse7zExePath
        '
        Me.buttonBrowse7zExePath.Location = New System.Drawing.Point(242, 249)
        Me.buttonBrowse7zExePath.Name = "buttonBrowse7zExePath"
        Me.buttonBrowse7zExePath.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowse7zExePath.TabIndex = 5
        Me.buttonBrowse7zExePath.Text = "Browse..."
        Me.buttonBrowse7zExePath.UseVisualStyleBackColor = True
        '
        'textbox7zExePath
        '
        Me.textbox7zExePath.Location = New System.Drawing.Point(88, 250)
        Me.textbox7zExePath.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.textbox7zExePath.Name = "textbox7zExePath"
        Me.textbox7zExePath.Size = New System.Drawing.Size(148, 20)
        Me.textbox7zExePath.TabIndex = 4
        '
        'label7zExePath
        '
        Me.label7zExePath.AutoSize = True
        Me.label7zExePath.Location = New System.Drawing.Point(17, 254)
        Me.label7zExePath.Name = "label7zExePath"
        Me.label7zExePath.Size = New System.Drawing.Size(65, 13)
        Me.label7zExePath.TabIndex = 5
        Me.label7zExePath.Text = "7z.exe path:"
        '
        'checkboxUse7zip
        '
        Me.checkboxUse7zip.AutoSize = True
        Me.checkboxUse7zip.Location = New System.Drawing.Point(3, 193)
        Me.checkboxUse7zip.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxUse7zip.Name = "checkboxUse7zip"
        Me.checkboxUse7zip.Size = New System.Drawing.Size(303, 17)
        Me.checkboxUse7zip.TabIndex = 3
        Me.checkboxUse7zip.Text = "(Experimental) Use 7-Zip to extract manifests and database"
        Me.checkboxUse7zip.UseVisualStyleBackColor = True
        '
        'checkboxLoadFromDatabase
        '
        Me.checkboxLoadFromDatabase.AutoSize = True
        Me.checkboxLoadFromDatabase.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxLoadFromDatabase.Location = New System.Drawing.Point(3, 49)
        Me.checkboxLoadFromDatabase.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxLoadFromDatabase.Name = "checkboxLoadFromDatabase"
        Me.checkboxLoadFromDatabase.Size = New System.Drawing.Size(298, 30)
        Me.checkboxLoadFromDatabase.TabIndex = 1
        Me.checkboxLoadFromDatabase.Text = "(Experimental) Update and load package list from winget's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "default community data" &
    "base"
        Me.checkboxLoadFromDatabase.UseVisualStyleBackColor = True
        '
        'labelLoadLatestVersion
        '
        Me.labelLoadLatestVersion.AutoSize = True
        Me.labelLoadLatestVersion.Location = New System.Drawing.Point(18, 138)
        Me.labelLoadLatestVersion.Name = "labelLoadLatestVersion"
        Me.labelLoadLatestVersion.Size = New System.Drawing.Size(298, 52)
        Me.labelLoadLatestVersion.TabIndex = 3
        Me.labelLoadLatestVersion.Text = "Some packages may display a version number that's not really" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the latest version." &
    " Not sure how to fix this at the moment." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Requires loading from the community da" &
    "tabase checkbox to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be checked."
        '
        'labelLoadFromManifests
        '
        Me.labelLoadFromManifests.AutoSize = True
        Me.labelLoadFromManifests.Location = New System.Drawing.Point(18, 79)
        Me.labelLoadFromManifests.Name = "labelLoadFromManifests"
        Me.labelLoadFromManifests.Size = New System.Drawing.Size(270, 39)
        Me.labelLoadFromManifests.TabIndex = 1
        Me.labelLoadFromManifests.Text = "This will ensure guinget only displays packages winget's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "default source knows ab" &
    "out and may be faster" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in some cases. Details will still be loaded from manifest" &
    "s."
        '
        'checkboxShowOnlyLatestVersions
        '
        Me.checkboxShowOnlyLatestVersions.AutoSize = True
        Me.checkboxShowOnlyLatestVersions.Location = New System.Drawing.Point(3, 121)
        Me.checkboxShowOnlyLatestVersions.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxShowOnlyLatestVersions.Name = "checkboxShowOnlyLatestVersions"
        Me.checkboxShowOnlyLatestVersions.Size = New System.Drawing.Size(308, 17)
        Me.checkboxShowOnlyLatestVersions.TabIndex = 2
        Me.checkboxShowOnlyLatestVersions.Text = "(Experimental) Load only the latest version of each package"
        Me.checkboxShowOnlyLatestVersions.UseVisualStyleBackColor = True
        '
        'labelExperimentalSettingsHidden
        '
        Me.labelExperimentalSettingsHidden.AutoSize = True
        Me.labelExperimentalSettingsHidden.Location = New System.Drawing.Point(66, 166)
        Me.labelExperimentalSettingsHidden.Name = "labelExperimentalSettingsHidden"
        Me.labelExperimentalSettingsHidden.Size = New System.Drawing.Size(228, 39)
        Me.labelExperimentalSettingsHidden.TabIndex = 5
        Me.labelExperimentalSettingsHidden.Text = "Experimental options are currently hidden." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can show them by clicking in the " &
    "lower-left" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "corner of the About window."
        '
        'buttonCancel
        '
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonCancel.Location = New System.Drawing.Point(204, 402)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(81, 27)
        Me.buttonCancel.TabIndex = 5
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonOk
        '
        Me.buttonOk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonOk.Location = New System.Drawing.Point(289, 402)
        Me.buttonOk.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonOk.Name = "buttonOk"
        Me.buttonOk.Size = New System.Drawing.Size(81, 27)
        Me.buttonOk.TabIndex = 4
        Me.buttonOk.Text = "OK"
        Me.buttonOk.UseVisualStyleBackColor = True
        '
        'SevenZExeOpenFileDialog
        '
        Me.SevenZExeOpenFileDialog.FileName = "7z.exe"
        Me.SevenZExeOpenFileDialog.Filter = "EXE files|*.exe|All files|*.*"
        Me.SevenZExeOpenFileDialog.Title = "Browse for 7z.exe"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(3, 348)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(189, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "(Experimental) Search when typing"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(103, 364)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(89, 20)
        Me.NumericUpDown1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 366)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Wait time (ms):"
        '
        'OptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(372, 431)
        Me.Controls.Add(Me.tablelayoutpanelOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.tablelayoutpanelOptions.ResumeLayout(False)
        Me.tabcontrolOptions.ResumeLayout(False)
        Me.tabpagePackageDetails.ResumeLayout(False)
        Me.tabpagePackageDetails.PerformLayout()
        Me.tabpageSearch.ResumeLayout(False)
        Me.tabpageSearch.PerformLayout()
        Me.tabpageApplyChanges.ResumeLayout(False)
        Me.tabpageApplyChanges.PerformLayout()
        Me.tabpageLayout.ResumeLayout(False)
        Me.tabpageLayout.PerformLayout()
        Me.tabpageRefreshCache.ResumeLayout(False)
        Me.tabpageRefreshCache.PerformLayout()
        Me.panelExperimentalSettings.ResumeLayout(False)
        Me.panelExperimentalSettings.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tablelayoutpanelOptions As TableLayoutPanel
    Friend WithEvents buttonDefaults As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonOk As Button
    Friend WithEvents tabcontrolOptions As TabControl
    Friend WithEvents tabpagePackageDetails As TabPage
    Friend WithEvents checkboxLastSelectedPackageDetails As CheckBox
    Friend WithEvents tabpageSearch As TabPage
    Friend WithEvents checkboxUseExactMatchForLastSelectedPackageIDSearch As CheckBox
    Friend WithEvents checkboxRerunSearch As CheckBox
    Friend WithEvents tabpageApplyChanges As TabPage
    Friend WithEvents checkboxElevateWinget As CheckBox
    Friend WithEvents checkboxInstallInteractively As CheckBox
    Friend WithEvents tabpageLayout As TabPage
    Friend WithEvents checkboxShowSidebar As CheckBox
    Friend WithEvents tabpageRefreshCache As TabPage
    Friend WithEvents checkboxLoadFromDatabase As CheckBox
    Friend WithEvents labelLoadFromManifests As Label
    Friend WithEvents checkboxShowOnlyLatestVersions As CheckBox
    Friend WithEvents labelLoadLatestVersion As Label
    Friend WithEvents panelExperimentalSettings As Panel
    Friend WithEvents labelExperimentalSettingsHidden As Label
    Friend WithEvents checkboxUse7zip As CheckBox
    Friend WithEvents label7zExePath As Label
    Friend WithEvents buttonBrowse7zExePath As Button
    Friend WithEvents textbox7zExePath As TextBox
    Friend WithEvents checkboxUseRobocopy As CheckBox
    Friend WithEvents checkboxHideUnfinishedControls As CheckBox
    Friend WithEvents labelCopyrightForSevenZip As Label
    Friend WithEvents labelCopyrightForRobocopy As Label
    Friend WithEvents SevenZExeOpenFileDialog As OpenFileDialog
    Friend WithEvents labelRequiresApplicationRestart As Label
    Friend WithEvents labelWhyElevate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents CheckBox1 As CheckBox
End Class
