Imports System.Diagnostics.Eventing.Reader
Public Class Form1
    Dim op As Char

    Private Sub Btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        op = "+"
    End Sub

    Private Sub Btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        op = "-"
    End Sub

    Private Sub Btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        op = "*"
    End Sub

    Private Sub Btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        op = "/"
    End Sub

    Private Sub Btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        If IsNumeric(txt_A.Text) And IsNumeric(txt_B.Text) Then
            Dim a = ""
            Integer.Parse(txt_A.Text)
            Dim b = ""
            Integer.Parse(txt_B.Text)
            Dim res = 0
            Dim test = True
            If op = "+" Then
                res = a + b
            ElseIf op = "-" Then
                res = a - b
            ElseIf op = "*" Then
                res = a * b
            ElseIf op = "/" And Not b = 0 Then
                res = a / b
            Else
                MessageBox.Show("veuillez choisir un opérateur")
                test = False
            End If
            If test Then
                lbl_res.Text = a.ToString + "" + op + "" + b.ToString + "=" + res.ToString

            End If
        Else
            MessageBox.Show(" A et B doivent entre deux entier  ")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
