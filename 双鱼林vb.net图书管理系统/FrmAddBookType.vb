Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Imports Model
Imports BLL

Partial Public Class FrmAddBookType
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Btn_Add_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Add.Click
        Dim bookType As New BookType()
        If Me.txt_bookTypeName.Text = "" Then
            MessageBox.Show("图书类型输入不能为空!")
            Me.txt_bookTypeName.Focus()
            Return
        End If
        bookType.bookTypeName = Me.txt_bookTypeName.Text

        Try
            bookType.days = Convert.ToInt32(Me.txt_days.Text)
        Catch ex As Exception
            MessageBox.Show("天数请输入整数")
            Me.txt_days.SelectAll()
            Me.txt_days.Focus()
            Return
        End Try

        If bllBookType.AddBookType(bookType) Then
            MessageBox.Show("图书类型添加成功!")
        Else
            MessageBox.Show("图书类型添加失败!")
        End If


        Me.Close()

    End Sub
End Class
