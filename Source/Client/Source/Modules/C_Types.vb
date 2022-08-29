Imports MirageBasic.Core

Module C_Types2

    ' client-side stuff
    Friend ActionMsg(Byte.MaxValue) As ActionMsgRec

    Friend Blood(Byte.MaxValue) As BloodRec

    Friend Chat As New List(Of ChatRec)

    'Mapreport
    Friend MapNames(MAX_MAPS) As String

    Public Structure ChatRec
        Dim Text As String
        Dim Color As Integer
        Dim Y As Byte
    End Structure

    Public Structure SkillAnim
        Dim Skillnum As Integer
        Dim Timer As Integer
        Dim FramePointer As Integer
    End Structure

    Public Structure ChatBubbleRec
        Dim Msg As String
        Dim Colour As Integer
        Dim Target As Integer
        Dim TargetType As Byte
        Dim Timer As Integer
        Dim Active As Boolean
    End Structure

    Public Structure MapResourceRec
        Dim X As Integer
        Dim Y As Integer
        Dim State As Byte
    End Structure

    Public Structure ActionMsgRec
        Dim Message As String
        Dim Created As Integer
        Dim Type As Integer
        Dim Color As Integer
        Dim Scroll As Integer
        Dim X As Integer
        Dim Y As Integer
        Dim Timer As Integer
    End Structure

    Public Structure BloodRec
        Dim Sprite As Integer
        Dim Timer As Integer
        Dim X As Integer
        Dim Y As Integer
    End Structure

End Module