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
        Me.labelLoadLatestVersion = New System.Windows.Forms.Label()
        Me.checkboxShowOnlyLatestVersions = New System.Windows.Forms.CheckBox()
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
        Me.labelAboutNotSpecifyingVersionNumbers = New System.Windows.Forms.Label()
        Me.labelSpecifyVersionNumberHeading = New System.Windows.Forms.Label()
        Me.checkboxWhenInstalling = New System.Windows.Forms.CheckBox()
        Me.checkboxWhenUpgrading = New System.Windows.Forms.CheckBox()
        Me.checkboxWhenUninstalling = New System.Windows.Forms.CheckBox()
        Me.checkboxOpenMiniOptions = New System.Windows.Forms.CheckBox()
        Me.labelWhyElevate = New System.Windows.Forms.Label()
        Me.checkboxElevateWinget = New System.Windows.Forms.CheckBox()
        Me.checkboxInstallInteractively = New System.Windows.Forms.CheckBox()
        Me.tabpageLayout = New System.Windows.Forms.TabPage()
        Me.checkboxShowSidebar = New System.Windows.Forms.CheckBox()
        Me.tabpageMaintenance = New System.Windows.Forms.TabPage()
        Me.labelTabWillBeMoved = New System.Windows.Forms.Label()
        Me.labelDeleteCacheFiles = New System.Windows.Forms.Label()
        Me.buttonDeleteCacheFiles = New System.Windows.Forms.Button()
        Me.labelDeleteCacheFilesInRoaming = New System.Windows.Forms.Label()
        Me.buttonDeleteCacheFilesInRoaming = New System.Windows.Forms.Button()
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
        Me.labelExperimentalSettingsHidden = New System.Windows.Forms.Label()
        Me.checkboxHideUnfinishedControls = New System.Windows.Forms.CheckBox()
        Me.labelRequiresApplicationRestart = New System.Windows.Forms.Label()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonOk = New System.Windows.Forms.Button()
        Me.SevenZExeOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.checkboxUseKDEStyleFastResize = New System.Windows.Forms.CheckBox()
        Me.groupboxPackageList = New System.Windows.Forms.GroupBox()
        Me.groupboxPackageDetails = New System.Windows.Forms.GroupBox()
        Me.tablelayoutpanelOptions.SuspendLayout()
        Me.tabcontrolOptions.SuspendLayout()
        Me.tabpageRefreshCache.SuspendLayout()
        Me.tabpageSearch.SuspendLayout()
        CType(Me.numericupdownSearchWhenTypingWaitTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageAppsUIs.SuspendLayout()
        Me.tabpagePackageDetails.SuspendLayout()
        Me.tabpageApplyChanges.SuspendLayout()
        Me.tabpageLayout.SuspendLayout()
        Me.tabpageMaintenance.SuspendLayout()
        Me.tabpageExperimental.SuspendLayout()
        Me.panelExperimentalSettings.SuspendLayout()
        Me.groupboxPackageList.SuspendLayout()
        Me.groupboxPackageDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'tablelayoutpanelOptions
        '
        Me.tablelayoutpanelOptions.ColumnCount = 4
        Me.tablelayoutpanelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.tablelayoutpanelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.tablelayoutpanelOptions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
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
        Me.tablelayoutpanelOptions.Size = New System.Drawing.Size(465, 539)
        Me.tablelayoutpanelOptions.TabIndex = 0
        '
        'buttonDefaults
        '
        Me.buttonDefaults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonDefaults.Location = New System.Drawing.Point(2, 502)
        Me.buttonDefaults.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonDefaults.Name = "buttonDefaults"
        Me.buttonDefaults.Size = New System.Drawing.Size(102, 35)
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
        Me.tabcontrolOptions.Controls.Add(Me.tabpageMaintenance)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageExperimental)
        Me.tabcontrolOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolOptions.Location = New System.Drawing.Point(2, 2)
        Me.tabcontrolOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.tabcontrolOptions.Multiline = True
        Me.tabcontrolOptions.Name = "tabcontrolOptions"
        Me.tabcontrolOptions.SelectedIndex = 0
        Me.tabcontrolOptions.Size = New System.Drawing.Size(461, 496)
        Me.tabcontrolOptions.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tabcontrolOptions.TabIndex = 0
        '
        'tabpageRefreshCache
        '
        Me.tabpageRefreshCache.Controls.Add(Me.labelLoadLatestVersion)
        Me.tabpageRefreshCache.Controls.Add(Me.checkboxShowOnlyLatestVersions)
        Me.tabpageRefreshCache.Controls.Add(Me.labelDeleteTempFilesAfterRefresh)
        Me.tabpageRefreshCache.Controls.Add(Me.checkboxDeleteTempFilesAfterRefresh)
        Me.tabpageRefreshCache.Location = New System.Drawing.Point(4, 46)
        Me.tabpageRefreshCache.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpageRefreshCache.Name = "tabpageRefreshCache"
        Me.tabpageRefreshCache.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpageRefreshCache.Size = New System.Drawing.Size(453, 446)
        Me.tabpageRefreshCache.TabIndex = 5
        Me.tabpageRefreshCache.Text = "Refresh Cache"
        Me.tabpageRefreshCache.UseVisualStyleBackColor = True
        '
        'labelLoadLatestVersion
        '
        Me.labelLoadLatestVersion.AutoSize = True
        Me.labelLoadLatestVersion.Location = New System.Drawing.Point(29, 91)
        Me.labelLoadLatestVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelLoadLatestVersion.Name = "labelLoadLatestVersion"
        Me.labelLoadLatestVersion.Size = New System.Drawing.Size(363, 51)
        Me.labelLoadLatestVersion.TabIndex = 7
        Me.labelLoadLatestVersion.Text = "Some packages may display a version number that's not" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "really the latest version." &
    " Not sure how to fix this at the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "moment."
        '
        'checkboxShowOnlyLatestVersions
        '
        Me.checkboxShowOnlyLatestVersions.AutoSize = True
        Me.checkboxShowOnlyLatestVersions.Location = New System.Drawing.Point(8, 70)
        Me.checkboxShowOnlyLatestVersions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.checkboxShowOnlyLatestVersions.Name = "checkboxShowOnlyLatestVersions"
        Me.checkboxShowOnlyLatestVersions.Size = New System.Drawing.Size(313, 21)
        Me.checkboxShowOnlyLatestVersions.TabIndex = 6
        Me.checkboxShowOnlyLatestVersions.Text = "Load only the latest version of each package"
        Me.checkboxShowOnlyLatestVersions.UseVisualStyleBackColor = True
        '
        'labelDeleteTempFilesAfterRefresh
        '
        Me.labelDeleteTempFilesAfterRefresh.AutoSize = True
        Me.labelDeleteTempFilesAfterRefresh.Location = New System.Drawing.Point(29, 32)
        Me.labelDeleteTempFilesAfterRefresh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelDeleteTempFilesAfterRefresh.Name = "labelDeleteTempFilesAfterRefresh"
        Me.labelDeleteTempFilesAfterRefresh.Size = New System.Drawing.Size(273, 34)
        Me.labelDeleteTempFilesAfterRefresh.TabIndex = 1
        Me.labelDeleteTempFilesAfterRefresh.Text = "Temporary files are always deleted before" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "refreshing the cache."
        '
        'checkboxDeleteTempFilesAfterRefresh
        '
        Me.checkboxDeleteTempFilesAfterRefresh.AutoSize = True
        Me.checkboxDeleteTempFilesAfterRefresh.Location = New System.Drawing.Point(8, 8)
        Me.checkboxDeleteTempFilesAfterRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxDeleteTempFilesAfterRefresh.Name = "checkboxDeleteTempFilesAfterRefresh"
        Me.checkboxDeleteTempFilesAfterRefresh.Size = New System.Drawing.Size(291, 21)
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
        Me.tabpageSearch.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageSearch.Name = "tabpageSearch"
        Me.tabpageSearch.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageSearch.Size = New System.Drawing.Size(453, 467)
        Me.tabpageSearch.TabIndex = 0
        Me.tabpageSearch.Text = "Search"
        Me.tabpageSearch.UseVisualStyleBackColor = True
        '
        'labelWaitTime
        '
        Me.labelWaitTime.AutoSize = True
        Me.labelWaitTime.Location = New System.Drawing.Point(30, 86)
        Me.labelWaitTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelWaitTime.Name = "labelWaitTime"
        Me.labelWaitTime.Size = New System.Drawing.Size(102, 17)
        Me.labelWaitTime.TabIndex = 18
        Me.labelWaitTime.Text = "Wait time (ms):"
        '
        'numericupdownSearchWhenTypingWaitTime
        '
        Me.numericupdownSearchWhenTypingWaitTime.Location = New System.Drawing.Point(132, 84)
        Me.numericupdownSearchWhenTypingWaitTime.Margin = New System.Windows.Forms.Padding(4)
        Me.numericupdownSearchWhenTypingWaitTime.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numericupdownSearchWhenTypingWaitTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numericupdownSearchWhenTypingWaitTime.Name = "numericupdownSearchWhenTypingWaitTime"
        Me.numericupdownSearchWhenTypingWaitTime.Size = New System.Drawing.Size(111, 22)
        Me.numericupdownSearchWhenTypingWaitTime.TabIndex = 17
        Me.numericupdownSearchWhenTypingWaitTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'checkboxSearchWhenTyping
        '
        Me.checkboxSearchWhenTyping.AutoSize = True
        Me.checkboxSearchWhenTyping.Location = New System.Drawing.Point(8, 64)
        Me.checkboxSearchWhenTyping.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxSearchWhenTyping.Name = "checkboxSearchWhenTyping"
        Me.checkboxSearchWhenTyping.Size = New System.Drawing.Size(154, 21)
        Me.checkboxSearchWhenTyping.TabIndex = 16
        Me.checkboxSearchWhenTyping.Text = "Search when typing"
        Me.checkboxSearchWhenTyping.UseVisualStyleBackColor = True
        '
        'checkboxUseExactMatchForLastSelectedPackageIDSearch
        '
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.AutoSize = True
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.Location = New System.Drawing.Point(8, 35)
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.Name = "checkboxUseExactMatchForLastSelectedPackageIDSearch"
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.Size = New System.Drawing.Size(334, 21)
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.TabIndex = 3
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.Text = "Use exact match for selected package ID search"
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch.UseVisualStyleBackColor = True
        '
        'checkboxRerunSearch
        '
        Me.checkboxRerunSearch.AutoSize = True
        Me.checkboxRerunSearch.Location = New System.Drawing.Point(8, 8)
        Me.checkboxRerunSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxRerunSearch.Name = "checkboxRerunSearch"
        Me.checkboxRerunSearch.Size = New System.Drawing.Size(244, 21)
        Me.checkboxRerunSearch.TabIndex = 0
        Me.checkboxRerunSearch.Text = "Re-run search after cache update"
        Me.checkboxRerunSearch.UseVisualStyleBackColor = True
        '
        'tabpageAppsUIs
        '
        Me.tabpageAppsUIs.Controls.Add(Me.labelAutomaticControlPanelFallback)
        Me.tabpageAppsUIs.Controls.Add(Me.comboboxAppsListUI)
        Me.tabpageAppsUIs.Controls.Add(Me.labelAppsListUI)
        Me.tabpageAppsUIs.Location = New System.Drawing.Point(4, 25)
        Me.tabpageAppsUIs.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpageAppsUIs.Name = "tabpageAppsUIs"
        Me.tabpageAppsUIs.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpageAppsUIs.Size = New System.Drawing.Size(453, 467)
        Me.tabpageAppsUIs.TabIndex = 6
        Me.tabpageAppsUIs.Text = "Apps and UIs"
        Me.tabpageAppsUIs.UseVisualStyleBackColor = True
        '
        'labelAutomaticControlPanelFallback
        '
        Me.labelAutomaticControlPanelFallback.AutoSize = True
        Me.labelAutomaticControlPanelFallback.Location = New System.Drawing.Point(29, 68)
        Me.labelAutomaticControlPanelFallback.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelAutomaticControlPanelFallback.Name = "labelAutomaticControlPanelFallback"
        Me.labelAutomaticControlPanelFallback.Size = New System.Drawing.Size(392, 51)
        Me.labelAutomaticControlPanelFallback.TabIndex = 2
        Me.labelAutomaticControlPanelFallback.Text = "If we can't start the Settings app's ""Apps && features"" page," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "we'll fall back to" &
    " the Control Panel's ""Programs and Features""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "page automatically."
        '
        'comboboxAppsListUI
        '
        Me.comboboxAppsListUI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxAppsListUI.FormattingEnabled = True
        Me.comboboxAppsListUI.Items.AddRange(New Object() {"Settings app: Apps & features (default)", "CMD: winget list", "Control Panel: Programs and Features"})
        Me.comboboxAppsListUI.Location = New System.Drawing.Point(32, 32)
        Me.comboboxAppsListUI.Margin = New System.Windows.Forms.Padding(4)
        Me.comboboxAppsListUI.Name = "comboboxAppsListUI"
        Me.comboboxAppsListUI.Size = New System.Drawing.Size(364, 24)
        Me.comboboxAppsListUI.TabIndex = 1
        '
        'labelAppsListUI
        '
        Me.labelAppsListUI.AutoSize = True
        Me.labelAppsListUI.Location = New System.Drawing.Point(9, 12)
        Me.labelAppsListUI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelAppsListUI.Name = "labelAppsListUI"
        Me.labelAppsListUI.Size = New System.Drawing.Size(129, 17)
        Me.labelAppsListUI.TabIndex = 0
        Me.labelAppsListUI.Text = "Installed packages:"
        '
        'tabpagePackageDetails
        '
        Me.tabpagePackageDetails.Controls.Add(Me.groupboxPackageDetails)
        Me.tabpagePackageDetails.Controls.Add(Me.groupboxPackageList)
        Me.tabpagePackageDetails.Location = New System.Drawing.Point(4, 46)
        Me.tabpagePackageDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpagePackageDetails.Name = "tabpagePackageDetails"
        Me.tabpagePackageDetails.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpagePackageDetails.Size = New System.Drawing.Size(453, 446)
        Me.tabpagePackageDetails.TabIndex = 2
        Me.tabpagePackageDetails.Text = "Package List + Details"
        Me.tabpagePackageDetails.UseVisualStyleBackColor = True
        '
        'checkboxLastSelectedPackageDetails
        '
        Me.checkboxLastSelectedPackageDetails.AutoSize = True
        Me.checkboxLastSelectedPackageDetails.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxLastSelectedPackageDetails.Location = New System.Drawing.Point(7, 22)
        Me.checkboxLastSelectedPackageDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxLastSelectedPackageDetails.Name = "checkboxLastSelectedPackageDetails"
        Me.checkboxLastSelectedPackageDetails.Size = New System.Drawing.Size(348, 38)
        Me.checkboxLastSelectedPackageDetails.TabIndex = 0
        Me.checkboxLastSelectedPackageDetails.Text = "Show last-selected package details when selecting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "multiple packages"
        Me.checkboxLastSelectedPackageDetails.UseVisualStyleBackColor = True
        '
        'tabpageApplyChanges
        '
        Me.tabpageApplyChanges.Controls.Add(Me.labelAboutNotSpecifyingVersionNumbers)
        Me.tabpageApplyChanges.Controls.Add(Me.labelSpecifyVersionNumberHeading)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxWhenInstalling)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxWhenUpgrading)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxWhenUninstalling)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxOpenMiniOptions)
        Me.tabpageApplyChanges.Controls.Add(Me.labelWhyElevate)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxElevateWinget)
        Me.tabpageApplyChanges.Controls.Add(Me.checkboxInstallInteractively)
        Me.tabpageApplyChanges.Location = New System.Drawing.Point(4, 46)
        Me.tabpageApplyChanges.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpageApplyChanges.Name = "tabpageApplyChanges"
        Me.tabpageApplyChanges.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpageApplyChanges.Size = New System.Drawing.Size(453, 446)
        Me.tabpageApplyChanges.TabIndex = 1
        Me.tabpageApplyChanges.Text = "Apply Changes"
        Me.tabpageApplyChanges.UseVisualStyleBackColor = True
        '
        'labelAboutNotSpecifyingVersionNumbers
        '
        Me.labelAboutNotSpecifyingVersionNumbers.AutoSize = True
        Me.labelAboutNotSpecifyingVersionNumbers.Location = New System.Drawing.Point(25, 258)
        Me.labelAboutNotSpecifyingVersionNumbers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelAboutNotSpecifyingVersionNumbers.Name = "labelAboutNotSpecifyingVersionNumbers"
        Me.labelAboutNotSpecifyingVersionNumbers.Size = New System.Drawing.Size(348, 68)
        Me.labelAboutNotSpecifyingVersionNumbers.TabIndex = 17
        Me.labelAboutNotSpecifyingVersionNumbers.Text = resources.GetString("labelAboutNotSpecifyingVersionNumbers.Text")
        '
        'labelSpecifyVersionNumberHeading
        '
        Me.labelSpecifyVersionNumberHeading.AutoSize = True
        Me.labelSpecifyVersionNumberHeading.Location = New System.Drawing.Point(4, 154)
        Me.labelSpecifyVersionNumberHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelSpecifyVersionNumberHeading.Name = "labelSpecifyVersionNumberHeading"
        Me.labelSpecifyVersionNumberHeading.Size = New System.Drawing.Size(168, 17)
        Me.labelSpecifyVersionNumberHeading.TabIndex = 16
        Me.labelSpecifyVersionNumberHeading.Text = "Specify version number..."
        '
        'checkboxWhenInstalling
        '
        Me.checkboxWhenInstalling.AccessibleDescription = "Specify version number when installing a package."
        Me.checkboxWhenInstalling.AutoSize = True
        Me.checkboxWhenInstalling.Location = New System.Drawing.Point(29, 174)
        Me.checkboxWhenInstalling.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxWhenInstalling.Name = "checkboxWhenInstalling"
        Me.checkboxWhenInstalling.Size = New System.Drawing.Size(126, 21)
        Me.checkboxWhenInstalling.TabIndex = 2
        Me.checkboxWhenInstalling.Text = "When installing"
        Me.checkboxWhenInstalling.UseVisualStyleBackColor = True
        '
        'checkboxWhenUpgrading
        '
        Me.checkboxWhenUpgrading.AccessibleDescription = "Specify version number when upgrading a package."
        Me.checkboxWhenUpgrading.AutoSize = True
        Me.checkboxWhenUpgrading.Location = New System.Drawing.Point(29, 202)
        Me.checkboxWhenUpgrading.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxWhenUpgrading.Name = "checkboxWhenUpgrading"
        Me.checkboxWhenUpgrading.Size = New System.Drawing.Size(135, 21)
        Me.checkboxWhenUpgrading.TabIndex = 3
        Me.checkboxWhenUpgrading.Text = "When upgrading"
        Me.checkboxWhenUpgrading.UseVisualStyleBackColor = True
        '
        'checkboxWhenUninstalling
        '
        Me.checkboxWhenUninstalling.AccessibleDescription = "Specify version number when uninstalling a package."
        Me.checkboxWhenUninstalling.AutoSize = True
        Me.checkboxWhenUninstalling.Location = New System.Drawing.Point(29, 232)
        Me.checkboxWhenUninstalling.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxWhenUninstalling.Name = "checkboxWhenUninstalling"
        Me.checkboxWhenUninstalling.Size = New System.Drawing.Size(142, 21)
        Me.checkboxWhenUninstalling.TabIndex = 4
        Me.checkboxWhenUninstalling.Text = "When uninstalling"
        Me.checkboxWhenUninstalling.UseVisualStyleBackColor = True
        '
        'checkboxOpenMiniOptions
        '
        Me.checkboxOpenMiniOptions.AutoSize = True
        Me.checkboxOpenMiniOptions.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxOpenMiniOptions.Location = New System.Drawing.Point(8, 395)
        Me.checkboxOpenMiniOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxOpenMiniOptions.Name = "checkboxOpenMiniOptions"
        Me.checkboxOpenMiniOptions.Size = New System.Drawing.Size(365, 38)
        Me.checkboxOpenMiniOptions.TabIndex = 5
        Me.checkboxOpenMiniOptions.Text = "Automatically open the mini Options window when the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Apply Changes window is open" &
    "ed"
        Me.checkboxOpenMiniOptions.UseVisualStyleBackColor = True
        '
        'labelWhyElevate
        '
        Me.labelWhyElevate.AutoSize = True
        Me.labelWhyElevate.Location = New System.Drawing.Point(29, 58)
        Me.labelWhyElevate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelWhyElevate.Name = "labelWhyElevate"
        Me.labelWhyElevate.Size = New System.Drawing.Size(392, 85)
        Me.labelWhyElevate.TabIndex = 2
        Me.labelWhyElevate.Text = resources.GetString("labelWhyElevate.Text")
        '
        'checkboxElevateWinget
        '
        Me.checkboxElevateWinget.AutoSize = True
        Me.checkboxElevateWinget.Location = New System.Drawing.Point(8, 36)
        Me.checkboxElevateWinget.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.checkboxElevateWinget.Name = "checkboxElevateWinget"
        Me.checkboxElevateWinget.Size = New System.Drawing.Size(181, 21)
        Me.checkboxElevateWinget.TabIndex = 1
        Me.checkboxElevateWinget.Text = "Elevate winget with UAC"
        Me.checkboxElevateWinget.UseVisualStyleBackColor = True
        '
        'checkboxInstallInteractively
        '
        Me.checkboxInstallInteractively.AutoSize = True
        Me.checkboxInstallInteractively.Location = New System.Drawing.Point(8, 8)
        Me.checkboxInstallInteractively.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxInstallInteractively.Name = "checkboxInstallInteractively"
        Me.checkboxInstallInteractively.Size = New System.Drawing.Size(201, 21)
        Me.checkboxInstallInteractively.TabIndex = 0
        Me.checkboxInstallInteractively.Text = "Run interactively (winget -i)"
        Me.checkboxInstallInteractively.UseVisualStyleBackColor = True
        '
        'tabpageLayout
        '
        Me.tabpageLayout.Controls.Add(Me.checkboxShowSidebar)
        Me.tabpageLayout.Location = New System.Drawing.Point(4, 46)
        Me.tabpageLayout.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpageLayout.Name = "tabpageLayout"
        Me.tabpageLayout.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpageLayout.Size = New System.Drawing.Size(453, 446)
        Me.tabpageLayout.TabIndex = 3
        Me.tabpageLayout.Text = "Layout"
        Me.tabpageLayout.UseVisualStyleBackColor = True
        '
        'checkboxShowSidebar
        '
        Me.checkboxShowSidebar.AutoSize = True
        Me.checkboxShowSidebar.Location = New System.Drawing.Point(6, 6)
        Me.checkboxShowSidebar.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxShowSidebar.Name = "checkboxShowSidebar"
        Me.checkboxShowSidebar.Size = New System.Drawing.Size(115, 21)
        Me.checkboxShowSidebar.TabIndex = 2
        Me.checkboxShowSidebar.Text = "Show sidebar"
        Me.checkboxShowSidebar.UseVisualStyleBackColor = True
        '
        'tabpageMaintenance
        '
        Me.tabpageMaintenance.Controls.Add(Me.labelTabWillBeMoved)
        Me.tabpageMaintenance.Controls.Add(Me.labelDeleteCacheFiles)
        Me.tabpageMaintenance.Controls.Add(Me.buttonDeleteCacheFiles)
        Me.tabpageMaintenance.Controls.Add(Me.labelDeleteCacheFilesInRoaming)
        Me.tabpageMaintenance.Controls.Add(Me.buttonDeleteCacheFilesInRoaming)
        Me.tabpageMaintenance.Location = New System.Drawing.Point(4, 46)
        Me.tabpageMaintenance.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpageMaintenance.Name = "tabpageMaintenance"
        Me.tabpageMaintenance.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpageMaintenance.Size = New System.Drawing.Size(453, 446)
        Me.tabpageMaintenance.TabIndex = 7
        Me.tabpageMaintenance.Text = "Maintenance"
        Me.tabpageMaintenance.UseVisualStyleBackColor = True
        '
        'labelTabWillBeMoved
        '
        Me.labelTabWillBeMoved.AutoSize = True
        Me.labelTabWillBeMoved.Location = New System.Drawing.Point(4, 420)
        Me.labelTabWillBeMoved.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTabWillBeMoved.Name = "labelTabWillBeMoved"
        Me.labelTabWillBeMoved.Size = New System.Drawing.Size(392, 17)
        Me.labelTabWillBeMoved.TabIndex = 8
        Me.labelTabWillBeMoved.Text = "A future version will move this tab to a sources manager app." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'labelDeleteCacheFiles
        '
        Me.labelDeleteCacheFiles.AutoSize = True
        Me.labelDeleteCacheFiles.Location = New System.Drawing.Point(29, 162)
        Me.labelDeleteCacheFiles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelDeleteCacheFiles.Name = "labelDeleteCacheFiles"
        Me.labelDeleteCacheFiles.Size = New System.Drawing.Size(326, 68)
        Me.labelDeleteCacheFiles.TabIndex = 7
        Me.labelDeleteCacheFiles.Text = "You can delete the cache files guinget uses with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this button if you want to have" &
    " a clean uninstall" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or if you're having issues. These files are stored in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%Loca" &
    "lAppData%."
        '
        'buttonDeleteCacheFiles
        '
        Me.buttonDeleteCacheFiles.Location = New System.Drawing.Point(8, 111)
        Me.buttonDeleteCacheFiles.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonDeleteCacheFiles.Name = "buttonDeleteCacheFiles"
        Me.buttonDeleteCacheFiles.Size = New System.Drawing.Size(330, 48)
        Me.buttonDeleteCacheFiles.TabIndex = 6
        Me.buttonDeleteCacheFiles.Text = "Delete cache files in Local AppData"
        Me.buttonDeleteCacheFiles.UseVisualStyleBackColor = True
        '
        'labelDeleteCacheFilesInRoaming
        '
        Me.labelDeleteCacheFilesInRoaming.AutoSize = True
        Me.labelDeleteCacheFilesInRoaming.Location = New System.Drawing.Point(29, 59)
        Me.labelDeleteCacheFilesInRoaming.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelDeleteCacheFilesInRoaming.Name = "labelDeleteCacheFilesInRoaming"
        Me.labelDeleteCacheFilesInRoaming.Size = New System.Drawing.Size(330, 51)
        Me.labelDeleteCacheFilesInRoaming.TabIndex = 5
        Me.labelDeleteCacheFilesInRoaming.Text = "Older versions of guinget stored their cache files in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "%AppData% instead of %Loca" &
    "lAppData%. You can" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "delete them with this button, if you wish."
        '
        'buttonDeleteCacheFilesInRoaming
        '
        Me.buttonDeleteCacheFilesInRoaming.Location = New System.Drawing.Point(8, 8)
        Me.buttonDeleteCacheFilesInRoaming.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonDeleteCacheFilesInRoaming.Name = "buttonDeleteCacheFilesInRoaming"
        Me.buttonDeleteCacheFilesInRoaming.Size = New System.Drawing.Size(330, 48)
        Me.buttonDeleteCacheFilesInRoaming.TabIndex = 4
        Me.buttonDeleteCacheFilesInRoaming.Text = "Delete cache files in Roaming"
        Me.buttonDeleteCacheFilesInRoaming.UseVisualStyleBackColor = True
        '
        'tabpageExperimental
        '
        Me.tabpageExperimental.Controls.Add(Me.panelExperimentalSettings)
        Me.tabpageExperimental.Controls.Add(Me.labelExperimentalSettingsHidden)
        Me.tabpageExperimental.Controls.Add(Me.checkboxHideUnfinishedControls)
        Me.tabpageExperimental.Controls.Add(Me.labelRequiresApplicationRestart)
        Me.tabpageExperimental.Location = New System.Drawing.Point(4, 46)
        Me.tabpageExperimental.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpageExperimental.Name = "tabpageExperimental"
        Me.tabpageExperimental.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpageExperimental.Size = New System.Drawing.Size(453, 446)
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
        Me.panelExperimentalSettings.Location = New System.Drawing.Point(4, 61)
        Me.panelExperimentalSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.panelExperimentalSettings.Name = "panelExperimentalSettings"
        Me.panelExperimentalSettings.Size = New System.Drawing.Size(442, 375)
        Me.panelExperimentalSettings.TabIndex = 4
        '
        'labelDefaultSourceNameDescription
        '
        Me.labelDefaultSourceNameDescription.AutoSize = True
        Me.labelDefaultSourceNameDescription.Location = New System.Drawing.Point(36, 304)
        Me.labelDefaultSourceNameDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelDefaultSourceNameDescription.Name = "labelDefaultSourceNameDescription"
        Me.labelDefaultSourceNameDescription.Size = New System.Drawing.Size(351, 119)
        Me.labelDefaultSourceNameDescription.TabIndex = 20
        Me.labelDefaultSourceNameDescription.Text = resources.GetString("labelDefaultSourceNameDescription.Text")
        '
        'textboxDefaultSourceName
        '
        Me.textboxDefaultSourceName.Location = New System.Drawing.Point(156, 275)
        Me.textboxDefaultSourceName.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxDefaultSourceName.Name = "textboxDefaultSourceName"
        Me.textboxDefaultSourceName.Size = New System.Drawing.Size(250, 22)
        Me.textboxDefaultSourceName.TabIndex = 19
        '
        'labelDefaultSourceName
        '
        Me.labelDefaultSourceName.AutoSize = True
        Me.labelDefaultSourceName.Location = New System.Drawing.Point(14, 279)
        Me.labelDefaultSourceName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelDefaultSourceName.Name = "labelDefaultSourceName"
        Me.labelDefaultSourceName.Size = New System.Drawing.Size(143, 17)
        Me.labelDefaultSourceName.TabIndex = 18
        Me.labelDefaultSourceName.Text = "Default source name:"
        '
        'labelHiDPIMode
        '
        Me.labelHiDPIMode.AutoSize = True
        Me.labelHiDPIMode.Location = New System.Drawing.Point(36, 219)
        Me.labelHiDPIMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelHiDPIMode.Name = "labelHiDPIMode"
        Me.labelHiDPIMode.Size = New System.Drawing.Size(389, 51)
        Me.labelHiDPIMode.TabIndex = 17
        Me.labelHiDPIMode.Text = "For now, only doubles the height of items in the package list." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "May eventually be" &
    " expanded to cover the rest of the controls" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that are difficult to use on HiDPI " &
    "devices."
        '
        'checkboxHiDPIMode
        '
        Me.checkboxHiDPIMode.AutoSize = True
        Me.checkboxHiDPIMode.Location = New System.Drawing.Point(14, 198)
        Me.checkboxHiDPIMode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.checkboxHiDPIMode.Name = "checkboxHiDPIMode"
        Me.checkboxHiDPIMode.Size = New System.Drawing.Size(104, 21)
        Me.checkboxHiDPIMode.TabIndex = 16
        Me.checkboxHiDPIMode.Text = "HiDPI Mode"
        Me.checkboxHiDPIMode.UseVisualStyleBackColor = True
        '
        'labelCopyrightForRobocopy
        '
        Me.labelCopyrightForRobocopy.AutoSize = True
        Me.labelCopyrightForRobocopy.Location = New System.Drawing.Point(36, 129)
        Me.labelCopyrightForRobocopy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCopyrightForRobocopy.Name = "labelCopyrightForRobocopy"
        Me.labelCopyrightForRobocopy.Size = New System.Drawing.Size(316, 68)
        Me.labelCopyrightForRobocopy.TabIndex = 11
        Me.labelCopyrightForRobocopy.Text = "Robocopy is Copyright (C) Microsoft Corporation." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Robocopy " &
    "may copy faster than the .NET copier," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "but it's not fully tested for this purpos" &
    "e."
        '
        'labelCopyrightForSevenZip
        '
        Me.labelCopyrightForSevenZip.AutoSize = True
        Me.labelCopyrightForSevenZip.Location = New System.Drawing.Point(32, 25)
        Me.labelCopyrightForSevenZip.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCopyrightForSevenZip.Name = "labelCopyrightForSevenZip"
        Me.labelCopyrightForSevenZip.Size = New System.Drawing.Size(312, 51)
        Me.labelCopyrightForSevenZip.TabIndex = 10
        Me.labelCopyrightForSevenZip.Text = "7-Zip is Copyright (C) Igor Pavlov." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7-Zip may extract faster than the .NET extra" &
    "ctor," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "but it's not fully tested for this purpose." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'checkboxUseRobocopy
        '
        Me.checkboxUseRobocopy.AutoSize = True
        Me.checkboxUseRobocopy.Location = New System.Drawing.Point(14, 108)
        Me.checkboxUseRobocopy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.checkboxUseRobocopy.Name = "checkboxUseRobocopy"
        Me.checkboxUseRobocopy.Size = New System.Drawing.Size(328, 21)
        Me.checkboxUseRobocopy.TabIndex = 6
        Me.checkboxUseRobocopy.Text = "Use Robocopy to copy manifests and database"
        Me.checkboxUseRobocopy.UseVisualStyleBackColor = True
        '
        'buttonBrowse7zExePath
        '
        Me.buttonBrowse7zExePath.Location = New System.Drawing.Point(314, 76)
        Me.buttonBrowse7zExePath.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonBrowse7zExePath.Name = "buttonBrowse7zExePath"
        Me.buttonBrowse7zExePath.Size = New System.Drawing.Size(94, 29)
        Me.buttonBrowse7zExePath.TabIndex = 5
        Me.buttonBrowse7zExePath.Text = "Browse..."
        Me.buttonBrowse7zExePath.UseVisualStyleBackColor = True
        '
        'textbox7zExePath
        '
        Me.textbox7zExePath.Location = New System.Drawing.Point(121, 78)
        Me.textbox7zExePath.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox7zExePath.Name = "textbox7zExePath"
        Me.textbox7zExePath.Size = New System.Drawing.Size(184, 22)
        Me.textbox7zExePath.TabIndex = 4
        '
        'label7zExePath
        '
        Me.label7zExePath.AutoSize = True
        Me.label7zExePath.Location = New System.Drawing.Point(32, 78)
        Me.label7zExePath.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7zExePath.Name = "label7zExePath"
        Me.label7zExePath.Size = New System.Drawing.Size(85, 17)
        Me.label7zExePath.TabIndex = 5
        Me.label7zExePath.Text = "7z.exe path:"
        '
        'checkboxUse7zip
        '
        Me.checkboxUse7zip.AutoSize = True
        Me.checkboxUse7zip.Location = New System.Drawing.Point(14, 4)
        Me.checkboxUse7zip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.checkboxUse7zip.Name = "checkboxUse7zip"
        Me.checkboxUse7zip.Size = New System.Drawing.Size(309, 21)
        Me.checkboxUse7zip.TabIndex = 3
        Me.checkboxUse7zip.Text = "Use 7-Zip to extract manifests and database"
        Me.checkboxUse7zip.UseVisualStyleBackColor = True
        '
        'labelExperimentalSettingsHidden
        '
        Me.labelExperimentalSettingsHidden.AutoSize = True
        Me.labelExperimentalSettingsHidden.Location = New System.Drawing.Point(99, 224)
        Me.labelExperimentalSettingsHidden.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelExperimentalSettingsHidden.Name = "labelExperimentalSettingsHidden"
        Me.labelExperimentalSettingsHidden.Size = New System.Drawing.Size(274, 17)
        Me.labelExperimentalSettingsHidden.TabIndex = 5
        Me.labelExperimentalSettingsHidden.Text = "Experimental options are currently hidden."
        '
        'checkboxHideUnfinishedControls
        '
        Me.checkboxHideUnfinishedControls.AutoSize = True
        Me.checkboxHideUnfinishedControls.Location = New System.Drawing.Point(4, 4)
        Me.checkboxHideUnfinishedControls.Margin = New System.Windows.Forms.Padding(4, 4, 4, 0)
        Me.checkboxHideUnfinishedControls.Name = "checkboxHideUnfinishedControls"
        Me.checkboxHideUnfinishedControls.Size = New System.Drawing.Size(325, 21)
        Me.checkboxHideUnfinishedControls.TabIndex = 0
        Me.checkboxHideUnfinishedControls.Text = "Hide unfinished controls and experimental stuff"
        Me.checkboxHideUnfinishedControls.UseVisualStyleBackColor = True
        '
        'labelRequiresApplicationRestart
        '
        Me.labelRequiresApplicationRestart.AutoSize = True
        Me.labelRequiresApplicationRestart.Location = New System.Drawing.Point(22, 25)
        Me.labelRequiresApplicationRestart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelRequiresApplicationRestart.Name = "labelRequiresApplicationRestart"
        Me.labelRequiresApplicationRestart.Size = New System.Drawing.Size(338, 34)
        Me.labelRequiresApplicationRestart.TabIndex = 12
        Me.labelRequiresApplicationRestart.Text = "May require application restart to take full effect." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The rest of these options s" &
    "till apply even if this is on."
        '
        'buttonCancel
        '
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonCancel.Location = New System.Drawing.Point(255, 502)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(102, 35)
        Me.buttonCancel.TabIndex = 5
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonOk
        '
        Me.buttonOk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonOk.Location = New System.Drawing.Point(361, 502)
        Me.buttonOk.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonOk.Name = "buttonOk"
        Me.buttonOk.Size = New System.Drawing.Size(102, 35)
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
        'checkboxUseKDEStyleFastResize
        '
        Me.checkboxUseKDEStyleFastResize.AutoSize = True
        Me.checkboxUseKDEStyleFastResize.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxUseKDEStyleFastResize.Location = New System.Drawing.Point(6, 21)
        Me.checkboxUseKDEStyleFastResize.Name = "checkboxUseKDEStyleFastResize"
        Me.checkboxUseKDEStyleFastResize.Size = New System.Drawing.Size(361, 55)
        Me.checkboxUseKDEStyleFastResize.TabIndex = 1
        Me.checkboxUseKDEStyleFastResize.Text = "Use KDE-style fast resize for the package list so that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "resizing the window is sm" &
    "ooth when there are a lot" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of packages listed"
        Me.checkboxUseKDEStyleFastResize.UseVisualStyleBackColor = True
        '
        'groupboxPackageList
        '
        Me.groupboxPackageList.Controls.Add(Me.checkboxUseKDEStyleFastResize)
        Me.groupboxPackageList.Location = New System.Drawing.Point(7, 103)
        Me.groupboxPackageList.Name = "groupboxPackageList"
        Me.groupboxPackageList.Size = New System.Drawing.Size(439, 90)
        Me.groupboxPackageList.TabIndex = 2
        Me.groupboxPackageList.TabStop = False
        Me.groupboxPackageList.Text = "Package list"
        '
        'groupboxPackageDetails
        '
        Me.groupboxPackageDetails.Controls.Add(Me.checkboxLastSelectedPackageDetails)
        Me.groupboxPackageDetails.Location = New System.Drawing.Point(7, 7)
        Me.groupboxPackageDetails.Name = "groupboxPackageDetails"
        Me.groupboxPackageDetails.Size = New System.Drawing.Size(439, 90)
        Me.groupboxPackageDetails.TabIndex = 3
        Me.groupboxPackageDetails.TabStop = False
        Me.groupboxPackageDetails.Text = "Package details"
        '
        'OptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(465, 539)
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
        Me.tabpageApplyChanges.ResumeLayout(False)
        Me.tabpageApplyChanges.PerformLayout()
        Me.tabpageLayout.ResumeLayout(False)
        Me.tabpageLayout.PerformLayout()
        Me.tabpageMaintenance.ResumeLayout(False)
        Me.tabpageMaintenance.PerformLayout()
        Me.tabpageExperimental.ResumeLayout(False)
        Me.tabpageExperimental.PerformLayout()
        Me.panelExperimentalSettings.ResumeLayout(False)
        Me.panelExperimentalSettings.PerformLayout()
        Me.groupboxPackageList.ResumeLayout(False)
        Me.groupboxPackageList.PerformLayout()
        Me.groupboxPackageDetails.ResumeLayout(False)
        Me.groupboxPackageDetails.PerformLayout()
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
    Friend WithEvents labelWaitTime As Label
    Friend WithEvents numericupdownSearchWhenTypingWaitTime As NumericUpDown
    Friend WithEvents checkboxSearchWhenTyping As CheckBox
    Friend WithEvents tabpageAppsUIs As TabPage
    Friend WithEvents labelAppsListUI As Label
    Friend WithEvents comboboxAppsListUI As ComboBox
    Friend WithEvents labelAutomaticControlPanelFallback As Label
    Friend WithEvents tabpageMaintenance As TabPage
    Friend WithEvents labelDeleteCacheFilesInRoaming As Label
    Friend WithEvents buttonDeleteCacheFilesInRoaming As Button
    Friend WithEvents labelDeleteCacheFiles As Label
    Friend WithEvents buttonDeleteCacheFiles As Button
    Friend WithEvents labelTabWillBeMoved As Label
    Friend WithEvents checkboxOpenMiniOptions As CheckBox
    Friend WithEvents labelAboutNotSpecifyingVersionNumbers As Label
    Friend WithEvents labelSpecifyVersionNumberHeading As Label
    Friend WithEvents checkboxWhenInstalling As CheckBox
    Friend WithEvents checkboxWhenUpgrading As CheckBox
    Friend WithEvents checkboxWhenUninstalling As CheckBox
    Friend WithEvents labelLoadLatestVersion As Label
    Friend WithEvents checkboxShowOnlyLatestVersions As CheckBox
    Friend WithEvents checkboxUseKDEStyleFastResize As CheckBox
    Friend WithEvents groupboxPackageDetails As GroupBox
    Friend WithEvents groupboxPackageList As GroupBox
End Class
