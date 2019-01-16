Public Class memberCard
    Private _field1 As customerField1
    Public Property custom_field1() As customerField1
        Get
            Return _field1
        End Get
        Set(ByVal value As customerField1)

            _field1 = value
        End Set
    End Property

    'Private _setBalance As Boolean
    ''Public Property supply_balance() As Boolean
    ''    Get
    ''        Return _setBalance
    ''    End Get
    ''    Set(ByVal value As Boolean)

    ''        _setBalance = value
    ''    End Set
    ''End Property
    Private _field2 As customerField2
    Public Property custom_field2() As customerField2
        Get
            Return _field2
        End Get
        Set(ByVal value As customerField2)

            _field2 = value
        End Set
    End Property
    Private _discount As Integer
    Public Property discount() As Integer
        Get
            Return _discount
        End Get
        Set(ByVal value As Integer)

            _discount = value
        End Set
    End Property
    Sub New(ByVal value1 As String， ByVal value2 As String, ByVal discount As Integer)
        Me._field1 = New customerField1(value1)
        Me._field2 = New customerField2(value2)
        Me._discount = discount
        'Me._setBalance = True
    End Sub
End Class
