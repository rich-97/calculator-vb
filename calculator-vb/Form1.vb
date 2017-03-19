Public Class Form1

    Private ans(10) As String
    Private operators As String() = {"-", "+", "*", "/", "(", ")", "%"}
    Private functions As String() = {"sin ", "cos ", "tan ", "ln ", "log "}

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        lblInput.Text &= btn0.Text
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lblInput.Text &= btn1.Text
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        lblInput.Text &= btn2.Text
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lblInput.Text &= btn3.Text
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lblInput.Text &= btn4.Text
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        lblInput.Text &= btn5.Text
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        lblInput.Text &= btn6.Text
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        lblInput.Text &= btn7.Text
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        lblInput.Text &= btn8.Text
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        lblInput.Text &= btn9.Text
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        lblInput.Text &= btnMultiply.Text
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        lblInput.Text &= btnDiv.Text
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        lblInput.Text &= btnMinus.Text
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        lblInput.Text &= btnPlus.Text
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        lblInput.Text &= btnDot.Text
    End Sub

    Private Sub btnGroup1_Click(sender As Object, e As EventArgs) Handles btnGroup1.Click
        lblInput.Text &= btnGroup1.Text
    End Sub

    Private Sub btnGroup2_Click(sender As Object, e As EventArgs) Handles btnGroup2.Click
        lblInput.Text &= btnGroup2.Text
    End Sub

    Private Sub btnAns_Click(sender As Object, e As EventArgs) Handles btnAns.Click
        lblInput.Text &= ans.GetValue(ans.Length - 1)
    End Sub

    Private Sub btnPow2_Click(sender As Object, e As EventArgs) Handles btnPow2.Click
        lblInput.Text &= "^2"
    End Sub

    Private Sub btnPow3_Click(sender As Object, e As EventArgs) Handles btnPow3.Click
        lblInput.Text &= "^3"
    End Sub

    Private Sub btnPowM_Click(sender As Object, e As EventArgs) Handles btnPowM.Click
        lblInput.Text &= "^"
    End Sub

    Private Sub btnPercentage_Click(sender As Object, e As EventArgs) Handles btnPercentage.Click
        lblInput.Text &= btnPercentage.Text
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        lblInput.Text &= btnSqrt.Text
    End Sub

    Private Sub btnCbrt_Click(sender As Object, e As EventArgs) Handles btnCbrt.Click
        lblInput.Text &= btnCbrt.Text
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs)
        lblInput.Text &= "E"
    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        lblInput.Text &= "!"
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        lblInput.Text &= btnPi.Text
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        lblInput.Text &= btnE.Text
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        lblInput.Text &= btnTan.Text & " "
    End Sub

    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        lblInput.Text &= btnSin.Text & " "
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        lblInput.Text &= btnCos.Text & " "
    End Sub

    Private Sub btnLn_Click(sender As Object, e As EventArgs) Handles btnLn.Click
        lblInput.Text &= btnLn.Text & " "
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        lblInput.Text &= btnLog.Text & " "
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        lblInput.Text = ""
        lblOutput.Text = "0."
    End Sub

    Private Sub btnDEL_Click(sender As Object, e As EventArgs) Handles btnDEL.Click
        Dim length As Integer = lblInput.Text.Length

        If length > 0 Then
            lblInput.Text = lblInput.Text.Remove(length - 1)
        End If
    End Sub

    Private Sub btnExp_Click_1(sender As Object, e As EventArgs) Handles btnExp.Click
        lblInput.Text &= "E"
    End Sub

    Private Function replace_comma(ByVal str As String)
        Return Replace(str, ",", ".")
    End Function

    Private Function search_function(ByVal expression As String, ByVal fn As String)
        If expression.Contains(fn) Then
            Dim count As Integer = expression.Count(Function(c As Char) c = fn)

            For i As Integer = 0 To count
                Dim length As Integer = fn.Length()
                Dim index As Integer = expression.IndexOf(fn) + length
                Dim number As String = ""

                For j As Integer = index To expression.Length() - 1
                    If operators.Contains(expression.ElementAt(j)) Then
                        Exit For
                    End If

                    number &= expression.ElementAt(j)
                Next

                Dim value As String = ""

                If fn = "cos " Then
                    value = Math.Cos(Val(number)).ToString()
                ElseIf fn = "sin " Then
                    value = Math.Sin(Val(number)).ToString()
                ElseIf fn = "tan " Then
                    value = Math.Tan(Val(number)).ToString()
                ElseIf fn = "ln " Then
                    value = Math.Log(Val(number)).ToString()
                ElseIf fn = "log " Then
                    value = Math.Log10(Val(number)).ToString()
                End If

                value = replace_comma(value)
                expression = Replace(expression, fn & number, value)
            Next
        End If

        Return expression
    End Function

    Private Function factorial(ByVal int As Integer)
        If int = 0 Then
            Return 1
        End If

        Return int * factorial(int - 1)
    End Function

    Private Sub btnEq_Click(sender As Object, e As EventArgs) Handles btnEq.Click
        Dim obj As Object = CreateObject("MSScriptControl.ScriptControl")
        Dim expression As String = lblInput.Text
        Dim euler As String = replace_comma(Math.E.ToString())
        Dim pi As String = replace_comma(Math.PI.ToString())

        obj.Language = "VBScript"

        If expression <> "" Then
            expression = Replace(expression, "x", "*")
            expression = Replace(expression, "÷", "/")
            expression = Replace(expression, "e", euler)
            expression = Replace(expression, "π", pi)

            For Each i As String In functions
                expression = search_function(expression, i)
            Next

            If expression.Contains("%") Then
                Dim count As Integer = expression.Count(Function(c As Char) c = "%")

                For i As Integer = 0 To count
                    Dim index As Integer = expression.IndexOf("%") - 1
                    Dim number As String = ""

                    For j As Integer = index To 0 Step -1
                        If operators.Contains(expression.ElementAt(j)) Then
                            Exit For
                        End If

                        number &= expression.ElementAt(j)
                    Next

                    Dim percent As Double = Val(number.Reverse()) / 100
                    Dim percent_str = replace_comma(percent.ToString())
                    expression = Replace(expression, number + "%", percent_str)
                Next
            End If

            If expression.Contains("!") Then
                Dim count As Integer = expression.Count(Function(c As Char) c = "!")

                For i As Integer = 0 To count
                    Dim index As Integer = expression.IndexOf("!") - 1
                    Dim number As String = ""

                    For j As Integer = index To 0 Step -1
                        If operators.Contains(expression.ElementAt(j)) Then
                            Exit For
                        End If

                        number &= expression.ElementAt(j)
                    Next

                    Dim fact As Double = factorial(Val(StrReverse(number)))
                    Dim fact_str As String = fact.ToString()
                    expression = Replace(expression, number & "!", fact_str)
                Next
            End If

            If expression.Contains("^") Then
                Dim count As Integer = expression.Count(Function(c As Char) c = "^")

                For i As Integer = 0 To count
                    Dim index As Integer = expression.IndexOf("^")
                    Dim exp As Integer = Val(expression.ElementAt(index + 1))
                    Dim number As String = ""

                    For j As Integer = (index - 1) To 0 Step -1
                        If operators.Contains(expression.ElementAt(j)) Then
                            Exit For
                        End If

                        number &= expression.ElementAt(j)
                    Next

                    Dim value As Double = Math.Pow(Val(number), exp)
                    Dim value_str As String = value.ToString()
                    expression = Replace(expression, number & "^" & exp.ToString(), value_str)
                Next
            End If

            If expression.Contains("√") Then
                Dim count = expression.Count(Function(c As Char) c = "√")

                For i As Integer = 0 To count
                    Dim index As Integer = expression.IndexOf("√")
                    Dim exp As Integer = 2
                    Dim number As String = ""

                    If index > 0 Then
                        If Not operators.Contains(expression.ElementAt(index - 1)) Then
                            exp = Val(expression.ElementAt(index - 1))
                        End If
                    End If

                    For j As Integer = (index + 1) To expression.Length() - 1
                        If operators.Contains(expression.ElementAt(j)) Then
                            Exit For
                        End If

                        number &= expression.ElementAt(j)
                    Next

                    Dim value As Double
                    Dim value_str As String

                    If exp = 2 Then
                        value = Math.Sqrt(Val(number))
                        value_str = replace_comma(value.ToString())
                        expression = Replace(expression, "√" & number, value_str)
                    Else
                        value = Math.Pow(Val(number), 1 / exp)
                        value_str = replace_comma(value.ToString())
                        expression = Replace(expression, exp & "√" & number, value_str)
                    End If
                Next
            End If

            If expression.Contains("E") Then
                Dim count As Integer = expression.Count(Function(c As Char) c = "E")

                For i As Integer = 0 To count - 1
                    Dim index As Integer = expression.IndexOf("E") + 1
                    Dim number As String = ""
                    Dim ops As List(Of String) = operators.ToList()

                    ops.Remove("-")

                    For j As Integer = index To expression.Length() - 1
                        If ops.Contains(expression.ElementAt(j)) Then
                            Exit For
                        End If
                        number &= expression.ElementAt(j)
                    Next

                    Dim value As Double

                    If Val(number) < 0 Then
                        value = 1 / Math.Pow(10, Val(Replace(number, "-", "")))
                    Else
                        value = Math.Pow(10, Val(number))
                    End If

                    Dim value_str As String = replace_comma(value.ToString())
                    expression = Replace(expression, "E" & number, "*" & value_str)
                Next
            End If

            Dim result As String = obj.Eval(expression)

            lblOutput.Text = obj.Eval(expression) & "."

            ans.SetValue(result, ans.Length - 1)
        End If
    End Sub
End Class