Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports BLL



Partial Public Class Frm人员管理
    Inherits Form
    Public Sub New()

        InitializeComponent()
    End Sub

    '退出
    Private Sub toolStripLabel退出_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripLabel退出.Click
        Me.Close()
    End Sub
    '人员新增
    Private Sub toolStripLabel添加_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripLabel添加.Click
        Dim frm As New login()
        'frm.getName += New GetName(AddressOf login_getName)
        frm.Message("reload", Me)
        frm.ShowDialog()
    End Sub

    '委托获取传来的值 (刷新列表)
    Public Sub login_getName(ByVal s As String)
        dataBind()
    End Sub

    '修改
    Private Sub toolStripLabel修改_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripLabel修改.Click
        If DirectCast(dataGridView1.SelectedRows, System.Windows.Forms.BaseCollection).Count > 1 Then

            MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim frm As New Frm个人信息()
            Dim UserID As Integer = Convert.ToInt32(dataGridView1.CurrentRow.Cells(0).Value)
            frm.Message(UserID, "Update", Me)
            'frm.getName += New GetState(AddressOf login_getName)
            frm.ShowDialog()
        End If
    End Sub

    ''' <summary>
    ''' 绑定数据源
    ''' </summary>
    Public Sub dataBind()
        Dim ds As DataSet = New BU_UserInfo().SelectAdmin("U_RoleType=1")
        '查询普通用户
        dataGridView1.DataSource = ds.Tables(0).DefaultView
        toolStripStatusLabel2.Text = dataGridView1.Rows.Count.ToString()
    End Sub

    Private Sub dataGridView1_RowStateChanged(ByVal sender As Object, ByVal e As DataGridViewRowStateChangedEventArgs) Handles dataGridView1.RowStateChanged
        If dataGridView1.SelectedRows IsNot Nothing Then
            toolStripLabel修改.Enabled = True
            toolStripLabel删除.Enabled = True
        Else
            toolStripLabel修改.Enabled = True
            toolStripLabel删除.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' 查询
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim userName As String = textBox1.Text.Trim()
        If userName = "" Then
            toolStripButton1_Click_1(sender, e)
        Else
            Dim ds As DataSet = New BU_UserInfo().SelectAdmin("U_RoleType=1 and U_Sex=0 and U_Name like '%" & userName & "%' ")
            dataGridView1.DataSource = ds.Tables(0).DefaultView
        End If
    End Sub

    Private Sub toolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs)
        dataBind()
    End Sub
    '删除
    Private Sub toolStripLabel删除_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripLabel删除.Click
        If DirectCast(dataGridView1.SelectedRows, System.Windows.Forms.BaseCollection).Count > 1 Then
            MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim UserID As Integer = Convert.ToInt32(dataGridView1.CurrentRow.Cells(0).Value)

            If New BU_UserInfo().Delete(UserID) Then
                MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Frm人员管理_Load_1(sender, e)
            Else
                MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If

    End Sub

    Private Sub treeView1_NodeMouseClick_1(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles treeView1.NodeMouseClick
        Dim s As String = e.Node.FullPath
        Dim data As String() = s.Split("\"c)
        If data.Length = 2 Then
            Dim ds As DataSet = Nothing
            If data(1) = "男" Then
                '查询普通用户
                ds = New BU_UserInfo().SelectAdmin("U_RoleType=1 and U_Sex=0")
            Else
                '查询普通用户
                ds = New BU_UserInfo().SelectAdmin("U_RoleType=1 and U_Sex=1")
            End If
            dataGridView1.DataSource = ds.Tables(0).DefaultView
        End If
    End Sub

    '显示全部
    Private Sub toolStripButton1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
        dataBind()
    End Sub

    '窗体加载
    Private Sub Frm人员管理_Load_1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        dataBind()
        Me.dataGridView1.[ReadOnly] = True
        Me.treeView1.Nodes(0).Expand()
        '展开
    End Sub
End Class
