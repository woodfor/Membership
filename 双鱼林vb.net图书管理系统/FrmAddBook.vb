Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Imports Model


Partial Public Class FrmAddBook
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private book As New Book()

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

    Private Sub Btn_Add_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Add.Click
        If Me.txt_barcode.Text = "" Then
            MessageBox.Show("条形码输入不能为空!")
            Me.txt_barcode.Focus()
            Return
        End If
        book.barcode = Me.txt_barcode.Text
        '图书条形码
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



        If BLL.bllBook.AddBook(book) Then
            MessageBox.Show("图书添加成功!")
        Else
            MessageBox.Show("图书添加失败!")
        End If

        Me.Close()


    End Sub



    Private Sub FrmAddBook_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        '查询所有的图书类别
        Dim bookTypeDs As DataSet = BLL.bllBookType.getAllBookType()

        Me.cb_bookType.DataSource = bookTypeDs.Tables(0)
        Me.cb_bookType.DisplayMember = "bookTypeName"
        Me.cb_bookType.ValueMember = "bookTypeId"
        '
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


End Class
