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
        Me.panelSourceInfo = New System.Windows.Forms.Panel()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.panelSourceInfo.SuspendLayout()
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
        Me.labelSourceName.Location = New System.Drawing.Point(-3, -3)
        Me.labelSourceName.Name = "labelSourceName"
        Me.labelSourceName.Size = New System.Drawing.Size(100, 17)
        Me.labelSourceName.TabIndex = 2
        Me.labelSourceName.Text = "Source name: "
        '
        'labelSourceLocation
        '
        Me.labelSourceLocation.AutoSize = True
        Me.labelSourceLocation.Location = New System.Drawing.Point(-3, 14)
        Me.labelSourceLocation.Name = "labelSourceLocation"
        Me.labelSourceLocation.Size = New System.Drawing.Size(114, 17)
        Me.labelSourceLocation.TabIndex = 3
        Me.labelSourceLocation.Text = "Source location: "
        '
        'panelSourceInfo
        '
        Me.panelSourceInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSourceInfo.AutoScroll = True
        Me.panelSourceInfo.Controls.Add(Me.labelSourceLocation)
        Me.panelSourceInfo.Controls.Add(Me.labelSourceName)
        Me.panelSourceInfo.Location = New System.Drawing.Point(12, 58)
        Me.panelSourceInfo.Name = "panelSourceInfo"
        Me.panelSourceInfo.Size = New System.Drawing.Size(422, 68)
        Me.panelSourceInfo.TabIndex = 4
        '
        'buttonCancel
        '
        Me.buttonCancel.Location = New System.Drawing.Point(339, 132)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(95, 30)
        Me.buttonCancel.TabIndex = 5
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'DownloadProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(447, 171)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.panelSourceInfo)
        Me.Controls.Add(Me.labelDownloadingPackageList)
        Me.Controls.Add(Me.progressbarDownloadProgress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DownloadProgressForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "DownloadProgressForm"
        Me.panelSourceInfo.ResumeLayout(False)
        Me.panelSourceInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents progressbarDownloadProgress As Windows.Forms.ProgressBar
    Friend WithEvents labelDownloadingPackageList As Windows.Forms.Label
    Friend WithEvents labelSourceName As Windows.Forms.Label
    Friend WithEvents labelSourceLocation As Windows.Forms.Label
    Friend WithEvents panelSourceInfo As Windows.Forms.Panel
    Friend WithEvents buttonCancel As Windows.Forms.Button
End Class
