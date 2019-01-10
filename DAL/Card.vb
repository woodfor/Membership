Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Card")>
Partial Public Class Card
    Public Sub New()
        Trans = New HashSet(Of Trans)()
    End Sub

    <Key>
    <StringLength(50)>
    Public Property card_Id As String

    <Required>
    <StringLength(20)>
    Public Property user_name As String

    <Required>
    <StringLength(50)>
    Public Property open_id As String

    Public Property balance As Decimal

    <StringLength(10)>
    Public Property level As String

    <Required>
    <StringLength(50)>
    Public Property card_number As String

    Public Overridable Property Trans As ICollection(Of Trans)
End Class
