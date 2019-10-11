Module Module1

    Sub Main()
        Dim str As String = ""
        Dim loop1 As Integer = 0
        Dim Spaceposn As Integer = 0
        Dim AfterSpace As Integer = 0
        Dim Character As Char = ""
        Dim word As String = ""
        Const Space = " "
        Dim Newstr As String = ""

        Console.Write("Enter the string and enter a space at the end: ")
        str = Console.ReadLine

        For loop1 = 1 To Len(str)
            Character = Mid(str, loop1, 1)
            Newstr = Newstr & Character
            If Character = Space Then
                Console.WriteLine(Newstr)
                Newstr = ""
            End If
        Next
        Console.ReadKey()
    End Sub

End Module
