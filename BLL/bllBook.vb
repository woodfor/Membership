Imports System.Collections.Generic
Imports System.Linq
Imports System.Text



'图书业务逻辑层

Public Class bllBook
    '添加图书

    Public Shared Function AddBook(ByVal book As Model.Book) As Boolean
        Return DAL.dalBook.AddBook(book)
    End Function

    '根据barcode获取某条图书记录

    Public Shared Function getSomeBook(ByVal barcode As String) As Model.Book
        Return DAL.dalBook.getSomeBook(barcode)
    End Function

    '更新图书

    Public Shared Function EditBook(ByVal book As Model.Book) As Boolean
        Return DAL.dalBook.EditBook(book)
    End Function

    '删除图书

    Public Shared Function DelBook(ByVal p As String) As Boolean
        Return DAL.dalBook.DelBook(p)
    End Function

    '根据条件分页查询图书

    Public Shared Function GetBook(ByVal NowPage As Integer, ByVal PageSize As Integer, ByRef AllPage As Integer, ByRef DataCount As Integer, ByVal p As String) As System.Data.DataTable
        Return DAL.dalBook.GetBook(NowPage, PageSize, AllPage, DataCount, p)
    End Function
    '查询所有的图书

    Public Shared Function getAllBook() As System.Data.DataSet
        Return DAL.dalBook.getAllBook()
    End Function
End Class
