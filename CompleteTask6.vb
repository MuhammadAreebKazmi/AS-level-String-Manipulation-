Module Module1

    Sub Main()
        'Task 6 to determine whether a string is an anagarm or not
        Dim Str1 As String
        Dim Str2 As String
        Dim Chr1 As Char
        Dim Chr2 As String
        Dim AscSum1 As Integer
        Dim AscSum2 As Integer
        Dim loop2 As Integer
        Dim loop1 As Integer
        Dim AscValue As Integer
        Dim Ascval As Integer


        ' =Initialisation
        Str1 = ""
        Str2 = ""
        Chr1 = ""
        Chr2 = ""
        AscSum1 = 0
        AscSum2 = 0
        AscValue = 0
        Ascval = 0

        Console.Write("Enter first String to check anagram: ")
        Str1 = Console.ReadLine

        Console.Write("Enter the second string to check anagram: ")
        Str2 = Console.ReadLine

        For loop1 = 1 To Len(Str1)
            Chr1 = Mid(Str1, loop1, 1)
            AscValue = Asc(Chr1)
            AscSum1 = AscSum1 + AscValue
        Next
        For loop2 = 1 To Len(Str2)
            Chr2 = Mid(Str2, loop2, 1)
            Ascval = Asc(Chr2)
            AscSum2 = AscSum2 + Ascval
        Next
        If AscSum1 = AscSum2 Then
            Console.WriteLine("This is an Anagram")
        Else : Console.WriteLine("This is not an Anagram")
        End If
        Console.ReadKey()
    End Sub

End Module
