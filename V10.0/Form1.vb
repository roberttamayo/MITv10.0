Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Sucursales = MySQL.SelectQuery("SELECT * FROM sucursales where estatus_sucursal = 1")
        If Sucursales IsNot Nothing Then
            While Sucursales.Read()
                CBSucursales.Items.Add(Sucursales.Item("nombre_sucursal"))
            End While
        End If
        MySQL.NextResult()
        MaximizeBox = False
    End Sub

    Private Sub BotonAceptar_Click(sender As Object, e As EventArgs) Handles BotonAceptar.Click

        If CBSucursales.SelectedItem IsNot Nothing Then
            Dim user = MySQL.NumRows("SELECT u.* FROM usuarios u inner join sucursales s  on u.id_sucursal_FK = s.id_sucursal inner join rol_usuarios r on u.id_rol_usuarios_FK = r.id_rol_usuarios " +
                $"where u.nick_usuarios = '{TBUserNick.Text()}' and u.contra_usuarios = '{TBPass.Text()}' and u.estatus = 1 and s.nombre_sucursal = '{CBSucursales.SelectedItem}'")
            If user = 1 Then
                'tenemos sesion iniciada
                Dim userInfo = MySQL.SelectQuery("SELECT * FROM usuarios u inner join sucursales s  on u.id_sucursal_FK = s.id_sucursal inner join rol_usuarios r on u.id_rol_usuarios_FK = r.id_rol_usuarios " +
                $"where u.nick_usuarios = '{TBUserNick.Text()}' and u.contra_usuarios = '{TBPass.Text()}' and u.estatus = 1  and s.nombre_sucursal = '{CBSucursales.SelectedItem}'")
                userInfo.Read()
                'data user sesion
                SESION.IdUser = userInfo.Item("id_usuarios")
                SESION.NombreUsuario = userInfo.Item("nombre_usuarios")
                SESION.EmailUsuario = userInfo.Item("email_usuarios")
                SESION.IdSucursal = userInfo.Item("id_sucursal")
                SESION.NombreSucursal = userInfo.Item("nombre_sucursal")
                SESION.IdRol = userInfo.Item("id_rol_usuarios")
                SESION.NombreRol = userInfo.Item("nombre_rol_usuarios")
                SESION.ContenidoRol = userInfo.Item("contenido_rol_usuarios")
                MySQL.NextResult()
                Escritorio.Show()
                Me.Hide()
            Else
                'no iniciamos sesion
                Alertas.Alerta("Usuario y contraseña no son correctos", "El usuario y contraseña proporcionados no son correctos por favor verifiquelos")
            End If
        Else
            Alertas.Alerta("Se debe seleccionar una sucursal", "No has seleccionado ninguna sucursal, es imposible continuar, selecciona antes una sucursal")
        End If

    End Sub

    Private Sub BotonCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
        Close()
    End Sub
End Class
