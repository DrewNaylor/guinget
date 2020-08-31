<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsWindow
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
        Me.tablelayoutpanelOptions = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonDefaults = New System.Windows.Forms.Button()
        Me.buttonOk = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.tabcontrolOptions = New System.Windows.Forms.TabControl()
        Me.tabpageSearch = New System.Windows.Forms.TabPage()
        Me.tablelayoutpanelOptions.SuspendLayout()
        Me.tabcontrolOptions.SuspendLayout()
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
        Me.tablelayoutpanelOptions.Controls.Add(Me.buttonCancel, 3, 1)
        Me.tablelayoutpanelOptions.Controls.Add(Me.buttonOk, 2, 1)
        Me.tablelayoutpanelOptions.Controls.Add(Me.tabcontrolOptions, 0, 0)
        Me.tablelayoutpanelOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelOptions.Location = New System.Drawing.Point(0, 0)
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
        Me.buttonDefaults.Location = New System.Drawing.Point(3, 503)
        Me.buttonDefaults.Name = "buttonDefaults"
        Me.buttonDefaults.Size = New System.Drawing.Size(100, 33)
        Me.buttonDefaults.TabIndex = 1
        Me.buttonDefaults.Text = "Defaults"
        Me.buttonDefaults.UseVisualStyleBackColor = True
        '
        'buttonOk
        '
        Me.buttonOk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonOk.Location = New System.Drawing.Point(256, 503)
        Me.buttonOk.Name = "buttonOk"
        Me.buttonOk.Size = New System.Drawing.Size(100, 33)
        Me.buttonOk.TabIndex = 4
        Me.buttonOk.Text = "OK"
        Me.buttonOk.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonCancel.Location = New System.Drawing.Point(362, 503)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(100, 33)
        Me.buttonCancel.TabIndex = 5
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'tabcontrolOptions
        '
        Me.tablelayoutpanelOptions.SetColumnSpan(Me.tabcontrolOptions, 4)
        Me.tabcontrolOptions.Controls.Add(Me.tabpageSearch)
        Me.tabcontrolOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolOptions.Location = New System.Drawing.Point(3, 3)
        Me.tabcontrolOptions.Name = "tabcontrolOptions"
        Me.tabcontrolOptions.SelectedIndex = 0
        Me.tabcontrolOptions.Size = New System.Drawing.Size(459, 494)
        Me.tabcontrolOptions.TabIndex = 6
        '
        'tabpageSearch
        '
        Me.tabpageSearch.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSearch.Name = "tabpageSearch"
        Me.tabpageSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageSearch.Size = New System.Drawing.Size(451, 465)
        Me.tabpageSearch.TabIndex = 0
        Me.tabpageSearch.Text = "Search"
        Me.tabpageSearch.UseVisualStyleBackColor = True
        '
        'OptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(465, 539)
        Me.Controls.Add(Me.tablelayoutpanelOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.tablelayoutpanelOptions.ResumeLayout(False)
        Me.tabcontrolOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tablelayoutpanelOptions As TableLayoutPanel
    Friend WithEvents buttonDefaults As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonOk As Button
    Friend WithEvents tabcontrolOptions As TabControl
    Friend WithEvents tabpageSearch As TabPage
End Class
