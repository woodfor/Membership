Public Class customerField2
    Private _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _nameType As String
    Public Property name_type() As String
        Get
            Return _nameType
        End Get
        Set(ByVal value As String)
            _nameType = value
        End Set
    End Property
    Sub New(ByVal value As String)
        Me._name = value
        Me._nameType = "FIELD_NAME_TYPE_DISCOUNT"
    End Sub
End Class
