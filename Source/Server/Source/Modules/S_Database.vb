﻿Imports System.IO
Imports Asfw
Imports Asfw.IO
Imports MirageBasic.Core
Imports Ini = Asfw.IO.TextFile

Module modDatabase

#Region "Job"

    Sub ClearJobs()
        Dim i As Integer

        ReDim Job(MAX_JOBS)

        For i = 0 To MAX_JOBS
            Job(i).Name = ""
            Job(i).Desc = ""
            ReDim Job(i).Stat(StatType.Count - 1)
            ReDim Job(i).StartItem(5)
            ReDim Job(i).StartValue(5)
        Next

    End Sub

    Sub LoadJobs()
        Dim cf = Paths.Database & "Job.ini"
        Dim i, n, x As Integer

        ClearJobs()

        For i = 0 To MAX_JOBS
            Job(i).Name = Ini.Read(cf, "CLASS" & i, "Name")
            Job(i).Desc = Ini.Read(cf, "CLASS" & i, "Desc")
            Job(i).BaseExp = Val(Ini.Read(cf, "CLASS" & i, "BaseExp"))

            n = Val(Ini.Read(cf, "CLASS" & i, "MaxMaleSprite"))
            ReDim Job(i).MaleSprite(n)
            For X = 0 To n
                Job(i).MaleSprite(x) = Val(Ini.Read(cf, "CLASS" & i, "Sprite_Male" & x))
            Next

            n = Val(Ini.Read(cf, "CLASS" & i, "MaxFemaleSprite"))
            ReDim Job(i).FemaleSprite(n)
            For X = 0 To n
                Job(i).FemaleSprite(x) = Val(Ini.Read(cf, "CLASS" & i, "Sprite_Female" & x))
            Next

            Job(i).Stat(StatType.Strength) = Val(Ini.Read(cf, "CLASS" & i, "Str"))
            Job(i).Stat(StatType.Endurance) = Val(Ini.Read(cf, "CLASS" & i, "End"))
            Job(i).Stat(StatType.Vitality) = Val(Ini.Read(cf, "CLASS" & i, "Vit"))
            Job(i).Stat(StatType.Luck) = Val(Ini.Read(cf, "CLASS" & i, "Luck"))
            Job(i).Stat(StatType.Intelligence) = Val(Ini.Read(cf, "CLASS" & i, "Int"))
            Job(i).Stat(StatType.Spirit) = Val(Ini.Read(cf, "CLASS" & i, "Speed"))

            Job(i).StartMap = Val(Ini.Read(cf, "CLASS" & i, "StartMap"))
            Job(i).StartX = Val(Ini.Read(cf, "CLASS" & i, "StartX"))
            Job(i).StartY = Val(Ini.Read(cf, "CLASS" & i, "StartY"))

            ' loop for items & values
            For x = 0 To MAX_DROP_ITEMS
                Job(i).StartItem(x) = Val(Ini.Read(cf, "CLASS" & i, "StartItem" & x))
                Job(i).StartValue(x) = Val(Ini.Read(cf, "CLASS" & i, "StartValue" & x))
            Next
        Next
    End Sub

    Sub SaveJobs()
        Dim cf = Paths.Database & "Job.ini"
        Dim i, n, x As Integer

        For i = 0 To MAX_JOBS
            Ini.Write(cf, "CLASS" & i, "Name", Trim$(Job(i).Name))
            Ini.Write(cf, "CLASS" & i, "Desc", Trim$(Job(i).Desc))
            Ini.Write(cf, "CLASS" & i, "BaseExp", Job(i).BaseExp)

            n = UBound(Job(i).MaleSprite)
            Ini.Write(cf, "CLASS" & i, "MaxMaleSprite", n)
            For X = 0 To n
                Ini.Write(cf, "CLASS" & i, "Sprite_Male" & x, Job(i).MaleSprite(x))
            Next

            n = UBound(Job(i).FemaleSprite)
            Ini.Write(cf, "CLASS" & i, "MaxFemaleSprite", n)
            For X = 0 To n
                Ini.Write(cf, "CLASS" & i, "Sprite_Female" & x, Job(i).FemaleSprite(x))
            Next

            Ini.Write(cf, "CLASS" & i, "Str", Job(i).Stat(StatType.Strength))
            Ini.Write(cf, "CLASS" & i, "End", Job(i).Stat(StatType.Endurance))
            Ini.Write(cf, "CLASS" & i, "Vit", Job(i).Stat(StatType.Vitality))
            Ini.Write(cf, "CLASS" & i, "Luck", Job(i).Stat(StatType.Luck))
            Ini.Write(cf, "CLASS" & i, "Int", Job(i).Stat(StatType.Intelligence))
            Ini.Write(cf, "CLASS" & i, "Speed", Job(i).Stat(StatType.Spirit))

            Ini.Write(cf, "CLASS" & i, "StartMap", Job(i).StartMap)
            Ini.Write(cf, "CLASS" & i, "StartX", Job(i).StartX)
            Ini.Write(cf, "CLASS" & i, "StartY", Job(i).StartY)

            ' loop for items & values
            For x = 0 To MAX_DROP_ITEMS
                Ini.Write(cf, "CLASS" & i, "StartItem" & x, Job(i).StartItem(x))
                Ini.Write(cf, "CLASS" & i, "StartValue" & x, Job(i).StartValue(x))
            Next
        Next
    End Sub

    Function GetJobMaxVital(ClassNum As Integer, Vital As VitalType) As Integer
        Select Case Vital
            Case VitalType.HP
                GetJobMaxVital = (1 + (Job(ClassNum).Stat(StatType.Vitality) \ 2) + Job(ClassNum).Stat(StatType.Vitality)) * 2
            Case VitalType.MP
                GetJobMaxVital = (1 + (Job(ClassNum).Stat(StatType.Intelligence) \ 2) + Job(ClassNum).Stat(StatType.Intelligence)) * 2
            Case VitalType.SP
                GetJobMaxVital = (1 + (Job(ClassNum).Stat(StatType.Spirit) \ 2) + Job(ClassNum).Stat(StatType.Spirit)) * 2
        End Select
    End Function

    Function GetJobName(ClassNum As Integer) As String
        GetJobName = Trim$(Job(ClassNum).Name)
    End Function

#End Region

