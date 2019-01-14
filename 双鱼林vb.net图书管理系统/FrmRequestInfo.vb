Public Class FrmRequestInfo
    Private card As Model.Card
    Public Sub New(ByVal card As Model.Card)

        ' This call is required by the designer.
        InitializeComponent()
        Me.card = card
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
            MsgBox("电话号码应当是数字")
            Text_fstTopUp.Focus()
            Return
        End If

        card.customer_phone = TextBox1.Text.Trim

        Dim decResult As Decimal
        If Decimal.TryParse(Text_fstTopUp.Text, decResult) = True Then
            card.balance = decResult
        Else
            MsgBox("输入金额的小数点应不超过两位")
            Text_fstTopUp.Focus()
            Return
        End If

        Dim frmAuth As New FrmAuthPrompt(2)
        If Not frmAuth.AuthResult = True Then
            MsgBox("需要验证密码")
            Return
        Else
            Try
                DAL.dalCard.Addcard(card)
            Catch ex As Exception
                MsgBox("数据库损坏，请联系客服")
                Return
            End Try

            MsgBox("储值服务已开通")
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class