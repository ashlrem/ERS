Public Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ReportViewer.RefreshReport()
       
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        My.Forms.MainScreen.AdminBtn.Visible = True
        My.Forms.MainScreen.CashierBtn.Visible = True
        My.Forms.MainScreen.RegistrarBtn.Visible = True
        My.Forms.MainScreen.AboutUsBtn.Visible = True
        My.Forms.MainScreen.PictureBox1.Visible = True
        Me.Close()
    End Sub
End Class