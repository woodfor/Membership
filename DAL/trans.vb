Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Trans
    <Key>
    <Column(Order:=0)>
    <StringLength(50)>
    Public Property card_id As String

    <Key>
    <Column(Order:=1)>
    Public Property trans_time As Date

    <Key>
    <Column(Order:=2)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property worker_id As Integer

    Public Property money As Decimal

    Public Overridable Property Card As Card

    Public Overridable Property Worker As Worker
End Class
