﻿Imports Mirage.Basic.Engine

Module S_Instances
    'Consts
    Friend Const INSTANCED_MAP_MASK As Integer = 16777216 '1 << 24
    Friend Const MAP_NUMBER_MASK As Integer = INSTANCED_MAP_MASK - 1
    Friend Const INSTANCED_MAP_SUFFIX As String = " (Instanced)"

    Friend Sub ClearInstancedMaps()
        Dim i As Integer

        For i = 0 To MAX_INSTANCED_MAPS
            CacheResources(i + MAX_MAPS)
            InstancedMaps(i).OriginalMap = 0
        Next
    End Sub

    Friend Function FindFreeInstanceMapSlot() As Integer
        Dim i As Integer

        For i = 0 To MAX_INSTANCED_MAPS
            If InstancedMaps(i).OriginalMap = 0 Then
                FindFreeInstanceMapSlot = i
                Exit Function
            End If
        Next

        FindFreeInstanceMapSlot = -1
    End Function

    Friend Function CreateInstance(mapNum As Integer) As Integer
        Dim i As Integer, slot As Integer

        If mapNum < 0 OrElse mapNum > MAX_MAPS Then
            CreateInstance = -1
            Exit Function
        End If

        slot = FindFreeInstanceMapSlot()

        If slot = -1 Then
            CreateInstance = -1
            Exit Function
        End If

        InstancedMaps(slot).OriginalMap = mapNum

        'Copy Map Data
        Map(slot + MAX_MAPS) = Map(mapNum)

        'Copy Map Item Data

        For i = 1 To MAX_MAP_ITEMS
            MapItem(slot + MAX_MAPS, i) = MapItem(mapNum, i)
        Next

        'Copy Map NPCs
        MapNpc(slot + MAX_MAPS) = MapNpc(mapNum)

        'Re-Cache Resource
        CacheResources(slot + MAX_MAPS)

        If Not (Map(slot + MAX_MAPS).Name = vbNullString) Then Map(slot + MAX_MAPS).Name = Map(slot + MAX_MAPS).Name & INSTANCED_MAP_SUFFIX
        CreateInstance = slot
        Exit Function
    End Function

    Friend Sub DestroyInstancedMap(Slot As Integer)
        Dim x As Integer

        ClearMap(Slot + MAX_MAPS)

        For x = 0 To MAX_MAP_NPCS
            ClearMapNpc(x, Slot + MAX_MAPS)
        Next

        For x = 1 To MAX_MAP_ITEMS
            ClearMapItem(x, Slot + MAX_MAPS)
        Next
        InstancedMaps(Slot).OriginalMap = 0
    End Sub

    Friend Function IsInstancedMap(mapNum As Integer) As Boolean
        IsInstancedMap = mapNum > MAX_MAPS AndAlso mapNum <= MAX_CACHED_MAPS
    End Function

    Friend Function GetInstanceBaseMap(mapNum As Integer) As Integer
        GetInstanceBaseMap = InstancedMaps(mapNum - MAX_MAPS).OriginalMap
    End Function

End Module