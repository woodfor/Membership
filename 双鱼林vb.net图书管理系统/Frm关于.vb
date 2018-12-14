Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms


Partial Public Class Frm关于
    Inherits Form
    Public Sub New()

        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Me.Close()
    End Sub

    Private Sub Frm关于_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim appSettings As System.Configuration.AppSettingsSection = CType(config.GetSection("appSettings"), System.Configuration.AppSettingsSection)

        Dim version As String = appSettings.Settings("version").Value
        '窗口标题
        Me.label1.Text = version

        Dim AboutImage As String = "../../pic/" & appSettings.Settings("AboutImage").Value
        '关于图片
        'AboutImage += Application.StartupPath + AboutImage;
        Me.pictureBox1.BackgroundImage = Image.FromFile(AboutImage)

    End Sub
End Class
