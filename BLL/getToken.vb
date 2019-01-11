Imports System.IO
Imports System.Net
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text

Public Class GetToken
    Public Shared Function GetToken() As Boolean
        Try
            Dim aToken As String = httpCon.PostData("http://129.204.173.150/appname/static/token/token1", "")
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


End Class
