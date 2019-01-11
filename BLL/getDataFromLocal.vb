Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class getDataFromLocal
    Public Shared Function getToken() As String
        Dim tmp As String
        Dim fs As FileStream = New FileStream("./support.dat", FileMode.Open)
        Dim bf As BinaryFormatter = New BinaryFormatter()
        tmp = bf.Deserialize(fs)
        fs.Close()
        Return tmp
    End Function
End Class
