Public Class frm_coffeeSale
    Private Sub frm_coffeeSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_coffee()
    End Sub

    Public Sub total_price()
        txt_total.Text = Sum_Column_Currency(listview_sale, 6)
    End Sub

    Public Sub refresh_coffee()
        sql = "select coffee_id, coffee_name, coffee_image from coffee"
        Dim data_table As DataTable = cmd_excuteDataTable()

        Load_Sale_item(ImageList1, listview_coffee, data_table, My.Resources.dufault_coffee, "coffee_image", "coffee_id", "coffee_name")
    End Sub


    Public Sub search_coffee()
        sql = String.Format("select coffee_id, coffee_name, coffee_image from coffee where coffee_id like '%{0}%' OR coffee_name like '%{0}%'", txt_search.Text)
        Dim data_table As DataTable = cmd_excuteDataTable()

        Load_Sale_item(ImageList1, listview_coffee, data_table, My.Resources.dufault_coffee, "coffee_image", "coffee_id", "coffee_name")
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub txt_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search.KeyDown
        If e.KeyData = Keys.Enter Then
            search_coffee()
        End If
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview_sale.SelectedIndexChanged

    End Sub

    Private Sub listview_coffee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listview_coffee.SelectedIndexChanged
        Dim select_coffee As String = listview_coffee.FocusedItem.Text
        Dim coffee_split() As String = select_coffee.Split("|")
        coffee_split(0) = coffee_split(0).ToString.Trim


        sql = "select * from coffee where coffee_id ='" & coffee_split(0) & "'"
        Dim data_table As DataTable = cmd_excuteDataTable()

        Dim hot, cool, spin As Integer
        hot = data_table.Rows(0)("coffee_hot")
        cool = data_table.Rows(0)("coffee_cool")
        spin = data_table.Rows(0)("coffee_spin")
        Dim coffee_id, coffee_name As String
        coffee_id = data_table.Rows(0)("coffee_id")
        coffee_name = data_table.Rows(0)("coffee_name")

        With frm_select_price
            .lbl_hot.Text = hot
            .lbl_cool.Text = cool
            .lbl_spin.Text = spin

            .lbl_coffee_id.Text = coffee_id
            .lbl_coffee_name.Text = coffee_name
        End With

        frm_select_price.TopMost = True
        frm_select_price.Show()
        frm_select_price.txt_amount.Text = ""


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_coffee_id.Text = "" Or txt_coffee_amount.Text = "" Then
            msg_error("ไม่สามารถเว้นว่าง ID หรือค จำนวนได้")
            Return
        End If
        sql = "select * from coffee where coffee_id = '" & txt_coffee_id.Text & "'"
        Dim dts As DataTable = cmd_excuteDataTable()

        Dim arr(7) As String
        arr(0) = listview_coffee.Items.Count + 1
        arr(1) = dts.Rows(0)("coffee_id")
        arr(2) = dts.Rows(0)("coffee_name")
        arr(3) = "แก้ว"
        arr(4) = txt_coffee_amount.Text

        Dim price As Integer
        If rad_hot.Checked = True Then price = dts.Rows(0)("coffee_hot")
        If rad_cool.Checked = True Then price = dts.Rows(0)("coffee_cool")
        If rad_spin.Checked = True Then price = dts.Rows(0)("coffee_spin")

        Dim type_coffee As String = ""
        If rad_hot.Checked = True Then type_coffee = "ร้อน"
        If rad_cool.Checked = True Then type_coffee = "เย็น"
        If rad_spin.Checked = True Then type_coffee = "ปั่น"


        arr(3) &= "/" & type_coffee


        arr(5) = price
        arr(6) = arr(4) * arr(5)
        Dim itm As New ListViewItem(arr)
        listview_sale.Items.Add(itm)
        total_price()

    End Sub

    Private Sub txt_coffee_id_Leave(sender As Object, e As EventArgs) Handles txt_coffee_id.Leave
        sql = "select * from coffee where coffee_id = '" & txt_coffee_id.Text & "'"
        Dim i As Integer = cmd_excuteScalar()
        If i <= 0 And txt_coffee_id.Text <> "" Then
            msg_error("ไม่พบรหัสสินค้านี้ กรุณาแก้ไข หรือเว้นว่างไว้เพื่อยกเลิก")
            txt_coffee_id.Select()
        End If
    End Sub

    Private Sub txt_coffee_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_coffee_id.KeyDown
        If e.KeyData = Keys.Enter Then txt_coffee_amount.Select()
    End Sub

    Private Sub btn_delete_all_Click(sender As Object, e As EventArgs) Handles btn_delete_all.Click
        If confirm("คุณต้องการยกเลิกการขายนี้ หรือไม่ ?") = vbNo Then Return
        listview_sale.Items.Clear()
        txt_total.Text = "0.00"

    End Sub

    Private Sub btn_select_delete_Click(sender As Object, e As EventArgs) Handles btn_select_delete.Click
        If confirm("คุณต้องการจะลบรายการนี้ หรือไม่ ?") = vbYes Then
            listview_sale.Items.Remove(listview_sale.FocusedItem)
            total_price()
        End If
    End Sub
End Class