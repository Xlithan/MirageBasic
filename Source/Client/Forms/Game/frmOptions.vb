Imports Mirage.Basic.Engine

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
            If Settings.Fullscreen = 0 Then
                MsgBox(Language.Game.Fullscreen, vbOKOnly, Settings.GameName)
            End If
            Settings.Fullscreen = 1
        Else
            If Settings.Fullscreen = 1 Then
                cmbScreenSize.Enabled = False
            Else              
                resolution = cmbScreenSize.SelectedItem.ToString.ToLower.Split("x")
                width = resolution(0)
                height = resolution(1)

                RePositionGui(Width, Height)
            End If

            Settings.Fullscreen = 0
        End If

        ' save to config.ini
        SaveSettings()
        Me.Visible = False
    End Sub

    Private Sub FrmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optMOn.Checked = Settings.Music
        optSOn.Checked = Settings.Sound
        lblVolume.Text = "Volume: " & Settings.Volume
        scrlVolume.Value = Settings.Volume
        TopMost = True
    End Sub

#End Region

End Class