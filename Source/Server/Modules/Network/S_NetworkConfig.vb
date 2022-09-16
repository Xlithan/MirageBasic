﻿Imports System.Net
Imports Asfw.Network
Imports Mirage.Basic.Engine

Friend Module S_NetworkConfig
    Friend WithEvents Socket As Asfw.Network.NetworkServer

    Friend Sub InitNetwork()
        If Not Socket Is Nothing Then Return
        ' Establish some Rulez
        Socket = New Asfw.Network.NetworkServer(Packets.ClientPackets.Count, 4096, MAX_PLAYERS) With {
            .BufferLimit = 2048000, ' <- this is 2mb max data storage
            .MinimumIndex = 1, ' <- this prevents the network from giving us 0 as an index
            .PacketAcceptLimit = 500, ' Dunno what is a reasonable cap right now so why not? :P
            .PacketDisconnectCount = 125 ' If the other thing was even remotely reasonable, this is DEFINITELY spam count!
            }
        ' END THE ESTABLISHMENT! WOOH ANARCHY! ~SpiceyWolf

        PacketRouter() ' Need them packet ids boah!
    End Sub

    Friend Sub DestroyNetwork()
        Socket.Dispose()
    End Sub

    Function IsLoggedIn(index As Integer) As Boolean
        Return Account(index).Login.Trim.Length > 0
    End Function

    Function IsPlaying(index As Integer) As Boolean
        Return TempPlayer(index).InGame
    End Function

    Function IsMultiAccounts(Index As Integer, Login As String) As Boolean
        For i As Integer = 1 To GetPlayersOnline()
            If i <> Index then
                If Account(i).Login.Trim.ToLower() = Login.Trim.ToLower() Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Friend Sub SendDataToAll(ByRef data() As Byte, head As Integer)
        For i As Integer = 1 To GetPlayersOnline()
            If IsPlaying(i) Then
                Socket.SendDataTo(i, data, head)
            End If
        Next
    End Sub

    Sub SendDataToAllBut(index As Integer, ByRef data() As Byte, head As Integer)
        For i As Integer = 0 To GetPlayersOnline()
            If IsPlaying(i) AndAlso i <> index Then
                Socket.SendDataTo(i, data, head)
            End If
        Next
    End Sub

    Sub SendDataToMapBut(index As Integer, mapNum As Integer, ByRef data() As Byte, head As Integer)
        For i As Integer = 0 To GetPlayersOnline()
            If IsPlaying(i) AndAlso GetPlayerMap(i) = mapNum AndAlso i <> index Then
                Socket.SendDataTo(i, data, head)
            End If
        Next
    End Sub

    Sub SendDataToMap(mapNum As Integer, ByRef data() As Byte, head As Integer)
        Dim i As Integer

       For i = 0 To GetPlayersOnline()

            If IsPlaying(i) Then
                If GetPlayerMap(i) = mapNum Then
                    Socket.SendDataTo(i, data, head)
                End If
            End If

        Next

    End Sub

#Region " Events "

    Friend Sub Socket_ConnectionReceived(index As Integer) Handles Socket.ConnectionReceived
        Console.WriteLine("Connection received on index[" & index & "] - IP[" & Socket.ClientIp(index) & "]")
        SendKeyPair(index)
        SendNews(index)
    End Sub

    Friend Sub Socket_ConnectionLost(index As Integer) Handles Socket.ConnectionLost
        Console.WriteLine("Connection lost on index[" & index & "] - IP[" & Socket.ClientIp(index) & "]")
        LeftGame(index)
    End Sub

    Friend Sub Socket_CrashReport(index As Integer, err As String) Handles Socket.CrashReport
        Console.WriteLine("There was a network error index[" & index & "]")
        Console.WriteLine("Report: " & err)
        LeftGame(index)
    End Sub

    Private Sub Socket_TrafficReceived(size As Integer, ByRef data() As Byte) Handles Socket.TrafficReceived
        If DebugTxt = True Then
            Console.WriteLine("Traffic Received: [Size: " & size & "]")
        End If
    End Sub

    Private Sub Socket_PacketReceived(size As Integer, header As Integer, ByRef data() As Byte) Handles Socket.PacketReceived
        If DebugTxt = True Then
            Console.WriteLine("Packet Received: [Size: " & size & "| Packet: " & CType(header, ClientPackets).ToString() & "]")
        End If
    End Sub

#End Region

End Module