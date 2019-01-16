Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Card")>
Partial Public Class Card
    Public Sub New()
        Trans_TopUp = New HashSet(Of Trans_TopUp)()
        Trans_purchase = New HashSet(Of Trans_purchase)()
    End Sub

    <Key>
    <StringLength(50)>
    Public Property card_id As String

    <Required>
    <StringLength(20)>
    Public Property user_name As String

    <Required>
    <StringLength(50)>
    Public Property open_id As String

    Public Property balance As Decimal

    Public Property store_id As Integer

    <Required>
    <StringLength(20)>
    Public Property customer_phone As String

    Public Overridable Property Store As Store

    Public Overridable Property Trans_TopUp As ICollection(Of Trans_TopUp)

    Public Overridable Property Trans_purchase As ICollection(Of Trans_purchase)
End Class
