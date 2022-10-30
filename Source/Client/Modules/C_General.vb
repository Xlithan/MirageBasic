﻿Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Mirage.Basic.Engine

Module C_General
    Friend Started As Boolean

    Friend Function GetTickCount() As Integer
        Return Environment.TickCount
    End Function

    Sub Startup()
        ClearGameData()
        LoadGame()
        GameLoop()
    End Sub

    Friend Function LoadGame()
        LoadSettings()
        LoadLanguage()
        LoadInputs()
        LoadGraphics()
        InitNetwork()
        FrmMenu.Text = Settings.GameName
        FrmMenu.Visible = True
        Frmmenuvisible = True
        Ping = -1
    End Function

    Friend Function LoadGraphics()
        Started = True
        CheckPaths()
        InitGraphics()
End Function

    Friend function ClearGameData()
        ClearMap()
        ClearMapNpcs()
        ClearMapItems()
        ClearNpcs()
        ClearResources()
        ClearItems()
        ClearShops()
        ClearSkills()
        ClearAnimations()
        ClearQuests()
        ClearProjectile()
        ClearPets()
        ClearJobs()
        ClearBank()
        ClearParty()

        For i = 0 To MAX_PLAYERS
            ClearPlayer(i)
        Next

        ReDim CharSelection(3)

        ClearAnimInstances()
        ClearAutotiles()
    End function

    Friend Function CheckPaths()
        CacheMusic()
        CacheSound()

        If Settings.Music = 1 AndAlso Len(Trim$(Settings.MenuMusic)) > 0 Then
            PlayMusic(Trim$(Settings.MenuMusic))
            MusicPlayer.Volume() = Settings.Volume
        End If

        CheckAnimations()
        CheckCharacters()
        CheckEmotes()
        CheckFaces()
        CheckFog()
        CheckItems()
        CheckPanoramas()
        CheckPaperdolls()
        CheckParallax()
        CheckPictures()
        CheckProjectile()
        CheckResources()
        CheckSkillIcons()
        CheckTilesets()
    End Function

    Friend Function IsLoginLegal(username As String, password As String) As Boolean
        Return Len(Trim$(username)) >= MIN_STRING_LENGTH AndAlso Len(Trim$(password)) >= MIN_STRING_LENGTH And Len(Trim$(username)) <= MAX_STRING_LENGTH And Len(Trim$(password)) <= MAX_STRING_LENGTH
    End Function

    Friend Function IsStringLegal(sInput As String) As Boolean
        Dim i As Integer

        ' Prevent high ascii chars
        For i = 1 To Len(sInput)

            If (Asc(Mid$(sInput, i, 1))) < 32 OrElse Asc(Mid$(sInput, i, 1)) > 126 Then
                MsgBox(Language.MainMenu.StringLegal, vbOKOnly, Settings.GameName)
                IsStringLegal = False
                Exit Function
            End If

        Next

        IsStringLegal = True
    End Function

    Sub GameInit()
        ' Set the focus
        FrmGame.picscreen.Focus()

        ' Send a request to the server to open the admin menu if the user wants it.
        If Settings.OpenAdminPanelOnLogin = 1 Then
            If GetPlayerAccess(Myindex) > 0 Then
                SendRequestAdmin()
            End If
        End If

        'stop the song playing
        StopMusic()
    End Sub

    Friend Sub MenuState(state As Integer)
        Frmmenuvisible = False
        Select Case state
            Case MenuStateAddchar
                PnlCharCreateVisible = False
                PnlLoginVisible = False
                PnlRegisterVisible = False
                PnlCreditsVisible = False

                If ConnectToServer(1) Then
                    If FrmMenu.rdoMale.Checked = True Then
                        SendAddChar(SelectedChar, FrmMenu.txtCharName.Text, SexType.Male, FrmMenu.cmbJob.SelectedIndex)
                    Else
                        SendAddChar(SelectedChar, FrmMenu.txtCharName.Text, SexType.Female, FrmMenu.cmbJob.SelectedIndex)
                    End If
                End If

            Case MenuStateNewaccount
                PnlLoginVisible = False
                PnlCharCreateVisible = False
                PnlRegisterVisible = False
                PnlCreditsVisible = False

                If ConnectToServer(1) Then
                    SendNewAccount(FrmMenu.txtRuser.Text, FrmMenu.txtRPass.Text)
                End If

            Case MenuStateLogin
                PnlLoginVisible = False
                PnlCharCreateVisible = False
                PnlRegisterVisible = False
                PnlCreditsVisible = False
                TempUserName = FrmMenu.txtLogin.Text
                TempPassword = FrmMenu.txtPassword.Text

                If ConnectToServer(1) Then
                    SendLogin(FrmMenu.txtLogin.Text, FrmMenu.txtPassword.Text)
                    Exit Sub
                End If
        End Select

    End Sub

    Friend Function ConnectToServer(i As Integer) As Boolean
        Dim until As Integer
        ConnectToServer = False

        ' Check to see if we are already connected, if so just exit
        If Socket.IsConnected() Then
            ConnectToServer = True
            Exit Function
        End If

        If i = 4 Then Exit Function
        until = GetTickCount() + 3500

        Connect()

        ' Wait until connected or a few seconds have passed and report the server being down
        Do While (Not Socket.IsConnected()) AndAlso (GetTickCount() <= until)
            Application.DoEvents()
        Loop

        ' return value
        If Socket.IsConnected() Then
            ConnectToServer = True
        End If

        If Not ConnectToServer Then
            ConnectToServer(i + 1)
        End If

    End Function

    Friend Sub RePositionGui(width As Integer, height As Integer)
        ScreenMapx = 24 '(width / 32) - 1
        ScreenMapy = 18 '(height / 32) - 1

        'then the window
        'FrmGame.ClientSize = New Drawing.Size((ScreenMapx) * PicX + PicX, (ScreenMapy) * PicY + PicY)
        FrmGame.picscreen.Width = 800 '(ScreenMapx) * PicX + PicX
        FrmGame.picscreen.Height = 608 '(ScreenMapy) * PicY + PicY

        HalfX = ((ScreenMapx) \ 2) * PicX
        HalfY = ((ScreenMapy) \ 2) * PicY
        ScreenX = (ScreenMapx) * PicX
        ScreenY = (ScreenMapy) * PicY

        GameWindow.SetView(New SFML.Graphics.View(New SFML.Graphics.FloatRect(0, 0, (ScreenMapx) * PicX + PicX, (ScreenMapy) * PicY + PicY)))

        'Then we can recalculate the positions

        'chatwindow
        ChatWindowX = 1
        ChatWindowY = FrmGame.Height - ChatWindowGfxInfo.Height - 65

        MyChatX = 24
        MyChatY = FrmGame.Height - 60

        'hotbar
        'If Settings.ScreenSize = 0 Then
        HotbarX = HudWindowX + HudPanelGfxInfo.Width + 20
        HotbarY = 5

        'petbar
        PetbarX = HotbarX
        PetbarY = HotbarY + 34
        'Else
        '    HotbarX = ChatWindowX + MyChatWindowGfxInfo.Width + 75
        '    HotbarY = FrmGame.Height - HotBarGfxInfo.Height - 45

        'petbar
        '    PetbarX = HotbarX
        '    PetbarY = HotbarY - 34
        'End If

        'action panel
        ActionPanelX = FrmGame.Width - ActionPanelGfxInfo.Width - 25
        ActionPanelY = FrmGame.Height - ActionPanelGfxInfo.Height - 45

        'Char Window
        CharWindowX = FrmGame.Width - CharPanelGfxInfo.Width - 26
        CharWindowY = FrmGame.Height - CharPanelGfxInfo.Height - ActionPanelGfxInfo.Height - 50

        'inv Window
        InvWindowX = FrmGame.Width - InvPanelGfxInfo.Width - 26
        InvWindowY = FrmGame.Height - InvPanelGfxInfo.Height - ActionPanelGfxInfo.Height - 50

        'skill window
        SkillWindowX = FrmGame.Width - SkillPanelGfxInfo.Width - 26
        SkillWindowY = FrmGame.Height - SkillPanelGfxInfo.Height - ActionPanelGfxInfo.Height - 50

        'petstat window
        PetStatX = PetbarX
        PetStatY = PetbarY - PetStatsGfxInfo.Height - 10
    End Sub

    Friend Sub DestroyGame()
        ' break out of GameLoop
        InGame = False
        Application.Exit()
        End
    End Sub

    Friend Sub CheckDir(dirPath As String)
        If Not IO.Directory.Exists(dirPath) Then
            IO.Directory.CreateDirectory(dirPath)
        End If
    End Sub

    Friend Function GetExceptionInfo(ex As Exception) As String
        Dim result As String
        Dim hr As Integer = Runtime.InteropServices.Marshal.GetHRForException(ex)
        result = ex.GetType.ToString & "(0x" & hr.ToString("X8") & "): " & ex.Message & Environment.NewLine & ex.StackTrace & Environment.NewLine
        Dim st As StackTrace = New StackTrace(ex, True)
        For Each sf As StackFrame In st.GetFrames
            If sf.GetFileLineNumber() > 0 Then
                result &= "Line:" & sf.GetFileLineNumber() & " Filename: " & IO.Path.GetFileName(sf.GetFileName) & Environment.NewLine
            End If
        Next
        Return result
    End Function

End Module