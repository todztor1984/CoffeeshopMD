<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
Partial Class frm_login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
<<<<<<< HEAD
    <System.Diagnostics.DebuggerNonUserCode()>
=======
    <System.Diagnostics.DebuggerNonUserCode()> _
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
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
<<<<<<< HEAD
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lbl_security_code = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_remember = New System.Windows.Forms.CheckBox()
        Me.txt_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_security_code = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
=======
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lbl_security_code = New System.Windows.Forms.Label()
        Me.txt_security_code = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_remember = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Cordia New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรดเข้าสู่ระบบ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_username.Location = New System.Drawing.Point(186, 114)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(219, 31)
        Me.txt_username.TabIndex = 3
        '
        'txt_password
        '
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_password.Location = New System.Drawing.Point(186, 177)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_password.Size = New System.Drawing.Size(219, 31)
        Me.txt_password.TabIndex = 4
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_login.Font = New System.Drawing.Font("MingLiU-ExtB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_login.Location = New System.Drawing.Point(58, 331)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(136, 46)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exit.Font = New System.Drawing.Font("MingLiU-ExtB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_exit.Location = New System.Drawing.Point(238, 331)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(136, 46)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
<<<<<<< HEAD
        Me.CheckBox1.Location = New System.Drawing.Point(426, 331)
=======
        Me.CheckBox1.Location = New System.Drawing.Point(199, 214)
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "แสดง Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'lbl_security_code
        '
        Me.lbl_security_code.BackColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.lbl_security_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_security_code.Location = New System.Drawing.Point(505, 418)
        Me.lbl_security_code.Name = "lbl_security_code"
        Me.lbl_security_code.Size = New System.Drawing.Size(142, 34)
=======
        Me.lbl_security_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbl_security_code.Location = New System.Drawing.Point(243, 249)
        Me.lbl_security_code.Name = "lbl_security_code"
        Me.lbl_security_code.Size = New System.Drawing.Size(162, 34)
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
        Me.lbl_security_code.TabIndex = 8
        Me.lbl_security_code.Text = "SC"
        Me.lbl_security_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
<<<<<<< HEAD
=======
        'txt_security_code
        '
        Me.txt_security_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_security_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_security_code.Location = New System.Drawing.Point(231, 288)
        Me.txt_security_code.Name = "txt_security_code"
        Me.txt_security_code.Size = New System.Drawing.Size(197, 31)
        Me.txt_security_code.TabIndex = 9
        '
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
<<<<<<< HEAD
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(487, 376)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 29)
=======
        Me.Label5.Font = New System.Drawing.Font("Tempus Sans ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 38)
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Security Code"
        '
        'chk_remember
        '
        Me.chk_remember.AutoSize = True
        Me.chk_remember.BackColor = System.Drawing.Color.White
        Me.chk_remember.ForeColor = System.Drawing.Color.Black
<<<<<<< HEAD
        Me.chk_remember.Location = New System.Drawing.Point(425, 221)
=======
        Me.chk_remember.Location = New System.Drawing.Point(199, 151)
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
        Me.chk_remember.Name = "chk_remember"
        Me.chk_remember.Size = New System.Drawing.Size(128, 17)
        Me.chk_remember.TabIndex = 12
        Me.chk_remember.Text = "Remember Username"
        Me.chk_remember.UseVisualStyleBackColor = False
        '
<<<<<<< HEAD
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.White
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.Color.Black
        Me.txt_password.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txt_password.HintText = "Type Your Password"
        Me.txt_password.isPassword = False
        Me.txt_password.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txt_password.LineIdleColor = System.Drawing.Color.Black
        Me.txt_password.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txt_password.LineThickness = 3
        Me.txt_password.Location = New System.Drawing.Point(425, 271)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(304, 39)
        Me.txt_password.TabIndex = 16
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.White
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.Color.Black
        Me.txt_username.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txt_username.HintText = "Type Your Username"
        Me.txt_username.isPassword = False
        Me.txt_username.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txt_username.LineIdleColor = System.Drawing.Color.Black
        Me.txt_username.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txt_username.LineThickness = 3
        Me.txt_username.Location = New System.Drawing.Point(425, 175)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(303, 39)
        Me.txt_username.TabIndex = 17
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_security_code
        '
        Me.txt_security_code.BackColor = System.Drawing.Color.White
        Me.txt_security_code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_security_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_security_code.ForeColor = System.Drawing.Color.Black
        Me.txt_security_code.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.txt_security_code.HintText = "Security Code"
        Me.txt_security_code.isPassword = False
        Me.txt_security_code.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txt_security_code.LineIdleColor = System.Drawing.Color.Black
        Me.txt_security_code.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txt_security_code.LineThickness = 3
        Me.txt_security_code.Location = New System.Drawing.Point(425, 456)
        Me.txt_security_code.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_security_code.Name = "txt_security_code"
        Me.txt_security_code.Size = New System.Drawing.Size(304, 39)
        Me.txt_security_code.TabIndex = 18
        Me.txt_security_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Location = New System.Drawing.Point(727, -1)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(32, 31)
        Me.lblClose.TabIndex = 19
        Me.lblClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(127, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "MD CAFE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(65, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "make sure your account is secure"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.coffeeshopMD.My.Resources.Resources._93687084_1427100624135945_6986415204942741504_n
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(497, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(167, 133)
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gold
        Me.PictureBox2.BackgroundImage = Global.coffeeshopMD.My.Resources.Resources._123
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(36, 145)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(304, 350)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 574)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 20
        Me.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "LOGIN"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 20
        Me.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnLogin.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLogin.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(406, 508)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(337, 49)
        Me.btnLogin.TabIndex = 20
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(759, 572)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.txt_security_code)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.chk_remember)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_security_code)
        Me.Controls.Add(Me.CheckBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
=======
        'frm_login
        '
        Me.AcceptButton = Me.btn_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.coffeeshopMD.My.Resources.Resources.ป้ายร้านกาแฟ_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btn_exit
        Me.ClientSize = New System.Drawing.Size(439, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.chk_remember)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_security_code)
        Me.Controls.Add(Me.lbl_security_code)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
<<<<<<< HEAD
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lbl_security_code As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_remember As CheckBox
    Friend WithEvents txt_password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_security_code As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lblClose As Label
    Friend WithEvents btnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
=======

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lbl_security_code As Label
    Friend WithEvents txt_security_code As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_remember As CheckBox
>>>>>>> c1ecb6e5919e3946c0d3087c6fd85e5482a63ef3
End Class
