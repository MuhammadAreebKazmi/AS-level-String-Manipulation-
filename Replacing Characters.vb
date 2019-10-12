Module Module1

    Sub Main()
        Dim mystr As String = ""
        Dim Newstr As String = ""
        Dim chr1 As Char = ""
        Dim unwantedchar As Char = ""
        Dim replacingchar As Char = ""
        Dim loop1 As Integer = 0

        Console.Write("Enter the string: ")
        mystr = Console.ReadLine
        Console.Write("Enter the character you want to replace: ")
        unwantedchar = Console.ReadLine
        Console.Write("Enter the character you want to replace the older character with: ")
        replacingchar = Console.ReadLine

        For loop1 = 1 To Len(mystr)
            chr1 = Mid(mystr, loop1, 1)
            If chr1 = unwantedchar Then
                Newstr = Newstr & replacingchar
            Else : Newstr = Newstr & chr1
            End If
        Next

        Console.WriteLine("Enter the string with the characters replaced" & Newstr)
        Console.ReadKey()
    End Sub

End Module
