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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_delete_all = New System.Windows.Forms.Button()
        Me.btn_select_delete = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
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
        Me.listview_coffee.Location = New System.Drawing.Point(21, 93)
        Me.listview_coffee.Name = "listview_coffee"
        Me.listview_coffee.Size = New System.Drawing.Size(353, 359)
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
        Me.listview_sale.Location = New System.Drawing.Point(0, 147)
        Me.listview_sale.Name = "listview_sale"
        Me.listview_sale.Size = New System.Drawing.Size(503, 313)
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
        Me.Panel6.Controls.Add(Me.Button3)
        Me.Panel6.Controls.Add(Me.btn_delete_all)
        Me.Panel6.Controls.Add(Me.btn_select_delete)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 460)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(503, 44)
        Me.Panel6.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(392, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 25)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "คิดเงิน"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_delete_all
        '
        Me.btn_delete_all.Location = New System.Drawing.Point(113, 11)
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
        Me.Panel5.Size = New System.Drawing.Size(503, 51)
        Me.Panel5.TabIndex = 11
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
    Friend WithEvents Button3 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
End Class
