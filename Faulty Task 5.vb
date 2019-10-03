Module Module1

    Sub Main()
        ' This is task 5 where a string would be inversed
        Dim myStr As String
        Dim myChar As Char
        Dim loopno As Integer
        Dim InvChar As Char
        Dim InvStr As String

        myChar = ""
        loopno = 1
        InvChar = ""
        InvStr = ""

        Console.Write("Enter the string which needs to be inversed")
        myStr = Console.ReadLine
        InvChar = Mid(myStr, Len(myStr), 1)
        InvStr = InvStr & InvChar
        For loopno = 1 To Len(myStr)
            InvChar = Mid(myStr, Len(myStr) - loopno, 1)
            InvStr = InvStr & InvChar
        Next
        Console.WriteLine("The inverse of the string is " & InvStr)
        Console.ReadKey()
    End Sub

End Module
