<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer_login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_passworf = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.btn_register = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Yi Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(318, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Register"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password :"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(128, 264)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(126, 20)
        Me.txt_username.TabIndex = 4
        '
        'txt_passworf
        '
        Me.txt_passworf.Location = New System.Drawing.Point(126, 308)
        Me.txt_passworf.Name = "txt_passworf"
        Me.txt_passworf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_passworf.Size = New System.Drawing.Size(128, 20)
        Me.txt_passworf.TabIndex = 5
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(113, 356)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(75, 23)
        Me.btn_login.TabIndex = 6
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.coffeeshopMD.My.Resources.Resources.user11
        Me.PictureBox1.Location = New System.Drawing.Point(86, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'date_edit_born
        '
        Me.date_edit_born.Location = New System.Drawing.Point(413, 145)
        Me.date_edit_born.Name = "date_edit_born"
        Me.date_edit_born.Size = New System.Drawing.Size(219, 20)
        Me.date_edit_born.TabIndex = 82
        '
        'txt_edit_nickname
        '
        Me.txt_edit_nickname.Location = New System.Drawing.Point(413, 113)
        Me.txt_edit_nickname.Name = "txt_edit_nickname"
        Me.txt_edit_nickname.Size = New System.Drawing.Size(219, 20)
        Me.txt_edit_nickname.TabIndex = 81
        '
        'txt_edit_address
        '
        Me.txt_edit_address.Location = New System.Drawing.Point(413, 185)
        Me.txt_edit_address.Name = "txt_edit_address"
        Me.txt_edit_address.Size = New System.Drawing.Size(473, 20)
        Me.txt_edit_address.TabIndex = 80
        '
        'txt_edit_tel
        '
        Me.txt_edit_tel.Location = New System.Drawing.Point(413, 223)
        Me.txt_edit_tel.Name = "txt_edit_tel"
        Me.txt_edit_tel.Size = New System.Drawing.Size(219, 20)
        Me.txt_edit_tel.TabIndex = 79
        '
        'txt_edit_username
        '
        Me.txt_edit_username.Location = New System.Drawing.Point(714, 77)
        Me.txt_edit_username.Name = "txt_edit_username"
        Me.txt_edit_username.Size = New System.Drawing.Size(172, 20)
        Me.txt_edit_username.TabIndex = 78
        '
        'txt_edit_password
        '
        Me.txt_edit_password.Location = New System.Drawing.Point(714, 113)
        Me.txt_edit_password.Name = "txt_edit_password"
        Me.txt_edit_password.Size = New System.Drawing.Size(174, 20)
        Me.txt_edit_password.TabIndex = 77
        '
        'txt_edit_name
        '
        Me.txt_edit_name.Location = New System.Drawing.Point(413, 77)
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(219, 20)
        Me.txt_edit_name.TabIndex = 76
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(653, 116)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 13)
        Me.Label17.TabIndex = 75
        Me.Label17.Text = "Password"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(341, 226)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "เบอร์โทร"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(341, 188)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 73
        Me.Label19.Text = "ที่อยู่"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(341, 151)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "วันเกิด"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(341, 116)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 13)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "ชื่อเล่น"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(341, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "ชื่อ - สกุล"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(653, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 13)
        Me.Label23.TabIndex = 69
        Me.Label23.Text = "Username"
        '
        'btn_register
        '
        Me.btn_register.Location = New System.Drawing.Point(512, 267)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(75, 23)
        Me.btn_register.TabIndex = 83
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Location = New System.Drawing.Point(619, 267)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(133, 23)
        Me.btn_back.TabIndex = 84
        Me.btn_back.Text = "Back to staff Login"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'frm_customer_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 400)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_register)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_passworf)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_customer_login"
        Me.Text = "สำหรับลูกค้า"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_passworf As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents btn_register As Button
    Friend WithEvents btn_back As Button
End Class
