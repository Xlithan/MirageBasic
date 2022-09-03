Imports System.IO
Imports System.Windows.Forms
Imports MirageBasic.Core

Friend Class frmEditor_Shop
    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim tmpindex As Integer

        tmpindex = lstIndex.SelectedIndex
        Shop(Editorindex).Name = Trim$(txtName.Text)
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Shop(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex
    End Sub

    Private Sub ScrlBuy_Scroll(sender As Object, e As EventArgs) Handles nudBuy.ValueChanged
        Shop(Editorindex).BuyRate = nudBuy.Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim index As Integer

        index = lstTradeItem.SelectedIndex
        With Shop(Editorindex).TradeItem(index)
            .Item = cmbItem.SelectedIndex
            .ItemValue = nudItemValue.Value
            .CostItem = cmbCostItem.SelectedIndex
            .CostValue = nudCostValue.Value
        End With
        Call UpdateShopTrade()
    End Sub

    Private Sub BtnDeleteTrade_Click(sender As Object, e As EventArgs) Handles btnDeleteTrade.Click
        Dim index As Integer

        index = lstTradeItem.SelectedIndex
        With Shop(Editorindex).TradeItem(index)
            .Item = 0
            .ItemValue = 0
            .CostItem = 0
            .CostValue = 0
        End With
        Call UpdateShopTrade()
    End Sub

    Private Sub LstIndex_Click(sender As Object, e As EventArgs) Handles lstIndex.Click
        ShopEditorInit()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Len(Trim$(txtName.Text)) = 0 Then
            MsgBox("Name required.")
        Else
            ShopEditorOk()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ShopEditorCancel()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim tmpindex As Integer

        ClearShop(Editorindex)

        tmpindex = lstIndex.SelectedIndex
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Shop(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex

        ShopEditorInit()
    End Sub

    Private Sub ScrlFace_Scroll(sender As Object, e As EventArgs) Handles nudFace.ValueChanged

        If File.Exists(Paths.Graphics & "Faces\" & nudFace.Value & GfxExt) Then
            Me.picFace.BackgroundImage = Image.FromFile(Paths.Graphics & "\Faces\" & nudFace.Value & GfxExt)
        End If

        Shop(Editorindex).Face = nudFace.Value
    End Sub

    Private Sub frmEditor_Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstIndex.Items.Clear()

        ' Add the names
        For i = 0 To MAX_SHOPS
            lstIndex.Items.Add(i & ": " & Trim$(Shop(i).Name))
        Next

        cmbItem.Items.Clear()
        cmbCostItem.Items.Clear()

        For i = 0 To MAX_ITEMS
            cmbItem.Items.Add(i & ": " & Trim$(Item(i).Name))
            cmbCostItem.Items.Add(i & ": " & Trim$(Item(i).Name))
        Next
    End Sub
End Class