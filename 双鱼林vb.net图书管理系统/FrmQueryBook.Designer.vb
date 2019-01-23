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
        Me.HNowPage = New System.Windows.Forms.TextBox()
        Me.HWhere = New System.Windows.Forms.TextBox()
        Me.HAllPage = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.labelx = New System.Windows.Forms.Label()
        Me.txt_bookName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.HSelectID = New System.Windows.Forms.TextBox()
        Me.txt_barcode = New System.Windows.Forms.TextBox()
        Me.LBEnd = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.LBNext = New System.Windows.Forms.Button()
        Me.LBUp = New System.Windows.Forms.Button()
        Me.LBHome = New System.Windows.Forms.Button()
        Me.PageMes = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        CType(Me.dataGridView_Book, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Query
        '
        Me.Btn_Query.Location = New System.Drawing.Point(845, 45)
        Me.Btn_Query.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Query.Name = "Btn_Query"
        Me.Btn_Query.Size = New System.Drawing.Size(119, 28)
        Me.Btn_Query.TabIndex = 9
        Me.Btn_Query.Text = "查询"
        Me.Btn_Query.UseVisualStyleBackColor = True
        '
        'dataGridView_Book
        '
        Me.dataGridView_Book.AllowUserToAddRows = False
        Me.dataGridView_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView_Book.Location = New System.Drawing.Point(4, 124)
        Me.dataGridView_Book.Margin = New System.Windows.Forms.Padding(4)
        Me.dataGridView_Book.Name = "dataGridView_Book"
        Me.dataGridView_Book.RowTemplate.Height = 23
        Me.dataGridView_Book.Size = New System.Drawing.Size(992, 432)
        Me.dataGridView_Book.TabIndex = 15
        '
        'HPageSize
        '
        Me.HPageSize.Location = New System.Drawing.Point(256, 564)
        Me.HPageSize.Margin = New System.Windows.Forms.Padding(4)
        Me.HPageSize.Name = "HPageSize"
        Me.HPageSize.Size = New System.Drawing.Size(73, 25)
        Me.HPageSize.TabIndex = 24
        Me.HPageSize.Text = "5"
        Me.HPageSize.Visible = False
        '
        'HNowPage
        '
        Me.HNowPage.Location = New System.Drawing.Point(197, 564)
        Me.HNowPage.Margin = New System.Windows.Forms.Padding(4)
        Me.HNowPage.Name = "HNowPage"
        Me.HNowPage.Size = New System.Drawing.Size(73, 25)
        Me.HNowPage.TabIndex = 23
        Me.HNowPage.Text = "1"
        Me.HNowPage.Visible = False
        '
        'HWhere
        '
        Me.HWhere.Location = New System.Drawing.Point(143, 564)
        Me.HWhere.Margin = New System.Windows.Forms.Padding(4)
        Me.HWhere.Name = "HWhere"
        Me.HWhere.Size = New System.Drawing.Size(73, 25)
        Me.HWhere.TabIndex = 22
        Me.HWhere.Visible = False
        '
        'HAllPage
        '
        Me.HAllPage.Location = New System.Drawing.Point(303, 566)
        Me.HAllPage.Margin = New System.Windows.Forms.Padding(4)
        Me.HAllPage.Name = "HAllPage"
        Me.HAllPage.Size = New System.Drawing.Size(73, 25)
        Me.HAllPage.TabIndex = 25
        Me.HAllPage.Text = "0"
        Me.HAllPage.Visible = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(512, 76)
        Me.label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(82, 15)
        Me.label4.TabIndex = 6
        Me.label4.Text = "充值日期："
        '
        'labelx
        '
        Me.labelx.AutoSize = True
        Me.labelx.Location = New System.Drawing.Point(23, 76)
        Me.labelx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelx.Name = "labelx"
        Me.labelx.Size = New System.Drawing.Size(82, 15)
        Me.labelx.TabIndex = 4
        Me.labelx.Text = "预留电话："
        '
        'txt_bookName
        '
        Me.txt_bookName.Location = New System.Drawing.Point(603, 26)
        Me.txt_bookName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_bookName.Name = "txt_bookName"
        Me.txt_bookName.Size = New System.Drawing.Size(196, 25)
        Me.txt_bookName.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(542, 32)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 15)
        Me.label2.TabIndex = 2
        Me.label2.Text = "名字："
        '
        'HSelectID
        '
        Me.HSelectID.Location = New System.Drawing.Point(60, 564)
        Me.HSelectID.Margin = New System.Windows.Forms.Padding(4)
        Me.HSelectID.Name = "HSelectID"
        Me.HSelectID.Size = New System.Drawing.Size(73, 25)
        Me.HSelectID.TabIndex = 21
        Me.HSelectID.Visible = False
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(113, 26)
        Me.txt_barcode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Size = New System.Drawing.Size(189, 25)
        Me.txt_barcode.TabIndex = 1
        '
        'LBEnd
        '
        Me.LBEnd.Enabled = False
        Me.LBEnd.Location = New System.Drawing.Point(909, 562)
        Me.LBEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.LBEnd.Name = "LBEnd"
        Me.LBEnd.Size = New System.Drawing.Size(85, 32)
        Me.LBEnd.TabIndex = 20
        Me.LBEnd.Text = "尾页"
        Me.LBEnd.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(38, 29)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "条形码："
        '
        'LBNext
        '
        Me.LBNext.Enabled = False
        Me.LBNext.Location = New System.Drawing.Point(816, 561)
        Me.LBNext.Margin = New System.Windows.Forms.Padding(4)
        Me.LBNext.Name = "LBNext"
        Me.LBNext.Size = New System.Drawing.Size(85, 32)
        Me.LBNext.TabIndex = 19
        Me.LBNext.Text = "下一页"
        Me.LBNext.UseVisualStyleBackColor = True
        '
        'LBUp
        '
        Me.LBUp.Enabled = False
        Me.LBUp.Location = New System.Drawing.Point(717, 561)
        Me.LBUp.Margin = New System.Windows.Forms.Padding(4)
        Me.LBUp.Name = "LBUp"
        Me.LBUp.Size = New System.Drawing.Size(85, 32)
        Me.LBUp.TabIndex = 18
        Me.LBUp.Text = "上一页"
        Me.LBUp.UseVisualStyleBackColor = True
        '
        'LBHome
        '
        Me.LBHome.Enabled = False
        Me.LBHome.Location = New System.Drawing.Point(624, 561)
        Me.LBHome.Margin = New System.Windows.Forms.Padding(4)
        Me.LBHome.Name = "LBHome"
        Me.LBHome.Size = New System.Drawing.Size(85, 32)
        Me.LBHome.TabIndex = 17
        Me.LBHome.Text = "首页"
        Me.LBHome.UseVisualStyleBackColor = True
        '
        'PageMes
        '
        Me.PageMes.AutoSize = True
        Me.PageMes.Location = New System.Drawing.Point(1, 568)
        Me.PageMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PageMes.Name = "PageMes"
        Me.PageMes.Size = New System.Drawing.Size(52, 15)
        Me.PageMes.TabIndex = 16
        Me.PageMes.Text = "待查询"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txt_date)
        Me.groupBox1.Controls.Add(Me.DateTimePicker1)
        Me.groupBox1.Controls.Add(Me.txt_phone)
        Me.groupBox1.Controls.Add(Me.Btn_Query)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.labelx)
        Me.groupBox1.Controls.Add(Me.txt_bookName)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.txt_barcode)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(4, 2)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.groupBox1.Size = New System.Drawing.Size(992, 114)
        Me.groupBox1.TabIndex = 14
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "设置查询条件"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(603, 73)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(196, 25)
        Me.txt_date.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(797, 73)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(21, 25)
        Me.DateTimePicker1.TabIndex = 11
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(113, 71)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(189, 25)
        Me.txt_phone.TabIndex = 10
        '
        'FrmQueryBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 595)
        Me.Controls.Add(Me.dataGridView_Book)
        Me.Controls.Add(Me.HPageSize)
        Me.Controls.Add(Me.HNowPage)
        Me.Controls.Add(Me.HWhere)
        Me.Controls.Add(Me.HAllPage)
        Me.Controls.Add(Me.HSelectID)
        Me.Controls.Add(Me.LBEnd)
        Me.Controls.Add(Me.LBNext)
        Me.Controls.Add(Me.LBUp)
        Me.Controls.Add(Me.LBHome)
        Me.Controls.Add(Me.PageMes)
        Me.Controls.Add(Me.groupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Private WithEvents HNowPage As System.Windows.Forms.TextBox
    Private WithEvents HWhere As System.Windows.Forms.TextBox
    Private WithEvents HAllPage As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents labelx As System.Windows.Forms.Label
    Private WithEvents txt_bookName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents HSelectID As System.Windows.Forms.TextBox
    Private WithEvents txt_barcode As System.Windows.Forms.TextBox
    Private WithEvents LBEnd As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents LBNext As System.Windows.Forms.Button
    Private WithEvents LBUp As System.Windows.Forms.Button
    Private WithEvents LBHome As System.Windows.Forms.Button
    Private WithEvents PageMes As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txt_phone As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Private WithEvents txt_date As TextBox
End Class
