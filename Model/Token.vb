Public Class Token
    Private _ID As String
    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property

    Private _leftTime As String
    Public Property leftTime() As String
        Get
            Return _leftTime
        End Get
        Set(ByVal value As String)
            _leftTime = value
        End Set
    End Property


End Class
