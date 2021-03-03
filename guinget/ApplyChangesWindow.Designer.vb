<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ApplyChangesWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApplyChangesWindow))
        Me.tablelayoutpanelApplyChanges = New System.Windows.Forms.TableLayoutPanel()
        Me.datagridviewAppsBeingInstalled = New System.Windows.Forms.DataGridView()
        Me.PackageName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageCurrentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonConfirmChanges = New System.Windows.Forms.Button()
        Me.checkboxInstallInteractively = New System.Windows.Forms.CheckBox()
        Me.checkboxElevateWinget = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.tooltipInstallOptions = New System.Windows.Forms.ToolTip(Me.components)
        Me.tablelayoutpanelApplyChanges.SuspendLayout()
        CType(Me.datagridviewAppsBeingInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablelayoutpanelApplyChanges
        '
        Me.tablelayoutpanelApplyChanges.ColumnCount = 5
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.datagridviewAppsBeingInstalled, 0, 0)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.buttonCancel, 4, 1)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.buttonConfirmChanges, 3, 1)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.checkboxInstallInteractively, 0, 1)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.checkboxElevateWinget, 1, 1)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.LinkLabel1, 2, 1)
        Me.tablelayoutpanelApplyChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelApplyChanges.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelApplyChanges.Margin = New System.Windows.Forms.Padding(2)
        Me.tablelayoutpanelApplyChanges.Name = "tablelayoutpanelApplyChanges"
        Me.tablelayoutpanelApplyChanges.RowCount = 2
        Me.tablelayoutpanelApplyChanges.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelApplyChanges.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tablelayoutpanelApplyChanges.Size = New System.Drawing.Size(630, 373)
        Me.tablelayoutpanelApplyChanges.TabIndex = 0
        '
        'datagridviewAppsBeingInstalled
        '
        Me.datagridviewAppsBeingInstalled.AllowUserToAddRows = False
        Me.datagridviewAppsBeingInstalled.AllowUserToDeleteRows = False
        Me.datagridviewAppsBeingInstalled.AllowUserToOrderColumns = True
        Me.datagridviewAppsBeingInstalled.AllowUserToResizeRows = False
        Me.datagridviewAppsBeingInstalled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridviewAppsBeingInstalled.BackgroundColor = System.Drawing.SystemColors.Window
        Me.datagridviewAppsBeingInstalled.ColumnHeadersHeight = 29
        Me.datagridviewAppsBeingInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridviewAppsBeingInstalled.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackageName, Me.PackageVersion, Me.PackageAction, Me.PackageCurrentStatus})
        Me.tablelayoutpanelApplyChanges.SetColumnSpan(Me.datagridviewAppsBeingInstalled, 5)
        Me.datagridviewAppsBeingInstalled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAppsBeingInstalled.Location = New System.Drawing.Point(2, 2)
        Me.datagridviewAppsBeingInstalled.Margin = New System.Windows.Forms.Padding(2)
        Me.datagridviewAppsBeingInstalled.MultiSelect = False
        Me.datagridviewAppsBeingInstalled.Name = "datagridviewAppsBeingInstalled"
        Me.datagridviewAppsBeingInstalled.ReadOnly = True
        Me.datagridviewAppsBeingInstalled.RowHeadersVisible = False
        Me.datagridviewAppsBeingInstalled.RowHeadersWidth = 51
        Me.datagridviewAppsBeingInstalled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAppsBeingInstalled.RowTemplate.Height = 24
        Me.datagridviewAppsBeingInstalled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAppsBeingInstalled.Size = New System.Drawing.Size(626, 337)
        Me.datagridviewAppsBeingInstalled.StandardTab = True
        Me.datagridviewAppsBeingInstalled.TabIndex = 0
        '
        'PackageName
        '
        Me.PackageName.HeaderText = "Package"
        Me.PackageName.MinimumWidth = 6
        Me.PackageName.Name = "PackageName"
        Me.PackageName.ReadOnly = True
        '
        'PackageVersion
        '
        Me.PackageVersion.HeaderText = "Version"
        Me.PackageVersion.MinimumWidth = 6
        Me.PackageVersion.Name = "PackageVersion"
        Me.PackageVersion.ReadOnly = True
        '
        'PackageAction
        '
        Me.PackageAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PackageAction.HeaderText = "Action"
        Me.PackageAction.MinimumWidth = 6
        Me.PackageAction.Name = "PackageAction"
        Me.PackageAction.ReadOnly = True
        Me.PackageAction.Width = 62
        '
        'PackageCurrentStatus
        '
        Me.PackageCurrentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PackageCurrentStatus.HeaderText = "Current status"
        Me.PackageCurrentStatus.MinimumWidth = 6
        Me.PackageCurrentStatus.Name = "PackageCurrentStatus"
        Me.PackageCurrentStatus.ReadOnly = True
        Me.PackageCurrentStatus.Width = 97
        '
        'buttonCancel
        '
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonCancel.Location = New System.Drawing.Point(542, 343)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(86, 28)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Close"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonConfirmChanges
        '
        Me.buttonConfirmChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonConfirmChanges.Location = New System.Drawing.Point(437, 343)
        Me.buttonConfirmChanges.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonConfirmChanges.Name = "buttonConfirmChanges"
        Me.buttonConfirmChanges.Size = New System.Drawing.Size(101, 28)
        Me.buttonConfirmChanges.TabIndex = 2
        Me.buttonConfirmChanges.Text = "Confirm changes"
        Me.buttonConfirmChanges.UseVisualStyleBackColor = True
        '
        'checkboxInstallInteractively
        '
        Me.checkboxInstallInteractively.AutoSize = True
        Me.checkboxInstallInteractively.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkboxInstallInteractively.Location = New System.Drawing.Point(2, 343)
        Me.checkboxInstallInteractively.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxInstallInteractively.Name = "checkboxInstallInteractively"
        Me.checkboxInstallInteractively.Size = New System.Drawing.Size(119, 28)
        Me.checkboxInstallInteractively.TabIndex = 4
        Me.checkboxInstallInteractively.Text = "Run interactively (-i)"
        Me.tooltipInstallOptions.SetToolTip(Me.checkboxInstallInteractively, "winget will be run interactively when checked.")
        Me.checkboxInstallInteractively.UseVisualStyleBackColor = True
        '
        'checkboxElevateWinget
        '
        Me.checkboxElevateWinget.AutoSize = True
        Me.checkboxElevateWinget.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkboxElevateWinget.Location = New System.Drawing.Point(126, 344)
        Me.checkboxElevateWinget.Name = "checkboxElevateWinget"
        Me.checkboxElevateWinget.Size = New System.Drawing.Size(127, 26)
        Me.checkboxElevateWinget.TabIndex = 3
        Me.checkboxElevateWinget.Text = "Elevate winget (UAC)"
        Me.tooltipInstallOptions.SetToolTip(Me.checkboxElevateWinget, resources.GetString("checkboxElevateWinget.ToolTip"))
        Me.checkboxElevateWinget.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(259, 341)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        Me.LinkLabel1.Visible = False
        '
        'tooltipInstallOptions
        '
        Me.tooltipInstallOptions.AutoPopDelay = 10000
        Me.tooltipInstallOptions.InitialDelay = 500
        Me.tooltipInstallOptions.ReshowDelay = 100
        '
        'ApplyChangesWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(630, 373)
        Me.Controls.Add(Me.tablelayoutpanelApplyChanges)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeBox = False
        Me.Name = "ApplyChangesWindow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Apply changes"
        Me.tablelayoutpanelApplyChanges.ResumeLayout(False)
        Me.tablelayoutpanelApplyChanges.PerformLayout()
        CType(Me.datagridviewAppsBeingInstalled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tablelayoutpanelApplyChanges As TableLayoutPanel
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonConfirmChanges As Button
    Friend WithEvents datagridviewAppsBeingInstalled As DataGridView
    Friend WithEvents PackageName As DataGridViewTextBoxColumn
    Friend WithEvents PackageVersion As DataGridViewTextBoxColumn
    Friend WithEvents PackageAction As DataGridViewTextBoxColumn
    Friend WithEvents PackageCurrentStatus As DataGridViewTextBoxColumn
    Friend WithEvents checkboxInstallInteractively As CheckBox
    Friend WithEvents tooltipInstallOptions As ToolTip
    Friend WithEvents checkboxElevateWinget As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
