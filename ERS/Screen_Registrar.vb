Public Class Screen_Registrar

 
    Private Sub UpdateAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateAccountToolStripMenuItem.Click
        UpdateRegistrar.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(UpdateRegistrar)
        RegistrarPanel.Hide()
        UpdateRegistrar.Show()
    End Sub
    Private Sub UpdateSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateSubjectToolStripMenuItem.Click
        UpdateClass_R.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(UpdateClass_R)
        RegistrarPanel.Hide()
        UpdateClass_R.Show()
    End Sub

    Private Sub DeleteSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSubjectToolStripMenuItem.Click
        DeleteSubj_R.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(DeleteSubj_R)
        RegistrarPanel.Hide()
        DeleteSubj_R.Show()
    End Sub

    Private Sub UpdateStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStudentRecordToolStripMenuItem.Click
        UpdateStudent_R.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(UpdateStudent_R)
        RegistrarPanel.Hide()
        UpdateStudent_R.Show()
    End Sub

    Private Sub DeleteStudentRecordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteStudentRecordToolStripMenuItem.Click
        DeleteStudent_R.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(DeleteStudent_R)
        RegistrarPanel.Hide()
        DeleteStudent_R.Show()
    End Sub

    Private Sub SearchStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudentToolStripMenuItem.Click
        ViewStudentInfo.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(ViewStudentInfo)
        RegistrarPanel.Hide()
        ViewStudentInfo.Show()
    End Sub

    Private Sub SubjectToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectToolStripMenuItem1.Click
        ViewClass.TopLevel = False
        RegistrarPanelPictureBox.Controls.Add(ViewClass)
        RegistrarPanel.Hide()
        ViewClass.Show()
    End Sub

    Private Sub AddSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSubjectToolStripMenuItem.Click

    End Sub
End Class