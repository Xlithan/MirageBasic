Imports Asfw
Imports MirageBasic.Core

Module C_Job

#Region "Incoming Traffic"

    Sub Packet_NewCharJob(ByRef data() As Byte)
        Dim i As Integer, z As Integer, x As Integer
        Dim buffer As New ByteStream(data)

       For i = 0 To MAX_JOBS
            With Job(i)
                .Name = Trim(buffer.ReadString)
                .Desc = Trim(buffer.ReadString)

                ReDim .Vital(VitalType.Count - 1)

                .Vital(VitalType.HP) = buffer.ReadInt32
                .Vital(VitalType.MP) = buffer.ReadInt32
                .Vital(VitalType.SP) = buffer.ReadInt32

                ' get array size
                z = buffer.ReadInt32
                ' redim array
                ReDim .MaleSprite(z)
                ' loop-receive data
                For x = 0 To z
                    .MaleSprite(x) = buffer.ReadInt32
                Next

                ' get array size
                z = buffer.ReadInt32
                ' redim array
                ReDim .FemaleSprite(z)
                ' loop-receive data
                For x = 0 To z
                    .FemaleSprite(x) = buffer.ReadInt32
                Next

                ReDim .Stat(StatType.Count - 1)

                .Stat(StatType.Strength) = buffer.ReadInt32
                .Stat(StatType.Endurance) = buffer.ReadInt32
                .Stat(StatType.Vitality) = buffer.ReadInt32
                .Stat(StatType.Intelligence) = buffer.ReadInt32
                .Stat(StatType.Luck) = buffer.ReadInt32
                .Stat(StatType.Spirit) = buffer.ReadInt32

                ReDim .StartItem(5)
                ReDim .StartValue(5)
                For q = 0 To 5
                    .StartItem(q) = buffer.ReadInt32
                    .StartValue(q) = buffer.ReadInt32
                Next

                .StartMap = buffer.ReadInt32
                .StartX = buffer.ReadInt32
                .StartY = buffer.ReadInt32

                .BaseExp = buffer.ReadInt32
            End With

        Next

        buffer.Dispose()

        ' Used for if the player is creating a new character
        Frmmenuvisible = True
        Pnlloadvisible = False
        PnlCreditsVisible = False
        PnlRegisterVisible = False
        PnlCharCreateVisible = True
        PnlLoginVisible = False

        ReDim CmbJob(MAX_JOBS)

       For i = 0 To MAX_JOBS
            CmbJob(i) = Job(i).Name
        Next

        FrmMenu.DrawCharacter()

        NewCharSprite = 0
    End Sub

    Sub Packet_JobData(ByRef data() As Byte)
        Dim i As Integer, z As Integer, x As Integer
        Dim buffer As New ByteStream(data)

        NewCharSprite = 0

        For i = 0 To MAX_JOBS
            With Job(i)
                .Name = Trim(buffer.ReadString)
                .Desc = Trim(buffer.ReadString)

                ReDim .Vital(VitalType.Count - 1)

                .Vital(VitalType.HP) = buffer.ReadInt32
                .Vital(VitalType.MP) = buffer.ReadInt32
                .Vital(VitalType.SP) = buffer.ReadInt32

                ' get array size
                z = buffer.ReadInt32
                ' redim array
                ReDim .MaleSprite(z)
                ' loop-receive data
                For x = 0 To z
                    .MaleSprite(x) = buffer.ReadInt32
                Next

                ' get array size
                z = buffer.ReadInt32
                ' redim array
                ReDim .FemaleSprite(z)
                ' loop-receive data
                For x = 0 To z
                    .FemaleSprite(x) = buffer.ReadInt32
                Next

                ReDim .Stat(StatType.Count - 1)

                .Stat(StatType.Strength) = buffer.ReadInt32
                .Stat(StatType.Endurance) = buffer.ReadInt32
                .Stat(StatType.Vitality) = buffer.ReadInt32
                .Stat(StatType.Intelligence) = buffer.ReadInt32
                .Stat(StatType.Luck) = buffer.ReadInt32
                .Stat(StatType.Spirit) = buffer.ReadInt32

                ReDim .StartItem(5)
                ReDim .StartValue(5)
                For q = 0 To 5
                    .StartItem(q) = buffer.ReadInt32
                    .StartValue(q) = buffer.ReadInt32
                Next

                .StartMap = buffer.ReadInt32
                .StartX = buffer.ReadInt32
                .StartY = buffer.ReadInt32

                .BaseExp = buffer.ReadInt32
            End With

        Next

       ReDim CmbJob(MAX_JOBS)
       For i = 0 To MAX_JOBS
            CmbJob(i) = Job(i).Name
        Next
        FrmMenu.DrawCharacter()

        buffer.Dispose()
    End Sub

#End Region

#Region "Outgoing Traffic"

    Friend Sub SendRequestJobs()
        Dim buffer As New ByteStream(4)

        buffer.WriteInt32(ClientPackets.CRequestClass)

        Socket.SendData(buffer.Data, buffer.Head)
        buffer.Dispose()
    End Sub

#End Region

End Module