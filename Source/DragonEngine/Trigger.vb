﻿Public Class Trigger
    Public Property Type As TriggerType
    Public Property IfConst As Boolean = True
    Public Property IfKey As Keys
    Public Property IfMessage As String
    Public Property ConsumeMessage As Boolean

    Public Function GetTrigger() As Boolean
        If Type = TriggerType.Constant Then
            Return IfConst
        ElseIf Type = TriggerType.KeyPress Then
            Return Keyboard.ActiveKeys.Contains(IfKey)
        ElseIf Type = TriggerType.Message Then
            Return Messaging.QueryMessage(IfMessage, ConsumeMessage)
        End If
        Return False
    End Function

    Public Enum TriggerType
        Constant = 0
        KeyPress = 1
        Message = 2
    End Enum
End Class
