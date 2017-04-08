Imports System.IO
Imports System.Drawing.Imaging
Public Class UpdateCashierC

    Private Sub ValidateAccountUpdate_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidateAccountUpdate_btn.Click
        SCashier_btn()
    End Sub

    Private Sub update_account_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_account.Click
        UpdateCashiercc()
    End Sub
    Public Function base64toimage(ByVal base64code As String) As Image
        Dim imagebyte As Byte() = Convert.FromBase64String(base64code)
        Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
        Dim tmpImage As Image = Image.FromStream(ms, True)
        Return tmpImage
    End Function
    Private Sub UpdateUpdateCashierC_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Screen_Cashier.Show()
        CashierPanel.Show()
    End Sub

    Private Sub UpdateCashierC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height - 125) + 35
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
End Class