Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports DAL
Imports Model


Public Class BU_UserInfo
    Private UserInfo As New DU_UserInfo()
    ''' <summary>
    ''' 查询用户名是否存在
    ''' </summary>
    ''' <param name="U_Id"></param>
    ''' <returns></returns>
    Public Function ExistsName(ByVal U_Name As String) As Integer
        Return UserInfo.ExistsName(U_Name)
    End Function


    ''' <summary>
    ''' 查询用户名和密码是否存在
    ''' </summary>
    ''' <param name="U_Id"></param>
    ''' <returns></returns>
    Public Function ExistsPwd(ByVal U_Name As String, ByVal pwd As String) As DataSet
        Return UserInfo.ExistsPwd(U_Name, pwd)
    End Function

    ''' <summary>
    ''' 增加一条数据
    ''' </summary>
    Public Function Add(ByVal model As MU_UserInfo) As Integer
        Return UserInfo.Add(model)
    End Function

    ''' <summary>
    ''' 更改密码
    ''' </summary>
    Public Function UpdatePassword(ByVal pwd As String, ByVal key As Long) As Boolean
        Return UserInfo.UpdatePassword(pwd, key)
    End Function

    ''' <summary>
    ''' 查询所有密保问题
    ''' </summary>
    ''' <returns></returns>
    Public Function GetMP_PasswordType() As DataSet
        Return UserInfo.GetMP_PasswordType()
    End Function


    ''' <summary>
    ''' 根据用户名和密保问题查询出密码
    ''' </summary>
    ''' <param name="U_Id"></param>
    ''' <returns></returns>
    Public Function ShowPwd(ByVal U_Name As String, ByVal pwd As String) As DataSet
        Return UserInfo.ShowPwd(U_Name, pwd)
    End Function

    ''' <summary>
    ''' 更改密保
    ''' </summary>
    ''' <param name="type">密保类型</param>
    ''' <param name="ask">密保回答</param>
    ''' <param name="key">主键</param>
    ''' <returns></returns>
    Public Function UpdateU_PsdAnswer(ByVal type As Integer, ByVal ask As String, ByVal key As Integer) As Boolean
        Return UserInfo.UpdateU_PsdAnswer(type, ask, key)
    End Function

    ''' <summary>
    ''' 得到一个对象实体
    ''' </summary>
    Public Function GetModel(ByVal U_Id As Integer) As MU_UserInfo
        Return UserInfo.GetModel(U_Id)
    End Function

    ''' <summary>
    ''' 更新一条数据
    ''' </summary>
    Public Function Update(ByVal model As MU_UserInfo) As Boolean
        Return UserInfo.Update(model)
    End Function

    ''' <summary>
    ''' 删除一条数据
    ''' </summary>
    Public Function Delete(ByVal U_Id As Integer) As Boolean
        Return UserInfo.Delete(U_Id)
    End Function

    ''' <summary>
    ''' 查询所有管理员| 用户信息
    ''' </summary>
    ''' <param name="roletype">1:普通用户 2:管理员</param>
    ''' <returns></returns>
    Public Function SelectAdmin(ByVal where As String) As DataSet
        Return UserInfo.SelectAdmin(where)
    End Function
End Class
