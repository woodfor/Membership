Public Class dalTrans
    Public Shared Function addTrans(ByRef db As Model.Transaction, ByVal card As Model.Card, ByVal id As Integer, ByVal money As Decimal) As Boolean
        Try
            Dim topup As New Trans_TopUp With {
                    .Card = card,
                    .time = DateTime.Now,
                    .payer_name = card.user_name,
                    .payer_phone = card.customer_phone,
                    .trans_money = money,
                    .U_UserInfo = db.U_UserInfo.Where(Function(s) s.U_Id = id).ToList.First}
            db.Trans_TopUp.Add(topup)
            db.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Shared Function addTrans(ByRef db As Model.Transaction, ByVal card As Model.Card, ByVal id As Integer, ByVal money As Decimal, ByVal payer_name As String, ByVal payer_phone As String) As Boolean
        Try
            Dim topUp As New Trans_TopUp With {
                .Card = card,
                .time = DateTime.Now,
                .payer_name = payer_name,
                .payer_phone = payer_phone,
                .trans_money = money,
                .U_UserInfo = db.U_UserInfo.Where(Function(s) s.U_Id = id).ToList.First}
            db.Trans_TopUp.Add(topUp)
            db.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Shared Function findLastTopUp(ByRef db As Transaction, ByVal id As String) As Trans_TopUp
        Try
            Return db.Trans_TopUp.Where(Function(s) s.card_id = id).OrderByDescending(Function(s) s.time).First
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Shared Function findAllTrans(ByRef db As Transaction, ByVal id As String) As Array

        Return (From x In db.Trans_TopUp Where x.card_id = id Order By x.time Descending Select x.card_id, x.time, x.Card.user_name).ToArray
        'db.Trans_TopUp.Where(Function(s) s.card_id = id).Select(New{}).
        Try
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
