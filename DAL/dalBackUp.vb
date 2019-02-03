Imports System.Data.SqlClient
Imports System.IO

Public Class dalBackUp
    Public Shared Function backup() As Boolean
        Dim localAppData As String = Environment.GetFolderPath(
            Environment.SpecialFolder.LocalApplicationData)
        Dim userFilePath As String =
              Path.Combine(localAppData, "ChengWeiTech")

        If (Not Directory.Exists(userFilePath)) Then
            Directory.CreateDirectory(userFilePath)
        End If
        'Dim destFilePath As String =
        '      Path.Combine(userFilePath, "membership.BAK")
        'Dim constr As String = System.Configuration.ConfigurationManager.ConnectionStrings("Transaction").ConnectionString
        'Dim Builder = New SqlConnectionStringBuilder(constr)
        'Builder.InitialCatalog = "MembershipDB"
        Dim backupFileName = String.Format("{0}{1}_{2}.mdf", userFilePath + "\", "MembershipSystem", Date.Now.ToShortDateString)
        'Dim query = String.Format("BACKUP DATABASE {0} TO DISK='{1}'", "MembershipSystem", backupFileName)
        Dim destFilePath As String = My.Application.Info.DirectoryPath + "\BookSystemDB.mdf"

        Dim objReader As New System.IO.StreamReader(destFilePath)
        objReader.Close()
        Dim objWriter As New System.IO.StreamWriter(My.Application.Info.DirectoryPath + "\tmp.mdf")
        File.Copy(My.Application.Info.DirectoryPath + "\tmp.mdf", backupFileName, True)
        'MsgBox(query)
        'If DBHelp.ExecuteNonQuery(query) > 0 Then
        '    Return True
        'End If
        Return True
    End Function
End Class
