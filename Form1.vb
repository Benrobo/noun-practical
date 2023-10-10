Public Class Form1
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim fName As String = "Benrobo"
        Dim Balance As Decimal
        Dim Bank As New Bank()
        Dim bnkName As String = Bank.GetName("first bank")

        Bank.Deposit(2000)
        Balance = Bank.GetBalance()
        MsgBox(Balance)
        Bank.Withdraw(20000)
        Balance = Bank.GetBalance()
        MsgBox(Balance)

    End Sub
End Class


Public Class Bank
    Dim FName As String
    Dim BankAcct As Decimal


    Public Sub New()

    End Sub

    Public Function GetName(name As String)
        FName = name
        Return name
    End Function

    Public Sub Deposit(amount As Integer)
        If (amount = 0) Then
            MsgBox("Amount can't be empty!!")
            Return
        Else
            BankAcct += amount
        End If

    End Sub

    Public Sub Withdraw(amount As Integer)
        If (amount > Me.BankAcct) Then
            MsgBox("Insufficient funds!!")
            Exit Sub
        Else
            BankAcct -= amount
        End If

    End Sub

    Public Function GetBalance()
        Return Me.BankAcct
    End Function
End Class