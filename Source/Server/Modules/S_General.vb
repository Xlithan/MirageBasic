﻿Imports System
Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Runtime.InteropServices
Imports Mirage.Basic.Engine
Imports Mirage.Basic.Engine.Database

Module S_General
    'Friend Declare Function GetQueueStatus Lib "user32" (fuFlags As Integer) As Integer
    Friend ServerDestroyed As Boolean
    Friend MyIPAddress As String
    Friend myStopWatch As New Stopwatch()

    Friend Function GetTimeMs() As Integer
        Return myStopWatch.ElapsedMilliseconds
    End Function

    Sub InitServer()
        Dim i As Integer, F As Integer, x As Integer
        Dim time1 As Integer, time2 As Integer

        myStopWatch.Start()

        LoadSettings()

        Console.Title = "MirageBasic Server"

        time1 = GetTimeMs()

        ' Check if the directory is there, if its not make it
        CheckDir(Paths.Database)
        CheckDir(Paths.Jobs)
        CheckDir(Paths.Items)
        CheckDir(Paths.Maps)
        CheckDir(Paths.Npcs)
        CheckDir(Paths.Shops)
        CheckDir(Paths.Skills)
        CheckDir(Paths.Accounts)
        CheckDir(Paths.Resources)
        CheckDir(Paths.Animations)
        CheckDir(Paths.Logs)
        CheckDir(Paths.Quests)
        CheckDir(Paths.Pets)
        CheckDir(Paths.Projectiles)
        CheckDir(Paths.Quests)

        ' LOAD ENCRYPTION
        EKeyPair.GenerateKeys()
        ' Remember never pass private to client!
        ' Exporting the Key above saves it as a file for later reuse.
        ' END LOAD ENCRYPTION

        ' Get that network READY SUN! ~ SpiceyWOlf
        InitNetwork()

        'event
        ReDim Switches(MAX_SWITCHES)
        ReDim Variables(NAX_VARIABLES)
        ReDim TempEventMap(MAX_CACHED_MAPS)

        ReDim Shop(MAX_SHOPS).TradeItem(MAX_TRADES)

        ReDim Animation(MAX_ANIMATIONS).Sprite(1)
        ReDim Animation(MAX_ANIMATIONS).Frames(1)
        ReDim Animation(MAX_ANIMATIONS).LoopCount(1)
        ReDim Animation(MAX_ANIMATIONS).LoopTime(1)

        ReDim MapProjectile(MAX_CACHED_MAPS, MAX_PROJECTILES)
        ReDim Projectile(MAX_PROJECTILES)

        ' Serves as a constructor
        ClearGameData()
        LoadGameData()
        Console.WriteLine("Spawning Map Items...")
        SpawnAllMapsItems()
        Console.WriteLine("Spawning Map Npcs...")
        SpawnAllMapNpcs()

        InitTime()

        UpdateCaption()
        time2 = GetTimeMs()

        Console.Clear()
        Console.WriteLine(" __  __ _____ _____            _____ ______ _               _       ")
        Console.WriteLine("|  \/  |_   _|  __ \     /\   / ____|  ____| |             (_)      ")
        Console.WriteLine("| \  / | | | | |__) |   /  \ | |  __| |__  | |__   __ _ ___ _  ___  ")
        Console.WriteLine("| |\/| | | | |  _  /   / /\ \| | |_ |  __| | '_ \ / _` / __| |/ __| ")
        Console.WriteLine("| |  | |_| |_| | \ \  / ____ \ |__| | |____| |_) | (_| \__ \ | (__  ")
        Console.WriteLine("|_|  |_|_____|_|  \_\/_/    \_\_____|______|_.__/ \__,_|___/_|\___| ")

        Console.WriteLine("")

        Console.WriteLine("Initialization complete. Server loaded in " & time2 - time1 & "ms.")
        Console.WriteLine("")
        Console.WriteLine("Use /help for the available commands.")

        UpdateCaption()

        ' reset shutdown value
        isShuttingDown = False

        ' Start listener now that everything is loaded
        Socket.StartListening(Settings.Port, 5)

        ' Starts the server loop
        ServerLoop()

    End Sub

    Private Function ConsoleEventCallback(eventType As Integer) As Boolean
        If eventType = 2 Then
            Console.WriteLine("Console window closing, death imminent")
            'cleanup and close
            DestroyServer()
        End If
        Return False
    End Function

    Private handler As ConsoleEventDelegate

    ' Keeps it from getting garbage collected
    ' Pinvoke
    Private Delegate Function ConsoleEventDelegate(eventType As Integer) As Boolean

    <Runtime.InteropServices.DllImport("kernel32.dll", SetLastError:=True)>
    Private Function SetConsoleCtrlHandler(callback As ConsoleEventDelegate, add As Boolean) As Boolean
    End Function

    Sub UpdateCaption()
        Console.Title = String.Format("{0} <IP {1}:{2}> ({3} Players Online) - Current Errors: {4} - Time: {5}", Settings.GameName, MyIPAddress, Settings.Port, GetPlayersOnline(), ErrorCount, Time.Instance.ToString())
    End Sub

    Sub DestroyServer()
        Socket.StopListening()

        Console.WriteLine("Saving players online...")
        SaveAllPlayersOnline()

        Console.WriteLine("Unloading players...")
        For i As Integer = 1 To MAX_PLAYERS
            SendLeftGame(i)
            LeftGame(i)
        Next

        DestroyNetwork()
        ClearGameData()

        Environment.Exit(0)
    End Sub

    Friend Sub ClearGameData()
        Dim i As Integer

        ' Init all the player sockets
        Console.WriteLine("Clearing Players...")

        For i = 1 To MAX_PLAYERS
            ClearPlayer(i)
        Next

        ClearParties()

        Console.WriteLine("Clearing Jobs...") : ClearJobs()
        Console.WriteLine("Clearing Maps...") : ClearMaps()
        Console.WriteLine("Clearing Map Items...") : ClearMapItems()
        Console.WriteLine("Clearing Map NPC's...") : ClearAllMapNpcs()
        Console.WriteLine("Clearing NPC's...") : ClearNpcs()
        Console.WriteLine("Clearing Resources...") : ClearResources()
        Console.WriteLine("Clearing Items...") : ClearItems()
        Console.WriteLine("Clearing Shops...") : ClearShops()
        Console.WriteLine("Clearing Skills...") : ClearSkills()
        Console.WriteLine("Clearing Animations...") : ClearAnimations()
        Console.WriteLine("Clearing Quests...") : ClearQuests()
        Console.WriteLine("Clearing Map Projectiles...") : ClearMapProjectile()
        Console.WriteLine("Clearing Projectiles...") : ClearProjectile()
        Console.WriteLine("Clearing Pets...") : ClearPets()
    End Sub

    Private Sub LoadGameData()
        Console.WriteLine("Loading Jobs...") : LoadJobs()
        Console.WriteLine("Loading Maps...") : LoadMaps()
        Console.WriteLine("Loading Items...") : LoadItems()
        Console.WriteLine("Loading NPC's...") : LoadNpcs()
        Console.WriteLine("Loading Resources...") : LoadResources()
        Console.WriteLine("Loading Shops...") : LoadShops()
        Console.WriteLine("Loading Skills...") : LoadSkills()
        Console.WriteLine("Loading Animations...") : LoadAnimations()
        Console.WriteLine("Loading Quests...") : LoadQuests()
        Console.WriteLine("Loading Switches...") : LoadSwitches()
        Console.WriteLine("Loading Variables...") : LoadVariables()
        Console.WriteLine("Spawning Global Events...") : SpawnAllMapGlobalEvents()
        Console.WriteLine("Loading Projectiles...") : LoadProjectile()
        Console.WriteLine("Loading Pets...") : LoadPets()
        Console.WriteLine("Loading Character List...") : CharactersList = New CharacterList().Load()
    End Sub

    ' Used for checking validity of names
    Function IsNameLegal(sInput As Integer) As Boolean

        If (sInput >= 65 AndAlso sInput <= 90) OrElse (sInput >= 97 AndAlso sInput <= 122) OrElse (sInput = 95) OrElse (sInput = 32) OrElse (sInput >= 48 AndAlso sInput <= 57) Then
            Return True
        Else
            Return False
        End If

    End Function

    Friend Sub CheckDir(path As String)
        If Not Directory.Exists(path) Then Directory.CreateDirectory(path)
    End Sub

    Sub ErrorHandler(sender As Object, args As UnhandledExceptionEventArgs)
        Dim e As Exception = DirectCast(args.ExceptionObject, Exception)
        Dim myFilePath As String = Paths.Logs & "ErrorLog.log"

        Using sw As New StreamWriter(File.Open(myFilePath, FileMode.Append))
            sw.WriteLine(DateTime.Now)
            sw.WriteLine(GetExceptionInfo(e))
        End Using

        ErrorCount = ErrorCount + 1

        UpdateCaption()
    End Sub

    Friend Function GetExceptionInfo(ex As Exception) As String
        Dim Result As String
        Dim hr As Integer = Runtime.InteropServices.Marshal.GetHRForException(ex)
        Result = ex.GetType.ToString & "(0x" & hr.ToString("X8") & "): " & ex.Message & Environment.NewLine & ex.StackTrace & Environment.NewLine
        Dim st As New StackTrace(ex, True)
        For Each sf As StackFrame In st.GetFrames
            If sf.GetFileLineNumber() > 0 Then
                Result &= "Line:" & sf.GetFileLineNumber() & " Filename: " & Path.GetFileName(sf.GetFileName) & Environment.NewLine
            End If
        Next
        Return Result
    End Function

    Friend Sub AddDebug(Msg As String)
        If DebugTxt = True Then
            Addlog(Msg, PACKET_LOG)
            Console.WriteLine(Msg)
        End If

    End Sub

End Module