Module Module1

    Sub Main()
        Dim str As String = ""
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim NewStr As String = ""
        Dim Midword As String = ""

        Console.Write("Enter the string of three words: ")
        str = Console.ReadLine

        X = InStr(str, " ")
        Y = InStr(X + 1, str, " ")

        Midword = Mid(str, X + 1, Y - X - 1)

        Console.WriteLine("The middle word of the string is: " & Midword)
        Console.ReadKey()
    End Sub

End Module
