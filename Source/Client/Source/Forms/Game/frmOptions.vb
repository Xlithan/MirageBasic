Imports MirageBasic.Core

Friend Class FrmOptions

#Region "Options"

    Private Sub scrlVolume_ValueChanged(sender As Object, e As EventArgs) Handles scrlVolume.ValueChanged
        Settings.Volume = scrlVolume.Value

        MaxVolume = Settings.Volume

        lblVolume.Text = "Volume: " & Settings.Volume

        If Not MusicPlayer Is Nothing Then MusicPlayer.Volume() = MaxVolume

    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        Dim resolution As String(), width As String, height As String

        'music
        If optMOn.Checked = True Then
            Settings.Music = True
            ' start music playing
            PlayMusic(Trim$(Map.Music))
        Else
            Settings.Music = False
            ' stop music playing
            StopMusic()
            CurMusic = ""
        End If

        'sound
        If optSOn.Checked = True Then
            Settings.Sound = True
        Else
            Settings.Sound = False
            StopSound()
        End If

        'screensize
        Settings.ScreenSize = cmbScreenSize.SelectedItem

        If chkVsync.Checked Then
            Settings.Vsync = 1
        Else
            Settings.Vsync = 0
        End If

        If chkNpcBars.Checked Then
            Settings.ShowNpcBar = 1
        Else
            Settings.ShowNpcBar = 0
        End If

        If chkFullscreen.Checked Then
            If Settings.Fullscreen = 0 Then MsgBox("Please restart the client for the changes to take effect.", vbOKOnly, Settings.GameName)
            Settings.Fullscreen = 1
        Else
            Settings.Fullscreen = 0

            resolution = cmbScreenSize.SelectedItem.ToString.ToLower.Split("x")
            width = resolution(0)
            height = resolution(1)

            RePositionGui(Width, Height)
        End If

        ' save to config.ini
        SaveSettings()
        Me.Visible = False
    End Sub

#End Region

End Class