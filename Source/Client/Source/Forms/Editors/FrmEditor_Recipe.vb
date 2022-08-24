﻿Imports MirageBasic.Core

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

    Private Sub LstIndex_MouseClick(sender As Object, e As EventArgs) Handles lstIndex.MouseClick
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

End Class