Imports System.Data.SqlClient
Imports Model
Public Class dalCard
    Public Shared sql As String = ""

    '添加图书实现

    Public Shared Function Addcard(ByVal card As Model.Card) As Boolean
        Dim sql As String = "insert into Card(card_id,user_name,open_id,balance,store_id,customer_phone) values(@card_id,@user_name,@open_id,@balance,@store_id,@customer_phone)"
        '构建sql参数

        Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@card_id", SqlDbType.VarChar), New SqlParameter("@user_name", SqlDbType.VarChar), New SqlParameter("@open_id", SqlDbType.VarChar), New SqlParameter("@balance", SqlDbType.Decimal), New SqlParameter("@store_id", SqlDbType.Int),
         New SqlParameter("@customer_phone", SqlDbType.VarChar)}
        '给参数赋值

        parm(0).Value = card.card_id
        '图书名称
        parm(1).Value = card.user_name
        '图书所在类别
        parm(2).Value = card.open_id
        '图书价格
        parm(3).Value = card.balance
        '库存
        parm(4).Value = card.store_id
        '出版社
        parm(5).Value = card.customer_phone


        Return If((DBHelp.ExecuteNonQuery(sql, parm) > 0), True, False)
    End Function

    '根据barcode获取某条图书记录

    Public Shared Function getSomeCard(ByVal id As String) As Model.Card
        '构建查询sql
        Dim sql As String = "select * from Card where card_id='" & id & "'"
        Dim DataRead As SqlDataReader = DBHelp.ExecuteReader(sql, Nothing)
        Dim card As New Model.Card()
        '如果查询存在记录，就包装到对象中返回

        If DataRead.Read() Then
            card.store_id = DirectCast(DataRead("store_id"), Integer)
            card.card_id = DataRead("card_id").ToString()
            card.user_name = DataRead("user_name").ToString()
            card.open_id = DataRead("open_id").ToString()
            card.balance = DirectCast(DataRead("balance"), Decimal)
            card.customer_phone = DataRead("customer_phone").ToString()
            'store.store_phone = DirectCast(DataRead("bookPhoto"), Byte())

            Return card
        End If
        DataRead.Close()
        Return Nothing
    End Function

    '更新图书实现

    Public Shared Function EditCard(ByVal card As Model.Card) As Boolean
        Dim sql As String = "update Card set user_name=@user_name,customer_phone=@customer_phone where card_id=@card_id"
        '构建sql参数信息

        Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@user_name", SqlDbType.VarChar), New SqlParameter("@customer_phone", SqlDbType.VarChar), New SqlParameter("@card_id", SqlDbType.VarChar)}
        '为参数赋值

        parm(0).Value = card.user_name
        parm(1).Value = card.customer_phone
        parm(3).Value = card.card_id
        '执行更新

        Return If((DBHelp.ExecuteNonQuery(sql, parm) > 0), True, False)
    End Function

    Public Shared Function EditBalance(ByVal card_id As String, ByVal number As Decimal) As Boolean
        Dim sql As String = "update Card set balance=@balance where card_id=@card_id"
        '构建sql参数信息

        Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@balance", SqlDbType.Decimal), New SqlParameter("@card_id", SqlDbType.VarChar)}
        '为参数赋值

        parm(0).Value = number
        parm(1).Value = card_id
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
