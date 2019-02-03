Imports BLL

Public Class FrmRequestInfo
    Private card As Model.Card
    Private db As Model.Transaction
    Public Sub New(ByRef db As Model.Transaction, ByVal card As Model.Card)

        ' This call is required by the designer.
        InitializeComponent()
        Me.card = card
        Me.db = db
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Then
            MsgBox("请输入电话号码")
            TextBox1.Focus()
            Return
        ElseIf Not IsNumeric(TextBox1.Text.Trim) Then
            MsgBox("电话号码应当是数字")
            TextBox1.Focus()
            Return
        ElseIf TextBox1.Text.Trim.Length > 20 Then
            MsgBox("请注意检查电话号码")
            TextBox1.Focus()
            Return
        ElseIf Not TextBox1.Text.Trim.Length = 11 Then
            If MsgBox("请注意检查电话号码,仍要添加？", vbOKCancel, "警告") = MsgBoxResult.Ok Then

            Else
                TextBox1.Focus()
                Return
            End If
        End If

        If Text_fstTopUp.Text.Trim = "" Then
            MsgBox("请输入充值金额")
            Text_fstTopUp.Focus()
            Return
        ElseIf Not IsNumeric(Text_fstTopUp.Text.Trim) Then
            MsgBox("输入金额应当是数字")
            Text_fstTopUp.Focus()
            Return
        End If

        card.customer_phone = TextBox1.Text.Trim

        Dim decResult As Decimal
        If Decimal.TryParse(Text_fstTopUp.Text, decResult) = True Then
            card.balance = decResult
        Else
            MsgBox("输入金额有误")
            Text_fstTopUp.Focus()
            Return
        End If

        Dim token As String = getDataFromLocal.getToken()
        Dim frmAuth As New FrmAuthPrompt(2)
        If Not frmAuth.AuthResult = True Then
            MsgBox("需要验证密码")
            Return
        Else
            Try
                If decResult > Rules.top_level Then
                    Dim postStr As String = BLL.UpdateCardInfo.openDiscount(card.card_id)
                    httpCon.PostData("https://api.weixin.qq.com/card/update?access_token=" + token, postStr)
                    Dim updateStr As String = BLL.UpdateCardInfo.setDiscount(card, "高级", Rules.top_discount.ToString + "折")
                    httpCon.PostData("https://api.weixin.qq.com/card/membercard/updateuser?access_token=" + token, updateStr)
                    card.type_id = db.MemberType.Where(Function(x) x.name = "高级").First.id
                    MsgBox("已充值满" + Rules.top_level.ToString + "元获得高级会员资格")

                ElseIf decResult > Rules.meidum_level Then
                    Dim postStr As String = BLL.UpdateCardInfo.openDiscount(card.card_id)
                    httpCon.PostData("https://api.weixin.qq.com/card/update?access_token=" + token, postStr)
                    Dim updateStr As String = BLL.UpdateCardInfo.setDiscount(card, "中等", Rules.medium_discount.ToString + "折")
                    httpCon.PostData("https://api.weixin.qq.com/card/membercard/updateuser?access_token=" + token, updateStr)
                    card.type_id = db.MemberType.Where(Function(x) x.name = "中等").First.id
                    MsgBox("已充值满" + Rules.meidum_level.ToString + "元获得中级会员资格")

                ElseIf decResult > Rules.normal_level Then
                    Dim postStr As String = BLL.UpdateCardInfo.openDiscount(card.card_id)
                    httpCon.PostData("https://api.weixin.qq.com/card/update?access_token=" + token, postStr)
                    Dim updateStr As String = BLL.UpdateCardInfo.setDiscount(card, "普通", Rules.normal_discount.ToString + "折")
                    httpCon.PostData("https://api.weixin.qq.com/card/membercard/updateuser?access_token=" + token, updateStr)
                    card.type_id = db.MemberType.Where(Function(x) x.name = "普通").First.id
                    MsgBox("已充值满" + Rules.normal_level.ToString + "元获得普通会员资格")
                Else
                    card.type_id = db.MemberType.Where(Function(x) x.name = "无").First.id
                End If

            Catch ex As Exception
                MsgBox("网络连接有误，请重试", vbQuestion)
                Return
            End Try


            If DAL.dalCard.Addcard(db, card) AndAlso
                DAL.dalTrans.addTrans(db, card, LoginRoler.U_Id， Decimal.Parse(Text_fstTopUp.Text)) Then

                MsgBox("储值服务已开通")
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("数据库损坏，请联系客服")
                Return
            End If

            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class