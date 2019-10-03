Module Module1

    Sub Main()
        'Task Number 4 for truncating a character from a string
        Dim myStr As String
        Dim NewStr As String
        Dim Char1 As Char
        Dim length As Integer
        Dim DisallowedChar As String
        Dim Charsloop As Integer
        Dim UnwantedChar As Char

        'Initialisation
        Console.Write("Enter the string ")
        myStr = Console.ReadLine
        Char1 = ""
        length = 0
        Console.Write("Enter the character to be truncated ")
        DisallowedChar = Console.ReadLine
        Charsloop = 0
        NewStr = ""
        UnwantedChar = ""

        'Going for the loop to truncate character
        For length = 1 To Len(myStr)
            Char1 = Mid(myStr, length, 1)
            For Charsloop = 1 To Len(myStr)
                UnwantedChar = Mid(DisallowedChar, Charsloop, 1)
            Next
            If Char1 <> UnwantedChar Then
                NewStr = NewStr & Char1
            End If
        Next
        Console.WriteLine("New string with character truncated is " & NewStr)
        Console.ReadKey()
    End Sub

End Module
