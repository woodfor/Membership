Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("MemberType")>
Partial Public Class MemberType
    Public Sub New()
        Card = New HashSet(Of Card)()
    End Sub

    Public Property id As Integer

    <Required>
    <StringLength(10)>
    Public Property name As String

    Public Property discount As Decimal

    Public Overridable Property Card As ICollection(Of Card)
End Class
