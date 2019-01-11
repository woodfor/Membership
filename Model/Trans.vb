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
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property worker_id As Integer

    <Key>
    <Column(Order:=2)>
    Public Property time As Date

    Public Property trans_money As Decimal

    <Required>
    <StringLength(20)>
    Public Property payer_name As String

    <Required>
    <StringLength(20)>
    Public Property payer_phone As String

    Public Overridable Property Card As Card

    Public Overridable Property Worker As Worker
End Class
