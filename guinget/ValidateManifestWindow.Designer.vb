<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidateManifestWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValidateManifestWindow))
        Me.textboxManifestPath = New System.Windows.Forms.TextBox()
        Me.buttonBrowseForManifest = New System.Windows.Forms.Button()
        Me.buttonValidateManifest = New System.Windows.Forms.Button()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.labelValidateManifestLabel = New System.Windows.Forms.Label()
        Me.openfiledialogBrowseForManifest = New System.Windows.Forms.OpenFileDialog()
        Me.checkboxBrowseForSingleton = New System.Windows.Forms.CheckBox()
        Me.folderbrowserdialogMultiFileManifestBrowse = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'textboxManifestPath
        '
        Me.textboxManifestPath.Location = New System.Drawing.Point(15, 89)
        Me.textboxManifestPath.Name = "textboxManifestPath"
        Me.textboxManifestPath.Size = New System.Drawing.Size(476, 22)
        Me.textboxManifestPath.TabIndex = 0
        '
        'buttonBrowseForManifest
        '
        Me.buttonBrowseForManifest.Location = New System.Drawing.Point(497, 89)
        Me.buttonBrowseForManifest.Name = "buttonBrowseForManifest"
        Me.buttonBrowseForManifest.Size = New System.Drawing.Size(100, 49)
        Me.buttonBrowseForManifest.TabIndex = 2
        Me.buttonBrowseForManifest.Text = "Browse..."
        Me.buttonBrowseForManifest.UseVisualStyleBackColor = True
        '
        'buttonValidateManifest
        '
        Me.buttonValidateManifest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonValidateManifest.Location = New System.Drawing.Point(497, 194)
        Me.buttonValidateManifest.Name = "buttonValidateManifest"
        Me.buttonValidateManifest.Size = New System.Drawing.Size(100, 34)
        Me.buttonValidateManifest.TabIndex = 3
        Me.buttonValidateManifest.Text = "Validate"
        Me.buttonValidateManifest.UseVisualStyleBackColor = True
        '
        'buttonClose
        '
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(391, 194)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(100, 34)
        Me.buttonClose.TabIndex = 4
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'labelValidateManifestLabel
        '
        Me.labelValidateManifestLabel.AutoSize = True
        Me.labelValidateManifestLabel.Location = New System.Drawing.Point(12, 9)
        Me.labelValidateManifestLabel.Name = "labelValidateManifestLabel"
        Me.labelValidateManifestLabel.Size = New System.Drawing.Size(533, 68)
        Me.labelValidateManifestLabel.TabIndex = 4
        Me.labelValidateManifestLabel.Text = resources.GetString("labelValidateManifestLabel.Text")
        '
        'openfiledialogBrowseForManifest
        '
        Me.openfiledialogBrowseForManifest.Filter = "Manifest (*.yaml)|*.yaml|All File Formats (*.*)|*.*"
        Me.openfiledialogBrowseForManifest.RestoreDirectory = True
        Me.openfiledialogBrowseForManifest.Title = "Browse"
        '
        'checkboxBrowseForSingleton
        '
        Me.checkboxBrowseForSingleton.AutoSize = True
        Me.checkboxBrowseForSingleton.Location = New System.Drawing.Point(15, 117)
        Me.checkboxBrowseForSingleton.Name = "checkboxBrowseForSingleton"
        Me.checkboxBrowseForSingleton.Size = New System.Drawing.Size(215, 21)
        Me.checkboxBrowseForSingleton.TabIndex = 1
        Me.checkboxBrowseForSingleton.Text = "Browse for singleton manifest"
        Me.checkboxBrowseForSingleton.UseVisualStyleBackColor = True
        '
        'ValidateManifestWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonClose
        Me.ClientSize = New System.Drawing.Size(609, 240)
        Me.Controls.Add(Me.checkboxBrowseForSingleton)
        Me.Controls.Add(Me.labelValidateManifestLabel)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.buttonValidateManifest)
        Me.Controls.Add(Me.buttonBrowseForManifest)
        Me.Controls.Add(Me.textboxManifestPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ValidateManifestWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Validate Manifest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxManifestPath As TextBox
    Friend WithEvents buttonBrowseForManifest As Button
    Friend WithEvents buttonValidateManifest As Button
    Friend WithEvents buttonClose As Button
    Friend WithEvents labelValidateManifestLabel As Label
    Friend WithEvents openfiledialogBrowseForManifest As OpenFileDialog
    Friend WithEvents checkboxBrowseForSingleton As CheckBox
    Friend WithEvents folderbrowserdialogMultiFileManifestBrowse As FolderBrowserDialog
End Class
