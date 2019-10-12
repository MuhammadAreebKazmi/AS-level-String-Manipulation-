Module Module1

    Sub Main()
        Dim mystr As String = ""
        Const vowels = "AaEeIiOoUu"
        Dim loop1 As Integer = 0
        Dim vowelcounter As Integer = 0
        Dim chr1 As Char = ""

        Console.Write("Enter the string: ")
        mystr = Console.ReadLine

        For loop1 = 1 To Len(mystr)
            chr1 = Mid(mystr, loop1, 1)
            If InStr(vowels, chr1) > 0 Then
                vowelcounter = vowelcounter + 1
            End If
        Next

        Console.WriteLine("The number of vowels is: " & vowelcounter)
        Console.ReadKey()
    End Sub

End Module
