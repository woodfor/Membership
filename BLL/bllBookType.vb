Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports DAL
Imports Model


'图书类型业务逻辑层

Public Class bllBookType
    '添加图书类型

    Public Shared Function AddBookType(ByVal bookType As Model.BookType) As Boolean
        Return DAL.dalBookType.AddBookType(bookType)
    End Function

    '根据bookTypeId获取某条图书类型记录

    Public Shared Function getSomeBookType(ByVal bookTypeId As Integer) As Model.BookType
        Return DAL.dalBookType.getSomeBookType(bookTypeId)
    End Function

    '更新图书类型

    Public Shared Function EditBookType(ByVal bookType As Model.BookType) As Boolean
        Return DAL.dalBookType.EditBookType(bookType)
    End Function

    '删除图书类型

    Public Shared Function DelBookType(ByVal p As String) As Boolean
        Return DAL.dalBookType.DelBookType(p)
    End Function

    '根据条件分页查询图书类型

    Public Shared Function GetBookType(ByVal NowPage As Integer, ByVal PageSize As Integer, ByRef AllPage As Integer, ByRef DataCount As Integer, ByVal p As String) As System.Data.DataTable
        Return DAL.dalBookType.GetBookType(NowPage, PageSize, AllPage, DataCount, p)
    End Function
    '查询所有的图书类型

    Public Shared Function getAllBookType() As System.Data.DataSet
        Return DAL.dalBookType.getAllBookType()
    End Function
End Class
