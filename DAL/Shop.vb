Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Shop")>
Partial Public Class Shop
    Public Sub New()
        Worker = New HashSet(Of Worker)()
    End Sub

    <Key>
    Public Property shop_id As Integer

    <Required>
    <StringLength(20)>
    Public Property shop_name As String

    <Required>
    <StringLength(20)>
    Public Property city As String

    <Required>
    <StringLength(50)>
    Public Property street As String

    <Required>
    <StringLength(20)>
    Public Property admin_name As String

    <Required>
    <StringLength(50)>
    Public Property admin_phone As String

    Public Overridable Property Worker As ICollection(Of Worker)
End Class
