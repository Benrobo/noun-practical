Public Class Form1
    Dim initialFee As Double = 25000
    Dim feeVal As Double = 4
    Dim currentFee As Double


    ' assign value to text box on initial render
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fee.Text = feeVal
        charge.Text = initialFee

    End Sub

    Private Sub charge_TextChanged(sender As Object, e As EventArgs) Handles charge.TextChanged
        If IsNumeric(charge.Text) Then
            initialFee = CDbl(charge.Text)
        Else
            initialFee = 0
        End If
    End Sub

    Private Sub fee_TextChanged(sender As Object, e As EventArgs) Handles fee.TextChanged
        If IsNumeric(fee.Text) Then
            feeVal = CDbl(fee.Text)
        Else
            feeVal = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        output.Text = ""
        For i = 1 To 6
            ' Concatenate items within the loop
            initialFee += (feeVal * initialFee) / 100
            Dim finalVal = "Year " & i & " " & "N" & initialFee.ToString("F1") & vbCrLf & vbCrLf
            output.Text += finalVal
        Next i
    End Sub

End Class
