<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStore
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
        Me.Text_name = New System.Windows.Forms.TextBox()
        Me.Text_city = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Text_admin_name = New System.Windows.Forms.TextBox()
        Me.Text_admin_phone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Text_phone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Text_street = New System.Windows.Forms.TextBox()
        Me.Button_edit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Text_name
        '
        Me.Text_name.Location = New System.Drawing.Point(280, 56)
        Me.Text_name.Name = "Text_name"
        Me.Text_name.Size = New System.Drawing.Size(197, 25)
        Me.Text_name.TabIndex = 0
        '
        'Text_city
        '
        Me.Text_city.Location = New System.Drawing.Point(280, 105)
        Me.Text_city.Name = "Text_city"
        Me.Text_city.Size = New System.Drawing.Size(197, 25)
        Me.Text_city.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "店面名字："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "所在城市："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(131, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "经理名字："
        '
        'Text_admin_name
        '
        Me.Text_admin_name.Location = New System.Drawing.Point(280, 211)
        Me.Text_admin_name.Name = "Text_admin_name"
        Me.Text_admin_name.Size = New System.Drawing.Size(197, 25)
        Me.Text_admin_name.TabIndex = 5
        '
        'Text_admin_phone
        '
        Me.Text_admin_phone.Location = New System.Drawing.Point(280, 259)
        Me.Text_admin_phone.Name = "Text_admin_phone"
        Me.Text_admin_phone.Size = New System.Drawing.Size(197, 25)
        Me.Text_admin_phone.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "经理电话："
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "店面联系电话："
        '
        'Text_phone
        '
        Me.Text_phone.Location = New System.Drawing.Point(280, 306)
        Me.Text_phone.Name = "Text_phone"
        Me.Text_phone.Size = New System.Drawing.Size(197, 25)
        Me.Text_phone.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "所在街道："
        '
        'Text_street
        '
        Me.Text_street.Location = New System.Drawing.Point(280, 156)
        Me.Text_street.Name = "Text_street"
        Me.Text_street.Size = New System.Drawing.Size(326, 25)
        Me.Text_street.TabIndex = 11
        '
        'Button_edit
        '
        Me.Button_edit.Location = New System.Drawing.Point(239, 375)
        Me.Button_edit.Name = "Button_edit"
        Me.Button_edit.Size = New System.Drawing.Size(155, 42)
        Me.Button_edit.TabIndex = 12
        Me.Button_edit.Text = "修改店面信息"
        Me.Button_edit.UseVisualStyleBackColor = True
        '
        'FrmStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 458)
        Me.Controls.Add(Me.Button_edit)
        Me.Controls.Add(Me.Text_street)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Text_phone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Text_admin_phone)
        Me.Controls.Add(Me.Text_admin_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Text_city)
        Me.Controls.Add(Me.Text_name)
        Me.Name = "FrmStore"
        Me.Text = "店面信息"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Text_name As TextBox
    Friend WithEvents Text_city As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Text_admin_name As TextBox
    Friend WithEvents Text_admin_phone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Text_phone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Text_street As TextBox
    Friend WithEvents Button_edit As Button
End Class
