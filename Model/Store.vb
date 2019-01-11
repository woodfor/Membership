Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Store")>
Partial Public Class Store
    Public Sub New()
        Card = New HashSet(Of Card)()
        Worker = New HashSet(Of Worker)()
    End Sub

    <Key>
    Public Property store_id As Integer

    <Required>
    <StringLength(20)>
    Public Property store_name As String

    <Required>
    <StringLength(20)>
    Public Property city As String

    <Required>
    <StringLength(100)>
    Public Property street As String

    <Required>
    <StringLength(20)>
    Public Property admin_name As String

    <Required>
    <StringLength(20)>
    Public Property admin_phone As String

    <Required>
    <StringLength(20)>
    Public Property store_phone As String

    Public Overridable Property Card As ICollection(Of Card)

    Public Overridable Property Worker As ICollection(Of Worker)
End Class
