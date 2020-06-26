Public Class ChoosePkglistUpdater

    Private Sub buttonUpdateWithUpdateManifests_Click(sender As Object, e As EventArgs) Handles buttonUpdateWithUpdateManifests.Click
        aaformMainWindow.RefreshCache()
        Me.Close()
    End Sub
End Class