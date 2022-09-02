Public Module Commands
    Public Sub SetPlayerGatherSkillLvl(index As Integer, SkillSlot As Integer, lvl As Integer)
        Player(index).GatherSkills(SkillSlot).SkillLevel = lvl
    End Sub

    Public Sub SetPlayerGatherSkillExp(index As Integer, SkillSlot As Integer, Exp As Integer)
        Player(index).GatherSkills(SkillSlot).SkillCurExp = Exp
    End Sub

    Public Sub SetPlayerGatherSkillMaxExp(index As Integer, SkillSlot As Integer, MaxExp As Integer)
        Player(index).GatherSkills(SkillSlot).SkillNextLvlExp = MaxExp
    End Sub

    Public Function GetResourceSkillName(skillNum As ResourceSkills) As String
        Select Case skillNum
            Case ResourceSkills.Herbing
                GetResourceSkillName = "Herbalism"
            Case ResourceSkills.Woodcutting
                GetResourceSkillName = "Woodcutting"
            Case ResourceSkills.Mining
                GetResourceSkillName = "Mining"
            Case ResourceSkills.Fishing
                GetResourceSkillName = "Fishing"
            Case Else
                Throw New NotImplementedException()
        End Select
    End Function

    Public Function GetSkillNextLevel(index As Integer, SkillSlot As Integer) As Integer
        GetSkillNextLevel = (50 / 3) * ((GetPlayerGatherSkillLvl(index, SkillSlot) + 1) ^ 3 - (6 * (GetPlayerGatherSkillLvl(index, SkillSlot) + 1) ^ 2) + 17 * (GetPlayerGatherSkillLvl(index, SkillSlot) + 1) - 12)
    End Function

    Public Function GetPlayerGatherSkillLvl(Index As Integer, SkillSlot As Integer) As Integer
        GetPlayerGatherSkillLvl = Player(Index).GatherSkills(SkillSlot).SkillLevel
    End Function

    Public Function GetPlayerGatherSkillExp(Index As Integer, SkillSlot As Integer) As Integer
        GetPlayerGatherSkillExp = Player(Index).GatherSkills(SkillSlot).SkillCurExp
    End Function

    Public Function GetPlayerGatherSkillMaxExp(index As Integer, SkillSlot As Integer) As Integer
        GetPlayerGatherSkillMaxExp = Player(index).GatherSkills(SkillSlot).SkillNextLvlExp
    End Function

    Public Function GetPlayerInvItemNum(index As Integer, InvSlot As Integer) As Integer
        GetPlayerInvItemNum = Player(index).Inv(InvSlot).Num
    End Function

    Public Function GetPlayerInvItemValue(index As Integer, InvSlot As Integer) As Integer
        GetPlayerInvItemValue = Player(index).Inv(InvSlot).Value
    End Function

    Public Sub SetPlayerInvItemValue(index As Integer, InvSlot As Integer, ItemValue As Integer)
        Player(index).Inv(InvSlot).Value = ItemValue
    End Sub

    Public Sub SetPlayerInvItemNum(index As Integer, invSlot As Integer, itemNum As Integer)
        Player(index).Inv(invSlot).Num = itemNum
    End Sub
End Module
