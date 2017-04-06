Public Class ForgotV
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        forgor01()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.MainScreen.AdminBtn.Visible = True
        My.Forms.MainScreen.CashierBtn.Visible = True
        My.Forms.MainScreen.RegistrarBtn.Visible = True
        My.Forms.MainScreen.AboutUsBtn.Visible = True
        My.Forms.MainScreen.PictureBox1.Visible = True
        Me.Close()
    End Sub
End Class