Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Public Class Book
    '图书名称

    Private _bookName As String
    Public Property bookName() As String
        Get
            Return _bookName
        End Get
        Set(ByVal value As String)
            _bookName = value
        End Set
    End Property

    '图书所在类别

    Private _bookType As Integer
    Public Property bookType() As Integer
        Get
            Return _bookType
        End Get
        Set(ByVal value As Integer)
            _bookType = value
        End Set
    End Property

    '图书价格

    Private _price As Single
    Public Property price() As Single
        Get
            Return _price
        End Get
        Set(ByVal value As Single)
            _price = value
        End Set
    End Property

    '库存

    Private _count As Integer
    Public Property count() As Integer
        Get
            Return _count
        End Get
        Set(ByVal value As Integer)
            _count = value
        End Set
    End Property

    '出版社

    Private _publish As String
    Public Property publish() As String
        Get
            Return _publish
        End Get
        Set(ByVal value As String)
            _publish = value
        End Set
    End Property

    '图书条形码

    Private _barcode As String
    Public Property barcode() As String
        Get
            Return _barcode
        End Get
        Set(ByVal value As String)
            _barcode = value
        End Set
    End Property

    '图书图片

    Private _bookPhoto As Byte()
    Public Property bookPhoto() As Byte()
        Get
            Return _bookPhoto
        End Get
        Set(ByVal value As Byte())
            _bookPhoto = value
        End Set
    End Property

    '出版日期

    Private _publishDate As DateTime
    Public Property publishDate() As DateTime
        Get
            Return _publishDate
        End Get
        Set(ByVal value As DateTime)
            _publishDate = value
        End Set
    End Property

End Class
