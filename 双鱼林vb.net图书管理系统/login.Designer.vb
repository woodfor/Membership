<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.radio_women = New System.Windows.Forms.RadioButton()
        Me.radion_man = New System.Windows.Forms.RadioButton()
        Me.time_Birthday = New System.Windows.Forms.DateTimePicker()
        Me.txt_pwd2 = New System.Windows.Forms.TextBox()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'radio_women
        '
        Me.radio_women.AutoSize = True
        Me.radio_women.Location = New System.Drawing.Point(199, 76)
        Me.radio_women.Name = "radio_women"
        Me.radio_women.Size = New System.Drawing.Size(35, 16)
        Me.radio_women.TabIndex = 29
        Me.radio_women.Text = "女"
        Me.radio_women.UseVisualStyleBackColor = True
        '
        'radion_man
        '
        Me.radion_man.AutoSize = True
        Me.radion_man.Checked = True
        Me.radion_man.Location = New System.Drawing.Point(120, 76)
        Me.radion_man.Name = "radion_man"
        Me.radion_man.Size = New System.Drawing.Size(35, 16)
        Me.radion_man.TabIndex = 28
        Me.radion_man.TabStop = True
        Me.radion_man.Text = "男"
        Me.radion_man.UseVisualStyleBackColor = True
        '
        'time_Birthday
        '
        Me.time_Birthday.Location = New System.Drawing.Point(105, 107)
        Me.time_Birthday.Name = "time_Birthday"
        Me.time_Birthday.Size = New System.Drawing.Size(185, 21)
        Me.time_Birthday.TabIndex = 27
        '
        'txt_pwd2
        '
        Me.txt_pwd2.Location = New System.Drawing.Point(105, 202)
        Me.txt_pwd2.MaxLength = 10
        Me.txt_pwd2.Name = "txt_pwd2"
        Me.txt_pwd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pwd2.Size = New System.Drawing.Size(185, 21)
        Me.txt_pwd2.TabIndex = 26
        '
        'txt_pwd
        '
        Me.txt_pwd.Location = New System.Drawing.Point(105, 153)
        Me.txt_pwd.MaxLength = 10
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pwd.Size = New System.Drawing.Size(185, 21)
        Me.txt_pwd.TabIndex = 25
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(105, 28)
        Me.txt_username.MaxLength = 10
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(185, 21)
        Me.txt_username.TabIndex = 24
        '
        'button2
        '
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.Location = New System.Drawing.Point(199, 274)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 28)
        Me.button2.TabIndex = 23
        Me.button2.Text = "取   消"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        Me.button1.Location = New System.Drawing.Point(80, 274)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 27)
        Me.button1.TabIndex = 22
        Me.button1.Text = "注   册"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(40, 116)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(59, 12)
        Me.label5.TabIndex = 21
        Me.label5.Text = "出身日期:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(52, 80)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(47, 12)
        Me.label4.TabIndex = 20
        Me.label4.Text = "性  别:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(40, 211)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(59, 12)
        Me.label3.TabIndex = 19
        Me.label3.Text = "确认密码:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(52, 162)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(47, 12)
        Me.label2.TabIndex = 18
        Me.label2.Text = "密  码:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(52, 37)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 12)
        Me.label1.TabIndex = 17
        Me.label1.Text = "用户名:"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 330)
        Me.Controls.Add(Me.radio_women)
        Me.Controls.Add(Me.radion_man)
        Me.Controls.Add(Me.time_Birthday)
        Me.Controls.Add(Me.txt_pwd2)
        Me.Controls.Add(Me.txt_pwd)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(347, 368)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(347, 368)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "用户注册"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents radio_women As System.Windows.Forms.RadioButton
    Private WithEvents radion_man As System.Windows.Forms.RadioButton
    Private WithEvents time_Birthday As System.Windows.Forms.DateTimePicker
    Private WithEvents txt_pwd2 As System.Windows.Forms.TextBox
    Private WithEvents txt_pwd As System.Windows.Forms.TextBox
    Private WithEvents txt_username As System.Windows.Forms.TextBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
