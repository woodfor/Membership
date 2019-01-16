Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class U_UserInfo
    Public Sub New()
        Trans_purchase = New HashSet(Of Trans_purchase)()
        Trans_TopUp = New HashSet(Of Trans_TopUp)()
    End Sub

    <Key>
    Public Property U_Id As Integer

    <StringLength(50)>
    Public Property U_Name As String

    <StringLength(50)>
    Public Property U_RelName As String

    Public Property U_Sex As Boolean?

    <StringLength(50)>
    Public Property U_PassWord As String

    Public Property U_Birthday As Date?

    Public Property U_PsdType As Integer?

    <StringLength(50)>
    Public Property U_PsdAnswer As String

    <StringLength(20)>
    Public Property U_IdCard As String

    <StringLength(20)>
    Public Property U_NativePlace As String

    <StringLength(50)>
    Public Property U_Address As String

    <StringLength(50)>
    Public Property U_Telephone As String

    <StringLength(50)>
    Public Property U_Email As String

    <StringLength(20)>
    Public Property U_PostalId As String

    <StringLength(20)>
    Public Property U_wechat As String

    <StringLength(20)>
    Public Property U_Position As String

    <StringLength(50)>
    Public Property U_Reamrk As String

    Public Property U_LoginTime As Date?

    Public Property U_RoleType As Integer?

    <Column(TypeName:="image")>
    Public Property U_Image As Byte()

    Public Property store_id As Integer?

    Public Overridable Property Store As Store

    Public Overridable Property Trans_purchase As ICollection(Of Trans_purchase)

    Public Overridable Property Trans_TopUp As ICollection(Of Trans_TopUp)
End Class
