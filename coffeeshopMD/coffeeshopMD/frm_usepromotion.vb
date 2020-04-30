Public Class frm_usepromotion
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_active_Click(sender As Object, e As EventArgs) Handles btn_active.Click
        sql = "select * from promotion where promotion_coupon =  '" & txt_coupon.Text & "' AND promotion_count >=1"
        Dim dts As DataTable = cmd_excuteDataTable()
        If dts.Rows.Count = 0 Then
            msg_error("ไม่พบ Coupon นี้ หรือ Coupon ถูกใช้งานไปครบจำนวนแล้ว")
            Return
        End If


        lbl_condition.Text = dts.Rows(0)("promotion_condition")
        lbl_discount.Text = dts.Rows(0)("promotion_discount")


        txt_coupon.Enabled = False
        btn_active.Enabled = False


    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        sql = "update promotion set promotion_count = promotion_count-1 where promotion_coupon = '" & txt_coupon.Text & "'"
        If cmd_excuteNonquery() = 0 Then
            msg_error("ไม่พบ Coupon")
        Else
            msg_ok("ใช้คูปองสำเร็จ")
            frm_coffeeSale.lbl_discount.Text = lbl_discount.Text
            frm_coffeeSale.lbl_condition.Text = lbl_condition.Text

            Me.Close()

        End If
    End Sub
End Class