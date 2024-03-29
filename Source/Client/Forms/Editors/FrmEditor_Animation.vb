﻿Imports Mirage.Basic.Engine
Imports SFML.Graphics

Friend Class FrmEditor_Animation
    Private Sub NudSprite0_ValueChanged(sender As Object, e As EventArgs) Handles nudSprite0.Click
        Animation(Editorindex).Sprite(0) = nudSprite0.Value
    End Sub

    Private Sub NudSprite1_ValueChanged(sender As Object, e As EventArgs) Handles nudSprite1.Click
        Animation(Editorindex).Sprite(1) = nudSprite1.Value
    End Sub

    Private Sub NudLoopCount0_ValueChanged(sender As Object, e As EventArgs) Handles nudLoopCount0.Click
        Animation(Editorindex).LoopCount(0) = nudLoopCount0.Value
    End Sub

    Private Sub NudLoopCount1_ValueChanged(sender As Object, e As EventArgs) Handles nudLoopCount1.Click
        Animation(Editorindex).LoopCount(1) = nudLoopCount1.Value
    End Sub

    Private Sub NudFrameCount0_ValueChanged(sender As Object, e As EventArgs) Handles nudFrameCount0.Click
        Animation(Editorindex).Frames(0) = nudFrameCount0.Value
    End Sub

    Private Sub NudFrameCount1_ValueChanged(sender As Object, e As EventArgs) Handles nudFrameCount1.Click
        Animation(Editorindex).Frames(1) = nudFrameCount1.Value
    End Sub

    Private Sub NudLoopTime0_ValueChanged(sender As Object, e As EventArgs) Handles nudLoopTime0.Click
        Animation(Editorindex).LoopTime(0) = nudLoopTime0.Value
    End Sub

    Private Sub NudLoopTime1_ValueChanged(sender As Object, e As EventArgs) Handles nudLoopTime1.Click
        Animation(Editorindex).LoopTime(1) = nudLoopTime1.Value
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        AnimationEditorOk()
        Dispose()
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim tmpindex As Integer
        tmpindex = lstIndex.SelectedIndex
        Animation(Editorindex).Name = Trim$(txtName.Text)
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Animation(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex
    End Sub

    Private Sub LstIndex_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lstIndex.Click
        If lstIndex.SelectedIndex = 0 Then lstIndex.SelectedIndex = 1
        AnimationEditorInit()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim tmpindex As Integer

        ClearAnimation(Editorindex)

        tmpindex = lstIndex.SelectedIndex
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Animation(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex

        AnimationEditorInit()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AnimationEditorCancel()
        Dispose()
    End Sub

    Private Sub FrmEditor_Animation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstIndex.Items.Clear()

        ' Add the names
        For i = 0 To MAX_ANIMATIONS
            lstIndex.Items.Add(i & ": " & Trim$(Animation(i).Name))
        Next

        ' find the music we have set
        cmbSound.Items.Clear()

        CacheSound
        For i = 0 To UBound(SoundCache)
            cmbSound.Items.Add(SoundCache(i))
        Next

        nudSprite0.Maximum = NumAnimations
        nudSprite1.Maximum = NumAnimations

        EditorAnimation_Anim1 = New RenderWindow(picSprite0.Handle)
        EditorAnimation_Anim2 = New RenderWindow(picSprite1.Handle)
    End Sub

    Private Sub CmbSound_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSound.SelectedIndexChanged
        Animation(Editorindex).Sound = cmbSound.SelectedItem.ToString
    End Sub

    Private Sub FrmEditor_Animation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        AnimationEditorCancel
    End Sub

End Class