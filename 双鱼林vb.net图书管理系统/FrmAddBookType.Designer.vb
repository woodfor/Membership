<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddBookType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddBookType))
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.txt_days = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txt_bookTypeName = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(149, 208)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(118, 23)
        Me.Btn_Add.TabIndex = 9
        Me.Btn_Add.Text = "添加"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'txt_days
        '
        Me.txt_days.Location = New System.Drawing.Point(149, 131)
        Me.txt_days.Name = "txt_days"
        Me.txt_days.Size = New System.Drawing.Size(95, 21)
        Me.txt_days.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(61, 140)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(71, 12)
        Me.label2.TabIndex = 7
        Me.label2.Text = "可借阅天数:"
        '
        'txt_bookTypeName
        '
        Me.txt_bookTypeName.Location = New System.Drawing.Point(149, 52)
        Me.txt_bookTypeName.Name = "txt_bookTypeName"
        Me.txt_bookTypeName.Size = New System.Drawing.Size(167, 21)
        Me.txt_bookTypeName.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(61, 61)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(59, 12)
        Me.label1.TabIndex = 5
        Me.label1.Text = "类别名称:"
        '
        'FrmAddBookType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 282)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.txt_days)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txt_bookTypeName)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAddBookType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "添加图书类别"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Btn_Add As System.Windows.Forms.Button
    Private WithEvents txt_days As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents txt_bookTypeName As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
