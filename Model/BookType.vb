Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

''' <summary>
'''BookType 的摘要说明：图书信息实体
''' </summary>

Public Class BookType
    '图书类别

    Private _bookTypeId As Integer
    Public Property bookTypeId() As Integer
        Get
            Return _bookTypeId
        End Get
        Set(ByVal value As Integer)
            _bookTypeId = value
        End Set
    End Property

    '类别名称

    Private _bookTypeName As String
    Public Property bookTypeName() As String
        Get
            Return _bookTypeName
        End Get
        Set(ByVal value As String)
            _bookTypeName = value
        End Set
    End Property

    '可借阅天数

    Private _days As Integer
    Public Property days() As Integer
        Get
            Return _days
        End Get
        Set(ByVal value As Integer)
            _days = value
        End Set
    End Property

End Class
