Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Trans_TopUp
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

    <StringLength(20)>
    Public Property payer_name As String

    <StringLength(20)>
    Public Property payer_phone As String

    Public Overridable Property Card As Card

    Public Overridable Property U_UserInfo As U_UserInfo
End Class
