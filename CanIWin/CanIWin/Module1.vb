Module Module1

    Sub Main()
        Console.WriteLine("    ******************************    ")
        Console.WriteLine("    Finding the Max, Min and Average  ")
        Console.WriteLine("    ******************************    ")
        Console.WriteLine()
        Console.Write("How many numbers would you like to enter? ")
        Dim n As Integer = Console.ReadLine()
        Dim x As Integer = 1
        Dim minNum As Double = 2000000
        Dim maxNum As Double = 0
        Dim total As Double = 0.00
        Console.WriteLine("     ")
        While x <= n
            Console.Write("Choice number " + x.ToString() + ": ")
            Dim xNum As Double = Console.ReadLine()


            If xNum > maxNum Then
                maxNum = xNum
            End If
            If xNum < minNum Then
                minNum = xNum
            End If
            total += xNum
            x += 1

        End While
        Console.WriteLine()
        Console.WriteLine("Max Number is: " + maxNum.ToString())
        Console.WriteLine("Min Number is: " + minNum.ToString())
        Console.WriteLine("Avg Number is: " + (total / n).ToString())
        Console.WriteLine()
        Console.WriteLine("    ******************************    ")
        Console.WriteLine("Want to play again? Y/N")
        Dim answer As String = Console.ReadLine()

        If answer.ToUpper() = "Y" Then
            Main()
        Else

            Environment.Exit(0)
        End If
        Console.ReadKey()

    End Sub

End Module
