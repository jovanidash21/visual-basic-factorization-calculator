Module Module1

    Sub Main()
        Console.Write("Please Enter an Integer: ")
        Dim input As String = Console.ReadLine()
        Dim number As Integer
        If Integer.TryParse(input, number) Then
            Console.WriteLine("The Factors are: ")
            For x = 1 To number
                If number Mod x = 0 Then
                    Console.WriteLine(x)
                End If
            Next
            Console.WriteLine()
            Main()
        Else
            Console.WriteLine("Invalid Input")
            Console.WriteLine()
            Main()
        End If
        Console.ReadLine()
    End Sub

End Module
