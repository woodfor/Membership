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
        Me.label9 = New System.Windows.Forms.Label()
        Me.pictureBox_bookPhoto = New System.Windows.Forms.PictureBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txt_bonus = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txt_userName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txt_card_status = New System.Windows.Forms.TextBox()
        Me.Button_addLevel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_level = New System.Windows.Forms.TextBox()
        Me.Text_temp = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.testbox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Text_discount = New System.Windows.Forms.TextBox()
        Me.GroupBox_basicInfo = New System.Windows.Forms.GroupBox()
        Me.GroupBox_level = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox_topUp = New System.Windows.Forms.GroupBox()
        Me.Button_topUp = New System.Windows.Forms.Button()
        Me.Text_lastTopUp = New System.Windows.Forms.TextBox()
        Me.Text_lastBuy = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button_openTopUp = New System.Windows.Forms.Button()
        CType(Me.pictureBox_bookPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_basicInfo.SuspendLayout()
        Me.GroupBox_level.SuspendLayout()
        Me.GroupBox_topUp.SuspendLayout()
        Me.SuspendLayout()
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(7, 105)
        Me.label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(90, 15)
        Me.label9.TabIndex = 36
        Me.label9.Text = "会员卡状态:"
        '
        'pictureBox_bookPhoto
        '
        Me.pictureBox_bookPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox_bookPhoto.Location = New System.Drawing.Point(125, 192)
        Me.pictureBox_bookPhoto.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureBox_bookPhoto.Name = "pictureBox_bookPhoto"
        Me.pictureBox_bookPhoto.Size = New System.Drawing.Size(264, 167)
        Me.pictureBox_bookPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox_bookPhoto.TabIndex = 32
        Me.pictureBox_bookPhoto.TabStop = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(23, 192)
        Me.label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(82, 15)
        Me.label7.TabIndex = 31
        Me.label7.Text = "用户照片："
        '
        'txt_balance
        '
        Me.txt_balance.Location = New System.Drawing.Point(133, 47)
        Me.txt_balance.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.ReadOnly = True
        Me.txt_balance.Size = New System.Drawing.Size(157, 25)
        Me.txt_balance.TabIndex = 28
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(43, 57)
        Me.label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 15)
        Me.label5.TabIndex = 27
        Me.label5.Text = "卡上余额："
        '
        'txt_bonus
        '
        Me.txt_bonus.Location = New System.Drawing.Point(133, 77)
        Me.txt_bonus.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_bonus.Name = "txt_bonus"
        Me.txt_bonus.ReadOnly = True
        Me.txt_bonus.Size = New System.Drawing.Size(157, 25)
        Me.txt_bonus.TabIndex = 26
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(34, 86)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(82, 15)
        Me.label4.TabIndex = 25
        Me.label4.Text = "用户积分："
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(1259, 510)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(67, 15)
        Me.label3.TabIndex = 23
        Me.label3.Text = "暂时保留"
        '
        'txt_userName
        '
        Me.txt_userName.Location = New System.Drawing.Point(125, 138)
        Me.txt_userName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_userName.Name = "txt_userName"
        Me.txt_userName.ReadOnly = True
        Me.txt_userName.Size = New System.Drawing.Size(264, 25)
        Me.txt_userName.TabIndex = 22
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(23, 148)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(82, 15)
        Me.label2.TabIndex = 21
        Me.label2.Text = "用户名称："
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(125, 57)
        Me.txt_barcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(264, 25)
        Me.txt_barcode.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(30, 60)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 19
        Me.label1.Text = "条形码："
        '
        'txt_card_status
        '
        Me.txt_card_status.Location = New System.Drawing.Point(125, 102)
        Me.txt_card_status.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_card_status.Name = "txt_card_status"
        Me.txt_card_status.ReadOnly = True
        Me.txt_card_status.Size = New System.Drawing.Size(264, 25)
        Me.txt_card_status.TabIndex = 38
        '
        'Button_addLevel
        '
        Me.Button_addLevel.Location = New System.Drawing.Point(681, 539)
        Me.Button_addLevel.Name = "Button_addLevel"
        Me.Button_addLevel.Size = New System.Drawing.Size(188, 32)
        Me.Button_addLevel.TabIndex = 40
        Me.Button_addLevel.Text = "添加会员等级"
        Me.Button_addLevel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 50)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "会员卡等级："
        '
        'txt_level
        '
        Me.txt_level.Location = New System.Drawing.Point(133, 41)
        Me.txt_level.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_level.Name = "txt_level"
        Me.txt_level.ReadOnly = True
        Me.txt_level.Size = New System.Drawing.Size(157, 25)
        Me.txt_level.TabIndex = 42
        '
        'Text_temp
        '
        Me.Text_temp.Location = New System.Drawing.Point(946, 217)
        Me.Text_temp.Multiline = True
        Me.Text_temp.Name = "Text_temp"
        Me.Text_temp.Size = New System.Drawing.Size(288, 150)
        Me.Text_temp.TabIndex = 44
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(946, 421)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(288, 150)
        Me.TextBox1.TabIndex = 45
        '
        'testbox
        '
        Me.testbox.Location = New System.Drawing.Point(946, 27)
        Me.testbox.Multiline = True
        Me.testbox.Name = "testbox"
        Me.testbox.Size = New System.Drawing.Size(288, 150)
        Me.testbox.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(64, 120)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "折扣："
        '
        'Text_discount
        '
        Me.Text_discount.Location = New System.Drawing.Point(133, 110)
        Me.Text_discount.Margin = New System.Windows.Forms.Padding(4)
        Me.Text_discount.Name = "Text_discount"
        Me.Text_discount.ReadOnly = True
        Me.Text_discount.Size = New System.Drawing.Size(73, 25)
        Me.Text_discount.TabIndex = 47
        '
        'GroupBox_basicInfo
        '
        Me.GroupBox_basicInfo.Controls.Add(Me.txt_barcode)
        Me.GroupBox_basicInfo.Controls.Add(Me.label1)
        Me.GroupBox_basicInfo.Controls.Add(Me.label2)
        Me.GroupBox_basicInfo.Controls.Add(Me.txt_userName)
        Me.GroupBox_basicInfo.Controls.Add(Me.pictureBox_bookPhoto)
        Me.GroupBox_basicInfo.Controls.Add(Me.label7)
        Me.GroupBox_basicInfo.Controls.Add(Me.label9)
        Me.GroupBox_basicInfo.Controls.Add(Me.txt_card_status)
        Me.GroupBox_basicInfo.Location = New System.Drawing.Point(69, 17)
        Me.GroupBox_basicInfo.Name = "GroupBox_basicInfo"
        Me.GroupBox_basicInfo.Size = New System.Drawing.Size(413, 402)
        Me.GroupBox_basicInfo.TabIndex = 0
        Me.GroupBox_basicInfo.TabStop = False
        Me.GroupBox_basicInfo.Text = "基本信息"
        '
        'GroupBox_level
        '
        Me.GroupBox_level.Controls.Add(Me.Label13)
        Me.GroupBox_level.Controls.Add(Me.Label8)
        Me.GroupBox_level.Controls.Add(Me.txt_level)
        Me.GroupBox_level.Controls.Add(Me.Label11)
        Me.GroupBox_level.Controls.Add(Me.Text_discount)
        Me.GroupBox_level.Controls.Add(Me.txt_bonus)
        Me.GroupBox_level.Controls.Add(Me.label4)
        Me.GroupBox_level.Location = New System.Drawing.Point(519, 17)
        Me.GroupBox_level.Name = "GroupBox_level"
        Me.GroupBox_level.Size = New System.Drawing.Size(318, 160)
        Me.GroupBox_level.TabIndex = 49
        Me.GroupBox_level.TabStop = False
        Me.GroupBox_level.Text = "等级活动"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(227, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 15)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "折"
        '
        'GroupBox_topUp
        '
        Me.GroupBox_topUp.Controls.Add(Me.Button_topUp)
        Me.GroupBox_topUp.Controls.Add(Me.Text_lastTopUp)
        Me.GroupBox_topUp.Controls.Add(Me.Text_lastBuy)
        Me.GroupBox_topUp.Controls.Add(Me.Label12)
        Me.GroupBox_topUp.Controls.Add(Me.Label6)
        Me.GroupBox_topUp.Controls.Add(Me.label5)
        Me.GroupBox_topUp.Controls.Add(Me.txt_balance)
        Me.GroupBox_topUp.Location = New System.Drawing.Point(519, 183)
        Me.GroupBox_topUp.Name = "GroupBox_topUp"
        Me.GroupBox_topUp.Size = New System.Drawing.Size(318, 233)
        Me.GroupBox_topUp.TabIndex = 50
        Me.GroupBox_topUp.TabStop = False
        Me.GroupBox_topUp.Text = "储值服务"
        '
        'Button_topUp
        '
        Me.Button_topUp.Enabled = False
        Me.Button_topUp.Location = New System.Drawing.Point(103, 182)
        Me.Button_topUp.Name = "Button_topUp"
        Me.Button_topUp.Size = New System.Drawing.Size(100, 32)
        Me.Button_topUp.TabIndex = 51
        Me.Button_topUp.Text = "充值"
        Me.Button_topUp.UseVisualStyleBackColor = True
        '
        'Text_lastTopUp
        '
        Me.Text_lastTopUp.Location = New System.Drawing.Point(133, 136)
        Me.Text_lastTopUp.Margin = New System.Windows.Forms.Padding(4)
        Me.Text_lastTopUp.Name = "Text_lastTopUp"
        Me.Text_lastTopUp.ReadOnly = True
        Me.Text_lastTopUp.Size = New System.Drawing.Size(157, 25)
        Me.Text_lastTopUp.TabIndex = 53
        '
        'Text_lastBuy
        '
        Me.Text_lastBuy.Location = New System.Drawing.Point(133, 93)
        Me.Text_lastBuy.Margin = New System.Windows.Forms.Padding(4)
        Me.Text_lastBuy.Name = "Text_lastBuy"
        Me.Text_lastBuy.ReadOnly = True
        Me.Text_lastBuy.Size = New System.Drawing.Size(157, 25)
        Me.Text_lastBuy.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 93)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 30)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "上次储值消费" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "时间："
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 139)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 15)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "上次充值时间："
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(519, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 32)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "储值消费"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(299, 469)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 32)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "现金消费"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button_openTopUp
        '
        Me.Button_openTopUp.Enabled = False
        Me.Button_openTopUp.Location = New System.Drawing.Point(605, 288)
        Me.Button_openTopUp.Name = "Button_openTopUp"
        Me.Button_openTopUp.Size = New System.Drawing.Size(159, 32)
        Me.Button_openTopUp.TabIndex = 56
        Me.Button_openTopUp.Text = "开启储值服务"
        Me.Button_openTopUp.UseVisualStyleBackColor = True
        '
        'FrmAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1376, 634)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox_topUp)
        Me.Controls.Add(Me.GroupBox_level)
        Me.Controls.Add(Me.GroupBox_basicInfo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button_openTopUp)
        Me.Controls.Add(Me.Text_temp)
        Me.Controls.Add(Me.testbox)
        Me.Controls.Add(Me.Button_addLevel)
        Me.Controls.Add(Me.label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "卡券查询"
        CType(Me.pictureBox_bookPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_basicInfo.ResumeLayout(False)
        Me.GroupBox_basicInfo.PerformLayout()
        Me.GroupBox_level.ResumeLayout(False)
        Me.GroupBox_level.PerformLayout()
        Me.GroupBox_topUp.ResumeLayout(False)
        Me.GroupBox_topUp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents pictureBox_bookPhoto As System.Windows.Forms.PictureBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_balance As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txt_bonus As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txt_userName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txt_barcode As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txt_card_status As TextBox
    Friend WithEvents Button_addLevel As Button
    Private WithEvents Label8 As Label
    Private WithEvents txt_level As TextBox
    Friend WithEvents Text_temp As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents testbox As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents Text_discount As TextBox
    Friend WithEvents GroupBox_basicInfo As GroupBox
    Friend WithEvents GroupBox_level As GroupBox
    Friend WithEvents GroupBox_topUp As GroupBox
    Private WithEvents Text_lastTopUp As TextBox
    Private WithEvents Text_lastBuy As TextBox
    Private WithEvents Label12 As Label
    Private WithEvents Label6 As Label
    Friend WithEvents Button_topUp As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button_openTopUp As Button
    Friend WithEvents Label13 As Label
End Class
