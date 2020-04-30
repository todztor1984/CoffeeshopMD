Imports System.Data.SqlClient

Public Class frm_customer_login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        If confirm("ยืนยันการสมัครสมาชิก ") = vbNo Then
            Return
        End If

        connect_open()

        Dim name As String = txt_edit_name.Text
        Dim nickname As String = txt_edit_nickname.Text
        Dim born As Date = date_edit_born.Value
        Dim address As String = txt_edit_address.Text
        Dim tel As String = txt_edit_tel.Text
        Dim username As String = txt_edit_username.Text
        Dim password As String = txt_edit_password.Text

        sql = "insert into customer(username, password, name, nickname, born, address, tel, point) values(@username, @password, @name, @nickname, @born, @address, @tel, @point)"
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("username", username)
        cmd.Parameters.AddWithValue("password", password)
        cmd.Parameters.AddWithValue("name", name)
        cmd.Parameters.AddWithValue("nickname", nickname)
        cmd.Parameters.AddWithValue("born", born)
        cmd.Parameters.AddWithValue("address", address)
        cmd.Parameters.AddWithValue("tel", tel)
        cmd.Parameters.AddWithValue("point", 0)



        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("สมัครสำเร็จ")
            txt_edit_address.Text = ""
            txt_edit_name.Text = ""
            txt_edit_nickname.Text = ""
            txt_edit_tel.Text = ""
            txt_edit_username.Text = ""
            txt_edit_password.Text = ""
        Else
            msg_error("ไม่สำเร็จ")


        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_login.Show()
        Me.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        connect_open()
        sql = "select * from customer where username='" & txt_username.Text & "' AND password= '" & txt_passworf.Text & "'"
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        Dim DT As DataTable = DS.Tables("table")

        If DT.Rows.Count = 0 Then
            msg_error("ไม่พบ Username / Password อยู่ในระบบ")
        Else
            Me.Hide()

            With frm_customer_main
                .txt_edit_address.Text = DT.Rows(0)("address")
                .txt_edit_name.Text = DT.Rows(0)("name")
                .txt_edit_nickname.Text = DT.Rows(0)("nickname")
                .txt_edit_password.Text = DT.Rows(0)("password")
                .txt_edit_point.Text = DT.Rows(0)("point")
                .txt_edit_tel.Text = DT.Rows(0)("tel")
                .txt_edit_username.Text = DT.Rows(0)("username")
            End With

            frm_customer_main.load_bill()
            frm_customer_main.Show()


        End If

    End Sub
End Class