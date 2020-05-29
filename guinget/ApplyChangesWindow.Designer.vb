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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PackageCurrentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datagridviewAppsBeingInstalled = New System.Windows.Forms.DataGridView()
        Me.tablelayoutpanelApplyChanges.SuspendLayout()
        CType(Me.datagridviewAppsBeingInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablelayoutpanelApplyChanges
        '
        Me.tablelayoutpanelApplyChanges.ColumnCount = 3
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.datagridviewAppsBeingInstalled, 0, 0)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.Button1, 2, 1)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.Button2, 1, 1)
        Me.tablelayoutpanelApplyChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelApplyChanges.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelApplyChanges.Name = "tablelayoutpanelApplyChanges"
        Me.tablelayoutpanelApplyChanges.RowCount = 2
        Me.tablelayoutpanelApplyChanges.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelApplyChanges.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tablelayoutpanelApplyChanges.Size = New System.Drawing.Size(690, 450)
        Me.tablelayoutpanelApplyChanges.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(613, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(533, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 34)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PackageCurrentStatus
        '
        Me.PackageCurrentStatus.HeaderText = "Current status"
        Me.PackageCurrentStatus.MinimumWidth = 6
        Me.PackageCurrentStatus.Name = "PackageCurrentStatus"
        Me.PackageCurrentStatus.ReadOnly = True
        '
        'PackageAction
        '
        Me.PackageAction.HeaderText = "Action"
        Me.PackageAction.MinimumWidth = 6
        Me.PackageAction.Name = "PackageAction"
        Me.PackageAction.ReadOnly = True
        '
        'PackageName
        '
        Me.PackageName.HeaderText = "Package"
        Me.PackageName.MinimumWidth = 6
        Me.PackageName.Name = "PackageName"
        Me.PackageName.ReadOnly = True
        '
        'datagridviewAppsBeingInstalled
        '
        Me.datagridviewAppsBeingInstalled.AllowUserToAddRows = False
        Me.datagridviewAppsBeingInstalled.AllowUserToDeleteRows = False
        Me.datagridviewAppsBeingInstalled.AllowUserToOrderColumns = True
        Me.datagridviewAppsBeingInstalled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridviewAppsBeingInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewAppsBeingInstalled.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackageName, Me.PackageAction, Me.PackageCurrentStatus})
        Me.tablelayoutpanelApplyChanges.SetColumnSpan(Me.datagridviewAppsBeingInstalled, 3)
        Me.datagridviewAppsBeingInstalled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAppsBeingInstalled.Location = New System.Drawing.Point(3, 3)
        Me.datagridviewAppsBeingInstalled.Name = "datagridviewAppsBeingInstalled"
        Me.datagridviewAppsBeingInstalled.ReadOnly = True
        Me.datagridviewAppsBeingInstalled.RowHeadersVisible = False
        Me.datagridviewAppsBeingInstalled.RowHeadersWidth = 51
        Me.datagridviewAppsBeingInstalled.RowTemplate.Height = 24
        Me.datagridviewAppsBeingInstalled.Size = New System.Drawing.Size(684, 404)
        Me.datagridviewAppsBeingInstalled.TabIndex = 0
        '
        'ApplyChangesWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 450)
        Me.Controls.Add(Me.tablelayoutpanelApplyChanges)
        Me.Name = "ApplyChangesWindow"
        Me.Text = "ApplyChangesWindow"
        Me.tablelayoutpanelApplyChanges.ResumeLayout(False)
        CType(Me.datagridviewAppsBeingInstalled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tablelayoutpanelApplyChanges As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents datagridviewAppsBeingInstalled As DataGridView
    Friend WithEvents PackageName As DataGridViewTextBoxColumn
    Friend WithEvents PackageAction As DataGridViewTextBoxColumn
    Friend WithEvents PackageCurrentStatus As DataGridViewTextBoxColumn
End Class
