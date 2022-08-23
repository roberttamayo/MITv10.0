Public Class MarcasAdministracion
    Sub ResetCampos()
        'regresamos todos los campos a su estado natural
        TBFecha.Text = ""
        TBHora.Text = ""
        TBNombre.Text = ""
        CTEstatus.Checked = True
    End Sub
    Sub LlenarMarcasDGV()
        'eliminamos el contenido de las filas del DataGridView
        DGVMarcas.Rows.Clear()
        Dim marcas = MySQL.SelectQuery($"select * from marcas where id_sucursal_FK = {SESION.IdSucursal}")
        While marcas.Read()
            DGVMarcas.Rows.Add(marcas.Item("id_marcas"), marcas.Item("nombre_marcas"), If(marcas.Item("estatus_marcas") = 1, "Activo", "Eliminado"), marcas.Item("fecha_marcas"), marcas.Item("hora_marcas"))
        End While
        MySQL.NextResult()
    End Sub

    Private Sub MarcasAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarMarcasDGV()
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Close()
    End Sub

    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        If TBNombre.Text.Length < 4 Then
            Alertas.Alerta("Los Campos estan vacios o son nulos", "El nombre de la marca no debe estar vacio y debe de tener por lo menos 4 letras")
        Else
            If MySQL.NumRows($"SELECT * FROM marcas where id_sucursal_FK = {SESION.IdSucursal} and nombre_marcas like '{TBNombre.Text}'") > 0 Then
                'si la busqueda tiene uno o mas resultados el nombre esta duplicado
                Alertas.Alerta("Al parecer los datos estan duplicados", "No e posible continuar ya que el nombre de la marca ya esta en uso o existe otra marca con ese nombre")
            Else
                'si no hay amrcas duplicadas insertamos la marca en la abse de datos
                If MySQL.InsertQuery("INSERT INTO `marcas` (`nombre_marcas`, `estatus_marcas`, `fecha_marcas`, `hora_marcas`, `id_sucursal_FK`) VALUES " +
                                     $"('{TBNombre.Text}', '{If(CTEstatus.Checked, "1", "0")}', '{MySQL.FechaMySQL()}', '{MySQL.HoraMySQL()}', '{SESION.IdSucursal}');") Then
                    'si se inserto correctamente mostramos un mensaje de exito y llenamos el DataGridView
                    Alertas.Check("Marca insertada correctamente", "Se ha insertado correctamente la marca")
                    LlenarMarcasDGV()
                    ResetCampos()
                Else
                    'si no se inserto correctamente mostramos un mensaje de error
                    Alertas.Bug("Error al ratar de insertar la marca", "No se ha podido insertar la marca, ocurrio un error en el servidor")
                End If
            End If
        End If
    End Sub
End Class