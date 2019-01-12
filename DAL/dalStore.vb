Imports System.Data.SqlClient
Imports Model
Public Class dalStore


    Public Shared sql As String = ""

    '添加图书实现

    Public Shared Function Addstore(ByVal store As Model.Store) As Boolean
        Dim sql As String = "insert into Store(store_name,city,street,admin_name,admin_phone,store_phone) values(@store_name,@city,@street,@admin_name,@admin_phone,@store_phone)"
        '构建sql参数

        Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@store_name", SqlDbType.VarChar), New SqlParameter("@city", SqlDbType.VarChar), New SqlParameter("@street", SqlDbType.VarChar), New SqlParameter("@admin_name", SqlDbType.VarChar), New SqlParameter("@admin_phone", SqlDbType.VarChar),
         New SqlParameter("@store_phone", SqlDbType.VarChar)}
        '给参数赋值

        parm(0).Value = store.store_name
        '图书名称
        parm(1).Value = store.city
        '图书所在类别
        parm(2).Value = store.street
        '图书价格
        parm(3).Value = store.admin_name
        '库存
        parm(4).Value = store.admin_phone
        '出版社
        parm(5).Value = store.store_phone


        Return If((DBHelp.ExecuteNonQuery(sql, parm) > 0), True, False)
    End Function

    '根据barcode获取某条图书记录

    Public Shared Function getSomeStore(ByVal id As String) As Model.Store
        '构建查询sql
        Dim sql As String = "select * from Store where store_id=" & Integer.Parse(id)
        Dim DataRead As SqlDataReader = DBHelp.ExecuteReader(sql, Nothing)
        Dim store As New Model.Store()
        '如果查询存在记录，就包装到对象中返回

        If DataRead.Read() Then
            store.store_id = Integer.Parse(DataRead("store_id").ToString())
            store.store_name = DataRead("store_name").ToString()
            store.city = DataRead("city").ToString()
            store.street = DataRead("street").ToString()
            store.admin_name = DataRead("admin_name").ToString()
            store.admin_phone = DataRead("admin_phone").ToString()
            store.store_phone = DataRead("store_phone").ToString()
            'store.store_phone = DirectCast(DataRead("bookPhoto"), Byte())


        End If
        DataRead.Close()
        Return store
    End Function

    '更新图书实现

    Public Shared Function EditStore(ByVal store As Model.Store) As Boolean
        Dim sql As String = "update Store set store_name=@store_name,city=@city,street=@street,admin_name=@admin_name,admin_phone=@admin_phone,store_phone=@store_phone where store_id=@store_id"
        '构建sql参数信息

        Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@store_name", SqlDbType.VarChar), New SqlParameter("@city", SqlDbType.VarChar), New SqlParameter("@street", SqlDbType.VarChar), New SqlParameter("@admin_name", SqlDbType.VarChar), New SqlParameter("@admin_phone", SqlDbType.VarChar),
         New SqlParameter("@store_phone", SqlDbType.VarChar), New SqlParameter("@store_id", SqlDbType.Int)}
        '为参数赋值

        parm(0).Value = store.store_name
        parm(1).Value = store.city
        parm(2).Value = store.street
        parm(3).Value = store.admin_name
        parm(4).Value = store.admin_phone
        parm(5).Value = store.store_phone
        parm(6).Value = store.store_id
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


    Public Shared Function getAllStore() As DataSet
        Try
            Dim strSql As String = "select store_id as ID, store_name as 店名, city as 所在城市, street as 所在街道, store_phone as 店内电话, admin_name as 管理员名字, admin_phone as 管理员电话 from Store"
            Return DBHelp.ExecuteDataSet(strSql, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Function



End Class
