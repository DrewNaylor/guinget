<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutWindow
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
        Me.tablelayoutpanelAbout = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.textboxAbout = New System.Windows.Forms.TextBox()
        Me.labelShowHiddenControls = New System.Windows.Forms.Label()
        Me.tablelayoutpanelAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'tablelayoutpanelAbout
        '
        Me.tablelayoutpanelAbout.ColumnCount = 3
        Me.tablelayoutpanelAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.tablelayoutpanelAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.tablelayoutpanelAbout.Controls.Add(Me.OK_Button, 2, 1)
        Me.tablelayoutpanelAbout.Controls.Add(Me.textboxAbout, 0, 0)
        Me.tablelayoutpanelAbout.Controls.Add(Me.labelShowHiddenControls, 0, 1)
        Me.tablelayoutpanelAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelAbout.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelAbout.Name = "tablelayoutpanelAbout"
        Me.tablelayoutpanelAbout.RowCount = 2
        Me.tablelayoutpanelAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tablelayoutpanelAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tablelayoutpanelAbout.Size = New System.Drawing.Size(529, 368)
        Me.tablelayoutpanelAbout.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.Location = New System.Drawing.Point(451, 340)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 25)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'textboxAbout
        '
        Me.tablelayoutpanelAbout.SetColumnSpan(Me.textboxAbout, 3)
        Me.textboxAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxAbout.Location = New System.Drawing.Point(3, 3)
        Me.textboxAbout.Multiline = True
        Me.textboxAbout.Name = "textboxAbout"
        Me.textboxAbout.ReadOnly = True
        Me.textboxAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxAbout.Size = New System.Drawing.Size(523, 331)
        Me.textboxAbout.TabIndex = 1
        '
        'labelShowHiddenControls
        '
        Me.labelShowHiddenControls.AutoSize = True
        Me.labelShowHiddenControls.BackColor = System.Drawing.Color.Transparent
        Me.labelShowHiddenControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelShowHiddenControls.ForeColor = System.Drawing.SystemColors.Control
        Me.labelShowHiddenControls.Location = New System.Drawing.Point(3, 337)
        Me.labelShowHiddenControls.Name = "labelShowHiddenControls"
        Me.labelShowHiddenControls.Size = New System.Drawing.Size(112, 31)
        Me.labelShowHiddenControls.TabIndex = 2
        '
        'AboutWindow
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.OK_Button
        Me.ClientSize = New System.Drawing.Size(529, 368)
        Me.Controls.Add(Me.tablelayoutpanelAbout)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutWindow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About guinget"
        Me.tablelayoutpanelAbout.ResumeLayout(False)
        Me.tablelayoutpanelAbout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tablelayoutpanelAbout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents textboxAbout As TextBox
    Friend WithEvents labelShowHiddenControls As Label
End Class
