Module Module1

    Sub Main()
        Console.Write("Enter Amount of Stones:")
        Dim n As Integer = Console.ReadLine()
        Console.WriteLine(n)

        Console.WriteLine("Make a move between 1 to 3:")
        Console.Write("Choose your move:")
        Dim m As Integer = Console.ReadLine()
        Dim answer As Integer = n Mod m

        Console.WriteLine("answer: ")
        Console.WriteLine(answer)


        If answer = 0 Then
            Console.WriteLine("You win")
        ElseIf answer > 0 AndAlso answer <= 3 Then
            Console.WriteLine("You lose")

        End If


        Console.ReadKey()

    End Sub

End Module
