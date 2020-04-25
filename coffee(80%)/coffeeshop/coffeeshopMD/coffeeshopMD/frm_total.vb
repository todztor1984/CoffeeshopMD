Public Class frm_total
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub txt_receive_TextChanged(sender As Object, e As EventArgs) Handles txt_receive.TextChanged

    End Sub

    Private Sub txt_receive_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_receive.KeyDown
        If e.KeyData = Keys.Enter Then


            If Not IsNumeric(txt_receive.Text) Then
                msg_error("กรุณากรอกเป็นตัวเลขเท่านั้น")
                txt_receive.Text = ""
                txt_receive.Select()
                Return

            End If

            If Val(txt_receive.Text) < Val(txt_total.Text) Then
                msg_error("ยอดที่รับมาน้อยกวว่า ยอดชำระ")
                txt_receive.Text = ""
                txt_receive.Select()
                Return

            End If


            Dim net As Double = txt_net.Text
            Dim recive As Double = txt_receive.Text
            Dim refund As Double = recive - net
            txt_refund.Text = FormatNumber(refund)

        End If
    End Sub

    Private Sub link_resize_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub


    Public Sub add_receive(money As Integer)
        Dim receive As Double
        Try
            receive = txt_receive.Text
        Catch ex As Exception
            receive = 0
        End Try

        receive += money
        txt_receive.Text = FormatNumber(receive)
        txt_receive.Select()


    End Sub
    Private Sub pic_1000_Click(sender As Object, e As EventArgs) Handles pic_1000.Click
        add_receive(1000)
    End Sub

    Private Sub pic_500_Click(sender As Object, e As EventArgs) Handles pic_500.Click
        add_receive(500)
    End Sub

    Private Sub pic_100_Click(sender As Object, e As EventArgs) Handles pic_100.Click
        add_receive(100)
    End Sub

    Private Sub pic_50_Click(sender As Object, e As EventArgs) Handles pic_50.Click
        add_receive(50)
    End Sub

    Private Sub pic_20_Click(sender As Object, e As EventArgs) Handles pic_20.Click
        add_receive(20)
    End Sub

    Private Sub pic_10_Click(sender As Object, e As EventArgs) Handles pic_10.Click
        add_receive(10)
    End Sub

    Private Sub txt_refund_TextChanged(sender As Object, e As EventArgs) Handles txt_refund.TextChanged

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        sql = "insert into sale_table (sale_full_id, coffee_id, coffee_amount, coffee_total, date_sale) values"
        Dim i As Integer = frm_coffeeSale.listview_sale.Items.Count - 1
        For j As Integer = 0 To i
            Dim coffee_id As String = frm_coffeeSale.listview_sale.Items(j).SubItems(1).Text
            Dim coffee_amount As Integer = frm_coffeeSale.listview_sale.Items(j).SubItems(4).Text
            Dim coffee_total As Integer = frm_coffeeSale.listview_sale.Items(j).SubItems(6).Text
            Dim date_sale As String = Date.Now.Year & "/" & Date.Now.Month & "/" & Date.Now.Day


            If j = i Then
                sql &= String.Format("('{0}','{1}','{2}','{3}','{4}')", frm_coffeeSale.lbl_sale_id.Text, coffee_id, coffee_amount, coffee_total, date_sale)
            Else
                sql &= String.Format("('{0}','{1}','{2}','{3}','{4}') ,", frm_coffeeSale.lbl_sale_id.Text, coffee_id, coffee_amount, coffee_total, date_sale)
            End If
        Next


        cmd = New SqlClient.SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery = 0 Then
            msg_error("ไม่สามารถบันทึกได้")
        Else

            sql = "insert into sale_detail(sale_full_id, sale_total, discount, discount_condition, sale_net, customer ) values (@sale_full_id, @sale_total, @discount, @discount_condition, @sale_net, @customer)"
            cmd = New SqlClient.SqlCommand(sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("sale_full_id", frm_coffeeSale.lbl_sale_id.Text)
            cmd.Parameters.AddWithValue("sale_total", txt_total.Text)
            cmd.Parameters.AddWithValue("discount", txt_discount.Text)
            cmd.Parameters.AddWithValue("discount_condition", frm_coffeeSale.lbl_condition.Text)
            cmd.Parameters.AddWithValue("sale_net", txt_total.Text)
            cmd.Parameters.AddWithValue("customer", frm_coffeeSale.lbl_username.Text)

            If cmd.ExecuteNonQuery = 0 Then
                msg_error("ไม่สามารถเพิ่มได้")
            Else
                msg_ok("เพิ่มสำเร็จ")

                connect_open()
                sql = "update customer set point+=" & lbl_point.Text & " where username ='" & frm_coffeeSale.lbl_username.Text & "'"
                cmd = New SqlClient.SqlCommand(sql, cn)
                If cmd.ExecuteNonQuery >= 1 Then
                    msg_ok("เพิ่ม Piont สำเร็จ")
                Else
                    msg_error("ไม่สามารถเพิ่ม Point ได้")
                End If

            End If

            End If



        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

        Me.Close()

        frm_coffeeSale.txt_total.Text = "0.00"
        frm_coffeeSale.generate_saleID()
        frm_coffeeSale.lbl_condition.Text = "0"
        frm_coffeeSale.listview_sale.Items.Clear()




    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim col(8) As Integer
        col(1) = 10
        col(2) = 70
        col(3) = 140
        col(4) = 250
        col(5) = 350
        col(6) = 440
        col(7) = 510

        Dim fnt As New Font("Cordia New", 16)
        Dim fnt_bold As New Font("Cordia New", 30, FontStyle.Bold)
        e.Graphics.DrawString("CoffeeshopMD", fnt_bold, Brushes.Red, col(1), 20)
        e.Graphics.DrawLine(Pens.Black, col(1), 80, 650, 80)



        Dim line As Integer = 100


        e.Graphics.DrawString("ลำดับ", fnt, Brushes.Black, col(1), line)
        e.Graphics.DrawString("รหัส", fnt, Brushes.Black, col(2), line)
        e.Graphics.DrawString("รายการ", fnt, Brushes.Black, col(3), line)
        e.Graphics.DrawString("หน่วย", fnt, Brushes.Black, col(4), line)
        e.Graphics.DrawString("จำนวน", fnt, Brushes.Black, col(5), line)
        e.Graphics.DrawString("@ราคา", fnt, Brushes.Black, col(6), line)
        e.Graphics.DrawString("ราคารวม", fnt, Brushes.Black, col(7), line)


        For i As Integer = 0 To frm_coffeeSale.listview_sale.Items.Count - 1
            line += 30
            Dim print_out(8) As String
            With frm_coffeeSale.listview_sale
                print_out(1) = .Items(i).SubItems(0).Text
                print_out(2) = .Items(i).SubItems(1).Text
                print_out(3) = .Items(i).SubItems(2).Text
                print_out(4) = .Items(i).SubItems(3).Text
                print_out(5) = .Items(i).SubItems(4).Text
                print_out(6) = .Items(i).SubItems(5).Text
                print_out(7) = .Items(i).SubItems(6).Text
            End With

            e.Graphics.DrawString(print_out(1), fnt, Brushes.Black, col(1), line)
            e.Graphics.DrawString(print_out(2), fnt, Brushes.Black, col(2), line)
            e.Graphics.DrawString(print_out(3), fnt, Brushes.Black, col(3), line)
            e.Graphics.DrawString(print_out(4), fnt, Brushes.Black, col(4), line)
            e.Graphics.DrawString(print_out(5), fnt, Brushes.Black, col(5), line)
            e.Graphics.DrawString(print_out(6), fnt, Brushes.Black, col(6), line)
            e.Graphics.DrawString(print_out(7), fnt, Brushes.Black, col(7), line)

        Next

        line += 35
        e.Graphics.DrawString("ราคารวม :   " & frm_coffeeSale.txt_total.Text & "บาท", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("ส่วนลด :   " & frm_coffeeSale.lbl_discount.Text & "บาท", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("รวมทั้งสิน :   " & txt_net.Text & "บาท", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("รับเงินมา :   " & txt_receive.Text & "บาท", fnt, Brushes.Black, col(1), line)
        line += 35
        e.Graphics.DrawString("เงินทอน :   " & txt_refund.Text & "บาท", fnt, Brushes.Black, col(1), line)

    End Sub

    Private Sub frm_total_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PrintPreviewDialog1.Document = PrintDocument1
        'PrintPreviewDialog1.ShowDialog()


    End Sub
End Class