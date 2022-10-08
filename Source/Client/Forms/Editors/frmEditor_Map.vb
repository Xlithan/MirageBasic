﻿Imports System.IO
Imports Mirage.Sharp.Asfw
Imports SFML.Graphics
Imports SFML.Window
Imports Mirage.Basic.Engine
Imports SFML.System
Imports Mirage.Basic.Engine.Enumerations

Public Class frmEditor_Map
#Region "Frm"
    Private Sub FrmEditor_Map_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        cmbTileSets.SelectedIndex = 0
        pnlAttributes.BringToFront()
        pnlAttributes.Visible = False
        pnlAttributes.Left = 4
        pnlAttributes.Top = 28
        optBlocked.Checked = True
        tabpages.SelectedIndex = 0

        DirArrowX(DirectionType.Up) = 12
        DirArrowY(DirectionType.Up) = 0
        DirArrowX(DirectionType.Down) = 12
        DirArrowY(DirectionType.Down) = 23
        DirArrowX(DirectionType.Left) = 0
        DirArrowY(DirectionType.Left) = 12
        DirArrowX(DirectionType.Right) = 23
        DirArrowY(DirectionType.Right) = 12

        scrlFog.Maximum = NumFogs

        TilesetWindow = New RenderWindow(picBackSelect.Handle)

        TopMost = True
    End Sub

#End Region

#Region "Toolbar"

    Private Sub TsbSave_Click(sender As Object, e As EventArgs) Handles tsbSave.Click
        Dim X As Integer, x2 As Integer
        Dim Y As Integer, y2 As Integer
        Dim tempArr(,) As TileStruct

        If Not IsNumeric(txtMaxX.Text) Then txtMaxX.Text = Map.MaxX
        If Val(txtMaxX.Text) < ScreenMapx Then txtMaxX.Text = ScreenMapx
        If Val(txtMaxX.Text) > Byte.MaxValue Then txtMaxX.Text = Byte.MaxValue
        If Not IsNumeric(txtMaxY.Text) Then txtMaxY.Text = Map.MaxY
        If Val(txtMaxY.Text) < ScreenMapy Then txtMaxY.Text = ScreenMapy
        If Val(txtMaxY.Text) > Byte.MaxValue Then txtMaxY.Text = Byte.MaxValue

        With Map
            .Name = Trim$(txtName.Text)
            If lstMusic.SelectedIndex >= 0 Then
                .Music = lstMusic.Items(lstMusic.SelectedIndex).ToString
            Else
                .Music = ""
            End If
            .Up = Val(txtUp.Text)
            .Down = Val(txtDown.Text)
            .Left = Val(txtLeft.Text)
            .Right = Val(txtRight.Text)
            .Moral = cmbMoral.SelectedIndex
            .BootMap = Val(txtBootMap.Text)
            .BootX = Val(txtBootX.Text)
            .BootY = Val(txtBootY.Text)

            ' set the data before changing it
            tempArr = Map.Tile.Clone

            x2 = Map.MaxX
            y2 = Map.MaxY

            ' change the data
            .MaxX = Val(txtMaxX.Text)
            .MaxY = Val(txtMaxY.Text)

            ReDim Map.Tile(.MaxX, .MaxY)
            ReDim Autotile(.MaxX, .MaxY)

            For i = 0 To MaxTileHistory
                ReDim TileHistory(i).Tile(.MaxX, .MaxY)
            Next

            If x2 > .MaxX Then x2 = .MaxX
            If y2 > .MaxY Then y2 = .MaxY

            For X = 0 To .MaxX
                For Y = 0 To .MaxY
                    ReDim .Tile(X, Y).Layer(LayerType.Count - 1)
                    ReDim Autotile(X, Y).Layer(LayerType.Count - 1)

                    For i = 0 To MaxTileHistory
                        ReDim TileHistory(i).Tile(X,y).Layer(LayerType.Count - 1)
                    Next

                    If X <= x2 Then
                        If Y <= y2 Then
                            .Tile(X, Y) = tempArr(X, Y)
                        End If
                    End If
                Next
            Next
        End With

        MapEditorSend()      
        GettingMap = True
        Dispose()
    End Sub

    Private Sub TsbFill_Click(sender As Object, e As EventArgs) Handles tsbFill.Click
        MapEditorFillLayer(cmbAutoTile.SelectedIndex)
    End Sub

    Private Sub TsbClear_Click(sender As Object, e As EventArgs) Handles  tsbClear.Click
        MapEditorClearLayer()
    End Sub

    Private Sub TsbEyeDropper_Click(sender As Object, e As EventArgs) Handles tsbEyeDropper.Click
        EyeDropper = Not EyeDropper  
    End Sub

    Private Sub TsbDiscard_Click(sender As Object, e As EventArgs) Handles tsbDiscard.Click
        MapEditorCancel()
        Dispose()
    End Sub

    Private Sub TsbMapGrid_Click(sender As Object, e As EventArgs) Handles tsbMapGrid.Click
        MapGrid = Not MapGrid
    End Sub

#End Region

#Region "Tiles"
    Private Sub PicBackSelect_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picBackSelect.MouseDown
        MapEditorChooseTile(e.Button, e.X, e.Y)
    End Sub

    Private Sub PicBackSelect_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles picBackSelect.MouseMove
        MapEditorDrag(e.Button, e.X, e.Y)
    End Sub

    Private Sub CmbTileSets_Click(sender As Object, e As EventArgs) Handles cmbTileSets.Click
        If cmbTileSets.SelectedIndex > NumTileSets Then
            cmbTileSets.SelectedIndex = 0
        End If

        Map.Tileset = cmbTileSets.SelectedIndex

        EditorTileSelStart = New Point(0, 0)
        EditorTileSelEnd = New Point(1, 1)
    End Sub

    Private Sub CmbAutoTile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAutoTile.SelectedIndexChanged
        If cmbAutoTile.SelectedIndex = 0 Then
            EditorTileWidth = 1
            EditorTileHeight = 1
        End If
    End Sub

#End Region

