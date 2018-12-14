Public Class Frm登陆成功显示进度
    '进度条显示
    Private count As Integer = 20

    Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        If progressBar1.Value < 98 Then
            progressBar1.Value += count
        Else
            timer1.Enabled = False
            Dim frm As New Frm主面()
            frm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Frm登陆成功显示进度_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        timer1.Enabled = True
    End Sub
End Class