#Region "Maps"

    Sub CheckMaps()
        For i = 0 To MAX_MAPS
            If Not File.Exists(Paths.Map(i)) Then
                SaveMap(i)
            End If
        Next

    End Sub

    Sub ClearMaps()
        For i = 0 To MAX_CACHED_MAPS
            ClearMap(i)
        Next
    End Sub

    Sub ClearMap(mapNum As Integer)
        Dim x As Integer
        Dim y As Integer

        Map(mapNum) = Nothing
        Map(mapNum).Tileset = 1
        Map(mapNum).Name = ""
        Map(mapNum).MaxX = MAX_MAPX
        Map(mapNum).MaxY = MAX_MAPY
        ReDim Map(mapNum).Npc(MAX_MAP_NPCS)
        ReDim Map(mapNum).Tile(Map(mapNum).MaxX, Map(mapNum).MaxY)

        For x = 0 To MAX_MAPX
            For y = 0 To MAX_MAPY
                ReDim Map(mapNum).Tile(x, y).Layer(LayerType.Count - 1)
            Next
        Next

        Map(mapNum).EventCount = 0
        ReDim Map(mapNum).Events(0)

        ' Reset the values for if a player is on the map or not
        PlayersOnMap(mapNum) = False
        Map(mapNum).Tileset = 1
        Map(mapNum).Name = ""
        Map(mapNum).Music = ""
        Map(mapNum).MaxX = MAX_MAPX
        Map(mapNum).MaxY = MAX_MAPY

        ClearTempTile(mapNum)

    End Sub

    Sub SaveMaps()
        Dim i As Integer

        For i = 0 To MAX_MAPS
            SaveMap(i)
            SaveMapEvent(i)
        Next

    End Sub

    Sub SaveMap(mapNum As Integer)
        Dim filename As String
        Dim x As Integer, y As Integer, l As Integer
        Dim writer As New ByteStream(100)

        filename = Paths.Map(mapNum)

        writer.WriteString(Map(mapNum).Name)
        writer.WriteString(Map(mapNum).Music)
        writer.WriteInt32(Map(mapNum).Revision)
        writer.WriteByte(Map(mapNum).Moral)
        writer.WriteInt32(Map(mapNum).Tileset)
        writer.WriteInt32(Map(mapNum).Up)
        writer.WriteInt32(Map(mapNum).Down)
        writer.WriteInt32(Map(mapNum).Left)
        writer.WriteInt32(Map(mapNum).Right)
        writer.WriteInt32(Map(mapNum).BootMap)
        writer.WriteByte(Map(mapNum).BootX)
        writer.WriteByte(Map(mapNum).BootY)
        writer.WriteByte(Map(mapNum).MaxX)
        writer.WriteByte(Map(mapNum).MaxY)
        writer.WriteByte(Map(mapNum).WeatherType)
        writer.WriteInt32(Map(mapNum).Fogindex)
        writer.WriteInt32(Map(mapNum).WeatherIntensity)
        writer.WriteByte(Map(mapNum).FogAlpha)
        writer.WriteByte(Map(mapNum).FogSpeed)
        writer.WriteByte(Map(mapNum).HasMapTint)
        writer.WriteByte(Map(mapNum).MapTintR)
        writer.WriteByte(Map(mapNum).MapTintG)
        writer.WriteByte(Map(mapNum).MapTintB)
        writer.WriteByte(Map(mapNum).MapTintA)

        writer.WriteByte(Map(mapNum).Instanced)
        writer.WriteByte(Map(mapNum).Panorama)
        writer.WriteByte(Map(mapNum).Parallax)

        For X = 0 To Map(mapNum).MaxX
            For Y = 0 To Map(mapNum).MaxY
                writer.WriteInt32(Map(mapNum).Tile(x, y).Data1)
                writer.WriteInt32(Map(mapNum).Tile(x, y).Data2)
                writer.WriteInt32(Map(mapNum).Tile(x, y).Data3)
                writer.WriteByte(Map(mapNum).Tile(x, y).DirBlock)
                For i = 0 To LayerType.Count - 1
                    writer.WriteByte(Map(mapNum).Tile(x, y).Layer(i).Tileset)
                    writer.WriteByte(Map(mapNum).Tile(x, y).Layer(i).X)
                    writer.WriteByte(Map(mapNum).Tile(x, y).Layer(i).Y)
                    writer.WriteByte(Map(mapNum).Tile(x, y).Layer(i).AutoTile)
                Next
                writer.WriteByte(Map(mapNum).Tile(x, y).Type)
            Next
        Next

        For x = 0 To MAX_MAP_NPCS
            writer.WriteInt32(Map(mapNum).Npc(x))
        Next

        ByteFile.Save(filename, writer)

    End Sub

    Sub SaveMapEvent(mapNum As Integer)
        Dim filename = Paths.EventMap(mapNum)
        Dim writer As New ByteStream(100)
 
        writer.WriteInt32(Map(mapNum).EventCount)
        For i = 0 To Map(mapNum).EventCount
            With Map(mapNum).Events(i)
                writer.WriteString(.Name)
                writer.WriteByte(.Globals)
                writer.WriteInt32(.X)
                writer.WriteInt32(.Y)
                writer.WriteInt32(.PageCount)
            End With

            If Map(mapNum).Events(i).PageCount > 0 Then
                For x = 0 To Map(mapNum).Events(i).PageCount
                    With Map(mapNum).Events(i).Pages(x)
                        writer.WriteInt32(.ChkVariable)
                        writer.WriteInt32(.Variableindex)
                        writer.WriteInt32(.VariableCondition)
                        writer.WriteInt32(.VariableCompare)

                        writer.WriteInt32(.ChkSwitch)
                        writer.WriteInt32(.Switchindex)
                        writer.WriteInt32(.SwitchCompare)

                        writer.WriteInt32(.ChkHasItem)
                        writer.WriteInt32(.HasItemindex)
                        writer.WriteInt32(.HasItemAmount)

                        writer.WriteInt32(.ChkSelfSwitch)
                        writer.WriteInt32(.SelfSwitchindex)
                        writer.WriteInt32(.SelfSwitchCompare)

                        writer.WriteByte(.GraphicType)
                        writer.WriteInt32(.Graphic)
                        writer.WriteInt32(.GraphicX)
                        writer.WriteInt32(.GraphicY)
                        writer.WriteInt32(.GraphicX2)
                        writer.WriteInt32(.GraphicY2)

                        writer.WriteByte(.MoveType)
                        writer.WriteByte(.MoveSpeed)
                        writer.WriteByte(.MoveFreq)

                        writer.WriteInt32(.IgnoreMoveRoute)
                        writer.WriteInt32(.RepeatMoveRoute)

                        writer.WriteInt32(.MoveRouteCount)

                        If .MoveRouteCount > 0 Then
                            For y = 0 To .MoveRouteCount
                                writer.WriteInt32(.MoveRoute(y).Index)
                                writer.WriteInt32(.MoveRoute(y).Data1)
                                writer.WriteInt32(.MoveRoute(y).Data2)
                                writer.WriteInt32(.MoveRoute(y).Data3)
                                writer.WriteInt32(.MoveRoute(y).Data4)
                                writer.WriteInt32(.MoveRoute(y).Data5)
                                writer.WriteInt32(.MoveRoute(y).Data6)
                            Next
                        End If

                        writer.WriteInt32(.WalkAnim)
                        writer.WriteInt32(.DirFix)
                        writer.WriteInt32(.WalkThrough)
                        writer.WriteInt32(.ShowName)
                        writer.WriteByte(.Trigger)
                        writer.WriteInt32(.CommandListCount)
                        writer.WriteByte(.Position)
                        writer.WriteInt32(.QuestNum)
                    End With

                    If Map(mapNum).Events(i).Pages(x).CommandListCount > 0 Then
                        For y = 0 To Map(mapNum).Events(i).Pages(x).CommandListCount
                            writer.WriteInt32(Map(mapNum).Events(i).Pages(x).CommandList(y).CommandCount)
                            writer.WriteInt32(Map(mapNum).Events(i).Pages(x).CommandList(y).ParentList)

                            If Map(mapNum).Events(i).Pages(x).CommandList(y).CommandCount > 0 Then
                                For z = 0 To Map(mapNum).Events(i).Pages(x).CommandList(y).CommandCount
                                    With Map(mapNum).Events(i).Pages(x).CommandList(y).Commands(z)
                                        writer.WriteByte(.Index)
                                        writer.WriteString(.Text1)
                                        writer.WriteString(.Text2)
                                        writer.WriteString(.Text3)
                                        writer.WriteString(.Text4)
                                        writer.WriteString(.Text5)
                                        writer.WriteInt32(.Data1)
                                        writer.WriteInt32(.Data2)
                                        writer.WriteInt32(.Data3)
                                        writer.WriteInt32(.Data4)
                                        writer.WriteInt32(.Data5)
                                        writer.WriteInt32(.Data6)
                                        writer.WriteInt32(.ConditionalBranch.CommandList)
                                        writer.WriteInt32(.ConditionalBranch.Condition)
                                        writer.WriteInt32(.ConditionalBranch.Data1)
                                        writer.WriteInt32(.ConditionalBranch.Data2)
                                        writer.WriteInt32(.ConditionalBranch.Data3)
                                        writer.WriteInt32(.ConditionalBranch.ElseCommandList)
                                        writer.WriteInt32(.MoveRouteCount)

                                        If .MoveRouteCount > 0 Then
                                            For w = 0 To .MoveRouteCount
                                                writer.WriteInt32(.MoveRoute(w).Index)
                                                writer.WriteInt32(.MoveRoute(w).Data1)
                                                writer.WriteInt32(.MoveRoute(w).Data2)
                                                writer.WriteInt32(.MoveRoute(w).Data3)
                                                writer.WriteInt32(.MoveRoute(w).Data4)
                                                writer.WriteInt32(.MoveRoute(w).Data5)
                                                writer.WriteInt32(.MoveRoute(w).Data6)
                                            Next
                                        End If
                                    End With
                                Next
                            End If
                        Next
                    End If
                Next
            End If
        Next

        ByteFile.Save(filename, writer)
    End Sub

    Sub LoadMapEvent(mapNum As Integer)
        Dim filename = Paths.EventMap(mapNum)

        If File.Exists(filename) = False Then Exit Sub

        Dim i As Integer, x As Integer, y As Integer, p As Integer
        Dim reader As New ByteStream()
        ByteFile.Load(filename, reader)

        Map(mapNum).EventCount = reader.ReadInt32()
        ReDim Map(mapNum).Events(Map(mapNum).EventCount)

        For i = 0 To Map(mapNum).EventCount
            With Map(mapNum).Events(i)
                .Name = reader.ReadString()
                .Globals = reader.ReadByte()
                .X = reader.ReadInt32()
                .Y = reader.ReadInt32()
                .PageCount = reader.ReadInt32()
            End With

            If Map(mapNum).Events(i).PageCount > 0 Then
                ReDim Map(mapNum).Events(i).Pages(Map(mapNum).Events(i).PageCount)
                For x = 0 To Map(mapNum).Events(i).PageCount
                    With Map(mapNum).Events(i).Pages(x)
                        .ChkVariable = reader.ReadInt32()
                        .Variableindex = reader.ReadInt32()
                        .VariableCondition = reader.ReadInt32()
                        .VariableCompare = reader.ReadInt32()

                        .ChkSwitch = reader.ReadInt32()
                        .Switchindex = reader.ReadInt32()
                        .SwitchCompare = reader.ReadInt32()

                        .ChkHasItem = reader.ReadInt32()
                        .HasItemindex = reader.ReadInt32()
                        .HasItemAmount = reader.ReadInt32()

                        .ChkSelfSwitch = reader.ReadInt32()
                        .SelfSwitchindex = reader.ReadInt32()
                        .SelfSwitchCompare = reader.ReadInt32()

                        .GraphicType = reader.ReadByte()
                        .Graphic = reader.ReadInt32()
                        .GraphicX = reader.ReadInt32()
                        .GraphicY = reader.ReadInt32()
                        .GraphicX2 = reader.ReadInt32()
                        .GraphicY2 = reader.ReadInt32()

                        .MoveType = reader.ReadByte()
                        .MoveSpeed = reader.ReadByte()
                        .MoveFreq = reader.ReadByte()
                        .IgnoreMoveRoute = reader.ReadInt32()
                        .RepeatMoveRoute = reader.ReadInt32()
                        .MoveRouteCount = reader.ReadInt32()

                        If .MoveRouteCount > 0 Then
                            ReDim Preserve Map(mapNum).Events(i).Pages(x).MoveRoute(.MoveRouteCount)
                            For y = 0 To .MoveRouteCount
                                .MoveRoute(y).Index = reader.ReadInt32()
                                .MoveRoute(y).Data1 = reader.ReadInt32()
                                .MoveRoute(y).Data2 = reader.ReadInt32()
                                .MoveRoute(y).Data3 = reader.ReadInt32()
                                .MoveRoute(y).Data4 = reader.ReadInt32()
                                .MoveRoute(y).Data5 = reader.ReadInt32()
                                .MoveRoute(y).Data6 = reader.ReadInt32()
                            Next
                        End If

                        .WalkAnim = reader.ReadInt32()
                        .DirFix = reader.ReadInt32()
                        .WalkThrough = reader.ReadInt32()
                        .ShowName = reader.ReadInt32()
                        .Trigger = reader.ReadByte()
                        .CommandListCount = reader.ReadInt32()
                        .Position = reader.ReadByte()
                        .QuestNum = reader.ReadInt32()
                    End With

                    If Map(mapNum).Events(i).Pages(x).CommandListCount > 0 Then
                        ReDim Map(mapNum).Events(i).Pages(x).CommandList(Map(mapNum).Events(i).Pages(x).CommandListCount)
                        For y = 0 To Map(mapNum).Events(i).Pages(x).CommandListCount
                            Map(mapNum).Events(i).Pages(x).CommandList(y).CommandCount = reader.ReadInt32()
                            Map(mapNum).Events(i).Pages(x).CommandList(y).ParentList = reader.ReadInt32()
                            If Map(mapNum).Events(i).Pages(x).CommandList(y).CommandCount > 0 Then
                                ReDim Map(mapNum).Events(i).Pages(x).CommandList(y).Commands(Map(mapNum).Events(i).Pages(x).CommandList(y).CommandCount)
                                For p = 0 To Map(mapNum).Events(i).Pages(x).CommandList(y).CommandCount
                                    With Map(mapNum).Events(i).Pages(x).CommandList(y).Commands(p)
                                        .Index = reader.ReadByte()
                                        .Text1 = reader.ReadString()
                                        .Text2 = reader.ReadString()
                                        .Text3 = reader.ReadString()
                                        .Text4 = reader.ReadString()
                                        .Text5 = reader.ReadString()
                                        .Data1 = reader.ReadInt32()
                                        .Data2 = reader.ReadInt32()
                                        .Data3 = reader.ReadInt32()
                                        .Data4 = reader.ReadInt32()
                                        .Data5 = reader.ReadInt32()
                                        .Data6 = reader.ReadInt32()
                                        .ConditionalBranch.CommandList = reader.ReadInt32()
                                        .ConditionalBranch.Condition = reader.ReadInt32()
                                        .ConditionalBranch.Data1 = reader.ReadInt32()
                                        .ConditionalBranch.Data2 = reader.ReadInt32()
                                        .ConditionalBranch.Data3 = reader.ReadInt32()
                                        .ConditionalBranch.ElseCommandList = reader.ReadInt32()
                                        .MoveRouteCount = reader.ReadInt32()
                                        If .MoveRouteCount > 0 Then
                                            ReDim .MoveRoute(.MoveRouteCount)
                                            For w = 0 To .MoveRouteCount
                                                .MoveRoute(w).Index = reader.ReadInt32()
                                                .MoveRoute(w).Data1 = reader.ReadInt32()
                                                .MoveRoute(w).Data2 = reader.ReadInt32()
                                                .MoveRoute(w).Data3 = reader.ReadInt32()
                                                .MoveRoute(w).Data4 = reader.ReadInt32()
                                                .MoveRoute(w).Data5 = reader.ReadInt32()
                                                .MoveRoute(w).Data6 = reader.ReadInt32()
                                            Next
                                        End If
                                    End With
                                Next
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Sub LoadMaps()
        Dim i As Integer

        CheckMaps()

        For i = 0 To MAX_MAPS
            LoadMap(i)
        Next
    End Sub

    Sub LoadMap(mapNum As Integer)
        Dim filename As String
        Dim x As Integer
        Dim y As Integer
        Dim l As Integer

        filename = Paths.Map(mapNum)
        Dim reader As New ByteStream()
        ByteFile.Load(filename, reader)

        Map(mapNum).Name = reader.ReadString()
        Map(mapNum).Music = reader.ReadString()
        Map(mapNum).Revision = reader.ReadInt32()
        Map(mapNum).Moral = reader.ReadByte()
        Map(mapNum).Tileset = reader.ReadInt32()
        Map(mapNum).Up = reader.ReadInt32()
        Map(mapNum).Down = reader.ReadInt32()
        Map(mapNum).Left = reader.ReadInt32()
        Map(mapNum).Right = reader.ReadInt32()
        Map(mapNum).BootMap = reader.ReadInt32()
        Map(mapNum).BootX = reader.ReadByte()
        Map(mapNum).BootY = reader.ReadByte()
        Map(mapNum).MaxX = reader.ReadByte()
        Map(mapNum).MaxY = reader.ReadByte()
        Map(mapNum).WeatherType = reader.ReadByte()
        Map(mapNum).Fogindex = reader.ReadInt32()
        Map(mapNum).WeatherIntensity = reader.ReadInt32()
        Map(mapNum).FogAlpha = reader.ReadByte()
        Map(mapNum).FogSpeed = reader.ReadByte()
        Map(mapNum).HasMapTint = reader.ReadByte()
        Map(mapNum).MapTintR = reader.ReadByte()
        Map(mapNum).MapTintG = reader.ReadByte()
        Map(mapNum).MapTintB = reader.ReadByte()
        Map(mapNum).MapTintA = reader.ReadByte()
        Map(mapNum).Instanced = reader.ReadByte()
        Map(mapNum).Panorama = reader.ReadByte()
        Map(mapNum).Parallax = reader.ReadByte()

        ' have to set the tile()
        ReDim Map(mapNum).Tile(Map(mapNum).MaxX, Map(mapNum).MaxY)

        For X = 0 To Map(mapNum).MaxX
            For Y = 0 To Map(mapNum).MaxY
                Map(mapNum).Tile(x, y).Data1 = reader.ReadInt32()
                Map(mapNum).Tile(x, y).Data2 = reader.ReadInt32()
                Map(mapNum).Tile(x, y).Data3 = reader.ReadInt32()
                Map(mapNum).Tile(x, y).DirBlock = reader.ReadByte()
                ReDim Map(mapNum).Tile(x, y).Layer(LayerType.Count - 1)
                For l = 0 To LayerType.Count - 1
                    Map(mapNum).Tile(x, y).Layer(l).Tileset = reader.ReadByte()
                    Map(mapNum).Tile(x, y).Layer(l).X = reader.ReadByte()
                    Map(mapNum).Tile(x, y).Layer(l).Y = reader.ReadByte()
                    Map(mapNum).Tile(x, y).Layer(l).AutoTile = reader.ReadByte()
                Next
                Map(mapNum).Tile(x, y).Type = reader.ReadByte()
            Next
        Next

        For x = 0 To MAX_MAP_NPCS
            Map(mapNum).Npc(x) = reader.ReadInt32()
            MapNpc(mapNum).Npc(x).Num = Map(mapNum).Npc(x)
        Next

        ClearTempTile(mapNum)
        CacheResources(mapNum)

        If Map(mapNum).Name Is Nothing Then Map(mapNum).Name = ""
        If Map(mapNum).Music Is Nothing Then Map(mapNum).Music = ""

        LoadMapEvent(mapNum)
    End Sub

    Sub ClearTempTiles()
        ReDim TempTile(MAX_CACHED_MAPS)

        For i = 0 To MAX_CACHED_MAPS
            ClearTempTile(i)
        Next

    End Sub

    Sub ClearTempTile(mapNum As Integer)
        Dim y As Integer
        Dim x As Integer
        TempTile(mapNum).DoorTimer = 0
        ReDim TempTile(mapNum).DoorOpen(Map(mapNum).MaxX, Map(mapNum).MaxY)

        For X = 0 To Map(mapNum).MaxX
            For Y = 0 To Map(mapNum).MaxY
                TempTile(mapNum).DoorOpen(x, y) = False
            Next
        Next

    End Sub

    Sub ClearMapItem(index As Integer, mapNum As Integer)
        MapItem(mapNum, index) = Nothing
        MapItem(mapNum, index).RandData.Prefix = ""
        MapItem(mapNum, index).RandData.Suffix = ""
    End Sub

    Sub ClearMapItems()
        Dim x As Integer
        Dim y As Integer

        For y = 0 To MAX_CACHED_MAPS
            For x = 0 To MAX_MAP_ITEMS
                ClearMapItem(x, y)
            Next
        Next

    End Sub

