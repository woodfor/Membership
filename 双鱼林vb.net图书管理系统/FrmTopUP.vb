Imports BLL

Public Class FrmTopUP
    Private db As Model.Transaction
    Private card As Model.Card
    Public Sub New(ByRef db As Model.Transaction, ByRef card As Model.Card)

        ' This call is required by the designer.
        InitializeComponent()
        Me.db = db
        Me.card = card
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub But_confirm_Click(sender As Object, e As EventArgs) Handles But_confirm.Click
        If Text_money.Text.Trim = "" Then
            MsgBox("请输入充值金额")
            Text_money.Focus()
            Return
        ElseIf Not IsNumeric(Text_money.Text.Trim) Then
            MsgBox("输入金额应当是数字")
            Text_money.Focus()
            Return
        End If

        Dim decResult As Decimal
        If Decimal.TryParse(Text_money.Text, decResult) = True Then
            card.balance += decResult
        Else
            MsgBox("输入金额的小数点应不超过两位")
            Text_money.Focus()
            Return
        End If

        Dim frmAuth As New FrmAuthPrompt(2)
        If Not frmAuth.AuthResult = True Then
            MsgBox("需要验证密码")
            Return
        Else
            Try
                If decResult > Rules.top_level AndAlso Not card.MemberType.name = "高级" Then
                    Dim postStr As String = BLL.UpdateCardInfo.setDiscount(card, "高级", Rules.top_discount)
                    httpCon.PostData("https://api.weixin.qq.com/card/membercard/updateuser?access_token=" + getDataFromLocal.getToken, postStr)
                    card.type_id = db.MemberType.Where(Function(x) x.name = "高级").First.id
                    MsgBox("已充值满" + Rules.top_level.ToString + "元获得高级会员资格")

                ElseIf decResult > Rules.meidum_level AndAlso Not card.MemberType.name = "中等" AndAlso Not card.MemberType.name = "高级" Then
                    Dim postStr As String = BLL.UpdateCardInfo.setDiscount(card, "中等", Rules.medium_discount)
                    httpCon.PostData("https://api.weixin.qq.com/card/membercard/updateuser?access_token=" + getDataFromLocal.getToken, postStr)
                    card.type_id = db.MemberType.Where(Function(x) x.name = "中等").First.id
                    MsgBox("已充值满" + Rules.meidum_level.ToString + "元获得中级会员资格")

                ElseIf decResult > Rules.normal_level AndAlso card.MemberType.name = "无" Then
                    Dim postStr As String = BLL.UpdateCardInfo.setDiscount(card, "普通", Rules.normal_discount)
                    httpCon.PostData("https://api.weixin.qq.com/card/membercard/updateuser?access_token=" + getDataFromLocal.getToken, postStr)
                    card.type_id = db.MemberType.Where(Function(x) x.name = "普通").First.id
                    MsgBox("已充值满" + Rules.normal_level.ToString + "元获得普通会员资格")

                End If
            Catch ex As Exception
                MsgBox("网络连接有误，请重试", vbQuestion)
                Return
            End Try
            Try
                db.SaveChanges()
                If DAL.dalTrans.addTrans(db, card, LoginRoler.U_Id， Decimal.Parse(Text_money.Text)) Then
                    MsgBox("充值成功")
                    DialogResult = DialogResult.OK
                End If

            Catch ex As Exception
                MsgBox("数据更新失败，请重试")
                Return
            End Try
            Me.Close()
        End If
    End Sub

    Private Sub But_cancel_Click(sender As Object, e As EventArgs) Handles But_cancel.Click
        Me.Close()
    End Sub


End Class