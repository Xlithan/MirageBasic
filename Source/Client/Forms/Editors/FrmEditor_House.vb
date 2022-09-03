Imports MirageBasic.Core

Friend Class frmEditor_House

    Private Sub LstIndex_Click(sender As Object, e As EventArgs) Handles lstIndex.Click
        HouseEditorInit()
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim tmpindex As Integer

        tmpindex = lstIndex.SelectedIndex
        House(Editorindex).ConfigName = Trim$(txtName.Text)
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & House(Editorindex).ConfigName)
        lstIndex.SelectedIndex = tmpindex
    End Sub

    Private Sub NudBaseMap_ValueChanged(sender As Object, e As EventArgs) Handles nudBaseMap.KeyUp, nudBaseMap.Click
        House(Editorindex).BaseMap = nudBaseMap.Value
    End Sub

    Private Sub NudX_ValueChanged(sender As Object, e As EventArgs) Handles nudX.KeyUp, nudX.Click
        House(Editorindex).X = nudX.Value
    End Sub

    Private Sub NudY_ValueChanged(sender As Object, e As EventArgs) Handles nudY.KeyUp, nudY.Click
        House(Editorindex).Y = nudY.Value
    End Sub

    Private Sub NudPrice_ValueChanged(sender As Object, e As EventArgs) Handles nudPrice.KeyUp, nudPrice.Click
        House(Editorindex).Price = nudPrice.Value

    End Sub

    Private Sub NudFurniture_ValueChanged(sender As Object, e As EventArgs) Handles nudFurniture.KeyUp, nudFurniture.Click
        House(Editorindex).MaxFurniture = nudFurniture.Value
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Len(Trim$(txtName.Text)) = 0 Then
            MsgBox("Name required.")
            Exit Sub
        End If

        If nudBaseMap.Value = 0 Then
            MsgBox("Base map required.")
            Exit Sub
        End If

        HouseEditorOk()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        HouseEditorCancel()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim tmpindex As Integer

        House(EditorIndex).ConfigName = ""
        House(Editorindex).Price = 0
        House(EditorIndex).BaseMap = 0
        House(EditorIndex).MaxFurniture = 0
        House(EditorIndex).X = 0
        House(EditorIndex).Y = 0

        tmpindex = lstIndex.SelectedIndex
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & House(Editorindex).ConfigName)
        lstIndex.SelectedIndex = tmpindex
        
        HouseEditorInit
    End Sub

    Private Sub frmEditor_House_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstIndex.Items.Clear()

        ' Add the names
        For i = 0 To MAX_HOUSES
            lstIndex.Items.Add(i & ": " & Trim$(House(i).ConfigName))
        Next
    End Sub
End Class