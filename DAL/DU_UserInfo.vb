Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports Model


Public Class DU_UserInfo

    ''' <summary>
    ''' 查询用户名是否存在
    ''' </summary>
    ''' <param name="U_Id"></param>
    ''' <returns></returns>
    Public Function ExistsName(ByVal U_Name As String) As Integer
        Dim strSql As New StringBuilder()
        strSql.Append("select count(1) from U_UserInfo")
        strSql.Append(" where ")
        strSql.Append(" U_Name = @U_Name  ")
        Dim parameters As SqlParameter() = {New SqlParameter("@U_Name", SqlDbType.VarChar, 50)}
        parameters(0).Value = U_Name

        Return Convert.ToInt32(DBHelp.ExecuteScalar(strSql.ToString(), parameters))
    End Function


    ''' <summary>
    ''' 查询用户名和密码是否存在
    ''' </summary>
    ''' <param name="U_Id"></param>
    ''' <returns></returns>
    Public Function ExistsPwd(ByVal U_Name As String, ByVal pwd As String) As DataSet
        Dim strSql As New StringBuilder()
        strSql.Append("select top 1 U_Id,U_RoleType from U_UserInfo")
        strSql.Append(" where ")
        strSql.Append(" U_Name = @U_Name and U_PassWord=@U_PassWord ")
        Dim parameters As SqlParameter() = {New SqlParameter("@U_Name", SqlDbType.VarChar, 50), New SqlParameter("@U_PassWord", SqlDbType.VarChar, 50)}
        parameters(0).Value = U_Name
        parameters(1).Value = pwd

        Dim ds As DataSet = DBHelp.DateSet(strSql.ToString(), parameters)

        Return ds
    End Function

    ''' <summary>
    ''' 根据用户名和密保问题查询出密码
    ''' </summary>
    ''' <param name="U_Id"></param>
    ''' <returns></returns>
    Public Function ShowPwd(ByVal U_Name As String, ByVal pwd As String) As DataSet
        Dim strSql As New StringBuilder()
        strSql.Append("select top 1 U_PassWord from U_UserInfo")
        strSql.Append(" where ")
        strSql.Append(" U_Name = @U_Name and U_PsdAnswer=@U_PsdAnswer ")
        Dim parameters As SqlParameter() = {New SqlParameter("@U_Name", SqlDbType.VarChar, 50), New SqlParameter("@U_PsdAnswer", SqlDbType.VarChar, 50)}
        parameters(0).Value = U_Name
        parameters(1).Value = pwd

        Dim ds As DataSet = DBHelp.DateSet(strSql.ToString(), parameters)

        Return ds
    End Function


    ''' <summary>
    ''' 增加一条数据
    ''' </summary>

    Public Function Add(ByVal model As MU_UserInfo) As Integer
        Dim strSql As New StringBuilder()
        strSql.Append("insert into U_UserInfo(")
        strSql.Append("U_LoginTime,U_RoleType,U_Name,U_Sex,U_PassWord,U_Birthday,store_id")
        strSql.Append(") values (")
        strSql.Append("@U_LoginTime,@U_RoleType,@U_Name,@U_Sex,@U_PassWord,@U_Birthday,@store_id")
        strSql.Append(") ")
        strSql.Append(";select @@IDENTITY")

        Dim parameters As SqlParameter() = {New SqlParameter("@U_LoginTime", SqlDbType.DateTime), New SqlParameter("@U_RoleType", SqlDbType.Int, 4), New SqlParameter("@U_Name", SqlDbType.VarChar, 50), New SqlParameter("@U_Sex", SqlDbType.Bit, 1), New SqlParameter("@U_PassWord", SqlDbType.VarChar, 50), New SqlParameter("@U_Birthday", SqlDbType.DateTime), New SqlParameter("@store_id", SqlDbType.Int)}

        parameters(0).Value = model.U_LoginTime
        parameters(1).Value = model.U_RoleType
        parameters(2).Value = model.U_Name
        parameters(3).Value = model.U_Sex
        parameters(4).Value = model.U_PassWord
        parameters(5).Value = model.U_Birthday
        parameters(6).Value = model.store_id

        Dim obj As Object = DBHelp.ExecuteNonQuery(strSql.ToString(), parameters)

        If obj Is Nothing Then
            Return 0
        Else
            Return Convert.ToInt32(obj)
        End If
    End Function

    ''' <summary>
    ''' 更改密码
    ''' </summary>
    Public Function UpdatePassword(ByVal pwd As String, ByVal key As Long) As Boolean
        Dim strSql As New StringBuilder()
        strSql.Append("update U_UserInfo set ")
        strSql.Append(" U_PassWord = @U_PassWord ")
        strSql.Append(" where U_Id=@U_Id ")


        Dim parameters As SqlParameter() = {New SqlParameter("@U_Id", SqlDbType.Int, 4), New SqlParameter("@U_PassWord", SqlDbType.VarChar, 50)}

        parameters(0).Value = key
        parameters(1).Value = pwd

        Dim rows As Integer = DBHelp.ExecuteNonQuery(strSql.ToString(), parameters)
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' 更改密保
    ''' </summary>
    ''' <param name="type">密保类型</param>
    ''' <param name="ask">密保回答</param>
    ''' <param name="key">主键</param>
    ''' <returns></returns>
    Public Function UpdateU_PsdAnswer(ByVal type As Integer, ByVal ask As String, ByVal key As Long) As Boolean
        Dim strSql As New StringBuilder()
        strSql.Append("update U_UserInfo set ")
        strSql.Append(" U_PsdType= @U_PsdType,U_PsdAnswer=@U_PsdAnswer ")
        strSql.Append(" where U_Id=@U_Id ")


        Dim parameters As SqlParameter() = {New SqlParameter("@U_Id", SqlDbType.Int, 4), New SqlParameter("@U_PsdType", SqlDbType.Int), New SqlParameter("@U_PsdAnswer", SqlDbType.VarChar, 50)}

        parameters(0).Value = key
        parameters(1).Value = type
        parameters(2).Value = ask

        Dim rows As Integer = DBHelp.ExecuteNonQuery(strSql.ToString(), parameters)
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' 更新一条数据
    ''' </summary>
    Public Function Update(ByVal model As MU_UserInfo) As Boolean
        Dim strSql As New StringBuilder()
        strSql.Append("update U_UserInfo set ")

        strSql.Append(" U_NativePlace = @U_NativePlace , ")
        strSql.Append(" U_Address = @U_Address , ")
        strSql.Append(" U_Telephone = @U_Telephone , ")
        strSql.Append(" U_Email = @U_Email , ")
        strSql.Append(" U_PostalId = @U_PostalId , ")
        strSql.Append(" U_Position = @U_Position , ")
        strSql.Append(" U_RelName = @U_RelName , ")
        strSql.Append(" U_Sex = @U_Sex , ")
        strSql.Append(" U_Birthday = @U_Birthday , ")
        strSql.Append(" U_IdCard = @U_IdCard,  ")
        strSql.Append(" U_Image = @U_Image ,")
        strSql.Append(" U_wechat = @U_wechat")
        strSql.Append(" where U_Id=@U_Id ")


        Dim parameters As SqlParameter() = {New SqlParameter("@U_Id", SqlDbType.Int, 4), New SqlParameter("@U_NativePlace", SqlDbType.VarChar, 20), New SqlParameter("@U_Address", SqlDbType.VarChar, 50), New SqlParameter("@U_Telephone", SqlDbType.VarChar, 50), New SqlParameter("@U_Email", SqlDbType.VarChar, 50), New SqlParameter("@U_PostalId", SqlDbType.VarChar, 20),
         New SqlParameter("@U_Position", SqlDbType.VarChar, 20), New SqlParameter("@U_RelName", SqlDbType.VarChar, 50), New SqlParameter("@U_Sex", SqlDbType.Bit, 1), New SqlParameter("@U_Birthday", SqlDbType.DateTime), New SqlParameter("@U_IdCard", SqlDbType.VarChar, 20), New SqlParameter("@U_Image", SqlDbType.Image),
         New SqlParameter("@U_wechat", SqlDbType.VarChar, 50)}

        parameters(0).Value = model.U_Id
        parameters(1).Value = model.U_NativePlace
        parameters(2).Value = model.U_Address
        parameters(3).Value = model.U_Telephone
        parameters(4).Value = model.U_Email
        parameters(5).Value = model.U_PostalId
        parameters(6).Value = model.U_Position
        parameters(7).Value = model.U_RelName
        parameters(8).Value = model.U_Sex
        parameters(9).Value = model.U_Birthday
        parameters(10).Value = model.U_IdCard
        parameters(11).Value = model.U_Image
        parameters(12).Value = model.U_QQ

        Dim rows As Integer = DBHelp.ExecuteNonQuery(strSql.ToString(), parameters)
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' 删除一条数据
    ''' </summary>
    Public Function Delete(ByVal U_Id As Integer) As Boolean
        Dim strSql As New StringBuilder()
        strSql.Append("delete from U_UserInfo ")
        strSql.Append(" where U_Id=@U_Id")
        Dim parameters As SqlParameter() = {New SqlParameter("@U_Id", SqlDbType.Int, 4)}
        parameters(0).Value = U_Id


        Dim rows As Integer = DBHelp.ExecuteNonQuery(strSql.ToString(), parameters)
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' 删除一条数据
    ''' </summary>
    Public Function DeleteList(ByVal U_Idlist As String) As Boolean
        Dim strSql As New StringBuilder()
        strSql.Append("delete from U_UserInfo ")
        strSql.Append(" where ID in (" & U_Idlist & ")  ")
        Dim rows As Integer = DBHelp.ExecuteNonQuery(strSql.ToString())
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    ''' <summary>
    ''' 得到一个对象实体
    ''' </summary>
    Public Function GetModel(ByVal U_Id As Integer) As MU_UserInfo
        Dim strSql As New StringBuilder()
        strSql.Append("select * ")
        strSql.Append("  from U_UserInfo ")
        strSql.Append(" where U_Id=@U_Id")
        Dim parameters As SqlParameter() = {New SqlParameter("@U_Id", SqlDbType.Int, 4)}
        parameters(0).Value = U_Id


        Dim model As New MU_UserInfo()
        Dim ds As DataSet = DBHelp.DateSet(strSql.ToString(), parameters)

        If ds.Tables(0).Rows.Count > 0 Then
            If ds.Tables(0).Rows(0)("U_Id").ToString() <> "" Then
                model.U_Id = Integer.Parse(ds.Tables(0).Rows(0)("U_Id").ToString())
            End If
            model.U_NativePlace = ds.Tables(0).Rows(0)("U_NativePlace").ToString()
            model.U_Address = ds.Tables(0).Rows(0)("U_Address").ToString()
            model.U_Telephone = ds.Tables(0).Rows(0)("U_Telephone").ToString()
            model.U_Email = ds.Tables(0).Rows(0)("U_Email").ToString()
            model.U_PostalId = ds.Tables(0).Rows(0)("U_PostalId").ToString()
            model.U_Position = ds.Tables(0).Rows(0)("U_Position").ToString()
            model.U_Reamrk = ds.Tables(0).Rows(0)("U_Reamrk").ToString()
            If ds.Tables(0).Rows(0)("U_LoginTime").ToString() <> "" Then
                model.U_LoginTime = DateTime.Parse(ds.Tables(0).Rows(0)("U_LoginTime").ToString())
            End If
            If ds.Tables(0).Rows(0)("U_RoleType").ToString() <> "" Then
                model.U_RoleType = Integer.Parse(ds.Tables(0).Rows(0)("U_RoleType").ToString())
            End If
            model.U_Name = ds.Tables(0).Rows(0)("U_Name").ToString()
            model.U_RelName = ds.Tables(0).Rows(0)("U_RelName").ToString()
            If ds.Tables(0).Rows(0)("U_Sex").ToString() <> "" Then
                If (ds.Tables(0).Rows(0)("U_Sex").ToString() = "1") OrElse (ds.Tables(0).Rows(0)("U_Sex").ToString().ToLower() = "true") Then
                    model.U_Sex = True
                Else
                    model.U_Sex = False
                End If
            End If
            model.U_PassWord = ds.Tables(0).Rows(0)("U_PassWord").ToString()
            If ds.Tables(0).Rows(0)("U_Birthday").ToString() <> "" Then
                model.U_Birthday = DateTime.Parse(ds.Tables(0).Rows(0)("U_Birthday").ToString())
            End If
            If ds.Tables(0).Rows(0)("U_PsdType").ToString() <> "" Then
                model.U_PsdType = Integer.Parse(ds.Tables(0).Rows(0)("U_PsdType").ToString())
            End If
            model.U_PsdAnswer = ds.Tables(0).Rows(0)("U_PsdAnswer").ToString()
            model.U_IdCard = ds.Tables(0).Rows(0)("U_IdCard").ToString()
            If ds.Tables(0).Rows(0)("U_Image").ToString() <> "" Then
                model.U_Image = DirectCast(ds.Tables(0).Rows(0)("U_Image"), Byte())
            End If
            Return model
        Else
            Return Nothing
        End If
    End Function


    ''' <summary>
    ''' 获得前几行数据
    ''' </summary>
    Public Function GetList(ByVal Top As Integer, ByVal strWhere As String, ByVal filedOrder As String) As DataSet
        Dim strSql As New StringBuilder()
        strSql.Append("select ")
        If Top > 0 Then
            strSql.Append(" top " & Top.ToString())
        End If
        strSql.Append(" * ")
        strSql.Append(" FROM U_UserInfo ")
        If strWhere.Trim() <> "" Then
            strSql.Append(" where " & strWhere)
        End If
        strSql.Append(" order by " & filedOrder)
        Return DBHelp.DateSet(strSql.ToString())
    End Function

    ''' <summary>
    ''' 查询所有密保问题
    ''' </summary>
    ''' <returns></returns>
    Public Function GetMP_PasswordType() As DataSet
        Dim strSql As New StringBuilder()
        strSql.Append("select * from P_PasswordType")

        Return DBHelp.DateSet(strSql.ToString())
    End Function

    ''' <summary>
    ''' 查询所有管理员| 用户信息
    ''' </summary>
    ''' <param name="roletype">1:普通用户 2:管理员</param>
    ''' <returns></returns>
    Public Function SelectAdmin(ByVal where As String) As DataSet
        Dim strSql As New StringBuilder()
        strSql.Append("select U_Id as 用户编号,")
        strSql.Append(" U_Name as 用户名,U_RelName as 真实姓名,(case  U_Sex  when '0' then '男' when '1' then '女'  else ''  end  ) as 性别,")
        strSql.Append(" U_Birthday as 出身日期, U_IdCard as 身份证号,U_Address as 家庭住址,U_Telephone as 联系电话")
        strSql.Append(" from U_UserInfo")
        If where <> "" Then
            strSql.Append(" where " & where)
        End If
        Return DBHelp.DateSet(strSql.ToString())
    End Function
End Class
