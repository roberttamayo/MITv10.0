Public Class SucursalesAdministracion
    Private Sub SucursalesAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        CargarSucursales()
    End Sub
    Sub CargarSucursales()
        DGVSucursales.Rows.Clear()
        Dim sucursales = MySQL.SelectQuery("select * from sucursales")
        While sucursales.Read()
            Dim estatus As String = If(sucursales.Item("estatus_sucursal") = 1, "Activo", "Eliminada")
            Dim fecha As Date = sucursales.Item("fecha_sucursal")
            Dim hora As TimeSpan = sucursales.Item("hora_sucursal")
            DGVSucursales.Rows.Add(sucursales.Item("id_sucursal"), sucursales.Item("nombre_sucursal"), sucursales.Item("descripcion_sucursal"), estatus, fecha.ToString("yyyy-MM-dd:"), hora.ToString())
        End While
        MySQL.NextResult()
    End Sub
    Sub ResetCampos()
        LabelIDSucursal.Text = ""
        TBNombre.Text = ""
        TBDesc.Text = ""
        TBFecha.Text = ""
        TBHora.Text = ""
        EstatusCyToggle.Checked = True
    End Sub
    'boton agregar
    Private Sub CyButtonAgregar_Click(sender As Object, e As EventArgs) Handles CyButtonAgregar.Click
        If TBNombre.Text.Length < 4 Or TBDesc.Text.Length < 8 Then
            Alertas.Alerta("Campos muy cortos o vacíos", "Los campos introducidos en nombre y/o descripción son muy cortos o están vacíos")
        Else
            If MySQL.NumRows($"select * from sucursales where nombre_sucursal like '{TBNombre.Text}'") > 0 Then
                Alertas.Alerta("Datos duplicados!", "El nombre de la sucursal a ingresar ya se encuentra en uso o dada de alta, verifica que no este desactivada, recuerda que siempre puedes volver a activar las sucursales desde el panel de administración > sucursales")
            Else
                If MySQL.InsertQuery("INSERT INTO `sucursales` (`nombre_sucursal`, `descripcion_sucursal`, `estatus_sucursal`, `fecha_sucursal`, `hora_sucursal`)" +
                                   $"VALUES ('{TBNombre.Text}', '{TBDesc.Text}', '{If(EstatusCyToggle.Checked, "1", "0")}', '{MySQL.FechaMySQL()}', '{MySQL.HoraMySQL()}');") Then
                    'creamos los roles para esta sucursal
                    Dim idsucursalagregada = MySQL.SelectQuery($"select * from sucursales where nombre_sucursal= '{TBNombre.Text}'")
                    idsucursalagregada.Read()
                    Dim IDTemporal = idsucursalagregada.Item("id_sucursal")
                    MySQL.NextResult()
                    If MySQL.InsertQuery("INSERT INTO `rol_usuarios` (`nombre_rol_usuarios`, `descripcion_rol_usuarios`, `contenido_rol_usuarios`, `estatus_rol_usuarios`, `fecha_rol_usuarios`, `hora_rol_usuarios`, `id_sucursal_FK`)" +
                                      $"VALUES ('Administrador', 'Administrador de sistema', 'a', '1', '{MySQL.FechaMySQL()}', '{MySQL.HoraMySQL()}', '{IDTemporal}');" +
                                       "INSERT INTO `rol_usuarios` (`nombre_rol_usuarios`, `descripcion_rol_usuarios`, `contenido_rol_usuarios`, `estatus_rol_usuarios`, `fecha_rol_usuarios`, `hora_rol_usuarios`, `id_sucursal_FK`)" +
                                      $"VALUES ('Vendedor', 'Vendedor de punto de venta', 'v', '1', '{MySQL.FechaMySQL()}', '{MySQL.HoraMySQL()}', '{IDTemporal}');" +
                                       "INSERT INTO `rol_usuarios` (`nombre_rol_usuarios`, `descripcion_rol_usuarios`, `contenido_rol_usuarios`, `estatus_rol_usuarios`, `fecha_rol_usuarios`, `hora_rol_usuarios`, `id_sucursal_FK`)" +
                                      $"VALUES ('Supervisor', 'Supervisor, da acceso a nivel intermedio de sistema', 's', '1', '{MySQL.FechaMySQL()}', '{MySQL.HoraMySQL()}', '{IDTemporal}');") Then

                        'creamos el usuario administrador para esta sucursal
                        Dim idrol = MySQL.SelectQuery($"select * from rol_usuarios where nombre_rol_usuarios like 'Administrador' and id_sucursal_FK = {IDTemporal}")
                        idrol.Read()
                        Dim IDRolTemporal = idrol.Item("id_rol_usuarios")
                        MySQL.NextResult()
                        If MySQL.InsertQuery($"INSERT INTO `mit`.`usuarios` (`nombre_usuarios`, `apellidos_usuarios`, `nick_usuarios`, `contra_usuarios`, `telefono_usuarios`, `email_usuarios`, `estatus`, `fecha_c_usuarios`, `fecha_m_usaurios`, `hora_c_usuarios`, `hora_m_usuarios`, `id_sucursal_FK`, `id_rol_usuarios_FK`)" +
                                             $"VALUES ('Administrador', 'Administrador', 'root', 'admin', '4437160182', 'robert-cyby@hotmail.com', '1', '{MySQL.FechaMySQL()}', '{MySQL.FechaMySQL()}', '{MySQL.HoraMySQL()}', '{MySQL.HoraMySQL()}', '{IDTemporal}', '{IDRolTemporal}');") Then
                        Else
                            Alertas.Bug("Error!", "No se pudo agregar el usuario administrador")
                        End If

                        Alertas.Check("Sucursal Agregada correctamente", "La sucursal ha sido agregada correctamente y ya está disponible para su uso")
                        CargarSucursales() 'actualizamos la tabla
                        ResetCampos() 'restauramos valores de textbox y datos
                    End If
                Else
                    Alertas.Bug("Ocurrió un error", "Ocurrió un error al tratar de insertar la sucursal por favor consulta al administrador de sistema")
                End If
            End If
        End If
    End Sub
    'al dar doble clic en una celda
    Private Sub DGVSucursales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSucursales.CellDoubleClick
        'colocamos la informacion en los campos
        LabelIDSucursal.Text = DGVSucursales.Rows(e.RowIndex).Cells(0).Value()
        TBNombre.Text = DGVSucursales.Rows(e.RowIndex).Cells(1).Value()
        TBDesc.Text = DGVSucursales.Rows(e.RowIndex).Cells(2).Value()
        EstatusCyToggle.Checked = DGVSucursales.Rows(e.RowIndex).Cells(3).Value() = "Activo"
        TBFecha.Text = DGVSucursales.Rows(e.RowIndex).Cells(4).Value()
        TBHora.Text = DGVSucursales.Rows(e.RowIndex).Cells(5).Value()
    End Sub
    'al dar clic en boton actualizar
    Private Sub CyButtonActualizar_Click(sender As Object, e As EventArgs) Handles CyButtonActualizar.Click
        Dim query = $"UPDATE `sucursales` SET `nombre_sucursal` = '{TBNombre.Text()}', `descripcion_sucursal` = '{TBDesc.Text()}', `estatus_sucursal` = '{If(EstatusCyToggle.Checked, "1", "0")}' WHERE (`id_sucursal` = '{LabelIDSucursal.Text()}');"
        'revisemos que no estan campos vacios
        If TBNombre.Text.Length < 4 Or TBDesc.Text.Length < 8 Then
            Alertas.Alerta("Campos muy cortos o vacíos", "Los campos introducidos en nombre y/o descripción son muy cortos o están vacíos")
        Else
            'revisamos que los datos no esten duplicados
            If MySQL.NumRows($"SELECT * FROM sucursales where id_sucursal <> {LabelIDSucursal.Text()} and nombre_sucursal like '{TBNombre.Text()}'") > 0 Then
                Alertas.Alerta("Datos duplicados!", "El nombre de la sucursal a ingresar ya se encuentra en uso o dada de alta, verifica que no este desactivada, recuerda que siempre puedes volver a activar las sucursales desde el panel de administración > sucursales")
            Else
                'si no esta duplicados los campos actalizamos
                If MySQL.UpdateQuery(query) Then
                    Alertas.Check("Sucursal acttualizada correctamente", "La sucursal se ha actualizado correctamente")
                    CargarSucursales() 'actualizamos la tabla
                    ResetCampos() 'restauramos valores de textbox y datos
                Else
                    Alertas.Bug("Ocurrió un error", "Ocurrió un error al tratar de actualizar la sucursal por favor consulta al administrador de sistema")
                End If
            End If
        End If
    End Sub
    Private Sub CyButtonCancelar_Click(sender As Object, e As EventArgs) Handles CyButtonCancelar.Click
        Close() 'cerramos formulario
    End Sub
End Class