Public Class Deposit

    Private Sub cls_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Hide()
    End Sub

    Private Sub Deposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accBalanceTextBox.Text = String.Format("{0:C}", home.getBalance)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            home.depositAmount(Convert.ToDecimal(TextBox2.Text))
            accBalanceTextBox.Text = String.Format("{0:C}", home.getBalance)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show("Deposit amount must be positive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        TextBox2.Clear()
        TextBox2.Focus()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub WithdrawToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithdrawToolStripMenuItem.Click
        Withdraw.Show()
        Me.Close()
    End Sub
End Class