Module Module1

    Sub Main()
        Dim mystr As String = ""
        Dim format As Boolean = True
        Dim chr1 As Char = ""
        Dim posn As Integer = 0

        Console.Write("Enter the string on format aaaa-999-AAA: ")
        mystr = Console.ReadLine

        If Len(mystr) < 12 Or Len(mystr) > 12 Then
            format = False
        End If

        If format = True Then
            For posn = 1 To 4
                chr1 = Mid(mystr, posn, 1)
                If chr1 < "a" Or chr1 > "z" Then
                    format = False
                End If
            Next
        End If

        If format = True Then
            For posn = 6 To 8
                chr1 = Mid(mystr, posn, 1)
                If chr1 < "0" Or chr1 > "9" Then
                    format = False
                End If
            Next
        End If

        If format = True Then
            For posn = 10 To 12
                chr1 = Mid(mystr, posn, 1)
                If chr1 < "A" Or chr1 > "Z" Then
                    format = False
                End If
            Next
        End If

        If format = True Then
            If Mid(mystr, 5, 1) <> "-" Or Mid(mystr, 9, 1) <> "-" Then
                format = False
            End If
        End If

        If format = True Then
            Console.WriteLine("The string is valid ")
        Else : Console.WriteLine("The string is invalid. ")
        End If
        Console.ReadKey()
    End Sub

End Module
