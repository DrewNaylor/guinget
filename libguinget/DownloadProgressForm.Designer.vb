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
        Me.progressbarDownloadProgress = New System.Windows.Forms.ProgressBar()
        Me.labelDownloadingPackageList = New System.Windows.Forms.Label()
        Me.labelSourceName = New System.Windows.Forms.Label()
        Me.labelSourceLocation = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'progressbarDownloadProgress
        '
        Me.progressbarDownloadProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressbarDownloadProgress.Location = New System.Drawing.Point(12, 29)
        Me.progressbarDownloadProgress.Name = "progressbarDownloadProgress"
        Me.progressbarDownloadProgress.Size = New System.Drawing.Size(422, 23)
        Me.progressbarDownloadProgress.TabIndex = 0
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
        Me.labelSourceName.Location = New System.Drawing.Point(3, -2)
        Me.labelSourceName.Name = "labelSourceName"
        Me.labelSourceName.Size = New System.Drawing.Size(100, 17)
        Me.labelSourceName.TabIndex = 2
        Me.labelSourceName.Text = "Source name: "
        '
        'labelSourceLocation
        '
        Me.labelSourceLocation.AutoSize = True
        Me.labelSourceLocation.Location = New System.Drawing.Point(3, 15)
        Me.labelSourceLocation.Name = "labelSourceLocation"
        Me.labelSourceLocation.Size = New System.Drawing.Size(114, 17)
        Me.labelSourceLocation.TabIndex = 3
        Me.labelSourceLocation.Text = "Source location: "
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.labelSourceLocation)
        Me.Panel1.Controls.Add(Me.labelSourceName)
        Me.Panel1.Location = New System.Drawing.Point(12, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 68)
        Me.Panel1.TabIndex = 4
        '
        'DownloadProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(447, 138)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labelDownloadingPackageList)
        Me.Controls.Add(Me.progressbarDownloadProgress)
        Me.Name = "DownloadProgressForm"
        Me.Text = "DownloadProgressForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents progressbarDownloadProgress As Windows.Forms.ProgressBar
    Friend WithEvents labelDownloadingPackageList As Windows.Forms.Label
    Friend WithEvents labelSourceName As Windows.Forms.Label
    Friend WithEvents labelSourceLocation As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
