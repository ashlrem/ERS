Imports System.IO
Imports System.Drawing.Imaging
Public Class UpdateStudent_R
    Dim encodeType As ImageFormat = ImageFormat.Jpeg
    Dim decoding As String = String.Empty
    Private Sub SearchStudent_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchStudent_btn.Click
        SearchStudent_r_Update_btn()
    End Sub

    Public Function base64toimage(ByVal base64code As String) As Image
        Dim imagebyte As Byte() = Convert.FromBase64String(base64code)
        Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
        Dim tmpImage As Image = Image.FromStream(ms, True)
        Return tmpImage
    End Function
    Private Sub UpdateStudent_R_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Screen_Registrar.Show()
        RegistrarPanel.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Screen_Registrar.Show()
        RegistrarPanel.Show()
        Me.Close()
    End Sub

    Private Sub UpdateButton_a_Student_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton_a_Student.Click
        editstud_R()
    End Sub

    Private Sub UpdateStudent_R_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub

    Private Sub nso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nso.CheckedChanged
        If (nso.Checked = True) Then
            Try
                If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                    NSO2 = OpenFileDialog1.FileName
                End If
            Catch

            End Try
        End If
    End Sub

    Private Sub bapt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bapt.CheckedChanged
        If (bapt.Checked = True) Then
            Try
                If (OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                    baptis = OpenFileDialog1.FileName
                End If
            Catch

            End Try
        End If
    End Sub
End Class