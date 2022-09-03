Imports MirageBasic.Core

Friend Class frmEditor_Projectile

    Private Sub FrmEditor_Projectile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstIndex.Items.Clear()

        ' Add the names
        For i = 0 To MAX_PROJECTILES
            lstIndex.Items.Add(i & ": " & Trim$(Projectiles(i).Name))
        Next
        nudPic.Maximum = NumProjectiles
    End Sub

    Private Sub LstIndex_Click(sender As Object, e As EventArgs) Handles lstIndex.Click
        ProjectileEditorInit()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ProjectileEditorOk()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ProjectileEditorCancel()
    End Sub

    Private Sub TxtName_TextChanged(sender As System.Object, e As EventArgs) Handles txtName.TextChanged
        Dim tmpindex As Integer

        tmpindex = lstIndex.SelectedIndex
        Projectiles(Editorindex).Name = Trim$(txtName.Text)
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Projectiles(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex
    End Sub

    Private Sub NudPic_ValueChanged(sender As Object, e As EventArgs) Handles nudPic.Click
        Projectiles(Editorindex).Sprite = nudPic.Value
    End Sub

    Private Sub NudRange_ValueChanged(sender As Object, e As EventArgs) Handles nudRange.Click
        Projectiles(Editorindex).Range = nudRange.Value
    End Sub

    Private Sub NudSpeed_ValueChanged(sender As Object, e As EventArgs) Handles nudSpeed.Click
        Projectiles(Editorindex).Speed = nudSpeed.Value
    End Sub

    Private Sub NudDamage_ValueChanged(sender As Object, e As EventArgs) Handles nudDamage.Click
        Projectiles(Editorindex).Damage = nudDamage.Value
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim tmpindex As Integer

        ClearProjectile(Editorindex)

        tmpindex = lstIndex.SelectedIndex
        lstIndex.Items.RemoveAt(EditorIndex)
        lstIndex.Items.Insert(EditorIndex, Editorindex & ": " & Projectiles(Editorindex).Name)
        lstIndex.SelectedIndex = tmpindex

        ProjectileEditorInit()
    End Sub
End Class