#End Region

#Region "Npc's"

    Sub SaveNpcs()
        Dim i As Integer

        For i = 0 To MAX_NPCS
            SaveNpc(i)
            Application.DoEvents()
        Next

    End Sub

    Sub SaveNpc(NpcNum As Integer)
        Dim filename As String
        Dim i As Integer
        filename = Paths.Npc(NpcNum)

        Dim writer As New ByteStream(100)
        writer.WriteString(Npc(NpcNum).Name)
        writer.WriteString(Npc(NpcNum).AttackSay)
        writer.WriteInt32(Npc(NpcNum).Sprite)
        writer.WriteByte(Npc(NpcNum).SpawnTime)
        writer.WriteInt32(Npc(NpcNum).SpawnSecs)
        writer.WriteByte(Npc(NpcNum).Behaviour)
        writer.WriteByte(Npc(NpcNum).Range)

        For i = 0 To MAX_DROP_ITEMS
            writer.WriteInt32(Npc(NpcNum).DropChance(i))
            writer.WriteInt32(Npc(NpcNum).DropItem(i))
            writer.WriteInt32(Npc(NpcNum).DropItemValue(i))
        Next

        For i = 0 To StatType.Count - 1
            writer.WriteByte(Npc(NpcNum).Stat(i))
        Next

        writer.WriteByte(Npc(NpcNum).Faction)
        writer.WriteInt32(Npc(NpcNum).Hp)
        writer.WriteInt32(Npc(NpcNum).Exp)
        writer.WriteInt32(Npc(NpcNum).Animation)

        writer.WriteInt32(Npc(NpcNum).QuestNum)

        For i = 0 To MAX_NPC_SKILLS
            writer.WriteByte(Npc(NpcNum).Skill(i))
        Next

        writer.WriteInt32(Npc(NpcNum).Level)
        writer.WriteInt32(Npc(NpcNum).Damage)

        ByteFile.Save(filename, writer)
    End Sub

    Sub LoadNpcs()
        Dim i As Integer

        CheckNpcs()

        For i = 0 To MAX_NPCS
            LoadNpc(i)
            Application.DoEvents()
        Next
    End Sub

    Sub LoadNpc(NpcNum As Integer)
        Dim filename As String
        Dim n As Integer

        filename = Paths.Npc(NpcNum)
        Dim reader As New ByteStream()
        ByteFile.Load(filename, reader)

        Npc(NpcNum).Name = reader.ReadString()
        Npc(NpcNum).AttackSay = reader.ReadString()
        Npc(NpcNum).Sprite = reader.ReadInt32()
        Npc(NpcNum).SpawnTime = reader.ReadByte()
        Npc(NpcNum).SpawnSecs = reader.ReadInt32()
        Npc(NpcNum).Behaviour = reader.ReadByte()
        Npc(NpcNum).Range = reader.ReadByte()

        For i = 0 To MAX_DROP_ITEMS
            Npc(NpcNum).DropChance(i) = reader.ReadInt32()
            Npc(NpcNum).DropItem(i) = reader.ReadInt32()
            Npc(NpcNum).DropItemValue(i) = reader.ReadInt32()
        Next

        For n = 0 To StatType.Count - 1
            Npc(NpcNum).Stat(n) = reader.ReadByte()
        Next

        Npc(NpcNum).Faction = reader.ReadByte()
        Npc(NpcNum).Hp = reader.ReadInt32()
        Npc(NpcNum).Exp = reader.ReadInt32()
        Npc(NpcNum).Animation = reader.ReadInt32()

        Npc(NpcNum).QuestNum = reader.ReadInt32()

        For i = 0 To MAX_NPC_SKILLS
            Npc(NpcNum).Skill(i) = reader.ReadByte()
        Next

        Npc(NpcNum).Level = reader.ReadInt32()
        Npc(NpcNum).Damage = reader.ReadInt32()

        If Npc(NpcNum).Name Is Nothing Then Npc(NpcNum).Name = ""
        If Npc(NpcNum).AttackSay Is Nothing Then Npc(NpcNum).AttackSay = ""
    End Sub

    Sub CheckNpcs()
        Dim i As Integer

        For i = 0 To MAX_NPCS
            If Not File.Exists(Paths.Npc(i)) Then
                SaveNpc(i)
                Application.DoEvents()
            End If

        Next

    End Sub

    Sub ClearMapNpc(index As Integer, mapNum As Integer)
        ReDim MapNpc(mapNum).Npc(index).Vital(VitalType.Count - 1)
        ReDim MapNpc(mapNum).Npc(index).SkillCd(MAX_NPC_SKILLS)
    End Sub

    Sub ClearAllMapNpcs()
        Dim i As Integer

        For i = 0 To MAX_CACHED_MAPS
            ClearMapNpcs(i)
            Application.DoEvents()
        Next

    End Sub

    Sub ClearMapNpcs(mapNum As Integer)
        Dim x As Integer
        Dim y As Integer

        For x = 0 To MAX_MAP_NPCS
            For y = 0 To MAX_MAPS
                ClearMapNpc(x, y)
            Next
        Next

    End Sub

    Sub ClearNpc(index As Integer)
        Npc(index) = Nothing
        Npc(index).Name = ""
        Npc(index).AttackSay = ""
        ReDim Npc(index).Stat(StatType.Count - 1)
        For i = 0 To MAX_DROP_ITEMS
            ReDim Npc(index).DropChance(5)
            ReDim Npc(index).DropItem(5)
            ReDim Npc(index).DropItemValue(5)
            ReDim Npc(index).Skill(MAX_NPC_SKILLS)
        Next
    End Sub

    Sub ClearNpcs()
        For i = 0 To MAX_NPCS
            ClearNpc(i)
        Next

    End Sub

