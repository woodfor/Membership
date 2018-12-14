Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Imports System.IO
Imports Model


Partial Public Class FrmEditBook
    Inherits Form
    Public Sub New(ByVal barcode As [String], ByVal frmQueryBook As FrmQueryBook)
        InitializeComponent()

        Me.barcode = barcode
        Me.frmQueryBook = frmQueryBook
    End Sub

    Private book As Book
    Private barcode As [String]
    Private frmQueryBook As FrmQueryBook

    '
    '        public void setBarCode(String barcode)
    '        {
    '            this.barcode = barcode;
    '        }
    '        


    Private Sub Btn_Update_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Update.Click


        If Me.txt_bookName.Text = "" Then
            MessageBox.Show("图书名称输入不能为空!")
            Me.txt_bookName.Focus()
            Return
        End If
        book.bookName = Me.txt_bookName.Text
        '图书名称

        book.bookType = Int32.Parse(Me.cb_bookType.SelectedValue.ToString())
        '图书类别
        Try
            '图书价格
            book.price = Convert.ToSingle(Me.txt_price.Text)
        Catch
            MessageBox.Show("图书价格请输入正确的格式!")
            Me.txt_price.SelectAll()
            Me.txt_price.Focus()
            Return
        End Try

        Try
            '图书库存
            book.count = Convert.ToInt32(Me.txt_count.Text)
        Catch
            MessageBox.Show("图书库存请输入正确的格式!")
            Me.txt_count.SelectAll()
            Me.txt_count.Focus()
            Return
        End Try

        book.publish = Me.txt_publish.Text
        '出版社
        book.publishDate = Me.dtp_publishDate.Value



        If BLL.bllBook.EditBook(book) Then
            MessageBox.Show("图书更新成功!")
        Else
            MessageBox.Show("图书更新失败!")
        End If

        'FrmQueryBook frmQueryBook = (FrmQueryBook)this.Parent;
        frmQueryBook.BindData("refresh")

        Me.Close()
    End Sub

    Private Sub btn_bookPhoto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_bookPhoto.Click
        Dim openFileDialog1 As New OpenFileDialog()
        Try
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
            openFileDialog1.Filter = "图片（*.jpg;*.bmp;*.gif,*.png）|*.jpg;*.bmp;*.gif;*.png"
            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Me.txt_bookPhoto.Text = openFileDialog1.FileName
                pictureBox_bookPhoto.Image = Image.FromFile(txt_bookPhoto.Text)
                pictureBox_bookPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                Dim fs As New FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read)
                Dim bw As New BinaryReader(fs)
                book.bookPhoto = bw.ReadBytes(CInt(fs.Length))
            End If
        Catch
            MessageBox.Show("请选择正确的图片格式", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try
    End Sub

    Private Sub FrmEditBook_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        '查询所有的图书类别
        Dim bookTypeDs As DataSet = BLL.bllBookType.getAllBookType()

        Me.cb_bookType.DataSource = bookTypeDs.Tables(0)
        Me.cb_bookType.DisplayMember = "bookTypeName"
        Me.cb_bookType.ValueMember = "bookTypeId"

        book = BLL.bllBook.getSomeBook(barcode)

        Me.txt_barcode.[ReadOnly] = True

        Me.txt_barcode.Text = book.barcode
        Me.txt_bookName.Text = book.bookName
        Me.cb_bookType.SelectedValue = book.bookType.ToString()
        Me.txt_price.Text = book.price.ToString()
        Me.txt_count.Text = book.count.ToString()
        Me.txt_publish.Text = book.publish
        Me.dtp_publishDate.Value = book.publishDate



        Dim bookPhoto As Byte() = DirectCast(book.bookPhoto, Byte())
        Dim ms As New MemoryStream(bookPhoto)
        pictureBox_bookPhoto.Image = Image.FromStream(ms)


    End Sub
 
End Class
