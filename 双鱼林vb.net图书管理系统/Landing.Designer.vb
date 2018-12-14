<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landing
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Landing))
        Me.skinEngine1 = New Sunisoft.IrisSkin.SkinEngine()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.linkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.linkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_Pwd = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'skinEngine1
        '
        Me.skinEngine1.__DrawButtonFocusRectangle = True
        Me.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray
        Me.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText
        Me.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.skinEngine1.SerialNumber = ""
        Me.skinEngine1.SkinFile = Nothing
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImage = CType(resources.GetObject("pictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(994, 503)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 2
        Me.pictureBox1.TabStop = False
        '
        'linkLabel3
        '
        Me.linkLabel3.AutoSize = True
        Me.linkLabel3.Location = New System.Drawing.Point(320, 352)
        Me.linkLabel3.Name = "linkLabel3"
        Me.linkLabel3.Size = New System.Drawing.Size(359, 12)
        Me.linkLabel3.TabIndex = 31
        Me.linkLabel3.TabStop = True
        Me.linkLabel3.Text = "程序开发:双鱼林 QQ:287307421或254540457 www.shuangyulin.com"
        '
        'linkLabel2
        '
        Me.linkLabel2.AutoSize = True
        Me.linkLabel2.Location = New System.Drawing.Point(615, 243)
        Me.linkLabel2.Name = "linkLabel2"
        Me.linkLabel2.Size = New System.Drawing.Size(59, 12)
        Me.linkLabel2.TabIndex = 30
        Me.linkLabel2.TabStop = True
        Me.linkLabel2.Text = "密码找回?"
        '
        'pictureBox2
        '
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pictureBox2.Location = New System.Drawing.Point(518, 272)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(57, 21)
        Me.pictureBox2.TabIndex = 28
        Me.pictureBox2.TabStop = False
        Me.toolTip1.SetToolTip(Me.pictureBox2, "看不清,刷新")
        '
        'button2
        '
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button2.Location = New System.Drawing.Point(534, 323)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 29)
        Me.button2.TabIndex = 26
        Me.button2.Text = "退  出"
        Me.toolTip1.SetToolTip(Me.button2, "退出系统")
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.Location = New System.Drawing.Point(397, 323)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 29)
        Me.button1.TabIndex = 25
        Me.button1.Text = "登  录"
        Me.toolTip1.SetToolTip(Me.button1, "登录")
        Me.button1.UseVisualStyleBackColor = True
        '
        'linkLabel1
        '
        Me.linkLabel1.AutoSize = True
        Me.linkLabel1.Location = New System.Drawing.Point(615, 281)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(53, 12)
        Me.linkLabel1.TabIndex = 29
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "用户注册"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(422, 272)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(80, 21)
        Me.textBox1.TabIndex = 24
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label4.Location = New System.Drawing.Point(356, 281)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(51, 12)
        Me.label4.TabIndex = 27
        Me.label4.Text = "验证码:"
        '
        'timer1
        '
        Me.timer1.Enabled = True
        '
        'txt_Pwd
        '
        Me.txt_Pwd.Location = New System.Drawing.Point(422, 234)
        Me.txt_Pwd.Name = "txt_Pwd"
        Me.txt_Pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Pwd.Size = New System.Drawing.Size(187, 21)
        Me.txt_Pwd.TabIndex = 23
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label2.Location = New System.Drawing.Point(355, 243)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 12)
        Me.label2.TabIndex = 22
        Me.label2.Text = "密  码:"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(422, 195)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(187, 21)
        Me.txt_username.TabIndex = 21
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label1.Location = New System.Drawing.Point(356, 204)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(51, 12)
        Me.label1.TabIndex = 20
        Me.label1.Text = "用户名:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label3.Location = New System.Drawing.Point(353, 147)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(23, 24)
        Me.label3.TabIndex = 19
        Me.label3.Text = " "
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 503)
        Me.Controls.Add(Me.linkLabel3)
        Me.Controls.Add(Me.linkLabel2)
        Me.Controls.Add(Me.linkLabel1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txt_Pwd)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.pictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Landing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Landing"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents skinEngine1 As Sunisoft.IrisSkin.SkinEngine
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents linkLabel3 As System.Windows.Forms.LinkLabel
    Private WithEvents linkLabel2 As System.Windows.Forms.LinkLabel
    Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents linkLabel1 As System.Windows.Forms.LinkLabel
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private WithEvents txt_Pwd As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txt_username As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
End Class
