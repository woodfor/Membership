﻿Imports System.Collections.Generic
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

Partial Public Class FrmAddBook
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private book As New Book()
    Private card As New CardInfo()
    Private token As New Token()
    Private user As New User()

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

    Private Sub Btn_Add_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Add.Click
        If Me.txt_barcode.Text = "" Then
            MessageBox.Show("条形码输入不能为空!")
            Me.txt_barcode.Focus()
            Return
        End If


        'book.barcode = Me.txt_barcode.Text
        ''图书条形码
        'If Me.txt_bookName.Text = "" Then
        '    MessageBox.Show("图书名称输入不能为空!")
        '    Me.txt_bookName.Focus()
        '    Return
        'End If
        'book.bookName = Me.txt_bookName.Text
        ''图书名称

        'book.bookType = Int32.Parse(Me.cb_bookType.SelectedValue.ToString())
        ''图书类别
        'Try
        '    '图书价格
        '    book.price = Convert.ToSingle(Me.txt_price.Text)
        'Catch
        '    MessageBox.Show("图书价格请输入正确的格式!")
        '    Me.txt_price.SelectAll()
        '    Me.txt_price.Focus()
        '    Return
        'End Try

        'Try
        '    '图书库存
        '    book.count = Convert.ToInt32(Me.txt_count.Text)
        'Catch
        '    MessageBox.Show("图书库存请输入正确的格式!")
        '    Me.txt_count.SelectAll()
        '    Me.txt_count.Focus()
        '    Return
        'End Try

        'book.publish = Me.txt_publish.Text
        ''出版社
        'book.publishDate = Me.dtp_publishDate.Value



        'If BLL.bllBook.AddBook(book) Then
        '    MessageBox.Show("图书添加成功!")
        'Else
        '    MessageBox.Show("图书添加失败!")
        'End If

        'Me.Close()


    End Sub


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



    End Sub

    Private Sub txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged
        If txt_barcode.Text.Length = 12 Then
            Dim response As String

            Dim userResponse As String

            Try

                token.ID = getDataFromLocal.getToken()

                Dim dic As Dictionary(Of String, Object) = New Dictionary(Of String, Object) From {
                {"code", txt_barcode.Text}}
                Dim cardNumber As String = Newtonsoft.Json.JsonConvert.SerializeObject(dic)

                Try
                    Dim idPr As JObject = CType(JsonConvert.DeserializeObject(httpCon.PostData("https://api.weixin.qq.com/card/code/get?access_token=" + token.ID, cardNumber)), Object)
                    If String.Compare(idPr("errcode").ToString(), "0") = 0 Then

                        Dim mPr As JObject = CType(JsonConvert.DeserializeObject(idPr("card").ToString), Object)
                        card.ID = mPr("card_id").ToString()


                        Dim tokenAPI As String = "https://api.weixin.qq.com/card/membercard/userinfo/get?access_token=" + token.ID
                        Try
                            response = httpCon.PostData(tokenAPI, cardNumber)
                            txt_publish.Text = response
                            Dim pr As JObject = CType(JsonConvert.DeserializeObject(response), Object)
                            response = pr("errcode").ToString()
                            If String.Compare(response, "0") = 0 Then
                                MessageBox.Show("获取卡的信息成功")
                                txt_bonus.Text = pr("bonus").ToString
                                txt_card_status.Text = pr("user_card_status").ToString

                                Try
                                    Dim tempUrl As String = "https://api.weixin.qq.com/cgi-bin/user/info?access_token=" + token.ID + "&openid=" + pr("openid").ToString() + "&lang=zh_CN"
                                    userResponse = httpCon.PostData(tempUrl, "")
                                    Dim uPr As JObject = CType(JsonConvert.DeserializeObject(userResponse), Object)
                                    user.Name = uPr("nickname").ToString()
                                    user.openID = uPr("openid").ToString
                                    txt_userName.Text = user.Name
                                    '基本信息读取完毕
                                    card.cardNumber = txt_barcode.Text
                                    card.bonus = txt_bonus.Text
                                    card.status = txt_card_status.Text
                                    Dim customPr As JObject = CType(JsonConvert.DeserializeObject(pr("user_info").ToString()), Object)
                                    If String.Compare(customPr("custom_field_list").ToString(), "[]") = 0 Then
                                        txt_level.Text = "暂未设置会员等级"
                                        Button_addLevel.Enabled = True
                                    Else
                                        Dim levelPr As JObject = CType(JsonConvert.DeserializeObject(customPr("custom_field_list").ToString()), Object)
                                        card.memberLevel = levelPr("level").ToString
                                    End If
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

            Catch
                MessageBox.Show("local file error")
                Return
            End Try

            '读取储值数据库
            Try
                Dim card_topup As Card = DAL.dalCard.getSomeCard(card.ID)

                If IsNothing(card_topup) Then
                    Button_openTopUp.Enabled = True
                Else
                    GroupBox_topUp.Visible = True
                    Button_openTopUp.Dispose()
                    txt_balance.Text = card_topup.balance.ToString
                    Button_topUp.Enabled = True
                End If
            Catch
                MsgBox("数据库损坏，请联系客服")
            End Try

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_addLevel.Click


        Dim post_dic As Dictionary(Of String, Object) = New Dictionary(Of String, Object) From {
               {"card_id", card.ID},
               {"member_card", New memberCard("C")}
            }
        Dim postStr As String = Newtonsoft.Json.JsonConvert.SerializeObject(post_dic)
        testbox.Text = postStr
        Text_temp.Text = httpCon.PostData("https://api.weixin.qq.com/card/update?access_token=" + token.ID, postStr)
    End Sub

    Private Sub Button_openTopUp_Click(sender As Object, e As EventArgs) Handles Button_openTopUp.Click
        Dim card_TopUp As New Card
        card_TopUp.card_id = card.ID
        card_TopUp.user_name = user.Name
        card_TopUp.open_id = user.openID
        card_TopUp.balance = Decimal.Parse("0.00")
        card_TopUp.store_id = 1
        Dim frm_phone As New FrmRequestInfo(card_TopUp)
        '事件完成，判断返回值
        If frm_phone.ShowDialog() = DialogResult.OK Then
            Try
                card_TopUp = DAL.dalCard.getSomeCard(card.ID)

                If IsNothing(card_TopUp) Then
                    MsgBox("数据更新未完成，请重试")
                    Return
                Else
                    GroupBox_topUp.Visible = True
                    Button_openTopUp.Dispose()
                    txt_balance.Text = card_TopUp.balance.ToString
                    Button_topUp.Enabled = True
                End If
            Catch
                MsgBox("数据库损坏，请联系客服")
            End Try
        End If
    End Sub

    Private Sub Button_topUp_Click(sender As Object, e As EventArgs) Handles Button_topUp.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
