Public Class Form1
    Dim InitialAmount As Integer = 10000
    Dim AnnualInterestRate As Integer = 5
    Dim TimeInYears As Integer = 5
    Dim ExpectedAmount As Integer = 0



    Public Function CalculateAnnualInterestRate(P As Integer, R As Integer, T As Integer)
        Dim result As Double
        result = P * (1 + (R / 100) / 1) ^ (1 * T / 10)
        Return result
    End Function

    Private Sub initialInp_TextChanged(sender As Object, e As EventArgs) Handles initialInp.TextChanged
        Dim value = initialInp.Text
        If IsNumeric(value) Then
            InitialAmount = CDbl(value)
        Else
            InitialAmount = 0
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles outputValue.TextChanged

    End Sub

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        Dim result As Double = CalculateAnnualInterestRate(InitialAmount, AnnualInterestRate, TimeInYears)
        ExpectedAmount = result.ToString("F1")
        outputValue.Text = ExpectedAmount
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialize expected input
        initialInp.Text = InitialAmount
    End Sub
End Class
