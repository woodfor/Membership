<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm管理员管理
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("男")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("女")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("性别", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm管理员管理))
        Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.toolStripLabel退出 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripLabel添加 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripLabel修改 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripLabel删除 = New System.Windows.Forms.ToolStripButton()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStripStatusLabel2
        '
        Me.toolStripStatusLabel2.AutoSize = False
        Me.toolStripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
        Me.toolStripStatusLabel2.Size = New System.Drawing.Size(100, 17)
        Me.toolStripStatusLabel2.Text = "toolStripStatusLabel2"
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridView1.Location = New System.Drawing.Point(3, 34)
        Me.dataGridView1.Name = "dataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridView1.RowTemplate.Height = 23
        Me.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataGridView1.Size = New System.Drawing.Size(766, 359)
        Me.dataGridView1.TabIndex = 0
        '
        'splitContainer1
        '
        Me.splitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.splitContainer1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.splitContainer1.Location = New System.Drawing.Point(12, 77)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.treeView1)
        Me.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.label1)
        Me.splitContainer1.Panel2.Controls.Add(Me.button1)
        Me.splitContainer1.Panel2.Controls.Add(Me.textBox1)
        Me.splitContainer1.Panel2.Controls.Add(Me.dataGridView1)
        Me.splitContainer1.Size = New System.Drawing.Size(901, 407)
        Me.splitContainer1.SplitterDistance = 117
        Me.splitContainer1.SplitterWidth = 5
        Me.splitContainer1.TabIndex = 19
        '
        'treeView1
        '
        Me.treeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeView1.Location = New System.Drawing.Point(3, 3)
        Me.treeView1.Name = "treeView1"
        TreeNode1.Name = "节点35"
        TreeNode1.Text = "男"
        TreeNode2.Name = "节点36"
        TreeNode2.Text = "女"
        TreeNode3.Name = "节点22"
        TreeNode3.Text = "性别"
        Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.treeView1.Size = New System.Drawing.Size(109, 399)
        Me.treeView1.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(462, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 12)
        Me.label1.TabIndex = 3
        Me.label1.Text = "用户名:"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(679, 5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 2
        Me.button1.Text = "快速搜索"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(515, 7)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(139, 21)
        Me.textBox1.TabIndex = 1
        '
        'toolStripStatusLabel1
        '
        Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
        Me.toolStripStatusLabel1.Size = New System.Drawing.Size(80, 17)
        Me.toolStripStatusLabel1.Text = "总记录数量："
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripStatusLabel2})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 487)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(925, 22)
        Me.statusStrip1.TabIndex = 18
        Me.statusStrip1.Text = "statusStrip1"
        '
        'toolStripLabel退出
        '
        Me.toolStripLabel退出.Image = CType(resources.GetObject("toolStripLabel退出.Image"), System.Drawing.Image)
        Me.toolStripLabel退出.Name = "toolStripLabel退出"
        Me.toolStripLabel退出.Size = New System.Drawing.Size(54, 71)
        Me.toolStripLabel退出.Text = "退  出"
        Me.toolStripLabel退出.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 74)
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 74)
        '
        'toolStripButton1
        '
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(60, 71)
        Me.toolStripButton1.Text = "显示全部"
        Me.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStrip1
        '
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripSeparator3, Me.toolStripButton1, Me.toolStripLabel添加, Me.toolStripLabel修改, Me.toolStripLabel删除, Me.toolStripSeparator2, Me.toolStripLabel退出})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(925, 74)
        Me.toolStrip1.TabIndex = 17
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripLabel添加
        '
        Me.toolStripLabel添加.Image = CType(resources.GetObject("toolStripLabel添加.Image"), System.Drawing.Image)
        Me.toolStripLabel添加.Name = "toolStripLabel添加"
        Me.toolStripLabel添加.Size = New System.Drawing.Size(60, 71)
        Me.toolStripLabel添加.Text = "人员新增"
        Me.toolStripLabel添加.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripLabel修改
        '
        Me.toolStripLabel修改.Enabled = False
        Me.toolStripLabel修改.Image = CType(resources.GetObject("toolStripLabel修改.Image"), System.Drawing.Image)
        Me.toolStripLabel修改.Name = "toolStripLabel修改"
        Me.toolStripLabel修改.Size = New System.Drawing.Size(60, 71)
        Me.toolStripLabel修改.Text = "信息修改"
        Me.toolStripLabel修改.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripLabel删除
        '
        Me.toolStripLabel删除.Enabled = False
        Me.toolStripLabel删除.Image = CType(resources.GetObject("toolStripLabel删除.Image"), System.Drawing.Image)
        Me.toolStripLabel删除.Name = "toolStripLabel删除"
        Me.toolStripLabel删除.Size = New System.Drawing.Size(60, 71)
        Me.toolStripLabel删除.Text = "信息删除"
        Me.toolStripLabel删除.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Frm管理员管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 509)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(941, 547)
        Me.MinimumSize = New System.Drawing.Size(941, 547)
        Me.Name = "Frm管理员管理"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "管理员管理"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents toolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents treeView1 As System.Windows.Forms.TreeView
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents toolStripLabel退出 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripLabel添加 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripLabel修改 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripLabel删除 As System.Windows.Forms.ToolStripButton
End Class
