Public Class customerField1
    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Private _name_type As String
    Public Property name_type() As String
        Get
            Return _name_type
        End Get
        Set(ByVal value As String)
            _name_type = value
        End Set
    End Property
    'Private _level As String
    'Public Property url() As String
    '    Get
    '        Return _level
    '    End Get
    '    Set(ByVal value As String)
    '        _level = value
    '    End Set
    'End Property
    Sub New(ByVal value As String)
        Me._name = value
        Me._name_type = "FIELD_NAME_TYPE_LEVEL"
    End Sub
End Class
