Public Class frm_promotion
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_count.Text = "" Or txt_coupon.Text = "" Or txt_discount.Text = "" Then
            msg_error("ไม่สามารถเว้นว่างได้")
            Return
        End If

        If confirm("จะเพิ่ม coupon หรือไม่ ?") = vbNo Then Return


        sql = String.Format("insert into promotion(promotion_coupon, promotion_condition, promotion_discount, promotion_count) values('{0}','{1}','{2}','{3}')", txt_coupon.Text, txt_condition.Text, txt_discount.Text, txt_count.Text)
        If cmd_excuteNonquery() = 0 Then
            msg_error("ไม่สามารถเพิ่มได้")
        Else
            msg_ok("เพิ่มสำเร็จ")
            txt_condition.Text = ""
            txt_count.Text = ""
            txt_coupon.Text = ""
            txt_discount.Text = ""
            refresh_coupon()

        End If


    End Sub


    Public Sub refresh_coupon()
        sql = "select * from promotion"
        daragrid_all.DataSource = cmd_excuteDataTable()
        sql = "select * from promotion where promotion_count = 0"
        datagrid_expire.DataSource = cmd_excuteDataTable()
        head_change()

        lbl_total_1.Text = daragrid_all.RowCount
        lbl_total_2.Text = datagrid_expire.RowCount

    End Sub

    Public Sub head_change()
        Dim head() As String = {"รหัส", "คูปอง", "เงื่อนไข", "ส่วนลด", "คงเหลือ"}
        For i As Integer = 0 To head.Length - 1
            daragrid_all.Columns(i).HeaderText = head(i)
            datagrid_expire.Columns(i).HeaderText = head(i)

        Next

    End Sub




    Private Sub frm_promotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coupon()
    End Sub

    Private Sub btn_coupon_add_Click(sender As Object, e As EventArgs) Handles btn_coupon_add.Click
        Dim i As Integer = daragrid_all.CurrentRow.Index
        Dim coupon As String = daragrid_all.Item(1, i).Value


        sql = "update promotion set promotion_count= promotion_count+" & txt_coupon_add.Text & " where promotion_coupon = '" & coupon & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("ไม่สำเร็จ")
        Else
            msg_ok("สำเร็จ")
            refresh_coupon()

        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim i As Integer = daragrid_all.CurrentRow.Index
        Dim coupon As String = daragrid_all.Item(1, i).Value


        If confirm("จะลบ coupon หรือไม่ ?") = vbNo Then Return


        sql = "delete from promotion where promotion_coupon = '" & coupon & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("ไม่สำเร็จ")
        Else
            msg_ok("สำเร็จ")
            refresh_coupon()

        End If



    End Sub
End Class