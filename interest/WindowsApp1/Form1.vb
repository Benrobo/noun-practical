Public Class Form1
    Dim basicSalary As Double
    Dim tfair As Double
    Dim rent As Double
    Dim hazard As Double
    Dim pension As Double
    Dim nhis As Double
    Dim tax As Double
    Dim Total_allowance As Double
    Dim Total_deduction As Double

    Dim allowancesTotal As Double
    Dim deductionTotal As Double
    Dim grossPay As Double
    Dim netPay As Double

    ' Function to calculate a percentage of a value
    Private Function CalculatePercentage(percentage As Double) As Double
        Return (percentage * basicSalary) / 100
    End Function

    Private Sub ValidateAndAssign(inputField As TextBox, ByRef variable As Double)
        If IsNumeric(inputField.Text) Then
            variable = CDbl(inputField.Text)
        Else
            ' Handle non-numeric input (e.g., display an error message or clear the field)
            ' Here, we set the variable to 0 as a default value
            variable = 0
        End If
    End Sub


    Private Sub basicSalaryInp_TextChanged(sender As Object, e As EventArgs) Handles basicSalaryInp.TextChanged
        ValidateAndAssign(basicSalaryInp, basicSalary)
    End Sub

    Private Sub tfairInp_TextChanged(sender As Object, e As EventArgs) Handles tfairInp.TextChanged
        ValidateAndAssign(tfairInp, tfair)
    End Sub

    Private Sub rentInp_TextChanged(sender As Object, e As EventArgs) Handles rentInp.TextChanged
        ValidateAndAssign(rentInp, rent)
    End Sub

    Private Sub hazardInp_TextChanged(sender As Object, e As EventArgs) Handles hazardInp.TextChanged
        ValidateAndAssign(hazardInp, hazard)
    End Sub

    Private Sub allowancesTotalInp_TextChanged(sender As Object, e As EventArgs) Handles allowancesTotalInp.TextChanged

    End Sub

    Private Sub pensionInp_TextChanged(sender As Object, e As EventArgs) Handles pensionInp.TextChanged
        ValidateAndAssign(pensionInp, pension)
    End Sub

    Private Sub nhisInp_TextChanged(sender As Object, e As EventArgs) Handles nhisInp.TextChanged
        ValidateAndAssign(nhisInp, nhis)
    End Sub

    Private Sub taxInp_TextChanged(sender As Object, e As EventArgs) Handles taxInp.TextChanged
        ValidateAndAssign(taxInp, tax)
    End Sub

    Private Sub deductionTotalInp_TextChanged(sender As Object, e As EventArgs) Handles deductionTotalInp.TextChanged

    End Sub

    Private Sub grosspayBtn_Click(sender As Object, e As EventArgs) Handles grosspayBtn.Click
        ' Calculate gross pay based on percentages
        Total_allowance = CalculatePercentage(10) + CalculatePercentage(15) + CalculatePercentage(6.5)
        allowancesTotalInp.Text = Total_allowance
        grossPay = basicSalary + Total_allowance
        grosspayInp.Text = grossPay
    End Sub

    Private Sub netpayBtn_Click(sender As Object, e As EventArgs) Handles netpayBtn.Click
        ' Calculate net pay based on percentages
        Total_deduction = CalculatePercentage(7.5) + CalculatePercentage(5) + CalculatePercentage(2)
        netPay = grossPay - Total_deduction
        deductionTotalInp.Text = Total_deduction
        netpayInp.Text = netPay
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        ' Clear all input fields and result fields
        basicSalaryInp.Clear()
        tfairInp.Clear()
        rentInp.Clear()
        hazardInp.Clear()
        allowancesTotalInp.Clear()
        pensionInp.Clear()
        nhisInp.Clear()
        taxInp.Clear()
        deductionTotalInp.Clear()
        grosspayInp.Clear()
        netpayInp.Clear()
    End Sub
End Class
