Public Class Escritorio
    Private Sub Escritorio_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Close()
        Application.Exit()
    End Sub

    Private Sub Escritorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuPrincipal.Renderer = New ToolStripProfessionalRenderer(New ColortablePersonalizada())


        'cambiamos los colores de menus en menustrip

        'menu archivo
        ArchivoToolStripMenuItem.ForeColor = Color.White
        CerrarToolStripMenuItem.ForeColor = Color.White

        'menu administracion
        MenuAdministarcionDropDown.ForeColor = Color.White
        SucursalesMenuItem.ForeColor = Color.White
        UsuariosMenuItem.ForeColor = Color.White
        DepartamentosMenuItem.ForeColor = Color.White
        MarcaMenuItem.ForeColor = Color.White
        TallasMenuItem.ForeColor = Color.White
        ProductosMenuItem.ForeColor = Color.White
    End Sub

    Private Sub SucursalesMenuItem_Click(sender As Object, e As EventArgs) Handles SucursalesMenuItem.Click
        SucursalesAdministracion.Show()
    End Sub

    Private Sub UsuariosMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosMenuItem.Click
        UsuariosAdministrador.Show()
    End Sub

    Private Sub DepartamentosMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosMenuItem.Click
        DepartamentosAdministracion.Show()
    End Sub
End Class