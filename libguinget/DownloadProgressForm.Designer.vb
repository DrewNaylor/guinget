<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadProgressForm
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.labelDownloadingPackageList = New System.Windows.Forms.Label()
        Me.labelSourceName = New System.Windows.Forms.Label()
        Me.labelSourceLocation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 29)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(422, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'labelDownloadingPackageList
        '
        Me.labelDownloadingPackageList.AutoSize = True
        Me.labelDownloadingPackageList.Location = New System.Drawing.Point(9, 9)
        Me.labelDownloadingPackageList.Name = "labelDownloadingPackageList"
        Me.labelDownloadingPackageList.Size = New System.Drawing.Size(180, 17)
        Me.labelDownloadingPackageList.TabIndex = 1
        Me.labelDownloadingPackageList.Text = "Downloading package list..."
        '
        'labelSourceName
        '
        Me.labelSourceName.AutoSize = True
        Me.labelSourceName.Location = New System.Drawing.Point(12, 59)
        Me.labelSourceName.Name = "labelSourceName"
        Me.labelSourceName.Size = New System.Drawing.Size(100, 17)
        Me.labelSourceName.TabIndex = 2
        Me.labelSourceName.Text = "Source name: "
        '
        'labelSourceLocation
        '
        Me.labelSourceLocation.AutoSize = True
        Me.labelSourceLocation.Location = New System.Drawing.Point(12, 76)
        Me.labelSourceLocation.Name = "labelSourceLocation"
        Me.labelSourceLocation.Size = New System.Drawing.Size(114, 17)
        Me.labelSourceLocation.TabIndex = 3
        Me.labelSourceLocation.Text = "Source location: "
        '
        'DownloadProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(447, 138)
        Me.Controls.Add(Me.labelSourceLocation)
        Me.Controls.Add(Me.labelSourceName)
        Me.Controls.Add(Me.labelDownloadingPackageList)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "DownloadProgressForm"
        Me.Text = "DownloadProgressForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As Windows.Forms.ProgressBar
    Friend WithEvents labelDownloadingPackageList As Windows.Forms.Label
    Friend WithEvents labelSourceName As Windows.Forms.Label
    Friend WithEvents labelSourceLocation As Windows.Forms.Label
End Class
