Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text

Public Class GetToken
    Public Shared Function GetToken() As Boolean
        Try
            Dim aToken As String = PostData("https://www.miditech.cn/appname/static/token/token1", "")
            Dim ht As Hashtable = New Hashtable()
            ht.Add("Token", aToken)
            Dim fs As FileStream = New FileStream("./support.dat", FileMode.Create)
            Dim bf As BinaryFormatter = New BinaryFormatter()
            bf.Serialize(fs, aToken)
            fs.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function PostData(ByVal url As String, ByVal data As String) As String

        ServicePointManager.Expect100Continue = False
        Dim request As HttpWebRequest = WebRequest.Create(url)
        '//Post请求方式
        request.Method = "POST"

        '内容类型
        request.ContentType = "application/x-www-form-urlencoded"
        '将URL编码后的字符串转化为字节
        Dim encoding As New UTF8Encoding()
        Dim bys As Byte() = encoding.GetBytes(data)
        '设置请求的 ContentLength 
        request.ContentLength = bys.Length
        '获得请 求流
        Dim newStream As Stream = request.GetRequestStream()
        newStream.Write(bys, 0, bys.Length)
        newStream.Close()
        '获得响应流
        Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
        Return sr.ReadToEnd
    End Function
End Class
