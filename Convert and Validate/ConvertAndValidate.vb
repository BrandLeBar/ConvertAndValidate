'Brandon Barrera
'Spring 2025
'RCET2265
'Convert and Validate
'https://github.com/BrandLeBar/ConvertAndValidate.git

Option Compare Text
Option Strict On
Option Explicit On

Module ConvertAndValidate

    Sub Main()

        Dim aValidNumber As Integer
        Dim userResponse As String

        Do

            Console.WriteLine($"Enter a number:")

            userResponse = Console.ReadLine()


            If ConversionValid(userResponse, aValidNumber) = True Then

                Console.WriteLine($"{userResponse} converted successfully to {aValidNumber}!")

            Else

                Console.WriteLine($"Oops, {userResponse} does not seem to be a number")

            End If

        Loop

    End Sub

    'this works now

    Function ConversionValid(ByRef convertThisString As String, ByRef toThisInteger As Integer) As Boolean

        Dim status As Boolean

        Try
            toThisInteger = CInt(convertThisString)
            status = True
        Catch ex As Exception
            status = False
        End Try

        Return status

    End Function

End Module
