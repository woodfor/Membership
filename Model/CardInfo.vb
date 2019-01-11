Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class CardInfo
    Private _cardNumber As String
    Public Property cardNumber() As String
        Get
            Return _cardNumber
        End Get
        Set(ByVal value As String)
            _cardNumber = value
        End Set
    End Property
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property
    Private _status As String
    Public Property status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    '图书所在类别

    Private _bonus As Integer
    Public Property bonus() As Integer
        Get
            Return _bonus
        End Get
        Set(ByVal value As Integer)
            _bonus = value
        End Set
    End Property

    Private _memberLevel As String
    Public Property memberLevel() As String
        Get
            Return _memberLevel
        End Get
        Set(ByVal value As String)
            _memberLevel = value
        End Set
    End Property

    '图书价格

    'Private _price As Single
    'Public Property price() As Single
    '    Get
    '        Return _price
    '    End Get
    '    Set(ByVal value As Single)
    '        _price = value
    '    End Set
    'End Property

    '库存

    'Private _count As Integer
    'Public Property count() As Integer
    '    Get
    '        Return _count
    '    End Get
    '    Set(ByVal value As Integer)
    '        _count = value
    '    End Set
    'End Property

    '出版社

    'Private _publish As String
    'Public Property publish() As String
    '    Get
    '        Return _publish
    '    End Get
    '    Set(ByVal value As String)
    '        _publish = value
    '    End Set
    'End Property

    '图书条形码

    'Private _barcode As String
    'Public Property barcode() As String
    '    Get
    '        Return _barcode
    '    End Get
    '    Set(ByVal value As String)
    '        _barcode = value
    '    End Set
    'End Property

    '图书图片

    'Private _bookPhoto As Byte()
    'Public Property bookPhoto() As Byte()
    '    Get
    '        Return _bookPhoto
    '    End Get
    '    Set(ByVal value As Byte())
    '        _bookPhoto = value
    '    End Set
    'End Property

    '出版日期

    'Private _publishDate As DateTime
    'Public Property publishDate() As DateTime
    '    Get
    '        Return _publishDate
    '    End Get
    '    Set(ByVal value As DateTime)
    '        _publishDate = value
    '    End Set
    'End Property

End Class
