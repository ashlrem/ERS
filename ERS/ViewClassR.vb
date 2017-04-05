Imports MySql.Data.MySqlClient

Public Class ViewClassR

    Private Sub ViewSubjectR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
    End Sub

    Private Sub SearchSubj_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSubj_btn.Click
        cn.Close()
        SearchSubject_R_View_btn()
    End Sub
    Private Sub ViewClassR_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Screen_Registrar.Show()
        RegistrarPanel.Show()
    End Sub

    Private Sub subj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subj.SelectedIndexChanged, sec.SelectedIndexChanged

    End Sub
End Class