Public Class UpdateCardInfo
    Public Shared Function updateBonus(ByVal card As CardInfo, ByVal amount As String) As String
        Dim post_dic As Dictionary(Of String, Object) = New Dictionary(Of String, Object) From {
        {"code", card.cardNumber}，
        {"card_id", card.ID},
        {"add_balance", amount}
        }
        Dim postStr As String = Newtonsoft.Json.JsonConvert.SerializeObject(post_dic)
        Return postStr
        '{"custom_field_value1", "白金"}}
    End Function
    Public Shared Function updateLevel(ByVal card As CardInfo, ByVal level As String) As String
        Dim post_dic As Dictionary(Of String, Object) = New Dictionary(Of String, Object) From {
        {"code", card.cardNumber}，
        {"card_id", card.ID},
        {"custom_field_value1", level}
        }
        Dim postStr As String = Newtonsoft.Json.JsonConvert.SerializeObject(post_dic)
        Return postStr
    End Function
    Public Shared Function openDiscount(ByVal card As CardInfo) As String
        Dim post_dic As Dictionary(Of String, Object) = New Dictionary(Of String, Object) From {
             {"card_id", card.ID},
        {"member_card", New memberCard("等级", "折扣", 9)}
        }
        Dim postStr As String = Newtonsoft.Json.JsonConvert.SerializeObject(post_dic)
        Return postStr
    End Function
    Public Shared Function setDiscount(ByVal card As CardInfo, ByVal discount As String) As String
        Dim post_dic As Dictionary(Of String, Object) = New Dictionary(Of String, Object) From {
             {"code", card.cardNumber}，
        {"card_id", card.ID},
        {"custom_field_value2", discount}
        }

        Dim postStr As String = Newtonsoft.Json.JsonConvert.SerializeObject(post_dic)
        Return postStr
    End Function

    Public Shared Function getDetail(ByVal card As CardInfo) As String
        Dim post_dic As Dictionary(Of String, Object) = New Dictionary(Of String, Object) From {
        {"card_id", card.ID}
        }

        Dim postStr As String = Newtonsoft.Json.JsonConvert.SerializeObject(post_dic)
        Return postStr
    End Function
End Class
