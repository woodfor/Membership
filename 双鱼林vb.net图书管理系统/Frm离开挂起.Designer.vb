<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm离开挂起
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm离开挂起))
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.butjiesuo = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lbuser = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(176, 100)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 24)
        Me.button1.TabIndex = 14
        Me.button1.Text = "退出系统"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtpwd
        '
        Me.txtpwd.Location = New System.Drawing.Point(117, 63)
        Me.txtpwd.MaxLength = 10
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(135, 21)
        Me.txtpwd.TabIndex = 13
        '
        'butjiesuo
        '
        Me.butjiesuo.Location = New System.Drawing.Point(108, 101)
        Me.butjiesuo.Name = "butjiesuo"
        Me.butjiesuo.Size = New System.Drawing.Size(62, 23)
        Me.butjiesuo.TabIndex = 12
        Me.butjiesuo.Text = "解  除(&D)"
        Me.butjiesuo.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(38, 70)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(77, 12)
        Me.label3.TabIndex = 11
        Me.label3.Text = "请输入密码："
        '
        'lbuser
        '
        Me.lbuser.AutoSize = True
        Me.lbuser.Location = New System.Drawing.Point(116, 25)
        Me.lbuser.Name = "lbuser"
        Me.lbuser.Size = New System.Drawing.Size(29, 12)
        Me.lbuser.TabIndex = 10
        Me.lbuser.Text = "null"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(39, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 12)
        Me.label1.TabIndex = 9
        Me.label1.Text = "当前管理员："
        '
        'Frm离开挂起
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 144)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.butjiesuo)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lbuser)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm离开挂起"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm离开挂起"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txtpwd As System.Windows.Forms.TextBox
    Private WithEvents butjiesuo As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents lbuser As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
