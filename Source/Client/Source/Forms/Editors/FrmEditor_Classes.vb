﻿Imports System.IO
Imports MirageBasic.Core

Friend Class frmEditor_Job

#Region "Frm Controls"

    Private Sub FrmEditor_Job_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudMaleSprite.Maximum = NumCharacters
        nudFemaleSprite.Maximum = NumCharacters

        DrawPreview()
    End Sub

    Private Sub LstIndex_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIndex.SelectedIndexChanged
        If lstIndex.SelectedIndex < 0 Then Exit Sub

        Editorindex = lstIndex.SelectedIndex + 1

        LoadClassInfo = True
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        JobEditorOk()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        JobEditorCancel()
    End Sub

    Private Sub TxtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        Job(Editorindex).Desc = txtDescription.Text
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim tmpindex As Integer
        If Editorindex = 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        tmpindex = lstIndex.SelectedIndex
        Job(Editorindex).Name = Trim$(txtName.Text)
        lstIndex.Items.RemoveAt(Editorindex - 1)
        lstIndex.Items.Insert(Editorindex - 1, Trim(Job(Editorindex).Name))
        lstIndex.SelectedIndex = tmpindex
    End Sub

#End Region

#Region "Sprites"

    Private Sub BtnAddMaleSprite_Click(sender As Object, e As EventArgs) Handles btnAddMaleSprite.Click
        Dim tmpamount As Byte
        If Editorindex = 0 OrElse Editorindex > MAX_JOB then Exit Sub

        tmpamount = UBound(Job(Editorindex).MaleSprite)

        ReDim Preserve Job(Editorindex).MaleSprite(tmpamount + 1)

        Job(Editorindex).MaleSprite(tmpamount + 1) = 1

        LoadClassInfo = True
    End Sub

    Private Sub BtnDeleteMaleSprite_Click(sender As Object, e As EventArgs) Handles btnDeleteMaleSprite.Click
        Dim tmpamount As Byte
        If Editorindex = 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        tmpamount = UBound(Job(Editorindex).MaleSprite)

        ReDim Preserve Job(Editorindex).MaleSprite(tmpamount - 1)

        LoadClassInfo = True
    End Sub

    Private Sub BtnAddFemaleSprite_Click(sender As Object, e As EventArgs) Handles btnAddFemaleSprite.Click
        Dim tmpamount As Byte
        If Editorindex = 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        tmpamount = UBound(Job(Editorindex).FemaleSprite)

        ReDim Preserve Job(Editorindex).FemaleSprite(tmpamount + 1)

        Job(Editorindex).FemaleSprite(tmpamount + 1) = 1

        LoadClassInfo = True
    End Sub

    Private Sub BtnDeleteFemaleSprite_Click(sender As Object, e As EventArgs) Handles btnDeleteFemaleSprite.Click
        Dim tmpamount As Byte
        If Editorindex = 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        tmpamount = UBound(Job(Editorindex).FemaleSprite)

        ReDim Preserve Job(Editorindex).FemaleSprite(tmpamount - 1)

        LoadClassInfo = True
    End Sub

    Private Sub NudMaleSprite_ValueChanged(sender As Object, e As EventArgs) Handles nudMaleSprite.Click
        If cmbMaleSprite.SelectedIndex < 0 Then Exit Sub

        Job(Editorindex).MaleSprite(cmbMaleSprite.SelectedIndex) = nudMaleSprite.Value

        DrawPreview()
    End Sub

    Private Sub NudFemaleSprite_ValueChanged(sender As Object, e As EventArgs) Handles nudFemaleSprite.Click
        If cmbFemaleSprite.SelectedIndex < 0 Then Exit Sub

        Job(Editorindex).FemaleSprite(cmbFemaleSprite.SelectedIndex) = nudFemaleSprite.Value

        DrawPreview()
    End Sub

    Private Sub CmbMaleSprite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaleSprite.SelectedIndexChanged
        nudMaleSprite.Value = Job(Editorindex).MaleSprite(cmbMaleSprite.SelectedIndex)
        DrawPreview()
    End Sub

    Private Sub CmbFemaleSprite_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFemaleSprite.SelectedIndexChanged
        nudFemaleSprite.Value = Job(Editorindex).FemaleSprite(cmbFemaleSprite.SelectedIndex)
        DrawPreview()
    End Sub

    Sub DrawPreview()

        If File.Exists(Paths.Graphics & "Characters\" & nudMaleSprite.Value & GfxExt) Then
            picMale.Width = Image.FromFile(Paths.Graphics & "characters\" & nudMaleSprite.Value & GfxExt).Width \ 4
            picMale.Height = Image.FromFile(Paths.Graphics & "characters\" & nudMaleSprite.Value & GfxExt).Height \ 4
            picMale.BackgroundImage = Image.FromFile(Paths.Graphics & "Characters\" & nudMaleSprite.Value & GfxExt)
        End If

        If File.Exists(Paths.Graphics & "Characters\" & nudFemaleSprite.Value & GfxExt) Then
            picFemale.Width = Image.FromFile(Paths.Graphics & "characters\" & nudFemaleSprite.Value & GfxExt).Width \ 4
            picFemale.Height = Image.FromFile(Paths.Graphics & "characters\" & nudFemaleSprite.Value & GfxExt).Height \ 4
            picFemale.BackgroundImage = Image.FromFile(Paths.Graphics & "Characters\" & nudFemaleSprite.Value & GfxExt)
        End If

    End Sub

    Private Sub PicMale_Paint(sender As Object, e As EventArgs) Handles picMale.Paint
        'nope
    End Sub

    Private Sub PicFemale_Paint(sender As Object, e As EventArgs) Handles picFemale.Paint
        'nope
    End Sub

#End Region

#Region "Stats"

    Private Sub NumStrength_ValueChanged(sender As Object, e As EventArgs) Handles nudStrength.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).Stat(StatType.Strength) = nudStrength.Value
    End Sub

    Private Sub NumLuck_ValueChanged(sender As Object, e As EventArgs) Handles nudLuck.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).Stat(StatType.Luck) = nudLuck.Value
    End Sub

    Private Sub NumEndurance_ValueChanged(sender As Object, e As EventArgs) Handles nudEndurance.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).Stat(StatType.Endurance) = nudEndurance.Value
    End Sub

    Private Sub NumIntelligence_ValueChanged(sender As Object, e As EventArgs) Handles nudIntelligence.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).Stat(StatType.Intelligence) = nudIntelligence.Value
    End Sub

    Private Sub NumVitality_ValueChanged(sender As Object, e As EventArgs) Handles nudVitality.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).Stat(StatType.Vitality) = nudVitality.Value
    End Sub

    Private Sub NumSpirit_ValueChanged(sender As Object, e As EventArgs) Handles nudSpirit.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).Stat(StatType.Spirit) = nudSpirit.Value
    End Sub

    Private Sub NumBaseExp_ValueChanged(sender As Object, e As EventArgs) Handles nudBaseExp.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).BaseExp = nudBaseExp.Value
    End Sub

#End Region

#Region "Start Items"

    Private Sub BtnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
        If lstStartItems.SelectedIndex < 0 OrElse cmbItems.SelectedIndex < 0 Then Exit Sub

        Job(Editorindex).StartItem(lstStartItems.SelectedIndex + 1) = cmbItems.SelectedIndex
        Job(Editorindex).StartValue(lstStartItems.SelectedIndex + 1) = nudItemAmount.Value

        LoadClassInfo = True
    End Sub

#End Region

#Region "Starting Point"

    Private Sub NumStartMap_ValueChanged(sender As Object, e As EventArgs) Handles nudStartMap.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).StartMap = nudStartMap.Value
    End Sub

    Private Sub NumStartX_ValueChanged(sender As Object, e As EventArgs) Handles nudStartX.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).StartX = nudStartX.Value
    End Sub

    Private Sub NumStartY_ValueChanged(sender As Object, e As EventArgs) Handles nudStartY.Click
        If Editorindex <= 0 OrElse Editorindex > MAX_JOB Then Exit Sub

        Job(Editorindex).StartY = nudStartY.Value
    End Sub

#End Region

End Class