#Region "Attributes"

    Private Sub ScrlMapWarpMap_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles scrlMapWarpMap.ValueChanged
        lblMapWarpMap.Text = "Map: " & scrlMapWarpMap.Value
    End Sub

    Private Sub ScrlMapWarpX_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles scrlMapWarpX.ValueChanged
        lblMapWarpX.Text = "X: " & scrlMapWarpX.Value
    End Sub

    Private Sub ScrlMapWarpY_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles scrlMapWarpY.ValueChanged
        lblMapWarpY.Text = "Y: " & scrlMapWarpY.Value
    End Sub

    Private Sub BtnMapWarp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMapWarp.Click
        EditorWarpMap = scrlMapWarpMap.Value

        EditorWarpX = scrlMapWarpX.Value
        EditorWarpY = scrlMapWarpY.Value
        pnlAttributes.Visible = False
        fraMapWarp.Visible = False
    End Sub

    Private Sub OptWarp_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optWarp.CheckedChanged
        If optWarp.Checked = False Then Exit Sub

        ClearAttributeDialogue()
        pnlAttributes.Visible = True
        fraMapWarp.Visible = True

        scrlMapWarpMap.Maximum = MAX_MAPS
        scrlMapWarpMap.Value = 1
        scrlMapWarpX.Maximum = Byte.MaxValue
        scrlMapWarpY.Maximum = Byte.MaxValue
        scrlMapWarpX.Value = 0
        scrlMapWarpY.Value = 0
    End Sub

    Private Sub ScrlMapItem_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles scrlMapItem.ValueChanged
        If Item(scrlMapItem.Value).Type = ItemType.Currency OrElse Item(scrlMapItem.Value).Stackable = 1 Then
            scrlMapItemValue.Enabled = True
        Else
            scrlMapItemValue.Value = 1
            scrlMapItemValue.Enabled = False
        End If

        DrawMapItem()
        lblMapItem.Text = "Item: " & scrlMapItem.Value & ". " & Trim$(Item(scrlMapItem.Value).Name) & " x" & scrlMapItemValue.Value
    End Sub

    Private Sub ScrlMapItemValue_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles scrlMapItemValue.ValueChanged
        lblMapItem.Text = Trim$(Item(scrlMapItem.Value).Name) & " x" & scrlMapItemValue.Value
    End Sub

    Private Sub BtnMapItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMapItem.Click
        ItemEditorNum = scrlMapItem.Value
        ItemEditorValue = scrlMapItemValue.Value
        pnlAttributes.Visible = False
        fraMapItem.Visible = False
    End Sub

    Private Sub OptItem_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optItem.CheckedChanged
        If optItem.Checked = False Then Exit Sub

        ClearAttributeDialogue()
        pnlAttributes.Visible = True
        fraMapItem.Visible = True

        scrlMapItem.Maximum = MAX_ITEMS
        scrlMapItem.Value = 1
        lblMapItem.Text = Trim$(Item(scrlMapItem.Value).Name) & " x" & scrlMapItemValue.Value
        DrawMapItem()
    End Sub

    Private Sub BtnResourceOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResourceOk.Click
        ResourceEditorNum = scrlResource.Value
        pnlAttributes.Visible = False
        fraResource.Visible = False
    End Sub

    Private Sub ScrlResource_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles scrlResource.ValueChanged
        lblResource.Text = "Resource: " & Resource(scrlResource.Value).Name
    End Sub

    Private Sub OptResource_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optResource.CheckedChanged
        If optResource.Checked = False Then Exit Sub

        ClearAttributeDialogue()
        pnlAttributes.Visible = True
        fraResource.Visible = True
    End Sub

    Private Sub BtnNpcSpawn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNpcSpawn.Click
        SpawnNpcNum = lstNpc.SelectedIndex
        SpawnNpcDir = scrlNpcDir.Value
        pnlAttributes.Visible = False
        fraNpcSpawn.Visible = False
    End Sub

    Private Sub OptNPCSpawn_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optNPCSpawn.CheckedChanged
        Dim n As Integer
        If optNPCSpawn.Checked = False Then Exit Sub

        lstNpc.Items.Clear()

        For n = 0 To MAX_MAP_NPCS
            If Map.Npc(n) > 0 Then
                lstNpc.Items.Add(n & ": " & Npc(Map.Npc(n)).Name)
            Else
                lstNpc.Items.Add(n & ": No Npc")
            End If
        Next n

        scrlNpcDir.Value = 0
        lstNpc.SelectedIndex = 0

        ClearAttributeDialogue()
        pnlAttributes.Visible = True
        fraNpcSpawn.Visible = True
    End Sub

    Private Sub BtnShop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShop.Click
        EditorShop = cmbShop.SelectedIndex
        pnlAttributes.Visible = False
        fraShop.Visible = False
    End Sub

    Private Sub OptShop_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optShop.CheckedChanged
        If optShop.Checked = False Then Exit Sub

        ClearAttributeDialogue()
        pnlAttributes.Visible = True
        fraShop.Visible = True
    End Sub

    Private Sub BtnHeal_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHeal.Click
        MapEditorHealType = cmbHeal.SelectedIndex
        MapEditorHealAmount = scrlHeal.Value
        pnlAttributes.Visible = False
        fraHeal.Visible = False
    End Sub

    Private Sub ScrlHeal_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles scrlHeal.ValueChanged
        lblHeal.Text = "Amount: " & scrlHeal.Value
    End Sub

    Private Sub OptHeal_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optHeal.CheckedChanged
        If optHeal.Checked = False Then Exit Sub

        ClearAttributeDialogue()
        pnlAttributes.Visible = True
        fraHeal.Visible = True
    End Sub

    Private Sub ScrlTrap_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles scrlTrap.ValueChanged
        lblTrap.Text = "Amount: " & scrlTrap.Value
    End Sub

    Private Sub BtnTrap_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTrap.Click
        MapEditorHealAmount = scrlTrap.Value
        pnlAttributes.Visible = False
        fraTrap.Visible = False
    End Sub

    Private Sub OptTrap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optTrap.CheckedChanged
        If optTrap.Checked = False Then Exit Sub

        ClearAttributeDialogue()
        pnlAttributes.Visible = True
        fraTrap.Visible = True
    End Sub

    Private Sub BtnClearAttribute_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClearAttribute.Click
        MapEditorClearAttribs()
    End Sub

    Private Sub ScrlNpcDir_Scroll(sender As Object, e As EventArgs) Handles scrlNpcDir.ValueChanged
        Select Case scrlNpcDir.Value
            Case 0
                lblNpcDir.Text = "Direction: Up"
            Case 1
                lblNpcDir.Text = "Direction: Down"
            Case 2
                lblNpcDir.Text = "Direction: Left"
            Case 3
                lblNpcDir.Text = "Direction: Right"
        End Select
    End Sub

    Private Sub OptBlocked_CheckedChanged(sender As Object, e As EventArgs) Handles optBlocked.CheckedChanged
        If optBlocked.Checked Then pnlAttributes.Visible = False
    End Sub

    Private Sub ChkInstance_CheckedChanged(sender As Object, e As EventArgs) Handles chkInstance.CheckedChanged
        If chkInstance.Checked = True Then
            Map.Instanced = 1
        Else
            Map.Instanced = 0
        End If
    End Sub

