﻿Public Class DeletePayment

    Private Sub SearchAddpayemt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAddpayemt_btn.Click
        SearchDeletePayment_A()
    End Sub

    Private Sub DeletePayment_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePayment_btn.Click
        deletePayment_btn_a()
        midterm.Text = ""
        prelim.Text = ""
    End Sub

    Private Sub DeletePayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
        Dim t As Integer = total.Text
        Dim a As Integer = rf.Text
        Dim b As Integer = lf.Text
        Dim c As Integer = ef.Text
        Dim d As Integer = gf.Text
        Dim f As Integer = mf.Text
        Dim g As Integer = tf.Text
        t = a + b + c + d + f + g
        total.Text = t
    End Sub
    Private Sub DeletePayment_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Screen_Cashier.Show()
        Screen_Cashier.Show()
        DeletePayment_btn.Visible = True
    End Sub
End Class