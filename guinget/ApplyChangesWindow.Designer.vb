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
        Me.tablelayoutpanelApplyChanges = New System.Windows.Forms.TableLayoutPanel()
        Me.datagridviewAppsBeingInstalled = New System.Windows.Forms.DataGridView()
        Me.PackageName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageCurrentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonConfirmChanges = New System.Windows.Forms.Button()
        Me.tablelayoutpanelApplyChanges.SuspendLayout()
        CType(Me.datagridviewAppsBeingInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablelayoutpanelApplyChanges
        '
        Me.tablelayoutpanelApplyChanges.ColumnCount = 3
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.datagridviewAppsBeingInstalled, 0, 0)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.buttonCancel, 2, 1)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.buttonConfirmChanges, 1, 1)
        Me.tablelayoutpanelApplyChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelApplyChanges.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelApplyChanges.Name = "tablelayoutpanelApplyChanges"
        Me.tablelayoutpanelApplyChanges.RowCount = 2
        Me.tablelayoutpanelApplyChanges.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelApplyChanges.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tablelayoutpanelApplyChanges.Size = New System.Drawing.Size(690, 450)
        Me.tablelayoutpanelApplyChanges.TabIndex = 0
        '
        'datagridviewAppsBeingInstalled
        '
        Me.datagridviewAppsBeingInstalled.AllowUserToAddRows = False
        Me.datagridviewAppsBeingInstalled.AllowUserToDeleteRows = False
        Me.datagridviewAppsBeingInstalled.AllowUserToOrderColumns = True
        Me.datagridviewAppsBeingInstalled.AllowUserToResizeRows = False
        Me.datagridviewAppsBeingInstalled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridviewAppsBeingInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAppsBeingInstalled.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackageName, Me.PackageVersion, Me.PackageAction, Me.PackageCurrentStatus})
        Me.tablelayoutpanelApplyChanges.SetColumnSpan(Me.datagridviewAppsBeingInstalled, 3)
        Me.datagridviewAppsBeingInstalled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAppsBeingInstalled.Location = New System.Drawing.Point(3, 3)
        Me.datagridviewAppsBeingInstalled.Name = "datagridviewAppsBeingInstalled"
        Me.datagridviewAppsBeingInstalled.ReadOnly = True
        Me.datagridviewAppsBeingInstalled.RowHeadersVisible = False
        Me.datagridviewAppsBeingInstalled.RowHeadersWidth = 51
        Me.datagridviewAppsBeingInstalled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAppsBeingInstalled.RowTemplate.Height = 24
        Me.datagridviewAppsBeingInstalled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAppsBeingInstalled.Size = New System.Drawing.Size(684, 404)
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
        Me.PackageAction.HeaderText = "Action"
        Me.PackageAction.MinimumWidth = 6
        Me.PackageAction.Name = "PackageAction"
        Me.PackageAction.ReadOnly = True
        '
        'PackageCurrentStatus
        '
        Me.PackageCurrentStatus.HeaderText = "Current status"
        Me.PackageCurrentStatus.MinimumWidth = 6
        Me.PackageCurrentStatus.Name = "PackageCurrentStatus"
        Me.PackageCurrentStatus.ReadOnly = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonCancel.Location = New System.Drawing.Point(573, 413)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(114, 34)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonConfirmChanges
        '
        Me.buttonConfirmChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonConfirmChanges.Location = New System.Drawing.Point(433, 413)
        Me.buttonConfirmChanges.Name = "buttonConfirmChanges"
        Me.buttonConfirmChanges.Size = New System.Drawing.Size(134, 34)
        Me.buttonConfirmChanges.TabIndex = 2
        Me.buttonConfirmChanges.Text = "Confirm changes"
        Me.buttonConfirmChanges.UseVisualStyleBackColor = True
        '
        'ApplyChangesWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 450)
        Me.Controls.Add(Me.tablelayoutpanelApplyChanges)
        Me.Name = "ApplyChangesWindow"
        Me.Text = "Apply changes"
        Me.tablelayoutpanelApplyChanges.ResumeLayout(False)
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
End Class
