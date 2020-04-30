<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer_main
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
        Me.txt_edit_point = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.date_edit_born = New System.Windows.Forms.DateTimePicker()
        Me.txt_edit_nickname = New System.Windows.Forms.TextBox()
        Me.txt_edit_address = New System.Windows.Forms.TextBox()
        Me.txt_edit_tel = New System.Windows.Forms.TextBox()
        Me.txt_edit_username = New System.Windows.Forms.TextBox()
        Me.txt_edit_password = New System.Windows.Forms.TextBox()
        Me.txt_edit_name = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btn_use_point = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.txt_coupon_code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_use_point = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.datagrid_bill = New System.Windows.Forms.DataGridView()
        Me.datagrid_list = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.datagrid_bill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagrid_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_edit_point
        '
        Me.txt_edit_point.Location = New System.Drawing.Point(104, 230)
        Me.txt_edit_point.Name = "txt_edit_point"
        Me.txt_edit_point.Size = New System.Drawing.Size(62, 20)
        Me.txt_edit_point.TabIndex = 66
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(32, 233)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "แต้มสะสม"
        '
        'date_edit_born
        '
        Me.date_edit_born.Location = New System.Drawing.Point(106, 103)
        Me.date_edit_born.Name = "date_edit_born"
        Me.date_edit_born.Size = New System.Drawing.Size(219, 20)
        Me.date_edit_born.TabIndex = 64
        '
        'txt_edit_nickname
        '
        Me.txt_edit_nickname.Location = New System.Drawing.Point(106, 71)
        Me.txt_edit_nickname.Name = "txt_edit_nickname"
        Me.txt_edit_nickname.Size = New System.Drawing.Size(219, 20)
        Me.txt_edit_nickname.TabIndex = 63
        '
        'txt_edit_address
        '
        Me.txt_edit_address.Location = New System.Drawing.Point(106, 143)
        Me.txt_edit_address.Name = "txt_edit_address"
        Me.txt_edit_address.Size = New System.Drawing.Size(473, 20)
        Me.txt_edit_address.TabIndex = 62
        '
        'txt_edit_tel
        '
        Me.txt_edit_tel.Location = New System.Drawing.Point(106, 181)
        Me.txt_edit_tel.Name = "txt_edit_tel"
        Me.txt_edit_tel.Size = New System.Drawing.Size(219, 20)
        Me.txt_edit_tel.TabIndex = 61
        '
        'txt_edit_username
        '
        Me.txt_edit_username.Enabled = False
        Me.txt_edit_username.Location = New System.Drawing.Point(407, 35)
        Me.txt_edit_username.Name = "txt_edit_username"
        Me.txt_edit_username.Size = New System.Drawing.Size(172, 20)
        Me.txt_edit_username.TabIndex = 60
        '
        'txt_edit_password
        '
        Me.txt_edit_password.Location = New System.Drawing.Point(407, 71)
        Me.txt_edit_password.Name = "txt_edit_password"
        Me.txt_edit_password.Size = New System.Drawing.Size(174, 20)
        Me.txt_edit_password.TabIndex = 59
        '
        'txt_edit_name
        '
        Me.txt_edit_name.Location = New System.Drawing.Point(106, 35)
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(219, 20)
        Me.txt_edit_name.TabIndex = 58
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(346, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Password"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(34, 184)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "เบอร์โทร"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(34, 146)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "ที่อยู่"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(34, 109)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "วันเกิด"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(34, 74)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 13)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "ชื่อเล่น"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(34, 38)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "ชื่อ - สกุล"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(346, 38)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 13)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "Username"
        '
        'btn_use_point
        '
        Me.btn_use_point.Location = New System.Drawing.Point(172, 229)
        Me.btn_use_point.Name = "btn_use_point"
        Me.btn_use_point.Size = New System.Drawing.Size(79, 20)
        Me.btn_use_point.TabIndex = 68
        Me.btn_use_point.Text = " ใช้แต้มสะสม"
        Me.btn_use_point.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(172, 332)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(122, 37)
        Me.btn_edit.TabIndex = 69
        Me.btn_edit.Text = "บันทึกการแก้ไข"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.Location = New System.Drawing.Point(300, 332)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(122, 37)
        Me.btn_logout.TabIndex = 70
        Me.btn_logout.Text = "ออกจากระบบ"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'txt_coupon_code
        '
        Me.txt_coupon_code.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_coupon_code.Location = New System.Drawing.Point(19, 36)
        Me.txt_coupon_code.Name = "txt_coupon_code"
        Me.txt_coupon_code.Size = New System.Drawing.Size(167, 29)
        Me.txt_coupon_code.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Coupon Code"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_coupon_code)
        Me.Panel1.Location = New System.Drawing.Point(361, 181)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 91)
        Me.Panel1.TabIndex = 73
        '
        'txt_use_point
        '
        Me.txt_use_point.Location = New System.Drawing.Point(257, 229)
        Me.txt_use_point.Name = "txt_use_point"
        Me.txt_use_point.Size = New System.Drawing.Size(62, 20)
        Me.txt_use_point.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "ระบุแต้ม"
        '
        'datagrid_bill
        '
        Me.datagrid_bill.AllowUserToAddRows = False
        Me.datagrid_bill.AllowUserToDeleteRows = False
        Me.datagrid_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_bill.Location = New System.Drawing.Point(626, 55)
        Me.datagrid_bill.Name = "datagrid_bill"
        Me.datagrid_bill.ReadOnly = True
        Me.datagrid_bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_bill.Size = New System.Drawing.Size(346, 171)
        Me.datagrid_bill.TabIndex = 76
        '
        'datagrid_list
        '
        Me.datagrid_list.AllowUserToAddRows = False
        Me.datagrid_list.AllowUserToDeleteRows = False
        Me.datagrid_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_list.Location = New System.Drawing.Point(626, 255)
        Me.datagrid_list.Name = "datagrid_list"
        Me.datagrid_list.ReadOnly = True
        Me.datagrid_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_list.Size = New System.Drawing.Size(346, 153)
        Me.datagrid_list.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(623, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "ใบเสร็จ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(622, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "รายการ"
        '
        'frm_customer_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 442)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.datagrid_list)
        Me.Controls.Add(Me.datagrid_bill)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_use_point)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_use_point)
        Me.Controls.Add(Me.txt_edit_point)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.date_edit_born)
        Me.Controls.Add(Me.txt_edit_nickname)
        Me.Controls.Add(Me.txt_edit_address)
        Me.Controls.Add(Me.txt_edit_tel)
        Me.Controls.Add(Me.txt_edit_username)
        Me.Controls.Add(Me.txt_edit_password)
        Me.Controls.Add(Me.txt_edit_name)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Name = "frm_customer_main"
        Me.Text = "frm_customer_login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.datagrid_bill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagrid_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_edit_point As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents date_edit_born As DateTimePicker
    Friend WithEvents txt_edit_nickname As TextBox
    Friend WithEvents txt_edit_address As TextBox
    Friend WithEvents txt_edit_tel As TextBox
    Friend WithEvents txt_edit_username As TextBox
    Friend WithEvents txt_edit_password As TextBox
    Friend WithEvents txt_edit_name As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btn_use_point As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents txt_coupon_code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_use_point As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents datagrid_bill As DataGridView
    Friend WithEvents datagrid_list As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