#End Region

#Region "Npc's"

    Private Sub CmbNpcList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNpcList.SelectedIndexChanged
        If lstMapNpc.SelectedIndex > -1 Then
            lstMapNpc.Items.Item(lstMapNpc.SelectedIndex) = cmbNpcList.SelectedIndex & ": " & Npc(cmbNpcList.SelectedIndex).Name
            Map.Npc(lstMapNpc.SelectedIndex) = cmbNpcList.SelectedIndex
        End If
    End Sub

#End Region

#Region "Settings"

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If PreviewPlayer Is Nothing Then
            If lstMusic.SelectedIndex > 0 Then
                StopMusic()
                PlayPreview(lstMusic.Items(lstMusic.SelectedIndex).ToString)
            End If
        Else
            StopPreview()
            PlayMusic(Map.Music)
        End If
    End Sub

#End Region

#Region "Events"

    Private Sub BtnCopyEvent_Click(sender As Object, e As EventArgs) Handles btnCopyEvent.Click
        If EventCopy = False Then
            EventCopy = True
            lblCopyMode.Text = "CopyMode On"
            EventPaste = False
            lblPasteMode.Text = "PasteMode Off"
        Else
            EventCopy = False
            lblCopyMode.Text = "CopyMode Off"
        End If
    End Sub

    Private Sub BtnPasteEvent_Click(sender As Object, e As EventArgs) Handles btnPasteEvent.Click
        If EventPaste = False Then
            EventPaste = True
            lblPasteMode.Text = "PasteMode On"
            EventCopy = False
            lblCopyMode.Text = "CopyMode Off"
        Else
            EventPaste = False
            lblPasteMode.Text = "PasteMode Off"
        End If
    End Sub

#End Region

#Region "Map Effects"

    Private Sub CmbWeather_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWeather.SelectedIndexChanged
        Map.WeatherType = cmbWeather.SelectedIndex
    End Sub

    Private Sub ScrlFog_Scroll(sender As Object, e As EventArgs) Handles scrlFog.ValueChanged
        Map.Fogindex = scrlFog.Value
        lblFogIndex.Text = "Fog: " & scrlFog.Value
    End Sub

    Private Sub ScrlIntensity_Scroll(sender As Object, e As EventArgs) Handles scrlIntensity.ValueChanged
        Map.WeatherIntensity = scrlIntensity.Value
        lblIntensity.Text = "Intensity: " & scrlIntensity.Value
    End Sub

    Private Sub ScrlFogSpeed_Scroll(sender As Object, e As EventArgs) Handles scrlFogSpeed.ValueChanged
        Map.FogSpeed = scrlFogSpeed.Value
        lblFogSpeed.Text = "FogSpeed: " & scrlFogSpeed.Value
    End Sub

    Private Sub ScrlFogAlpha_Scroll(sender As Object, e As EventArgs) Handles scrlFogAlpha.ValueChanged
        Map.FogAlpha = scrlFogAlpha.Value
        lblFogAlpha.Text = "Fog Alpha: " & scrlFogAlpha.Value
    End Sub

    Private Sub ChkUseTint_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseTint.CheckedChanged
        If chkUseTint.Checked = True Then
            Map.HasMapTint = 1
        Else
            Map.HasMapTint = 0
        End If
    End Sub

    Private Sub ScrlMapRed_Scroll(sender As Object, e As EventArgs) Handles scrlMapRed.ValueChanged
        Map.MapTintR = scrlMapRed.Value
        lblMapRed.Text = "Red: " & scrlMapRed.Value
    End Sub

    Private Sub ScrlMapGreen_Scroll(sender As Object, e As EventArgs) Handles scrlMapGreen.ValueChanged
        Map.MapTintG = scrlMapGreen.Value
        lblMapGreen.Text = "Green: " & scrlMapGreen.Value
    End Sub

    Private Sub ScrlMapBlue_Scroll(sender As Object, e As EventArgs) Handles scrlMapBlue.ValueChanged
        Map.MapTintB = scrlMapBlue.Value
        lblMapBlue.Text = "Blue: " & scrlMapBlue.Value
    End Sub

    Private Sub ScrlMapAlpha_Scroll(sender As Object, e As EventArgs) Handles scrlMapAlpha.ValueChanged
        Map.MapTintA = scrlMapAlpha.Value
        lblMapAlpha.Text = "Alpha: " & scrlMapAlpha.Value
    End Sub

    Private Sub CmbPanorama_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPanorama.SelectedIndexChanged
        Map.Panorama = cmbPanorama.SelectedIndex
    End Sub

    Private Sub CmbParallax_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbParallax.SelectedIndexChanged
        Map.Parallax = cmbParallax.SelectedIndex
    End Sub

#End Region

