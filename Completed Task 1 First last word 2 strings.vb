﻿Module Module1

    Sub Main()
        'To show first name of Str1 and Last name of Str2
        Dim Str1 As String
        Dim Str2 As String
        Dim FirstName As String
        Dim LastName As String
        Dim FullName As String
        Dim X As Integer
        Dim loop1 As Integer
        Dim Chr As Char
        Const Space = " "
        Dim B As Integer = 0

        'Initialisation
        Console.Write("Enter first string ")
        Str1 = Console.ReadLine

        Console.Write("Enter second string ")
        Str2 = Console.ReadLine
        FirstName = ""
        LastName = ""
        FullName = ""
        X = 0
        Chr = ""

        'For First name
        X = InStr(Str1, " ")
        FirstName = Left(Str1, X - 1)

        'For Second String
        For loop1 = 1 To Len(Str2)
            Chr = Mid(Str2, loop1, 1)
            If Chr = Space Then
                B = loop1
            End If
        Next
        LastName = Right(Str2, Len(Str2) - B)
        FullName = FirstName & " " & LastName

        'Doing Output
        Console.WriteLine("The Strings combined are: " & FullName)
        Console.ReadKey()
    End Sub

End Module
