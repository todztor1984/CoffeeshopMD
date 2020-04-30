Imports System.Data.SqlClient

Public Class frm_customer_main
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If confirm("ยืนยันการแก้ไขข้อมูล ") = vbNo Then
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
        Dim point As Integer = txt_edit_point.Text

        sql = "update customer set password=@password, name=@name, nickname=@nickname, born=@born, address=@address, tel=@tel where username=@username "
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("username", username)
        cmd.Parameters.AddWithValue("password", password)
        cmd.Parameters.AddWithValue("name", name)
        cmd.Parameters.AddWithValue("nickname", nickname)
        cmd.Parameters.AddWithValue("born", born)
        cmd.Parameters.AddWithValue("address", address)
        cmd.Parameters.AddWithValue("tel", tel)




        If cmd.ExecuteNonQuery() >= 1 Then
            msg_ok("แก้ไขสำเร็จ")

        Else
            msg_error("ไม่สำเร็จ")


        End If
    End Sub

    Private Sub btn_use_point_Click(sender As Object, e As EventArgs) Handles btn_use_point.Click
        If txt_use_point.Text = "" Then
            msg_error("กรุณาระบุบจำนวนแต้มที่ต้องการแลก")
            txt_use_point.Select()
            Return
        End If



        Dim all_point As Integer = txt_edit_point.Text
        Dim use_point As Integer = txt_use_point.Text
        If use_point > all_point Then
            msg_error("point ของคุณน้อยเกินไป")
            Return
        End If

        Dim new_point As Integer = all_point - use_point


        If confirm("คุณต้องการจะแลหแต้มสะสมหรือไม่่ ?") = vbNo Then Return


        connect_open()
        sql = "update customer set point=point-" & txt_use_point.Text & " where username='" & txt_edit_username.Text & "'"
        cmd = New SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery >= 1 Then
            msg_ok("แต้มของคุณถูกหักไปแล้ว")

            Randomize()
            Dim rand_code As String = 999999 * Rnd()
            txt_coupon_code.Text = rand_code
            rand_code = rand_code.PadLeft(6, "0")
            sql = "insert into promotion (promotion_coupon, promotion_condition, promotion_discount, promotion_count) values(@coupon, @condition, @discount, @count)"
            cmd = New SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("coupon", rand_code)
            cmd.Parameters.AddWithValue("condition", "รับส่วนลดจากการแลกแต้ม" & txt_use_point.Text)
            cmd.Parameters.AddWithValue("discount", txt_use_point.Text)
            cmd.Parameters.AddWithValue("count", 1)

            If cmd.ExecuteNonQuery >= 1 Then
                msg_ok("สร้าง coupon สำเร็จ")
                txt_edit_point.Text = new_point
            Else
                msg_error("สร้าง coupon ไม่สำเร็จ")
            End If


        Else
            msg_error("ไม่สามารถหักแต้มสะสมได้")

        End If
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        frm_login.Show()
        Me.Close()
    End Sub

    Private Sub frm_customer_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub load_bill()
        connect_open()
        sql = "select * from sale_detail where customer='" & txt_edit_username.Text & "'"
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")


        datagrid_bill.DataSource = DS.Tables("table")
        change_bill_column()

    End Sub

    Private Sub datagrid_bill_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_bill.CellContentClick

    End Sub

    Private Sub datagrid_bill_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_bill.CellClick
        Dim i As Integer = datagrid_bill.CurrentRow.Index
        Dim key As String = datagrid_bill.Item(1, i).Value
        connect_open()
        sql = "select * from sale_table where sale_full_id='" & key & "'"
        DA = New SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")


        datagrid_list.DataSource = DS.Tables("table")
        change_list_column()
    End Sub

    Public Sub change_bill_column()
        Dim str() As String = {"รหัส", "เลขที่", "ราคารวม", "ส่วนลด", "เงื่อนไขส่วนลด", "ราคาสุทธิ", "username"}
        For i As Integer = 0 To datagrid_bill.Columns.Count - 1
            datagrid_bill.Columns(i).HeaderText = str(i)

        Next
    End Sub


    Public Sub change_list_column()
        Dim str() As String = {"เลขที่", "รหัส", "รหัสกาแฟ", "จำนวน", "ราคา", "วันที่ขาย"}
        For i As Integer = 0 To datagrid_list.Columns.Count - 1
            datagrid_list.Columns(i).HeaderText = str(i)

        Next
    End Sub


End Class