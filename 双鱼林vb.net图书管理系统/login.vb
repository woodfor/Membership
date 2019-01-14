Imports System.Security
Imports System.Security.Cryptography
Imports BLL
Imports Model
Imports System.Text

Public Delegate Sub GetName(ByVal name As String)

Partial Public Class login
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Event getName As GetName
    Public Pagetype As String = ""
    Private frmManage As Frm管理员管理
    Private frmUser As Frm人员管理
    '操作类型
    ''' <summary>
    ''' 取消
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 注册
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim UserName As String = Me.txt_username.Text.Trim()
        '姓名
        Dim Sex As Boolean = True
        '性别
        If Me.radio_women.Checked Then
            Sex = False
        End If

        Dim birthday As String = Me.time_Birthday.Text
        '出身日期
        Dim pwd As String = Me.txt_pwd.Text.Trim()
        '密码1
        Dim pwd2 As String = Me.txt_pwd2.Text.Trim()
        '密码2
        If UserName = "" Then
            MessageBox.Show("用户名输入不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf pwd = "" Then
            MessageBox.Show("密码不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf pwd2 = "" Then
            MessageBox.Show("确认密码不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf pwd <> pwd2 Then
            MessageBox.Show("密码输入不相同,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.txt_pwd2.Text = ""
        Else
            Dim Bll As New BU_UserInfo()

            Dim a As Integer = Bll.ExistsName(UserName)

            If a <> 0 Then
                MessageBox.Show("用户名已经存在,请重新注册", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                Dim info As New MU_UserInfo()

                '密码处理,经过加密
                Dim result__1 As Byte() = Encoding.[Default].GetBytes(pwd2)
                'pwd2为输入密码的文本框
                Dim md5 As MD5 = New MD5CryptoServiceProvider()
                Dim output As Byte() = md5.ComputeHash(result__1)
                info.U_PassWord = BitConverter.ToString(output).Replace("-", "")

                info.U_Name = UserName
                info.U_Sex = Sex
                info.U_Birthday = Convert.ToDateTime(birthday)
                info.U_LoginTime = DateTime.Now
                info.store_id = 1
                If Pagetype = "AddAdmin" Then
                    '管理员
                    info.U_RoleType = 2
                Else
                    '普通用户
                    info.U_RoleType = 1
                End If


                Dim Result__2 As Integer = Bll.Add(info)

                If Result__2 = 0 Then
                    MessageBox.Show("注册失败,请重新注册", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

                If info.U_RoleType = 2 Then
                    frmManage.dataBind()
                End If

                If Me.Pagetype = "reload" Then
                    frmUser.dataBind()
                End If
                'RaiseEvent getName(UserName)
                Me.Close()
            End If
        End If
    End Sub


    ''' <summary>
    ''' 传递参数
    ''' </summary>
    ''' <param name="sid">主键</param>
    ''' <param name="type">添加 | 修改</param>
    Public Sub Message(ByVal type As String)
        Me.Pagetype = type
    End Sub

    Public Sub Message(ByVal type As String, ByRef frmManage As Frm管理员管理)

        Me.Pagetype = type
        Me.frmManage = frmManage
    End Sub

    Public Sub Message(ByVal type As String, ByRef frmUser As Frm人员管理)

        Me.Pagetype = type
        Me.frmUser = frmUser
    End Sub


End Class