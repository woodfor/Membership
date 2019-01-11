Imports BLL
Public Class Frm登陆成功显示进度
    '进度条显示
    Private count As Integer = 20

    Private Function init() As Boolean
        Label1.Text = "与服务器进行通讯中。。。"
        If GetToken.GetToken() Then
            Label1.Text = "服务器通讯成功！ 组件正在加载"
            Return True
        Else
            Return False
        End If
    End Function
    'Private Sub timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
    '    If progressBar1.Value < 98 Then
    '        progressBar1.Value += count
    '    Else
    '        timer1.Enabled = False

    '    End If
    'End Sub

    Private Sub Frm登陆成功显示进度_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'timer1.Enabled = False

        If init() Then
            Dim frm As New Frm主面()
            frm.Show()
            Me.Close()
        Else
            If MessageBox.Show("连接服务器发生错误，请检查网络。如网络未发生异常，请联系客服。点击OK重试，点击Cancel退出程序 ",
                            "服务器错误",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

                init()
            Else
                Application.Exit()
            End If
        End If
    End Sub


End Class