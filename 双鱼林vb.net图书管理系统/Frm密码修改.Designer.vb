<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm密码修改
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm密码修改))
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txt_pwd2 = New System.Windows.Forms.TextBox()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.Location = New System.Drawing.Point(178, 117)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 28)
        Me.button2.TabIndex = 25
        Me.button2.Text = "取   消"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        Me.button1.Location = New System.Drawing.Point(56, 118)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 27)
        Me.button1.TabIndex = 24
        Me.button1.Text = "确  定"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txt_pwd2
        '
        Me.txt_pwd2.Location = New System.Drawing.Point(80, 67)
        Me.txt_pwd2.MaxLength = 10
        Me.txt_pwd2.Name = "txt_pwd2"
        Me.txt_pwd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pwd2.Size = New System.Drawing.Size(149, 21)
        Me.txt_pwd2.TabIndex = 23
        '
        'txt_pwd
        '
        Me.txt_pwd.Location = New System.Drawing.Point(80, 28)
        Me.txt_pwd.MaxLength = 10
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pwd.Size = New System.Drawing.Size(149, 21)
        Me.txt_pwd.TabIndex = 22
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(17, 70)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(59, 12)
        Me.label3.TabIndex = 21
        Me.label3.Text = "确认密码:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(27, 31)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(47, 12)
        Me.label2.TabIndex = 20
        Me.label2.Text = "新密码:"
        '
        'Frm密码修改
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 173)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txt_pwd2)
        Me.Controls.Add(Me.txt_pwd)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(286, 211)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(286, 211)
        Me.Name = "Frm密码修改"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "密码修改"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txt_pwd2 As System.Windows.Forms.TextBox
    Private WithEvents txt_pwd As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
End Class
