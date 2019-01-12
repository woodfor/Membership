Imports System.ComponentModel

Public Class FrmStore
    Private tmpID As String
    Private store As Model.Store
    Public Sub New(ByVal id As String)
        tmpID = id
        Try
            store = DAL.dalStore.getSomeStore(id)
            InitializeComponent()
            '设置最大字数
            Text_name.MaxLength = 10
            Text_city.MaxLength = 10
            Text_admin_name.MaxLength = 10
            Text_admin_phone.MaxLength = 19
            Text_street.MaxLength = 50
            Text_phone.MaxLength = 19

            Text_name.Text = store.store_name
            Text_city.Text = store.city
            Text_admin_name.Text = store.admin_name
            Text_admin_phone.Text = store.admin_phone
            Text_street.Text = store.street
            Text_phone.Text = store.store_phone


        Catch
            MsgBox("系统数据库损坏")
            Me.Close()
        End Try
    End Sub

    Private Sub Button_edit_Click(sender As Object, e As EventArgs) Handles Button_edit.Click
        If Text_city.Text.Trim = "" Then
            MsgBox("城市不能为空")
            Me.Text_city.Focus()
            Return
        End If
        If Text_name.Text.Trim = "" Then
            MsgBox("店名不能为空")
            Me.Text_name.Focus()
            Return
        End If
        If Text_admin_name.Text.Trim = "" Then
            MsgBox("管理员姓名不能为空")
            Me.Text_admin_name.Focus()
            Return
        End If

        If Me.Text_admin_phone.Text.Trim = "" Then
            MsgBox("管理员电话不能为空")
            Me.Text_admin_phone.Focus()
            Return
        ElseIf Information.IsNumeric(Text_admin_phone.Text.Trim) = False Then
            MsgBox("管理员电话得全是数字")
            Me.Text_admin_phone.Focus()
            Return
        End If

        If Me.Text_street.Text.Trim = "" Then
            MsgBox("街道不能为空")
            Me.Text_street.Focus()
            Return
        End If

        If Me.Text_phone.Text.Trim = "" Then
            MsgBox("店内电话不能为空")
            Me.Text_phone.Focus()
            Return
        ElseIf Information.IsNumeric(Text_phone.Text.Trim) = False Then
            MsgBox("店内电话得全是数字")
            Me.Text_phone.Focus()
            Return
        End If

        Dim tmpStore As New Model.Store
        Try
            tmpStore.store_id = Integer.Parse(tmpID)
            tmpStore.store_name = Me.Text_name.Text
            tmpStore.store_phone = Me.Text_phone.Text
            tmpStore.city = Me.Text_city.Text
            tmpStore.street = Me.Text_street.Text
            tmpStore.admin_name = Me.Text_admin_name.Text
            tmpStore.admin_phone = Me.Text_admin_phone.Text

            DAL.dalStore.EditStore(tmpStore)
            MsgBox("修改成功！")
        Catch ex As Exception
            MsgBox("数据库文件损坏，请联系客服")
            Return
        End Try



    End Sub

    Private Sub FrmStore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class