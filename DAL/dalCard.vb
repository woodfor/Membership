Imports System.Data.SqlClient
Imports Model
Public Class dalCard


    Public Shared sql As String = ""

    '添加图书实现

    Public Shared Function AddBook(ByVal book As Model.Book) As Boolean
        Dim sql As String = "insert into Book(bookName,bookType,price,count,publish,barcode,bookPhoto,publishDate) values(@bookName,@bookType,@price,@count,@publish,@barcode,@bookPhoto,@publishDate)"
        '构建sql参数

        Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@bookName", SqlDbType.VarChar), New SqlParameter("@bookType", SqlDbType.Int), New SqlParameter("@price", SqlDbType.Float), New SqlParameter("@count", SqlDbType.Int), New SqlParameter("@publish", SqlDbType.VarChar), New SqlParameter("@barcode", SqlDbType.VarChar),
         New SqlParameter("@bookPhoto", SqlDbType.Image), New SqlParameter("@publishDate", SqlDbType.DateTime)}
        '给参数赋值

        parm(0).Value = book.bookName
        '图书名称
        parm(1).Value = book.bookType
        '图书所在类别
        parm(2).Value = book.price
        '图书价格
        parm(3).Value = book.count
        '库存
        parm(4).Value = book.publish
        '出版社
        parm(5).Value = book.barcode
        '图书条形码
        parm(6).Value = book.bookPhoto
        '图书图片
        parm(7).Value = book.publishDate
        '出版日期
        '执行sql进行添加

        Return If((DBHelp.ExecuteNonQuery(sql, parm) > 0), True, False)
    End Function

    '根据barcode获取某条图书记录

    Public Shared Function getSomeBook(ByVal barcode As String) As Model.Book
        '构建查询sql

        Dim sql As String = "select * from Book where barcode='" & barcode & "'"
        Dim DataRead As SqlDataReader = DBHelp.ExecuteReader(sql, Nothing)
        Dim book As New Model.Book()
        '如果查询存在记录，就包装到对象中返回

        If DataRead.Read() Then
            book.bookName = DataRead("bookName").ToString()
            book.bookType = Convert.ToInt32(DataRead("bookType"))
            book.price = Single.Parse(DataRead("price").ToString())
            book.count = Convert.ToInt32(DataRead("count"))
            book.publish = DataRead("publish").ToString()
            book.barcode = DataRead("barcode").ToString()
            book.bookPhoto = DirectCast(DataRead("bookPhoto"), Byte())
            book.publishDate = Convert.ToDateTime(DataRead("publishDate").ToString())
        End If
        DataRead.Close()
        Return book
    End Function

    '更新图书实现

    Public Shared Function EditBook(ByVal book As Model.Book) As Boolean
        Dim sql As String = "update Book set bookName=@bookName,bookType=@bookType,price=@price,count=@count,publish=@publish,bookPhoto=@bookPhoto,publishDate=@publishDate where barcode=@barcode"
        '构建sql参数信息

        Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@bookName", SqlDbType.VarChar), New SqlParameter("@bookType", SqlDbType.Int), New SqlParameter("@price", SqlDbType.Float), New SqlParameter("@count", SqlDbType.Int), New SqlParameter("@publish", SqlDbType.VarChar), New SqlParameter("@bookPhoto", SqlDbType.Image),
         New SqlParameter("@publishDate", SqlDbType.DateTime), New SqlParameter("@barcode", SqlDbType.VarChar)}
        '为参数赋值

        parm(0).Value = book.bookName
        parm(1).Value = book.bookType
        parm(2).Value = book.price
        parm(3).Value = book.count
        parm(4).Value = book.publish
        parm(5).Value = book.bookPhoto
        parm(6).Value = book.publishDate
        parm(7).Value = book.barcode
        '执行更新

        Return If((DBHelp.ExecuteNonQuery(sql, parm) > 0), True, False)
    End Function


    '删除图书

    Public Shared Function DelBook(ByVal p As String) As Boolean
        Dim sql As String = ""
        Dim ids As String() = p.Split(","c)
        For i As Integer = 0 To ids.Length - 1
            If i <> ids.Length - 1 Then
                sql += "'" & ids(i) & "',"
            Else
                sql += "'" & ids(i) & "'"
            End If
        Next
        sql = "delete from Book where barcode in (" & sql & ")"
        Return If(((DBHelp.ExecuteNonQuery(sql, Nothing)) > 0), True, False)
    End Function


    '查询图书

    Public Shared Function GetBook(ByVal PageIndex As Integer, ByVal PageSize As Integer, ByRef PageCount As Integer, ByRef RecordCount As Integer, ByVal strWhere As String) As System.Data.DataTable
        Try
            Dim strSql As String = " select Book.*,BookType.bookTypeName from Book,BookType where  Book.bookType=BookType.bookTypeId "
            Dim strShow As String = "barcode as 图书条形码,bookName as 图书名称,bookTypeName as 图书类别,price as 价格,count as 库存,publish as 出版社,convert(char(11),publishDate,20) as 出版日期,bookPhoto as 图书图片"

            Return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "barcode", strShow, strSql, strWhere,
             " barcode asc ", PageCount, RecordCount)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Shared Function getAllBook() As DataSet
        Try
            Dim strSql As String = "select * from Book"
            Return DBHelp.ExecuteDataSet(strSql, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
