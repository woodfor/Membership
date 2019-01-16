Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports BLL


Partial Public Class FrmAuthPrompt
    Inherits Form
    'mode 1 挂起
    'mode 2 用户提权
    Private mode As Integer
    Private result As Boolean
    Public Sub New(ByVal mode As Integer)
        InitializeComponent()
        Me.mode = mode
        If mode = 1 Then

        ElseIf mode = 2 Then
            butjiesuo.Text = "验证"
            button1.Text = "取消操作"
        End If
    End Sub
    Public Shadows Function AuthResult() As Boolean
        MyBase.ShowDialog()
        Return Me.result
    End Function
    Private Sub butjiesuo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles butjiesuo.Click
        Dim password As String = txtpwd.Text

        If txtpwd.Text = "" Then
            MessageBox.Show("密码输入不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            '密码处理,经过加密
            Dim result As Byte() = Encoding.[Default].GetBytes(password)
            'password为输入密码的文本框
            Dim md5 As MD5 = New MD5CryptoServiceProvider()
            Dim output As Byte() = md5.ComputeHash(result)

            Dim bll As New BU_UserInfo()
            Dim ds As DataSet = bll.ExistsPwd(lbuser.Text.Trim(), BitConverter.ToString(output).Replace("-", ""))

            If ds.Tables(0).Rows.Count > 0 Then
                'MessageBox.Show("解锁成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.result = True
                Me.Close()
            Else
                MessageBox.Show("密码输入错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub
    '退出
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        If mode = 1 Then
            Dim button As DialogResult = MessageBox.Show("确定要退出系统?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

            If button = DialogResult.Yes Then
                Application.ExitThread()
            End If
        ElseIf mode = 2 Then
            Me.result = False
            Me.Close()
        End If

    End Sub
    Private Sub Frm离开挂起_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.lbuser.Text = LoginRoler.U_Name

    End Sub
End Class
