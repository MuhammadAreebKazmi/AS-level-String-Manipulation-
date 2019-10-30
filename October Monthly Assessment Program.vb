Module Module1

    Sub Main()
        Dim validBinaryString As Boolean = True
        Dim binaryString As String = ""
        Dim loop1 As Integer = 0
        Dim stringlength As Integer = 0
        Dim stringchar As Char = ""

        Console.Write("Enter Binary Number: ")
        binaryString = Console.ReadLine

        'For length validation check
        stringlength = Len(binaryString)
        If stringlength < 1 Or stringlength > 8 Then
            validBinaryString = False
        End If

        'Validation check for whether string contains only 0's and 1's
        For loop1 = 1 To Len(binaryString)
            stringchar = Mid(binaryString, loop1, 1)
            If stringchar <> "0" And stringchar <> "1" Then
                validBinaryString = False
            End If
        Next

        If validBinaryString = False Then
            Console.WriteLine("Not a valid binary number... ")
            Console.ReadKey()
        End If
    End Sub

End Module
