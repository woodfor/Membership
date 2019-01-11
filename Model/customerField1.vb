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

    Private _level As String
    'Public Property values() As String
    '    Get
    '        Return _level
    '    End Get
    '    Set(ByVal value As String)
    '        _level = value
    '    End Set
    'End Property
    Sub New(ByVal level As String)
        Me._name = level
        'Me._level = level
    End Sub
End Class
