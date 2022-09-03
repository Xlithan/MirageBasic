Imports System.IO
Imports MirageBasic.Core

Friend Class frmEditor_Job

#Region "Frm Controls"

    Private Sub FrmEditor_Job_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudMaleSprite.Maximum = NumCharacters
        nudFemaleSprite.Maximum = NumCharacters

        For i = 0 To MAX_JOBS
            lstIndex.Items.Add(i & ": " & Trim(Job(i).Name))
        Next

        nudMaleSprite.Maximum = NumCharacters
        nudFemaleSprite.Maximum = NumCharacters

        cmbItems.Items.Clear()

        For i = 0 To MAX_ITEMS
            cmbItems.Items.Add(Trim(Item(i).Name))
        Next

        cmbMaleSprite.Items.Clear()

        For i = 0 To UBound(Job(Editorindex).MaleSprite)
            cmbMaleSprite.Items.Add("Sprite " & i + 1)
        Next

        cmbFemaleSprite.Items.Clear()

        For i = 0 To UBound(Job(Editorindex).FemaleSprite)
            cmbFemaleSprite.Items.Add("Sprite " & i + 1)
        Next
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

        tmpindex = lstIndex.SelectedIndex
        Job(Editorindex).Name = Trim$(txtName.Text)
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Job(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex
    End Sub

#End Region

#Region "Sprites"

    Private Sub BtnAddMaleSprite_Click(sender As Object, e As EventArgs) Handles btnAddMaleSprite.Click
        Dim tmpamount As Byte

        tmpamount = UBound(Job(Editorindex).MaleSprite)

        ReDim Preserve Job(Editorindex).MaleSprite(tmpamount + 1)

        Job(Editorindex).MaleSprite(tmpamount + 1) = 1
    End Sub

    Private Sub BtnDeleteMaleSprite_Click(sender As Object, e As EventArgs) Handles btnDeleteMaleSprite.Click
        Dim tmpamount As Byte

        tmpamount = UBound(Job(Editorindex).MaleSprite)

        ReDim Preserve Job(Editorindex).MaleSprite(tmpamount)
    End Sub

    Private Sub BtnAddFemaleSprite_Click(sender As Object, e As EventArgs) Handles btnAddFemaleSprite.Click
        Dim tmpamount As Byte

        tmpamount = UBound(Job(Editorindex).FemaleSprite)

        ReDim Preserve Job(Editorindex).FemaleSprite(tmpamount + 1)

        Job(Editorindex).FemaleSprite(tmpamount) = 1
    End Sub

    Private Sub BtnDeleteFemaleSprite_Click(sender As Object, e As EventArgs) Handles btnDeleteFemaleSprite.Click
        Dim tmpamount As Byte

        tmpamount = UBound(Job(Editorindex).FemaleSprite)

        ReDim Preserve Job(Editorindex).FemaleSprite(tmpamount)
    End Sub

    Private Sub NudMaleSprite_ValueChanged(sender As Object, e As EventArgs) Handles nudMaleSprite.Click
        If cmbMaleSprite.SelectedIndex < 0 Then Exit Sub

        Job(Editorindex).MaleSprite(cmbMaleSprite.SelectedIndex) = nudMaleSprite.Value

        DrawPreview()
    End Sub

    Private Sub NudFemaleSprite_ValueChanged(sender As Object, e As EventArgs) Handles nudFemaleSprite.Click
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
        Job(Editorindex).Stat(StatType.Strength) = nudStrength.Value
    End Sub

    Private Sub NumLuck_ValueChanged(sender As Object, e As EventArgs) Handles nudLuck.Click
        Job(Editorindex).Stat(StatType.Luck) = nudLuck.Value
    End Sub

    Private Sub NumEndurance_ValueChanged(sender As Object, e As EventArgs) Handles nudEndurance.Click
        Job(Editorindex).Stat(StatType.Endurance) = nudEndurance.Value
    End Sub

    Private Sub NumIntelligence_ValueChanged(sender As Object, e As EventArgs) Handles nudIntelligence.Click
        Job(Editorindex).Stat(StatType.Intelligence) = nudIntelligence.Value
    End Sub

    Private Sub NumVitality_ValueChanged(sender As Object, e As EventArgs) Handles nudVitality.Click
        Job(Editorindex).Stat(StatType.Vitality) = nudVitality.Value
    End Sub

    Private Sub NumSpirit_ValueChanged(sender As Object, e As EventArgs) Handles nudSpirit.Click
        Job(Editorindex).Stat(StatType.Spirit) = nudSpirit.Value
    End Sub

    Private Sub NumBaseExp_ValueChanged(sender As Object, e As EventArgs) Handles nudBaseExp.Click
        Job(Editorindex).BaseExp = nudBaseExp.Value
    End Sub

#End Region

#Region "Start Items"

    Private Sub BtnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
        Job(Editorindex).StartItem(lstStartItems.SelectedIndex ) = cmbItems.SelectedIndex
        Job(Editorindex).StartValue(lstStartItems.SelectedIndex ) = nudItemAmount.Value
    End Sub

#End Region

#Region "Starting Point"

    Private Sub NumStartMap_ValueChanged(sender As Object, e As EventArgs) Handles nudStartMap.Click
        Job(Editorindex).StartMap = nudStartMap.Value
    End Sub

    Private Sub NumStartX_ValueChanged(sender As Object, e As EventArgs) Handles nudStartX.Click
        Job(Editorindex).StartX = nudStartX.Value
    End Sub

    Private Sub NumStartY_ValueChanged(sender As Object, e As EventArgs) Handles nudStartY.Click
        Job(Editorindex).StartY = nudStartY.Value
    End Sub

    Private Sub lstIndex_Click(sender As Object, e As EventArgs) Handles lstIndex.Click
        JobEditorInit
    End Sub

#End Region

End Class