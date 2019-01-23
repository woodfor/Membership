Imports System.Globalization
Imports System.Reflection

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
    Public Shared Function GetTrans(ByVal PageIndex As Integer, ByVal PageSize As Integer, ByRef PageCount As Integer, ByRef RecordCount As Integer, ByVal strWhere As String) As System.Data.DataTable
        Try
            Dim strSql As String = " select t.*, c.number, c.user_name, u.U_Name from Trans_TopUp t join Card c on t.card_id=c.card_id join U_UserInfo u on t.U_Id=u.U_Id"
            Dim strShow As String = "number as 卡号,user_name as 持卡人姓名, U_Name as 办理人姓名, convert(char(11),time,111) as 办理时间, trans_money as 充值金额, payer_phone as 预留电话"

            Return DAL.DBHelp.ExecutePagerWhenPrimaryIsString(PageIndex, PageSize, "card_id", strShow, strSql, strWhere,
             " time desc ", PageCount, RecordCount)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
