<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm登陆成功显示进度
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
        Me.components = New System.ComponentModel.Container()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(0, 4)
        Me.progressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(485, 51)
        Me.progressBar1.TabIndex = 2
        '
        'timer1
        '
        Me.timer1.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(201, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'Frm登陆成功显示进度
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 46)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.progressBar1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(502, 93)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(502, 93)
        Me.Name = "Frm登陆成功显示进度"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "窗体正在初始化。。。"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents progressBar1 As System.Windows.Forms.ProgressBar
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As Label
End Class
