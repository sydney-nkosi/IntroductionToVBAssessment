Imports System

Module Program
    Sub Main(args As String())

        Try
            Dim numerator As Integer = 10
            Dim denominator As Integer = 0
            Dim result As Double = numerator / denominator ' Attempt to divide by zero
            Console.WriteLine("Result: " & result) ' This line won't be reached
        Catch ex As DivideByZeroException
            ' Handle the DivideByZeroException
            Console.WriteLine("Error: Division by zero is not allowed.")
        Finally
            ' Code to execute regardless of whether an exception occurred or not
            Console.WriteLine("Execution completed.")
        End Try

    End Sub


End Module
