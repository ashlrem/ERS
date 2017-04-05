Public Class ChangePassC

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        chapassC()
    End Sub

    Private Sub ChangePassC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ne1.Text = My.Forms.ForgotC.ne1.Text
    End Sub
End Class