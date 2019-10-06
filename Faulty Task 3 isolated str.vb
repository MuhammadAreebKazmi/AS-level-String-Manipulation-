Module Module1

    Sub Main()
        Dim str As String = ""
        Dim loop1 As Integer = 0
        Dim Spaceposn As Integer = 0
        Dim AfterSpace As Integer = 0
        Dim Character As Char = ""
        Dim word As String = ""
        Const Space = " "

        Console.Write("Enter the string: ")
        str = Console.ReadLine

        Spaceposn = InStr(str, " ")
        word = Left(str, Spaceposn - 1)
        Console.WriteLine(word)

        For loop1 = Spaceposn To Len(str)
            Character = Mid(str, loop1, 1)
            If Character = Space Then
                AfterSpace = InStr(Spaceposn + 1, str, " ")
                word = Mid(str, loop1 + 1, AfterSpace - loop1 - 1)
                Console.WriteLine(word)
            End If
        Next
    End Sub

End Module
