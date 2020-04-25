<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_usepromotion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_active = New System.Windows.Forms.Button()
        Me.txt_coupon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_discount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_active)
        Me.GroupBox1.Controls.Add(Me.txt_coupon)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Coupon"
        '
        'btn_active
        '
        Me.btn_active.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_active.Location = New System.Drawing.Point(152, 145)
        Me.btn_active.Name = "btn_active"
        Me.btn_active.Size = New System.Drawing.Size(98, 35)
        Me.btn_active.TabIndex = 1
        Me.btn_active.Text = "Active"
        Me.btn_active.UseVisualStyleBackColor = True
        '
        'txt_coupon
        '
        Me.txt_coupon.Location = New System.Drawing.Point(17, 30)
        Me.txt_coupon.Multiline = True
        Me.txt_coupon.Name = "txt_coupon"
        Me.txt_coupon.Size = New System.Drawing.Size(393, 99)
        Me.txt_coupon.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ส่วนลดที่ท่านได้รับ คือ"
        '
        'lbl_condition
        '
        Me.lbl_condition.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_condition.Location = New System.Drawing.Point(230, 252)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(179, 32)
        Me.lbl_condition.TabIndex = 3
        Me.lbl_condition.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ส่วนลดที่ท่านได้รับ คือ"
        '
        'lbl_discount
        '
        Me.lbl_discount.AutoSize = True
        Me.lbl_discount.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount.Location = New System.Drawing.Point(230, 295)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(25, 21)
        Me.lbl_discount.TabIndex = 5
        Me.lbl_discount.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "บาท"
        '
        'btn_confirm
        '
        Me.btn_confirm.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.Location = New System.Drawing.Point(132, 334)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(75, 30)
        Me.btn_confirm.TabIndex = 7
        Me.btn_confirm.Text = "ยืนยัน"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(234, 334)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 30)
        Me.btn_close.TabIndex = 8
        Me.btn_close.Text = "ปิด"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'frm_usepromotion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 404)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_discount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_condition)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_usepromotion"
        Me.Text = "ใช้คูปอง"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_active As Button
    Friend WithEvents txt_coupon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_condition As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_discount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_close As Button
End Class
