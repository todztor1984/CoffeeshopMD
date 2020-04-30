<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manage_coffee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.datagrid_coffee = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_addnew = New System.Windows.Forms.Button()
        Me.btn_select_picture = New System.Windows.Forms.Button()
        Me.pic_add = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_add_spin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_add_cool = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_add_hot = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_add_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_add_id = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_save_edit = New System.Windows.Forms.Button()
        Me.btn_select_edit_picture = New System.Windows.Forms.Button()
        Me.pic_edit = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_edit_spin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_edit_cool = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_edit_hot = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_edit_name = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_edit_id = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.openfile_coffee = New System.Windows.Forms.OpenFileDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_detele = New System.Windows.Forms.Button()
        Me.txt_confrim = New System.Windows.Forms.TextBox()
        CType(Me.datagrid_coffee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pic_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.pic_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid_coffee
        '
        Me.datagrid_coffee.AllowUserToAddRows = False
        Me.datagrid_coffee.AllowUserToDeleteRows = False
        Me.datagrid_coffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_coffee.Location = New System.Drawing.Point(38, 92)
        Me.datagrid_coffee.Name = "datagrid_coffee"
        Me.datagrid_coffee.ReadOnly = True
        Me.datagrid_coffee.RowHeadersVisible = False
        Me.datagrid_coffee.RowTemplate.Height = 80
        Me.datagrid_coffee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_coffee.Size = New System.Drawing.Size(303, 515)
        Me.datagrid_coffee.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_search.Location = New System.Drawing.Point(125, 55)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(216, 31)
        Me.txt_search.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(347, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(331, 554)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_addnew)
        Me.TabPage1.Controls.Add(Me.btn_select_picture)
        Me.TabPage1.Controls.Add(Me.pic_add)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txt_add_name)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txt_add_id)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(323, 528)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่มเมนูกาแฟ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_addnew
        '
        Me.btn_addnew.Location = New System.Drawing.Point(86, 491)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(85, 24)
        Me.btn_addnew.TabIndex = 13
        Me.btn_addnew.Text = "บันทึก"
        Me.btn_addnew.UseVisualStyleBackColor = True
        '
        'btn_select_picture
        '
        Me.btn_select_picture.Location = New System.Drawing.Point(225, 402)
        Me.btn_select_picture.Name = "btn_select_picture"
        Me.btn_select_picture.Size = New System.Drawing.Size(84, 25)
        Me.btn_select_picture.TabIndex = 12
        Me.btn_select_picture.Text = "เลือกรูปภาพ"
        Me.btn_select_picture.UseVisualStyleBackColor = True
        '
        'pic_add
        '
        Me.pic_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_add.Location = New System.Drawing.Point(45, 347)
        Me.pic_add.Name = "pic_add"
        Me.pic_add.Size = New System.Drawing.Size(170, 138)
        Me.pic_add.TabIndex = 11
        Me.pic_add.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_add_spin)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_add_cool)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_add_hot)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 189)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ราคากาแฟ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ราคาเมนูปั่น :"
        '
        'txt_add_spin
        '
        Me.txt_add_spin.Location = New System.Drawing.Point(117, 129)
        Me.txt_add_spin.Multiline = True
        Me.txt_add_spin.Name = "txt_add_spin"
        Me.txt_add_spin.Size = New System.Drawing.Size(69, 32)
        Me.txt_add_spin.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ราคาเมนูเย็น :"
        '
        'txt_add_cool
        '
        Me.txt_add_cool.Location = New System.Drawing.Point(117, 84)
        Me.txt_add_cool.Multiline = True
        Me.txt_add_cool.Name = "txt_add_cool"
        Me.txt_add_cool.Size = New System.Drawing.Size(69, 32)
        Me.txt_add_cool.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ราคาเมนูร้อน :"
        '
        'txt_add_hot
        '
        Me.txt_add_hot.Location = New System.Drawing.Point(117, 36)
        Me.txt_add_hot.Multiline = True
        Me.txt_add_hot.Name = "txt_add_hot"
        Me.txt_add_hot.Size = New System.Drawing.Size(69, 32)
        Me.txt_add_hot.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ชื่อกาแฟ :"
        '
        'txt_add_name
        '
        Me.txt_add_name.Location = New System.Drawing.Point(103, 92)
        Me.txt_add_name.Multiline = True
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(136, 24)
        Me.txt_add_name.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รหัสเมนู :"
        '
        'txt_add_id
        '
        Me.txt_add_id.Location = New System.Drawing.Point(103, 44)
        Me.txt_add_id.Multiline = True
        Me.txt_add_id.Name = "txt_add_id"
        Me.txt_add_id.Size = New System.Drawing.Size(136, 24)
        Me.txt_add_id.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_save_edit)
        Me.TabPage2.Controls.Add(Me.btn_select_edit_picture)
        Me.TabPage2.Controls.Add(Me.pic_edit)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txt_edit_name)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txt_edit_id)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(323, 528)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไขเมนูกาแฟ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_save_edit
        '
        Me.btn_save_edit.Location = New System.Drawing.Point(91, 482)
        Me.btn_save_edit.Name = "btn_save_edit"
        Me.btn_save_edit.Size = New System.Drawing.Size(85, 24)
        Me.btn_save_edit.TabIndex = 21
        Me.btn_save_edit.Text = "แก้ไข้"
        Me.btn_save_edit.UseVisualStyleBackColor = True
        '
        'btn_select_edit_picture
        '
        Me.btn_select_edit_picture.Location = New System.Drawing.Point(230, 393)
        Me.btn_select_edit_picture.Name = "btn_select_edit_picture"
        Me.btn_select_edit_picture.Size = New System.Drawing.Size(84, 25)
        Me.btn_select_edit_picture.TabIndex = 20
        Me.btn_select_edit_picture.Text = "เลือกรูปภาพ"
        Me.btn_select_edit_picture.UseVisualStyleBackColor = True
        '
        'pic_edit
        '
        Me.pic_edit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_edit.Location = New System.Drawing.Point(50, 338)
        Me.pic_edit.Name = "pic_edit"
        Me.pic_edit.Size = New System.Drawing.Size(170, 138)
        Me.pic_edit.TabIndex = 19
        Me.pic_edit.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_edit_spin)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_edit_cool)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_edit_hot)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(34, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 189)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ราคากาแฟ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 19)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ราคาเมนูปั่น :"
        '
        'txt_edit_spin
        '
        Me.txt_edit_spin.Location = New System.Drawing.Point(117, 129)
        Me.txt_edit_spin.Multiline = True
        Me.txt_edit_spin.Name = "txt_edit_spin"
        Me.txt_edit_spin.Size = New System.Drawing.Size(69, 32)
        Me.txt_edit_spin.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "ราคาเมนูเย็น :"
        '
        'txt_edit_cool
        '
        Me.txt_edit_cool.Location = New System.Drawing.Point(117, 84)
        Me.txt_edit_cool.Multiline = True
        Me.txt_edit_cool.Name = "txt_edit_cool"
        Me.txt_edit_cool.Size = New System.Drawing.Size(69, 32)
        Me.txt_edit_cool.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 19)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "ราคาเมนูร้อน :"
        '
        'txt_edit_hot
        '
        Me.txt_edit_hot.Location = New System.Drawing.Point(117, 36)
        Me.txt_edit_hot.Multiline = True
        Me.txt_edit_hot.Name = "txt_edit_hot"
        Me.txt_edit_hot.Size = New System.Drawing.Size(69, 32)
        Me.txt_edit_hot.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 21)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "ชื่อกาแฟ :"
        '
        'txt_edit_name
        '
        Me.txt_edit_name.Location = New System.Drawing.Point(108, 83)
        Me.txt_edit_name.Multiline = True
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(136, 24)
        Me.txt_edit_name.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(41, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 21)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "รหัสเมนู :"
        '
        'txt_edit_id
        '
        Me.txt_edit_id.Location = New System.Drawing.Point(108, 35)
        Me.txt_edit_id.Multiline = True
        Me.txt_edit_id.Name = "txt_edit_id"
        Me.txt_edit_id.ReadOnly = True
        Me.txt_edit_id.Size = New System.Drawing.Size(136, 24)
        Me.txt_edit_id.TabIndex = 14
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txt_confrim)
        Me.TabPage3.Controls.Add(Me.btn_detele)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(323, 528)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบเมนูกาแฟ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'openfile_coffee
        '
        Me.openfile_coffee.Filter = "JPEG | *.jpg"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(47, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(236, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "กรุณาพิมพ์คำว่า ""ยืนยันการลบ"" ลงในช่องด้านล่าง"
        '
        'btn_detele
        '
        Me.btn_detele.Location = New System.Drawing.Point(88, 209)
        Me.btn_detele.Name = "btn_detele"
        Me.btn_detele.Size = New System.Drawing.Size(158, 49)
        Me.btn_detele.TabIndex = 8
        Me.btn_detele.Text = "ลบ"
        Me.btn_detele.UseVisualStyleBackColor = True
        '
        'txt_confrim
        '
        Me.txt_confrim.Location = New System.Drawing.Point(76, 153)
        Me.txt_confrim.Multiline = True
        Me.txt_confrim.Name = "txt_confrim"
        Me.txt_confrim.Size = New System.Drawing.Size(183, 30)
        Me.txt_confrim.TabIndex = 9
        '
        'frm_manage_coffee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 622)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datagrid_coffee)
        Me.Name = "frm_manage_coffee"
        Me.Text = "จัดการกาแฟ"
        CType(Me.datagrid_coffee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pic_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.pic_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datagrid_coffee As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_add_id As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_add_spin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_add_cool As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_add_hot As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_add_name As TextBox
    Friend WithEvents btn_select_picture As Button
    Friend WithEvents pic_add As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_addnew As Button
    Friend WithEvents openfile_coffee As OpenFileDialog
    Friend WithEvents btn_save_edit As Button
    Friend WithEvents btn_select_edit_picture As Button
    Friend WithEvents pic_edit As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_edit_spin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_edit_cool As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_edit_hot As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_edit_name As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_edit_id As TextBox
    Friend WithEvents txt_confrim As TextBox
    Friend WithEvents btn_detele As Button
    Friend WithEvents Label12 As Label
End Class
