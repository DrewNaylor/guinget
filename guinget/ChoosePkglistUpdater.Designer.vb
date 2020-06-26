<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoosePkglistUpdater
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
        Me.buttonUpdateWithUpdateManifests = New System.Windows.Forms.Button()
        Me.buttonUpdateWithBuiltin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonUpdateWithUpdateManifests
        '
        Me.buttonUpdateWithUpdateManifests.Location = New System.Drawing.Point(13, 13)
        Me.buttonUpdateWithUpdateManifests.Name = "buttonUpdateWithUpdateManifests"
        Me.buttonUpdateWithUpdateManifests.Size = New System.Drawing.Size(179, 69)
        Me.buttonUpdateWithUpdateManifests.TabIndex = 0
        Me.buttonUpdateWithUpdateManifests.Text = "Update using update-manifests.bat (Recommended)"
        Me.buttonUpdateWithUpdateManifests.UseVisualStyleBackColor = True
        '
        'buttonUpdateWithBuiltin
        '
        Me.buttonUpdateWithBuiltin.Location = New System.Drawing.Point(198, 13)
        Me.buttonUpdateWithBuiltin.Name = "buttonUpdateWithBuiltin"
        Me.buttonUpdateWithBuiltin.Size = New System.Drawing.Size(179, 69)
        Me.buttonUpdateWithBuiltin.TabIndex = 1
        Me.buttonUpdateWithBuiltin.Text = "Update using built-in updater"
        Me.buttonUpdateWithBuiltin.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 68)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please note that the built-in updater is unfinished, and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this window is here mai" &
    "nly to allow people to choose if" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "they want to try the built-in updater instead " &
    "of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "update-manifests.bat."
        '
        'ChoosePkglistUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(388, 167)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonUpdateWithBuiltin)
        Me.Controls.Add(Me.buttonUpdateWithUpdateManifests)
        Me.Name = "ChoosePkglistUpdater"
        Me.Text = "Choose package list updater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonUpdateWithUpdateManifests As Button
    Friend WithEvents buttonUpdateWithBuiltin As Button
    Friend WithEvents Label1 As Label
End Class
