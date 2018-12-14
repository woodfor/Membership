Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports BLL

Partial Public Class Frm找回密码
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Pagetype As String = ""
    '操作类型
    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Me.Close()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim [select] As String = cmbQuestion.SelectedIndex.ToString()

        Dim password As String = Me.txt_anask.Text

        Dim Bll As New BU_UserInfo()

        If Pagetype = "false" Then
            '完善个人资料
            If [select] = "-1" Then
                MessageBox.Show("请选择密保!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf password = "" Then
                MessageBox.Show("回答不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                Dim flag As Boolean = Bll.UpdateU_PsdAnswer(Convert.ToInt32([select]), password, LoginRoler.U_Id)

                If flag Then
                    Me.Close()
                Else
                    MessageBox.Show("申请失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            End If
        Else
            '登录
            Dim username As String = Me.txt_UserName.Text

            If username = "" Then
                MessageBox.Show("用户名不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf [select] = "-1" Then
                MessageBox.Show("请选择密保!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ElseIf password = "" Then
                MessageBox.Show("回答不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                Dim a As Integer = Bll.ExistsName(username)

                If a <> 0 Then
                    '密码处理,经过加密
                    Dim ds As DataSet = Bll.ShowPwd(username, password.Trim())

                    Dim PWD As String = ds.Tables(0).Rows(0)(0).ToString()
                    If PWD <> "" Then
                        MessageBox.Show("查询成功!你的密码是:<" & PWD & ">  请牢记", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Else
                        MessageBox.Show("密保输入错误,请重新输入密保", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.txt_anask.Text = ""
                    End If
                Else
                    MessageBox.Show("用户名不存在,请重新输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.txt_UserName.Text = ""

                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' 窗体加载
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Frm找回密码_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitSet()

        '隐藏用户名
        If Pagetype = "false" Then
            label1.Visible = False
            txt_UserName.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' 加载所有问题类型
    ''' </summary>
    Public Sub InitSet()
        Dim bll As New BU_UserInfo()
        Dim ds As DataSet = bll.GetMP_PasswordType()

        If ds.Tables(0).Rows.Count > 0 Then
            Me.cmbQuestion.DataSource = ds.Tables(0)
            cmbQuestion.DisplayMember = "U_Name"
            cmbQuestion.ValueMember = "P_Id"
        Else
            cmbQuestion.Text = "=暂停访问="
        End If
    End Sub

    ''' <summary>
    ''' 传递参数
    Public Sub Message(ByVal type As String)
        Me.Pagetype = type
    End Sub
End Class