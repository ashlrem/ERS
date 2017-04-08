Imports MySql.Data.MySqlClient
Module Payment
    Public Sub SearchAddPayment_A()
        Dim conn As New MySqlConnection ' <---
        ' Me.sn.Text = My.Forms.AdminPanel.TextBox1.Text
        'Me.FormBorderStyle = 0
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & My.Forms.AddPayment_A.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.AddPayment_A.grade.Text = r("GradeLevel").ToString()
                My.Forms.AddPayment_A.nameOS.Text = r("Lastname").ToString() & ", " & r("GivenName").ToString() & " " & r("Middlename").ToString()

                My.Forms.AddPayment_A.miscellaneous_fee_grp.Enabled = True
                My.Forms.AddPayment_A.Payment_grp.Enabled = True
            Else
                MsgBox("Student Number not Found!")
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub

    Public Sub SearchAddPayment1_A()
        Dim conn As New MySqlConnection ' <---
        ' Me.sn.Text = My.Forms.AdminPanel.TextBox1.Text
        'Me.FormBorderStyle = 0
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM payment_tbl WHERE (Student_ID_No ='" & My.Forms.AddPayment_A.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                MsgBox("Student payment record already exists.")
            Else
                My.Forms.AddPayment_A.Proceed_btn.Enabled = True
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub

    Public Sub FullPayment_A()
        Try
            Dim objConn As New MySqlConnection
            Dim ins As New MySqlCommand
            Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            objConn.ConnectionString = cn
            objConn.Open()
            ins.Connection = objConn
            ins.CommandText = "INSERT INTO payment_tbl VALUES(@Student_ID_No,@Prelim , @Midterm)"
            ins.Parameters.AddWithValue("@Student_ID_No", My.Forms.AddPayment_A.sn.Text)
            ins.Parameters.AddWithValue("@Prelim", 0)
            ins.Parameters.AddWithValue("@Midterm", 0)
            ins.ExecuteNonQuery()
            MsgBox("Payment Added!")
            objConn.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Public Sub PartialPayment_A()
        Try
            Dim objConn As New MySqlConnection
            Dim ins As New MySqlCommand
            Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            objConn.ConnectionString = cn
            objConn.Open()
            ins.Connection = objConn
            ins.CommandText = "INSERT INTO payment_tbl VALUES(@Student_ID_No,@FirstPayment , @SecondPayment)"
            ins.Parameters.AddWithValue("@Student_ID_No", My.Forms.AddPayment_A.sn.Text)
            ins.Parameters.AddWithValue("@FirstPayment", My.Forms.AddPayment_A.prelim.Text)
            ins.Parameters.AddWithValue("@SecondPayment", My.Forms.AddPayment_A.midterm.Text)
            ins.ExecuteNonQuery()
            MsgBox("Payment Added!")
            objConn.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Public Sub SearchUpdatePayment_A()
        Dim conn As New MySqlConnection ' <---
        ' Me.sn.Text = My.Forms.AdminPanel.TextBox1.Text
        'Me.FormBorderStyle = 0
     
            Try
                'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
                Dim r As MySqlDataReader
                Dim reg As String = "SELECT * FROM payment_tbl WHERE (Student_ID_No ='" & My.Forms.UpdatePayment_A.sn.Text & "')"
                conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
                Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
                r = cmd.ExecuteReader()
                If r.Read Then
                My.Forms.UpdatePayment_A.prelim.Text = r("FirstPayment").ToString()
                My.Forms.UpdatePayment_A.midterm.Text = r("SecondPayment").ToString()
                My.Forms.UpdatePayment_A.pre_btn.Visible = True


                My.Forms.Reciept.nameOS.Text = My.Forms.UpdatePayment_A.sn.Text
                My.Forms.Reciept.grade.Text = My.Forms.UpdatePayment_A.grade.Text


                My.Forms.UpdatePayment_A.Payment_grp.Enabled = True
                    If My.Forms.UpdatePayment_A.prelim.Text = "0" Then
                        My.Forms.UpdatePayment_A.pre_btn.Visible = False
                        My.Forms.UpdatePayment_A.mid_btn.Visible = True
                    End If
                    If My.Forms.UpdatePayment_A.midterm.Text = "0" Then
                        My.Forms.UpdatePayment_A.pre_btn.Visible = False
                        My.Forms.UpdatePayment_A.mid_btn.Visible = False
                    End If
                Else
                    MsgBox("Student Number not Found!")
                    conn.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
            End Try
        conn.Close()
    End Sub
    Public Sub prelimPay_btn()
        Try
       
            Dim reg As String = "UPDATE payment_tbl SET FirstPayment = 0 where Student_ID_No ='" & My.Forms.UpdatePayment_A.sn.Text & "'"
            Dim paymentOf As String = "Midterm"
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn1)
                    cn1.Open()
                    sqlCmd.ExecuteNonQuery()
                    My.Forms.Reciept.nameOS.Text = My.Forms.UpdatePayment_A.sn.Text
                    My.Forms.Reciept.grade.Text = My.Forms.UpdatePayment_A.grade.Text
                    My.Forms.Reciept.amount.Text = My.Forms.UpdatePayment_A.prelim.Text
                    My.Forms.Reciept.po.Text = paymentOf
                    Reciept.Show()
                    MsgBox("Midterm Paid!")
                    My.Forms.UpdatePayment_A.pre_btn.Text = "Paid!"
                    cn1.Close()
                End Using
                cn1.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub midtermPay_btn()
        Try

            Dim reg As String = "UPDATE payment_tbl SET SecondPayment = 0 Where Student_ID_No ='" & My.Forms.UpdatePayment_A.sn.Text & "'"
            Dim paymentOf As String = "Final"
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn1)
                    cn1.Open()
                    sqlCmd.ExecuteNonQuery()
                    MsgBox("Finals Paid!")
                    My.Forms.UpdatePayment_A.mid_btn.Text = "Paid!"
                    My.Forms.Reciept.nameOS.Text = My.Forms.UpdatePayment_A.sn.Text
                    My.Forms.Reciept.grade.Text = My.Forms.UpdatePayment_A.grade.Text
                    My.Forms.Reciept.amount.Text = My.Forms.UpdatePayment_A.midterm.Text
                    My.Forms.Reciept.po.Text = paymentOf
                    Reciept.Show()
                    cn1.Close()
                End Using
                cn1.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try
    End Sub
    Public Sub SearchDeletePayment_A()
        Dim conn As New MySqlConnection ' <---


        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM payment_tbl WHERE (Student_ID_No ='" & My.Forms.DeletePayment.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.DeletePayment.prelim.Text = r("FirstPayment").ToString()
                My.Forms.DeletePayment.midterm.Text = r("SecondPayment").ToString()
                My.Forms.DeletePayment.sn.Enabled = False
                My.Forms.DeletePayment.SearchAddpayemt_btn.Enabled = False
                My.Forms.DeletePayment.DeletePayment_btn.Enabled = True
            Else
                MsgBox("Student Number not Found!")
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub
    Public Sub deletePayment_btn_a()
        '   For Each FRM As Form In Application.OpenForms
        Try
            '  Dim deleteAccountUser As String = "My.Forms." & FRM.Name.ToString & ".en.Text"
            '  Dim reg1 As String = "DELETE FROM accounts WHERE EmployeeID = '" & My.Forms.DeleteRegistrar.en.Text & "'"
            Dim reg1 As String = "DELETE FROM payment_tbl WHERE Student_ID_No = '" & My.Forms.DeletePayment.sn.Text & "'"
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd1 = New MySqlCommand(reg1, cn1)
                    cn1.Open()
                    sqlCmd1.ExecuteNonQuery()
                    MsgBox("Payment record Deleted!")
                    My.Forms.DeletePayment.DeletePayment_btn.Enabled = False
                    My.Forms.DeletePayment.sn.Enabled = True
                    My.Forms.DeletePayment.sn.Text = ""
                    My.Forms.DeletePayment.SearchAddpayemt_btn.Enabled = True
                    cn1.Close()
                End Using
                cn1.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn1.Close()
        End Try
        '  Next
    End Sub
    Public Sub test()
        Dim conn As New MySqlConnection ' <---
        ' Me.sn.Text = My.Forms.AdminPanel.TextBox1.Text
        'Me.FormBorderStyle = 0
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM items_tbl WHERE (gradelevel ='" & My.Forms.AddPayment_A.grade.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                While r.Read
                    My.Forms.AddPayment_A.Subj1.Text = r("subjectname").ToString()
                    My.Forms.AddPayment_A.p1.Text = r("price").ToString()

                    My.Forms.AddPayment_A.Subj2.Text = r("subjectname").ToString()
                    My.Forms.AddPayment_A.p2.Text = r("price").ToString()





                End While



            Else
                MsgBox("Not yet added")
                My.Forms.AddPayment_A.Proceed_btn.Enabled = True
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub
    Public Sub addBook()
        Try
            Dim objConn As New MySqlConnection
            Dim ins As New MySqlCommand
            Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            objConn.ConnectionString = cn
            objConn.Open()
            ins.Connection = objConn
            ins.CommandText = "INSERT INTO items_tbl VALUES(@subjectname, @price , @gradelevel)"
            ins.Parameters.AddWithValue("@subjectname", My.Forms.addBookItem.subjectBookname.Text)
            ins.Parameters.AddWithValue("@price", My.Forms.addBookItem.gradelvl.SelectedItem)
            ins.Parameters.AddWithValue("@gradelevel", My.Forms.addBookItem.price.Text)
            ins.ExecuteNonQuery()
            My.Forms.addBookItem.gradelvl.SelectedItem = ""
            My.Forms.addBookItem.price.Text = ""
            My.Forms.addBookItem.subjectBookname.Text = ""
            MsgBox("Book Added!")
            objConn.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Public Sub retrieve123_btn()
        Dim conn As New MySqlConnection
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info_archive WHERE (Student_ID_No ='" & My.Forms.StudentArchive.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.StudentArchive.sn.Text = r("Student_ID_No").ToString()
                pic = r("Photo").ToString()
                Address = r("Address").ToString()
                Birthday = r("Birthday").ToString()
                GradeLevel = r("GradeLevel").ToString()
                Contact = r("Contact").ToString()
                SchoolYear = r("SchoolYear").ToString()
                MotherName = r("MotherName").ToString
                MotherOccupation = r("OccupationM").ToString
                FatherName = r("FatherName").ToString
                FatherOccupation = r("OccupationF").ToString
                Guardian = r("Guardian").ToString
                Relation = r("Relation").ToString
                Contact = r("Contact").ToString
                gender = r("Gender").ToString
                AddressLastSchool = r("Address_of_LastSchool").ToString
                NameLastSchool = r("Name_Of_LastSchool").ToString
                Section = r("Section").ToString
                Birthplace = r("Birth_Place").ToString
                Scholar = r("Scholar").ToString
                FirstN = r("GivenName").ToString
                MiddleN = r("MiddleName").ToString
                LastN = r("LastName").ToString
                religion = r("Religion").ToString
                Citizen = r("Citizenship").ToString
                pic = r("Photo").ToString()
                NSO2 = r("NSO").ToString()
                baptis = r("Baptismal").ToString()
                card = r("UploadCard").ToString()
                form137 = r("UploadForm137").ToString()
                goodMoral = r("UploadGoodMoral").ToString()
                age = r("Age").ToString()

                conn.Close() 'papalitan natin lahat ng cn1 ng conn
            Else
                MsgBox("Student ID not Found!")
                My.Forms.DeleteStudent_A.sn.Focus()
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()
    End Sub

    Public Sub insertArchive()
        Try
            Dim objConn As New MySqlConnection
            Dim ins As New MySqlCommand
            Dim cn = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            objConn.ConnectionString = cn
            objConn.Open()
            ins.Connection = objConn
            ins.CommandText = "INSERT INTO student_info VALUES(@Photo, @Student_ID_No, @LastName, @GivenName, @MiddleName, @Birthday, @Birth_Place, @Gender, @Address, @Age, @Citizenship, @Religion, @SchoolYear, @GradeLevel, @Section, @Scholar, @MotherName, @OccupationM, @FatherName, @OccupationF, @Guardian, @Relation, @Contact, @NSO, @Baptismal, @Name_Of_LastSchool, @Address_of_LastSchool, @UploadCard, @UploadForm137, @UploadGoodMoral)"
            ins.Parameters.AddWithValue("@Photo", pic)
            ins.Parameters.AddWithValue("@Student_ID_No", My.Forms.StudentArchive.sn.Text)
            ins.Parameters.AddWithValue("@LastName", LastN)
            ins.Parameters.AddWithValue("@GivenName", FirstN)
            ins.Parameters.AddWithValue("@MiddleName", MiddleN)
            ins.Parameters.AddWithValue("@Birthday", Birthday)
            ins.Parameters.AddWithValue("@Birth_Place", Birthplace)
            ins.Parameters.AddWithValue("@Gender", gender)
            ins.Parameters.AddWithValue("@Address", Address)
            ins.Parameters.AddWithValue("@Age", age)
            ins.Parameters.AddWithValue("@Citizenship", Citizen)
            ins.Parameters.AddWithValue("@Religion", religion)
            ins.Parameters.AddWithValue("@SchoolYear", SchoolYear)
            ins.Parameters.AddWithValue("@GradeLevel", GradeLevel)
            ins.Parameters.AddWithValue("@Section", Section)
            ins.Parameters.AddWithValue("@Scholar", Scholar)
            ins.Parameters.AddWithValue("@MotherName", MotherName)
            ins.Parameters.AddWithValue("@OccupationM", MotherOccupation)
            ins.Parameters.AddWithValue("@FatherName", FatherName)
            ins.Parameters.AddWithValue("@OccupationF", FatherOccupation)
            ins.Parameters.AddWithValue("@Guardian", Guardian)
            ins.Parameters.AddWithValue("@Relation", Relation)
            ins.Parameters.AddWithValue("@Contact", Contact)
            ins.Parameters.AddWithValue("@NSO", NSO2)
            ins.Parameters.AddWithValue("@Baptismal", baptis)
            ins.Parameters.AddWithValue("@Name_Of_LastSchool", NameLastSchool)
            ins.Parameters.AddWithValue("@Address_of_LastSchool", AddressLastSchool)
            ins.Parameters.AddWithValue("@UploadCard", card)
            ins.Parameters.AddWithValue("@UploadForm137", form137)
            ins.Parameters.AddWithValue("@UploadGoodMoral", goodMoral)
            ins.ExecuteNonQuery()

            Address = ""
            Birthday = ""
            GradeLevel = ""
            SchoolYear = ""
            MotherName = ""
            MotherOccupation = ""
            FatherName = ""
            age = ""
            FatherOccupation = ""
            Gender = ""
            Guardian = ""
            Relation = ""
            Contact = ""
            AddressLastSchool = ""
            NameLastSchool = ""
            Section = ""
            Birthplace = ""
            Scholar = ""
            FirstN = ""
            MiddleN = ""
            LastN = ""
            religion = ""
            Citizen = ""
            NSO2 = ""
            baptis = ""
            card = ""
            form137 = ""
            goodMoral = ""

            objConn.Close()




            Dim reg As String = "DELETE FROM student_info_archive WHERE Student_ID_No = '" & My.Forms.StudentArchive.sn.Text & "'"
            Using cn1 = New MySqlConnection("server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'")
                Using sqlCmd = New MySqlCommand(reg, cn1)
                    cn1.Open()
                    sqlCmd.ExecuteNonQuery()
                    pic = ""
                    cn1.Close()
                End Using
                cn1.Close()
            End Using
            MsgBox("Student successfully restore.!!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cn.Close()
        End Try






        Dim conn As New MySqlConnection ' <---
        ' Me.sn.Text = My.Forms.AdminPanel.TextBox1.Text
        'Me.FormBorderStyle = 0
        Try
            'insert() 'tatanggalin natin to, ang error kasi is yung pag connect sa db. gawa tayo ng sarili.
            conn.ConnectionString = "server= '" & server & "'; userid= '" & user & "'; port= '" & port & "';password= '" & password & "';database='" & database & "'"
            Dim r As MySqlDataReader
            Dim reg As String = "SELECT * FROM student_info WHERE (Student_ID_No ='" & My.Forms.AddPayment_A.sn.Text & "')"
            conn.Open() 'instead na cn1.Open, babaguhin natin. ilalagay natin yung conn na ni declare natin sa taas.
            Dim cmd As MySqlCommand = New MySqlCommand(reg, conn) '<--- dapat gagana na to. haha.
            r = cmd.ExecuteReader()
            If r.Read Then
                My.Forms.AddPayment_A.grade.Text = r("GradeLevel").ToString()
                My.Forms.AddPayment_A.nameOS.Text = r("Lastname").ToString() & ", " & r("GivenName").ToString() & " " & r("Middlename").ToString()

                My.Forms.AddPayment_A.miscellaneous_fee_grp.Enabled = True
                My.Forms.AddPayment_A.Payment_grp.Enabled = True
            Else
                MsgBox("Student Number not Found!")
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.StackTrace) '<-- tanggalin naten yung error.
        End Try
        conn.Close()








    End Sub






End Module
