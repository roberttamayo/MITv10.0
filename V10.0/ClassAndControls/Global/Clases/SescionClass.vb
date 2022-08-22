Public Class SescionClass
    'user data
    Private _IdUser As Integer
    Private _NombreUsuario As String
    Private _EmailUsuario As String

    'sucursal data
    Private _IdSucursal As Integer
    Private _NombreSucursal As String

    'rol usuario
    Private _IdRol As Integer
    Private _NombreRol As String
    Private _ContenidoRol As Char

    Public Overrides Function ToString() As String
        Return Me.NombreUsuario
    End Function
#Region "Propiedades"
    Public Property IdUser As Integer
        Get
            Return _IdUser
        End Get
        Set(value As Integer)
            _IdUser = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _NombreUsuario
        End Get
        Set(value As String)
            _NombreUsuario = value
        End Set
    End Property

    Public Property EmailUsuario As String
        Get
            Return _EmailUsuario
        End Get
        Set(value As String)
            _EmailUsuario = value
        End Set
    End Property

    Public Property IdSucursal As Integer
        Get
            Return _IdSucursal
        End Get
        Set(value As Integer)
            _IdSucursal = value
        End Set
    End Property

    Public Property NombreSucursal As String
        Get
            Return _NombreSucursal
        End Get
        Set(value As String)
            _NombreSucursal = value
        End Set
    End Property

    Public Property IdRol As Integer
        Get
            Return _IdRol
        End Get
        Set(value As Integer)
            _IdRol = value
        End Set
    End Property

    Public Property NombreRol As String
        Get
            Return _NombreRol
        End Get
        Set(value As String)
            _NombreRol = value
        End Set
    End Property

    Public Property ContenidoRol As Char
        Get
            Return _ContenidoRol
        End Get
        Set(value As Char)
            _ContenidoRol = value
        End Set
    End Property
#End Region
End Class