#Region "Map Editor"

    Public Sub MapPropertiesInit()
        Dim X As Integer, Y As Integer, i As Integer

        txtName.Text = Trim$(Map.Name)

        ' find the music we have set
        lstMusic.Items.Clear()
        lstMusic.Items.Add("None")

        CacheMusic
        For i = 0 To UBound(MusicCache)
            lstMusic.Items.Add(MusicCache(i))
        Next

        For i = 0 To lstMusic.Items.Count - 1
            If lstMusic.Items(i).ToString = Trim$(Map.Music) Then
                lstMusic.SelectedIndex = i
                Exit For
            End If
        Next

        ' rest of it
        txtUp.Text = Map.Up
        txtDown.Text = Map.Down
        txtLeft.Text = Map.Left
        txtRight.Text = Map.Right
        cmbMoral.SelectedIndex = Map.Moral
        txtBootMap.Text = Map.BootMap
        txtBootX.Text = Map.BootX
        txtBootY.Text = Map.BootY
        lstMapNpc.Items.Clear()

        For x = 0 To MAX_MAP_NPCS
             lstMapNpc.Items.Add(X & ": " & Trim$(Npc(Map.Npc(X)).Name))
        Next

        cmbNpcList.Items.Clear()
        For y = 0 To MAX_NPCS
            cmbNpcList.Items.Add(Y & ": " & Trim$(Npc(Y).Name))
        Next

        lblMap.Text = "Current Map: " & "?"
        txtMaxX.Text = Map.MaxX
        txtMaxY.Text = Map.MaxY

        cmbTileSets.SelectedIndex = 0
        cmbLayers.SelectedIndex = 0
        cmbAutoTile.SelectedIndex = 0
        cmbNpcList.SelectedIndex = 0
        lstMapNpc.SelectedIndex = 1

        cmbWeather.SelectedIndex = Map.WeatherType
        scrlFog.Value = Map.Fogindex
        lblFogIndex.Text = "Fog: " & scrlFog.Value
        scrlIntensity.Value = Map.WeatherIntensity
        lblIntensity.Text = "Intensity: " & scrlIntensity.Value

        cmbPanorama.Items.Clear()
       For i = 0 To NumPanorama
            cmbPanorama.Items.Add(i)
        Next

        cmbParallax.Items.Clear()
       For i = 0 To NumParallax
            cmbParallax.Items.Add(i)
        Next

        tabpages.SelectedIndex = 0

        scrlMapBrightness.Value = Map.Brightness

        ' show the form
        Visible = True

    End Sub

    Public Sub MapEditorInit()
        ' we're in the map editor
        Editor = EditorType.Map
        HideGui = True

        ' set the scrolly bars
        If Map.Tileset = 0 Then Map.Tileset = 1
        If Map.Tileset > NumTileSets Then Map.Tileset = 1

        EditorTileSelStart = New Point(0, 0)
        EditorTileSelEnd = New Point(1, 1)

        ' set shops for the shop attribute
        For i = 0 To MAX_SHOPS
            cmbShop.Items.Add(i & ": " & Shop(i).Name)
        Next
        ' we're not in a shop
        cmbShop.SelectedIndex = 0

        optBlocked.Checked = True

        cmbTileSets.Items.Clear()
        For i = 0 To NumTileSets
            cmbTileSets.Items.Add(i)
        Next

        cmbTileSets.SelectedIndex = 0
        cmbLayers.SelectedIndex = 0

        InitMapProperties = True

        If MapData = True Then GettingMap = False
    End Sub

    Public Sub MapEditorChooseTile(ByVal Button As Integer, ByVal X As Single, ByVal Y As Single)

        If Button = MouseButtons.Left Then 'Left Mouse Button

            EditorTileWidth = 1
            EditorTileHeight = 1

            If cmbAutoTile.SelectedIndex > 0 Then
                Select Case cmbAutoTile.SelectedIndex
                    Case 1 ' autotile
                        EditorTileWidth = 2
                        EditorTileHeight = 3
                    Case 2 ' fake autotile
                        EditorTileWidth = 1
                        EditorTileHeight = 1
                    Case 3 ' animated
                        EditorTileWidth = 6
                        EditorTileHeight = 3
                    Case 4 ' cliff
                        EditorTileWidth = 2
                        EditorTileHeight = 2
                    Case 5 ' waterfall
                        EditorTileWidth = 2
                        EditorTileHeight = 3
                End Select
            End If

            EditorTileX = X \ PicX
            EditorTileY = Y \ PicY

            EditorTileSelStart = New Point(EditorTileX, EditorTileY)
            EditorTileSelEnd = New Point(EditorTileX + EditorTileWidth, EditorTileY + EditorTileHeight)
        End If
    End Sub

    Public Sub MapEditorDrag(ByVal Button As Integer, ByVal X As Single, ByVal Y As Single)
        If Button = MouseButtons.Left Then 'Left Mouse Button
            ' convert the pixel number to tile number
            X = (X \ PicX) + 1
            Y = (Y \ PicY) + 1

            ' check it's not out of bounds
            If X < 0 Then X = 0
            If X > picBackSelect.Width / PicX Then X = picBackSelect.Width / PicX
            If Y < 0 Then Y = 0
            If Y > picBackSelect.Height / PicY Then Y = picBackSelect.Height / PicY

            ' find out what to set the width + height of map editor to
            If X > EditorTileX Then ' drag right
                EditorTileWidth = X - EditorTileX
            End If
            If Y > EditorTileY Then ' drag down
                EditorTileHeight = Y - EditorTileY
            End If

            EditorTileSelStart = New Point(EditorTileX, EditorTileY)
            EditorTileSelEnd = New Point(EditorTileWidth, EditorTileHeight)
        End If

    End Sub

    Public Sub MapEditorMouseDown(ByVal Button As Integer, ByVal X As Integer, ByVal Y As Integer, Optional ByVal movedMouse As Boolean = True)
        Dim i As Integer
        Dim CurLayer As Integer
        Dim tileChanged As Boolean

        CurLayer = cmbLayers.SelectedIndex

        If EyeDropper Then
            MapEditorEyeDropper() 
            Exit Sub
        End If

        For x = 0 To Map.MaxX
            For y = 0 To Map.MaxY
                With Map.Tile(X,Y)
                    If .Layer(CurLayer).Tileset > 0 Then
                        If Not tileChanged Then
                            MapEditorHistory()
                            tileChanged = True
                        End If

                        TileHistory(HistoryIndex).Tile(X,Y).Data1 = .Data1
                        TileHistory(HistoryIndex).Tile(X,Y).Data2 = .Data2
                        TileHistory(HistoryIndex).Tile(X,Y).Data3 = .Data3
                        TileHistory(HistoryIndex).Tile(X,Y).Type = .Type
                        TileHistory(HistoryIndex).Tile(X,Y).DirBlock = .DirBlock

                        TileHistory(HistoryIndex).Tile(X,Y).Layer(CurLayer).X = .Layer(CurLayer).X 
                        TileHistory(HistoryIndex).Tile(X,Y).Layer(CurLayer).Y = .Layer(CurLayer).Y
                        TileHistory(HistoryIndex).Tile(X,Y).Layer(CurLayer).Tileset = .Layer(CurLayer).Tileset
                        TileHistory(HistoryIndex).Tile(X,Y).Layer(CurLayer).AutoTile = .Layer(CurLayer).AutoTile
                    End If
                End With
            Next
        Next

        If Not IsInBounds() Then Exit Sub
        If Button = MouseButtons.Left Then
            If tabpages.SelectedTab Is tpTiles Then
                If EditorTileWidth = 1 AndAlso EditorTileHeight = 1 Then 'single tile
                    MapEditorSetTile(CurX, CurY, CurLayer, False, cmbAutoTile.SelectedIndex)
                Else ' multi tile!
                    If cmbAutoTile.SelectedIndex = 0 Then
                        MapEditorSetTile(CurX, CurY, CurLayer, True)
                    Else
                        MapEditorSetTile(CurX, CurY, CurLayer, , cmbAutoTile.SelectedIndex)
                    End If
                End If 
            ElseIf tabpages.SelectedTab Is tpAttributes Then
                With Map.Tile(CurX, CurY)
                    ' blocked tile
                    If optBlocked.Checked = True Then .Type = TileType.Blocked

                    ' warp tile
                    If optWarp.Checked = True Then
                        .Type = TileType.Warp
                        .Data1 = EditorWarpMap
                        .Data2 = EditorWarpX
                        .Data3 = EditorWarpY
                    End If

                    ' item spawn
                    If optItem.Checked = True Then
                        .Type = TileType.Item
                        .Data1 = ItemEditorNum
                        .Data2 = ItemEditorValue
                        .Data3 = 0
                    End If

                    ' npc avoid
                    If optNPCAvoid.Checked = True Then
                        .Type = TileType.NpcAvoid
                        .Data1 = 0
                        .Data2 = 0
                        .Data3 = 0
                    End If

                    ' resource
                    If optResource.Checked = True Then
                        .Type = TileType.Resource
                        .Data1 = ResourceEditorNum
                        .Data2 = 0
                        .Data3 = 0
                    End If

                    ' npc spawn
                    If optNPCSpawn.Checked = True Then
                        .Type = TileType.NpcSpawn
                        .Data1 = SpawnNpcNum
                        .Data2 = SpawnNpcDir
                        .Data3 = 0
                    End If

                    ' shop
                    If optShop.Checked = True Then
                        .Type = TileType.Shop
                        .Data1 = EditorShop
                        .Data2 = 0
                        .Data3 = 0
                    End If

                    ' bank
                    If optBank.Checked = True Then
                        .Type = TileType.Bank
                        .Data1 = 0
                        .Data2 = 0
                        .Data3 = 0
                    End If

                    ' heal
                    If optHeal.Checked = True Then
                        .Type = TileType.Heal
                        .Data1 = MapEditorHealType
                        .Data2 = MapEditorHealAmount
                        .Data3 = 0
                    End If

                    ' trap
                    If optTrap.Checked = True Then
                        .Type = TileType.Trap
                        .Data1 = MapEditorHealAmount
                        .Data2 = 0
                        .Data3 = 0
                    End If

                    'light
                    If optLight.Checked Then
                        .Type = TileType.Light
                        .Data1 = 0
                        .Data2 = 0
                        .Data3 = 0
                    End If
                End With
            ElseIf tabpages.SelectedTab Is tpDirBlock Then
                If movedMouse Then Exit Sub
                ' find what tile it is
                X -= ((X \ PicX) * PicX)
                Y -= ((Y \ PicY) * PicY)
                ' see if it hits an arrow
                For i = 0 To 4
                    If X >= DirArrowX(i) AndAlso X <= DirArrowX(i) + 8 Then
                        If Y >= DirArrowY(i) AndAlso Y <= DirArrowY(i) + 8 Then
                            ' flip the value.
                            SetDirBlock(Map.Tile(CurX, CurY).DirBlock, (i), Not IsDirBlocked(Map.Tile(CurX, CurY).DirBlock, (i)))
                            Exit Sub
                        End If
                    End If
                Next
            ElseIf tabpages.SelectedTab Is tpEvents Then
                If FrmEditor_Events.Visible = False Then
                    If EventCopy Then
                        CopyEvent_Map(CurX, CurY)
                    ElseIf EventPaste Then
                        PasteEvent_Map(CurX, CurY)
                    Else
                        AddEvent(CurX, CurY)
                    End If
                End If
            End If
        End If

        If Button = MouseButtons.Right Then
            If tabpages.SelectedTab Is tpTiles Then
                If EditorTileWidth = 1 AndAlso EditorTileHeight = 1 Then 'single tile

                    MapEditorSetTile(CurX, CurY, CurLayer, False, cmbAutoTile.SelectedIndex, 1)
                Else ' multi tile!
                    If cmbAutoTile.SelectedIndex = 0 Then
                        MapEditorSetTile(CurX, CurY, CurLayer, True, 0, 1)
                    Else
                        MapEditorSetTile(CurX, CurY, CurLayer, , cmbAutoTile.SelectedIndex, 1)
                    End If
                End If
            ElseIf tabpages.SelectedTab Is tpAttributes Then
                With Map.Tile(CurX, CurY)
                    ' clear attribute
                    .Type = 0
                    .Data1 = 0
                    .Data2 = 0
                    .Data3 = 0
                End With
            ElseIf tabpages.SelectedTab Is tpEvents Then
                DeleteEvent(CurX, CurY)
            End If
        End If
    End Sub

    Public Sub MapEditorCancel()
        If Editor <> EditorType.Map Then Exit sub
        Dim Buffer As ByteStream
        Buffer = New ByteStream(4)
        Buffer.WriteInt32(ClientPackets.CNeedMap)
        Buffer.WriteInt32(1)
        Socket?.SendData(Buffer.Data, Buffer.Head)
        Editor = -1
        HideGui = False
        GettingMap = True
        SendCloseEditor()

        FrmEditor_Events.Dispose()
    End Sub

    Public Sub MapEditorSend()
        SendMap()
        Editor = -1
        GettingMap = True
        SendCloseEditor()
    End Sub

    Public Sub MapEditorSetTile(ByVal X As Integer, ByVal Y As Integer, ByVal CurLayer As Integer, Optional ByVal multitile As Boolean = False, Optional ByVal theAutotile As Byte = 0, Optional eraseTile As Byte = 0)
        Dim x2 As Integer, y2 As Integer, newTileX As Integer, newTileY As integer

        newTileX = EditorTileX
        newTileY = EditorTileY

        If eraseTile Then
            newTileX = 0
            newTileY = 0
        End If

        If theAutotile > 0 Then
            With Map.Tile(X, Y)
                ' set layer
                .Layer(CurLayer).X = newTileX
                .Layer(CurLayer).Y = newTileY
                If eraseTile Then
                    .Layer(CurLayer).Tileset = 0
                Else
                    .Layer(CurLayer).Tileset = cmbTileSets.SelectedIndex
                End If
                .Layer(CurLayer).AutoTile = theAutotile
                CacheRenderState(X, Y, CurLayer)
            End With

            ' do a re-init so we can see our changes
            InitAutotiles()
            Exit Sub
        End If

        If Not multitile Then ' single
            With Map.Tile(X, Y)
                ' set layer
                .Layer(CurLayer).X = newTileX
                .Layer(CurLayer).Y = newTileY
                If eraseTile Then
                    .Layer(CurLayer).Tileset = 0
                Else
                    .Layer(CurLayer).Tileset = cmbTileSets.SelectedIndex
                End If
                .Layer(CurLayer).AutoTile = 0
                CacheRenderState(X, Y, CurLayer)
            End With
        Else ' multitile
            y2 = 0 ' starting tile for y axis
            For Y = CurY To CurY + EditorTileHeight - 1
                x2 = 0 ' re-set x count every y loop
                For X = CurX To CurX + EditorTileWidth - 1
                    If X >= 0 AndAlso X <= Map.MaxX Then
                        If Y >= 0 AndAlso Y <= Map.MaxY Then
                            With Map.Tile(X, Y)
                                .Layer(CurLayer).X = newTileX + x2
                                .Layer(CurLayer).Y = newTileY + y2
                                If eraseTile Then
                                    .Layer(CurLayer).Tileset = 0
                                Else
                                    .Layer(CurLayer).Tileset = cmbTileSets.SelectedIndex
                                End If
                                .Layer(CurLayer).AutoTile = 0
                                CacheRenderState(X, Y, CurLayer)
                            End With
                        End If
                    End If
                    x2 += 1
                Next
                y2 += 1
            Next
        End If
    End Sub

    Public Sub MapEditorHistory()
        Dim x As Integer, y As Integer, j As Integer

        If HistoryIndex = MaxTileHistory then
            For i = 1 To MaxTileHistory - 1
                TileHistory(i) = TileHistory(i + 1)
                TileHistoryHighIndex = TileHistoryHighIndex - 1
            Next
        Else
            HistoryIndex = HistoryIndex + 1
            TileHistoryHighIndex = TileHistoryHighIndex  + 1
            If TileHistoryHighIndex > HistoryIndex Then
                TileHistoryHighIndex = HistoryIndex
            End If
        End If

    End Sub

    Public Sub MapEditorClearLayer()
        Dim X As Integer
        Dim Y As Integer
        Dim CurLayer As Integer

        CurLayer = cmbLayers.SelectedIndex

        ' ask to clear layer
        If MsgBox("Are you sure you wish to clear this layer?", vbYesNo, "MapEditor") = vbYes Then
            For X = 0 To Map.MaxX
                For Y = 0 To Map.MaxY
                    With Map.Tile(X, Y)
                        .Layer(CurLayer).X = 0
                        .Layer(CurLayer).Y = 0
                        .Layer(CurLayer).Tileset = 0
                        .Layer(CurLayer).AutoTile = 0
                        CacheRenderState(X, Y, CurLayer)
                    End With
                Next
            Next
        End If
    End Sub

    Public Sub MapEditorFillLayer(Optional ByVal theAutotile As Byte = 0)
        Dim X As Integer
        Dim Y As Integer
        Dim CurLayer As Integer

        CurLayer = cmbLayers.SelectedIndex

        If MsgBox("Are you sure you wish to fill this layer?", vbYesNo, "Map Editor") = vbYes Then
            If theAutotile > 0 Then
                For X = 0 To Map.MaxX
                    For Y = 0 To Map.MaxY
                        Map.Tile(X, Y).Layer(CurLayer).X = EditorTileX
                        Map.Tile(X, Y).Layer(CurLayer).Y = EditorTileY
                        Map.Tile(X, Y).Layer(CurLayer).Tileset = cmbTileSets.SelectedIndex
                        Map.Tile(X, Y).Layer(CurLayer).AutoTile = theAutotile
                        CacheRenderState(X, Y, CurLayer)
                    Next
                Next

                ' do a re-init so we can see our changes
                InitAutotiles()
            Else
                For X = 0 To Map.MaxX
                    For Y = 0 To Map.MaxY
                        Map.Tile(X, Y).Layer(CurLayer).X = EditorTileX
                        Map.Tile(X, Y).Layer(CurLayer).Y = EditorTileY
                        Map.Tile(X, Y).Layer(CurLayer).Tileset = cmbTileSets.SelectedIndex
                        CacheRenderState(X, Y, CurLayer)
                    Next
                Next
            End If
        End If
    End Sub

    Public Sub MapEditorEyeDropper()
        Dim CurLayer As Integer

        CurLayer = cmbLayers.SelectedIndex

        With Map.Tile(CurX, CurY)
            If .Layer(CurLayer).Tileset > 0 Then
                cmbTileSets.SelectedIndex = .Layer(CurLayer).Tileset
            Else
                cmbTileSets.SelectedIndex = 1
            End If
            MapEditorChooseTile(MouseButtons.Left, .Layer(CurLayer).X * PicX, .Layer(CurLayer).Y * PicY)
            EyeDropper = Not EyeDropper
        End With
    End Sub

    Public sub MapEditorUndo()
        Dim tileChanged As Boolean

        If HistoryIndex = 0 Then
            Exit Sub
        End If

        HistoryIndex = HistoryIndex - 1

        For x = 0 To Map.MaxX
            For y = 0 To Map.MaxY
                For i = 0 To LayerType.Count - 1
                    With Map.Tile(X,Y)
                        If Not (Map.Tile(x,y).Type = TileHistory(HistoryIndex).Tile(x,y).Type) Or (Not .Layer(i).X = TileHistory(HistoryIndex).Tile(x,y).Layer(i).X Or Not .Layer(i).Y = TileHistory(HistoryIndex).Tile(x,y).Layer(i).Y Or Not  .Layer(i).Tileset = TileHistory(HistoryIndex).Tile(x,y).Layer(i).Tileset) Then
                            tileChanged = True
                        End If

                        .Data1 = TileHistory(HistoryIndex).Tile(X,Y).Data1
                        .Data2 = TileHistory(HistoryIndex).Tile(X,Y).Data2
                        .Data3 = TileHistory(HistoryIndex).Tile(X,Y).Data3
                        .Type = TileHistory(HistoryIndex).Tile(X,Y).Type
                        .DirBlock = TileHistory(HistoryIndex).Tile(X,Y).DirBlock
                        .Layer(i).X = TileHistory(HistoryIndex).Tile(X,Y).Layer(i).X
                        .Layer(i).Y = TileHistory(HistoryIndex).Tile(X,Y).Layer(i).Y
                        .Layer(i).Tileset = TileHistory(HistoryIndex).Tile(X,Y).Layer(i).Tileset
                        .Layer(i).AutoTile = TileHistory(HistoryIndex).Tile(X,Y).Layer(i).AutoTile
                        CacheRenderState(x,y, i)
                    End With
                Next
            Next
        Next

        If Not tileChanged Then
            MapEditorUndo()
        End If
    End sub

    Public Sub MapEditorRedo()
        Dim tileChanged As Boolean

        If TileHistoryHighIndex > 0 And (TileHistoryHighIndex = HistoryIndex Or HistoryIndex = MaxTileHistory) Then
            Exit Sub
        End If

        HistoryIndex = HistoryIndex + 1

        For x = 0 To Map.MaxX
            For y = 0 To Map.MaxY
                For i = 0 To LayerType.Count - 1
                     With Map.Tile(x,y)
                        If Not (Map.Tile(x,y).Type = TileHistory(HistoryIndex).Tile(x,y).Type) Or (Not .Layer(i).X = TileHistory(HistoryIndex).Tile(x,y).Layer(i).X Or Not .Layer(i).Y = TileHistory(HistoryIndex).Tile(x,y).Layer(i).Y Or Not  .Layer(i).Tileset = TileHistory(HistoryIndex).Tile(x,y).Layer(i).Tileset) Then
                            tileChanged = True
                        End If

                        .Data1 = TileHistory(HistoryIndex).Tile(X,Y).Data1
                        .Data2 = TileHistory(HistoryIndex).Tile(X,Y).Data2
                        .Data3 = TileHistory(HistoryIndex).Tile(X,Y).Data3
                        .Type = TileHistory(HistoryIndex).Tile(X,Y).Type
                        .DirBlock = TileHistory(HistoryIndex).Tile(X,Y).DirBlock

                        .Layer(i).X = TileHistory(HistoryIndex).Tile(X,Y).Layer(i).X
                        .Layer(i).Y = TileHistory(HistoryIndex).Tile(X,Y).Layer(i).Y
                        .Layer(i).Tileset = TileHistory(HistoryIndex).Tile(X,Y).Layer(i).Tileset
                        .Layer(i).AutoTile = TileHistory(HistoryIndex).Tile(X,Y).Layer(i).AutoTile
                        CacheRenderState(x,y, i)
                    End With
                Next
            Next
        Next

        If Not tileChanged Then
            MapEditorRedo()
        End If
    End Sub

    Public Sub ClearAttributeDialogue()
        fraNpcSpawn.Visible = False
        fraResource.Visible = False
        fraMapItem.Visible = False
        fraMapWarp.Visible = False
        fraShop.Visible = False
        fraHeal.Visible = False
        fraTrap.Visible = False
    End Sub

    Public Sub MapEditorClearAttribs()
        Dim X As Integer
        Dim Y As Integer

        If MsgBox("Are you sure you wish to clear the attributes on this map?", vbYesNo, "MapEditor") = vbYes Then

            For X = 0 To Map.MaxX
                For Y = 0 To Map.MaxY
                    Map.Tile(X, Y).Type = 0
                Next
            Next

        End If

    End Sub

    Private Sub cmbTileSets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTileSets.SelectedIndexChanged
        If cmbTileSets.SelectedIndex = 0 Then cmbTileSets.SelectedIndex = 1
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Map.Name = txtName.Text
    End Sub

    Private Sub frmEditor_Map_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MapEditorCancel
    End Sub

    Private Sub scrMapBrightness_Scroll(sender As Object, e As ScrollEventArgs) Handles scrlMapBrightness.Scroll
        Map.Brightness = scrlMapBrightness.Value
        lblMapBrightness.Text = "Brightness: " & scrlMapBrightness.Value
    End Sub

