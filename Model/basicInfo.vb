Public Class basicInfo


    Private _pay_info As payInfo
    Private Property pay_info() As payInfo
        Get
            Return _pay_info
        End Get
        Set(ByVal value As payInfo)
            _pay_info = value
        End Set
    End Property
    Private _is_pay_and_qrcode As Boolean
    Public Property is_pay_and_qrcode() As Boolean
        Get
            Return _is_pay_and_qrcode
        End Get
        Set(ByVal value As Boolean)

            _is_pay_and_qrcode = value
        End Set
    End Property
    Sub New()
        _pay_info = New payInfo()
        _is_pay_and_qrcode = True
    End Sub
    Private Class payInfo
        Private _swipe_card As swipeCard
        Private Property swipe_card() As swipeCard
            Get
                Return _swipe_card
            End Get
            Set(ByVal value As swipeCard)
                _swipe_card = value
            End Set
        End Property

        Sub New()
            _swipe_card = New swipeCard()
        End Sub
        Private Class swipeCard
            Private _swipe_card As Boolean
            Public Property is_swipe_card() As Boolean
                Get
                    Return _swipe_card
                End Get
                Set(ByVal value As Boolean)

                    _swipe_card = value
                End Set
            End Property
            Sub New()
                _swipe_card = True
            End Sub
        End Class
    End Class
End Class

