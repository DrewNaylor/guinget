<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MiniApplyChangesOptionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MiniApplyChangesOptionsForm))
        Me.labelWhyElevate = New System.Windows.Forms.Label()
        Me.checkboxElevateWinget = New System.Windows.Forms.CheckBox()
        Me.checkboxInstallInteractively = New System.Windows.Forms.CheckBox()
        Me.checkboxOpenAutomatically = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'labelWhyElevate
        '
        Me.labelWhyElevate.AutoSize = True
        Me.labelWhyElevate.Location = New System.Drawing.Point(29, 52)
        Me.labelWhyElevate.Name = "labelWhyElevate"
        Me.labelWhyElevate.Size = New System.Drawing.Size(287, 65)
        Me.labelWhyElevate.TabIndex = 5
        Me.labelWhyElevate.Text = resources.GetString("labelWhyElevate.Text")
        '
        'checkboxElevateWinget
        '
        Me.checkboxElevateWinget.AutoSize = True
        Me.checkboxElevateWinget.Location = New System.Drawing.Point(12, 35)
        Me.checkboxElevateWinget.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.checkboxElevateWinget.Name = "checkboxElevateWinget"
        Me.checkboxElevateWinget.Size = New System.Drawing.Size(143, 17)
        Me.checkboxElevateWinget.TabIndex = 4
        Me.checkboxElevateWinget.Text = "Elevate winget with UAC"
        Me.checkboxElevateWinget.UseVisualStyleBackColor = True
        '
        'checkboxInstallInteractively
        '
        Me.checkboxInstallInteractively.AutoSize = True
        Me.checkboxInstallInteractively.Location = New System.Drawing.Point(12, 12)
        Me.checkboxInstallInteractively.Name = "checkboxInstallInteractively"
        Me.checkboxInstallInteractively.Size = New System.Drawing.Size(153, 17)
        Me.checkboxInstallInteractively.TabIndex = 3
        Me.checkboxInstallInteractively.Text = "Run interactively (winget -i)"
        Me.checkboxInstallInteractively.UseVisualStyleBackColor = True
        '
        'checkboxOpenAutomatically
        '
        Me.checkboxOpenAutomatically.AutoSize = True
        Me.checkboxOpenAutomatically.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxOpenAutomatically.Location = New System.Drawing.Point(12, 182)
        Me.checkboxOpenAutomatically.Name = "checkboxOpenAutomatically"
        Me.checkboxOpenAutomatically.Size = New System.Drawing.Size(294, 30)
        Me.checkboxOpenAutomatically.TabIndex = 6
        Me.checkboxOpenAutomatically.Text = "Automatically open this window when the Apply Changes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "window is opened"
        Me.checkboxOpenAutomatically.UseVisualStyleBackColor = True
        '
        'MiniApplyChangesOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(358, 224)
        Me.Controls.Add(Me.checkboxOpenAutomatically)
        Me.Controls.Add(Me.labelWhyElevate)
        Me.Controls.Add(Me.checkboxElevateWinget)
        Me.Controls.Add(Me.checkboxInstallInteractively)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "MiniApplyChangesOptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Options: Apply Changes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelWhyElevate As Label
    Friend WithEvents checkboxElevateWinget As CheckBox
    Friend WithEvents checkboxInstallInteractively As CheckBox
    Friend WithEvents checkboxOpenAutomatically As CheckBox
End Class
