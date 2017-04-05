Imports MySql.Data.MySqlClient

Public Class UpdatePayment_A

    Private Sub SearchAddpayemt_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchAddpayemt_btn.Click
        

        Dim conn As New MySqlConnection ' <---
        ' Me.sn.Text = My.Forms.AdminPanel.TextBox1.Text
        'Me.FormBorderStyle = 0

        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM 	student_info WHERE (Student_ID_No ='" & sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                grade.Text = r("GradeLevel").ToString()
            Else
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()







        SearchUpdatePayment_A()
        If midterm.Text = "0" Then
            Payment_grp.Enabled = False
            MsgBox("Already paid!")
            pre_btn.Visible = False
            mid_btn.Visible = False
        End If
    End Sub

    Private Sub pre_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pre_btn.Click
        prelimPay_btn()
        SearchUpdatePayment_A()
        If prelim.Text = "0" Then
            pre_btn.Visible = False
            mid_btn.Visible = True
            Me.Enabled = False
        End If
        'If fin_btn.Text = "Paid!" Then
        '    MsgBox("Already Paid!")
        'End If
    End Sub

    Private Sub mid_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mid_btn.Click
        midtermPay_btn()
        SearchUpdatePayment_A()
        If midterm.Text = "0" Then
            MsgBox("Already paid!")
            pre_btn.Visible = False
            mid_btn.Visible = False
            Me.Enabled = False
        End If
    End Sub

    Private Sub UpdatePayment_A_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim t As Integer = total.Text
        Dim a As Integer = rf.Text
        Dim b As Integer = lf.Text
        Dim c As Integer = ef.Text
        Dim d As Integer = gf.Text
        Dim f As Integer = mf.Text
        Dim g As Integer = tf.Text
        t = a + b + c + d + f + g
        total.Text = t
    End Sub
    Private Sub UpadatePayment_A_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Screen_Cashier.Show()
        Screen_Cashier.Show()
    End Sub
End Class