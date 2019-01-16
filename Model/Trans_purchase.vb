Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Trans_purchase
    <Key>
    <Column(Order:=0)>
    <StringLength(50)>
    Public Property card_id As String

    <Key>
    <Column(Order:=1)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property U_Id As Integer

    <Key>
    <Column(Order:=2)>
    Public Property time As Date

    Public Property trans_money As Decimal

    <Column(TypeName:="numeric")>
    Public Property discount As Decimal

    Public Property type_id As Integer

    Public Overridable Property Card As Card

    Public Overridable Property Type As Type

    Public Overridable Property U_UserInfo As U_UserInfo
End Class
