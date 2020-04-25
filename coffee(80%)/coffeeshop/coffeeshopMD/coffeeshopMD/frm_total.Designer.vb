<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_total
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_total))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_receive = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_refund = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pic_10 = New System.Windows.Forms.PictureBox()
        Me.pic_20 = New System.Windows.Forms.PictureBox()
        Me.pic_50 = New System.Windows.Forms.PictureBox()
        Me.pic_100 = New System.Windows.Forms.PictureBox()
        Me.pic_500 = New System.Windows.Forms.PictureBox()
        Me.pic_1000 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_discount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_net = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lbl_add_point = New System.Windows.Forms.Label()
        Me.lbl_point = New System.Windows.Forms.Label()
        Me.lbl_add_p = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_1000, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รวมทั้งสิ้น"
        '
        'txt_total
        '
        Me.txt_total.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Yi Baiti", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.White
        Me.txt_total.Location = New System.Drawing.Point(126, 37)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(266, 73)
        Me.txt_total.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(409, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "บาท"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(409, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "บาท"
        '
        'txt_receive
        '
        Me.txt_receive.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_receive.Font = New System.Drawing.Font("Microsoft Yi Baiti", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receive.ForeColor = System.Drawing.Color.White
        Me.txt_receive.Location = New System.Drawing.Point(126, 277)
        Me.txt_receive.Name = "txt_receive"
        Me.txt_receive.Size = New System.Drawing.Size(266, 73)
        Me.txt_receive.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "รับเงินมา"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(409, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 33)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "บาท"
        '
        'txt_refund
        '
        Me.txt_refund.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_refund.Font = New System.Drawing.Font("Microsoft Yi Baiti", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refund.ForeColor = System.Drawing.Color.Red
        Me.txt_refund.Location = New System.Drawing.Point(126, 360)
        Me.txt_refund.Name = "txt_refund"
        Me.txt_refund.ReadOnly = True
        Me.txt_refund.Size = New System.Drawing.Size(266, 73)
        Me.txt_refund.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 381)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 33)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "เงินทอน"
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(144, 501)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 42)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "ยืนยัน"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(255, 501)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(94, 42)
        Me.btn_close.TabIndex = 10
        Me.btn_close.Text = "ปิด"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pic_10)
        Me.GroupBox1.Controls.Add(Me.pic_20)
        Me.GroupBox1.Controls.Add(Me.pic_50)
        Me.GroupBox1.Controls.Add(Me.pic_100)
        Me.GroupBox1.Controls.Add(Me.pic_500)
        Me.GroupBox1.Controls.Add(Me.pic_1000)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(521, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 342)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ธนบัตร"
        '
        'pic_10
        '
        Me.pic_10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_10.Image = CType(resources.GetObject("pic_10.Image"), System.Drawing.Image)
        Me.pic_10.Location = New System.Drawing.Point(261, 213)
        Me.pic_10.Name = "pic_10"
        Me.pic_10.Size = New System.Drawing.Size(76, 73)
        Me.pic_10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_10.TabIndex = 16
        Me.pic_10.TabStop = False
        '
        'pic_20
        '
        Me.pic_20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_20.Image = CType(resources.GetObject("pic_20.Image"), System.Drawing.Image)
        Me.pic_20.Location = New System.Drawing.Point(40, 213)
        Me.pic_20.Name = "pic_20"
        Me.pic_20.Size = New System.Drawing.Size(167, 73)
        Me.pic_20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_20.TabIndex = 15
        Me.pic_20.TabStop = False
        '
        'pic_50
        '
        Me.pic_50.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_50.Image = CType(resources.GetObject("pic_50.Image"), System.Drawing.Image)
        Me.pic_50.Location = New System.Drawing.Point(213, 134)
        Me.pic_50.Name = "pic_50"
        Me.pic_50.Size = New System.Drawing.Size(167, 73)
        Me.pic_50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_50.TabIndex = 14
        Me.pic_50.TabStop = False
        '
        'pic_100
        '
        Me.pic_100.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_100.Image = CType(resources.GetObject("pic_100.Image"), System.Drawing.Image)
        Me.pic_100.Location = New System.Drawing.Point(40, 134)
        Me.pic_100.Name = "pic_100"
        Me.pic_100.Size = New System.Drawing.Size(167, 73)
        Me.pic_100.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_100.TabIndex = 13
        Me.pic_100.TabStop = False
        '
        'pic_500
        '
        Me.pic_500.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_500.Image = CType(resources.GetObject("pic_500.Image"), System.Drawing.Image)
        Me.pic_500.Location = New System.Drawing.Point(213, 55)
        Me.pic_500.Name = "pic_500"
        Me.pic_500.Size = New System.Drawing.Size(167, 73)
        Me.pic_500.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_500.TabIndex = 12
        Me.pic_500.TabStop = False
        '
        'pic_1000
        '
        Me.pic_1000.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_1000.Image = CType(resources.GetObject("pic_1000.Image"), System.Drawing.Image)
        Me.pic_1000.Location = New System.Drawing.Point(40, 55)
        Me.pic_1000.Name = "pic_1000"
        Me.pic_1000.Size = New System.Drawing.Size(167, 73)
        Me.pic_1000.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_1000.TabIndex = 11
        Me.pic_1000.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(409, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 33)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "บาท"
        '
        'txt_discount
        '
        Me.txt_discount.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_discount.Font = New System.Drawing.Font("Microsoft Yi Baiti", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discount.ForeColor = System.Drawing.Color.White
        Me.txt_discount.Location = New System.Drawing.Point(126, 119)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.ReadOnly = True
        Me.txt_discount.Size = New System.Drawing.Size(266, 73)
        Me.txt_discount.TabIndex = 19
        Me.txt_discount.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 33)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "ส่วนลด"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(409, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 33)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "บาท"
        '
        'txt_net
        '
        Me.txt_net.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_net.Font = New System.Drawing.Font("Microsoft Yi Baiti", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_net.ForeColor = System.Drawing.Color.White
        Me.txt_net.Location = New System.Drawing.Point(126, 198)
        Me.txt_net.Name = "txt_net"
        Me.txt_net.ReadOnly = True
        Me.txt_net.Size = New System.Drawing.Size(266, 73)
        Me.txt_net.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 33)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "ทั้งหมด"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'lbl_add_point
        '
        Me.lbl_add_point.AutoSize = True
        Me.lbl_add_point.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add_point.ForeColor = System.Drawing.Color.Red
        Me.lbl_add_point.Location = New System.Drawing.Point(144, 459)
        Me.lbl_add_point.Name = "lbl_add_point"
        Me.lbl_add_point.Size = New System.Drawing.Size(101, 24)
        Me.lbl_add_point.TabIndex = 24
        Me.lbl_add_point.Text = "ได้แต้มสะสม :"
        '
        'lbl_point
        '
        Me.lbl_point.AutoSize = True
        Me.lbl_point.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_point.ForeColor = System.Drawing.Color.Red
        Me.lbl_point.Location = New System.Drawing.Point(251, 459)
        Me.lbl_point.Name = "lbl_point"
        Me.lbl_point.Size = New System.Drawing.Size(22, 24)
        Me.lbl_point.TabIndex = 25
        Me.lbl_point.Text = "0"
        '
        'lbl_add_p
        '
        Me.lbl_add_p.AutoSize = True
        Me.lbl_add_p.Font = New System.Drawing.Font("Microsoft Yi Baiti", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_add_p.ForeColor = System.Drawing.Color.Red
        Me.lbl_add_p.Location = New System.Drawing.Point(279, 459)
        Me.lbl_add_p.Name = "lbl_add_p"
        Me.lbl_add_p.Size = New System.Drawing.Size(39, 24)
        Me.lbl_add_p.TabIndex = 26
        Me.lbl_add_p.Text = "แต้ม"
        '
        'frm_total
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 570)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_add_p)
        Me.Controls.Add(Me.lbl_point)
        Me.Controls.Add(Me.lbl_add_point)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_net)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_discount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_refund)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_receive)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_total"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "คิดเงิน"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pic_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_1000, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_receive As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_refund As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents pic_1000 As PictureBox
    Friend WithEvents pic_500 As PictureBox
    Friend WithEvents pic_100 As PictureBox
    Friend WithEvents pic_50 As PictureBox
    Friend WithEvents pic_20 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pic_10 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_discount As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_net As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents lbl_add_point As Label
    Friend WithEvents lbl_point As Label
    Friend WithEvents lbl_add_p As Label
End Class
