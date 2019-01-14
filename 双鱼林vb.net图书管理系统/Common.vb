Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports DAL


Public Class Common
    '使用帮助
    Private FILE_NAME As String = Application.StartupPath + "\Regedit"
    Public Sub ShowHelp()
        System.Diagnostics.Process.Start("Notepad.exe", FILE_NAME)
    End Sub
    '关于
    Public Sub ShowAbout()
        Dim about As New Frm关于()
        about.ShowDialog()
    End Sub

    '密码修改
    Public Sub UpdatePassword()
        Dim about As New Frm密码修改()
        about.ShowDialog()
    End Sub

    '离开挂起
    Public Sub KeepLeve()
        Dim about As New FrmAuthPrompt(1)
        about.ShowDialog()
    End Sub

    ''' <summary>
    ''' 判断身份证是否合法
    ''' </summary>
    ''' <param name="str">身份证号码</param>
    ''' <returns>bool</returns>
    Public Function RegexcardID(ByVal str As String) As Boolean
        Dim [error] As Boolean = True
        Dim zzbds As String = "^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$"
        '设置正则表达式 
        Dim m As Match = Regex.Match(str, zzbds)
        '判断并得到结果
        If Not m.Success Then
            '判断如果不符合正则表达式规则设置error为false;
            [error] = False


        End If
        Return [error]
    End Function

    ''' <summary>
    ''' 判断邮箱是否合法
    ''' </summary>
    ''' <param name="str">邮箱号码</param>
    ''' <returns>bool</returns>
    Public Function RegexEmail(ByVal str As String) As Boolean
        Dim [error] As Boolean = True
        Dim zzbds As String = "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        '设置正则表达式 
        Dim m As Match = Regex.Match(str, zzbds)
        '判断并得到结果
        If Not m.Success Then
            '判断如果不符合正则表达式规则设置error为false;
            [error] = False


        End If
        Return [error]
    End Function

    ''' <summary>
    ''' 判断电话号码是否合法
    ''' </summary>
    ''' <param name="str">电话号码</param>
    ''' <returns>bool</returns>
    Public Function RegexPhone(ByVal str As String) As Boolean
        Dim [error] As Boolean = True
        Dim zzbds As String = "^1(3[4-9]|5[012789]|8[78])\d{8}$"
        '设置正则表达式 
        Dim m As Match = Regex.Match(str, zzbds)
        '判断并得到结果
        If Not m.Success Then
            '判断如果不符合正则表达式规则设置error为false;
            [error] = False


        End If
        Return [error]
    End Function


#Region "获得编码    示例为 and，Tcode 选中行的编码，Pcode 选中行的父编码 ，ForderCode，FParentCode 字段名称 Type 1 同级 2 下级 strWhere 条件"
    ''' <summary>
    ''' 获得编码    示例为 and，Tcode 选中行的编码，Pcode 选中行的父编码 ，ForderCode，FParentCode 字段名称 Type 1 同级 2 下级 strWhere 条件
    ''' </summary>
    Public Shared Function GetCode(ByVal Tcode As String, ByVal Pcode As String, ByVal ForderCode As String, ByVal FParentCode As String, ByVal TableName As String, ByVal Type As Integer, _
     ByVal strWhere As String) As String
        Dim strSql As New StringBuilder()
        strSql.Append("select isnull(Max(" & ForderCode & "),0) from " & TableName & " ")
        Dim strCode As String = ""
        If Type = 1 Then
            '添加同级节点
            strCode = Pcode
        Else
            strCode = Tcode
        End If
        '添加下级节点
        strSql.Append(" where " & FParentCode & "='" & strCode & "' and " & strWhere & " ")
        Dim ds As DataSet = DBHelp.DateSet(strSql.ToString())
        If Type = 1 Then
            Dim Ycode As String = ds.Tables(0).Rows(0)(0).ToString()
            Dim Rcode As String = Ycode.Substring(Ycode.Length - 3, 3)
            Dim Lcode As String = Ycode.Substring(0, Ycode.Length - 3)

            Dim Hcode As Integer = Convert.ToInt32(Rcode) + 1

            Tcode = Lcode & Hcode.ToString().PadLeft(3, "0"c)
        Else
            If ds.Tables(0).Rows(0)(0).ToString() = "0" Then
                Tcode = strCode & "001"
            Else
                Dim Ycode As String = ds.Tables(0).Rows(0)(0).ToString()
                Dim Rcode As String = Ycode.Substring(Ycode.Length - 3, 3)
                Dim Lcode As String = Ycode.Substring(0, Ycode.Length - 3)
                Dim Hcode As Integer = Convert.ToInt32(Rcode) + 1
                Tcode = Lcode & Hcode.ToString().PadLeft(3, "0"c)
            End If
        End If
        Return Tcode
    End Function
#End Region
End Class
