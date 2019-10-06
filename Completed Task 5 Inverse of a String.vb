Module Module1

    Sub Main()
        ' This is task 5 where a string would be inversed
        Dim myStr As String
        Dim myChar As Char
        Dim loopno As Integer
        Dim InvChar As Char
        Dim InvStr As String
        Dim ucasestring As String = ""

        myChar = ""
        loopno = 1
        InvChar = ""
        InvStr = ""

        Console.Write("Enter the string which needs to be inversed: ")
        myStr = Console.ReadLine

        For loopno = Len(myStr) To 1 Step -1
            InvChar = Mid(myStr, loopno, 1)
            InvStr = InvStr & InvChar
        Next

        ucasestring = UCase(InvStr)
        Console.WriteLine("The inverse of the string is " & ucasestring)
        Console.ReadKey()
    End Sub

End Module
