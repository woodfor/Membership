Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports BLL
Imports Model

Public Delegate Sub GetState(ByVal name As String)

Partial Public Class Frm个人信息
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub
    Public byte_Image As Byte() = Nothing
    '添加   
    Public byte_Image2 As Byte() = Nothing
    '查看
    Public id As Integer
    Public Pagetype As String = ""
    '操作类型
    Public Event getName As GetState

    Private frmUser As Frm人员管理 = Nothing


    ''' <summary>
    ''' 图片上传
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        Try
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
            openFileDialog1.Filter = "图片（*.jpg;*.bmp;*.gif,*.png）|*.jpg;*.bmp;*.gif;*.png"
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Me.txt_pic.Text = openFileDialog1.FileName
                pictureBox1.Image = Image.FromFile(txt_pic.Text)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Dim fs As New FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)
                Dim bw As New BinaryReader(fs)
                byte_Image = bw.ReadBytes(CInt(fs.Length))
            End If
        Catch
            MessageBox.Show("请选择正确的图片格式", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub

    ''' <summary>
    ''' 窗体加载
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Frm个人信息_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim appSettings As System.Configuration.AppSettingsSection = CType(config.GetSection("appSettings"), System.Configuration.AppSettingsSection)

        Dim ButtonShow As String = appSettings.Settings("ButtonShow").Value
        '是否显示密保按钮(0:隐藏 1:显示)
        If ButtonShow = "0" Then
            Me.checkBox1.Visible = False
        End If

        GetUserInfo()
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.Click
        If checkBox1.Checked Then
            Dim frm As New Frm找回密码()
            frm.Message("false")
            frm.ShowDialog()
        End If
    End Sub

    ''' <summary>
    ''' 传递参数
    ''' </summary>
    ''' <param name="sid">主键</param>
    ''' <param name="type">添加 | 修改</param>
    ''' 

    Public Sub Message(ByVal sid As Integer, ByVal type As String)
        Me.id = sid
        '编号
        Me.Pagetype = type 
    End Sub


    Public Sub Message(ByVal sid As Integer, ByVal type As String, ByRef frmUser As Frm人员管理)
        Me.id = sid
        '编号
        Me.Pagetype = type

        Me.frmUser = frmUser
    End Sub

    ''' <summary>
    ''' 退出
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 保存
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Dim user As New MU_UserInfo()

        Dim com As New Common()

        If byte_Image Is Nothing Then
            '显示用户生活照
            If byte_Image2 Is Nothing Then
                MessageBox.Show("请上传个人生活照!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Return
            Else
                user.U_Image = byte_Image2
            End If
        Else
            user.U_Image = byte_Image
        End If

        user.U_Name = U_Name.Text
        '用户名
        user.U_RelName = U_RelName.Text
        '用户真实姓名
        user.U_Sex = False

        If Me.radio_women.Checked = True Then
            '男
            user.U_Sex = True
        End If

        user.U_Birthday = Me.U_Birthday.Value
        '出生日期
        If U_IdCard.Text <> "" Then
            If com.RegexcardID(U_IdCard.Text) Then
                '身份证号
                user.U_IdCard = U_IdCard.Text
            Else
                MessageBox.Show("身份证号格式输入错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Else
            user.U_IdCard = ""
        End If

        user.U_NativePlace = U_NativePlace.Text
        '籍贯
        user.U_Address = U_Address.Text
        '家庭住址
        user.U_Position = U_Position.Text
        '邮编
        If U_Telephone.Text <> "" Then
            If com.RegexPhone(U_Telephone.Text) Then
                '电话号码
                user.U_Telephone = U_Telephone.Text
            Else
                MessageBox.Show("电话号码格式输入错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Else
            user.U_Telephone = ""
        End If

        If U_Email.Text <> "" Then
            If com.RegexEmail(U_Email.Text) Then
                '邮箱号码
                user.U_Email = U_Email.Text
            Else
                MessageBox.Show("邮箱号码格式输入错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Else
            user.U_Email = ""
        End If
        user.U_PostalId = U_PostalId.Text
        '邮编号码
        user.U_QQ = ""
        'QQ
        user.U_Position = U_Position.Text
        '职位


        user.U_Id = id

        Dim flag As Boolean = New BU_UserInfo().Update(user)

        If flag Then
            'getName("随便传的值");
            If LoginRoler.U_ROlesType = 2 Then
            End If
            MessageBox.Show("修改成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Me.Close()
        Else
            MessageBox.Show("修改失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

        If frmUser Is Nothing = False Then
            frmUser.dataBind()
        End If



    End Sub

    ''' <summary>
    ''' 获取用户信息
    ''' </summary>
    Public Sub GetUserInfo()
        Dim bll As New BU_UserInfo()

        Dim user As MU_UserInfo = bll.GetModel(id)

        U_Name.Text = user.U_Name
        '用户名
        U_Name.[ReadOnly] = True

        U_RelName.Text = user.U_RelName
        '用户真实姓名
        If user.U_Sex = True Then
            '女
            Me.radio_women.Checked = True
        End If

        Me.U_Birthday.Value = user.U_Birthday
        '出生日期
        U_IdCard.Text = user.U_IdCard
        '身份证号
        U_NativePlace.Text = user.U_NativePlace
        '籍贯
        U_Address.Text = user.U_Address
        '家庭住址
        U_Telephone.Text = user.U_Telephone
        '电话号码
        U_Email.Text = user.U_Email
        '邮箱号码
        U_PostalId.Text = user.U_PostalId
        '邮编号码
        'U_QQ.Text = user.U_QQ;//QQ
        U_Position.Text = user.U_Position
        '职位
        '显示用户生活照
        If user.U_Image IsNot Nothing Then
            byte_Image2 = DirectCast(user.U_Image, Byte())
            Dim ms As New MemoryStream(byte_Image2)
            pictureBox1.Image = Image.FromStream(ms)
        End If
    End Sub


End Class