#End Region

#Region "Drawing"

    Public Sub DrawTileset()
        'Dim height As Integer
        'Dim width As Integer
        Dim tileset As Byte

        ' find tileset number
        tileset = cmbTileSets.SelectedIndex
        TilesetWindow.Clear(ToSfmlColor(picBackSelect.BackColor))

        Dim rec2 As New RectangleShape With {
            .OutlineColor = New SFML.Graphics.Color(SFML.Graphics.Color.Red),
            .OutlineThickness = 0.6,
            .FillColor = New SFML.Graphics.Color(SFML.Graphics.Color.Transparent)
        }

        If TileSetTextureInfo(tileset).IsLoaded = False Then
            LoadTexture(tileset, 1)
        End If
        ' we use it, lets update timer
        With TileSetTextureInfo(tileset)
            .TextureTimer = GetTickCount() + 100000
        End With

        ' change selected shape for autotiles
        If Me.cmbAutoTile.SelectedIndex > 0 Then
            Select Case Me.cmbAutoTile.SelectedIndex
                Case 1 ' autotile
                    EditorTileWidth = 2
                    EditorTileHeight = 3
                Case 2 ' fake autotile
                    EditorTileWidth = 1
                    EditorTileHeight = 1
                Case 3 ' animated
                    EditorTileWidth = 6
                    EditorTileHeight = 3
                Case 4 ' cliff
                    EditorTileWidth = 2
                    EditorTileHeight = 2
                Case 5 ' waterfall
                    EditorTileWidth = 2
                    EditorTileHeight = 3
                Case Else
                    EditorTileWidth = 1
                    EditorTileHeight = 1
            End Select
        End If

        If TileSetTextureInfo(tileset).Width < picBackSelect.Width Or TileSetTextureInfo(tileset).Height < picBackSelect.Height Then
            RenderSprite(TileSetSprite(tileset), TilesetWindow, 0, 0, 0, 0, TileSetTextureInfo(tileset).Width, TileSetTextureInfo(tileset).Height)
        Else
            RenderSprite(TileSetSprite(tileset), TilesetWindow, 0, 0, 0, 0, picBackSelect.Width, picBackSelect.Height)
        End If

        rec2.Size = New Vector2f(EditorTileWidth * PicX, EditorTileHeight * PicY)
        rec2.Position = New Vector2f((EditorTileSelStart.X * PicX), (EditorTileSelStart.Y * PicY))

        'Me.picBackSelect.BackgroundImage = Drawing.Image.FromFile(Paths.Graphics & "tilesets\" & tileset * GfxExt)
        TilesetWindow.Draw(rec2)

        'and finally show everything on screen
        TilesetWindow.Display()
    End Sub

    Public Sub DrawMapItem()
        Dim itemnum As Integer
        itemnum = Item(Me.scrlMapItem.Value).Pic

        If itemnum < 0 OrElse itemnum > NumItems Then
            Me.picMapItem.BackgroundImage = Nothing
            Exit Sub
        End If

        If File.Exists(Paths.Graphics & "items\" & itemnum & GfxExt) Then
            Me.picMapItem.BackgroundImage = Drawing.Image.FromFile(Paths.Graphics & "items\" & itemnum & GfxExt)
        End If

    End Sub

    Private Sub lstMapNpc_Click(sender As Object, e As EventArgs) Handles lstMapNpc.Click
        If lstMapNpc.SelectedIndex = 0 Then lstMapNpc.SelectedIndex = 1
    End Sub

    Private Sub tsbCopyMap_Click(sender As Object, e As EventArgs) Handles tsbCopyMap.Click
        Dim i As Integer, X As Integer, Y As Integer

        If CopyMap = False Then
            ReDim TmpTile(Map.MaxX, Map.MaxY)
            TmpMaxX = Map.MaxX
            TmpMaxY = Map.MaxY

            For X = 0 To Map.MaxX
                For Y = 0 To Map.MaxY
                    With Map.Tile(X,Y)
                        ReDim TmpTile(X,Y).Layer(LayerType.Count - 1)

                        TmpTile(X,Y).Data1 = .Data1
                        TmpTile(X,Y).Data2 = .Data2
                        TmpTile(X,Y).Data3 = .Data3
                        TmpTile(X,Y).Type = .Type
                        TmpTile(X,Y).DirBlock = .DirBlock

                        For i = 0 To LayerType.Count - 1 
                            TmpTile(X,Y).Layer(i).X = .Layer(i).X
                            TmpTile(X,Y).Layer(i).Y = .Layer(i).Y
                            TmpTile(X,Y).Layer(i).Tileset = .Layer(i).Tileset
                            TmpTile(X,Y).Layer(i).AutoTile = .Layer(i).AutoTile
                        Next
                    End With
                Next
            Next

            CopyMap = True
            MsgBox("Map copied. Go to another map to paste it.")
        Else
            ReDim Map.Tile(TmpMaxX, TmpMaxY)
            ReDim Autotile(TmpMaxX, TmpMaxY)
            Map.MaxX = TmpMaxX
            Map.MaxY = TmpMaxY            

            For X = 0 To Map.MaxX
                For Y = 0 To Map.MaxY
                    With Map.Tile(X,Y)
                        ReDim Map.Tile(X,Y).Layer(LayerType.Count - 1)
                        ReDim Autotile(X, Y).Layer(LayerType.Count - 1)

                        .Data1 = TmpTile(X,Y).Data1
                        .Data2 =  TmpTile(X,Y).Data2
                        .Data3 = TmpTile(X,Y).Data3
                        .Type = TmpTile(X,Y).Type
                        .DirBlock = TmpTile(X,Y).DirBlock

                        For i = 0 To LayerType.Count - 1 
                            .Layer(i).X = TmpTile(X,Y).Layer(i).X
                            .Layer(i).Y = TmpTile(X,Y).Layer(i).Y
                            .Layer(i).Tileset = TmpTile(X,Y).Layer(i).Tileset
                            .Layer(i).AutoTile = TmpTile(X,Y).Layer(i).AutoTile
                            CacheRenderState(X,Y,i)
                        Next
                    End With
                Next
            Next 
            CopyMap = False
        End If
    End Sub

    Private Sub tsbUndo_Click(sender As Object, e As EventArgs) Handles tsbUndo.Click
        MapEditorUndo()
    End Sub

    Private Sub tsbRedo_Click(sender As Object, e As EventArgs) Handles tsbRedo.Click
        MapEditorRedo()
    End Sub

    Private Sub tsbOpacity_Click(sender As Object, e As EventArgs) Handles tsbOpacity.Click
        HideLayers = Not HideLayers
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsbLight.Click
        Night = Not Night
    End Sub
#End Region

End Class