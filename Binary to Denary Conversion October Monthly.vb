Module Module1

    Sub Main()
        Dim validBinaryString As Boolean = True
        Dim binaryString As String = ""
        Dim loop1 As Integer = 0
        Dim stringlength As Integer = 0
        Dim stringchar As Char = ""
        'Declaration for binary calculation
        Dim binarychartodenary As Integer = 0
        Dim denarysum As Integer = 0
        Dim binaryvalue As Integer = 0
        Dim binaryloop As Integer = 0


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

        For binaryloop = 1 To stringlength
            stringchar = Mid(binaryString, binaryloop, 1)
            binaryvalue = Val(stringchar)
            binarychartodenary = (2 ^ (stringlength - binaryloop)) * binaryvalue
            denarysum = denarysum + binarychartodenary
        Next

        Console.WriteLine(binaryString & " = " & denarysum)
        Console.ReadKey()
    End Sub

End Module
