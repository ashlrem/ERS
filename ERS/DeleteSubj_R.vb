Public Class DeleteSubj_R

    Private Sub SearchSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cn.Close()
        SearchSubject_R_Delete_btn()
    End Sub

    Private Sub DeleteSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        deleteSubject_R()
    End Sub
    Private Sub DeleteSubj_R_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Screen_Registrar.Show()
        RegistrarPanel.Show()
    End Sub

    Private Sub DeleteSubj_R_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
End Class