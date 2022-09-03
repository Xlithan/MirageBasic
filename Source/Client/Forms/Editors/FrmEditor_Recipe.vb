Imports MirageBasic.Core

Friend Class frmEditor_Recipe

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        RecipeEditorOk()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        RecipeEditorCancel()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim tmpindex As Integer

        ClearRecipe(Editorindex)

        tmpindex = lstIndex.SelectedIndex
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Recipe(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex

        lstIngredients.Items.Clear()

        RecipeEditorInit()
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim tmpindex As Integer

        tmpindex = lstIndex.SelectedIndex
        Recipe(Editorindex).Name = Trim$(txtName.Text)
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Recipe(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex
    End Sub

    Private Sub LstIndex_Click(sender As Object, e As EventArgs) Handles lstIndex.Click
        If lstIndex.SelectedIndex = 0 Then lstIndex.SelectedIndex = 1
        RecipeEditorInit()
    End Sub

    Private Sub BtnIngredientAdd_Click(sender As Object, e As EventArgs) Handles btnIngredientAdd.Click
        Recipe(Editorindex).Ingredients(lstIngredients.SelectedIndex).ItemNum = cmbIngredient.SelectedIndex
        Recipe(Editorindex).Ingredients(lstIngredients.SelectedIndex).Value = numItemAmount.Value

        UpdateIngredient()
    End Sub

    Private Sub CmbMakeItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMakeItem.SelectedIndexChanged
        Recipe(Editorindex).MakeItemNum = cmbMakeItem.SelectedIndex
    End Sub

    Private Sub CmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        Recipe(Editorindex).RecipeType = cmbType.SelectedIndex
    End Sub

    Private Sub NudAmount_ValueChanged(sender As Object, e As EventArgs) Handles nudAmount.ValueChanged
        Recipe(Editorindex).MakeItemAmount = nudAmount.Value
    End Sub

    Private Sub NudCreateTime_ValueChanged(sender As Object, e As EventArgs) Handles nudCreateTime.ValueChanged
        Recipe(Editorindex).CreateTime = nudCreateTime.Value
    End Sub

    Private Sub frmEditor_Recipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstIndex.Items.Clear()

        ' Add the names
        For i = 0 To MAX_RECIPE
            lstIndex.Items.Add(i & ": " & Trim$(Recipe(i).Name))
        Next

        'fill comboboxes
        cmbMakeItem.Items.Clear()
        cmbIngredient.Items.Clear()

        For i = 0 To MAX_ITEMS
            cmbMakeItem.Items.Add(Trim$(Item(i).Name))
            cmbIngredient.Items.Add(Trim$(Item(i).Name))
        Next
    End Sub
End Class