<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditBook))
        Me.dtp_publishDate = New System.Windows.Forms.DateTimePicker()
        Me.label8 = New System.Windows.Forms.Label()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.btn_bookPhoto = New System.Windows.Forms.Button()
        Me.txt_bookPhoto = New System.Windows.Forms.TextBox()
        Me.pictureBox_bookPhoto = New System.Windows.Forms.PictureBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txt_publish = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txt_count = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cb_bookType = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txt_bookName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.pictureBox_bookPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_publishDate
        '
        Me.dtp_publishDate.Location = New System.Drawing.Point(170, 417)
        Me.dtp_publishDate.Name = "dtp_publishDate"
        Me.dtp_publishDate.Size = New System.Drawing.Size(208, 21)
        Me.dtp_publishDate.TabIndex = 56
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(71, 419)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(65, 12)
        Me.label8.TabIndex = 55
        Me.label8.Text = "出版日期："
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(184, 461)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(142, 25)
        Me.Btn_Update.TabIndex = 54
        Me.Btn_Update.Text = "更新图书"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'btn_bookPhoto
        '
        Me.btn_bookPhoto.Location = New System.Drawing.Point(341, 355)
        Me.btn_bookPhoto.Name = "btn_bookPhoto"
        Me.btn_bookPhoto.Size = New System.Drawing.Size(60, 26)
        Me.btn_bookPhoto.TabIndex = 53
        Me.btn_bookPhoto.Text = "上 传"
        Me.btn_bookPhoto.UseVisualStyleBackColor = True
        '
        'txt_bookPhoto
        '
        Me.txt_bookPhoto.Location = New System.Drawing.Point(170, 387)
        Me.txt_bookPhoto.Name = "txt_bookPhoto"
        Me.txt_bookPhoto.ReadOnly = True
        Me.txt_bookPhoto.Size = New System.Drawing.Size(300, 21)
        Me.txt_bookPhoto.TabIndex = 52
        '
        'pictureBox_bookPhoto
        '
        Me.pictureBox_bookPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox_bookPhoto.Location = New System.Drawing.Point(170, 241)
        Me.pictureBox_bookPhoto.Name = "pictureBox_bookPhoto"
        Me.pictureBox_bookPhoto.Size = New System.Drawing.Size(156, 140)
        Me.pictureBox_bookPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox_bookPhoto.TabIndex = 51
        Me.pictureBox_bookPhoto.TabStop = False
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(71, 241)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(65, 12)
        Me.label7.TabIndex = 50
        Me.label7.Text = "图书图片："
        '
        'txt_publish
        '
        Me.txt_publish.Location = New System.Drawing.Point(170, 200)
        Me.txt_publish.Name = "txt_publish"
        Me.txt_publish.Size = New System.Drawing.Size(354, 21)
        Me.txt_publish.TabIndex = 49
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(71, 200)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(53, 12)
        Me.label6.TabIndex = 48
        Me.label6.Text = "出版社："
        '
        'txt_count
        '
        Me.txt_count.Location = New System.Drawing.Point(170, 164)
        Me.txt_count.Name = "txt_count"
        Me.txt_count.Size = New System.Drawing.Size(199, 21)
        Me.txt_count.TabIndex = 47
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(71, 166)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(65, 12)
        Me.label5.TabIndex = 46
        Me.label5.Text = "图书库存："
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(170, 127)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(199, 21)
        Me.txt_price.TabIndex = 45
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(71, 130)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 12)
        Me.label4.TabIndex = 44
        Me.label4.Text = "图书价格："
        '
        'cb_bookType
        '
        Me.cb_bookType.FormattingEnabled = True
        Me.cb_bookType.Location = New System.Drawing.Point(170, 89)
        Me.cb_bookType.Name = "cb_bookType"
        Me.cb_bookType.Size = New System.Drawing.Size(199, 20)
        Me.cb_bookType.TabIndex = 43
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(71, 92)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(65, 12)
        Me.label3.TabIndex = 42
        Me.label3.Text = "图书类别："
        '
        'txt_bookName
        '
        Me.txt_bookName.Location = New System.Drawing.Point(170, 55)
        Me.txt_bookName.Name = "txt_bookName"
        Me.txt_bookName.Size = New System.Drawing.Size(199, 21)
        Me.txt_bookName.TabIndex = 41
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(71, 58)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 12)
        Me.label2.TabIndex = 40
        Me.label2.Text = "图书名称："
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(170, 20)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(199, 21)
        Me.txt_barcode.TabIndex = 39
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(71, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 12)
        Me.label1.TabIndex = 38
        Me.label1.Text = "图书条形码："
        '
        'FrmEditBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 507)
        Me.Controls.Add(Me.dtp_publishDate)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.btn_bookPhoto)
        Me.Controls.Add(Me.txt_bookPhoto)
        Me.Controls.Add(Me.pictureBox_bookPhoto)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txt_publish)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txt_count)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.cb_bookType)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txt_bookName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txt_barcode)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEditBook"
        Me.Text = "图书编辑界面"
        CType(Me.pictureBox_bookPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dtp_publishDate As System.Windows.Forms.DateTimePicker
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents Btn_Update As System.Windows.Forms.Button
    Private WithEvents btn_bookPhoto As System.Windows.Forms.Button
    Private WithEvents txt_bookPhoto As System.Windows.Forms.TextBox
    Private WithEvents pictureBox_bookPhoto As System.Windows.Forms.PictureBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txt_publish As System.Windows.Forms.TextBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents txt_count As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txt_price As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents cb_bookType As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txt_bookName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txt_barcode As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
