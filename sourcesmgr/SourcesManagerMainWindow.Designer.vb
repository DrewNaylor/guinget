<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformMainWindow
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabpageWinget = New System.Windows.Forms.TabPage()
        Me.tabpageGuingetAndOtherFrontends = New System.Windows.Forms.TabPage()
        Me.tabpageMaintenance = New System.Windows.Forms.TabPage()
        Me.tabpageAbout = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabpageWinget)
        Me.TabControl1.Controls.Add(Me.tabpageGuingetAndOtherFrontends)
        Me.TabControl1.Controls.Add(Me.tabpageMaintenance)
        Me.TabControl1.Controls.Add(Me.tabpageAbout)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(594, 409)
        Me.TabControl1.TabIndex = 0
        '
        'tabpageWinget
        '
        Me.tabpageWinget.Location = New System.Drawing.Point(4, 22)
        Me.tabpageWinget.Name = "tabpageWinget"
        Me.tabpageWinget.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageWinget.Size = New System.Drawing.Size(586, 383)
        Me.tabpageWinget.TabIndex = 0
        Me.tabpageWinget.Text = "Sources: winget"
        Me.tabpageWinget.UseVisualStyleBackColor = True
        '
        'tabpageGuingetAndOtherFrontends
        '
        Me.tabpageGuingetAndOtherFrontends.Location = New System.Drawing.Point(4, 22)
        Me.tabpageGuingetAndOtherFrontends.Name = "tabpageGuingetAndOtherFrontends"
        Me.tabpageGuingetAndOtherFrontends.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGuingetAndOtherFrontends.Size = New System.Drawing.Size(586, 383)
        Me.tabpageGuingetAndOtherFrontends.TabIndex = 1
        Me.tabpageGuingetAndOtherFrontends.Text = "Sources: guinget+compatible frontends"
        Me.tabpageGuingetAndOtherFrontends.UseVisualStyleBackColor = True
        '
        'tabpageMaintenance
        '
        Me.tabpageMaintenance.Location = New System.Drawing.Point(4, 22)
        Me.tabpageMaintenance.Name = "tabpageMaintenance"
        Me.tabpageMaintenance.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageMaintenance.Size = New System.Drawing.Size(586, 383)
        Me.tabpageMaintenance.TabIndex = 2
        Me.tabpageMaintenance.Text = "Maintenance"
        Me.tabpageMaintenance.UseVisualStyleBackColor = True
        '
        'tabpageAbout
        '
        Me.tabpageAbout.Location = New System.Drawing.Point(4, 22)
        Me.tabpageAbout.Name = "tabpageAbout"
        Me.tabpageAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAbout.Size = New System.Drawing.Size(586, 383)
        Me.tabpageAbout.TabIndex = 3
        Me.tabpageAbout.Text = "About"
        Me.tabpageAbout.UseVisualStyleBackColor = True
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(594, 409)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "aaformMainWindow"
        Me.Text = "Sources Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabpageWinget As TabPage
    Friend WithEvents tabpageGuingetAndOtherFrontends As TabPage
    Friend WithEvents tabpageMaintenance As TabPage
    Friend WithEvents tabpageAbout As TabPage
End Class
