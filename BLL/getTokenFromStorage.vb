Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class getTokenFromStorage
    Public Shared Function getLocalToken() As String
        Dim flag = "Yes"

        Try
            Dim fs As FileStream = New FileStream("./support.dat", FileMode.Open)
            Dim bf As BinaryFormatter = New BinaryFormatter()
            flag = bf.Deserialize(fs)
            fs.Close()
        Catch
            Return "No"
        End Try

        Return flag
    End Function
End Class
