Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Type")>
Partial Public Class Type
    Public Sub New()
        Trans_purchase = New HashSet(Of Trans_purchase)()
    End Sub

    Public Property id As Integer

    <Required>
    <StringLength(10)>
    Public Property name As String

    Public Overridable Property Trans_purchase As ICollection(Of Trans_purchase)
End Class
