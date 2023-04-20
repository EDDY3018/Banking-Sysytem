Public Class home


    Public totacc As Integer
    Public totemp As Integer
    Public bankbal As Integer

    Public ReadOnly Property getBalance As Decimal
        Get
            Return bankbal
        End Get
    End Property

    Private Sub DepositToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositToolStripMenuItem.Click
        Deposit.Show()

    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WithdrawToolStripMenuItem.Click
        Withdraw.Show()

    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Deposit.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Withdraw.Show()

    End Sub

    Public Sub depositAmount(depositAmount As Decimal)
        If depositAmount <= 0D Then
            Throw New ArgumentOutOfRangeException("Deposit must be > 0")
        End If
        bankbal += depositAmount
    End Sub

    Public Sub withdrawAmount(withdrawalAmount As Decimal)
        If withdrawalAmount > getBalance Then
            Throw New ArgumentOutOfRangeException("Withdrawal amount must be <= Balance")
        ElseIf withdrawalAmount <= 0D Then
            Throw New ArgumentOutOfRangeException("Withdrawal amount must be > 0")
        End If

        bankbal -= withdrawalAmount
    End Sub

    Private Sub cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Close()
    End Sub

    Private Sub LoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoanToolStripMenuItem.Click
        Loan.Show()
    End Sub
End Class