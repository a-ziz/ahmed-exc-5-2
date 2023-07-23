<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFutureValue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblMonthlyInvestment = New System.Windows.Forms.Label()
        Me.lblYearlyInterestRate = New System.Windows.Forms.Label()
        Me.lblNumberOfYears = New System.Windows.Forms.Label()
        Me.lblFutureValue = New System.Windows.Forms.Label()
        Me.txtMonthlyInvestment = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtNumberOfYears = New System.Windows.Forms.TextBox()
        Me.txtFutureValue = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMonthlyInvestment
        '
        Me.lblMonthlyInvestment.AutoSize = True
        Me.lblMonthlyInvestment.Location = New System.Drawing.Point(14, 20)
        Me.lblMonthlyInvestment.Name = "lblMonthlyInvestment"
        Me.lblMonthlyInvestment.Size = New System.Drawing.Size(133, 17)
        Me.lblMonthlyInvestment.TabIndex = 0
        Me.lblMonthlyInvestment.Text = "Monthly Investment:"
        '
        'lblYearlyInterestRate
        '
        Me.lblYearlyInterestRate.AutoSize = True
        Me.lblYearlyInterestRate.Location = New System.Drawing.Point(14, 56)
        Me.lblYearlyInterestRate.Name = "lblYearlyInterestRate"
        Me.lblYearlyInterestRate.Size = New System.Drawing.Size(137, 17)
        Me.lblYearlyInterestRate.TabIndex = 1
        Me.lblYearlyInterestRate.Text = "Yearly Interest Rate:"
        '
        'lblNumberOfYears
        '
        Me.lblNumberOfYears.AutoSize = True
        Me.lblNumberOfYears.Location = New System.Drawing.Point(14, 92)
        Me.lblNumberOfYears.Name = "lblNumberOfYears"
        Me.lblNumberOfYears.Size = New System.Drawing.Size(119, 17)
        Me.lblNumberOfYears.TabIndex = 2
        Me.lblNumberOfYears.Text = "Number of Years:"
        '
        'lblFutureValue
        '
        Me.lblFutureValue.AutoSize = True
        Me.lblFutureValue.Location = New System.Drawing.Point(14, 128)
        Me.lblFutureValue.Name = "lblFutureValue"
        Me.lblFutureValue.Size = New System.Drawing.Size(93, 17)
        Me.lblFutureValue.TabIndex = 3
        Me.lblFutureValue.Text = "Future Value:"
        '
        'txtMonthlyInvestment
        '
        Me.txtMonthlyInvestment.Location = New System.Drawing.Point(177, 17)
        Me.txtMonthlyInvestment.Name = "txtMonthlyInvestment"
        Me.txtMonthlyInvestment.Size = New System.Drawing.Size(131, 22)
        Me.txtMonthlyInvestment.TabIndex = 4
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(177, 53)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(131, 22)
        Me.txtInterestRate.TabIndex = 5
        '
        'txtNumberOfYears
        '
        Me.txtNumberOfYears.Location = New System.Drawing.Point(177, 89)
        Me.txtNumberOfYears.Name = "txtNumberOfYears"
        Me.txtNumberOfYears.Size = New System.Drawing.Size(131, 22)
        Me.txtNumberOfYears.TabIndex = 6
        '
        'txtFutureValue
        '
        Me.txtFutureValue.Location = New System.Drawing.Point(177, 125)
        Me.txtFutureValue.Name = "txtFutureValue"
        Me.txtFutureValue.ReadOnly = True
        Me.txtFutureValue.Size = New System.Drawing.Size(131, 22)
        Me.txtFutureValue.TabIndex = 7
        Me.txtFutureValue.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(76, 167)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(121, 27)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(214, 167)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 27)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmFutureValue
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(338, 214)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtFutureValue)
        Me.Controls.Add(Me.txtNumberOfYears)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtMonthlyInvestment)
        Me.Controls.Add(Me.lblFutureValue)
        Me.Controls.Add(Me.lblNumberOfYears)
        Me.Controls.Add(Me.lblYearlyInterestRate)
        Me.Controls.Add(Me.lblMonthlyInvestment)
        Me.Name = "frmFutureValue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Future Value"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMonthlyInvestment As Label
    Friend WithEvents lblYearlyInterestRate As Label
    Friend WithEvents lblNumberOfYears As Label
    Friend WithEvents lblFutureValue As Label
    Friend WithEvents txtMonthlyInvestment As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents txtNumberOfYears As TextBox
    Friend WithEvents txtFutureValue As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class
