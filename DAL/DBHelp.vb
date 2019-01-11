Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Configuration





Public Class DBHelp

    Private Shared connection As SqlConnection
    ''' <summary>
    ''' 获取连接数据库对象
    ''' </summary>
    Public Shared ReadOnly Property GetConnection() As SqlConnection
        Get
            Dim connectionStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Membership system\Membership\数据库\BookSystemDB.mdf;Integrated Security=True;Connect Timeout=30"
            'Dim connectionStr As String = "server=.\SQLEXPRESS;database=BookSystemDB;user=sa;pwd=morrowsoft"
            Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim appSettings As System.Configuration.AppSettingsSection = CType(config.GetSection("appSettings"), System.Configuration.AppSettingsSection)

            'connectionStr = appSettings.Settings("strCon").Value
            If connection Is Nothing Then
                connection = New SqlConnection(connectionStr)
                connection.Open()
            ElseIf connection.State = ConnectionState.Closed Then
                connection = New SqlConnection(connectionStr)
                connection.Open()
            ElseIf connection.State = ConnectionState.Broken Then
                connection.Close()
                connection.Open()
            End If
            Return connection
        End Get
    End Property
    '创建SqlCommand对象 sql语句不带参数
    Public Shared Function Command(ByVal strSql As String) As SqlCommand
        Using cmd As New SqlCommand(strSql, GetConnection)
            Return cmd
        End Using
    End Function
    '创建SqlCommand对象 sql语句带参数
    Public Shared Function Command(ByVal strSql As String, ByVal ParamArray values As SqlParameter()) As SqlCommand
        Dim cmd As New SqlCommand(strSql, GetConnection)
        If values IsNot Nothing Then
            cmd.Parameters.AddRange(values)
        End If
        Return cmd
    End Function
    '返回前向只读的结果集对象 sql语句不带参数(查询)
    Public Shared Function ExecuteReader(ByVal strSql As String) As SqlDataReader
        Dim cmd As SqlCommand = Command(strSql)
        Return cmd.ExecuteReader()
    End Function
    '返回前向只读的结果集对象 sql语句带参数(查询)
    Public Shared Function ExecuteReader(ByVal strSql As String, ByVal ParamArray values As SqlParameter()) As SqlDataReader
        Dim cmd As SqlCommand = Command(strSql, values)
        Return cmd.ExecuteReader()
    End Function
    '返回第一行第一列的值 sql语句不带参数(查询)
    Public Shared Function ExecuteScalar(ByVal strSql As String) As Object
        Dim cmd As SqlCommand = Command(strSql)
        Return cmd.ExecuteScalar()
    End Function
    '返回第一行第一列的值 sql语句带参数(查询)
    Public Shared Function ExecuteScalar(ByVal strSql As String, ByVal ParamArray values As SqlParameter()) As Object
        Dim cmd As SqlCommand = Command(strSql, values)
        Return cmd.ExecuteScalar()
    End Function
    '返回受影响的行数 sql语句不带参数(更新 添加 删除)
    Public Shared Function ExecuteNonQuery(ByVal strSql As String) As Integer
        Dim cmd As SqlCommand = Command(strSql)
        Return cmd.ExecuteNonQuery()
    End Function
    '返回受影响的行数 sql语句不带参数(更新 添加 删除)
    Public Shared Function ExecuteNonQuery(ByVal strSql As String, ByVal ParamArray values As SqlParameter()) As Integer
        Dim cmd As SqlCommand = Command(strSql, values)
        Return cmd.ExecuteNonQuery()
    End Function
    '断开连接方式的结果集 sql语句不带参数
    Public Shared Function DataTable(ByVal strSql As String) As DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter(strSql, GetConnection)
        adapter.Fill(ds)
        Return ds.Tables(0)
    End Function
    '断开连接方式的结果集 sql语句带参数
    Public Shared Function DataTable(ByVal strSql As String, ByVal ParamArray values As SqlParameter()) As DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter(strSql, GetConnection)
        adapter.SelectCommand.Parameters.AddRange(values)
        adapter.Fill(ds)
        Return ds.Tables(0)
    End Function
    '''使用存储过程的获得SQLCommand对象
    '''ProcName存储过程的名称
    Public Shared Function ProcCommad(ByVal ProcName As String) As SqlCommand
        Dim comm As New SqlCommand(ProcName, GetConnection)
        comm.CommandType = CommandType.StoredProcedure
        Return comm
    End Function
    '''使用带参数存储过程的获得SQLCommand对象
    '''ProcName存储过程的名称
    Public Shared Function ProcCommad(ByVal ProcName As String, ByVal param As SqlParameter()) As SqlCommand
        Dim comm As New SqlCommand(ProcName, GetConnection)
        comm.Parameters.AddRange(param)
        comm.CommandType = CommandType.StoredProcedure
        Return comm
    End Function
    '存储过程返回一个前向只读的结果集
    Public Shared Function ProExecuteReader(ByVal ProName As String) As SqlDataReader
        Dim comd As SqlCommand = ProcCommad(ProName)
        Return comd.ExecuteReader()
    End Function
    '带参数存储过程返回一个前向只读的结果集
    Public Shared Function ProExecuteReader(ByVal ProName As String, ByVal param As SqlParameter()) As SqlDataReader
        Dim comd As SqlCommand = ProcCommad(ProName, param)
        Return comd.ExecuteReader()
    End Function
    '不带参数的存储过程的实现受影响行数
    Public Shared Function ProExecuteNonQuery(ByVal ProName As String) As Integer
        Dim comd As SqlCommand = ProcCommad(ProName)
        Return comd.ExecuteNonQuery()
    End Function
    '''/带参数的存储过程的实现受影响行数
    Public Shared Function ProExecuteNonQuery(ByVal ProName As String, ByVal param As SqlParameter()) As Integer
        Dim comd As SqlCommand = ProcCommad(ProName, param)
        Return comd.ExecuteNonQuery()
    End Function
    '''使用带参数获得DataSet对象
    Public Shared Function DateSet(ByVal strSql As String, ByVal param As SqlParameter()) As DataSet
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter(strSql, GetConnection)
        adapter.SelectCommand.Parameters.AddRange(param)
        adapter.Fill(ds)
        Return ds
    End Function
    '''使用带参数获得DataSet对象
    Public Shared Function DateSet(ByVal strSql As String) As DataSet
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter(strSql, GetConnection)
        adapter.Fill(ds)
        Return ds
    End Function


    ''' <summary>
    ''' 返回一个DataSet数据集
    ''' </summary>
    ''' <param name="connectionString">一个有效的连接字符串</param>
    ''' <param name="cmdText">存储过程名称或者sql命令语句</param>
    ''' <param name="commandParameters">执行命令所用参数的集合</param>
    ''' <returns>包含结果的数据集</returns>
    Public Shared Function ExecuteDataSet(ByVal cmdText As String, ByVal ParamArray commandParameters As SqlParameter()) As DataSet
        '创建一个SqlCommand对象，并对其进行初始化
        Dim cmd As New SqlCommand()
        Dim conn As SqlConnection = GetConnection
        PrepareCommand(cmd, GetConnection, Nothing, cmdText, commandParameters)
        '创建SqlDataAdapter对象以及DataSet
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        Try
            '填充ds
            da.Fill(ds)
            ' 清除cmd的参数集合 
            cmd.Parameters.Clear()
            '返回ds
            Return ds
        Catch
            '关闭连接，抛出异常
            conn.Close()
            Throw
        End Try

    End Function

    ''' <summary>
    ''' 准备执行一个命令
    ''' </summary>
    ''' <param name="cmd">sql命令</param>
    ''' <param name="conn">Sql连接</param>
    ''' <param name="trans">Sql事务</param>
    ''' <param name="cmdText">命令文本,例如：Select * from Products</param>
    ''' <param name="cmdParms">执行命令的参数</param>
    Private Shared Sub PrepareCommand(ByVal cmd As SqlCommand, ByVal conn As SqlConnection, ByVal trans As SqlTransaction, ByVal cmdText As String, ByVal cmdParms As SqlParameter())
        '判断连接的状态。如果是关闭状态，则打开
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
        'cmd属性赋值
        cmd.Connection = conn
        cmd.CommandText = cmdText
        '是否需要用到事务处理
        If trans IsNot Nothing Then
            cmd.Transaction = trans
        End If
        cmd.CommandType = CommandType.Text
        '添加cmd需要的存储过程参数
        If cmdParms IsNot Nothing Then
            For Each parm As SqlParameter In cmdParms
                cmd.Parameters.Add(parm)
            Next
        End If
    End Sub


    ''' <summary>
    ''' ACCESS高效分页
    ''' </summary>
    ''' <param name="pageIndex">当前页码</param>
    ''' <param name="pageSize">分页容量</param>
    ''' <param name="strKey">主键</param>
    ''' <param name="showString">显示的字段</param>
    ''' <param name="queryString">查询字符串，支持联合查询</param>
    ''' <param name="whereString">查询条件，若有条件限制则必须以where 开头</param>
    ''' <param name="orderString">排序规则</param>
    ''' <param name="pageCount">传出参数：总页数统计</param>
    ''' <param name="recordCount">传出参数：总记录统计</param>
    ''' <returns>装载记录的DataTable</returns>
    Public Shared Function ExecutePager(ByVal pageIndex As Integer, ByVal pageSize As Integer, ByVal strKey As String, ByVal showString As String, ByVal queryString As String, ByVal whereString As String, _
     ByVal orderString As String, ByRef pageCount As Integer, ByRef recordCount As Integer) As DataTable
        If pageIndex < 1 Then
            pageIndex = 1
        End If
        If pageSize < 1 Then
            pageSize = 10
        End If
        If String.IsNullOrEmpty(showString) Then
            showString = "*"
        End If
        If String.IsNullOrEmpty(orderString) Then
            orderString = strKey & " asc "
        End If
        Dim m_Conn As SqlConnection = GetConnection

        Try
            m_Conn.Open()
        Catch
        End Try
        Dim myVw As String = String.Format(" ( {0} ) tempVw ", queryString)
        Dim cmdCount As New SqlCommand(String.Format(" select count(*) as recordCount from {0} {1}", myVw, whereString), m_Conn)

        recordCount = Convert.ToInt32(cmdCount.ExecuteScalar())

        If (recordCount Mod pageSize) > 0 Then
            pageCount = recordCount \ pageSize + 1
        Else
            pageCount = recordCount \ pageSize
        End If
        Dim cmdRecord As SqlCommand
        If pageIndex = 1 Then
            '第一页
            cmdRecord = New SqlCommand(String.Format("select top {0} {1} from {2} {3} order by {4} ", pageSize, showString, myVw, whereString, orderString), m_Conn)
        ElseIf pageIndex > pageCount Then
            '超出总页数
            cmdRecord = New SqlCommand(String.Format("select top {0} {1} from {2} {3} order by {4} ", pageSize, showString, myVw, "where 1=2", orderString), m_Conn)
        Else
            Dim pageLowerBound As Integer = pageSize * pageIndex
            Dim pageUpperBound As Integer = pageLowerBound - pageSize
            Dim recordIDs As String = recordID(String.Format("select top {0} {1} from {2} {3} order by {4} ", pageLowerBound, strKey, myVw, whereString, orderString), pageUpperBound)
            Dim queryStringend As String = String.Format("select {0} from {1} where {2} in ({3}) order by {4} ", showString, myVw, strKey, recordIDs, orderString)

            cmdRecord = New SqlCommand(queryStringend, m_Conn)
        End If
        Dim dataAdapter As New SqlDataAdapter(cmdRecord)
        Dim dt As New DataTable()
        dataAdapter.Fill(dt)
        m_Conn.Close()
        m_Conn.Dispose()
        Return dt

    End Function



    ''' <summary>
    ''' ACCESS高效分页：当表的主键是字符串类型时候
    ''' </summary>
    ''' <param name="pageIndex">当前页码</param>
    ''' <param name="pageSize">分页容量</param>
    ''' <param name="strKey">主键</param>
    ''' <param name="showString">显示的字段</param>
    ''' <param name="queryString">查询字符串，支持联合查询</param>
    ''' <param name="whereString">查询条件，若有条件限制则必须以where 开头</param>
    ''' <param name="orderString">排序规则</param>
    ''' <param name="pageCount">传出参数：总页数统计</param>
    ''' <param name="recordCount">传出参数：总记录统计</param>
    ''' <returns>装载记录的DataTable</returns>
    Public Shared Function ExecutePagerWhenPrimaryIsString(ByVal pageIndex As Integer, ByVal pageSize As Integer, ByVal strKey As String, ByVal showString As String, ByVal queryString As String, ByVal whereString As String, _
     ByVal orderString As String, ByRef pageCount As Integer, ByRef recordCount As Integer) As DataTable
        If pageIndex < 1 Then
            pageIndex = 1
        End If
        If pageSize < 1 Then
            pageSize = 10
        End If
        If String.IsNullOrEmpty(showString) Then
            showString = "*"
        End If
        If String.IsNullOrEmpty(orderString) Then
            orderString = strKey & " asc "
        End If
        Dim m_Conn As SqlConnection = GetConnection

        Try
            m_Conn.Open()
        Catch
        End Try
        Dim myVw As String = String.Format(" ( {0} ) tempVw ", queryString)
        Dim cmdCount As New SqlCommand(String.Format(" select count(*) as recordCount from {0} {1}", myVw, whereString), m_Conn)

        recordCount = Convert.ToInt32(cmdCount.ExecuteScalar())

        If (recordCount Mod pageSize) > 0 Then
            pageCount = recordCount \ pageSize + 1
        Else
            pageCount = recordCount \ pageSize
        End If
        Dim cmdRecord As SqlCommand
        If pageIndex = 1 Then
            '第一页
            Dim sql As String = String.Format("select top {0} {1} from {2} {3} order by {4} ", pageSize, showString, myVw, whereString, orderString)
            cmdRecord = New SqlCommand(sql, m_Conn)
        ElseIf pageIndex > pageCount Then
            '超出总页数
            Dim sql As String = String.Format("select top {0} {1} from {2} {3} order by {4} ", pageSize, showString, myVw, "where 1=2", orderString)
            cmdRecord = New SqlCommand(sql, m_Conn)
        Else
            Dim pageLowerBound As Integer = pageSize * pageIndex
            Dim pageUpperBound As Integer = pageLowerBound - pageSize
            Dim recordIDs As String = recordIDString(String.Format("select top {0} {1} from {2} {3} order by {4} ", pageLowerBound, strKey, myVw, whereString, orderString), pageUpperBound)
            Dim queryStringend As String = String.Format("select {0} from {1} where {2} in ({3}) order by {4} ", showString, myVw, strKey, recordIDs, orderString)

            cmdRecord = New SqlCommand(queryStringend, m_Conn)
        End If
        Dim dataAdapter As New SqlDataAdapter(cmdRecord)
        Dim dt As New DataTable()
        dataAdapter.Fill(dt)
        m_Conn.Close()
        m_Conn.Dispose()
        Return dt

    End Function

    ''' <summary>
    ''' 分页使用
    ''' </summary>
    ''' <param name="query"></param>
    ''' <param name="passCount"></param>
    ''' <returns></returns>
    Private Shared Function recordID(ByVal query As String, ByVal passCount As Integer) As String
        Dim m_Conn As SqlConnection = GetConnection

        Try
            m_Conn.Open()
        Catch
        End Try
        Dim cmd As New SqlCommand(query, m_Conn)
        Dim result As String = String.Empty
        Using dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                If passCount < 1 Then
                    result += "," & dr.GetInt32(0)
                End If
                passCount -= 1
            End While
        End Using
        ' m_Conn.Close();
        ' m_Conn.Dispose();
        Return result.Substring(1)

    End Function

    ''' <summary>
    ''' 分页使用:主键是字符串类型时候
    ''' </summary>
    ''' <param name="query"></param>
    ''' <param name="passCount"></param>
    ''' <returns></returns>
    Private Shared Function recordIDString(ByVal query As String, ByVal passCount As Integer) As String
        Dim m_Conn As SqlConnection = GetConnection

        Try
            m_Conn.Open()
        Catch
        End Try
        Dim cmd As New SqlCommand(query, m_Conn)
        Dim result As String = String.Empty
        Using dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                If passCount < 1 Then
                    result += ",'" & dr.GetString(0) & "'"
                End If
                passCount -= 1
            End While
        End Using
        '  m_Conn.Close();
        ' m_Conn.Dispose();
        Return result.Substring(1)

    End Function


End Class
