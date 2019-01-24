Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Model
Imports System.Net
Imports BLL
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization

Partial Public Class FrmAddBook
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private book As New Book()
    Private card As New CardInfo()
    Private token As New Token()
    Private user As New User()
    Private card_TopUp As New Card
    Dim db As New Transaction
    'Private Sub btn_bookPhoto_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim openFileDialog1 As New OpenFileDialog()
    '    Try
    '        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
    '        openFileDialog1.Filter = "图片（*.jpg;*.bmp;*.gif,*.png）|*.jpg;*.bmp;*.gif;*.png"
    '        If openFileDialog1.ShowDialog() = DialogResult.OK Then
    '            Me.txt_bookPhoto.Text = openFileDialog1.FileName
    '            pictureBox_bookPhoto.Image = Image.FromFile(txt_bookPhoto.Text)
    '            pictureBox_bookPhoto.SizeMode = PictureBoxSizeMode.StretchImage
    '            Dim fs As New FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)
    '            Dim bw As New BinaryReader(fs)
    '            book.bookPhoto = bw.ReadBytes(CInt(fs.Length))
    '        End If
    '    Catch
    '        MessageBox.Show("请选择正确的图片格式", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '    End Try
    'End Sub



    Private Sub FrmAddBook_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        '查询所有的图书类别
        'Dim bookTypeDs As DataSet = BLL.bllBookType.getAllBookType()

        'Me.cb_bookType.DataSource = bookTypeDs.Tables(0)
        'Me.cb_bookType.DisplayMember = "bookTypeName"
        'Me.cb_bookType.ValueMember = "bookTypeId"
        GroupBox_topUp.Visible = False
        '
        '            DataTable newDataTable = new DataTable();
        '            newDataTable.Columns.Add("bookTypeId");
        '            newDataTable.Columns.Add("bookTypeName");
        '
        '            foreach (DataRow oldDR in bookTypeDs.Tables[0].Rows)
        '            {
        '                DataRow newDR = newDataTable.NewRow();
        '                newDR[0] = oldDR["bookTypeId"].ToString();
        '                newDR[1] = oldDR["bookTypeName"].ToString();
        '                newDataTable.Rows.InsertAt(newDR, newDataTable.Rows.Count);
        '            }
        '
        '            // Add your 'Select an item' option at the top  
        '            DataRow dr = newDataTable.NewRow();
        '            dr[0] = "0";
        '            dr[1] = "请选择";
        '            newDataTable.Rows.InsertAt(dr, 0);
        '
        '            this.cb_bookType.DataSource = newDataTable;
        '            this.cb_bookType.DisplayMember = "bookTypeName";
        '            this.cb_bookType.ValueMember = "bookTypeId"; 
        '             


        pictureBox_bookPhoto.Image = Image.FromFile("pic/NoImage.jpg")
        pictureBox_bookPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        Dim fs As New FileStream("pic/NoImage.jpg", FileMode.Open, FileAccess.Read)
        Dim bw As New BinaryReader(fs)
        book.bookPhoto = bw.ReadBytes(CInt(fs.Length))
        txt_barcode.TabIndex = 0


    End Sub

    Private Sub txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged
        If txt_barcode.Text.Length = 12 Then
            Dim response As String
            Dim pr As JObject
            Dim userResponse As String
            Dim cardNumber As String

            Try
                token.ID = getDataFromLocal.getToken()
                Dim dic As Dictionary(Of String, Object) = New Dictionary(Of String, Object) From {
                {"code", txt_barcode.Text}}
                cardNumber = Newtonsoft.Json.JsonConvert.SerializeObject(dic)
                pr = CType(JsonConvert.DeserializeObject(httpCon.PostData("https://api.weixin.qq.com/card/code/get?access_token=" + token.ID, cardNumber)), Object)
                If String.Compare(pr("errcode").ToString(), "0") = 0 Then

                    card.ID = pr("card")("card_id").ToString()
                Else
                    MessageBox.Show("卡片信息不正确，请重新扫描")
                    Return
                End If
            Catch ex As Exception
                If GetToken.GetToken() = True Then
                    txt_barcode_TextChanged(Nothing, Nothing)
                Else
                    If MessageBox.Show("连接服务器发生错误，请检查网络。如网络未发生异常，请联系客服。点击OK重试，点击Cancel取消操作。 ",
                        "服务器错误",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                        txt_barcode_TextChanged(Nothing, Nothing)
                    Else

                    End If
                End If
                Return
            End Try

            '读取储值数据库




            Try
                Dim tmpCard As New Card
                tmpCard = DAL.dalCard.getSomeCard(db, card.ID)
                If IsNothing(tmpCard) Then
                    Button_openTopUp.Enabled = True
                    'Dim postStr As String = BLL.UpdateCardInfo.openDiscount(card.ID, 9)
                    'Dim updateStr As String = BLL.UpdateCardInfo.setDiscount(card, "9折")
                    'Text_temp.Text = httpCon.PostData("https://api.weixin.qq.com/card/update?access_token=" + token.ID, postStr)
                    'Text_temp.Text = httpCon.PostData("https://api.weixin.qq.com/card/membercard/updateuser?access_token=" + token.ID, updateStr)
                Else
                    card_TopUp = tmpCard
                    Dim trans = DAL.dalTrans.findLastTopUp(db, card_TopUp.card_id)
                    GroupBox_topUp.Visible = True
                    Button_openTopUp.Dispose()
                    txt_balance.Text = card_TopUp.balance.ToString
                    Text_lastTopUp.Text = trans.time
                    Button_topUp.Enabled = True
                End If
            Catch
                MsgBox("数据库损坏，请联系客服")
                Return
            End Try

            'Read all the info
            Dim tokenAPI As String = "https://api.weixin.qq.com/card/membercard/userinfo/get?access_token=" + token.ID
                Try
                    response = httpCon.PostData(tokenAPI, cardNumber)
                    testbox.Text = response
                    pr = CType(JsonConvert.DeserializeObject(response), Object)
                    If String.Compare(pr("errcode").ToString(), "0") = 0 Then
                        txt_bonus.Text = pr("bonus").ToString
                        txt_card_status.Text = pr("user_card_status").ToString
                    'read users' info
                    Try
                            Dim tempUrl As String = "https://api.weixin.qq.com/cgi-bin/user/info?access_token=" + token.ID + "&openid=" + pr("openid").ToString() + "&lang=zh_CN"
                            userResponse = httpCon.PostData(tempUrl, "")
                            pr = CType(JsonConvert.DeserializeObject(userResponse), Object)
                            user.Name = pr("nickname").ToString()
                            user.openID = pr("openid").ToString
                            txt_userName.Text = user.Name
                            '基本信息读取完毕
                            card.cardNumber = txt_barcode.Text
                            card.bonus = txt_bonus.Text
                            card.status = txt_card_status.Text
                            '获取折扣信息
                            Dim postStr As String = BLL.UpdateCardInfo.getDetail(card)
                            pr = CType(JsonConvert.DeserializeObject(httpCon.PostData("https://api.weixin.qq.com/card/get?access_token=" + token.ID, postStr)), Object)
                        Try
                            Text_discount.Text = pr("card")("member_card")("discount").ToString
                        Catch ex As Exception
                            MsgBox("未设置折扣")
                        End Try
                        txt_level.Text = "暂未设置会员等级"
                    Catch
                            MessageBox.Show("获取用户信息时发生网络错误")
                            Return
                        End Try
                    Else
                        MessageBox.Show(pr("errmsg").ToString)
                        Return
                    End If
                Catch
                    MessageBox.Show("网络未连接，请更新WIFI后重试")
                    Return
                End Try


        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_addLevel.Click
        Try
            token.ID = getDataFromLocal.getToken()
        Catch ex As Exception
            MsgBox("本地文件异常，请重试")
        End Try

        'Dim postStr As String = BLL.UpdateCardInfo.getDetail(card)
        'testbox.Text = postStr
        'Text_temp.Text = httpCon.PostData("https://api.weixin.qq.com/card/get?access_token=" + token.ID, postStr)

    End Sub

    Private Sub Button_openTopUp_Click(sender As Object, e As EventArgs) Handles Button_openTopUp.Click

        card_TopUp.card_id = card.ID
        card_TopUp.number = card.cardNumber
        card_TopUp.user_name = user.Name
        card_TopUp.open_id = user.openID
        card_TopUp.balance = Decimal.Parse("0.00")
        card_TopUp.store_id = 1
        Dim frm_phone As New FrmRequestInfo(card_TopUp)

        '事件完成，判断返回值
        If frm_phone.ShowDialog() = DialogResult.OK Then
            Try
                card_TopUp = DAL.dalCard.getSomeCard(db, card.ID)
                Dim trans = DAL.dalTrans.findLastTopUp(db, card_TopUp.card_id)
                If IsNothing(card_TopUp) AndAlso IsNothing(trans) Then
                    MsgBox("数据更新未完成，请重试")
                    Return
                Else
                    GroupBox_topUp.Visible = True
                    Button_openTopUp.Dispose()
                    txt_balance.Text = card_TopUp.balance.ToString
                    Text_lastTopUp.Text = trans.time
                    Button_topUp.Enabled = True
                End If
            Catch
                MsgBox("数据库损坏，请联系客服")
            End Try
        End If
    End Sub

    Private Sub Button_topUp_Click(sender As Object, e As EventArgs) Handles Button_topUp.Click
        'Try
        Dim frm_topUp As New FrmTopUP(db, card_TopUp)
        If frm_topUp.ShowDialog = DialogResult.OK Then
            Try

                card_TopUp = DAL.dalCard.getSomeCard(db, card.ID)
                Dim trans = DAL.dalTrans.findLastTopUp(db, card_TopUp.card_id)
                If IsNothing(card_TopUp) AndAlso IsNothing(trans) Then
                    MsgBox("数据更新未完成，请重试")
                    Return
                Else
                    GroupBox_topUp.Visible = True
                    Button_openTopUp.Dispose()
                    txt_balance.Text = card_TopUp.balance.ToString
                    Text_lastTopUp.Text = trans.time
                    Button_topUp.Enabled = True
                End If
            Catch
                MsgBox("数据库损坏，请联系客服")
            End Try
        End If
        'Catch ex As Exception

        'End Try
    End Sub
End Class
