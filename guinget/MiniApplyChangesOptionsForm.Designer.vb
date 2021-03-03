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
        Me.checkboxWhenUpgrading = New System.Windows.Forms.CheckBox()
        Me.checkboxWhenUninstalling = New System.Windows.Forms.CheckBox()
        Me.checkboxWhenInstalling = New System.Windows.Forms.CheckBox()
        Me.panelMiniFormPanel = New System.Windows.Forms.Panel()
        Me.labelSpecifyVersionNumberHeading = New System.Windows.Forms.Label()
        Me.labelAboutNotSpecifyingVersionNumbers = New System.Windows.Forms.Label()
        Me.panelMiniFormPanel.SuspendLayout()
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
        'checkboxWhenUpgrading
        '
        Me.checkboxWhenUpgrading.AutoSize = True
        Me.checkboxWhenUpgrading.Location = New System.Drawing.Point(23, 158)
        Me.checkboxWhenUpgrading.Name = "checkboxWhenUpgrading"
        Me.checkboxWhenUpgrading.Size = New System.Drawing.Size(105, 17)
        Me.checkboxWhenUpgrading.TabIndex = 8
        Me.checkboxWhenUpgrading.Text = "When upgrading"
        Me.checkboxWhenUpgrading.UseVisualStyleBackColor = True
        '
        'checkboxWhenUninstalling
        '
        Me.checkboxWhenUninstalling.AutoSize = True
        Me.checkboxWhenUninstalling.Location = New System.Drawing.Point(23, 182)
        Me.checkboxWhenUninstalling.Name = "checkboxWhenUninstalling"
        Me.checkboxWhenUninstalling.Size = New System.Drawing.Size(110, 17)
        Me.checkboxWhenUninstalling.TabIndex = 9
        Me.checkboxWhenUninstalling.Text = "When uninstalling"
        Me.checkboxWhenUninstalling.UseVisualStyleBackColor = True
        '
        'checkboxWhenInstalling
        '
        Me.checkboxWhenInstalling.AutoSize = True
        Me.checkboxWhenInstalling.Location = New System.Drawing.Point(23, 135)
        Me.checkboxWhenInstalling.Name = "checkboxWhenInstalling"
        Me.checkboxWhenInstalling.Size = New System.Drawing.Size(98, 17)
        Me.checkboxWhenInstalling.TabIndex = 10
        Me.checkboxWhenInstalling.Text = "When installing"
        Me.checkboxWhenInstalling.UseVisualStyleBackColor = True
        '
        'panelMiniFormPanel
        '
        Me.panelMiniFormPanel.AutoScroll = True
        Me.panelMiniFormPanel.Controls.Add(Me.labelAboutNotSpecifyingVersionNumbers)
        Me.panelMiniFormPanel.Controls.Add(Me.labelSpecifyVersionNumberHeading)
        Me.panelMiniFormPanel.Controls.Add(Me.checkboxWhenInstalling)
        Me.panelMiniFormPanel.Controls.Add(Me.checkboxWhenUpgrading)
        Me.panelMiniFormPanel.Controls.Add(Me.checkboxInstallInteractively)
        Me.panelMiniFormPanel.Controls.Add(Me.checkboxWhenUninstalling)
        Me.panelMiniFormPanel.Controls.Add(Me.checkboxElevateWinget)
        Me.panelMiniFormPanel.Controls.Add(Me.labelWhyElevate)
        Me.panelMiniFormPanel.Controls.Add(Me.buttonClose)
        Me.panelMiniFormPanel.Controls.Add(Me.checkboxOpenAutomatically)
        Me.panelMiniFormPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMiniFormPanel.Location = New System.Drawing.Point(0, 0)
        Me.panelMiniFormPanel.Name = "panelMiniFormPanel"
        Me.panelMiniFormPanel.Size = New System.Drawing.Size(348, 337)
        Me.panelMiniFormPanel.TabIndex = 12
        '
        'labelSpecifyVersionNumberHeading
        '
        Me.labelSpecifyVersionNumberHeading.AutoSize = True
        Me.labelSpecifyVersionNumberHeading.Location = New System.Drawing.Point(3, 119)
        Me.labelSpecifyVersionNumberHeading.Name = "labelSpecifyVersionNumberHeading"
        Me.labelSpecifyVersionNumberHeading.Size = New System.Drawing.Size(126, 13)
        Me.labelSpecifyVersionNumberHeading.TabIndex = 11
        Me.labelSpecifyVersionNumberHeading.Text = "Specify version number..."
        '
        'labelAboutNotSpecifyingVersionNumbers
        '
        Me.labelAboutNotSpecifyingVersionNumbers.AutoSize = True
        Me.labelAboutNotSpecifyingVersionNumbers.Location = New System.Drawing.Point(20, 202)
        Me.labelAboutNotSpecifyingVersionNumbers.Name = "labelAboutNotSpecifyingVersionNumbers"
        Me.labelAboutNotSpecifyingVersionNumbers.Size = New System.Drawing.Size(260, 52)
        Me.labelAboutNotSpecifyingVersionNumbers.TabIndex = 12
        Me.labelAboutNotSpecifyingVersionNumbers.Text = resources.GetString("labelAboutNotSpecifyingVersionNumbers.Text")
        '
        'MiniApplyChangesOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonClose
        Me.ClientSize = New System.Drawing.Size(348, 337)
        Me.Controls.Add(Me.panelMiniFormPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "MiniApplyChangesOptionsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Options: Apply Changes"
        Me.panelMiniFormPanel.ResumeLayout(False)
        Me.panelMiniFormPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labelWhyElevate As Label
    Friend WithEvents checkboxElevateWinget As CheckBox
    Friend WithEvents checkboxInstallInteractively As CheckBox
    Friend WithEvents checkboxOpenAutomatically As CheckBox
    Friend WithEvents buttonClose As Button
    Friend WithEvents checkboxWhenUpgrading As CheckBox
    Friend WithEvents checkboxWhenUninstalling As CheckBox
    Friend WithEvents checkboxWhenInstalling As CheckBox
    Friend WithEvents panelMiniFormPanel As Panel
    Friend WithEvents labelSpecifyVersionNumberHeading As Label
    Friend WithEvents labelAboutNotSpecifyingVersionNumbers As Label
End Class
