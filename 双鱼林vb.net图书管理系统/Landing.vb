Imports System.Configuration
Imports BLL
Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient


Public Class Landing

    ''' <summary>
    ''' 窗体加载事件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Landing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim appSettings As System.Configuration.AppSettingsSection = CType(config.GetSection("appSettings"), System.Configuration.AppSettingsSection)


        Dim version As String = appSettings.Settings("version").Value
        '窗口标题
        Me.label3.Text = version

        checkCode = GetRandomCode(4)
        CreateImage(checkCode)

        Me.Opacity = 0
        timer1.Start()

        Dim ButtonShow As String = appSettings.Settings("ButtonShow").Value 
        '是否显示登录界面密码找回按钮(0:隐藏 1:显示)
        If ButtonShow = "0" Then
            linkLabel2.Visible = False
        End If
    End Sub

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

        '更改背景色
        label1.Parent = pictureBox1
        label2.Parent = pictureBox1
        label3.Parent = pictureBox1
        linkLabel1.Parent = pictureBox1
        linkLabel2.Parent = pictureBox1

        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim appSettings As System.Configuration.AppSettingsSection = CType(config.GetSection("appSettings"), System.Configuration.AppSettingsSection)

        Me.skinEngine1.SkinFile = "../../Skins/" & appSettings.Settings("image").Value

        Me.skinEngine1.SkinAllForm = True
        Me.Text = appSettings.Settings("title").Value


    End Sub


    Public Shared checkCode As String = ""
    ''' <summary>
    ''' 产生验证码随机数
    ''' </summary>
    ''' <param name="CodeCount"></param>
    ''' <returns></returns>
    Private Function GetRandomCode(ByVal CodeCount As Integer) As String
        'Dim allChar As String = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,i,J,K,M,N,P,Q,R,S,T,U,W,X,Y,Z"
        'Dim allCharArray As String() = allChar.Split(","c)
        'Dim RandomCode As String = ""
        'Dim temp As Integer = -1

        'Dim rand As New Random()
        'For i As Integer = 0 To CodeCount - 1
        '    If temp <> -1 Then
        '        rand = New Random(temp * i * CInt(DateTime.Now.Ticks))
        '    End If

        '    Dim t As Integer = rand.[Next](33)

        '    While temp = t
        '        t = rand.[Next](33)
        '    End While

        '    temp = t
        '    RandomCode += allCharArray(t)
        'Next

        'Return RandomCode
        Dim allChar As String = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,W,X,Y,Z"
        Dim allCharArray() As String = allChar.Split(",")
        Dim randomCode As String = ""
        Dim temp As Integer = -1
        Dim rand As Random = New Random
        Dim i As Integer = 0
        Do While (i < 4)
            If (temp <> -1) Then
                Dim aa As Integer = CType(DateTime.Now.Ticks Mod System.Int32.MaxValue, Integer) '根据时间生成随机数种子
                rand = New Random(aa)
            End If
            Dim t As Integer = rand.Next(61) + 1
            If t > allCharArray.Length - 1 Then t = allCharArray.Length - 1
            If temp = t Then '抑制产生连续重复的验证码。

                i -= 1
                randomCode = Microsoft.VisualBasic.Left(randomCode, i)
            End If
            temp = t
            randomCode = randomCode + allCharArray(t)
            i += 1
        Loop
        Return randomCode

    End Function




    ''' <summary>
    ''' 创建验证码图片
    ''' </summary>
    ''' <param name="checkCode"></param>
    Private Sub CreateImage(ByVal checkCode As String)
        Dim iwidth As Integer = CInt(checkCode.Length * 14)
        Dim image As New System.Drawing.Bitmap(iwidth, 21)
        Dim g As Graphics = Graphics.FromImage(image)
        Dim f As Font = New System.Drawing.Font("Arial ", 10)
        ', System.Drawing.FontStyle.Bold);
        Dim b As Brush = New System.Drawing.SolidBrush(Color.Black)
        Dim r As Brush = New System.Drawing.SolidBrush(Color.FromArgb(166, 8, 8))

        g.Clear(System.Drawing.ColorTranslator.FromHtml("#99C1CB"))
        '背景色
        Dim ch As Char() = checkCode.ToCharArray()
        For i As Integer = 0 To ch.Length - 1
            If ch(i) >= "0"c AndAlso ch(i) <= "9"c Then
                '数字用红色显示
                g.DrawString(ch(i).ToString(), f, r, 3 + (i * 12), 3)
            Else
                '字母用黑色显示
                g.DrawString(ch(i).ToString(), f, b, 3 + (i * 12), 3)
            End If
        Next
        Dim ms As New System.IO.MemoryStream()
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        'history back 不重复 
        pictureBox2.Image = image
    End Sub
    ''' <summary>
    ''' 刷新验证码
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pictureBox2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pictureBox2.Click
        checkCode = GetRandomCode(4)
        CreateImage(checkCode)
    End Sub

    ''' <summary>
    ''' 窗体显示效果
    ''' </summary>
    Private dou As Double = 0.03
    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
        Me.Opacity += dou
        If Me.Opacity = 1 Then
            timer1.[Stop]()

            dou = -0.05
        ElseIf Me.Opacity = 0 Then
            timer1.[Stop]()
        End If
    End Sub

    ''' <summary>
    ''' 退出
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Application.[Exit]()
    End Sub

    Private isMouseDown As Boolean = False
    Private FormLocation As Point
    'form的location
    Private mouseOffset As Point
    '鼠标的按下位置

    Private Sub pictureBox1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            isMouseDown = True
            FormLocation = Me.Location
            mouseOffset = Control.MousePosition
        End If
    End Sub

    Private Sub pictureBox1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox1.MouseMove
        Dim _x As Integer = 0
        Dim _y As Integer = 0
        If isMouseDown Then
            Dim pt As Point = Control.MousePosition
            _x = mouseOffset.X - pt.X
            _y = mouseOffset.Y - pt.Y

            Me.Location = New Point(FormLocation.X - _x, FormLocation.Y - _y)
        End If
    End Sub

    Private Sub pictureBox1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pictureBox1.MouseUp
        isMouseDown = False
    End Sub

    ''' <summary>
    ''' 登录
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim username As String = Me.txt_username.Text

        Dim password As String = Me.txt_Pwd.Text

        If username = "" Then
            MessageBox.Show("用户名不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        ElseIf password = "" Then
            MessageBox.Show("密码不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        ElseIf Me.textBox1.Text.Trim() = "" Then
            MessageBox.Show("验证码不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If checkCode.ToLower() <> Me.textBox1.Text.Trim().ToLower() Then
                MessageBox.Show("验证码输入错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                Dim Bll As New BU_UserInfo()

                Dim a As Integer = Bll.ExistsName(username)

                If a <> 0 Then
                    '密码处理,经过加密
                    Dim result As Byte() = Encoding.[Default].GetBytes(password)
                    'password为输入密码的文本框
                    Dim md5 As MD5 = New MD5CryptoServiceProvider()
                    Dim output As Byte() = md5.ComputeHash(result)

                    Dim ds As DataSet = Bll.ExistsPwd(username, BitConverter.ToString(output).Replace("-", ""))


                    If ds.Tables(0).Rows.Count > 0 Then
                        MessageBox.Show("登录成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        LoginRoler.U_Id = Convert.ToInt32(ds.Tables(0).Rows(0)(0).ToString())
                        '用户主键
                        LoginRoler.U_Name = username
                        '获取当前登录的用户名    
                        LoginRoler.U_ROlesType = Convert.ToInt32(ds.Tables(0).Rows(0)(1).ToString())
                        '用户类型
                        Me.Visible = False
                        checkCode = ""
                        Dim frm As New Frm登陆成功显示进度()
                        frm.ShowDialog()
                    Else
                        MessageBox.Show("密码输入错误,请重新输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        Me.txt_Pwd.Text = ""
                        Me.txt_username.Text = ""
                        Me.textBox1.Text = ""
                        '调用刷新验证码方法
                        pictureBox2_Click(sender, e)
                    End If
                Else
                    MessageBox.Show("用户名不存在,请重新输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Me.txt_Pwd.Text = ""
                    Me.txt_username.Text = ""
                    Me.textBox1.Text = ""
                    '调用刷新验证码方法
                    pictureBox2_Click(sender, e)
                End If
            End If
        End If
    End Sub


    ''' <summary>
    ''' 注册
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub linkLabel1_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel1.LinkClicked
        Dim login As New login()

        'login.getName += New GetName(AddressOf login_getName)
        login.ShowDialog()
    End Sub

    '委托获取传来的值
    Public Sub login_getName(ByVal s As String)
        Me.txt_username.Text = s
    End Sub
    '密码找回
    Private Sub linkLabel2_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel2.LinkClicked
        Dim frm As New Frm找回密码()
        frm.ShowDialog()
    End Sub

    Private Sub linkLabel3_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles linkLabel3.LinkClicked
        System.Diagnostics.Process.Start("http://www.shuangyulin.com")
    End Sub


End Class