Public Class ChangePassR

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        chapassR()
    End Sub

    Private Sub ChangePassR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ne1.Text = My.Forms.ForgotR.ne1.Text
    End Sub
End Class