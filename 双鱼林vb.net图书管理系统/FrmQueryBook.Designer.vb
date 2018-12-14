<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQueryBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQueryBook))
        Me.Btn_Query = New System.Windows.Forms.Button()
        Me.dataGridView_Book = New System.Windows.Forms.DataGridView()
        Me.HPageSize = New System.Windows.Forms.TextBox()
        Me.dtp_publishDate = New System.Windows.Forms.DateTimePicker()
        Me.HNowPage = New System.Windows.Forms.TextBox()
        Me.txt_publishDate = New System.Windows.Forms.TextBox()
        Me.HWhere = New System.Windows.Forms.TextBox()
        Me.cb_bookType = New System.Windows.Forms.ComboBox()
        Me.HAllPage = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.txt_bookName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.HSelectID = New System.Windows.Forms.TextBox()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.LBEnd = New System.Windows.Forms.Button()
        Me.Btn_Del = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.LBNext = New System.Windows.Forms.Button()
        Me.LBUp = New System.Windows.Forms.Button()
        Me.LBHome = New System.Windows.Forms.Button()
        Me.PageMes = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dataGridView_Book, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Query
        '
        Me.Btn_Query.Location = New System.Drawing.Point(634, 36)
        Me.Btn_Query.Name = "Btn_Query"
        Me.Btn_Query.Size = New System.Drawing.Size(89, 22)
        Me.Btn_Query.TabIndex = 9
        Me.Btn_Query.Text = "查询"
        Me.Btn_Query.UseVisualStyleBackColor = True
        '
        'dataGridView_Book
        '
        Me.dataGridView_Book.AllowUserToAddRows = False
        Me.dataGridView_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView_Book.Location = New System.Drawing.Point(3, 99)
        Me.dataGridView_Book.Name = "dataGridView_Book"
        Me.dataGridView_Book.RowTemplate.Height = 23
        Me.dataGridView_Book.Size = New System.Drawing.Size(744, 346)
        Me.dataGridView_Book.TabIndex = 15
        '
        'HPageSize
        '
        Me.HPageSize.Location = New System.Drawing.Point(192, 451)
        Me.HPageSize.Name = "HPageSize"
        Me.HPageSize.Size = New System.Drawing.Size(56, 21)
        Me.HPageSize.TabIndex = 24
        Me.HPageSize.Text = "5"
        Me.HPageSize.Visible = False
        '
        'dtp_publishDate
        '
        Me.dtp_publishDate.Location = New System.Drawing.Point(584, 57)
        Me.dtp_publishDate.Name = "dtp_publishDate"
        Me.dtp_publishDate.Size = New System.Drawing.Size(16, 21)
        Me.dtp_publishDate.TabIndex = 8
        '
        'HNowPage
        '
        Me.HNowPage.Location = New System.Drawing.Point(148, 451)
        Me.HNowPage.Name = "HNowPage"
        Me.HNowPage.Size = New System.Drawing.Size(56, 21)
        Me.HNowPage.TabIndex = 23
        Me.HNowPage.Text = "1"
        Me.HNowPage.Visible = False
        '
        'txt_publishDate
        '
        Me.txt_publishDate.Location = New System.Drawing.Point(452, 57)
        Me.txt_publishDate.Name = "txt_publishDate"
        Me.txt_publishDate.Size = New System.Drawing.Size(130, 21)
        Me.txt_publishDate.TabIndex = 7
        '
        'HWhere
        '
        Me.HWhere.Location = New System.Drawing.Point(107, 451)
        Me.HWhere.Name = "HWhere"
        Me.HWhere.Size = New System.Drawing.Size(56, 21)
        Me.HWhere.TabIndex = 22
        Me.HWhere.Visible = False
        '
        'cb_bookType
        '
        Me.cb_bookType.FormattingEnabled = True
        Me.cb_bookType.Location = New System.Drawing.Point(77, 53)
        Me.cb_bookType.Name = "cb_bookType"
        Me.cb_bookType.Size = New System.Drawing.Size(145, 20)
        Me.cb_bookType.TabIndex = 5
        '
        'HAllPage
        '
        Me.HAllPage.Location = New System.Drawing.Point(227, 453)
        Me.HAllPage.Name = "HAllPage"
        Me.HAllPage.Size = New System.Drawing.Size(56, 21)
        Me.HAllPage.TabIndex = 25
        Me.HAllPage.Text = "0"
        Me.HAllPage.Visible = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(384, 61)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(65, 12)
        Me.label4.TabIndex = 6
        Me.label4.Text = "出版日期："
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(6, 60)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(65, 12)
        Me.label3.TabIndex = 4
        Me.label3.Text = "图书类别："
        '
        'Btn_Update
        '
        Me.Btn_Update.Enabled = False
        Me.Btn_Update.Location = New System.Drawing.Point(279, 453)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(76, 21)
        Me.Btn_Update.TabIndex = 26
        Me.Btn_Update.Text = "查看/编辑"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'txt_bookName
        '
        Me.txt_bookName.Location = New System.Drawing.Point(452, 18)
        Me.txt_bookName.Name = "txt_bookName"
        Me.txt_bookName.Size = New System.Drawing.Size(148, 21)
        Me.txt_bookName.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(381, 23)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 12)
        Me.label2.TabIndex = 2
        Me.label2.Text = "图书名称："
        '
        'HSelectID
        '
        Me.HSelectID.Location = New System.Drawing.Point(45, 451)
        Me.HSelectID.Name = "HSelectID"
        Me.HSelectID.Size = New System.Drawing.Size(56, 21)
        Me.HSelectID.TabIndex = 21
        Me.HSelectID.Visible = False
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(79, 20)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(143, 21)
        Me.txt_barcode.TabIndex = 1
        '
        'LBEnd
        '
        Me.LBEnd.Enabled = False
        Me.LBEnd.Location = New System.Drawing.Point(682, 450)
        Me.LBEnd.Name = "LBEnd"
        Me.LBEnd.Size = New System.Drawing.Size(64, 26)
        Me.LBEnd.TabIndex = 20
        Me.LBEnd.Text = "尾页"
        Me.LBEnd.UseVisualStyleBackColor = True
        '
        'Btn_Del
        '
        Me.Btn_Del.Enabled = False
        Me.Btn_Del.Location = New System.Drawing.Point(361, 451)
        Me.Btn_Del.Name = "Btn_Del"
        Me.Btn_Del.Size = New System.Drawing.Size(71, 24)
        Me.Btn_Del.TabIndex = 27
        Me.Btn_Del.Text = "删除记录"
        Me.Btn_Del.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 12)
        Me.label1.TabIndex = 0
        Me.label1.Text = "图书条形码："
        '
        'LBNext
        '
        Me.LBNext.Enabled = False
        Me.LBNext.Location = New System.Drawing.Point(612, 449)
        Me.LBNext.Name = "LBNext"
        Me.LBNext.Size = New System.Drawing.Size(64, 26)
        Me.LBNext.TabIndex = 19
        Me.LBNext.Text = "下一页"
        Me.LBNext.UseVisualStyleBackColor = True
        '
        'LBUp
        '
        Me.LBUp.Enabled = False
        Me.LBUp.Location = New System.Drawing.Point(538, 449)
        Me.LBUp.Name = "LBUp"
        Me.LBUp.Size = New System.Drawing.Size(64, 26)
        Me.LBUp.TabIndex = 18
        Me.LBUp.Text = "上一页"
        Me.LBUp.UseVisualStyleBackColor = True
        '
        'LBHome
        '
        Me.LBHome.Enabled = False
        Me.LBHome.Location = New System.Drawing.Point(468, 449)
        Me.LBHome.Name = "LBHome"
        Me.LBHome.Size = New System.Drawing.Size(64, 26)
        Me.LBHome.TabIndex = 17
        Me.LBHome.Text = "首页"
        Me.LBHome.UseVisualStyleBackColor = True
        '
        'PageMes
        '
        Me.PageMes.AutoSize = True
        Me.PageMes.Location = New System.Drawing.Point(1, 454)
        Me.PageMes.Name = "PageMes"
        Me.PageMes.Size = New System.Drawing.Size(41, 12)
        Me.PageMes.TabIndex = 16
        Me.PageMes.Text = "待查询"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Btn_Query)
        Me.groupBox1.Controls.Add(Me.dtp_publishDate)
        Me.groupBox1.Controls.Add(Me.txt_publishDate)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.cb_bookType)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txt_bookName)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txt_barcode)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(3, 2)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(744, 91)
        Me.groupBox1.TabIndex = 14
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "设置查询条件"
        '
        'FrmQueryBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 476)
        Me.Controls.Add(Me.dataGridView_Book)
        Me.Controls.Add(Me.HPageSize)
        Me.Controls.Add(Me.HNowPage)
        Me.Controls.Add(Me.HWhere)
        Me.Controls.Add(Me.HAllPage)
        Me.Controls.Add(Me.Btn_Update)
        Me.Controls.Add(Me.HSelectID)
        Me.Controls.Add(Me.LBEnd)
        Me.Controls.Add(Me.Btn_Del)
        Me.Controls.Add(Me.LBNext)
        Me.Controls.Add(Me.LBUp)
        Me.Controls.Add(Me.LBHome)
        Me.Controls.Add(Me.PageMes)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmQueryBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "图书信息查询"
        CType(Me.dataGridView_Book, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Btn_Query As System.Windows.Forms.Button
    Private WithEvents dataGridView_Book As System.Windows.Forms.DataGridView
    Private WithEvents HPageSize As System.Windows.Forms.TextBox
    Private WithEvents dtp_publishDate As System.Windows.Forms.DateTimePicker
    Private WithEvents HNowPage As System.Windows.Forms.TextBox
    Private WithEvents txt_publishDate As System.Windows.Forms.TextBox
    Private WithEvents HWhere As System.Windows.Forms.TextBox
    Private WithEvents cb_bookType As System.Windows.Forms.ComboBox
    Private WithEvents HAllPage As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents Btn_Update As System.Windows.Forms.Button
    Private WithEvents txt_bookName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents HSelectID As System.Windows.Forms.TextBox
    Private WithEvents txt_barcode As System.Windows.Forms.TextBox
    Private WithEvents LBEnd As System.Windows.Forms.Button
    Private WithEvents Btn_Del As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents LBNext As System.Windows.Forms.Button
    Private WithEvents LBUp As System.Windows.Forms.Button
    Private WithEvents LBHome As System.Windows.Forms.Button
    Private WithEvents PageMes As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
End Class
