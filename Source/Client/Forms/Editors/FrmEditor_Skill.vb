﻿Imports MirageBasic.Core
Imports SFML.Graphics

Friend Class frmEditor_Skill

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim tmpindex As Integer
        tmpindex = lstIndex.SelectedIndex
        Skill(Editorindex).Name = Trim$(txtName.Text)
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Skill(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex
    End Sub

    Private Sub CmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        Skill(Editorindex).Type = cmbType.SelectedIndex
    End Sub

    Private Sub NudMp_ValueChanged(sender As Object, e As EventArgs) Handles nudMp.ValueChanged
        Skill(Editorindex).MpCost = nudMp.Value
    End Sub

    Private Sub NudLevel_ValueChanged(sender As Object, e As EventArgs) Handles nudLevel.ValueChanged
        Skill(Editorindex).LevelReq = nudLevel.Value
    End Sub

    Private Sub CmbAccessReq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAccessReq.SelectedIndexChanged
        Skill(Editorindex).AccessReq = cmbAccessReq.SelectedIndex
    End Sub

    Private Sub CmbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJob.SelectedIndexChanged
        Skill(Editorindex).JobReq = cmbJob.SelectedIndex
    End Sub

    Private Sub NudCast_Scroll(sender As Object, e As EventArgs) Handles nudCast.ValueChanged
        Skill(Editorindex).CastTime = nudCast.Value
    End Sub

    Private Sub NudCool_Scroll(sender As Object, e As EventArgs) Handles nudCool.ValueChanged
        Skill(Editorindex).CdTime = nudCool.Value
    End Sub

    Private Sub NudIcon_Scroll(sender As Object, e As EventArgs) Handles nudIcon.ValueChanged
        Skill(Editorindex).Icon = nudIcon.Value
        EditorSkill_DrawIcon()
    End Sub

    Private Sub NudMap_Scroll(sender As Object, e As EventArgs) Handles nudMap.ValueChanged
        Skill(Editorindex).Map = nudMap.Value
    End Sub

    Private Sub CmbDir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDir.SelectedIndexChanged
        Skill(Editorindex).Dir = cmbDir.SelectedIndex
    End Sub

    Private Sub NudX_Scroll(sender As Object, e As EventArgs) Handles nudX.ValueChanged
        Skill(Editorindex).X = nudX.Value
    End Sub

    Private Sub NudY_Scroll(sender As Object, e As EventArgs) Handles nudY.ValueChanged
        Skill(Editorindex).Y = nudY.Value
    End Sub

    Private Sub NudVital_Scroll(sender As Object, e As EventArgs) Handles nudVital.ValueChanged
        Skill(Editorindex).Vital = nudVital.Value
    End Sub

    Private Sub NudDuration_Scroll(sender As Object, e As EventArgs) Handles nudDuration.ValueChanged
        Skill(Editorindex).Duration = nudDuration.Value
    End Sub

    Private Sub NudInterval_Scroll(sender As Object, e As EventArgs) Handles nudInterval.ValueChanged
        Skill(Editorindex).Interval = nudInterval.Value
    End Sub

    Private Sub NudRange_Scroll(sender As Object, e As EventArgs) Handles nudRange.ValueChanged
        Skill(Editorindex).Range = nudRange.Value
    End Sub

    Private Sub ChkAOE_CheckedChanged(sender As Object, e As EventArgs) Handles chkAoE.CheckedChanged
        If chkAoE.Checked = False Then
            Skill(Editorindex).IsAoE = False
        Else
            Skill(Editorindex).IsAoE = True
        End If
    End Sub

    Private Sub NudAoE_Scroll(sender As Object, e As EventArgs) Handles nudAoE.ValueChanged
        Skill(Editorindex).AoE = nudAoE.Value
    End Sub

    Private Sub CmbAnimCast_Scroll(sender As Object, e As EventArgs) Handles cmbAnimCast.SelectedIndexChanged
        Skill(Editorindex).CastAnim = cmbAnimCast.SelectedIndex
    End Sub

    Private Sub CmbAnim_Scroll(sender As Object, e As EventArgs) Handles cmbAnim.SelectedIndexChanged
        Skill(Editorindex).SkillAnim = cmbAnim.SelectedIndex
    End Sub

    Private Sub NudStun_Scroll(sender As Object, e As EventArgs) Handles nudStun.ValueChanged
        Skill(Editorindex).StunDuration = nudStun.Value
    End Sub

    Private Sub LstIndex_Click(sender As Object, e As EventArgs) Handles lstIndex.Click
        SkillEditorInit()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SkillEditorOk()
        Dispose()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim tmpindex As Integer

        ClearSkill(Editorindex)

        tmpindex = lstIndex.SelectedIndex
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Skill(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex

        SkillEditorInit()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        SkillEditorCancel()
        Dispose()
    End Sub

    Private Sub FrmEditor_Skill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudIcon.Maximum = NumSkillIcons
        nudCast.Value = 1
        nudAoE.Maximum = Byte.MaxValue
        nudRange.Maximum = Byte.MaxValue
        nudMap.Maximum = MAX_MAPS
        lstIndex.Items.Clear()

        ' Add the names
        For i = 0 To MAX_SKILLS
            lstIndex.Items.Add(i & ": " & Trim$(Skill(i).Name))
        Next

        cmbAnimCast.Items.Clear()
        cmbAnim.Items.Clear()
        For i = 0 To MAX_ANIMATIONS
            cmbAnimCast.Items.Add(i & ": " & Animation(i).Name.Trim)
            cmbAnim.Items.Add(i & ": " & Animation(i).Name.Trim)
        Next

        cmbProjectile.Items.Clear()
        For i = 0 To MAX_ANIMATIONS
            cmbProjectile.Items.Add(i & ": " & Projectile(i).Name.Trim)
        Next

        cmbJob.Items.Clear()
        For i = 0 To MAX_JOBS
            cmbJob.Items.Add(i & ": " & Job(i).Name.Trim)
        Next

        EditorSkill_Icon = New RenderWindow(picSprite.Handle)
    End Sub

    Private Sub ChkProjectile_CheckedChanged(sender As Object, e As EventArgs) Handles chkProjectile.CheckedChanged
        If chkProjectile.Checked = False Then
            Skill(Editorindex).IsProjectile = 0
        Else
            Skill(Editorindex).IsProjectile = 1
        End If
    End Sub

    Private Sub ScrlProjectile_Scroll(sender As System.Object, e As System.EventArgs) Handles cmbProjectile.SelectedIndexChanged
        Skill(Editorindex).Projectile = cmbProjectile.SelectedIndex
    End Sub

    Private Sub ChkKnockBack_CheckedChanged(sender As Object, e As EventArgs) Handles chkKnockBack.CheckedChanged
        If chkKnockBack.Checked = True Then
            Skill(Editorindex).KnockBack = 1
        Else
            Skill(Editorindex).KnockBack = 0
        End If
    End Sub

    Private Sub CmbKnockBackTiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKnockBackTiles.SelectedIndexChanged
        Skill(Editorindex).KnockBackTiles = cmbKnockBackTiles.SelectedIndex
    End Sub

    Private Sub frmEditor_Skill_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SkillEditorCancel
    End Sub
End Class