#End Region

#Region "Shops"

    Sub SaveShops()
        Dim i As Integer

        For i = 0 To MAX_SHOPS
            SaveShop(i)
            Application.DoEvents()
        Next

    End Sub

    Sub SaveShop(shopNum As Integer)
        Dim i As Integer
        Dim filename As String

        filename = Paths.Shop(shopNum)

        Dim writer As New ByteStream(100)

        writer.WriteString(Shop(shopNum).Name)
        writer.WriteByte(Shop(shopNum).Face)
        writer.WriteInt32(Shop(shopNum).BuyRate)

        For i = 0 To MAX_TRADES
            writer.WriteInt32(Shop(shopNum).TradeItem(i).Item)
            writer.WriteInt32(Shop(shopNum).TradeItem(i).ItemValue)
            writer.WriteInt32(Shop(shopNum).TradeItem(i).CostItem)
            writer.WriteInt32(Shop(shopNum).TradeItem(i).CostValue)
        Next

        ByteFile.Save(filename, writer)
    End Sub

    Sub LoadShops()

        Dim i As Integer

        CheckShops()

        For i = 0 To MAX_SHOPS
            LoadShop(i)
            Application.DoEvents()
        Next

    End Sub

    Sub LoadShop(ShopNum As Integer)
        Dim filename As String
        Dim x As Integer

        filename = Paths.Shop(ShopNum)
        Dim reader As New ByteStream()
        ByteFile.Load(filename, reader)

        Shop(ShopNum).Name = reader.ReadString()
        Shop(ShopNum).Face = reader.ReadByte()
        Shop(ShopNum).BuyRate = reader.ReadInt32()

        For x = 0 To MAX_TRADES
            Shop(ShopNum).TradeItem(x).Item = reader.ReadInt32()
            Shop(ShopNum).TradeItem(x).ItemValue = reader.ReadInt32()
            Shop(ShopNum).TradeItem(x).CostItem = reader.ReadInt32()
            Shop(ShopNum).TradeItem(x).CostValue = reader.ReadInt32()
        Next

    End Sub

    Sub CheckShops()
        Dim i As Integer

        For i = 0 To MAX_SHOPS

            If Not File.Exists(Paths.Shop(i)) Then
                SaveShop(i)
            End If

        Next

    End Sub

    Sub ClearShop(index As Integer)
        Dim i As Integer

        Shop(index) = Nothing
        Shop(index).Name = ""

        ReDim Shop(index).TradeItem(MAX_TRADES)
        For i = 0 To MAX_SHOPS
            ReDim Shop(i).TradeItem(MAX_TRADES)
        Next

    End Sub

    Sub ClearShops()
        For i = 0 To MAX_SHOPS
            Call ClearShop(i)
        Next
    End Sub

#End Region

#Region "Skills"

    Sub SaveSkills()
        Dim i As Integer
        Console.WriteLine("Saving skills... ")

        For i = 0 To MAX_SKILLS
            SaveSkill(i)
            Application.DoEvents()
        Next

    End Sub

    Sub SaveSkill(skillnum As Integer)
        Dim filename As String
        filename = Paths.Skill(skillnum)

        Dim writer As New ByteStream(100)

        writer.WriteString(Skill(skillnum).Name)
        writer.WriteByte(Skill(skillnum).Type)
        writer.WriteInt32(Skill(skillnum).MpCost)
        writer.WriteInt32(Skill(skillnum).LevelReq)
        writer.WriteInt32(Skill(skillnum).AccessReq)
        writer.WriteInt32(Skill(skillnum).ClassReq)
        writer.WriteInt32(Skill(skillnum).CastTime)
        writer.WriteInt32(Skill(skillnum).CdTime)
        writer.WriteInt32(Skill(skillnum).Icon)
        writer.WriteInt32(Skill(skillnum).Map)
        writer.WriteInt32(Skill(skillnum).X)
        writer.WriteInt32(Skill(skillnum).Y)
        writer.WriteByte(Skill(skillnum).Dir)
        writer.WriteInt32(Skill(skillnum).Vital)
        writer.WriteInt32(Skill(skillnum).Duration)
        writer.WriteInt32(Skill(skillnum).Interval)
        writer.WriteInt32(Skill(skillnum).Range)
        writer.WriteBoolean(Skill(skillnum).IsAoE)
        writer.WriteInt32(Skill(skillnum).AoE)
        writer.WriteInt32(Skill(skillnum).CastAnim)
        writer.WriteInt32(Skill(skillnum).SkillAnim)
        writer.WriteInt32(Skill(skillnum).StunDuration)

        writer.WriteInt32(Skill(skillnum).IsProjectile)
        writer.WriteInt32(Skill(skillnum).Projectile)

        writer.WriteByte(Skill(skillnum).KnockBack)
        writer.WriteByte(Skill(skillnum).KnockBackTiles)

        ByteFile.Save(filename, writer)
    End Sub

    Sub LoadSkills()
        Dim i As Integer

        CheckSkills()

        For i = 0 To MAX_SKILLS
            LoadSkill(i)
            Application.DoEvents()
        Next

    End Sub

    Sub LoadSkill(SkillNum As Integer)
        Dim filename As String

        filename = Paths.Skill(SkillNum)
        Dim reader As New ByteStream()
        ByteFile.Load(filename, reader)

        Skill(SkillNum).Name = reader.ReadString()
        Skill(SkillNum).Type = reader.ReadByte()
        Skill(SkillNum).MpCost = reader.ReadInt32()
        Skill(SkillNum).LevelReq = reader.ReadInt32()
        Skill(SkillNum).AccessReq = reader.ReadInt32()
        Skill(SkillNum).ClassReq = reader.ReadInt32()
        Skill(SkillNum).CastTime = reader.ReadInt32()
        Skill(SkillNum).CdTime = reader.ReadInt32()
        Skill(SkillNum).Icon = reader.ReadInt32()
        Skill(SkillNum).Map = reader.ReadInt32()
        Skill(SkillNum).X = reader.ReadInt32()
        Skill(SkillNum).Y = reader.ReadInt32()
        Skill(SkillNum).Dir = reader.ReadByte()
        Skill(SkillNum).Vital = reader.ReadInt32()
        Skill(SkillNum).Duration = reader.ReadInt32()
        Skill(SkillNum).Interval = reader.ReadInt32()
        Skill(SkillNum).Range = reader.ReadInt32()
        Skill(SkillNum).IsAoE = reader.ReadBoolean()
        Skill(SkillNum).AoE = reader.ReadInt32()
        Skill(SkillNum).CastAnim = reader.ReadInt32()
        Skill(SkillNum).SkillAnim = reader.ReadInt32()
        Skill(SkillNum).StunDuration = reader.ReadInt32()

        Skill(SkillNum).IsProjectile = reader.ReadInt32()
        Skill(SkillNum).Projectile = reader.ReadInt32()

        Skill(SkillNum).KnockBack = reader.ReadByte()
        Skill(SkillNum).KnockBackTiles = reader.ReadByte()

    End Sub

    Sub CheckSkills()
        Dim i As Integer

        For i = 0 To MAX_SKILLS

            If Not File.Exists(Paths.Skill(i)) Then
                SaveSkill(i)
                Application.DoEvents()
            End If

        Next

    End Sub

    Sub ClearSkill(index As Integer)
        Skill(index) = Nothing
        Skill(index).Name = ""
        Skill(index).LevelReq = 1 'Needs to be 1 for the skill editor
    End Sub

    Sub ClearSkills()
        For i = 0 To MAX_SKILLS
            ClearSkill(i)
        Next

    End Sub

