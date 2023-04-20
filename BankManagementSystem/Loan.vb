Public Class Loan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If loanAmount.Text <> "" AndAlso loanPeriod.Text <> "" Then
            Try
                Dim amount As Decimal = Convert.ToDecimal(loanAmount.Text)
                Dim period As Integer = Convert.ToInt32(loanPeriod.Text)
                Dim rate As Decimal = 0.00

                If amount <= 0D Then
                    MsgBox("Invalid Amount")
                ElseIf amount <= 100 Then
                    rate = 0.3
                ElseIf amount <= 200 Then
                    rate = 0.4
                ElseIf amount <= 300 Then
                    rate = 0.5
                ElseIf amount <= 400 Then
                    rate = 0.6
                ElseIf amount <= 500 Then
                    rate = 0.7
                ElseIf amount <= 600 Then
                    rate = 0.8
                ElseIf amount <= 700 Then
                    rate = 0.9
                ElseIf amount > 700 Then
                    rate = 1
                End If

                If period <= 0 Then
                    MsgBox("Invalid Period")
                End If

                If Not amount <= 0D AndAlso Not period <= 0 Then

                    loanBalance.AppendText("Interest: ")
                    loanBalance.AppendText(Convert.ToString((amount * rate * period) / 100) & vbNewLine)
                    loanBalance.AppendText(String.Format("Amount: {0:C}", amount) & vbNewLine)
                    loanBalance.AppendText("Period: " & Convert.ToString(period) & " months" & vbNewLine)
                    loanBalance.AppendText(String.Format("Amount To Pay: {0:C}", (amount + (amount * rate * period) / 100)) & vbNewLine & "------------------------------" & vbNewLine)

                End If

            Catch ex As Exception
                MsgBox("Enter valid values")
            End Try
        End If
    End Sub
End Class