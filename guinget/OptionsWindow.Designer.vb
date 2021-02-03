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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsWindow))
        Me.tablelayoutpanelOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonDefaults = New System.Windows.Forms.Button()
        Me.tabcontrolOptions = New System.Windows.Forms.TabControl()
        Me.tabpageRefreshCache = New System.Windows.Forms.TabPage()
        Me.labelDeleteCacheFilesInRoaming = New System.Windows.Forms.Label()
        Me.buttonDeleteCacheFilesInRoaming = New System.Windows.Forms.Button()
        Me.labelDeleteTempFilesAfterRefresh = New System.Windows.Forms.Label()
        Me.checkboxDeleteTempFilesAfterRefresh = New System.Windows.Forms.CheckBox()
        Me.tabpageSearch = New System.Windows.Forms.TabPage()
        Me.labelWaitTime = New System.Windows.Forms.Label()
        Me.numericupdownSearchWhenTypingWaitTime = New System.Windows.Forms.NumericUpDown()
        Me.checkboxSearchWhenTyping = New System.Windows.Forms.CheckBox()
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch = New System.Windows.Forms.CheckBox()
        Me.checkboxRerunSearch = New System.Windows.Forms.CheckBox()
        Me.tabpageAppsUIs = New System.Windows.Forms.TabPage()
        Me.labelAutomaticControlPanelFallback = New System.Windows.Forms.Label()
        Me.comboboxAppsListUI = New System.Windows.Forms.ComboBox()
        Me.labelAppsListUI = New System.Windows.Forms.Label()
        Me.tabpagePackageDetails = New System.Windows.Forms.TabPage()
        Me.checkboxLastSelectedPackageDetails = New System.Windows.Forms.CheckBox()
        Me.tabpageApplyChanges = New System.Windows.Forms.TabPage()
        Me.labelWhyElevate = New System.Windows.Forms.Label()
        Me.checkboxElevateWinget = New System.Windows.Forms.CheckBox()
        Me.checkboxInstallInteractively = New System.Windows.Forms.CheckBox()
        Me.tabpageLayout = New System.Windows.Forms.TabPage()
        Me.checkboxShowSidebar = New System.Windows.Forms.CheckBox()
        Me.tabpageExperimental = New System.Windows.Forms.TabPage()
        Me.panelExperimentalSettings = New System.Windows.Forms.Panel()
        Me.labelDefaultSourceNameDescription = New System.Windows.Forms.Label()
        Me.textboxDefaultSourceName = New System.Windows.Forms.TextBox()
        Me.labelDefaultSourceName = New System.Windows.Forms.Label()
        Me.labelHiDPIMode = New System.Windows.Forms.Label()
        Me.checkboxHiDPIMode = New System.Windows.Forms.CheckBox()
        Me.labelCopyrightForRobocopy = New System.Windows.Forms.Label()
        Me.labelCopyrightForSevenZip = New System.Windows.Forms.Label()
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
        Me.checkboxHideUnfinishedControls = New System.Windows.Forms.CheckBox()
        Me.labelRequiresApplicationRestart = New System.Windows.Forms.Label()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonOk = New System.Windows.Forms.Button()
        Me.SevenZExeOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.tablelayoutpanelOptions.SuspendLayout()
        Me.tabcontrolOptions.SuspendLayout()
        Me.tabpageRefreshCache.SuspendLayout()
        Me.tabpageSearch.SuspendLayout()
        CType(Me.numericupdownSearchWhenTypingWaitTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageAppsUIs.SuspendLayout()
        Me.tabpagePackageDetails.SuspendLayout()
        Me.tabpageApplyChanges.SuspendLayout()
        Me.tabpageLayout.SuspendLayout()
        Me.tabpageExperimental.SuspendLayout()
        Me.panelExperimentalSettings.SuspendLayout()
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
        Me.tabcontrolOptions.Controls.Add(Me.tabpageRefreshCache)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageSearch)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageAppsUIs)
        Me.tabcontrolOptions.Controls.Add(Me.tabpagePackageDetails)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageApplyChanges)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageLayout)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageExperimental)
        Me.tabcontrolOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolOptions.Location = New System.Drawing.Point(2, 2)
        Me.tabcontrolOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.tabcontrolOptions.Multiline = True
        Me.tabcontrolOptions.Name = "tabcontrolOptions"
        Me.tabcontrolOptions.SelectedIndex = 0
        Me.tabcontrolOptions.Size = New System.Drawing.Size(368, 396)
        Me.tabcontrolOptions.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabcontrolOptions.TabIndex = 0
        '
        'tabpageRefreshCache
        '
        Me.tabpageRefreshCache.Controls.Add(Me.labelDeleteCacheFilesInRoaming)
        Me.tabpageRefreshCache.Controls.Add(Me.buttonDeleteCacheFilesInRoaming)
        Me.tabpageRefreshCache.Controls.Add(Me.labelDeleteTempFilesAfterRefresh)
        Me.tabpageRefreshCache.Controls.Add(Me.checkboxDeleteTempFilesAfterRefresh)
        Me.tabpageRefreshCache.Location = New System.Drawing.Point(4, 40)
        Me.tabpageRefreshCache.Name = "tabpageRefreshCache"
        Me.tabpageRefreshCache.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageRefreshCache.Size = New System.Drawing.Size(360, 352)
        Me.tabpageRefreshCache.TabIndex = 5
        Me.tabpageRefreshCache.Text = "Refresh Cache"
        Me.tabpageRefreshCache.UseVisualStyleBackColor = True
        '
        'labelDeleteCacheFilesInRoaming
        '
        Me.labelDeleteCacheFilesInRoaming.AutoSize = True
        Me.labelDeleteCacheFilesInRoaming.Location = New System.Drawing.Point(23, 108)
        Me.labelDeleteCacheFilesInRoaming.Name = "labelDeleteCacheFilesInRoaming"
        Me.labelDeleteCacheFilesInRoaming.Size = New System.Drawing.Size(247, 65)
        Me.labelDeleteCacheFilesInRoaming.TabIndex = 3
        Me.labelDeleteCacheFilesInRoaming.Text = resources.GetString("labelDeleteCacheFilesInRoaming.Text")
        '
        'buttonDeleteCacheFilesInRoaming
        '
        Me.buttonDeleteCacheFilesInRoaming.Location = New System.Drawing.Point(6, 67)
        Me.buttonDeleteCacheFilesInRoaming.Name = "buttonDeleteCacheFilesInRoaming"
        Me.buttonDeleteCacheFilesInRoaming.Size = New System.Drawing.Size(264, 38)
        Me.buttonDeleteCacheFilesInRoaming.TabIndex = 2
        Me.buttonDeleteCacheFilesInRoaming.Text = "Delete cache files in Roaming"
        Me.buttonDeleteCacheFilesInRoaming.UseVisualStyleBackColor = True
        '
        'labelDeleteTempFilesAfterRefresh
        '
        Me.labelDeleteTempFilesAfterRefresh.AutoSize = True
        Me.labelDeleteTempFilesAfterRefresh.Location = New System.Drawing.Point(23, 26)
        Me.labelDeleteTempFilesAfterRefresh.Name = "labelDeleteTempFilesAfterRefresh"
        Me.labelDeleteTempFilesAfterRefresh.Size = New System.Drawing.Size(202, 26)
        Me.labelDeleteTempFilesAfterRefresh.TabIndex = 1
        Me.labelDeleteTempFilesAfterRefresh.Text = "Temporary files are always deleted before" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "refreshing the cache."
        '
        'checkboxDeleteTempFilesAfterRefresh
        '
        Me.checkboxDeleteTempFilesAfterRefresh.AutoSize = True
        Me.checkboxDeleteTempFilesAfterRefresh.Location = New System.Drawing.Point(6, 6)
        Me.checkboxDeleteTempFilesAfterRefresh.Name = "checkboxDeleteTempFilesAfterRefresh"
        Me.checkboxDeleteTempFilesAfterRefresh.Size = New System.Drawing.Size(220, 17)
        Me.checkboxDeleteTempFilesAfterRefresh.TabIndex = 0
        Me.checkboxDeleteTempFilesAfterRefresh.Text = "Delete temporary files after cache update"
        Me.checkboxDeleteTempFilesAfterRefresh.UseVisualStyleBackColor = True
        '
        'tabpageSearch
        '
        Me.tabpageSearch.Controls.Add(Me.labelWaitTime)
        Me.tabpageSearch.Controls.Add(Me.numericupdownSearchWhenTypingWaitTime)
        Me.tabpageSearch.Controls.Add(Me.checkboxSearchWhenTyping)
        Me.tabpageSearch.Controls.Add(Me.checkboxUseExactMatchForLastSelectedPackageIDSearch)
        Me.tabpageSearch.Controls.Add(Me.checkboxRerunSearch)
        Me.tabpageSearch.Location = New System.Drawing.Point(4, 40)
        Me.tabpageSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageSearch.Name = "tabpageSearch"
        Me.tabpageSearch.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageSearch.Size = New System.Drawing.Size(360, 352)
        Me.tabpageSearch.TabIndex = 0
        Me.tabpageSearch.Text = "Search"
        Me.tabpageSearch.UseVisualStyleBackColor = True
        '
        'labelWaitTime
        '
        Me.labelWaitTime.AutoSize = True
        Me.labelWaitTime.Location = New System.Drawing.Point(24, 69)
        Me.labelWaitTime.Name = "labelWaitTime"
        Me.labelWaitTime.Size = New System.Drawing.Size(76, 13)
        Me.labelWaitTime.TabIndex = 18
        Me.labelWaitTime.Text = "Wait time (ms):"
        '
        'numericupdownSearchWhenTypingWaitTime
        '
        Me.numericupdownSearchWhenTypingWaitTime.Location = New System.Drawing.Point(106, 67)
        Me.numericupdownSearchWhenTypingWaitTime.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numericupdownSearchWhenTypingWaitTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericupdownSearchWhenTypingWaitTime.Name = "numericupdownSearchWhenTypingWaitTime"
        Me.numericupdownSearchWhenTypingWaitTime.Size = New System.Drawing.Size(89, 20)
        Me.numericupdownSearchWhenTypingWaitTime.TabIndex = 17
        Me.numericupdownSearchWhenTypingWaitTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'checkboxSearchWhenTyping
        '
        Me.checkboxSearchWhenTyping.AutoSize = True
        Me.checkboxSearchWhenTyping.Location = New System.Drawing.Point(6, 51)
        Me.checkboxSearchWhenTyping.Name = "checkboxSearchWhenTyping"
        Me.checkboxSearchWhenTyping.Size = New System.Drawing.Size(120, 17)
        Me.checkboxSearchWhenTyping.TabIndex = 16
        Me.checkboxSearchWhenTyping.Text = "Search when typing"
        Me.checkboxSearchWhenTyping.UseVisualStyleBackColor = True
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
        'tabpageAppsUIs
        '
        Me.tabpageAppsUIs.Controls.Add(Me.labelAutomaticControlPanelFallback)
        Me.tabpageAppsUIs.Controls.Add(Me.comboboxAppsListUI)
        Me.tabpageAppsUIs.Controls.Add(Me.labelAppsListUI)
        Me.tabpageAppsUIs.Location = New System.Drawing.Point(4, 40)
        Me.tabpageAppsUIs.Name = "tabpageAppsUIs"
        Me.tabpageAppsUIs.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAppsUIs.Size = New System.Drawing.Size(360, 352)
        Me.tabpageAppsUIs.TabIndex = 6
        Me.tabpageAppsUIs.Text = "Apps and UIs"
        Me.tabpageAppsUIs.UseVisualStyleBackColor = True
        '
        'labelAutomaticControlPanelFallback
        '
        Me.labelAutomaticControlPanelFallback.AutoSize = True
        Me.labelAutomaticControlPanelFallback.Location = New System.Drawing.Point(23, 54)
        Me.labelAutomaticControlPanelFallback.Name = "labelAutomaticControlPanelFallback"
        Me.labelAutomaticControlPanelFallback.Size = New System.Drawing.Size(295, 39)
        Me.labelAutomaticControlPanelFallback.TabIndex = 2
        Me.labelAutomaticControlPanelFallback.Text = "If we can't start the Settings app's ""Apps && features"" page," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "we'll fall back to" &
    " the Control Panel's ""Programs and Features""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "page automatically."
        '
        'comboboxAppsListUI
        '
        Me.comboboxAppsListUI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxAppsListUI.FormattingEnabled = True
        Me.comboboxAppsListUI.Items.AddRange(New Object() {"Settings app: Apps & features (default)", "CMD: winget list", "Control Panel: Programs and Features"})
        Me.comboboxAppsListUI.Location = New System.Drawing.Point(26, 26)
        Me.comboboxAppsListUI.Name = "comboboxAppsListUI"
        Me.comboboxAppsListUI.Size = New System.Drawing.Size(292, 21)
        Me.comboboxAppsListUI.TabIndex = 1
        '
        'labelAppsListUI
        '
        Me.labelAppsListUI.AutoSize = True
        Me.labelAppsListUI.Location = New System.Drawing.Point(7, 10)
        Me.labelAppsListUI.Name = "labelAppsListUI"
        Me.labelAppsListUI.Size = New System.Drawing.Size(99, 13)
        Me.labelAppsListUI.TabIndex = 0
        Me.labelAppsListUI.Text = "Installed packages:"
        '
        'tabpagePackageDetails
        '
        Me.tabpagePackageDetails.Controls.Add(Me.checkboxLastSelectedPackageDetails)
        Me.tabpagePackageDetails.Location = New System.Drawing.Point(4, 40)
        Me.tabpagePackageDetails.Name = "tabpagePackageDetails"
        Me.tabpagePackageDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpagePackageDetails.Size = New System.Drawing.Size(360, 352)
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
        'tabpageApplyChanges
        '
        Me.tabpageApplyChanges.Controls.Add(Me.labelWhyElevate)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxElevateWinget)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxInstallInteractively)
        Me.tabpageApplyChanges.Location = New System.Drawing.Point(4, 40)
        Me.tabpageApplyChanges.Name = "tabpageApplyChanges"
        Me.tabpageApplyChanges.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageApplyChanges.Size = New System.Drawing.Size(360, 352)
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
        Me.tabpageLayout.Location = New System.Drawing.Point(4, 40)
        Me.tabpageLayout.Name = "tabpageLayout"
        Me.tabpageLayout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageLayout.Size = New System.Drawing.Size(360, 352)
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
        'tabpageExperimental
        '
        Me.tabpageExperimental.Controls.Add(Me.panelExperimentalSettings)
        Me.tabpageExperimental.Controls.Add(Me.labelExperimentalSettingsHidden)
        Me.tabpageExperimental.Controls.Add(Me.checkboxHideUnfinishedControls)
        Me.tabpageExperimental.Controls.Add(Me.labelRequiresApplicationRestart)
        Me.tabpageExperimental.Location = New System.Drawing.Point(4, 40)
        Me.tabpageExperimental.Name = "tabpageExperimental"
        Me.tabpageExperimental.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageExperimental.Size = New System.Drawing.Size(360, 352)
        Me.tabpageExperimental.TabIndex = 4
        Me.tabpageExperimental.Text = "Experimental"
        Me.tabpageExperimental.UseVisualStyleBackColor = True
        '
        'panelExperimentalSettings
        '
        Me.panelExperimentalSettings.AutoScroll = True
        Me.panelExperimentalSettings.Controls.Add(Me.labelDefaultSourceNameDescription)
        Me.panelExperimentalSettings.Controls.Add(Me.textboxDefaultSourceName)
        Me.panelExperimentalSettings.Controls.Add(Me.labelDefaultSourceName)
        Me.panelExperimentalSettings.Controls.Add(Me.labelHiDPIMode)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxHiDPIMode)
        Me.panelExperimentalSettings.Controls.Add(Me.labelCopyrightForRobocopy)
        Me.panelExperimentalSettings.Controls.Add(Me.labelCopyrightForSevenZip)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxUseRobocopy)
        Me.panelExperimentalSettings.Controls.Add(Me.buttonBrowse7zExePath)
        Me.panelExperimentalSettings.Controls.Add(Me.textbox7zExePath)
        Me.panelExperimentalSettings.Controls.Add(Me.label7zExePath)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxUse7zip)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxLoadFromDatabase)
        Me.panelExperimentalSettings.Controls.Add(Me.labelLoadLatestVersion)
        Me.panelExperimentalSettings.Controls.Add(Me.labelLoadFromManifests)
        Me.panelExperimentalSettings.Controls.Add(Me.checkboxShowOnlyLatestVersions)
        Me.panelExperimentalSettings.Location = New System.Drawing.Point(3, 49)
        Me.panelExperimentalSettings.Name = "panelExperimentalSettings"
        Me.panelExperimentalSettings.Size = New System.Drawing.Size(354, 300)
        Me.panelExperimentalSettings.TabIndex = 4
        '
        'labelDefaultSourceNameDescription
        '
        Me.labelDefaultSourceNameDescription.AutoSize = True
        Me.labelDefaultSourceNameDescription.Location = New System.Drawing.Point(21, 387)
        Me.labelDefaultSourceNameDescription.Name = "labelDefaultSourceNameDescription"
        Me.labelDefaultSourceNameDescription.Size = New System.Drawing.Size(261, 91)
        Me.labelDefaultSourceNameDescription.TabIndex = 20
        Me.labelDefaultSourceNameDescription.Text = resources.GetString("labelDefaultSourceNameDescription.Text")
        '
        'textboxDefaultSourceName
        '
        Me.textboxDefaultSourceName.Location = New System.Drawing.Point(117, 364)
        Me.textboxDefaultSourceName.Name = "textboxDefaultSourceName"
        Me.textboxDefaultSourceName.Size = New System.Drawing.Size(201, 20)
        Me.textboxDefaultSourceName.TabIndex = 19
        '
        'labelDefaultSourceName
        '
        Me.labelDefaultSourceName.AutoSize = True
        Me.labelDefaultSourceName.Location = New System.Drawing.Point(3, 367)
        Me.labelDefaultSourceName.Name = "labelDefaultSourceName"
        Me.labelDefaultSourceName.Size = New System.Drawing.Size(108, 13)
        Me.labelDefaultSourceName.TabIndex = 18
        Me.labelDefaultSourceName.Text = "Default source name:"
        '
        'labelHiDPIMode
        '
        Me.labelHiDPIMode.AutoSize = True
        Me.labelHiDPIMode.Location = New System.Drawing.Point(21, 319)
        Me.labelHiDPIMode.Name = "labelHiDPIMode"
        Me.labelHiDPIMode.Size = New System.Drawing.Size(293, 39)
        Me.labelHiDPIMode.TabIndex = 17
        Me.labelHiDPIMode.Text = "For now, only doubles the height of items in the package list." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "May eventually be" &
    " expanded to cover the rest of the controls" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that are difficult to use on HiDPI " &
    "devices."
        '
        'checkboxHiDPIMode
        '
        Me.checkboxHiDPIMode.AutoSize = True
        Me.checkboxHiDPIMode.Location = New System.Drawing.Point(3, 302)
        Me.checkboxHiDPIMode.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxHiDPIMode.Name = "checkboxHiDPIMode"
        Me.checkboxHiDPIMode.Size = New System.Drawing.Size(84, 17)
        Me.checkboxHiDPIMode.TabIndex = 16
        Me.checkboxHiDPIMode.Text = "HiDPI Mode"
        Me.checkboxHiDPIMode.UseVisualStyleBackColor = True
        '
        'labelCopyrightForRobocopy
        '
        Me.labelCopyrightForRobocopy.AutoSize = True
        Me.labelCopyrightForRobocopy.Location = New System.Drawing.Point(21, 247)
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
        Me.labelCopyrightForSevenZip.Location = New System.Drawing.Point(18, 164)
        Me.labelCopyrightForSevenZip.Name = "labelCopyrightForSevenZip"
        Me.labelCopyrightForSevenZip.Size = New System.Drawing.Size(234, 39)
        Me.labelCopyrightForSevenZip.TabIndex = 10
        Me.labelCopyrightForSevenZip.Text = "7-Zip is Copyright (C) Igor Pavlov." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7-Zip may extract faster than the .NET extra" &
    "ctor," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "but it's not fully tested for this purpose." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'checkboxUseRobocopy
        '
        Me.checkboxUseRobocopy.AutoSize = True
        Me.checkboxUseRobocopy.Location = New System.Drawing.Point(3, 230)
        Me.checkboxUseRobocopy.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxUseRobocopy.Name = "checkboxUseRobocopy"
        Me.checkboxUseRobocopy.Size = New System.Drawing.Size(250, 17)
        Me.checkboxUseRobocopy.TabIndex = 6
        Me.checkboxUseRobocopy.Text = "Use Robocopy to copy manifests and database"
        Me.checkboxUseRobocopy.UseVisualStyleBackColor = True
        '
        'buttonBrowse7zExePath
        '
        Me.buttonBrowse7zExePath.Location = New System.Drawing.Point(243, 205)
        Me.buttonBrowse7zExePath.Name = "buttonBrowse7zExePath"
        Me.buttonBrowse7zExePath.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowse7zExePath.TabIndex = 5
        Me.buttonBrowse7zExePath.Text = "Browse..."
        Me.buttonBrowse7zExePath.UseVisualStyleBackColor = True
        '
        'textbox7zExePath
        '
        Me.textbox7zExePath.Location = New System.Drawing.Point(89, 206)
        Me.textbox7zExePath.Name = "textbox7zExePath"
        Me.textbox7zExePath.Size = New System.Drawing.Size(148, 20)
        Me.textbox7zExePath.TabIndex = 4
        '
        'label7zExePath
        '
        Me.label7zExePath.AutoSize = True
        Me.label7zExePath.Location = New System.Drawing.Point(18, 206)
        Me.label7zExePath.Name = "label7zExePath"
        Me.label7zExePath.Size = New System.Drawing.Size(65, 13)
        Me.label7zExePath.TabIndex = 5
        Me.label7zExePath.Text = "7z.exe path:"
        '
        'checkboxUse7zip
        '
        Me.checkboxUse7zip.AutoSize = True
        Me.checkboxUse7zip.Location = New System.Drawing.Point(3, 147)
        Me.checkboxUse7zip.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxUse7zip.Name = "checkboxUse7zip"
        Me.checkboxUse7zip.Size = New System.Drawing.Size(234, 17)
        Me.checkboxUse7zip.TabIndex = 3
        Me.checkboxUse7zip.Text = "Use 7-Zip to extract manifests and database"
        Me.checkboxUse7zip.UseVisualStyleBackColor = True
        '
        'checkboxLoadFromDatabase
        '
        Me.checkboxLoadFromDatabase.AutoSize = True
        Me.checkboxLoadFromDatabase.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxLoadFromDatabase.Location = New System.Drawing.Point(3, 3)
        Me.checkboxLoadFromDatabase.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxLoadFromDatabase.Name = "checkboxLoadFromDatabase"
        Me.checkboxLoadFromDatabase.Size = New System.Drawing.Size(229, 30)
        Me.checkboxLoadFromDatabase.TabIndex = 1
        Me.checkboxLoadFromDatabase.Text = "Update and load package list from winget's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "default community database"
        Me.checkboxLoadFromDatabase.UseVisualStyleBackColor = True
        '
        'labelLoadLatestVersion
        '
        Me.labelLoadLatestVersion.AutoSize = True
        Me.labelLoadLatestVersion.Location = New System.Drawing.Point(18, 92)
        Me.labelLoadLatestVersion.Name = "labelLoadLatestVersion"
        Me.labelLoadLatestVersion.Size = New System.Drawing.Size(271, 52)
        Me.labelLoadLatestVersion.TabIndex = 3
        Me.labelLoadLatestVersion.Text = "Some packages may display a version number that's not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "really the latest version." &
    " Not sure how to fix this at the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "moment. Requires loading from the community" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "d" &
    "atabase checkbox to be checked."
        '
        'labelLoadFromManifests
        '
        Me.labelLoadFromManifests.AutoSize = True
        Me.labelLoadFromManifests.Location = New System.Drawing.Point(18, 33)
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
        Me.checkboxShowOnlyLatestVersions.Location = New System.Drawing.Point(3, 75)
        Me.checkboxShowOnlyLatestVersions.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxShowOnlyLatestVersions.Name = "checkboxShowOnlyLatestVersions"
        Me.checkboxShowOnlyLatestVersions.Size = New System.Drawing.Size(239, 17)
        Me.checkboxShowOnlyLatestVersions.TabIndex = 2
        Me.checkboxShowOnlyLatestVersions.Text = "Load only the latest version of each package"
        Me.checkboxShowOnlyLatestVersions.UseVisualStyleBackColor = True
        '
        'labelExperimentalSettingsHidden
        '
        Me.labelExperimentalSettingsHidden.AutoSize = True
        Me.labelExperimentalSettingsHidden.Location = New System.Drawing.Point(79, 179)
        Me.labelExperimentalSettingsHidden.Name = "labelExperimentalSettingsHidden"
        Me.labelExperimentalSettingsHidden.Size = New System.Drawing.Size(203, 13)
        Me.labelExperimentalSettingsHidden.TabIndex = 5
        Me.labelExperimentalSettingsHidden.Text = "Experimental options are currently hidden."
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
        'labelRequiresApplicationRestart
        '
        Me.labelRequiresApplicationRestart.AutoSize = True
        Me.labelRequiresApplicationRestart.Location = New System.Drawing.Point(18, 20)
        Me.labelRequiresApplicationRestart.Name = "labelRequiresApplicationRestart"
        Me.labelRequiresApplicationRestart.Size = New System.Drawing.Size(251, 26)
        Me.labelRequiresApplicationRestart.TabIndex = 12
        Me.labelRequiresApplicationRestart.Text = "May require application restart to take full effect." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The rest of these options s" &
    "till apply even if this is on."
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
        Me.tabpageRefreshCache.ResumeLayout(False)
        Me.tabpageRefreshCache.PerformLayout()
        Me.tabpageSearch.ResumeLayout(False)
        Me.tabpageSearch.PerformLayout()
        CType(Me.numericupdownSearchWhenTypingWaitTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageAppsUIs.ResumeLayout(False)
        Me.tabpageAppsUIs.PerformLayout()
        Me.tabpagePackageDetails.ResumeLayout(False)
        Me.tabpagePackageDetails.PerformLayout()
        Me.tabpageApplyChanges.ResumeLayout(False)
        Me.tabpageApplyChanges.PerformLayout()
        Me.tabpageLayout.ResumeLayout(False)
        Me.tabpageLayout.PerformLayout()
        Me.tabpageExperimental.ResumeLayout(False)
        Me.tabpageExperimental.PerformLayout()
        Me.panelExperimentalSettings.ResumeLayout(False)
        Me.panelExperimentalSettings.PerformLayout()
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
    Friend WithEvents tabpageExperimental As TabPage
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
    Friend WithEvents checkboxHiDPIMode As CheckBox
    Friend WithEvents labelHiDPIMode As Label
    Friend WithEvents textboxDefaultSourceName As TextBox
    Friend WithEvents labelDefaultSourceName As Label
    Friend WithEvents labelDefaultSourceNameDescription As Label
    Friend WithEvents tabpageRefreshCache As TabPage
    Friend WithEvents checkboxDeleteTempFilesAfterRefresh As CheckBox
    Friend WithEvents labelDeleteTempFilesAfterRefresh As Label
    Friend WithEvents buttonDeleteCacheFilesInRoaming As Button
    Friend WithEvents labelDeleteCacheFilesInRoaming As Label
    Friend WithEvents labelWaitTime As Label
    Friend WithEvents numericupdownSearchWhenTypingWaitTime As NumericUpDown
    Friend WithEvents checkboxSearchWhenTyping As CheckBox
    Friend WithEvents tabpageAppsUIs As TabPage
    Friend WithEvents labelAppsListUI As Label
    Friend WithEvents comboboxAppsListUI As ComboBox
    Friend WithEvents labelAutomaticControlPanelFallback As Label
End Class
