Module Module1

    Sub Main()
        Dim myStr As String = ""
        Dim IsPangram As Boolean = False
        Dim character As Char = ""
        Dim ascii As Integer = 0
        Dim Length As Integer = 0
        Dim str As String = ""

        Console.Write("Enter the string to check whether is a pangram or not: ")
        myStr = Console.ReadLine

        str = UCase(myStr)
        For ascii = 65 To 90
            For Length = 1 To Len(str)
                character = Mid(str, Length, 1)
                If Asc(character) = ascii Then
                    IsPangram = True
                    ExitFor()
                Else : IsPangram = False
                End If
            Next
        Next
        If IsPangram = True Then
            Console.WriteLine("It is a pangram ")
            Console.ReadKey()
        Else : Console.WriteLine("It is not a pangram ")
            Console.ReadKey()
        End If
    End Sub

End Module

