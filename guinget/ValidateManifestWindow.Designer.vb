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
        Me.textboxManifestPath = New System.Windows.Forms.TextBox()
        Me.buttonBrowseForManifest = New System.Windows.Forms.Button()
        Me.buttonValidateManifest = New System.Windows.Forms.Button()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.labelValidateManifestLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textboxManifestPath
        '
        Me.textboxManifestPath.Location = New System.Drawing.Point(15, 46)
        Me.textboxManifestPath.Name = "textboxManifestPath"
        Me.textboxManifestPath.Size = New System.Drawing.Size(476, 22)
        Me.textboxManifestPath.TabIndex = 0
        '
        'buttonBrowseForManifest
        '
        Me.buttonBrowseForManifest.Location = New System.Drawing.Point(497, 46)
        Me.buttonBrowseForManifest.Name = "buttonBrowseForManifest"
        Me.buttonBrowseForManifest.Size = New System.Drawing.Size(100, 34)
        Me.buttonBrowseForManifest.TabIndex = 1
        Me.buttonBrowseForManifest.Text = "Browse..."
        Me.buttonBrowseForManifest.UseVisualStyleBackColor = True
        '
        'buttonValidateManifest
        '
        Me.buttonValidateManifest.Location = New System.Drawing.Point(353, 124)
        Me.buttonValidateManifest.Name = "buttonValidateManifest"
        Me.buttonValidateManifest.Size = New System.Drawing.Size(138, 34)
        Me.buttonValidateManifest.TabIndex = 2
        Me.buttonValidateManifest.Text = "Validate manifest"
        Me.buttonValidateManifest.UseVisualStyleBackColor = True
        '
        'buttonClose
        '
        Me.buttonClose.Location = New System.Drawing.Point(497, 124)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(100, 34)
        Me.buttonClose.TabIndex = 3
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'labelValidateManifestLabel
        '
        Me.labelValidateManifestLabel.AutoSize = True
        Me.labelValidateManifestLabel.Location = New System.Drawing.Point(12, 9)
        Me.labelValidateManifestLabel.Name = "labelValidateManifestLabel"
        Me.labelValidateManifestLabel.Size = New System.Drawing.Size(537, 34)
        Me.labelValidateManifestLabel.TabIndex = 4
        Me.labelValidateManifestLabel.Text = "Enter or browse for a manifest path then click ""Validate manifest"". The manifest " &
    "path" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "must be in the format ""Publisher.App.yaml""."
        '
        'ValidateManifestWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(609, 170)
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
End Class
