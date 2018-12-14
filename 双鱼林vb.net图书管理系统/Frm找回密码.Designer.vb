<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm找回密码
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm找回密码))
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.cmbQuestion = New System.Windows.Forms.ComboBox()
        Me.txt_anask = New System.Windows.Forms.TextBox()
        Me.txt_UserName = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.Location = New System.Drawing.Point(230, 240)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 28)
        Me.button2.TabIndex = 29
        Me.button2.Text = "取   消"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        Me.button1.Location = New System.Drawing.Point(108, 241)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 27)
        Me.button1.TabIndex = 28
        Me.button1.Text = "确  定"
        Me.button1.UseVisualStyleBackColor = True
        '
        'cmbQuestion
        '
        Me.cmbQuestion.FormattingEnabled = True
        Me.cmbQuestion.Location = New System.Drawing.Point(119, 98)
        Me.cmbQuestion.Name = "cmbQuestion"
        Me.cmbQuestion.Size = New System.Drawing.Size(186, 20)
        Me.cmbQuestion.TabIndex = 27
        Me.cmbQuestion.Text = "==选择密保问题="
        '
        'txt_anask
        '
        Me.txt_anask.Location = New System.Drawing.Point(119, 154)
        Me.txt_anask.Name = "txt_anask"
        Me.txt_anask.Size = New System.Drawing.Size(185, 21)
        Me.txt_anask.TabIndex = 26
        '
        'txt_UserName
        '
        Me.txt_UserName.Location = New System.Drawing.Point(120, 42)
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.Size = New System.Drawing.Size(185, 21)
        Me.txt_UserName.TabIndex = 25
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(54, 163)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(59, 12)
        Me.label3.TabIndex = 24
        Me.label3.Text = "密保回答:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(54, 106)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(59, 12)
        Me.label2.TabIndex = 23
        Me.label2.Text = "密保问题:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(54, 51)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(47, 12)
        Me.label1.TabIndex = 22
        Me.label1.Text = "用户名:"
        '
        'Frm找回密码
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 310)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.cmbQuestion)
        Me.Controls.Add(Me.txt_anask)
        Me.Controls.Add(Me.txt_UserName)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(374, 348)
        Me.MinimumSize = New System.Drawing.Size(374, 348)
        Me.Name = "Frm找回密码"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Frm找回密码"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents cmbQuestion As System.Windows.Forms.ComboBox
    Private WithEvents txt_anask As System.Windows.Forms.TextBox
    Private WithEvents txt_UserName As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
