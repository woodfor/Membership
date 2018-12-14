Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Model
    Class MP_PasswordType
        ''' <summary>
        ''' P_Id
        ''' </summary>		
        Private _p_id As Integer
        Public Property P_Id() As Integer
            Get
                Return _p_id
            End Get
            Set(ByVal value As Integer)
                _p_id = value
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
    End Class
End Namespace