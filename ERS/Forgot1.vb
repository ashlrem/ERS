Imports MySql.Data.MySqlClient
Public Class Forgot1
    Dim cn1 As New MySqlConnection
    Private Sub Forgot1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ne1.Text = My.Forms.ForgotV.ne1.Text
        insert()
        Dim r As MySqlDataReader
        Dim reg As String = "SELECT * FROM admin WHERE (EmployeeID ='" & ne1.Text & "')"
        cn1.Open()
        Dim cmd As MySqlCommand = New MySqlCommand(reg, cn1)
        r = cmd.ExecuteReader()
        If r.Read Then
            sq1.Text = r("SecurityQuestion1").ToString() & "."
            sq2.Text = r("SecurityQuestion2").ToString()
            cn1.Close()
        Else
            MsgBox("EmployeeID not Found!")
            ' en.Focus()
            cn1.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        forgot()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ans1.Text = ""
        ans2.Text = ""
        Me.Close()
        ForgotV.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Forms.MainScreen.AdminBtn.Visible = True
        My.Forms.MainScreen.CashierBtn.Visible = True
        My.Forms.MainScreen.RegistrarBtn.Visible = True
        My.Forms.MainScreen.AboutUsBtn.Visible = True
        My.Forms.MainScreen.PictureBox1.Visible = True
        Me.Close()
    End Sub
End Class