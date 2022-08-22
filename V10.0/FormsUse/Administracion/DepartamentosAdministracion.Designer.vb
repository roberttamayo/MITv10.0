<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartamentosAdministracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartamentosAdministracion))
        Me.DGVDepartamentos = New System.Windows.Forms.DataGridView()
        Me.IDDep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDepa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusDepa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBNombre = New V10._0.CyTextBox()
        Me.TBDescripcion = New V10._0.CyTextBox()
        Me.CTEstatus = New V10._0.CyTogle_()
        Me.LIDDep = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.LEstatus = New System.Windows.Forms.Label()
        Me.BAgregar = New V10._0.CyButton()
        Me.BActualizar = New V10._0.CyButton()
        Me.BCancelar = New V10._0.CyButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LPaso1 = New System.Windows.Forms.Label()
        Me.LPasodos = New System.Windows.Forms.Label()
        CType(Me.DGVDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVDepartamentos
        '
        Me.DGVDepartamentos.AllowUserToAddRows = False
        Me.DGVDepartamentos.AllowUserToDeleteRows = False
        Me.DGVDepartamentos.AllowUserToOrderColumns = True
        Me.DGVDepartamentos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DGVDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDep, Me.NombreDp, Me.DescripcionDepa, Me.EstatusDepa})
        Me.DGVDepartamentos.Location = New System.Drawing.Point(26, 23)
        Me.DGVDepartamentos.Name = "DGVDepartamentos"
        Me.DGVDepartamentos.ReadOnly = True
        Me.DGVDepartamentos.RowTemplate.Height = 25
        Me.DGVDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDepartamentos.Size = New System.Drawing.Size(598, 199)
        Me.DGVDepartamentos.TabIndex = 0
        '
        'IDDep
        '
        Me.IDDep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IDDep.HeaderText = "ID"
        Me.IDDep.Name = "IDDep"
        Me.IDDep.ReadOnly = True
        '
        'NombreDp
        '
        Me.NombreDp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDp.HeaderText = "Nombre"
        Me.NombreDp.Name = "NombreDp"
        Me.NombreDp.ReadOnly = True
        '
        'DescripcionDepa
        '
        Me.DescripcionDepa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDepa.HeaderText = "Descripcion"
        Me.DescripcionDepa.Name = "DescripcionDepa"
        Me.DescripcionDepa.ReadOnly = True
        '
        'EstatusDepa
        '
        Me.EstatusDepa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EstatusDepa.HeaderText = "Estatus"
        Me.EstatusDepa.Name = "EstatusDepa"
        Me.EstatusDepa.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LPasodos)
        Me.Panel1.Controls.Add(Me.LPaso1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(630, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 459)
        Me.Panel1.TabIndex = 1
        '
        'TBNombre
        '
        Me.TBNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TBNombre.BordeSubrrayado = True
        Me.TBNombre.ColorBorde = System.Drawing.Color.Blue
        Me.TBNombre.ColorFocus = System.Drawing.Color.Red
        Me.TBNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBNombre.GrosorBorde = 1
        Me.TBNombre.Location = New System.Drawing.Point(42, 283)
        Me.TBNombre.MultilineText = False
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Padding = New System.Windows.Forms.Padding(7)
        Me.TBNombre.PassWordChar = False
        Me.TBNombre.PlaceHolder = ""
        Me.TBNombre.Size = New System.Drawing.Size(200, 34)
        Me.TBNombre.TabIndex = 2
        '
        'TBDescripcion
        '
        Me.TBDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TBDescripcion.BordeSubrrayado = True
        Me.TBDescripcion.ColorBorde = System.Drawing.Color.Blue
        Me.TBDescripcion.ColorFocus = System.Drawing.Color.Red
        Me.TBDescripcion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBDescripcion.GrosorBorde = 1
        Me.TBDescripcion.Location = New System.Drawing.Point(324, 283)
        Me.TBDescripcion.MultilineText = False
        Me.TBDescripcion.Name = "TBDescripcion"
        Me.TBDescripcion.Padding = New System.Windows.Forms.Padding(7)
        Me.TBDescripcion.PassWordChar = False
        Me.TBDescripcion.PlaceHolder = ""
        Me.TBDescripcion.Size = New System.Drawing.Size(200, 34)
        Me.TBDescripcion.TabIndex = 3
        '
        'CTEstatus
        '
        Me.CTEstatus.AutoSize = True
        Me.CTEstatus.Checked = True
        Me.CTEstatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CTEstatus.ColorFondoOff = System.Drawing.Color.Gray
        Me.CTEstatus.ColorFondoOn = System.Drawing.Color.SpringGreen
        Me.CTEstatus.ColorSolido = True
        Me.CTEstatus.ColorToggleOff = System.Drawing.Color.Gainsboro
        Me.CTEstatus.ColorToggleOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CTEstatus.Location = New System.Drawing.Point(56, 382)
        Me.CTEstatus.MinimumSize = New System.Drawing.Size(52, 22)
        Me.CTEstatus.Name = "CTEstatus"
        Me.CTEstatus.Size = New System.Drawing.Size(52, 22)
        Me.CTEstatus.TabIndex = 5
        Me.CTEstatus.UseVisualStyleBackColor = True
        '
        'LIDDep
        '
        Me.LIDDep.AutoSize = True
        Me.LIDDep.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LIDDep.ForeColor = System.Drawing.Color.White
        Me.LIDDep.Location = New System.Drawing.Point(324, 382)
        Me.LIDDep.Name = "LIDDep"
        Me.LIDDep.Size = New System.Drawing.Size(0, 19)
        Me.LIDDep.TabIndex = 6
        Me.LIDDep.Visible = False
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LNombre.ForeColor = System.Drawing.Color.White
        Me.LNombre.Location = New System.Drawing.Point(42, 260)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(172, 19)
        Me.LNombre.TabIndex = 7
        Me.LNombre.Text = "Nombre del departamento"
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LDescripcion.ForeColor = System.Drawing.Color.White
        Me.LDescripcion.Location = New System.Drawing.Point(324, 262)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(192, 19)
        Me.LDescripcion.TabIndex = 8
        Me.LDescripcion.Text = "Descripcion del departamento"
        '
        'LEstatus
        '
        Me.LEstatus.AutoSize = True
        Me.LEstatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LEstatus.ForeColor = System.Drawing.Color.White
        Me.LEstatus.Location = New System.Drawing.Point(59, 350)
        Me.LEstatus.Name = "LEstatus"
        Me.LEstatus.Size = New System.Drawing.Size(53, 19)
        Me.LEstatus.TabIndex = 9
        Me.LEstatus.Text = "Estatus"
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BAgregar.ColorBorde = System.Drawing.Color.DarkBlue
        Me.BAgregar.FlatAppearance.BorderSize = 0
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAgregar.GrosorBorde = 1
        Me.BAgregar.Location = New System.Drawing.Point(524, 339)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.RedondeadoBorde = 0
        Me.BAgregar.Size = New System.Drawing.Size(100, 30)
        Me.BAgregar.TabIndex = 10
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'BActualizar
        '
        Me.BActualizar.BackColor = System.Drawing.Color.MediumOrchid
        Me.BActualizar.ColorBorde = System.Drawing.Color.DarkOrchid
        Me.BActualizar.FlatAppearance.BorderSize = 0
        Me.BActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BActualizar.GrosorBorde = 1
        Me.BActualizar.Location = New System.Drawing.Point(524, 377)
        Me.BActualizar.Name = "BActualizar"
        Me.BActualizar.RedondeadoBorde = 0
        Me.BActualizar.Size = New System.Drawing.Size(100, 30)
        Me.BActualizar.TabIndex = 11
        Me.BActualizar.Text = "Actualizar"
        Me.BActualizar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelar.ColorBorde = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelar.FlatAppearance.BorderSize = 0
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.GrosorBorde = 1
        Me.BCancelar.Location = New System.Drawing.Point(524, 413)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.RedondeadoBorde = 0
        Me.BCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.V10._0.My.Resources.Resources.departamentos_icon
        Me.PictureBox1.Location = New System.Drawing.Point(47, 373)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LPaso1
        '
        Me.LPaso1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LPaso1.ForeColor = System.Drawing.Color.White
        Me.LPaso1.Location = New System.Drawing.Point(7, 23)
        Me.LPaso1.Name = "LPaso1"
        Me.LPaso1.Size = New System.Drawing.Size(166, 114)
        Me.LPaso1.TabIndex = 1
        Me.LPaso1.Text = "• Llene los campos y luego de en agregar para agregar un nuevo departamento a est" &
    "a sucursal"
        '
        'LPasodos
        '
        Me.LPasodos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LPasodos.ForeColor = System.Drawing.Color.White
        Me.LPasodos.Location = New System.Drawing.Point(7, 159)
        Me.LPasodos.Name = "LPasodos"
        Me.LPasodos.Size = New System.Drawing.Size(166, 193)
        Me.LPasodos.TabIndex = 2
        Me.LPasodos.Text = "• Para actualizar un departamento primero de doble clic sobre alguno en la tabla " &
    "de la izquierda, se llenarán los campos automáticamente modifíquelos y haga clic" &
    " en actualizar"
        '
        'DepartamentosAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 459)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BActualizar)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.LEstatus)
        Me.Controls.Add(Me.LDescripcion)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LIDDep)
        Me.Controls.Add(Me.CTEstatus)
        Me.Controls.Add(Me.TBDescripcion)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVDepartamentos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DepartamentosAdministracion"
        Me.Text = "Administracion de departamentos"
        CType(Me.DGVDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVDepartamentos As DataGridView
    Friend WithEvents IDDep As DataGridViewTextBoxColumn
    Friend WithEvents NombreDp As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDepa As DataGridViewTextBoxColumn
    Friend WithEvents EstatusDepa As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBNombre As CyTextBox
    Friend WithEvents TBDescripcion As CyTextBox
    Friend WithEvents CTEstatus As CyTogle_
    Friend WithEvents LIDDep As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents LEstatus As Label
    Friend WithEvents BAgregar As CyButton
    Friend WithEvents BActualizar As CyButton
    Friend WithEvents BCancelar As CyButton
    Friend WithEvents LPasodos As Label
    Friend WithEvents LPaso1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
