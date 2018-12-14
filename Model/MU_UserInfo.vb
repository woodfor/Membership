Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Public Class MU_UserInfo
    ''' <summary>
    ''' U_Id
    ''' </summary>		
    Private _u_id As Integer
    Public Property U_Id() As Integer
        Get
            Return _u_id
        End Get
        Set(ByVal value As Integer)
            _u_id = value
        End Set
    End Property
    ''' <summary>
    ''' U_Name
    ''' </summary>		
    Private _u_name As String
    Public Property U_Name() As String
        Get
            Return _u_name
        End Get
        Set(ByVal value As String)
            _u_name = value
        End Set
    End Property
    ''' <summary>
    ''' U_RelName
    ''' </summary>		
    Private _u_relname As String
    Public Property U_RelName() As String
        Get
            Return _u_relname
        End Get
        Set(ByVal value As String)
            _u_relname = value
        End Set
    End Property
    ''' <summary>
    ''' U_Sex
    ''' </summary>		
    Private _u_sex As Boolean
    Public Property U_Sex() As Boolean
        Get
            Return _u_sex
        End Get
        Set(ByVal value As Boolean)
            _u_sex = value
        End Set
    End Property
    ''' <summary>
    ''' U_PassWord
    ''' </summary>		
    Private _u_password As String
    Public Property U_PassWord() As String
        Get
            Return _u_password
        End Get
        Set(ByVal value As String)
            _u_password = value
        End Set
    End Property
    ''' <summary>
    ''' U_Birthday
    ''' </summary>		
    Private _u_birthday As DateTime
    Public Property U_Birthday() As DateTime
        Get
            Return _u_birthday
        End Get
        Set(ByVal value As DateTime)
            _u_birthday = value
        End Set
    End Property
    ''' <summary>
    ''' U_PsdType
    ''' </summary>		
    Private _u_psdtype As Integer
    Public Property U_PsdType() As Integer
        Get
            Return _u_psdtype
        End Get
        Set(ByVal value As Integer)
            _u_psdtype = value
        End Set
    End Property
    ''' <summary>
    ''' U_PsdAnswer
    ''' </summary>		
    Private _u_psdanswer As String
    Public Property U_PsdAnswer() As String
        Get
            Return _u_psdanswer
        End Get
        Set(ByVal value As String)
            _u_psdanswer = value
        End Set
    End Property
    ''' <summary>
    ''' U_IdCard
    ''' </summary>		
    Private _u_idcard As String
    Public Property U_IdCard() As String
        Get
            Return _u_idcard
        End Get
        Set(ByVal value As String)
            _u_idcard = value
        End Set
    End Property
    ''' <summary>
    ''' U_NativePlace
    ''' </summary>		
    Private _u_nativeplace As String
    Public Property U_NativePlace() As String
        Get
            Return _u_nativeplace
        End Get
        Set(ByVal value As String)
            _u_nativeplace = value
        End Set
    End Property
    ''' <summary>
    ''' U_Address
    ''' </summary>		
    Private _u_address As String
    Public Property U_Address() As String
        Get
            Return _u_address
        End Get
        Set(ByVal value As String)
            _u_address = value
        End Set
    End Property
    ''' <summary>
    ''' U_Telephone
    ''' </summary>		
    Private _u_telephone As String
    Public Property U_Telephone() As String
        Get
            Return _u_telephone
        End Get
        Set(ByVal value As String)
            _u_telephone = value
        End Set
    End Property
    ''' <summary>
    ''' U_Email
    ''' </summary>		
    Private _u_email As String
    Public Property U_Email() As String
        Get
            Return _u_email
        End Get
        Set(ByVal value As String)
            _u_email = value
        End Set
    End Property
    ''' <summary>
    ''' U_PostalId
    ''' </summary>		
    Private _u_postalid As String
    Public Property U_PostalId() As String
        Get
            Return _u_postalid
        End Get
        Set(ByVal value As String)
            _u_postalid = value
        End Set
    End Property
    ''' <summary>
    ''' U_QQ
    ''' </summary>		
    Private _u_qq As String
    Public Property U_QQ() As String
        Get
            Return _u_qq
        End Get
        Set(ByVal value As String)
            _u_qq = value
        End Set
    End Property
    ''' <summary>
    ''' U_Position
    ''' </summary>		
    Private _u_position As String
    Public Property U_Position() As String
        Get
            Return _u_position
        End Get
        Set(ByVal value As String)
            _u_position = value
        End Set
    End Property
    ''' <summary>
    ''' U_Reamrk
    ''' </summary>		
    Private _u_reamrk As String
    Public Property U_Reamrk() As String
        Get
            Return _u_reamrk
        End Get
        Set(ByVal value As String)
            _u_reamrk = value
        End Set
    End Property
    ''' <summary>
    ''' U_LoginTime
    ''' </summary>		
    Private _u_logintime As DateTime
    Public Property U_LoginTime() As DateTime
        Get
            Return _u_logintime
        End Get
        Set(ByVal value As DateTime)
            _u_logintime = value
        End Set
    End Property
    ''' <summary>
    ''' U_RoleType
    ''' </summary>		
    Private _u_roletype As Integer
    Public Property U_RoleType() As Integer
        Get
            Return _u_roletype
        End Get
        Set(ByVal value As Integer)
            _u_roletype = value
        End Set
    End Property
    ''' <summary>
    ''' U_Image
    ''' </summary>		
    Private _u_image As Byte()
    Public Property U_Image() As Byte()
        Get
            Return _u_image
        End Get
        Set(ByVal value As Byte())
            _u_image = value
        End Set
    End Property
End Class
