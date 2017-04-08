Public Class DeleteClass

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Close()
        SearchClass_A_Delete_btn()
    End Sub

    Private Sub DeleteSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSubj_btn.Click
        deleteSubject_A()
    End Sub
    Private Sub DeleteClass_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Screen_Admin.Show()
        AdminPanel.Show()
    End Sub

    Private Sub DeleteClass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
End Class