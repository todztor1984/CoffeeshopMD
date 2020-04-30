Public Class frm_manage_coffee
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Public Sub refresh_coffee()
        sql = "select coffee_id, coffee_name, coffee_image from coffee"
        datagrid_coffee.DataSource = cmd_excuteDataTable()
        change_datagrid_column()
    End Sub

    Public Sub change_datagrid_column()
        Dim column_text() As String = {"รหัสกาแฟ", "ชื่อกาแฟ", "ภาพประกอบ"}
        For i As Integer = 0 To datagrid_coffee.ColumnCount - 1
            datagrid_coffee.Columns(i).HeaderText = column_text(i)
        Next
    End Sub

    Public Sub clear_from()
        txt_add_cool.Text = ""
        txt_add_hot.Text = ""
        txt_add_id.Text = ""
        txt_add_name.Text = ""
        txt_add_spin.Text = ""
        txt_search.Text = ""
        pic_add.Image = Nothing

    End Sub
    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        If confirm("คุณยืนยันที่จะเพิ่มกาแฟหรือไม่ ?") = vbNo Then Return 

            If txt_add_id.Text = "" Or txt_add_name.Text = "" Or txt_add_hot.Text = "" Or txt_add_cool.Text = "" Or txt_add_spin.Text = "" Then
            msg_error("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If Not IsNumeric(txt_add_hot.Text) Or Not IsNumeric(txt_add_cool.Text) Or Not IsNumeric(txt_add_spin.Text) Then
            msg_error("กรุณากรอกราคาเป็นตัวเลขเท่านั้น")
            Return
        End If

        If pic_add.Image Is Nothing Then
            sql = "insert into coffee(coffee_id, coffee_name, coffee_hot, coffee_cool, coffee_spin) values(@id, @name, @hot, @cool, @spin)"
        Else
            sql = "insert into coffee(coffee_id, coffee_name, coffee_hot, coffee_cool, coffee_spin, coffee_image) values(@id, @name, @hot, @cool, @spin, @img)"
        End If
        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txt_add_id.Text)
        cmd.Parameters.AddWithValue("name", txt_add_name.Text)
        cmd.Parameters.AddWithValue("hot", txt_add_hot.Text)
        cmd.Parameters.AddWithValue("cool", txt_add_cool.Text)
        cmd.Parameters.AddWithValue("spin", txt_add_spin.Text)
        If Not pic_add.Image Is Nothing Then
            'add image ลงฐานข้อมูล 
            Dim mem As New IO.MemoryStream
            pic_add.Image.Save(mem, Imaging.ImageFormat.Bmp)
            Dim pic_for_add() As Byte
            pic_for_add = mem.ToArray()
            cmd.Parameters.AddWithValue("img", pic_for_add)

        End If
        If cmd.ExecuteNonQuery = 0 Then
            msg_error("เพิ่มไม่สำเร็จ")
        Else
            msg_ok("เพิ่มสำเร็จ")
            refresh_coffee()
            clear_from()
            frm_coffeeSale.refresh_coffee()
        End If

    End Sub

    Private Sub btn_select_picture_Click(sender As Object, e As EventArgs) Handles btn_select_picture.Click
        If openfile_coffee.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim img As Image
            img = Image.FromFile(openfile_coffee.FileName)
            pic_add.Image = img

        End If
    End Sub

    Private Sub frm_manage_coffee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coffee()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        sql = "select coffee_id, coffee_name, coffee_image from coffee where coffee_id like '%" & txt_search.Text & "%' or coffee_name like '%" & txt_search.Text & "%'"
        datagrid_coffee.DataSource = cmd_excuteDataTable()
        change_datagrid_column()
    End Sub

    Private Sub datagrid_coffee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_coffee.CellContentClick

    End Sub

    Private Sub datagrid_coffee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_coffee.CellClick
        Dim select_row As Integer = datagrid_coffee.CurrentRow.Index
        Dim coffee_id As String = datagrid_coffee.Item(0, select_row).Value
        sql = "select * from coffee where coffee_id =  '" & coffee_id & "'"
        Dim data_keep As DataTable = cmd_excuteDataTable()
        txt_edit_id.Text = data_keep.Rows(0)("coffee_id")
        txt_edit_name.Text = data_keep.Rows(0)("coffee_name")
        txt_edit_hot.Text = data_keep.Rows(0)("coffee_hot")
        txt_edit_cool.Text = data_keep.Rows(0)("coffee_cool")
        txt_edit_spin.Text = data_keep.Rows(0)("coffee_spin")
        Dim img() As Byte = data_keep.Rows(0)("coffee_image")
        pic_edit.Image = Image.FromStream(New IO.MemoryStream(CType(img, Byte())))

    End Sub

    Private Sub btn_save_edit_Click(sender As Object, e As EventArgs) Handles btn_save_edit.Click
        If confirm("คุณต้องการแก้ไขกาแฟ หรือไม่ ?") = vbNo Then Return
        If txt_edit_cool.Text = "" Or txt_edit_hot.Text = "" Or txt_edit_id.Text = "" Or txt_edit_name.Text = "" Or txt_edit_spin.Text = "" Then
            msg_error("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If Not IsNumeric(txt_edit_hot.Text) Or Not IsNumeric(txt_edit_cool.Text) Or Not IsNumeric(txt_edit_spin.Text) Then
            msg_error("กรุณากรอกราคาเป็นตัวเลขเท่านั้น")
            Return
        End If

        If pic_edit.Image Is Nothing Then
            sql = "update coffee set coffee_name =@name, coffee_hot=@hot, coffee_cool=@cool, coffee_spin=@spin where coffee_id=@id"
        Else
            sql = "update coffee set coffee_name =@name, coffee_hot=@hot, coffee_cool=@cool, coffee_spin=@spin, coffee_image=@img where coffee_id=@id"
        End If


        cmd = New SqlClient.SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("name", txt_edit_name.Text)
        cmd.Parameters.AddWithValue("hot", txt_edit_hot.Text)
        cmd.Parameters.AddWithValue("cool", txt_edit_cool.Text)
        cmd.Parameters.AddWithValue("spin", txt_edit_spin.Text)
        If Not pic_edit.Image Is Nothing Then
            'edit image ลงฐานข้อมูล 
            Dim mem As New IO.MemoryStream
            pic_edit.Image.Save(mem, Imaging.ImageFormat.Bmp)
            Dim pic_for_add() As Byte
            pic_for_add = mem.ToArray()
            cmd.Parameters.AddWithValue("img", pic_for_add)

        End If
        cmd.Parameters.AddWithValue("id", txt_edit_id.Text)

        If cmd.ExecuteNonQuery() = 0 Then
            msg_error("ไม่สามารถแก้ไขได้")
        Else
            msg_ok("แก้ไขสำเร็จ")
            refresh_coffee()
            txt_confrim.Text = ""
            frm_coffeeSale.refresh_coffee()
        End If
    End Sub

    Private Sub btn_select_edit_picture_Click(sender As Object, e As EventArgs) Handles btn_select_edit_picture.Click
        If openfile_coffee.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim img As Image
            img = Image.FromFile(openfile_coffee.FileName)
            pic_edit.Image = img

        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub btn_detele_Click(sender As Object, e As EventArgs) Handles btn_detele.Click
        If txt_confrim.Text <> "ยืนยันการลบ" Then
            msg_error("กรุณาพิมพ์คำว่า ยืนยันการลบ ในช่องว่างใหม่อีกครั้ง")
            txt_confrim.Text = ""
            txt_confrim.Select()
            Return
        End If

        Dim select_id As Integer = datagrid_coffee.CurrentRow.Index
        Dim coffee_id As String = datagrid_coffee.Item(0, select_id).Value

        sql = "delete from coffee where coffee_id = '" & coffee_id & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("ไม่สามารถลบได้")
        Else
            msg_ok("ลบสำเร็จ")
            refresh_coffee()
            frm_coffeeSale.refresh_coffee()
        End If

    End Sub
End Class