#End Region

#Region "Accounts"

    Function AccountExist(Name As String) As Boolean
        Return File.Exists(Paths.Database & "Accounts\" & Trim$(Name) & "\Data.bin")
    End Function

    Function PasswordOK(Name As String, Password As String) As Boolean
        If Not AccountExist(Name) Then Return False
        Dim reader As New ByteStream()
        ByteFile.Load(Paths.Database & "Accounts\" & Trim$(Name) & "\Data.bin", reader)
        If reader.ReadString().Trim <> Name.Trim Then Return False
        Return reader.ReadString().Trim.ToUpper = Password.Trim.ToUpper
    End Function

    Sub AddAccount(index As Integer, Name As String, Password As String)
        ClearPlayer(index)

        Player(index).Login = Name
        Player(index).Password = Password

        SavePlayer(index)
    End Sub

    Sub DeleteName(Name As String)
        TextFile.RemoveString(Paths.Database & "Accounts\charlist.txt", Name.Trim.ToLower)
    End Sub

#End Region

#Region "Players"

    Sub SaveAllPlayersOnline()
        For i = 0 To GetPlayersOnline()
            If Not IsPlaying(i) Then Continue For
            SavePlayer(i)
            SaveBank(i)
        Next
    End Sub

    Sub SavePlayer(index As Integer)
        Dim playername As String = Trim$(Player(index).Login)
        Dim filename As String = Paths.Database & "Accounts\" & playername
        CheckDir(filename) : filename += "\Data.bin"

        Dim writer As New ByteStream(9 + Player(index).Login.Length + Player(index).Password.Length)

        writer.WriteString(Player(index).Login)
        writer.WriteString(Player(index).Password)
        writer.WriteByte(Player(index).Access)

        ByteFile.Save(filename, writer)

        SaveCharacter(index)
    End Sub

    Sub LoadPlayer(index As Integer, Name As String)
        Dim filename As String = Paths.Database & "Accounts\" & Name.Trim() & "\Data.bin"
        ClearPlayer(index)
        Dim reader As New ByteStream()
        ByteFile.Load(filename, reader)

        Player(index).Login = reader.ReadString()
        Player(index).Password = reader.ReadString()
        Player(index).Access = reader.ReadByte()

        LoadCharacter(index)
    End Sub

    Sub ClearPlayer(index As Integer)
        ReDim TempPlayer(index).SkillCd(MAX_PLAYER_SKILLS)
        ReDim TempPlayer(index).PetSkillCd(4)

        Player(index).Login = ""
        Player(index).Password = ""

        Player(index).Access = 0
        ClearCharacter(index)
    End Sub

#End Region

#Region "Bank"

    Friend Sub LoadBank(index As Integer, Name As String)
        Dim filename As String = Paths.Database & "Accounts\" & Name.Trim() & "\Bank.bin"

        ClearBank(index)

        If Not File.Exists(filename) Then
            SaveBank(index)
            Exit Sub
        End If

        Dim reader As New ByteStream()
        ByteFile.Load(filename, reader)

        For i = 0 To MAX_BANK
            Bank(index).Item(i).Num = reader.ReadByte()
            Bank(index).Item(i).Value = reader.ReadInt32()

            Bank(index).ItemRand(i).Prefix = reader.ReadString()
            Bank(index).ItemRand(i).Suffix = reader.ReadString()
            Bank(index).ItemRand(i).Rarity = reader.ReadInt32()
            Bank(index).ItemRand(i).Damage = reader.ReadInt32()
            Bank(index).ItemRand(i).Speed = reader.ReadInt32()

            For X = 0 To StatType.Count - 1
                Bank(index).ItemRand(i).Stat(x) = reader.ReadInt32()
            Next
        Next
    End Sub

    Sub SaveBank(index As Integer)
        Dim filename = Paths.Database & "Accounts\" & Player(index).Login.Trim() & "\Bank.bin"

        Dim writer As New ByteStream(100)

        For i = 0 To MAX_BANK
            writer.WriteByte(Bank(index).Item(i).Num)
            writer.WriteInt32(Bank(index).Item(i).Value)

            If Bank(index).ItemRand(i).Prefix = Nothing Then Bank(index).ItemRand(i).Prefix = ""
            If Bank(index).ItemRand(i).Suffix = Nothing Then Bank(index).ItemRand(i).Suffix = ""

            writer.WriteString(Bank(index).ItemRand(i).Prefix)
            writer.WriteString(Bank(index).ItemRand(i).Suffix)
            writer.WriteInt32(Bank(index).ItemRand(i).Rarity)
            writer.WriteInt32(Bank(index).ItemRand(i).Damage)
            writer.WriteInt32(Bank(index).ItemRand(i).Speed)

            For X = 0 To StatType.Count - 1
                writer.WriteInt32(Bank(index).ItemRand(i).Stat(x))
            Next

            'writer.WriteInt32(Bank(Index).ItemRand(i).Stat(Stats.Strength))
            'writer.WriteInt32(Bank(Index).ItemRand(i).Stat(Stats.Endurance))
            'writer.WriteInt32(Bank(Index).ItemRand(i).Stat(Stats.Vitality))
            'writer.WriteInt32(Bank(Index).ItemRand(i).Stat(Stats.Luck))
            'writer.WriteInt32(Bank(Index).ItemRand(i).Stat(Stats.Intelligence))
            'writer.WriteInt32(Bank(Index).ItemRand(i).Stat(Stats.Spirit))
        Next

        ByteFile.Save(filename, writer)
    End Sub

    Sub ClearBank(index As Integer)
        ReDim Bank(index).Item(MAX_BANK)
        ReDim Bank(index).ItemRand(MAX_BANK)

        For i = 0 To MAX_BANK

            Bank(index).Item(i).Num = 0
            Bank(index).Item(i).Value = 0
            Bank(index).ItemRand(i).Prefix = ""
            Bank(index).ItemRand(i).Suffix = ""
            Bank(index).ItemRand(i).Rarity = 0
            Bank(index).ItemRand(i).Damage = 0
            Bank(index).ItemRand(i).Speed = 0

            ReDim Bank(index).ItemRand(i).Stat(StatType.Count - 1)
            For X = 0 To StatType.Count - 1
                Bank(index).ItemRand(i).Stat(x) = 0
            Next
        Next
    End Sub

#End Region

#Region "Characters"

    Sub ClearCharacter(index As Integer)
       Player(Index).Job = 0
       Player(Index).Dir = 0

        ReDim Player(index).Equipment(EquipmentType.Count - 1)
        For i = 0 To EquipmentType.Count - 1
           Player(Index).Equipment(i) = 0
        Next

        ReDim Player(index).Inv(MAX_INV)
        For i = 0 To MAX_INV
           Player(Index).Inv(i).Num = 0
           Player(Index).Inv(i).Value = 0
        Next

       Player(Index).Exp = 0
       Player(Index).Level = 0
       Player(Index).Map = 0
       Player(Index).Name = ""
       Player(Index).Pk = 0
       Player(Index).Points = 0
       Player(Index).Sex = 0

        ReDim Player(index).Skill(MAX_PLAYER_SKILLS)
        For i = 0 To MAX_PLAYER_SKILLS
           Player(Index).Skill(i) = 0
        Next

       Player(Index).Sprite = 0

        ReDim Player(index).Stat(StatType.Count - 1)
        For i = 0 To StatType.Count - 1
           Player(Index).Stat(i) = 0
        Next

        ReDim Player(index).Vital(VitalType.Count - 1)
        For i = 0 To VitalType.Count - 1
           Player(Index).Vital(i) = 0
        Next

       Player(Index).X = 0
       Player(Index).Y = 0

        ReDim Player(Index).PlayerQuest(MAX_QUESTS)
        For i = 0 To MAX_QUESTS
           Player(Index).PlayerQuest(i).Status = 0
           Player(Index).PlayerQuest(i).ActualTask = 0
           Player(Index).PlayerQuest(i).CurrentCount = 0
        Next

        ' Housing
        Player(Index).House.Houseindex = 0
        Player(Index).House.FurnitureCount = 0
        ReDim Player(Index).House.Furniture(Player(index).House.FurnitureCount)

        For i = 0 To Player(Index).House.FurnitureCount
           Player(Index).House.Furniture(i).ItemNum = 0
           Player(Index).House.Furniture(i).X = 0
           Player(Index).House.Furniture(i).Y = 0
        Next

       Player(Index).InHouse = 0
       Player(Index).LastMap = 0
       Player(Index).LastX = 0
       Player(Index).LastY = 0

        ReDim Player(Index).Hotbar(MAX_HOTBAR)
        For i = 0 To MAX_HOTBAR
           Player(Index).Hotbar(i).Slot = 0
           Player(Index).Hotbar(i).SlotType = 0
        Next

        ReDim Player(Index).Switches(MAX_SWITCHES)
        For i = 0 To MAX_SWITCHES
           Player(Index).Switches(i) = 0
        Next
        ReDim Player(Index).Variables(MAX_VARIABLES)
        For i = 0 To MAX_VARIABLES
           Player(Index).Variables(i) = 0
        Next

        ReDim Player(Index).GatherSkills(ResourceSkills.Count - 1)
        For i = 0 To ResourceSkills.Count - 1
           Player(Index).GatherSkills(i).SkillLevel = 1
           Player(Index).GatherSkills(i).SkillCurExp = 0
           Player(Index).GatherSkills(i).SkillNextLvlExp = 100
        Next

        ReDim Player(Index).RecipeLearned(MAX_RECIPE)
        For i = 0 To MAX_RECIPE
           Player(Index).RecipeLearned(i) = 0
        Next

        'random items
        ReDim Player(Index).RandInv(MAX_INV)
        For i = 0 To MAX_INV
           Player(Index).RandInv(i).Prefix = ""
           Player(Index).RandInv(i).Suffix = ""
           Player(Index).RandInv(i).Rarity = 0
           Player(Index).RandInv(i).Damage = 0
           Player(Index).RandInv(i).Speed = 0

            ReDim Player(Index).RandInv(i).Stat(StatType.Count - 1)
            For X = 0 To StatType.Count - 1
               Player(Index).RandInv(i).Stat(x) = 0
            Next
        Next

        ReDim Player(Index).RandEquip(EquipmentType.Count - 1)
        For i = 0 To EquipmentType.Count - 1
           Player(Index).RandEquip(i).Prefix = ""
           Player(Index).RandEquip(i).Suffix = ""
           Player(Index).RandEquip(i).Rarity = 0
           Player(Index).RandEquip(i).Damage = 0
           Player(Index).RandEquip(i).Speed = 0

            ReDim Player(Index).RandEquip(i).Stat(StatType.Count - 1)
            For X = 0 To StatType.Count - 1
               Player(Index).RandEquip(i).Stat(x) = 0
            Next
        Next

        Player(Index).Pet.Num = 0
        Player(Index).Pet.Health = 0
        Player(Index).Pet.Mana = 0
        Player(Index).Pet.Level = 0

        ReDim Player(Index).Pet.Stat(StatType.Count - 1)
        For i = 0 To StatType.Count - 1
           Player(Index).Pet.Stat(i) = 0
        Next

        ReDim Player(Index).Pet.Skill(4)
        For i = 0 To 4
           Player(Index).Pet.Skill(i) = 0
        Next

       Player(Index).Pet.X = 0
       Player(Index).Pet.Y = 0
       Player(Index).Pet.Dir = 0
       Player(Index).Pet.Alive = 0
       Player(Index).Pet.AttackBehaviour = 0
       Player(Index).Pet.AdoptiveStats = 0
       Player(Index).Pet.Points = 0
       Player(Index).Pet.Exp = 0

    End Sub

    Sub LoadCharacter(index As Integer)
        Dim filename As String = Paths.Database & "Accounts\" & Player(index).Login.Trim & ".bin"

        ClearCharacter(index)

        Dim reader As New ByteStream()
        ByteFile.Load(filename, reader)

       Player(Index).Job = reader.ReadByte()
       Player(Index).Dir = reader.ReadByte()

        For i = 0 To EquipmentType.Count - 1
           Player(Index).Equipment(i) = reader.ReadByte()
        Next

       Player(Index).Exp = reader.ReadInt32()

        For i = 0 To MAX_INV
           Player(Index).Inv(i).Num = reader.ReadByte()
           Player(Index).Inv(i).Value = reader.ReadInt32()
        Next

       Player(Index).Level = reader.ReadByte()
       Player(Index).Map = reader.ReadInt32()
       Player(Index).Name = reader.ReadString()
       Player(Index).Pk = reader.ReadByte()
       Player(Index).Points = reader.ReadByte()
       Player(Index).Sex = reader.ReadByte()

        For i = 0 To MAX_PLAYER_SKILLS
           Player(Index).Skill(i) = reader.ReadByte()
        Next

       Player(Index).Sprite = reader.ReadInt32()

        For i = 0 To StatType.Count - 1
           Player(Index).Stat(i) = reader.ReadByte()
        Next

        For i = 0 To VitalType.Count - 1
           Player(Index).Vital(i) = reader.ReadInt32()
        Next

       Player(Index).X = reader.ReadByte()
       Player(Index).Y = reader.ReadByte()

        For i = 0 To MAX_QUESTS
           Player(Index).PlayerQuest(i).Status = reader.ReadInt32()
           Player(Index).PlayerQuest(i).ActualTask = reader.ReadInt32()
           Player(Index).PlayerQuest(i).CurrentCount = reader.ReadInt32()
        Next

        'Housing
       Player(Index).House.Houseindex = reader.ReadInt32()
       Player(Index).House.FurnitureCount = reader.ReadInt32()
        ReDim Player(Index).House.Furniture(Player(index).House.FurnitureCount)
        For i = 0 To Player(Index).House.FurnitureCount
           Player(Index).House.Furniture(i).ItemNum = reader.ReadInt32()
           Player(Index).House.Furniture(i).X = reader.ReadInt32()
           Player(Index).House.Furniture(i).Y = reader.ReadInt32()
        Next
       Player(Index).InHouse = reader.ReadInt32()
       Player(Index).LastMap = reader.ReadInt32()
       Player(Index).LastX = reader.ReadInt32()
       Player(Index).LastY = reader.ReadInt32()

        For i = 0 To MAX_HOTBAR
           Player(Index).Hotbar(i).Slot = reader.ReadInt32()
           Player(Index).Hotbar(i).SlotType = reader.ReadByte()
        Next

        ReDim Player(Index).Switches(MAX_SWITCHES)
        For i = 0 To MAX_SWITCHES
           Player(Index).Switches(i) = reader.ReadByte()
        Next
        ReDim Player(Index).Variables(MAX_VARIABLES)
        For i = 0 To MAX_VARIABLES
           Player(Index).Variables(i) = reader.ReadInt32()
        Next

        ReDim Player(Index).GatherSkills(ResourceSkills.Count - 1)
        For i = 0 To ResourceSkills.Count - 1
           Player(Index).GatherSkills(i).SkillLevel = reader.ReadInt32()
           Player(Index).GatherSkills(i).SkillCurExp = reader.ReadInt32()
           Player(Index).GatherSkills(i).SkillNextLvlExp = reader.ReadInt32()
            If Player(Index).GatherSkills(i).SkillLevel = 0 Then Player(Index).GatherSkills(i).SkillLevel = 1
            If Player(Index).GatherSkills(i).SkillNextLvlExp = 0 Then Player(Index).GatherSkills(i).SkillNextLvlExp = 100
        Next

        ReDim Player(Index).RecipeLearned(MAX_RECIPE)
        For i = 0 To MAX_RECIPE
           Player(Index).RecipeLearned(i) = reader.ReadByte()
        Next

        'random items
        ReDim Player(Index).RandInv(MAX_INV)
        For i = 0 To MAX_INV
           Player(Index).RandInv(i).Prefix = reader.ReadString()
           Player(Index).RandInv(i).Suffix = reader.ReadString()
           Player(Index).RandInv(i).Rarity = reader.ReadInt32()
           Player(Index).RandInv(i).Damage = reader.ReadInt32()
           Player(Index).RandInv(i).Speed = reader.ReadInt32()

            ReDim Player(Index).RandInv(i).Stat(StatType.Count - 1)
            For X = 0 To StatType.Count - 1
               Player(Index).RandInv(i).Stat(x) = reader.ReadInt32()
            Next
        Next

        ReDim Player(Index).RandEquip(EquipmentType.Count - 1)
        For i = 0 To EquipmentType.Count - 1
           Player(Index).RandEquip(i).Prefix = reader.ReadString()
           Player(Index).RandEquip(i).Suffix = reader.ReadString()
           Player(Index).RandEquip(i).Rarity = reader.ReadInt32()
           Player(Index).RandEquip(i).Damage = reader.ReadInt32()
           Player(Index).RandEquip(i).Speed = reader.ReadInt32()

            ReDim Player(Index).RandEquip(i).Stat(StatType.Count - 1)
            For X = 0 To StatType.Count - 1
               Player(Index).RandEquip(i).Stat(x) = reader.ReadInt32()
            Next
        Next

        'pets
       Player(Index).Pet.Num = reader.ReadInt32()
       Player(Index).Pet.Health = reader.ReadInt32()
       Player(Index).Pet.Mana = reader.ReadInt32()
       Player(Index).Pet.Level = reader.ReadInt32()

        ReDim Player(Index).Pet.Stat(StatType.Count - 1)
        For i = 0 To StatType.Count - 1
           Player(Index).Pet.Stat(i) = reader.ReadByte()
        Next

        ReDim Player(Index).Pet.Skill(4)
        For i = 0 To 4
           Player(Index).Pet.Skill(i) = reader.ReadInt32()
        Next

       Player(Index).Pet.X = reader.ReadInt32()
       Player(Index).Pet.Y = reader.ReadInt32()
       Player(Index).Pet.Dir = reader.ReadInt32()
       Player(Index).Pet.Alive = reader.ReadByte()
       Player(Index).Pet.AttackBehaviour = reader.ReadInt32()
       Player(Index).Pet.AdoptiveStats = reader.ReadByte()
       Player(Index).Pet.Points = reader.ReadInt32()
       Player(Index).Pet.Exp = reader.ReadInt32()

    End Sub

    Sub SaveCharacter(index As Integer)
        Dim filename As String = Paths.Database & "Accounts\" & Player(index).Login.Trim & ".bin"

        Dim writer As New ByteStream(100)

        writer.WriteByte(Player(index).Job)
        writer.WriteByte(Player(index).Dir)

        For i = 0 To EquipmentType.Count - 1
            writer.WriteByte(Player(index).Equipment(i))
        Next

        writer.WriteInt32(Player(index).Exp)

        For i = 0 To MAX_INV
            writer.WriteByte(Player(index).Inv(i).Num)
            writer.WriteInt32(Player(index).Inv(i).Value)
        Next

        writer.WriteByte(Player(index).Level)
        writer.WriteInt32(Player(index).Map)
        writer.WriteString(Player(index).Name)
        writer.WriteByte(Player(index).Pk)
        writer.WriteByte(Player(index).Points)
        writer.WriteByte(Player(index).Sex)

        For i = 0 To MAX_PLAYER_SKILLS
            writer.WriteByte(Player(index).Skill(i))
        Next

        writer.WriteInt32(Player(index).Sprite)

        For i = 0 To StatType.Count - 1
            writer.WriteByte(Player(index).Stat(i))
        Next

        For i = 0 To VitalType.Count - 1
            writer.WriteInt32(Player(index).Vital(i))
        Next

        writer.WriteByte(Player(index).X)
        writer.WriteByte(Player(index).Y)

        For i = 0 To MAX_QUESTS
            writer.WriteInt32(Player(index).PlayerQuest(i).Status)
            writer.WriteInt32(Player(index).PlayerQuest(i).ActualTask)
            writer.WriteInt32(Player(index).PlayerQuest(i).CurrentCount)
        Next

        'Housing
        writer.WriteInt32(Player(index).House.Houseindex)
        writer.WriteInt32(Player(index).House.FurnitureCount)
        For i = 0 To Player(Index).House.FurnitureCount
            writer.WriteInt32(Player(index).House.Furniture(i).ItemNum)
            writer.WriteInt32(Player(index).House.Furniture(i).X)
            writer.WriteInt32(Player(index).House.Furniture(i).Y)
        Next
        writer.WriteInt32(Player(index).InHouse)
        writer.WriteInt32(Player(index).LastMap)
        writer.WriteInt32(Player(index).LastX)
        writer.WriteInt32(Player(index).LastY)

        For i = 0 To MAX_HOTBAR
            writer.WriteInt32(Player(index).Hotbar(i).Slot)
            writer.WriteByte(Player(index).Hotbar(i).SlotType)
        Next

        For i = 0 To MAX_SWITCHES
            writer.WriteByte(Player(index).Switches(i))
        Next

        For i = 0 To MAX_VARIABLES
            writer.WriteInt32(Player(index).Variables(i))
        Next

        For i = 0 To ResourceSkills.Count - 1
            writer.WriteInt32(Player(index).GatherSkills(i).SkillLevel)
            writer.WriteInt32(Player(index).GatherSkills(i).SkillCurExp)
            writer.WriteInt32(Player(index).GatherSkills(i).SkillNextLvlExp)
        Next

        For i = 0 To MAX_RECIPE
            writer.WriteByte(Player(index).RecipeLearned(i))
        Next

        'random items
        For i = 0 To MAX_INV
            writer.WriteString(Player(index).RandInv(i).Prefix)
            writer.WriteString(Player(index).RandInv(i).Suffix)
            writer.WriteInt32(Player(index).RandInv(i).Rarity)
            writer.WriteInt32(Player(index).RandInv(i).Damage)
            writer.WriteInt32(Player(index).RandInv(i).Speed)
            For X = 0 To StatType.Count - 1
                writer.WriteInt32(Player(index).RandInv(i).Stat(x))
            Next
        Next

        For i = 0 To EquipmentType.Count - 1
            writer.WriteString(Player(index).RandEquip(i).Prefix)
            writer.WriteString(Player(index).RandEquip(i).Suffix)
            writer.WriteInt32(Player(index).RandEquip(i).Rarity)
            writer.WriteInt32(Player(index).RandEquip(i).Damage)
            writer.WriteInt32(Player(index).RandEquip(i).Speed)
            For X = 0 To StatType.Count - 1
                writer.WriteInt32(Player(index).RandEquip(i).Stat(x))
            Next
        Next

        'pets
        writer.WriteInt32(Player(index).Pet.Num)
        writer.WriteInt32(Player(index).Pet.Health)
        writer.WriteInt32(Player(index).Pet.Mana)
        writer.WriteInt32(Player(index).Pet.Level)

        For i = 0 To StatType.Count - 1
            writer.WriteByte(Player(index).Pet.Stat(i))
        Next

        For i = 0 To 4
            writer.WriteInt32(Player(index).Pet.Skill(i))
        Next

        writer.WriteInt32(Player(index).Pet.X)
        writer.WriteInt32(Player(index).Pet.Y)
        writer.WriteInt32(Player(index).Pet.Dir)
        writer.WriteByte(Player(index).Pet.Alive)
        writer.WriteInt32(Player(index).Pet.AttackBehaviour)
        writer.WriteByte(Player(index).Pet.AdoptiveStats)
        writer.WriteInt32(Player(index).Pet.Points)
        writer.WriteInt32(Player(index).Pet.Exp)

        ByteFile.Save(filename, writer)
    End Sub

    Function CharExist(index As Integer, CharNum As Integer) As Boolean
        Return Player(Index).Name.Trim.Length > 0
    End Function

    Sub AddChar(index As Integer, CharNum As Integer, Name As String, Sex As Byte, ClassNum As Byte, Sprite As Integer)
        Dim n As Integer, i As Integer

        If Len(Trim$(Player(index).Name)) = 0 Then
           Player(Index).Name = Name
           Player(Index).Sex = Sex
           Player(Index).Job = ClassNum

            If Player(Index).Sex = SexType.Male Then
               Player(Index).Sprite = Job(ClassNum).MaleSprite(Sprite)
            Else
               Player(Index).Sprite = Job(ClassNum).FemaleSprite(Sprite)
            End If

           Player(Index).Level = 1

            For n = 0 To StatType.Count - 1
               Player(Index).Stat(n) = Job(ClassNum).Stat(n)
            Next n

           Player(Index).Dir = DirectionType.Down
           Player(Index).Map = Job(ClassNum).StartMap
           Player(Index).X = Job(ClassNum).StartX
           Player(Index).Y = Job(ClassNum).StartY
           Player(Index).Dir = DirectionType.Down
           Player(Index).Vital(VitalType.HP) = GetPlayerMaxVital(index, VitalType.HP)
           Player(Index).Vital(VitalType.MP) = GetPlayerMaxVital(index, VitalType.MP)
           Player(Index).Vital(VitalType.SP) = GetPlayerMaxVital(index, VitalType.SP)

            ' set starter equipment
            For n = 0 To 5
                If Job(ClassNum).StartItem(n) > 0 Then
                   Player(Index).Inv(n).Num = Job(ClassNum).StartItem(n)
                   Player(Index).Inv(n).Value = Job(ClassNum).StartValue(n)

                    If Item(Job(ClassNum).StartItem(n)).Randomize Then
                        Player(index).RandInv(n).Prefix = ""
                        Player(index).RandInv(n).Suffix = ""
                        Player(index).RandInv(n).Rarity = RarityType.RARITY_COMMON
                        Player(index).RandInv(n).Damage = Item(Job(ClassNum).StartItem(n)).Data2
                        Player(index).RandInv(n).Speed = Item(Job(ClassNum).StartItem(n)).Speed
                        For i = 0 To StatType.Count - 1
                            Player(index).RandInv(n).Stat(i) = Item(Job(ClassNum).StartItem(n)).Add_Stat(i)
                        Next
                    End If
                End If
            Next

            'set skills
            ReDim Player(Index).GatherSkills(ResourceSkills.Count - 1)
            For i = 0 To ResourceSkills.Count - 1
               Player(Index).GatherSkills(i).SkillLevel = 1
               Player(Index).GatherSkills(i).SkillCurExp = 0
               Player(Index).GatherSkills(i).SkillNextLvlExp = 100
            Next

            ' Append name to file
            AddTextToFile(Name, "Accounts\charlist.txt")

            SavePlayer(index)
            Exit Sub
        End If

    End Sub

    Function FindChar(Name As String) As Boolean
        FindChar = False
        Dim characters() As String
        Dim fullpath As String
        Dim Contents As String

        fullpath = Paths.Accounts & "charlist.txt"

        Contents = GetFileContents(fullpath)
        characters = Split(Contents, vbNewLine)

        For i = 0 To UBound(characters)
            If Trim$(LCase(characters(i)) = Trim$(LCase(Name))) Then
                FindChar = True
            End If
        Next

        Return FindChar
    End Function

#End Region

#Region "Logs"

    Friend Function GetFileContents(fullPath As String) As String
        Dim strContents = ""
        Dim objReader As StreamReader
        If Not File.Exists(fullPath) Then File.Create(fullPath).Dispose()
        Try
            objReader = New StreamReader(fullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
        Catch
        End Try
        Return strContents
    End Function

    Friend Function Addlog(strData As String, FN As String) As Boolean
        Dim fullpath As String
        Dim contents As String
        Dim bAns = False
        Dim objReader As StreamWriter
        fullpath = Paths.Logs & FN
        contents = GetFileContents(fullpath)
        contents = contents & vbNewLine & strData
        Try
            objReader = New StreamWriter(fullpath)
            objReader.Write(contents)
            objReader.Close()
            bAns = True
        Catch
        End Try
        Return bAns
    End Function

    Friend Function AddTextToFile(strData As String, fn As String) As Boolean
        Dim fullpath As String
        Dim contents As String
        Dim bAns = False
        Dim objReader As StreamWriter
        fullpath = Paths.Database & fn
        contents = GetFileContents(fullpath)
        contents = contents & vbNewLine & strData
        Try
            objReader = New StreamWriter(fullpath)
            objReader.Write(contents)
            objReader.Close()
            bAns = True
        Catch
        End Try
        Return bAns
    End Function

#End Region

#Region "Banning"

    Sub ServerBanIndex(BanPlayerindex As Integer)
        Dim filename As String
        Dim IP As String
        Dim F As Integer
        Dim i As Integer
        filename = Paths.Database & "banlist.txt"

        ' Make sure the file exists
        If Not File.Exists("data\banlist.txt") Then
            F = FreeFile()
            'COME HERE!!!
        End If

        ' Cut off last portion of ip
        IP = Socket.ClientIp(BanPlayerindex)

        For i = Len(IP) To 1 Step -1

            If Mid$(IP, i, 1) = "." Then
                Exit For
            End If

        Next

        IP = Mid$(IP, 1, i)
        AddTextToFile(IP, "banlist.txt")
        GlobalMsg(GetPlayerName(BanPlayerindex) & " has been banned from " & Settings.GameName & " by " & "the Server" & "!")
        Addlog("The Server" & " has banned " & GetPlayerName(BanPlayerindex) & ".", ADMIN_LOG)
        AlertMsg(BanPlayerindex, "You have been banned by " & "The Server" & "!")
    End Sub

    Function IsBanned(IP As String) As Boolean
        Dim filename As String, line As String

        filename = Paths.Database & "banlist.txt"

        ' Check if file exists
        If Not File.Exists("data\banlist.txt") Then
            Return False
        End If

        Dim sr As StreamReader = New StreamReader(filename)

        Do While sr.Peek() >= 0
            'Console.WriteLine(sr.ReadLine())
            ' Is banned?
            line = sr.ReadLine()
            If Trim$(LCase$(line)) = Trim$(LCase$(Mid$(IP, 1, Len(line)))) Then
                IsBanned = True
            End If
        Loop
        sr.Close()

    End Function

    Sub BanIndex(BanPlayerindex As Integer, BannedByindex As Integer)
        Dim filename As String = Paths.Database & "banlist.txt"
        Dim IP As String, i As Integer

        ' Make sure the file exists
        If Not File.Exists(filename) Then File.Create(filename).Dispose()

        ' Cut off last portion of ip
        IP = Socket.ClientIp(BanPlayerindex)

        For i = Len(IP) To 1 Step -1

            If Mid$(IP, i, 1) = "." Then
                Exit For
            End If

        Next

        IP = Mid$(IP, 1, i)
        AddTextToFile(IP, "banlist.txt")
        GlobalMsg(GetPlayerName(BanPlayerindex) & " has been banned from " & Settings.GameName & " by " & GetPlayerName(BannedByindex) & "!")
        Addlog(GetPlayerName(BannedByindex) & " has banned " & GetPlayerName(BanPlayerindex) & ".", ADMIN_LOG)
        AlertMsg(BanPlayerindex, "You have been banned by " & GetPlayerName(BannedByindex) & "!")
    End Sub

#End Region

#Region "Data Functions"
    Function JobData() As Byte()
        Dim i As Integer, n As Integer, q As Integer
        Dim buffer As New ByteStream(4)

        For i = 0 To MAX_JOBS
            buffer.WriteString((GetJobName(i).Trim))
            buffer.WriteString((Job(i).Desc.Trim))

            buffer.WriteInt32(GetJobMaxVital(i, VitalType.HP))
            buffer.WriteInt32(GetJobMaxVital(i, VitalType.MP))
            buffer.WriteInt32(GetJobMaxVital(i, VitalType.SP))

            ' set sprite array size
            n = UBound(Job(i).MaleSprite)

            ' send array size
            buffer.WriteInt32(n)

            ' loop around sending each sprite
            For q = 0 To n
                buffer.WriteInt32(Job(i).MaleSprite(q))
            Next

            ' set sprite array size
            n = UBound(Job(i).FemaleSprite)

            ' send array size
            buffer.WriteInt32(n)

            ' loop around sending each sprite
            For q = 0 To n
                buffer.WriteInt32(Job(i).FemaleSprite(q))
            Next

            buffer.WriteInt32(Job(i).Stat(StatType.Strength))
            buffer.WriteInt32(Job(i).Stat(StatType.Endurance))
            buffer.WriteInt32(Job(i).Stat(StatType.Vitality))
            buffer.WriteInt32(Job(i).Stat(StatType.Intelligence))
            buffer.WriteInt32(Job(i).Stat(StatType.Luck))
            buffer.WriteInt32(Job(i).Stat(StatType.Spirit))

            For q = 0 To 5
                buffer.WriteInt32(Job(i).StartItem(q))
                buffer.WriteInt32(Job(i).StartValue(q))
            Next

            buffer.WriteInt32(Job(i).StartMap)
            buffer.WriteInt32(Job(i).StartX)
            buffer.WriteInt32(Job(i).StartY)

            buffer.WriteInt32(Job(i).BaseExp)
        Next

        Return buffer.ToArray()
    End Function

    Function NpcsData() As Byte()
        Dim buffer As New ByteStream(4)

        For i = 0 To MAX_NPCS
            If Not Len(Trim$(Npc(i).Name)) > 0 Then Continue For
            buffer.WriteBlock(NpcData(i))
        Next
        Return buffer.ToArray
    End Function

    Function NpcData(NpcNum As Integer) As Byte()
        Dim buffer As New ByteStream(4)

        buffer.WriteInt32(NpcNum)
        buffer.WriteInt32(Npc(NpcNum).Animation)
        buffer.WriteString((Npc(NpcNum).AttackSay))
        buffer.WriteInt32(Npc(NpcNum).Behaviour)
        For i = 0 To MAX_DROP_ITEMS
            buffer.WriteInt32(Npc(NpcNum).DropChance(i))
            buffer.WriteInt32(Npc(NpcNum).DropItem(i))
            buffer.WriteInt32(Npc(NpcNum).DropItemValue(i))
        Next
        buffer.WriteInt32(Npc(NpcNum).Exp)
        buffer.WriteInt32(Npc(NpcNum).Faction)
        buffer.WriteInt32(Npc(NpcNum).Hp)
        buffer.WriteString((Npc(NpcNum).Name))
        buffer.WriteInt32(Npc(NpcNum).Range)
        buffer.WriteInt32(Npc(NpcNum).SpawnTime)
        buffer.WriteInt32(Npc(NpcNum).SpawnSecs)
        buffer.WriteInt32(Npc(NpcNum).Sprite)
        For i = 0 To StatType.Count - 1
            buffer.WriteInt32(Npc(NpcNum).Stat(i))
        Next
        buffer.WriteInt32(Npc(NpcNum).QuestNum)
        For i = 0 To MAX_NPC_SKILLS
            buffer.WriteInt32(Npc(NpcNum).Skill(i))
        Next
        buffer.WriteInt32(Npc(NpcNum).Level)
        buffer.WriteInt32(Npc(NpcNum).Damage)
        Return buffer.ToArray
    End Function

    Function ShopsData() As Byte()
        Dim buffer As New ByteStream(4)
        For i = 0 To MAX_SHOPS
            If Not Len(Trim$(Shop(i).Name)) > 0 Then Continue For
            buffer.WriteBlock(ShopData(i))
        Next
        Return buffer.ToArray
    End Function

    Function ShopData(shopNum As Integer) As Byte()
        Dim buffer As New ByteStream(4)

        buffer.WriteInt32(shopNum)
        buffer.WriteInt32(Shop(shopNum).BuyRate)
        buffer.WriteString((Shop(shopNum).Name))
        buffer.WriteInt32(Shop(shopNum).Face)
        For i = 0 To MAX_TRADES
            buffer.WriteInt32(Shop(shopNum).TradeItem(i).CostItem)
            buffer.WriteInt32(Shop(shopNum).TradeItem(i).CostValue)
            buffer.WriteInt32(Shop(shopNum).TradeItem(i).Item)
            buffer.WriteInt32(Shop(shopNum).TradeItem(i).ItemValue)
        Next
        Return buffer.ToArray
    End Function

    Function SkillsData() As Byte()
        Dim buffer As New ByteStream(4)

        For i = 0 To MAX_SKILLS
            If Not Len(Trim$(Skill(i).Name)) > 0 Then Continue For
            buffer.WriteBlock(SkillData(i))
        Next
        Return buffer.ToArray
    End Function

    Function SkillData(skillnum As Integer) As Byte()
        Dim buffer As New ByteStream(4)

        buffer.WriteInt32(skillnum)
        buffer.WriteInt32(Skill(skillnum).AccessReq)
        buffer.WriteInt32(Skill(skillnum).AoE)
        buffer.WriteInt32(Skill(skillnum).CastAnim)
        buffer.WriteInt32(Skill(skillnum).CastTime)
        buffer.WriteInt32(Skill(skillnum).CdTime)
        buffer.WriteInt32(Skill(skillnum).ClassReq)
        buffer.WriteInt32(Skill(skillnum).Dir)
        buffer.WriteInt32(Skill(skillnum).Duration)
        buffer.WriteInt32(Skill(skillnum).Icon)
        buffer.WriteInt32(Skill(skillnum).Interval)
        buffer.WriteInt32(Skill(skillnum).IsAoE)
        buffer.WriteInt32(Skill(skillnum).LevelReq)
        buffer.WriteInt32(Skill(skillnum).Map)
        buffer.WriteInt32(Skill(skillnum).MpCost)
        buffer.WriteString((Skill(skillnum).Name))
        buffer.WriteInt32(Skill(skillnum).Range)
        buffer.WriteInt32(Skill(skillnum).SkillAnim)
        buffer.WriteInt32(Skill(skillnum).StunDuration)
        buffer.WriteInt32(Skill(skillnum).Type)
        buffer.WriteInt32(Skill(skillnum).Vital)
        buffer.WriteInt32(Skill(skillnum).X)
        buffer.WriteInt32(Skill(skillnum).Y)
        buffer.WriteInt32(Skill(skillnum).IsProjectile)
        buffer.WriteInt32(Skill(skillnum).Projectile)
        buffer.WriteInt32(Skill(skillnum).KnockBack)
        buffer.WriteInt32(Skill(skillnum).KnockBackTiles)
        Return buffer.ToArray
    End Function

#End Region

End Module