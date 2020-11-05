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
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonOk = New System.Windows.Forms.Button()
        Me.tabpageLayout = New System.Windows.Forms.TabPage()
        Me.checkboxShowSidebar = New System.Windows.Forms.CheckBox()
        Me.tabpageApplyChanges = New System.Windows.Forms.TabPage()
        Me.checkboxInstallInteractively = New System.Windows.Forms.CheckBox()
        Me.checkboxElevateWinget = New System.Windows.Forms.CheckBox()
        Me.tabpageSearch = New System.Windows.Forms.TabPage()
        Me.checkboxRerunSearch = New System.Windows.Forms.CheckBox()
        Me.checkboxUseExactMatchForLastSelectedPackageIDSearch = New System.Windows.Forms.CheckBox()
        Me.tabpagePackageDetails = New System.Windows.Forms.TabPage()
        Me.checkboxLastSelectedPackageDetails = New System.Windows.Forms.CheckBox()
        Me.tabcontrolOptions = New System.Windows.Forms.TabControl()
        Me.tabpageRefreshCache = New System.Windows.Forms.TabPage()
        Me.checkboxLoadFromDatabase = New System.Windows.Forms.CheckBox()
        Me.labelLoadFromManifests = New System.Windows.Forms.Label()
        Me.checkboxShowOnlyLatestVersions = New System.Windows.Forms.CheckBox()
        Me.labelLoadLatestVersion = New System.Windows.Forms.Label()
        Me.panelExperimentalSettings = New System.Windows.Forms.Panel()
        Me.labelExperimentalSettingsHidden = New System.Windows.Forms.Label()
        Me.checkboxUse7zip = New System.Windows.Forms.CheckBox()
        Me.label7zExePath = New System.Windows.Forms.Label()
        Me.textbox7zExePath = New System.Windows.Forms.TextBox()
        Me.buttonBrowse7zExePath = New System.Windows.Forms.Button()
        Me.checkboxUseRobocopy = New System.Windows.Forms.CheckBox()
        Me.checkboxHideUnfinishedControls = New System.Windows.Forms.CheckBox()
        Me.tablelayoutpanelOptions.SuspendLayout()
        Me.tabpageLayout.SuspendLayout()
        Me.tabpageApplyChanges.SuspendLayout()
        Me.tabpageSearch.SuspendLayout()
        Me.tabpagePackageDetails.SuspendLayout()
        Me.tabcontrolOptions.SuspendLayout()
        Me.tabpageRefreshCache.SuspendLayout()
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
        'tabpageApplyChanges
        '
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
        'checkboxElevateWinget
        '
        Me.checkboxElevateWinget.AutoSize = True
        Me.checkboxElevateWinget.Location = New System.Drawing.Point(6, 29)
        Me.checkboxElevateWinget.Name = "checkboxElevateWinget"
        Me.checkboxElevateWinget.Size = New System.Drawing.Size(143, 17)
        Me.checkboxElevateWinget.TabIndex = 1
        Me.checkboxElevateWinget.Text = "Elevate winget with UAC"
        Me.checkboxElevateWinget.UseVisualStyleBackColor = True
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
        'checkboxLoadFromDatabase
        '
        Me.checkboxLoadFromDatabase.AutoSize = True
        Me.checkboxLoadFromDatabase.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxLoadFromDatabase.Location = New System.Drawing.Point(3, 3)
        Me.checkboxLoadFromDatabase.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxLoadFromDatabase.Name = "checkboxLoadFromDatabase"
        Me.checkboxLoadFromDatabase.Size = New System.Drawing.Size(298, 30)
        Me.checkboxLoadFromDatabase.TabIndex = 0
        Me.checkboxLoadFromDatabase.Text = "(Experimental) Update and load package list from winget's" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "default community data" &
    "base"
        Me.checkboxLoadFromDatabase.UseVisualStyleBackColor = True
        '
        'labelLoadFromManifests
        '
        Me.labelLoadFromManifests.AutoSize = True
        Me.labelLoadFromManifests.Location = New System.Drawing.Point(18, 33)
        Me.labelLoadFromManifests.Name = "labelLoadFromManifests"
        Me.labelLoadFromManifests.Size = New System.Drawing.Size(196, 13)
        Me.labelLoadFromManifests.TabIndex = 1
        Me.labelLoadFromManifests.Text = "Details will still be loaded from manifests."
        '
        'checkboxShowOnlyLatestVersions
        '
        Me.checkboxShowOnlyLatestVersions.AutoSize = True
        Me.checkboxShowOnlyLatestVersions.Location = New System.Drawing.Point(3, 50)
        Me.checkboxShowOnlyLatestVersions.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxShowOnlyLatestVersions.Name = "checkboxShowOnlyLatestVersions"
        Me.checkboxShowOnlyLatestVersions.Size = New System.Drawing.Size(308, 17)
        Me.checkboxShowOnlyLatestVersions.TabIndex = 2
        Me.checkboxShowOnlyLatestVersions.Text = "(Experimental) Load only the latest version of each package"
        Me.checkboxShowOnlyLatestVersions.UseVisualStyleBackColor = True
        '
        'labelLoadLatestVersion
        '
        Me.labelLoadLatestVersion.AutoSize = True
        Me.labelLoadLatestVersion.Location = New System.Drawing.Point(18, 67)
        Me.labelLoadLatestVersion.Name = "labelLoadLatestVersion"
        Me.labelLoadLatestVersion.Size = New System.Drawing.Size(293, 26)
        Me.labelLoadLatestVersion.TabIndex = 3
        Me.labelLoadLatestVersion.Text = "Some packages will display a version number that's not really" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the latest version" &
    ". Not sure how to fix this at the moment."
        '
        'panelExperimentalSettings
        '
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
        'labelExperimentalSettingsHidden
        '
        Me.labelExperimentalSettingsHidden.AutoSize = True
        Me.labelExperimentalSettingsHidden.Location = New System.Drawing.Point(66, 166)
        Me.labelExperimentalSettingsHidden.Name = "labelExperimentalSettingsHidden"
        Me.labelExperimentalSettingsHidden.Size = New System.Drawing.Size(228, 39)
        Me.labelExperimentalSettingsHidden.TabIndex = 5
        Me.labelExperimentalSettingsHidden.Text = "Experimental settings are currently hidden." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can show them by clicking in the" &
    " lower-left" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "corner of the About window."
        '
        'checkboxUse7zip
        '
        Me.checkboxUse7zip.AutoSize = True
        Me.checkboxUse7zip.Location = New System.Drawing.Point(3, 97)
        Me.checkboxUse7zip.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxUse7zip.Name = "checkboxUse7zip"
        Me.checkboxUse7zip.Size = New System.Drawing.Size(303, 17)
        Me.checkboxUse7zip.TabIndex = 4
        Me.checkboxUse7zip.Text = "(Experimental) Use 7-Zip to extract manifests and database"
        Me.checkboxUse7zip.UseVisualStyleBackColor = True
        '
        'label7zExePath
        '
        Me.label7zExePath.AutoSize = True
        Me.label7zExePath.Location = New System.Drawing.Point(19, 118)
        Me.label7zExePath.Name = "label7zExePath"
        Me.label7zExePath.Size = New System.Drawing.Size(65, 13)
        Me.label7zExePath.TabIndex = 5
        Me.label7zExePath.Text = "7z.exe path:"
        '
        'textbox7zExePath
        '
        Me.textbox7zExePath.Location = New System.Drawing.Point(90, 114)
        Me.textbox7zExePath.Name = "textbox7zExePath"
        Me.textbox7zExePath.Size = New System.Drawing.Size(148, 20)
        Me.textbox7zExePath.TabIndex = 6
        '
        'buttonBrowse7zExePath
        '
        Me.buttonBrowse7zExePath.Location = New System.Drawing.Point(244, 113)
        Me.buttonBrowse7zExePath.Name = "buttonBrowse7zExePath"
        Me.buttonBrowse7zExePath.Size = New System.Drawing.Size(75, 23)
        Me.buttonBrowse7zExePath.TabIndex = 7
        Me.buttonBrowse7zExePath.Text = "Browse..."
        Me.buttonBrowse7zExePath.UseVisualStyleBackColor = True
        '
        'checkboxUseRobocopy
        '
        Me.checkboxUseRobocopy.AutoSize = True
        Me.checkboxUseRobocopy.Location = New System.Drawing.Point(3, 135)
        Me.checkboxUseRobocopy.Name = "checkboxUseRobocopy"
        Me.checkboxUseRobocopy.Size = New System.Drawing.Size(319, 17)
        Me.checkboxUseRobocopy.TabIndex = 8
        Me.checkboxUseRobocopy.Text = "(Experimental) Use Robocopy to copy manifests and database"
        Me.checkboxUseRobocopy.UseVisualStyleBackColor = True
        '
        'checkboxHideUnfinishedControls
        '
        Me.checkboxHideUnfinishedControls.AutoSize = True
        Me.checkboxHideUnfinishedControls.Location = New System.Drawing.Point(3, 159)
        Me.checkboxHideUnfinishedControls.Name = "checkboxHideUnfinishedControls"
        Me.checkboxHideUnfinishedControls.Size = New System.Drawing.Size(139, 17)
        Me.checkboxHideUnfinishedControls.TabIndex = 9
        Me.checkboxHideUnfinishedControls.Text = "Hide unfinished controls"
        Me.checkboxHideUnfinishedControls.UseVisualStyleBackColor = True
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
        Me.tabpageLayout.ResumeLayout(False)
        Me.tabpageLayout.PerformLayout()
        Me.tabpageApplyChanges.ResumeLayout(False)
        Me.tabpageApplyChanges.PerformLayout()
        Me.tabpageSearch.ResumeLayout(False)
        Me.tabpageSearch.PerformLayout()
        Me.tabpagePackageDetails.ResumeLayout(False)
        Me.tabpagePackageDetails.PerformLayout()
        Me.tabcontrolOptions.ResumeLayout(False)
        Me.tabpageRefreshCache.ResumeLayout(False)
        Me.tabpageRefreshCache.PerformLayout()
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
End Class
