
Public Class Form1

    Public Sub ConvertCurrencies(ByVal amount As Integer)
        ' currency conversion values from Google on 27th June 2020
        Dim GHS_USD = 0.17
        Dim GHS_EUR = 0.15
        Dim GHS_GBP = 0.14

        If amount > 0 Then
            lblDollarValue.Text = CDbl(amount * GHS_USD)
            lblEuroValue.Text = CDbl(amount * GHS_EUR)
            lblGBPValue.Text = CDbl(amount * GHS_GBP)
        Else
            lblDollarValue.Text = amount & ".00"
            lblEuroValue.Text = amount & ".00"
            lblGBPValue.Text = amount & ".00"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(150, 0, 0, 0)
        Label1.BackColor = Color.FromArgb(150, 0, 0, 0)
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ConvertCurrencies(TextBox1.Text)
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim amount
        If TextBox1.Text = "" Then
            amount = 0.0
        Else
            If Not IsNumeric(TextBox1.Text) Then
                amount = 0.0
                TextBox1.Text = "0.00"
                TextBox1.SelectAll()
            End If
            amount = TextBox1.Text
        End If
        ConvertCurrencies(amount)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Today As System.DateTime = DateTime.Today
        lblTime.Text = TimeOfDay.ToString("h:mm:ss tt")
        lblDate.Text = Today.ToString("D")
    End Sub

End Class
