Module Module1

    Sub Main()
        Dim myStr As String
        Dim myChar As Char
        Dim letters As String
        Dim Numbers As String
        Dim Specials As String
        Dim value As Integer
        Dim counter As Integer

        'Initialisation
        Console.Write("Enter the string")
        myStr = Console.ReadLine
        myChar = ""
        letters = ""
        Numbers = ""
        Specials = ""
        value = 0
        counter = 0

        For counter = 1 To Len(myStr)
            myChar = Mid(myStr, counter, 1)
            value = Asc(myChar)
            If value >= 65 And value <= 90 Or value >= 97 And value <= 122 Then
                letters = letters & myChar
            ElseIf value >= 48 And value <= 57 Then
                Numbers = Numbers & myChar
            Else : Specials = Specials & myChar
            End If
        Next
        Console.WriteLine("The letters separated are " & letters)
        Console.WriteLine("The numbers separated are " & Numbers)
        Console.WriteLine("The specials separated are " & Specials)
        Console.ReadKey()
    End Sub

End Module
