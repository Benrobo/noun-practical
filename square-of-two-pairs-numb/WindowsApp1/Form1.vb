Public Class Form1
    Dim firstNumberVal As Decimal
    Dim secondNumberVal As Double
    Dim outputVal As String

    Private Sub firstNumber_TextChanged(sender As Object, e As EventArgs) Handles firstNumber.TextChanged
        If IsNumeric(firstNumber.Text) Then
            firstNumberVal = CDbl(firstNumber.Text)
        Else
            firstNumberVal = 0
        End If
    End Sub

    Private Sub lastNumber_TextChanged(sender As Object, e As EventArgs) Handles lastNumber.TextChanged
        If IsNumeric(lastNumber.Text) Then
            secondNumberVal = CDbl(lastNumber.Text)
        Else
            secondNumberVal = 0
        End If
    End Sub

    Private Sub solveBtn_Click(sender As Object, e As EventArgs) Handles solveBtn.Click
        output.Text = ""
        For i = firstNumberVal To secondNumberVal
            ' Concatenate items within the loop
            Dim square = i ^ 2
            output.Text += outputVal & "( " & i & ", " & square & ")," & " "
        Next i
    End Sub

    Private Sub output_TextChanged(sender As Object, e As EventArgs) Handles output.TextChanged

    End Sub
End Class
