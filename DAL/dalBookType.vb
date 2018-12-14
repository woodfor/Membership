Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Data.SqlClient

Imports Model


'图书类型业务逻辑层实现

Public Class dalBookType
    '待执行的sql语句

    Public Shared sql As String = ""

    '添加图书类型实现

    Public Shared Function AddBookType(ByVal bookType As Model.BookType) As Boolean
        Dim sql As String = "insert into BookType(bookTypeName,days) values(@bookTypeName,@days)"
        '构建sql参数

        Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@bookTypeName", SqlDbType.VarChar), New SqlParameter("@days", SqlDbType.Int)}
        '给参数赋值

        parm(0).Value = bookType.bookTypeName
        '类别名称
        parm(1).Value = bookType.days
        '可借阅天数
        '执行sql进行添加

        Return If((DBHelp.ExecuteNonQuery(sql, parm) > 0), True, False)
    End Function

    '根据bookTypeId获取某条图书类型记录

    Public Shared Function getSomeBookType(ByVal bookTypeId As Integer) As Model.BookType
        '构建查询sql

        Dim sql As String = "select * from BookType where bookTypeId=" & bookTypeId
        Dim DataRead As SqlDataReader = DBHelp.ExecuteReader(sql, Nothing)
        Dim bookType As New Model.BookType()
        '如果查询存在记录，就包装到对象中返回

        If DataRead.Read() Then
            bookType.bookTypeId = Convert.ToInt32(DataRead("bookTypeId"))
            bookType.bookTypeName = DataRead("bookTypeName").ToString()
            bookType.days = Convert.ToInt32(DataRead("days"))
        End If
        Return bookType
    End Function

    '更新图书类型实现

    Public Shared Function EditBookType(ByVal bookType As Model.BookType) As Boolean
        Dim sql As String = "update BookType set bookTypeName=@bookTypeName,days=@days where bookTypeId=@bookTypeId"
        '构建sql参数信息

        Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@bookTypeName", SqlDbType.VarChar), New SqlParameter("@days", SqlDbType.Int), New SqlParameter("@bookTypeId", SqlDbType.Int)}
        '为参数赋值

        parm(0).Value = bookType.bookTypeName
        parm(1).Value = bookType.days
        parm(2).Value = bookType.bookTypeId
        '执行更新

        Return If((DBHelp.ExecuteNonQuery(sql, parm) > 0), True, False)
    End Function


    '删除图书类型

    Public Shared Function DelBookType(ByVal p As String) As Boolean
        Dim sql As String = "delete from BookType where bookTypeId in (" & p & ") "
        Return If(((DBHelp.ExecuteNonQuery(sql, Nothing)) > 0), True, False)
    End Function


    '查询图书类型

    Public Shared Function GetBookType(ByVal PageIndex As Integer, ByVal PageSize As Integer, ByRef PageCount As Integer, ByRef RecordCount As Integer, ByVal strWhere As String) As System.Data.DataTable
        Try
            Dim strSql As String = " select * from BookType"
            Dim strShow As String = "*"
            Return DAL.DBHelp.ExecutePager(PageIndex, PageSize, "bookTypeId", strShow, strSql, strWhere, _
             " bookTypeId asc ", PageCount, RecordCount)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Shared Function getAllBookType() As DataSet
        Try
            Dim strSql As String = "select * from BookType"
            Return DBHelp.ExecuteDataSet(strSql, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class
