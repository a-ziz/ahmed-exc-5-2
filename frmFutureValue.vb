Public Class frmFutureValue
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMonthlyInvestment.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object,
                                   e As EventArgs) Handles btnCalculate.Click

        Dim monthlyInvestment As Decimal = CDec(txtMonthlyInvestment.Text)
        Dim yearlyInterestRate As Decimal = CDec(txtInterestRate.Text)
        Dim years As Integer = CInt(txtNumberOfYears.Text)
        Dim monthlyInterestRate As Decimal = yearlyInterestRate / 12 / 100
        Dim months As Integer = years * 12

        Dim futureValue As Decimal

        'For i As Integer = 1 To months
        '    futureValue = (futureValue + monthlyInvestment) *
        '                  (1 + monthlyInterestRate)
        'Next

        Dim i As Integer = 1
        Do Until i > months
            futureValue = (futureValue + monthlyInvestment) *
                          (1 + monthlyInterestRate)
            i += 1
            If futureValue > 1000 Then
                Continue Do
            End If
        Loop

        txtFutureValue.Text = FormatCurrency(futureValue)

        txtMonthlyInvestment.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtYearlyInterestRate_TextChanged(sender As Object, e As EventArgs) Handles txtInterestRate.TextChanged

    End Sub
End Class
