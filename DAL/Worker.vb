Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Worker")>
Partial Public Class Worker
    Public Sub New()
        Trans = New HashSet(Of Trans)()
    End Sub

    <Key>
    Public Property worker_id As Integer

    <Required>
    <StringLength(20)>
    Public Property name As String

    <Required>
    <StringLength(20)>
    Public Property phone As String

    Public Property shop_id As Integer

    Public Overridable Property Shop As Shop

    Public Overridable Property Trans As ICollection(Of Trans)
End Class
