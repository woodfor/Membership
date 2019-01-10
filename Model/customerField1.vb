Public Class customerField1
    Private _name As String
    Public Property name_type() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _level As String
    Public Property url() As String
        Get
            Return _level
        End Get
        Set(ByVal value As String)
            _level = value
        End Set
    End Property
    Sub New(ByVal name As String, ByVal level As String)
        _name = "FIELD_NAME_TYPE_LEVEL"
        _level = level
    End Sub
End Class
