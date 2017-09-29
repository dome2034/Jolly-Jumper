Module Module1

    Sub Main()
        Dim TestStr As String
        '========================= Test 1 ================================
        TestStr = "1"
        If IsJolly(TestStr) Then
            Console.WriteLine("Jolly")
        Else
            Console.WriteLine("Not Jolly")
        End If
        '=================================================================
        '========================= Test 2 ================================
        TestStr = "2 5 4 2 7 11"
        If IsJolly(TestStr) Then
            Console.WriteLine("Jolly")
        Else
            Console.WriteLine("Not Jolly")
        End If
        '=================================================================
        '========================= Test 3 ================================
        TestStr = "2 5 4 2 7 10"
        If IsJolly(TestStr) Then
            Console.WriteLine("Jolly")
        Else
            Console.WriteLine("Not Jolly")
        End If
        '=================================================================
        '========================= Test 4 ================================
        TestStr = "1 2"
        If IsJolly(TestStr) Then
            Console.WriteLine("Jolly")
        Else
            Console.WriteLine("Not Jolly")
        End If
        '=================================================================
        '========================= Test 5 ================================
        TestStr = "3 3 3"
        If IsJolly(TestStr) Then
            Console.WriteLine("Jolly")
        Else
            Console.WriteLine("Not Jolly")
        End If
        '=================================================================
        Console.ReadLine()
    End Sub

    Function IsJolly(Source As String) As Boolean
        Dim InputList As String() = Source.Split(" ")
        Dim InputListToInt As Integer() = Array.ConvertAll(InputList, Function(str) Int32.Parse(str))
        Dim n As Integer = InputListToInt.Length()
        Dim Diffs(n - 1) As Integer
        For i = 0 To (n - 1)
            Diffs(i) = 0
        Next
        Dim Diff As Integer = 0
        '============================================================
        If n = 1 Then
            Return True
        Else
            For i = 0 To n - 2
                Diff = Math.Abs(InputListToInt(i) - InputListToInt(i + 1))
                If Diff = 0 Or Diff > (n - 1) Then
                    Return False
                Else
                    For j = 0 To Diffs.Length - 1
                        If Diff = Diffs(j) Then
                            Return False
                        End If
                    Next
                    Diffs(i) = Diff
                End If
            Next
            Return True
        End If
    End Function

End Module
