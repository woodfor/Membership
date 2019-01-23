Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports BLL
Imports Model
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Partial Public Class FrmQueryBook
    Inherits Form
    Private token As New Token()
    Private card As New CardInfo()
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub Btn_Query_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Query.Click
        Dim sqlstr As String = " where 1=1 "
        If Me.txt_bookName.Text.Trim <> "" Then
            sqlstr += "  and user_name like '%" & Convert.ToString(Me.txt_bookName.Text.Trim) & "%'"
        End If
        If Me.txt_phone.Text.Trim <> "0" Then
            sqlstr += "  and payer_phone like '%" & Convert.ToString(Me.txt_phone.Text.Trim) & "%'"
        End If
        If Me.txt_barcode.Text.Trim <> "" Then
            sqlstr += "  and number like '%" & Convert.ToString(Me.txt_barcode.Text.Trim) & "%'"
        End If
        If Me.DateTimePicker1.Text.Trim <> "" Then
            sqlstr += "  and convert(char(11),time,111) ='" & Convert.ToString(Me.DateTimePicker1.Text.Trim) & "'"
        End If
        HWhere.Text = sqlstr
        BindData("")
    End Sub


    Public Sub BindData(ByVal strClass As String)
        Dim DataCount As Integer = 0
        Dim NowPage As Integer = 1
        Dim AllPage As Integer = 0
        Dim PageSize As Integer = Convert.ToInt32(HPageSize.Text)
        Select Case strClass
            Case "next"
                NowPage = Convert.ToInt32(HNowPage.Text) + 1
                Exit Select
            Case "up"
                NowPage = Convert.ToInt32(HNowPage.Text) - 1
                Exit Select
            Case "end"
                NowPage = Convert.ToInt32(HAllPage.Text)
                Exit Select
            Case "refresh"
                NowPage = Convert.ToInt32(HNowPage.Text)
                Exit Select
            Case Else
                Exit Select
        End Select
        Dim dsLog As DataTable = DAL.dalTrans.GetTrans(NowPage, PageSize, AllPage, DataCount, HWhere.Text)
        If dsLog.Rows.Count = 0 OrElse AllPage = 1 Then
            LBEnd.Enabled = False
            LBHome.Enabled = False
            LBNext.Enabled = False
            LBUp.Enabled = False
        ElseIf NowPage = 1 Then
            LBHome.Enabled = False
            LBUp.Enabled = False
            LBNext.Enabled = True
            LBEnd.Enabled = True
        ElseIf NowPage = AllPage Then
            LBHome.Enabled = True
            LBUp.Enabled = True
            LBNext.Enabled = False
            LBEnd.Enabled = False
        Else
            LBEnd.Enabled = True
            LBHome.Enabled = True
            LBNext.Enabled = True
            LBUp.Enabled = True
        End If
        Me.dataGridView_Book.DataSource = dsLog.DefaultView
        PageMes.Text = String.Format("[每页{0}条 第{1}页／共{2}页   共{3}条]", PageSize, NowPage, AllPage, DataCount)
        HNowPage.Text = NowPage.ToString() 'Convert.ToString(System.Math.Max(System.Threading.Interlocked.Increment(NowPage), NowPage - 1))
        HAllPage.Text = AllPage.ToString()


    End Sub

    '开始加载窗体后

    Private Sub FrmQueryBook_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker1.Format = DateTimePickerFormat.Custom


    End Sub

    Private Sub LBHome_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBHome.Click
        BindData("")
    End Sub

    Private Sub LBUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBUp.Click
        BindData("up")
    End Sub

    Private Sub LBNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBNext.Click
        BindData("next")
    End Sub

    Private Sub LBEnd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LBEnd.Click
        BindData("end")
    End Sub

    'Private Sub Btn_Update_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Update.Click
    '    If DirectCast(dataGridView_Book.SelectedRows, System.Windows.Forms.BaseCollection).Count <> 1 Then
    '        MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '    Else
    '        Dim barcode As [String] = Me.dataGridView_Book.CurrentRow.Cells(0).Value.ToString()
    '        Dim frmEditBook As New FrmEditBook(barcode, Me)
    '        frmEditBook.ShowDialog()
    '    End If
    'End Sub

    'Private Sub Btn_Del_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Del.Click
    '    If DirectCast(dataGridView_Book.SelectedRows, System.Windows.Forms.BaseCollection).Count <> 1 Then
    '        MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '    Else
    '        If MessageBox.Show("确定删除吗?", "删除提示", MessageBoxButtons.OKCancel) = DialogResult.OK Then

    '            Dim barcode As [String] = Me.dataGridView_Book.CurrentRow.Cells(0).Value.ToString()
    '            If BLL.bllBook.DelBook(barcode) Then
    '                MessageBox.Show("图书删除成功!")
    '            Else
    '                MessageBox.Show("图书删除失败!")
    '            End If

    '            BindData("refresh")
    '        End If
    '    End If
    'End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txt_date.Text = DateTimePicker1.Text

    End Sub
    Private Sub DateTimePicker1_DoubleClick(sender As Object, e As EventArgs) Handles DateTimePicker1.DoubleClick
        txt_date.Text = ""
    End Sub
End Class