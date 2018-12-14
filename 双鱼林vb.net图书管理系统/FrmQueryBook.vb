Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms


Partial Public Class FrmQueryBook
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub dtp_publishDate_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dtp_publishDate.ValueChanged
        Me.txt_publishDate.Text = Me.dtp_publishDate.Value.ToShortDateString()

    End Sub
    Private Sub txt_publishDate_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles txt_publishDate.DoubleClick
        Me.txt_publishDate.Text = ""
    End Sub

    Private Sub Btn_Query_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Query.Click
        Dim sqlstr As String = " where 1=1 "
        If Me.txt_bookName.Text <> "" Then
            sqlstr += "  and bookName like '%" & Convert.ToString(Me.txt_bookName.Text) & "%'"
        End If
        If Me.cb_bookType.SelectedValue.ToString() <> "0" Then
            sqlstr += "  and bookType=" & Me.cb_bookType.SelectedValue.ToString()
        End If
        If Me.txt_barcode.Text <> "" Then
            sqlstr += "  and barcode like '%" & Convert.ToString(Me.txt_barcode.Text) & "%'"
        End If
        If Me.txt_publishDate.Text <> "" Then
            sqlstr += "  and convert(char(11),publishDate,20) ='" & Convert.ToString(Me.txt_publishDate.Text) & "'"
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
        Dim dsLog As DataTable = BLL.bllBook.GetBook(NowPage, PageSize, AllPage, DataCount, HWhere.Text)
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

        If dsLog.Rows.Count > 0 Then
            Me.Btn_Update.Enabled = True
            Me.Btn_Del.Enabled = True
        Else
            Me.Btn_Update.Enabled = False
            Me.Btn_Del.Enabled = False
        End If
    End Sub

    '开始加载窗体后

    Private Sub FrmQueryBook_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        '查询所有的图书类别
        Dim bookTypeDs As DataSet = BLL.bllBookType.getAllBookType()

        Dim newDataTable As New DataTable()
        newDataTable.Columns.Add("bookTypeId")
        newDataTable.Columns.Add("bookTypeName")

        For Each oldDR As DataRow In bookTypeDs.Tables(0).Rows
            Dim newDR As DataRow = newDataTable.NewRow()
            newDR(0) = oldDR("bookTypeId").ToString()
            newDR(1) = oldDR("bookTypeName").ToString()
            newDataTable.Rows.InsertAt(newDR, newDataTable.Rows.Count)
        Next

        ' Add your 'Select an item' option at the top  
        Dim dr As DataRow = newDataTable.NewRow()
        dr(0) = "0"
        dr(1) = "不限制"
        newDataTable.Rows.InsertAt(dr, 0)

        Me.cb_bookType.DataSource = newDataTable
        Me.cb_bookType.DisplayMember = "bookTypeName"
        Me.cb_bookType.ValueMember = "bookTypeId"

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

    Private Sub Btn_Update_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Update.Click
        If DirectCast(dataGridView_Book.SelectedRows, System.Windows.Forms.BaseCollection).Count <> 1 Then
            MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim barcode As [String] = Me.dataGridView_Book.CurrentRow.Cells(0).Value.ToString()
            Dim frmEditBook As New FrmEditBook(barcode, Me)
            frmEditBook.ShowDialog()
        End If
    End Sub

    Private Sub Btn_Del_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Del.Click
        If DirectCast(dataGridView_Book.SelectedRows, System.Windows.Forms.BaseCollection).Count <> 1 Then
            MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If MessageBox.Show("确定删除吗?", "删除提示", MessageBoxButtons.OKCancel) = DialogResult.OK Then

                Dim barcode As [String] = Me.dataGridView_Book.CurrentRow.Cells(0).Value.ToString()
                If BLL.bllBook.DelBook(barcode) Then
                    MessageBox.Show("图书删除成功!")
                Else
                    MessageBox.Show("图书删除失败!")
                End If

                BindData("refresh")
            End If
        End If
    End Sub



End Class