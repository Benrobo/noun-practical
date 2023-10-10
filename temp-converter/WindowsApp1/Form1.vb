
' Temperature Converter
Public Class Form1
    'Global variables
    Dim Convertion_Type As String = "CtF"
    Dim celciusValue As String
    Dim fahrenheitValue As String

    'Cconvert Celcius to Farenheit
    Private Function CtF(c As Decimal)
        Return (c * 9 / 5) + 32
    End Function

    'Convert Farenheit to Celcius
    Private Function FtC(f As Decimal)
        Return (f - 32) * (5 / 9)
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
                Dim celsiusValue As Double = Me.CtF(Me.celciusValue)
                fahrenheitInput.Text = celsiusValue.ToString("F1") ' to 2dp

            Else
                fahrenheitInput.Text = ""

            End If
        ElseIf Convertion_Type = "FtC" Then
            If IsNumeric(fahrenheitValue) Then
                Dim fahrenheitValue As Double = Me.FtC(Me.fahrenheitValue)
                celciusInput.Text = fahrenheitValue.ToString("F1") 'to 2dp
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

