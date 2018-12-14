Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports BLL

Partial Public Class Frm密码修改
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub
    ''' <summary>
    ''' 取消
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 确定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim pwd As String = Me.txt_pwd.Text.Trim()
        '密码1
        Dim pwd2 As String = Me.txt_pwd2.Text.Trim()
        '密码2
        If pwd = "" Then
            MessageBox.Show("密码不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf pwd2 = "" Then
            MessageBox.Show("确认密码不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf pwd <> pwd2 Then
            MessageBox.Show("密码输入不相同,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.txt_pwd2.Text = ""
        Else
            Dim bll As New BU_UserInfo()

            Dim id As Integer = LoginRoler.U_Id

            '密码处理,经过加密
            Dim result As Byte() = Encoding.[Default].GetBytes(pwd2)
            'pwd2为输入密码的文本框
            Dim md5 As MD5 = New MD5CryptoServiceProvider()
            Dim output As Byte() = md5.ComputeHash(result)

            Dim NewPwd As String = BitConverter.ToString(output).Replace("-", "")

            Dim flag As Boolean = bll.UpdatePassword(NewPwd, id)

            If flag Then
                MessageBox.Show("密码更改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                MessageBox.Show("密码更改失败,关闭后请重新更改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            Me.Close()
        End If
    End Sub
End Class