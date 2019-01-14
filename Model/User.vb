Public Class User
    Private _userName As String
    Public Property Name() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property

    Private _openID As String
    Public Property openID() As String
        Get
            Return _openID
        End Get
        Set(value As String)
            _openID = value
        End Set
    End Property
End Class
