<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddBook))
        Me.dtp_publishDate = New System.Windows.Forms.DateTimePicker()
        Me.label9 = New System.Windows.Forms.Label()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.btn_bookPhoto = New System.Windows.Forms.Button()
        Me.txt_bookPhoto = New System.Windows.Forms.TextBox()
        Me.pictureBox_bookPhoto = New System.Windows.Forms.PictureBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_publish = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txt_count = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txt_bonus = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cb_bookType = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txt_userName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_card_status = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Button_addLevel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_level = New System.Windows.Forms.TextBox()
        Me.testbox = New System.Windows.Forms.TextBox()
        Me.Text_temp = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.pictureBox_bookPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_publishDate
        '
        Me.dtp_publishDate.Location = New System.Drawing.Point(227, 557)
        Me.dtp_publishDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_publishDate.Name = "dtp_publishDate"
        Me.dtp_publishDate.Size = New System.Drawing.Size(276, 25)
        Me.dtp_publishDate.TabIndex = 37
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(95, 527)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(82, 15)
        Me.label9.TabIndex = 36
        Me.label9.Text = "会员卡状态"
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(153, 590)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(189, 31)
        Me.Btn_Add.TabIndex = 35
        Me.Btn_Add.Text = "添加图书"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'btn_bookPhoto
        '
        Me.btn_bookPhoto.Location = New System.Drawing.Point(455, 444)
        Me.btn_bookPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_bookPhoto.Name = "btn_bookPhoto"
        Me.btn_bookPhoto.Size = New System.Drawing.Size(80, 32)
        Me.btn_bookPhoto.TabIndex = 34
        Me.btn_bookPhoto.Text = "暂留"
        Me.btn_bookPhoto.UseVisualStyleBackColor = True
        '
        'txt_bookPhoto
        '
        Me.txt_bookPhoto.Location = New System.Drawing.Point(227, 484)
        Me.txt_bookPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_bookPhoto.Name = "txt_bookPhoto"
        Me.txt_bookPhoto.ReadOnly = True
        Me.txt_bookPhoto.Size = New System.Drawing.Size(399, 25)
        Me.txt_bookPhoto.TabIndex = 33
        '
        'pictureBox_bookPhoto
        '
        Me.pictureBox_bookPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox_bookPhoto.Location = New System.Drawing.Point(227, 301)
        Me.pictureBox_bookPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox_bookPhoto.Name = "pictureBox_bookPhoto"
        Me.pictureBox_bookPhoto.Size = New System.Drawing.Size(208, 175)
        Me.pictureBox_bookPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox_bookPhoto.TabIndex = 32
        Me.pictureBox_bookPhoto.TabStop = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(95, 301)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(67, 15)
        Me.label7.TabIndex = 31
        Me.label7.Text = "用户照片"
        '
        'txt_publish
        '
        Me.txt_publish.Location = New System.Drawing.Point(227, 250)
        Me.txt_publish.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_publish.Name = "txt_publish"
        Me.txt_publish.Size = New System.Drawing.Size(471, 25)
        Me.txt_publish.TabIndex = 30
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(95, 250)
        Me.label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 15)
        Me.label6.TabIndex = 29
        Me.label6.Text = "开卡地点"
        '
        'txt_count
        '
        Me.txt_count.Location = New System.Drawing.Point(227, 205)
        Me.txt_count.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_count.Name = "txt_count"
        Me.txt_count.Size = New System.Drawing.Size(264, 25)
        Me.txt_count.TabIndex = 28
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(95, 208)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(67, 15)
        Me.label5.TabIndex = 27
        Me.label5.Text = "卡上余额"
        '
        'txt_bonus
        '
        Me.txt_bonus.Location = New System.Drawing.Point(227, 159)
        Me.txt_bonus.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_bonus.Name = "txt_bonus"
        Me.txt_bonus.ReadOnly = True
        Me.txt_bonus.Size = New System.Drawing.Size(264, 25)
        Me.txt_bonus.TabIndex = 26
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(95, 162)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(67, 15)
        Me.label4.TabIndex = 25
        Me.label4.Text = "用户积分"
        '
        'cb_bookType
        '
        Me.cb_bookType.FormattingEnabled = True
        Me.cb_bookType.Location = New System.Drawing.Point(227, 111)
        Me.cb_bookType.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_bookType.Name = "cb_bookType"
        Me.cb_bookType.Size = New System.Drawing.Size(264, 23)
        Me.cb_bookType.TabIndex = 24
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(95, 115)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 23
        Me.label3.Text = "暂时保留"
        '
        'txt_userName
        '
        Me.txt_userName.Location = New System.Drawing.Point(227, 69)
        Me.txt_userName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_userName.Name = "txt_userName"
        Me.txt_userName.ReadOnly = True
        Me.txt_userName.Size = New System.Drawing.Size(264, 25)
        Me.txt_userName.TabIndex = 22
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(95, 72)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(82, 15)
        Me.label2.TabIndex = 21
        Me.label2.Text = "用户名称："
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(227, 25)
        Me.txt_barcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(264, 25)
        Me.txt_barcode.TabIndex = 20
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(95, 29)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 19
        Me.label1.Text = "条形码："
        '
        'txt_card_status
        '
        Me.txt_card_status.Location = New System.Drawing.Point(227, 524)
        Me.txt_card_status.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_card_status.Name = "txt_card_status"
        Me.txt_card_status.ReadOnly = True
        Me.txt_card_status.Size = New System.Drawing.Size(264, 25)
        Me.txt_card_status.TabIndex = 38
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(95, 564)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(67, 15)
        Me.label10.TabIndex = 39
        Me.label10.Text = "开卡日期"
        '
        'Button_addLevel
        '
        Me.Button_addLevel.Enabled = False
        Me.Button_addLevel.Location = New System.Drawing.Point(428, 590)
        Me.Button_addLevel.Name = "Button_addLevel"
        Me.Button_addLevel.Size = New System.Drawing.Size(188, 32)
        Me.Button_addLevel.TabIndex = 40
        Me.Button_addLevel.Text = "添加会员等级"
        Me.Button_addLevel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(620, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "会员卡等级"
        '
        'txt_level
        '
        Me.txt_level.Location = New System.Drawing.Point(739, 25)
        Me.txt_level.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_level.Name = "txt_level"
        Me.txt_level.Size = New System.Drawing.Size(264, 25)
        Me.txt_level.TabIndex = 42
        '
        'testbox
        '
        Me.testbox.Location = New System.Drawing.Point(739, 115)
        Me.testbox.Multiline = True
        Me.testbox.Name = "testbox"
        Me.testbox.Size = New System.Drawing.Size(288, 150)
        Me.testbox.TabIndex = 43
        '
        'Text_temp
        '
        Me.Text_temp.Location = New System.Drawing.Point(739, 298)
        Me.Text_temp.Multiline = True
        Me.Text_temp.Name = "Text_temp"
        Me.Text_temp.Size = New System.Drawing.Size(288, 150)
        Me.Text_temp.TabIndex = 44
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(739, 472)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 150)
        Me.TextBox1.TabIndex = 45
        '
        'FrmAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 634)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Text_temp)
        Me.Controls.Add(Me.testbox)
        Me.Controls.Add(Me.txt_level)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button_addLevel)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txt_card_status)
        Me.Controls.Add(Me.dtp_publishDate)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.btn_bookPhoto)
        Me.Controls.Add(Me.txt_bookPhoto)
        Me.Controls.Add(Me.pictureBox_bookPhoto)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txt_publish)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txt_count)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txt_bonus)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.cb_bookType)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txt_userName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txt_barcode)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "图书添加界面"
        CType(Me.pictureBox_bookPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dtp_publishDate As System.Windows.Forms.DateTimePicker
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents Btn_Add As System.Windows.Forms.Button
    Private WithEvents btn_bookPhoto As System.Windows.Forms.Button
    Private WithEvents txt_bookPhoto As System.Windows.Forms.TextBox
    Private WithEvents pictureBox_bookPhoto As System.Windows.Forms.PictureBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_publish As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txt_count As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txt_bonus As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents cb_bookType As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txt_userName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txt_barcode As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txt_card_status As TextBox
    Private WithEvents label10 As Label
    Friend WithEvents Button_addLevel As Button
    Private WithEvents Label8 As Label
    Private WithEvents txt_level As TextBox
    Friend WithEvents testbox As TextBox
    Friend WithEvents Text_temp As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
