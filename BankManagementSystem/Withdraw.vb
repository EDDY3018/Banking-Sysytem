Public Class Withdraw

    Private Sub cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Hide()

    End Sub

    Private Sub Withdraw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accBalanceTextBox.Text = String.Format("{0:C}", home.getBalance)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            home.withdrawAmount(Convert.ToDecimal(TextBox2.Text))
            accBalanceTextBox.Text = String.Format("{0:C}", home.getBalance)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Withdraw amount must be greater than 0 " & "and less than or equal to the account balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        TextBox2.Clear()
        TextBox2.Focus()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepositToolStripMenuItem.Click
        Deposit.Show()
        Me.Close()
    End Sub
End Class