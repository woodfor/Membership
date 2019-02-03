Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports DAL
Imports Model


Public Class BU_UserInfo
    Private UserInfo As New DU_UserInfo()

    Public Function ExistsName(ByVal U_Name As String) As Integer
        Return UserInfo.ExistsName(U_Name)
    End Function



    Public Function ExistsPwd(ByVal U_Name As String, ByVal pwd As String) As DataSet
        Return UserInfo.ExistsPwd(U_Name, pwd)
    End Function


    Public Function Add(ByVal model As MU_UserInfo) As Integer
        Return UserInfo.Add(model)
    End Function


    Public Function UpdatePassword(ByVal pwd As String, ByVal key As Long) As Boolean
        Return UserInfo.UpdatePassword(pwd, key)
    End Function


    Public Function GetMP_PasswordType() As DataSet
        Return UserInfo.GetMP_PasswordType()
    End Function



    Public Function ShowPwd(ByVal U_Name As String, ByVal pwd As String) As DataSet
        Return UserInfo.ShowPwd(U_Name, pwd)
    End Function


    Public Function UpdateU_PsdAnswer(ByVal type As Integer, ByVal ask As String, ByVal key As Integer) As Boolean
        Return UserInfo.UpdateU_PsdAnswer(type, ask, key)
    End Function


    Public Function GetModel(ByVal U_Id As Integer) As MU_UserInfo
        Return UserInfo.GetModel(U_Id)
    End Function


    Public Function Update(ByVal model As MU_UserInfo) As Boolean
        Return UserInfo.Update(model)
    End Function

    Public Function Delete(ByVal U_Id As Integer) As Boolean
        Return UserInfo.Delete(U_Id)
    End Function


    Public Function SelectAdmin(ByVal where As String) As DataSet
        Return UserInfo.SelectAdmin(where)
    End Function
End Class
