<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_coffeeSale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.listview_coffee = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.listview_sale = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_promotion = New System.Windows.Forms.Button()
        Me.btn_purchase = New System.Windows.Forms.Button()
        Me.btn_delete_all = New System.Windows.Forms.Button()
        Me.btn_select_delete = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_date_sale = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_sale_id = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.rad_spin = New System.Windows.Forms.RadioButton()
        Me.rad_cool = New System.Windows.Forms.RadioButton()
        Me.rad_hot = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_coffee_amount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_coffee_id = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_point = New System.Windows.Forms.Label()
        Me.link_select_customer = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_customer_clear = New System.Windows.Forms.LinkLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.listview_coffee)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(503, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 504)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(386, 71)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ค้นหา"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(58, 30)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(266, 20)
        Me.txt_search.TabIndex = 0
        '
        'listview_coffee
        '
        Me.listview_coffee.HideSelection = False
        Me.listview_coffee.LargeImageList = Me.ImageList1
        Me.listview_coffee.Location = New System.Drawing.Point(21, 77)
        Me.listview_coffee.Name = "listview_coffee"
        Me.listview_coffee.Size = New System.Drawing.Size(353, 321)
        Me.listview_coffee.TabIndex = 0
        Me.listview_coffee.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(100, 70)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.listview_sale)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 504)
        Me.Panel3.TabIndex = 1
        '
        'listview_sale
        '
        Me.listview_sale.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.listview_sale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listview_sale.FullRowSelect = True
        Me.listview_sale.GridLines = True
        Me.listview_sale.HideSelection = False
        Me.listview_sale.Location = New System.Drawing.Point(0, 193)
        Me.listview_sale.Name = "listview_sale"
        Me.listview_sale.Size = New System.Drawing.Size(503, 267)
        Me.listview_sale.TabIndex = 1
        Me.listview_sale.UseCompatibleStateImageBehavior = False
        Me.listview_sale.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "*"
        Me.ColumnHeader1.Width = 34
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "รหัสสินค้า"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 62
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "รายการ"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 131
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "หน่วย"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "จำนวน"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "@ราคา"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "ราคารวม"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btn_promotion)
        Me.Panel6.Controls.Add(Me.btn_purchase)
        Me.Panel6.Controls.Add(Me.btn_delete_all)
        Me.Panel6.Controls.Add(Me.btn_select_delete)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 460)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(503, 44)
        Me.Panel6.TabIndex = 12
        '
        'btn_promotion
        '
        Me.btn_promotion.Location = New System.Drawing.Point(184, 12)
        Me.btn_promotion.Name = "btn_promotion"
        Me.btn_promotion.Size = New System.Drawing.Size(75, 23)
        Me.btn_promotion.TabIndex = 5
        Me.btn_promotion.Text = "Promotion"
        Me.btn_promotion.UseVisualStyleBackColor = True
        '
        'btn_purchase
        '
        Me.btn_purchase.Location = New System.Drawing.Point(392, 11)
        Me.btn_purchase.Name = "btn_purchase"
        Me.btn_purchase.Size = New System.Drawing.Size(80, 25)
        Me.btn_purchase.TabIndex = 4
        Me.btn_purchase.Text = "คิดเงิน"
        Me.btn_purchase.UseVisualStyleBackColor = True
        '
        'btn_delete_all
        '
        Me.btn_delete_all.Location = New System.Drawing.Point(98, 11)
        Me.btn_delete_all.Name = "btn_delete_all"
        Me.btn_delete_all.Size = New System.Drawing.Size(80, 25)
        Me.btn_delete_all.TabIndex = 3
        Me.btn_delete_all.Text = "ลบทั้งหมด"
        Me.btn_delete_all.UseVisualStyleBackColor = True
        '
        'btn_select_delete
        '
        Me.btn_select_delete.Location = New System.Drawing.Point(12, 11)
        Me.btn_select_delete.Name = "btn_select_delete"
        Me.btn_select_delete.Size = New System.Drawing.Size(80, 25)
        Me.btn_select_delete.TabIndex = 2
        Me.btn_select_delete.Text = "ลบที่เลือก"
        Me.btn_select_delete.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbl_condition)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lbl_discount)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.lbl_date_sale)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lbl_sale_id)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.btn_add)
        Me.Panel5.Controls.Add(Me.rad_spin)
        Me.Panel5.Controls.Add(Me.rad_cool)
        Me.Panel5.Controls.Add(Me.rad_hot)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txt_coffee_amount)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.txt_coffee_id)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 96)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(503, 97)
        Me.Panel5.TabIndex = 11
        '
        'lbl_condition
        '
        Me.lbl_condition.AutoSize = True
        Me.lbl_condition.Location = New System.Drawing.Point(251, 72)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(16, 13)
        Me.lbl_condition.TabIndex = 19
        Me.lbl_condition.Text = "..."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(199, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "เงื่อนไข :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(110, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "บาท"
        '
        'lbl_discount
        '
        Me.lbl_discount.AutoSize = True
        Me.lbl_discount.Location = New System.Drawing.Point(73, 72)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(13, 13)
        Me.lbl_discount.TabIndex = 16
        Me.lbl_discount.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ส่วนลด :"
        '
        'lbl_date_sale
        '
        Me.lbl_date_sale.AutoSize = True
        Me.lbl_date_sale.Location = New System.Drawing.Point(307, 48)
        Me.lbl_date_sale.Name = "lbl_date_sale"
        Me.lbl_date_sale.Size = New System.Drawing.Size(16, 13)
        Me.lbl_date_sale.TabIndex = 14
        Me.lbl_date_sale.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(210, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "วัน/เดือน/ปี ขาย :"
        '
        'lbl_sale_id
        '
        Me.lbl_sale_id.AutoSize = True
        Me.lbl_sale_id.Location = New System.Drawing.Point(95, 48)
        Me.lbl_sale_id.Name = "lbl_sale_id"
        Me.lbl_sale_id.Size = New System.Drawing.Size(19, 13)
        Me.lbl_sale_id.TabIndex = 12
        Me.lbl_sale_id.Text = "...."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "รหัสการขาย :"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(425, 15)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(55, 25)
        Me.btn_add.TabIndex = 10
        Me.btn_add.Text = "เพิ่ม"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'rad_spin
        '
        Me.rad_spin.AutoSize = True
        Me.rad_spin.Location = New System.Drawing.Point(379, 18)
        Me.rad_spin.Name = "rad_spin"
        Me.rad_spin.Size = New System.Drawing.Size(40, 17)
        Me.rad_spin.TabIndex = 9
        Me.rad_spin.Text = "ปั่น"
        Me.rad_spin.UseVisualStyleBackColor = True
        '
        'rad_cool
        '
        Me.rad_cool.AutoSize = True
        Me.rad_cool.Location = New System.Drawing.Point(328, 18)
        Me.rad_cool.Name = "rad_cool"
        Me.rad_cool.Size = New System.Drawing.Size(45, 17)
        Me.rad_cool.TabIndex = 8
        Me.rad_cool.Text = "เย็น"
        Me.rad_cool.UseVisualStyleBackColor = True
        '
        'rad_hot
        '
        Me.rad_hot.AutoSize = True
        Me.rad_hot.Checked = True
        Me.rad_hot.Location = New System.Drawing.Point(277, 18)
        Me.rad_hot.Name = "rad_hot"
        Me.rad_hot.Size = New System.Drawing.Size(45, 17)
        Me.rad_hot.TabIndex = 7
        Me.rad_hot.TabStop = True
        Me.rad_hot.Text = "ร้อน"
        Me.rad_hot.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(157, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "จำนวน"
        '
        'txt_coffee_amount
        '
        Me.txt_coffee_amount.Location = New System.Drawing.Point(202, 15)
        Me.txt_coffee_amount.Multiline = True
        Me.txt_coffee_amount.Name = "txt_coffee_amount"
        Me.txt_coffee_amount.Size = New System.Drawing.Size(63, 20)
        Me.txt_coffee_amount.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รหัสสินค้า"
        '
        'txt_coffee_id
        '
        Me.txt_coffee_id.Location = New System.Drawing.Point(59, 15)
        Me.txt_coffee_id.Multiline = True
        Me.txt_coffee_id.Name = "txt_coffee_id"
        Me.txt_coffee_id.Size = New System.Drawing.Size(86, 20)
        Me.txt_coffee_id.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_total)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(503, 96)
        Me.Panel4.TabIndex = 0
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_total.Font = New System.Drawing.Font("MingLiU-ExtB", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.White
        Me.txt_total.Location = New System.Drawing.Point(0, 0)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(503, 123)
        Me.txt_total.TabIndex = 2
        Me.txt_total.Text = "0.00"
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btn_customer_clear)
        Me.Panel7.Controls.Add(Me.link_select_customer)
        Me.Panel7.Controls.Add(Me.lbl_point)
        Me.Panel7.Controls.Add(Me.lbl_name)
        Me.Panel7.Controls.Add(Me.lbl_username)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 404)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(386, 100)
        Me.Panel7.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(107, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Username :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(107, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Name :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(307, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 16)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Point :"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(189, 21)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(20, 16)
        Me.lbl_username.TabIndex = 4
        Me.lbl_username.Text = "..."
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft Yi Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(189, 47)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(20, 16)
        Me.lbl_name.TabIndex = 5
        Me.lbl_name.Text = "..."
        '
        'lbl_point
        '
        Me.lbl_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_point.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_point.Location = New System.Drawing.Point(310, 41)
        Me.lbl_point.Name = "lbl_point"
        Me.lbl_point.Size = New System.Drawing.Size(52, 42)
        Me.lbl_point.TabIndex = 6
        Me.lbl_point.Text = "0"
        Me.lbl_point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'link_select_customer
        '
        Me.link_select_customer.AutoSize = True
        Me.link_select_customer.Location = New System.Drawing.Point(107, 79)
        Me.link_select_customer.Name = "link_select_customer"
        Me.link_select_customer.Size = New System.Drawing.Size(37, 13)
        Me.link_select_customer.TabIndex = 7
        Me.link_select_customer.TabStop = True
        Me.link_select_customer.Text = "Select"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.coffeeshopMD.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(21, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_customer_clear
        '
        Me.btn_customer_clear.AutoSize = True
        Me.btn_customer_clear.Location = New System.Drawing.Point(161, 79)
        Me.btn_customer_clear.Name = "btn_customer_clear"
        Me.btn_customer_clear.Size = New System.Drawing.Size(31, 13)
        Me.btn_customer_clear.TabIndex = 8
        Me.btn_customer_clear.TabStop = True
        Me.btn_customer_clear.Text = "Clear"
        '
        'frm_coffeeSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 504)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_coffeeSale"
        Me.Text = "frm_coffeeSale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents listview_coffee As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_delete_all As Button
    Friend WithEvents btn_select_delete As Button
    Friend WithEvents listview_sale As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txt_total As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents rad_spin As RadioButton
    Friend WithEvents rad_cool As RadioButton
    Friend WithEvents rad_hot As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_coffee_amount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_coffee_id As TextBox
    Friend WithEvents btn_purchase As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_date_sale As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_sale_id As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_promotion As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_condition As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_point As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents link_select_customer As LinkLabel
    Friend WithEvents btn_customer_clear As LinkLabel
End Class
