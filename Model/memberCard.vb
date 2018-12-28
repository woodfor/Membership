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

    Private _setBalance As Boolean
    Public Property supply_balance() As Boolean
        Get
            Return _setBalance
        End Get
        Set(ByVal value As Boolean)

            _setBalance = value
        End Set
    End Property

    Sub New(ByVal value As String)
        Me._field1 = New customerField1(value)
        Me._setBalance = True
    End Sub
End Class
