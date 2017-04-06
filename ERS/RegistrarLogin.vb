Public Class RegistrarLogin
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoginReg()
    End Sub
    Private Sub RegistrarLogin_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        My.Forms.MainScreen.AdminBtn.Visible = True
        My.Forms.MainScreen.CashierBtn.Visible = True
        My.Forms.MainScreen.RegistrarBtn.Visible = True
        My.Forms.MainScreen.AboutUsBtn.Visible = True
        My.Forms.MainScreen.PictureBox1.Visible = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Forms.MainScreen.AdminBtn.Visible = False
        My.Forms.MainScreen.CashierBtn.Visible = False
        My.Forms.MainScreen.RegistrarBtn.Visible = False
        My.Forms.MainScreen.AboutUsBtn.Visible = False
        My.Forms.MainScreen.PictureBox1.Visible = False


        ForgotR.TopLevel = False
        My.Forms.MainScreen.Pi.Controls.Add(ForgotR)
        ForgotR.Show()
        Me.Hide()
    End Sub
End Class