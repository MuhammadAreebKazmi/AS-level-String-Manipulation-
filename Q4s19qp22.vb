﻿Module Module1

    Sub Main()
        Dim InString As String = "12 34 5  39"
        Dim NewString As String = ""
        Dim NextChar As String = ""
        Dim AfterSpace As Boolean = False
        Dim Index As Integer = 0
        Const Space = " "

        'Loop for the erasing of spaces
        For Index = 1 To Len(InString)
            NextChar = Mid(InString, Index, 1)
            If AfterSpace = True Then
                If NextChar <> Space Then
                    NewString = NewString & NextChar
                    AfterSpace = False
                End If
            Else
                NewString = NewString & NextChar
                If NextChar = Space Then
                    AfterSpace = True
                End If
            End If
        Next
        Console.WriteLine(NewString)
        Console.ReadKey()
    End Sub

End Module
