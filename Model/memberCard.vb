Public Class memberCard
    Private baseInfo As basicInfo
    Public Property base_info() As basicInfo
        Get
            Return baseInfo
        End Get
        Set(value As basicInfo)
            baseInfo = value
        End Set
    End Property
    Private _field1 As customerField1
    Public Property custom_field1() As customerField1
        Get
            Return _field1
        End Get
        Set(ByVal value As customerField1)

            _field1 = value
        End Set
    End Property

    Private _field2 As customerField2
    Public Property custom_field2() As customerField2
        Get
            Return _field2
        End Get
        Set(ByVal value As customerField2)

            _field2 = value
        End Set
    End Property



    Sub New(ByVal value1 As String， ByVal value2 As String)
        _field1 = New customerField1(value1)
        _field2 = New customerField2(value2)
        baseInfo = New basicInfo()
        'Me._setBalance = True
    End Sub

End Class

