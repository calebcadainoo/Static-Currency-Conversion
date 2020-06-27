Imports System.IO
Imports System.Net.WebRequestMethods.Http
Imports System.Text
Imports System.Net

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

    Private Sub extBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        'If Asc(e.KeyChar) <> 8 Then
        '    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
        '        e.Handled = True
        '    End If
        'End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim amount
        If TextBox1.Text = "" Then
            amount = 0.0
        Else
            If Not IsNumeric(TextBox1.Text) Then
                amount = 0.0
                TextBox1.Text = "0.00"
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
