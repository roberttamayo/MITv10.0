Public Class DepartamentosAdministracion
    Private Sub DepartamentosAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDepartamentos()
    End Sub
    Sub CargarDepartamentos()
        DGVDepartamentos.Rows.Clear()
        Dim departamentos = MySQL.SelectQuery($"SELECT * FROM departamentos where id_sucursal_FK = {SESION.IdSucursal}")
        While departamentos.Read()
            DGVDepartamentos.Rows.Add(departamentos.Item("id_departamentos"), departamentos.Item("nombre_departamentos"), departamentos.Item("descripcion_departamentos"), If(departamentos.Item("estatus_departamentos") = 1, "Activo", "Eliminado"))
        End While
        MySQL.NextResult()
    End Sub
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If TBNombre.Text.Length < 4 Or TBDescripcion.Text.Length < 4 Then
            Alertas.Alerta("Campos vacios o muy cortos", "Los campos estan vacios o muy cortos, tienen que tener al menos 4 caracteres")
        Else
            If MySQL.NumRows($"SELECT * FROM departamentos where id_sucursal_FK = {SESION.IdSucursal} and nombre_departamentos like '{TBNombre.Text()}'") > 0 Then
                Alertas.Alerta("Datos duplicados", "Al parecer ya hay un departamento con el mismo nombre")
            Else
                If MySQL.InsertQuery("INSERT INTO `departamentos` (`nombre_departamentos`, `descripcion_departamentos`, `estatus_departamentos`, `id_sucursal_FK`)" +
                                     $" VALUES ('{TBNombre.Text()}', '{TBDescripcion.Text()}', '{If(CTEstatus.Checked, "1", "0")}', '{SESION.IdSucursal}');") Then
                    Alertas.Check("Departamento agregado correctamente", "El departamento fue agregado correctamente")
                    CargarDepartamentos()
                    ResetCampos()
                Else
                    'alerta por error
                End If
            End If
        End If
    End Sub
    Sub ResetCampos()
        TBDescripcion.Text = ""
        TBNombre.Text = ""
        CTEstatus.Checked = True
        LIDDep.Text = ""
    End Sub
    Private Sub DGVDepartamentos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDepartamentos.CellDoubleClick
        TBNombre.Text = DGVDepartamentos.Rows(e.RowIndex).Cells(1).Value
        TBDescripcion.Text = DGVDepartamentos.Rows(e.RowIndex).Cells(2).Value
        CTEstatus.Checked = DGVDepartamentos.Rows(e.RowIndex).Cells(3).Value = "Activo"
        LIDDep.Text = DGVDepartamentos.Rows(e.RowIndex).Cells(0).Value
    End Sub
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Close()
    End Sub
    Private Sub BActualizar_Click(sender As Object, e As EventArgs) Handles BActualizar.Click
        If LIDDep.Text.Length < 1 Then
            Alertas.Alerta("Se debe seleccionar un departamento primero", "Al parecer no has seleccionado ningundepartamento doble clic en alguno de la tabla para hacerlo")
        Else
            If TBNombre.Text.Length < 4 Or TBDescripcion.Text.Length < 4 Then
                Alertas.Alerta("Campos vacios o muy cortos", "Los campos estan vacios o muy cortos, tienen que tener al menos 4 caracteres")
            Else
                If MySQL.NumRows($"SELECT * FROM departamentos where id_sucursal_FK = {SESION.IdSucursal} and nombre_departamentos like '{TBNombre.Text()}' and id_departamentos != {LIDDep.Text()}") > 0 Then
                    Alertas.Alerta("Datos duplicados", "Al parecer ya hay un departamento con el mismo nombre")
                Else
                    If MySQL.UpdateQuery($"UPDATE `departamentos` SET `nombre_departamentos` = '{TBNombre.Text()}', `descripcion_departamentos` = '{TBDescripcion.Text()}', `estatus_departamentos` = '{If(CTEstatus.Checked, "1", "0")}' WHERE (`id_departamentos` = '{LIDDep.Text()}');") Then
                        Alertas.Check("Departamento actualizado correctamente", "El departamento fue actualziado correctamente")
                        CargarDepartamentos()
                        ResetCampos()
                    Else
                        'alerta por si algo sale mal
                        Alertas.Alerta("Error al actualizar el departamento", "Al parecer algo salio mal tratando de actualziar el departamento, intenta de nuevo")
                    End If
                End If
            End If
        End If
    End Sub
End Class