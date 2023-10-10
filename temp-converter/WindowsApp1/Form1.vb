
Public Class Form1
    Dim Convertion_Type As String = "CtF"
    Dim celciusValue As String
    Dim fahrenheitValue As String

    Private Sub Main()
        Convertion_Type = "CtF"
    End Sub

    Private Function CtF(c As Decimal)
        Return (c * 9 / 5) + 32
    End Function

    Private Function FtC(f As Decimal)
        Return (f - 32) * 5 / 9
    End Function

    Public Sub celciusInput_TextChanged(sender As Object, e As EventArgs) Handles celciusInput.TextChanged
        celciusValue = celciusInput.Text
    End Sub

    Private Sub fahrenheitInput_TextChanged(sender As Object, e As EventArgs) Handles fahrenheitInput.TextChanged
        fahrenheitValue = fahrenheitInput.Text
    End Sub

    Private Sub convertBtn_Click(sender As Object, e As EventArgs) Handles convertBtn.Click
        If Convertion_Type = "CtF" Then
            If IsNumeric(celciusValue) Then
                Dim celsiusValue As Double = Me.CtF(celciusValue)
                fahrenheitInput.Text = celsiusValue.ToString()

            Else
                fahrenheitInput.Text = ""

            End If
        ElseIf Convertion_Type = "FtC" Then
            If IsNumeric(fahrenheitValue) Then
                Dim fahrenheitValue As Double = Me.CtF(fahrenheitValue)
                celciusInput.Text = fahrenheitValue.ToString()
            Else
                celciusInput.Text = ""

            End If
        End If

    End Sub

    Private Sub celRadioInput_CheckedChanged(sender As Object, e As EventArgs) Handles celRadioInput.CheckedChanged
        Convertion_Type = "CtF"
    End Sub

    Private Sub fahRadioInput_CheckedChanged(sender As Object, e As EventArgs) Handles fahRadioInput.CheckedChanged
        Convertion_Type = "FtC"
    End Sub
End Class

