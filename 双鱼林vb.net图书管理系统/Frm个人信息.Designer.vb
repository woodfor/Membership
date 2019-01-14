<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm个人信息
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm个人信息))
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.button3 = New System.Windows.Forms.Button()
        Me.txt_pic = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.U_Position = New System.Windows.Forms.TextBox()
        Me.U_RelName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.U_NativePlace = New System.Windows.Forms.ComboBox()
        Me.U_IdCard = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.U_Address = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.label16 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label17 = New System.Windows.Forms.Label()
        Me.U_PostalId = New System.Windows.Forms.TextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.U_Telephone = New System.Windows.Forms.TextBox()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.U_Email = New System.Windows.Forms.TextBox()
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.radio_women = New System.Windows.Forms.RadioButton()
        Me.label5 = New System.Windows.Forms.Label()
        Me.radion_man = New System.Windows.Forms.RadioButton()
        Me.U_Birthday = New System.Windows.Forms.DateTimePicker()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.U_Name = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox3.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.button3)
        Me.groupBox3.Controls.Add(Me.txt_pic)
        Me.groupBox3.Controls.Add(Me.pictureBox1)
        Me.groupBox3.Location = New System.Drawing.Point(556, 25)
        Me.groupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox3.Size = New System.Drawing.Size(549, 460)
        Me.groupBox3.TabIndex = 18
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "生活照展示"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(439, 411)
        Me.button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(80, 32)
        Me.button3.TabIndex = 2
        Me.button3.Text = "上 传"
        Me.button3.UseVisualStyleBackColor = True
        '
        'txt_pic
        '
        Me.txt_pic.Location = New System.Drawing.Point(21, 414)
        Me.txt_pic.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_pic.Name = "txt_pic"
        Me.txt_pic.ReadOnly = True
        Me.txt_pic.Size = New System.Drawing.Size(408, 25)
        Me.txt_pic.TabIndex = 1
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.Location = New System.Drawing.Point(21, 31)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(507, 361)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.U_Position)
        Me.groupBox2.Controls.Add(Me.U_RelName)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me.U_NativePlace)
        Me.groupBox2.Controls.Add(Me.U_IdCard)
        Me.groupBox2.Controls.Add(Me.label10)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.U_Address)
        Me.groupBox2.Controls.Add(Me.label12)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.ForeColor = System.Drawing.Color.Blue
        Me.groupBox2.Location = New System.Drawing.Point(17, 200)
        Me.groupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox2.Size = New System.Drawing.Size(532, 226)
        Me.groupBox2.TabIndex = 17
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "个人详细信息"
        '
        'U_Position
        '
        Me.U_Position.Location = New System.Drawing.Point(109, 176)
        Me.U_Position.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Position.MaxLength = 20
        Me.U_Position.Name = "U_Position"
        Me.U_Position.Size = New System.Drawing.Size(220, 25)
        Me.U_Position.TabIndex = 21
        '
        'U_RelName
        '
        Me.U_RelName.Location = New System.Drawing.Point(109, 35)
        Me.U_RelName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_RelName.MaxLength = 20
        Me.U_RelName.Name = "U_RelName"
        Me.U_RelName.Size = New System.Drawing.Size(221, 25)
        Me.U_RelName.TabIndex = 20
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(24, 46)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(75, 15)
        Me.label2.TabIndex = 19
        Me.label2.Text = "真实姓名:"
        '
        'U_NativePlace
        '
        Me.U_NativePlace.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.U_NativePlace.FormattingEnabled = True
        Me.U_NativePlace.Items.AddRange(New Object() {"汉族", "满族", "回族"})
        Me.U_NativePlace.Location = New System.Drawing.Point(109, 136)
        Me.U_NativePlace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_NativePlace.Name = "U_NativePlace"
        Me.U_NativePlace.Size = New System.Drawing.Size(220, 23)
        Me.U_NativePlace.TabIndex = 18
        '
        'U_IdCard
        '
        Me.U_IdCard.Location = New System.Drawing.Point(109, 69)
        Me.U_IdCard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_IdCard.MaxLength = 20
        Me.U_IdCard.Name = "U_IdCard"
        Me.U_IdCard.Size = New System.Drawing.Size(221, 25)
        Me.U_IdCard.TabIndex = 18
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.ForeColor = System.Drawing.Color.Black
        Me.label10.Location = New System.Drawing.Point(37, 146)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(61, 15)
        Me.label10.TabIndex = 16
        Me.label10.Text = "民  族:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label4.Location = New System.Drawing.Point(39, 188)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 15)
        Me.label4.TabIndex = 4
        Me.label4.Text = "职  务:"
        '
        'U_Address
        '
        Me.U_Address.Location = New System.Drawing.Point(111, 102)
        Me.U_Address.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Address.MaxLength = 20
        Me.U_Address.Name = "U_Address"
        Me.U_Address.Size = New System.Drawing.Size(220, 25)
        Me.U_Address.TabIndex = 13
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.ForeColor = System.Drawing.Color.Black
        Me.label12.Location = New System.Drawing.Point(24, 114)
        Me.label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(75, 15)
        Me.label12.TabIndex = 12
        Me.label12.Text = "家庭住址:"
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.ForeColor = System.Drawing.Color.Black
        Me.label16.Location = New System.Drawing.Point(24, 80)
        Me.label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(75, 15)
        Me.label16.TabIndex = 4
        Me.label16.Text = "身份证号:"
        '
        'button1
        '
        Me.button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        Me.button1.Location = New System.Drawing.Point(704, 612)
        Me.button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 36)
        Me.button1.TabIndex = 19
        Me.button1.Text = "保  存"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.ForeColor = System.Drawing.Color.Black
        Me.label17.Location = New System.Drawing.Point(23, 82)
        Me.label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(75, 15)
        Me.label17.TabIndex = 2
        Me.label17.Text = "邮箱号码:"
        '
        'U_PostalId
        '
        Me.U_PostalId.Location = New System.Drawing.Point(111, 115)
        Me.U_PostalId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_PostalId.MaxLength = 20
        Me.U_PostalId.Name = "U_PostalId"
        Me.U_PostalId.Size = New System.Drawing.Size(219, 25)
        Me.U_PostalId.TabIndex = 13
        '
        'button2
        '
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.Location = New System.Drawing.Point(887, 612)
        Me.button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(100, 36)
        Me.button2.TabIndex = 20
        Me.button2.Text = "退  出"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(23, 126)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(75, 15)
        Me.label3.TabIndex = 12
        Me.label3.Text = "邮政编码:"
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.ForeColor = System.Drawing.Color.Black
        Me.label13.Location = New System.Drawing.Point(23, 38)
        Me.label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(75, 15)
        Me.label13.TabIndex = 10
        Me.label13.Text = "联系电话:"
        '
        'U_Telephone
        '
        Me.U_Telephone.Location = New System.Drawing.Point(109, 26)
        Me.U_Telephone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Telephone.MaxLength = 20
        Me.U_Telephone.Name = "U_Telephone"
        Me.U_Telephone.Size = New System.Drawing.Size(219, 25)
        Me.U_Telephone.TabIndex = 3
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.U_PostalId)
        Me.groupBox4.Controls.Add(Me.label3)
        Me.groupBox4.Controls.Add(Me.U_Email)
        Me.groupBox4.Controls.Add(Me.label13)
        Me.groupBox4.Controls.Add(Me.label17)
        Me.groupBox4.Controls.Add(Me.U_Telephone)
        Me.groupBox4.ForeColor = System.Drawing.Color.Blue
        Me.groupBox4.Location = New System.Drawing.Point(17, 448)
        Me.groupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox4.Size = New System.Drawing.Size(532, 201)
        Me.groupBox4.TabIndex = 21
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "联系方式"
        '
        'U_Email
        '
        Me.U_Email.Location = New System.Drawing.Point(111, 71)
        Me.U_Email.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Email.MaxLength = 20
        Me.U_Email.Name = "U_Email"
        Me.U_Email.Size = New System.Drawing.Size(219, 25)
        Me.U_Email.TabIndex = 11
        '
        'openFileDialog1
        '
        Me.openFileDialog1.FileName = "openFileDialog1"
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(412, 122)
        Me.checkBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(89, 19)
        Me.checkBox1.TabIndex = 16
        Me.checkBox1.Text = "密保设置"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'radio_women
        '
        Me.radio_women.AutoSize = True
        Me.radio_women.ForeColor = System.Drawing.Color.Black
        Me.radio_women.Location = New System.Drawing.Point(221, 81)
        Me.radio_women.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radio_women.Name = "radio_women"
        Me.radio_women.Size = New System.Drawing.Size(43, 19)
        Me.radio_women.TabIndex = 21
        Me.radio_women.Text = "女"
        Me.radio_women.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label5.Location = New System.Drawing.Point(39, 84)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(61, 15)
        Me.label5.TabIndex = 8
        Me.label5.Text = "性  别:"
        '
        'radion_man
        '
        Me.radion_man.AutoSize = True
        Me.radion_man.Checked = True
        Me.radion_man.ForeColor = System.Drawing.Color.Black
        Me.radion_man.Location = New System.Drawing.Point(116, 81)
        Me.radion_man.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radion_man.Name = "radion_man"
        Me.radion_man.Size = New System.Drawing.Size(43, 19)
        Me.radion_man.TabIndex = 20
        Me.radion_man.TabStop = True
        Me.radion_man.Text = "男"
        Me.radion_man.UseVisualStyleBackColor = True
        '
        'U_Birthday
        '
        Me.U_Birthday.Location = New System.Drawing.Point(111, 116)
        Me.U_Birthday.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Birthday.Name = "U_Birthday"
        Me.U_Birthday.Size = New System.Drawing.Size(200, 25)
        Me.U_Birthday.TabIndex = 19
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.checkBox1)
        Me.groupBox1.Controls.Add(Me.radio_women)
        Me.groupBox1.Controls.Add(Me.radion_man)
        Me.groupBox1.Controls.Add(Me.U_Birthday)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label15)
        Me.groupBox1.Controls.Add(Me.U_Name)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.ForeColor = System.Drawing.Color.Blue
        Me.groupBox1.Location = New System.Drawing.Point(16, 24)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupBox1.Size = New System.Drawing.Size(532, 169)
        Me.groupBox1.TabIndex = 16
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "个人基本信息"
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.ForeColor = System.Drawing.Color.Black
        Me.label15.Location = New System.Drawing.Point(24, 128)
        Me.label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(75, 15)
        Me.label15.TabIndex = 6
        Me.label15.Text = "出生日期:"
        '
        'U_Name
        '
        Me.U_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.U_Name.Location = New System.Drawing.Point(109, 32)
        Me.U_Name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.U_Name.MaxLength = 20
        Me.U_Name.Name = "U_Name"
        Me.U_Name.Size = New System.Drawing.Size(201, 25)
        Me.U_Name.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label1.Location = New System.Drawing.Point(39, 44)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "用户名:"
        '
        'Frm个人信息
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 714)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Frm个人信息"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "个人详细信息"
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents txt_pic As System.Windows.Forms.TextBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents U_Position As System.Windows.Forms.TextBox
    Private WithEvents U_RelName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents U_NativePlace As System.Windows.Forms.ComboBox
    Private WithEvents U_IdCard As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents U_Address As System.Windows.Forms.TextBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents U_PostalId As System.Windows.Forms.TextBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents U_Telephone As System.Windows.Forms.TextBox
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents U_Email As System.Windows.Forms.TextBox
    Private WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents radio_women As System.Windows.Forms.RadioButton
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents radion_man As System.Windows.Forms.RadioButton
    Private WithEvents U_Birthday As System.Windows.Forms.DateTimePicker
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents U_Name As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
