Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace LoginFrame
    NotInheritable Class Program
        Private Sub New()
        End Sub
        ''' <summary>
        ''' 应用程序的主入口点。
        ''' </summary>
        <STAThread()> _
        Private Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Landing())
        End Sub
    End Class
End Namespace