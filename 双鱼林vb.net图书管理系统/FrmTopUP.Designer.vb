<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTopUP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label_trans = New System.Windows.Forms.Label()
        Me.Text_money = New System.Windows.Forms.TextBox()
        Me.But_confirm = New System.Windows.Forms.Button()
        Me.But_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_trans
        '
        Me.Label_trans.AutoSize = True
        Me.Label_trans.Font = New System.Drawing.Font("SimSun", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_trans.Location = New System.Drawing.Point(110, 129)
        Me.Label_trans.Name = "Label_trans"
        Me.Label_trans.Size = New System.Drawing.Size(118, 24)
        Me.Label_trans.TabIndex = 0
        Me.Label_trans.Text = "充值金额:"
        '
        'Text_money
        '
        Me.Text_money.Location = New System.Drawing.Point(288, 128)
        Me.Text_money.Name = "Text_money"
        Me.Text_money.Size = New System.Drawing.Size(253, 25)
        Me.Text_money.TabIndex = 1
        '
        'But_confirm
        '
        Me.But_confirm.Location = New System.Drawing.Point(133, 241)
        Me.But_confirm.Name = "But_confirm"
        Me.But_confirm.Size = New System.Drawing.Size(131, 56)
        Me.But_confirm.TabIndex = 2
        Me.But_confirm.Text = "确定"
        Me.But_confirm.UseVisualStyleBackColor = True
        '
        'But_cancel
        '
        Me.But_cancel.Location = New System.Drawing.Point(391, 241)
        Me.But_cancel.Name = "But_cancel"
        Me.But_cancel.Size = New System.Drawing.Size(131, 56)
        Me.But_cancel.TabIndex = 3
        Me.But_cancel.Text = "取消"
        Me.But_cancel.UseVisualStyleBackColor = True
        '
        'FrmTopUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 416)
        Me.Controls.Add(Me.But_cancel)
        Me.Controls.Add(Me.But_confirm)
        Me.Controls.Add(Me.Text_money)
        Me.Controls.Add(Me.Label_trans)
        Me.Name = "FrmTopUP"
        Me.Text = "充值"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_trans As Label
    Friend WithEvents Text_money As TextBox
    Friend WithEvents But_confirm As Button
    Friend WithEvents But_cancel As Button
End Class
