Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class P_PasswordType
    <Key>
    Public Property P_Id As Integer

    <StringLength(50)>
    Public Property U_Name As String
End Class
