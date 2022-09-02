Public Module Commands
    Public Function GetPlayerLogin(index As Integer) As String
        GetPlayerLogin = Trim$(Player(index).Login)
    End Function

    Public Function GetPlayerName(index As Integer) As String
        GetPlayerName = Player(index).Name.Trim()
    End Function

    Public Sub SetPlayerAccess(index As Integer, Access As Integer)
        Player(index).Access = Access
    End Sub

    Public Sub SetPlayerSprite(index As Integer, Sprite As Integer)
        Player(index).Sprite = Sprite
    End Sub

    Public Function GetPlayerMaxVital(index As Integer, Vital As VitalType) As Integer
        Select Case Vital
            Case VitalType.HP
                GetPlayerMaxVital = (Player(index).Level + (GetPlayerStat(index, StatType.Vitality) \ 2) + Job(Player(index).Job).Stat(StatType.Vitality)) * 2
            Case VitalType.MP
                GetPlayerMaxVital = (Player(index).Level + (GetPlayerStat(index, StatType.Intelligence) \ 2) + Job(Player(index).Job).Stat(StatType.Intelligence)) * 2
            Case VitalType.SP
                GetPlayerMaxVital = (Player(index).Level + (GetPlayerStat(index, StatType.Spirit) \ 2) + Job(Player(index).Job).Stat(StatType.Spirit)) * 2
        End Select

    End Function

    Public Function GetPlayerStat(index As Integer, Stat As StatType) As Integer
        Dim x As Integer, i As Integer

        x = Player(index).Stat(Stat)

        For i = 0 To EquipmentType.Count - 1
            If Player(index).Equipment(i) > 0 Then
                If Item(Player(index).Equipment(i)).Add_Stat(Stat) > 0 Then
                    x += Item(Player(index).Equipment(i)).Add_Stat(Stat)
                End If
            End If
        Next

        GetPlayerStat = x
    End Function

    Public Function GetPlayerAccess(index As Integer) As Integer
        GetPlayerAccess = Player(index).Access
    End Function

    Public Function GetPlayerMap(index As Integer) As Integer
        GetPlayerMap = Player(index).Map
    End Function

    Public Function GetPlayerX(index As Integer) As Integer
        GetPlayerX = Player(index).X
    End Function

    Public Function GetPlayerY(index As Integer) As Integer
        GetPlayerY = Player(index).Y
    End Function

    Public Function GetPlayerDir(index As Integer) As Integer
        GetPlayerDir = Player(index).Dir
    End Function

    Public Function GetPlayerSprite(index As Integer) As Integer
        GetPlayerSprite = Player(index).Sprite
    End Function

    Public Function GetPlayerPK(index As Integer) As Integer
        GetPlayerPK = Player(index).Pk
    End Function

    Public Function GetPlayerEquipment(index As Integer, EquipmentSlot As EquipmentType) As Integer
        GetPlayerEquipment = Player(index).Equipment(EquipmentSlot)
    End Function

    Public Sub SetPlayerEquipment(index As Integer, InvNum As Integer, EquipmentSlot As EquipmentType)
        Player(index).Equipment(EquipmentSlot) = InvNum
    End Sub

    Public Sub SetPlayerDir(index As Integer, Dir As Integer)
        Player(index).Dir = Dir
    End Sub

    Public Sub SetPlayerVital(index As Integer, Vital As VitalType, Value As Integer)
        Player(index).Vital(Vital) = Value

        If GetPlayerVital(index, Vital) > GetPlayerMaxVital(index, Vital) Then
            Player(index).Vital(Vital) = GetPlayerMaxVital(index, Vital)
        End If

        If GetPlayerVital(index, Vital) < 0 Then
            Player(index).Vital(Vital) = 0
        End If
    End Sub

    Public Function IsDirBlocked(ByRef Blockvar As Byte, ByRef Dir As Byte) As Boolean
        Return Not (Not Blockvar AndAlso (2 ^ Dir))
    End Function

    Public Function GetPlayerVital(index As Integer, Vital As VitalType) As Integer
        GetPlayerVital = Player(index).Vital(Vital)
    End Function

    Public Function GetPlayerLevel(index As Integer) As Integer
        GetPlayerLevel = Player(index).Level
    End Function

    Public Function GetPlayerPOINTS(index As Integer) As Integer
        GetPlayerPOINTS = 0
        If index > MAX_PLAYERS Then Exit Function
        GetPlayerPOINTS = Player(index).Points
    End Function

    Public Function GetPlayerNextLevel(index As Integer) As Integer
        GetPlayerNextLevel = (50 / 3) * ((GetPlayerLevel(index) + 1) ^ 3 - (6 * (GetPlayerLevel(index) + 1) ^ 2) + 17 * (GetPlayerLevel(index) + 1) - 12)
    End Function

    Public Function GetPlayerExp(index As Integer) As Integer
        GetPlayerExp = Player(index).Exp
    End Function

    Public Sub SetPlayerMap(index As Integer, mapNum As Integer)
        If mapNum > 0 AndAlso mapNum <= MAX_CACHED_MAPS Then
            Player(index).Map = mapNum
        End If
    End Sub

    Sub SetPlayerX(index As Integer, X As Integer)
        Player(index).X = X
    End Sub

    Public Sub SetPlayerY(index As Integer, Y As Integer)
        Player(index).Y = Y
    End Sub

    Public Sub SetPlayerExp(index As Integer, Exp As Integer)
        Player(index).Exp = Exp
    End Sub

    Public Function GetPlayerRawStat(index As Integer, Stat As StatType) As Integer
        GetPlayerRawStat = Player(index).Stat(Stat)
    End Function

    Public Sub SetPlayerStat(index As Integer, Stat As StatType, Value As Integer)
        Player(index).Stat(Stat) = Value
    End Sub

    Sub SetPlayerLevel(index As Integer, Level As Integer)
        If Level > MAX_LEVEL Then Exit Sub
        Player(index).Level = Level
    End Sub

    Public Sub SetPlayerPOINTS(index As Integer, Points As Integer)
        If Player(index).Points + Points > MAX_POINTS Then
            Player(index).Points = MAX_POINTS
        Else
            Player(index).Points = Points
        End If
    End Sub

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
