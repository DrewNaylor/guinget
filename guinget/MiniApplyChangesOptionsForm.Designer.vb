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
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelWhyElevate
        '
        Me.labelWhyElevate.AutoSize = True
        Me.labelWhyElevate.Location = New System.Drawing.Point(20, 43)
        Me.labelWhyElevate.Name = "labelWhyElevate"
        Me.labelWhyElevate.Size = New System.Drawing.Size(287, 65)
        Me.labelWhyElevate.TabIndex = 5
        Me.labelWhyElevate.Text = resources.GetString("labelWhyElevate.Text")
        '
        'checkboxElevateWinget
        '
        Me.checkboxElevateWinget.AutoSize = True
        Me.checkboxElevateWinget.Location = New System.Drawing.Point(3, 26)
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
        Me.checkboxInstallInteractively.Location = New System.Drawing.Point(3, 3)
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
        Me.checkboxOpenAutomatically.Location = New System.Drawing.Point(9, 270)
        Me.checkboxOpenAutomatically.Name = "checkboxOpenAutomatically"
        Me.checkboxOpenAutomatically.Size = New System.Drawing.Size(294, 30)
        Me.checkboxOpenAutomatically.TabIndex = 6
        Me.checkboxOpenAutomatically.Text = "Automatically open this window when the Apply Changes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "window is opened"
        Me.checkboxOpenAutomatically.UseVisualStyleBackColor = True
        '
        'buttonClose
        '
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(259, 306)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(86, 28)
        Me.buttonClose.TabIndex = 7
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(23, 158)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "When upgrading"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(23, 182)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(110, 17)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "When uninstalling"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(23, 135)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox3.TabIndex = 10
        Me.CheckBox3.Text = "When installing"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.checkboxInstallInteractively)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.checkboxElevateWinget)
        Me.Panel1.Controls.Add(Me.labelWhyElevate)
        Me.Panel1.Controls.Add(Me.buttonClose)
        Me.Panel1.Controls.Add(Me.checkboxOpenAutomatically)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(348, 337)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Specify version number..."
        '
        'MiniApplyChangesOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonClose
        Me.ClientSize = New System.Drawing.Size(348, 337)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "MiniApplyChangesOptionsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Options: Apply Changes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelWhyElevate As Label
    Friend WithEvents checkboxElevateWinget As CheckBox
    Friend WithEvents checkboxInstallInteractively As CheckBox
    Friend WithEvents checkboxOpenAutomatically As CheckBox
    Friend WithEvents buttonClose As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
