﻿Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Xml
Imports System.Net.Sockets
Imports System.Threading.Thread

Partial Public Class Frm主面
    Inherits Form
    Dim leftTime As String
    Dim setTime As String
    Public Sub New()
        InitializeComponent()
    End Sub
    '现在时间
    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
        tool_NowTime.Text = DateTime.Now.ToString()

    End Sub

    '退出系统
    Private Sub toolStripMenuItem6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem6.Click
        Dim button As DialogResult = MessageBox.Show("确定要退出系统?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If button = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub


    Private Sub toolStripLabel16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripLabel16.Click
        Dim button As DialogResult = MessageBox.Show("确定要退出系统?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If button = DialogResult.Yes Then
            Application.ExitThread()
        End If
    End Sub

    ''' <summary>
    ''' 窗体加载
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Frm主面_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        timer1.Enabled = True
        Timer2.Interval = 5400 * 1000
        Timer2.Enabled = True
        Me.tool_UserName.Text = LoginRoler.U_Name
        '用户名
        If LoginRoler.U_ROlesType = 1 Then
            toolStripMenuItem8.Visible = False
            toolStripButton3.Visible = False
            toolStripButton4.Visible = False
            toolStripButton5.Visible = False
            toolStripSeparator2.Visible = False
            toolStripButton6.Visible = False
            toolStripMenuItem7.Visible = False
            toolStripButton7.Visible = False
        Else
            '管理员

            'toolStripMenuItem2.Visible = False
            toolStripMenuItem11.Visible = False
            toolStripButton1.Visible = False
            toolStripButton2.Visible = False
            toolStripSeparator4.Visible = False
            toolStripLabel10.Visible = False
            toolStripLabel11.Visible = False
            toolStripSeparator3.Visible = False
        End If


    End Sub


    '个人信息
    Private Sub toolStripMenuItem1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem1.Click
        Dim frm As New Frm个人信息()
        frm.Message(LoginRoler.U_Id, "Update")
        frm.ShowDialog()
    End Sub
    '密码修改
    Private Sub toolStripMenuItem4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem4.Click
        Dim common As New Common
        common.UpdatePassword()
    End Sub
    '离开挂起
    Private Sub toolStripMenuItem5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem5.Click
        Dim common As New Common
        common.KeepLeve()
    End Sub
    '密码修改
    Private Sub toolStripLabel2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripLabel2.Click
        toolStripMenuItem4_Click(sender, e)
    End Sub
    '离开挂起
    Private Sub toolStripLabel3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripLabel3.Click
        toolStripMenuItem5_Click(sender, e)
    End Sub
    '用户管理
    Private Sub 用户管理ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 用户管理ToolStripMenuItem.Click
        Dim frm As New Frm人员管理()
        frm.ShowDialog()
    End Sub
    '管理员管理
    Private Sub 管理员管理ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 管理员管理ToolStripMenuItem.Click
        Dim frm As New Frm管理员管理()
        frm.ShowDialog()
    End Sub
    '用户管理
    Private Sub toolStripButton6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton6.Click
        用户管理ToolStripMenuItem_Click(sender, e)
    End Sub
    '管理员管理
    Private Sub toolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton4.Click
        管理员管理ToolStripMenuItem_Click(sender, e)
    End Sub
    '站点维护
    Private Sub toolStripButton7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton7.Click

    End Sub
    '车次管理
    '车次管理
    Private Sub toolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton5.DisplayStyleChanged

    End Sub
    '列车管理
    Private Sub toolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton3.Click

    End Sub
    '列车管理
    Private Sub 车票管理ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        toolStripButton3_Click(sender, e)
    End Sub
    '车次
    Private Sub toolStripLabel10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripLabel10.Click

    End Sub
    '站点维护
    Private Sub 站点维护ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        toolStripButton7_Click(sender, e)
    End Sub
    '车次
    Private Sub toolStripMenuItem12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem12.Click
        toolStripLabel10_Click(sender, e)
    End Sub
    'Frm车票查询
    Private Sub toolStripLabel11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripLabel11.Click
    End Sub
    'Frm车票查询
    Private Sub 个检信息分析ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 个检信息分析ToolStripMenuItem.Click
        toolStripLabel11_Click(sender, e)
    End Sub
    '订票记录
    'Private Sub toolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton2.Click
    'End Sub
    '订票记录
    Private Sub 订票记录ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 订票记录ToolStripMenuItem.Click
        'toolStripButton2_Click(sender, e)
        FrmAllStore.Show()
    End Sub

    Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
    End Sub

    Private Sub 退票记录ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles 退票记录ToolStripMenuItem.Click
        toolStripButton1_Click(sender, e)
    End Sub

    Private Sub toolStripMenuItem16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem16.Click
        Dim common As New Common
        common.ShowHelp()
    End Sub

    Private Sub toolStripMenuItem17_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripMenuItem17.Click
        Dim common As New Common
        common.ShowAbout()
    End Sub

    '添加图书类别
    Private Sub BookTypeAdd_ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BookTypeAdd_ToolStripMenuItem.Click
        Dim frm As New FrmAddBookType()
        frm.ShowDialog()
    End Sub

    Private Sub BookAdd_ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BookAdd_ToolStripMenuItem.Click
        Dim frmAddBook As New FrmAddBook()
        frmAddBook.ShowDialog()
    End Sub

    Private Sub BookManage_ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BookManage_ToolStripMenuItem.Click
        Dim frmQueryBook As New FrmQueryBook()
        frmQueryBook.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim flag As Boolean = False
        For i As Integer = 0 To 2
            If BLL.GetToken.GetToken() = True Then
                flag = True
                Exit For
            Else
                flag = False
                Sleep(1000)
            End If
        Next
        If flag = True Then
            MessageBox.Show("连接服务器发生错误，请检查网络。如网络未发生异常，请联系客服。")
        End If
    End Sub


End Class