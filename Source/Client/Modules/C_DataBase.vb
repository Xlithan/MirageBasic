Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports MirageBasic.Core

Module C_Database
    Friend Function GetFileContents(fullPath As String, Optional ByRef errInfo As String = "") As String
        Dim strContents As String
        Dim objReader As StreamReader
        strContents = ""
        Try
            objReader = New StreamReader(fullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
        Catch ex As Exception
            errInfo = ex.Message
        End Try
        Return strContents
    End Function

#Region "Assets Check"

    Friend Sub CheckCharacters()
        Dim i As Integer
        i = 1

        While File.Exists(Paths.Graphics & "characters\" & i & GfxExt)
            NumCharacters = NumCharacters + 1
            i = i + 1
        End While

    End Sub

    Friend Sub CheckPaperdolls()
        Dim i As Integer
        i = 1

        While File.Exists(Paths.Graphics & "paperdolls\" & i & GfxExt)
            NumPaperdolls = NumPaperdolls + 1
            i = i + 1
        End While

    End Sub

    Friend Sub CheckAnimations()
        Dim i As Integer
        i = 1

        While File.Exists(Paths.Graphics & "animations\" & i & GfxExt)
            NumAnimations = NumAnimations + 1
            i = i + 1
        End While

    End Sub

    Friend Sub CheckSkillIcons()
        Dim i As Integer
        i = 1

        While File.Exists(Paths.Graphics & "SkillIcons\" & i & GfxExt)
            NumSkillIcons = NumSkillIcons + 1
            i = i + 1
        End While

    End Sub

    Friend Sub CheckFaces()
        Dim i As Integer
        i = 1

        While File.Exists(Paths.Graphics & "Faces\" & i & GfxExt)
            NumFaces = NumFaces + 1
            i = i + 1
        End While

        If NumFaces = 0 Then Exit Sub
    End Sub

    Friend Sub CheckFog()
        Dim i As Integer
        i = 1

        While File.Exists(Paths.Graphics & "Fogs\" & i & GfxExt)
            NumFogs = NumFogs + 1
            i = i + 1
        End While

        If NumFogs = 0 Then Exit Sub
    End Sub

    Friend Sub CheckEmotes()
        Dim i As Integer
        i = 1

        While File.Exists(Paths.Graphics & "Emotes\" & i & GfxExt)
            NumEmotes = NumEmotes + 1
            i = i + 1
        End While

    End Sub

    Friend Sub CheckPanoramas()
        Dim i As Integer
        i = 1

        While File.Exists(Paths.Graphics & "Panoramas\" & i & GfxExt)
            NumPanorama = NumPanorama + 1
            i = i + 1
        End While
    End Sub

    Friend Sub CheckParallax()
        Dim i As Integer
        i = 1

        While File.Exists(Paths.Graphics & "Parallax\" & i & GfxExt)
            NumParallax = NumParallax + 1
            i = i + 1
        End While

    End Sub

    Friend Sub CacheMusic()
        ReDim MusicCache(Directory.GetFiles(Paths.Music, "*.ogg").Count)
        Dim files As String() = Directory.GetFiles(Paths.Music, "*.ogg")
        Dim maxNum As String = Directory.GetFiles(Paths.Music, "*.ogg").Count
        Dim counter As Integer = 0

        For Each FileName In files
            ReDim Preserve MusicCache(counter)

            MusicCache(counter) = System.IO.Path.GetFileName(FileName)
            counter = counter + 1
            Application.DoEvents()
        Next

    End Sub

    Friend Sub CacheSound()
        ReDim SoundCache(Directory.GetFiles(Paths.Sounds, "*.ogg").Count)
        Dim files As String() = Directory.GetFiles(Paths.Sounds, "*.ogg")
        Dim maxNum As String = Directory.GetFiles(Paths.Sounds, "*.ogg").Count
        Dim counter As Integer = 0

        For Each FileName In files
            ReDim Preserve SoundCache(counter)

            SoundCache(counter) = System.IO.Path.GetFileName(FileName)
            counter = counter + 1
            Application.DoEvents()
        Next

    End Sub

#End Region


#Region "Blood"

    Sub ClearBlood()
       For i = 0 To Byte.MaxValue
            Blood(I).Timer = 0
        Next
    End Sub

#End Region

#Region "Npc's"

    Sub ClearNpcs()
        Dim i As Integer

        ReDim Npc(MAX_NPCS)

       For i = 0 To MAX_NPCS
            ClearNpc(i)
        Next

    End Sub

    Sub ClearNpc(index As Integer)
        Npc(index) = Nothing
        ReDim Npc(index).Stat(StatType.Count - 1)
        ReDim Npc(index).DropChance(5)
        ReDim Npc(index).DropItem(5)    
        ReDim Npc(index).DropItemValue(5)
        ReDim Npc(index).Skill(6)
    End Sub

    Sub StreamNpc(npcNum As Integer)
        If npcNum > 0 and Npc(npcNum).Name = "" And NPC_Loaded(npcNum) = False Then
            NPC_Loaded(npcNum) = True
            SendRequestNpc(npcNum)
        End If
    End Sub

#End Region

#Region "Jobs"
    Sub ClearJobs()
        For i = 0 To MAX_JOBS
            ClearJob(i)
        Next
    End Sub

    Sub ClearJob(index As Integer)
        Job(index) = Nothing
        ReDim Job(index).Stat(StatType.Count - 1)
        Job(index).Name = ""
        Job(index).Desc = ""
        ReDim Job(index).StartItem(5)
        ReDim Job(index).StartValue(5)
        ReDim Job(index).MaleSprite(5)
        ReDim Job(index).FemaleSprite(5)

        For i = 0 To 5
            Job(index).MaleSprite(i) = 1
            Job(index).FemaleSprite(i) = 1
        Next
    End Sub
#End Region

#Region "Skills"

    Sub ClearSkills()
        Dim i As Integer

       For i = 0 To MAX_SKILLS
            ClearSkill(i)
        Next

    End Sub

    Sub ClearSkill(index As Integer)
        Skill(index) = Nothing
        Skill(index).Name = ""
    End Sub

    Sub StreamSkill(skillNum As Integer)
        If skillNum > 0 and Item(skillNum).Name = "" And SKill_Loaded(skillNum) = False Then
            Item_Loaded(skillNum) = True
            SendRequestSkill(skillNum)
        End If
    End Sub

#End Region

End Module