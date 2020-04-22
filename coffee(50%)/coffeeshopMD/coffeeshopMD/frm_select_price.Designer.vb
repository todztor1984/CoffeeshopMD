<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_select_price
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
        Me.rad_hot = New System.Windows.Forms.RadioButton()
        Me.rad_cool = New System.Windows.Forms.RadioButton()
        Me.rad_spin = New System.Windows.Forms.RadioButton()
        Me.lbl_hot = New System.Windows.Forms.Label()
        Me.lbl_spin = New System.Windows.Forms.Label()
        Me.lbl_cool = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_coffee_id = New System.Windows.Forms.Label()
        Me.lbl_coffee_name = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rad_hot
        '
        Me.rad_hot.AutoSize = True
        Me.rad_hot.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_hot.Location = New System.Drawing.Point(25, 18)
        Me.rad_hot.Name = "rad_hot"
        Me.rad_hot.Size = New System.Drawing.Size(51, 25)
        Me.rad_hot.TabIndex = 0
        Me.rad_hot.TabStop = True
        Me.rad_hot.Text = "ร้อน"
        Me.rad_hot.UseVisualStyleBackColor = True
        '
        'rad_cool
        '
        Me.rad_cool.AutoSize = True
        Me.rad_cool.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_cool.Location = New System.Drawing.Point(25, 69)
        Me.rad_cool.Name = "rad_cool"
        Me.rad_cool.Size = New System.Drawing.Size(49, 25)
        Me.rad_cool.TabIndex = 1
        Me.rad_cool.TabStop = True
        Me.rad_cool.Text = "เย็น"
        Me.rad_cool.UseVisualStyleBackColor = True
        '
        'rad_spin
        '
        Me.rad_spin.AutoSize = True
        Me.rad_spin.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_spin.Location = New System.Drawing.Point(25, 122)
        Me.rad_spin.Name = "rad_spin"
        Me.rad_spin.Size = New System.Drawing.Size(46, 25)
        Me.rad_spin.TabIndex = 2
        Me.rad_spin.TabStop = True
        Me.rad_spin.Text = "ปั่น"
        Me.rad_spin.UseVisualStyleBackColor = True
        '
        'lbl_hot
        '
        Me.lbl_hot.AutoSize = True
        Me.lbl_hot.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hot.Location = New System.Drawing.Point(92, 20)
        Me.lbl_hot.Name = "lbl_hot"
        Me.lbl_hot.Size = New System.Drawing.Size(21, 21)
        Me.lbl_hot.TabIndex = 3
        Me.lbl_hot.Text = "0"
        '
        'lbl_spin
        '
        Me.lbl_spin.AutoSize = True
        Me.lbl_spin.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_spin.Location = New System.Drawing.Point(92, 124)
        Me.lbl_spin.Name = "lbl_spin"
        Me.lbl_spin.Size = New System.Drawing.Size(21, 21)
        Me.lbl_spin.TabIndex = 4
        Me.lbl_spin.Text = "0"
        '
        'lbl_cool
        '
        Me.lbl_cool.AutoSize = True
        Me.lbl_cool.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cool.Location = New System.Drawing.Point(92, 71)
        Me.lbl_cool.Name = "lbl_cool"
        Me.lbl_cool.Size = New System.Drawing.Size(21, 21)
        Me.lbl_cool.TabIndex = 5
        Me.lbl_cool.Text = "0"
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_select.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_select.Location = New System.Drawing.Point(80, 321)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(105, 40)
        Me.btn_select.TabIndex = 6
        Me.btn_select.Text = "เลือก"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "บาท"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "บาท"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "บาท"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "รหัส :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "รายการ :"
        '
        'lbl_coffee_id
        '
        Me.lbl_coffee_id.AutoSize = True
        Me.lbl_coffee_id.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_coffee_id.Location = New System.Drawing.Point(85, 21)
        Me.lbl_coffee_id.Name = "lbl_coffee_id"
        Me.lbl_coffee_id.Size = New System.Drawing.Size(21, 21)
        Me.lbl_coffee_id.TabIndex = 12
        Me.lbl_coffee_id.Text = "0"
        '
        'lbl_coffee_name
        '
        Me.lbl_coffee_name.AutoSize = True
        Me.lbl_coffee_name.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_coffee_name.Location = New System.Drawing.Point(85, 49)
        Me.lbl_coffee_name.Name = "lbl_coffee_name"
        Me.lbl_coffee_name.Size = New System.Drawing.Size(21, 21)
        Me.lbl_coffee_name.TabIndex = 13
        Me.lbl_coffee_name.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_cool)
        Me.GroupBox1.Controls.Add(Me.lbl_spin)
        Me.GroupBox1.Controls.Add(Me.lbl_hot)
        Me.GroupBox1.Controls.Add(Me.rad_spin)
        Me.GroupBox1.Controls.Add(Me.rad_cool)
        Me.GroupBox1.Controls.Add(Me.rad_hot)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 177)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 282)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "จำนวน"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(95, 282)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(70, 20)
        Me.txt_amount.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(173, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "แก้ว"
        '
        'frm_select_price
        '
        Me.AcceptButton = Me.btn_select
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_coffee_name)
        Me.Controls.Add(Me.lbl_coffee_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_select)
        Me.Name = "frm_select_price"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกราคา"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rad_hot As RadioButton
    Friend WithEvents rad_cool As RadioButton
    Friend WithEvents rad_spin As RadioButton
    Friend WithEvents lbl_hot As Label
    Friend WithEvents lbl_spin As Label
    Friend WithEvents lbl_cool As Label
    Friend WithEvents btn_select As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_coffee_id As Label
    Friend WithEvents lbl_coffee_name As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_amount As TextBox
    Friend WithEvents Label7 As Label
End Class
