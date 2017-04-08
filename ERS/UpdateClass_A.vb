Public Class UpdateClass_A
    Private Sub SearchSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchSubject_A_Update_btn()
    End Sub
    Private Sub UpdateSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        updateSubjA_btn()
    End Sub
    Private Sub UpdateSub_A_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Screen_Admin.Show()
        AdminPanel.Show()
    End Sub

    Private Sub UpdateClass_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class