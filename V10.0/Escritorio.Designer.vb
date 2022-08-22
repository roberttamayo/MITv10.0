<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Escritorio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Escritorio))
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAdministarcionDropDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.SucursalesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarcaMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallasMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.MenuAdministarcionDropDown})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(854, 24)
        Me.MenuPrincipal.TabIndex = 0
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'MenuAdministarcionDropDown
        '
        Me.MenuAdministarcionDropDown.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SucursalesMenuItem, Me.UsuariosMenuItem, Me.DepartamentosMenuItem, Me.MarcaMenuItem, Me.TallasMenuItem, Me.ProductosMenuItem})
        Me.MenuAdministarcionDropDown.Name = "MenuAdministarcionDropDown"
        Me.MenuAdministarcionDropDown.Size = New System.Drawing.Size(100, 20)
        Me.MenuAdministarcionDropDown.Text = "Administracion"
        '
        'SucursalesMenuItem
        '
        Me.SucursalesMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SucursalesMenuItem.Image = Global.V10._0.My.Resources.Resources.IconSucursal
        Me.SucursalesMenuItem.Name = "SucursalesMenuItem"
        Me.SucursalesMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SucursalesMenuItem.Text = "Sucursales"
        '
        'UsuariosMenuItem
        '
        Me.UsuariosMenuItem.Image = Global.V10._0.My.Resources.Resources.users_icon
        Me.UsuariosMenuItem.Name = "UsuariosMenuItem"
        Me.UsuariosMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuariosMenuItem.Text = "Usuarios"
        '
        'DepartamentosMenuItem
        '
        Me.DepartamentosMenuItem.Image = Global.V10._0.My.Resources.Resources.departamentos_icon
        Me.DepartamentosMenuItem.Name = "DepartamentosMenuItem"
        Me.DepartamentosMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DepartamentosMenuItem.Text = "Departamentos"
        '
        'MarcaMenuItem
        '
        Me.MarcaMenuItem.Image = Global.V10._0.My.Resources.Resources.marcas_icon
        Me.MarcaMenuItem.Name = "MarcaMenuItem"
        Me.MarcaMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarcaMenuItem.Text = "Marcas"
        '
        'TallasMenuItem
        '
        Me.TallasMenuItem.Image = Global.V10._0.My.Resources.Resources.tallas_icon
        Me.TallasMenuItem.Name = "TallasMenuItem"
        Me.TallasMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TallasMenuItem.Text = "Tallas"
        '
        'ProductosMenuItem
        '
        Me.ProductosMenuItem.Image = Global.V10._0.My.Resources.Resources.productos_icon
        Me.ProductosMenuItem.Name = "ProductosMenuItem"
        Me.ProductosMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductosMenuItem.Text = "Producots"
        '
        'Escritorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(854, 432)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Name = "Escritorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Escritorio"
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAdministarcionDropDown As ToolStripMenuItem
    Friend WithEvents SucursalesMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosMenuItem As ToolStripMenuItem
    Friend WithEvents MarcaMenuItem As ToolStripMenuItem
    Friend WithEvents TallasMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosMenuItem As ToolStripMenuItem
End Class
