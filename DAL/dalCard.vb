Imports System.Data.SqlClient
Imports Model
Public Class dalCard
    Public Shared sql As String = ""

    '添加图书实现

    Public Shared Function Addcard(ByRef db As Model.Transaction, ByVal card As Model.Card) As Boolean
        'Dim sql As String = "insert into Card(card_id,user_name,open_id,balance,store_id,customer_phone) values(@card_id,@user_name,@open_id,@balance,@store_id,@customer_phone)"
        ''构建sql参数

        'Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@card_id", SqlDbType.VarChar), New SqlParameter("@user_name", SqlDbType.VarChar), New SqlParameter("@open_id", SqlDbType.VarChar), New SqlParameter("@balance", SqlDbType.Decimal), New SqlParameter("@store_id", SqlDbType.Int),
        ' New SqlParameter("@customer_phone", SqlDbType.VarChar)}
        ''给参数赋值

        'parm(0).Value = card.card_id
        ''图书名称
        'parm(1).Value = card.user_name
        ''图书所在类别
        'parm(2).Value = card.open_id
        ''图书价格
        'parm(3).Value = card.balance
        ''库存
        'parm(4).Value = card.store_id
        ''出版社
        'parm(5).Value = card.customer_phone


        'Return If((DBHelp.ExecuteNonQuery(sql, parm) > 0), True, False)
        Try

            db.Card.Add(card)
            db.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function

    '根据barcode获取某条图书记录

    Public Shared Function getSomeCard(ByVal id As String) As Model.Card

        Try
            Dim db As New Model.Transaction
            Return db.Card.Where(Function(s) s.card_id = id).First
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Shared Function getSomeCard(ByRef db As Transaction, ByVal id As String) As Model.Card

        Try
            Return db.Card.Where(Function(s) s.card_id = id).First
        Catch ex As Exception
            Return Nothing
        End Try


    End Function
    '更新图书实现

    'Public Shared Function EditCard(ByRef db As Model.Transaction, ByVal card As Model.Card) As Boolean
    '    'Dim sql As String = "update Card set user_name=@user_name,customer_phone=@customer_phone where card_id=@card_id"
    '    ''构建sql参数信息

    '    'Dim parm As SqlParameter() = New SqlParameter() {New SqlParameter("@user_name", SqlDbType.VarChar), New SqlParameter("@customer_phone", SqlDbType.VarChar), New SqlParameter("@card_id", SqlDbType.VarChar)}
    '    ''为参数赋值

    '    'parm(0).Value = card.user_name
    '    'parm(1).Value = card.customer_phone
    '    'parm(3).Value = card.card_id
    '    ''执行更新

    '    'Return If((DBHelp.ExecuteNonQuery(sql, parm) > 0), True, False)
    '    Dim original = db.Card.Where(Function(s) s.card_id = card.card_id)
    'End Function

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
