Imports System.Configuration

Public Class FrmRules
    Private db As New Model.Transaction
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FrmRules_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupBox3.Visible = False
        GroupBox4.Visible = False
        TextBox1.Text = Rules.normal_level
        TextBox2.Text = Rules.meidum_level
        TextBox3.Text = Rules.top_level
        TextBox4.Text = Rules.normal_discount
        TextBox5.Text = Rules.medium_discount
        TextBox6.Text = Rules.top_discount
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox3.Visible = True
        Else
            GroupBox3.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked = True AndAlso CheckBox2.Checked = True Then
            GroupBox4.Visible = True
        Else
            GroupBox4.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" OrElse Not IsNumeric(TextBox1.Text.Trim) Then
            MsgBox("输入不得为空且应是数字")
            TextBox1.Focus()
            Return
        End If
        If TextBox2.Text.Trim = "" OrElse Not IsNumeric(TextBox2.Text.Trim) Then
            MsgBox("输入不得为空且应是数字")
            TextBox2.Focus()
            Return
        End If
        If TextBox3.Text.Trim = "" OrElse Not IsNumeric(TextBox3.Text.Trim) Then
            MsgBox("输入不得为空且应是数字")
            TextBox3.Focus()
            Return
        End If
        If TextBox4.Text.Trim = "" Or Not IsNumeric(TextBox4.Text.Trim) OrElse Decimal.Parse(TextBox4.Text.Trim) >= 10 Then
            MsgBox("输入不得为空且应是数字,折扣应小于10")
            TextBox4.Focus()
            Return
        End If
        If TextBox5.Text.Trim = "" Or Not IsNumeric(TextBox5.Text.Trim) OrElse Decimal.Parse(TextBox5.Text.Trim) >= 10 Then
            MsgBox("输入不得为空且应是数字,折扣应小于10")
            TextBox5.Focus()
            Return
        End If
        If TextBox6.Text.Trim = "" Or Not IsNumeric(TextBox6.Text.Trim) OrElse Decimal.Parse(TextBox6.Text.Trim) >= 10 Then
            MsgBox("输入不得为空且应是数字,折扣应小于10")
            TextBox6.Focus()
            Return
        End If

        Rules.normal_level = Integer.Parse(TextBox1.Text.Trim)
        Rules.meidum_level = Integer.Parse(TextBox2.Text.Trim)
        Rules.top_level = Integer.Parse（TextBox3.Text.Trim）
        Rules.normal_discount = Math.Round(Double.Parse(TextBox4.Text.Trim), 2)
        Rules.medium_discount = Math.Round(Double.Parse(TextBox5.Text.Trim), 2)
        Rules.top_discount = Math.Round(Double.Parse(TextBox6.Text.Trim), 2)
        db.MemberType.Where(Function(x) x.name = "高级").First.discount = Rules.top_discount
        db.MemberType.Where(Function(x) x.name = "中等").First.discount = Rules.medium_discount
        db.MemberType.Where(Function(x) x.name = "普通").First.discount = Rules.normal_discount
        db.SaveChanges()
        MsgBox("修改完成")

    End Sub
    'Private Sub DealXML()
    '    Dim myDs As New DataSet
    '    myDs.ReadXml(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
    '    TBCopy.Text = myDs.Tables(1).Rows(0)(1)
    '    TBCompany.Text = myDs.Tables(1).Rows(1)(1)
    '    TBComUrl.Text = myDs.Tables(1).Rows(2)(1)
    '    ------------------------------------------
    '    myDs.Tables(1).Rows(0)(1) = TBCopy.Text
    '    myDs.Tables(1).Rows(1)(1) = TBCompany.Text
    '    myDs.Tables(1).Rows(2)(1) = TBComUrl.Text
    '    ------------------------------------------
    '    myDs.AcceptChanges()
    '    myDs.WriteXml(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
    '    myDs.Clear()
    '    myDs.Dispose()
    'End Sub
End Class