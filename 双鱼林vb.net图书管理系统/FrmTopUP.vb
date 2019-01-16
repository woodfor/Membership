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