<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SucursalesAdministracion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SucursalesAdministracion))
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelPaso3 = New System.Windows.Forms.Label()
        Me.LabelPaso2 = New System.Windows.Forms.Label()
        Me.LabelPaso1 = New System.Windows.Forms.Label()
        Me.DGVSucursales = New System.Windows.Forms.DataGridView()
        Me.IDSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSucursal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBNombre = New V10._0.CyTextBox()
        Me.TBFecha = New V10._0.CyTextBox()
        Me.TBDesc = New V10._0.CyTextBox()
        Me.TBHora = New V10._0.CyTextBox()
        Me.EstatusCyToggle = New V10._0.CyTogle_()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelDesc = New System.Windows.Forms.Label()
        Me.LabelEtatus = New System.Windows.Forms.Label()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.LabelIDSucursal = New System.Windows.Forms.Label()
        Me.CyButtonActualizar = New V10._0.CyButton()
        Me.CyButtonAgregar = New V10._0.CyButton()
        Me.CyButtonCancelar = New V10._0.CyButton()
        Me.PanelRight.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSucursales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRight
        '
        Me.PanelRight.Controls.Add(Me.Label1)
        Me.PanelRight.Controls.Add(Me.PictureBox1)
        Me.PanelRight.Controls.Add(Me.LabelPaso3)
        Me.PanelRight.Controls.Add(Me.LabelPaso2)
        Me.PanelRight.Controls.Add(Me.LabelPaso1)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelRight.Location = New System.Drawing.Point(610, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(176, 525)
        Me.PanelRight.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 129)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "•  Al agregar la sucursal también se agrega un usuario y contraseña listos para u" &
    "sarse, consulta con administrador de sistema"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.V10._0.My.Resources.Resources.IconSucursal
        Me.PictureBox1.Location = New System.Drawing.Point(8, 445)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'LabelPaso3
        '
        Me.LabelPaso3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPaso3.ForeColor = System.Drawing.Color.White
        Me.LabelPaso3.Location = New System.Drawing.Point(8, 180)
        Me.LabelPaso3.Name = "LabelPaso3"
        Me.LabelPaso3.Size = New System.Drawing.Size(161, 129)
        Me.LabelPaso3.TabIndex = 2
        Me.LabelPaso3.Text = "•  Cuando se crea una sucursal también se crean los roles de usuario ""Administrad" &
    "or, Vendedor y Supervisor"" y estarán disponibles para su uso"
        '
        'LabelPaso2
        '
        Me.LabelPaso2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPaso2.ForeColor = System.Drawing.Color.White
        Me.LabelPaso2.Location = New System.Drawing.Point(12, 96)
        Me.LabelPaso2.Name = "LabelPaso2"
        Me.LabelPaso2.Size = New System.Drawing.Size(161, 80)
        Me.LabelPaso2.TabIndex = 1
        Me.LabelPaso2.Text = "•  Una vez seleccionada deberán aparecer sus datos en las cajas de abajo "
        '
        'LabelPaso1
        '
        Me.LabelPaso1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPaso1.ForeColor = System.Drawing.Color.White
        Me.LabelPaso1.Location = New System.Drawing.Point(12, 28)
        Me.LabelPaso1.Name = "LabelPaso1"
        Me.LabelPaso1.Size = New System.Drawing.Size(161, 68)
        Me.LabelPaso1.TabIndex = 0
        Me.LabelPaso1.Text = "•  Para seleccionar una sucursal da doble clic encima de esta "
        '
        'DGVSucursales
        '
        Me.DGVSucursales.AllowUserToAddRows = False
        Me.DGVSucursales.AllowUserToDeleteRows = False
        Me.DGVSucursales.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        Me.DGVSucursales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVSucursales.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVSucursales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSucursales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSucursal, Me.NombreSucursal, Me.DescripcionSucursal, Me.EstatusSucursal, Me.FechaSucursal, Me.HoraSucursal})
        Me.DGVSucursales.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DGVSucursales.Location = New System.Drawing.Point(12, 28)
        Me.DGVSucursales.MultiSelect = False
        Me.DGVSucursales.Name = "DGVSucursales"
        Me.DGVSucursales.ReadOnly = True
        Me.DGVSucursales.RowTemplate.Height = 25
        Me.DGVSucursales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSucursales.Size = New System.Drawing.Size(574, 178)
        Me.DGVSucursales.TabIndex = 1
        '
        'IDSucursal
        '
        Me.IDSucursal.HeaderText = "IDSucursal"
        Me.IDSucursal.Name = "IDSucursal"
        Me.IDSucursal.ReadOnly = True
        Me.IDSucursal.Visible = False
        '
        'NombreSucursal
        '
        Me.NombreSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreSucursal.HeaderText = "Nombre"
        Me.NombreSucursal.Name = "NombreSucursal"
        Me.NombreSucursal.ReadOnly = True
        '
        'DescripcionSucursal
        '
        Me.DescripcionSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionSucursal.HeaderText = "Descripcion"
        Me.DescripcionSucursal.Name = "DescripcionSucursal"
        Me.DescripcionSucursal.ReadOnly = True
        '
        'EstatusSucursal
        '
        Me.EstatusSucursal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EstatusSucursal.HeaderText = "Estatus"
        Me.EstatusSucursal.Name = "EstatusSucursal"
        Me.EstatusSucursal.ReadOnly = True
        '
        'FechaSucursal
        '
        Me.FechaSucursal.HeaderText = "Fecha"
        Me.FechaSucursal.Name = "FechaSucursal"
        Me.FechaSucursal.ReadOnly = True
        Me.FechaSucursal.Visible = False
        '
        'HoraSucursal
        '
        Me.HoraSucursal.HeaderText = "Hora"
        Me.HoraSucursal.Name = "HoraSucursal"
        Me.HoraSucursal.ReadOnly = True
        Me.HoraSucursal.Visible = False
        '
        'TBNombre
        '
        Me.TBNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TBNombre.BordeSubrrayado = True
        Me.TBNombre.ColorBorde = System.Drawing.Color.Blue
        Me.TBNombre.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TBNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TBNombre.ForeColor = System.Drawing.Color.White
        Me.TBNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBNombre.ForeColor = System.Drawing.Color.White
        Me.TBNombre.GrosorBorde = 1
        Me.TBNombre.Location = New System.Drawing.Point(51, 263)
        Me.TBNombre.MultilineText = False
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Padding = New System.Windows.Forms.Padding(7)
        Me.TBNombre.PassWordChar = False
        Me.TBNombre.PlaceHolder = ""
        Me.TBNombre.Size = New System.Drawing.Size(200, 34)
        Me.TBNombre.TabIndex = 1
        '
        'TBFecha
        '
        Me.TBFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TBFecha.BordeSubrrayado = False
        Me.TBFecha.ColorBorde = System.Drawing.Color.Blue
        Me.TBFecha.ColorFocus = System.Drawing.Color.Red
        Me.TBFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TBFecha.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TBFecha.Enabled = False
        Me.TBFecha.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBFecha.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TBFecha.GrosorBorde = 1
        Me.TBFecha.Location = New System.Drawing.Point(51, 341)
        Me.TBFecha.MultilineText = False
        Me.TBFecha.Name = "TBFecha"
        Me.TBFecha.Padding = New System.Windows.Forms.Padding(7)
        Me.TBFecha.PassWordChar = False
        Me.TBFecha.PlaceHolder = ""
        Me.TBFecha.Size = New System.Drawing.Size(200, 34)
        Me.TBFecha.TabIndex = 10
        '
        'TBDesc
        '
        Me.TBDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TBDesc.BordeSubrrayado = True
        Me.TBDesc.ColorBorde = System.Drawing.Color.Blue
        Me.TBDesc.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TBDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.TBDesc.ForeColor = System.Drawing.Color.White
        Me.TBDesc.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBDesc.ForeColor = System.Drawing.Color.White
        Me.TBDesc.GrosorBorde = 1
        Me.TBDesc.Location = New System.Drawing.Point(281, 263)
        Me.TBDesc.MultilineText = False
        Me.TBDesc.Name = "TBDesc"
        Me.TBDesc.Padding = New System.Windows.Forms.Padding(7)
        Me.TBDesc.PassWordChar = False
        Me.TBDesc.PlaceHolder = ""
        Me.TBDesc.Size = New System.Drawing.Size(200, 34)
        Me.TBDesc.TabIndex = 2
        '
        'TBHora
        '
        Me.TBHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TBHora.BordeSubrrayado = False
        Me.TBHora.ColorBorde = System.Drawing.Color.Blue
        Me.TBHora.ColorFocus = System.Drawing.Color.Red
        Me.TBHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TBHora.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TBHora.Enabled = False
        Me.TBHora.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBHora.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TBHora.GrosorBorde = 1
        Me.TBHora.Location = New System.Drawing.Point(281, 341)
        Me.TBHora.MultilineText = False
        Me.TBHora.Name = "TBHora"
        Me.TBHora.Padding = New System.Windows.Forms.Padding(7)
        Me.TBHora.PassWordChar = False
        Me.TBHora.PlaceHolder = ""
        Me.TBHora.Size = New System.Drawing.Size(200, 34)
        Me.TBHora.TabIndex = 11
        '
        'EstatusCyToggle
        '
        Me.EstatusCyToggle.AutoSize = True
        Me.EstatusCyToggle.Checked = True
        Me.EstatusCyToggle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EstatusCyToggle.ColorFondoOff = System.Drawing.Color.Gray
        Me.EstatusCyToggle.ColorFondoOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EstatusCyToggle.ColorSolido = True
        Me.EstatusCyToggle.ColorToggleOff = System.Drawing.Color.Gainsboro
        Me.EstatusCyToggle.ColorToggleOn = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.EstatusCyToggle.Location = New System.Drawing.Point(521, 263)
        Me.EstatusCyToggle.MinimumSize = New System.Drawing.Size(52, 22)
        Me.EstatusCyToggle.Name = "EstatusCyToggle"
        Me.EstatusCyToggle.Size = New System.Drawing.Size(52, 22)
        Me.EstatusCyToggle.TabIndex = 3
        Me.EstatusCyToggle.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNombre.ForeColor = System.Drawing.Color.White
        Me.LabelNombre.Location = New System.Drawing.Point(51, 238)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(59, 19)
        Me.LabelNombre.TabIndex = 8
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelDesc
        '
        Me.LabelDesc.AutoSize = True
        Me.LabelDesc.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelDesc.ForeColor = System.Drawing.Color.White
        Me.LabelDesc.Location = New System.Drawing.Point(281, 238)
        Me.LabelDesc.Name = "LabelDesc"
        Me.LabelDesc.Size = New System.Drawing.Size(79, 19)
        Me.LabelDesc.TabIndex = 9
        Me.LabelDesc.Text = "Descripcion"
        '
        'LabelEtatus
        '
        Me.LabelEtatus.AutoSize = True
        Me.LabelEtatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelEtatus.ForeColor = System.Drawing.Color.White
        Me.LabelEtatus.Location = New System.Drawing.Point(521, 241)
        Me.LabelEtatus.Name = "LabelEtatus"
        Me.LabelEtatus.Size = New System.Drawing.Size(47, 19)
        Me.LabelEtatus.TabIndex = 10
        Me.LabelEtatus.Text = "Activo"
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelFecha.ForeColor = System.Drawing.Color.White
        Me.LabelFecha.Location = New System.Drawing.Point(51, 319)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(120, 19)
        Me.LabelFecha.TabIndex = 11
        Me.LabelFecha.Text = "Fecha de Creación"
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelHora.ForeColor = System.Drawing.Color.White
        Me.LabelHora.Location = New System.Drawing.Point(281, 319)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(115, 19)
        Me.LabelHora.TabIndex = 12
        Me.LabelHora.Text = "Hora de Creación"
        '
        'LabelIDSucursal
        '
        Me.LabelIDSucursal.AutoSize = True
        Me.LabelIDSucursal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelIDSucursal.ForeColor = System.Drawing.Color.White
        Me.LabelIDSucursal.Location = New System.Drawing.Point(51, 397)
        Me.LabelIDSucursal.Name = "LabelIDSucursal"
        Me.LabelIDSucursal.Size = New System.Drawing.Size(134, 19)
        Me.LabelIDSucursal.TabIndex = 13
        Me.LabelIDSucursal.Text = "IDSucursal no visible"
        Me.LabelIDSucursal.Visible = False
        '
        'CyButtonActualizar
        '
        Me.CyButtonActualizar.BackColor = System.Drawing.Color.Fuchsia
        Me.CyButtonActualizar.ColorBorde = System.Drawing.Color.DarkMagenta
        Me.CyButtonActualizar.BackColor = System.Drawing.Color.Fuchsia
        Me.CyButtonActualizar.ForeColor = System.Drawing.Color.White
        Me.CyButtonActualizar.FlatAppearance.BorderSize = 0
        Me.CyButtonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CyButtonActualizar.ForeColor = System.Drawing.Color.White
        Me.CyButtonActualizar.GrosorBorde = 1
        Me.CyButtonActualizar.Location = New System.Drawing.Point(504, 391)
        Me.CyButtonActualizar.Name = "CyButtonActualizar"
        Me.CyButtonActualizar.RedondeadoBorde = 5
        Me.CyButtonActualizar.Size = New System.Drawing.Size(100, 30)
        Me.CyButtonActualizar.TabIndex = 5
        Me.CyButtonActualizar.Text = "Actualizar"
        Me.CyButtonActualizar.UseVisualStyleBackColor = False
        '
        'CyButtonAgregar
        '
        Me.CyButtonAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CyButtonAgregar.ColorBorde = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CyButtonAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CyButtonAgregar.ForeColor = System.Drawing.Color.White
        Me.CyButtonAgregar.FlatAppearance.BorderSize = 0
        Me.CyButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CyButtonAgregar.ForeColor = System.Drawing.Color.White
        Me.CyButtonAgregar.GrosorBorde = 1
        Me.CyButtonAgregar.Location = New System.Drawing.Point(504, 345)
        Me.CyButtonAgregar.Name = "CyButtonAgregar"
        Me.CyButtonAgregar.RedondeadoBorde = 5
        Me.CyButtonAgregar.Size = New System.Drawing.Size(100, 30)
        Me.CyButtonAgregar.TabIndex = 4
        Me.CyButtonAgregar.Text = "Agregar"
        Me.CyButtonAgregar.UseVisualStyleBackColor = False
        '
        'CyButtonCancelar
        '
        Me.CyButtonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CyButtonCancelar.ColorBorde = System.Drawing.Color.Maroon
        Me.CyButtonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CyButtonCancelar.ForeColor = System.Drawing.Color.White
        Me.CyButtonCancelar.FlatAppearance.BorderSize = 0
        Me.CyButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CyButtonCancelar.ForeColor = System.Drawing.Color.White
        Me.CyButtonCancelar.GrosorBorde = 1
        Me.CyButtonCancelar.Location = New System.Drawing.Point(504, 483)
        Me.CyButtonCancelar.Name = "CyButtonCancelar"
        Me.CyButtonCancelar.RedondeadoBorde = 5
        Me.CyButtonCancelar.Size = New System.Drawing.Size(100, 30)
        Me.CyButtonCancelar.TabIndex = 6
        Me.CyButtonCancelar.Text = "Cancelar"
        Me.CyButtonCancelar.UseVisualStyleBackColor = False
        '
        'SucursalesAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(786, 525)
        Me.Controls.Add(Me.CyButtonCancelar)
        Me.Controls.Add(Me.CyButtonAgregar)
        Me.Controls.Add(Me.CyButtonActualizar)
        Me.Controls.Add(Me.LabelIDSucursal)
        Me.Controls.Add(Me.LabelHora)
        Me.Controls.Add(Me.LabelFecha)
        Me.Controls.Add(Me.LabelEtatus)
        Me.Controls.Add(Me.LabelDesc)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EstatusCyToggle)
        Me.Controls.Add(Me.TBHora)
        Me.Controls.Add(Me.TBDesc)
        Me.Controls.Add(Me.TBFecha)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.DGVSucursales)
        Me.Controls.Add(Me.PanelRight)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SucursalesAdministracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion de sucursales"
        Me.PanelRight.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSucursales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelRight As Panel
    Friend WithEvents DGVSucursales As DataGridView
    Friend WithEvents IDSucursal As DataGridViewTextBoxColumn
    Friend WithEvents NombreSucursal As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionSucursal As DataGridViewTextBoxColumn
    Friend WithEvents EstatusSucursal As DataGridViewTextBoxColumn
    Friend WithEvents FechaSucursal As DataGridViewTextBoxColumn
    Friend WithEvents HoraSucursal As DataGridViewTextBoxColumn
    Friend WithEvents LabelPaso1 As Label
    Friend WithEvents LabelPaso2 As Label
    Friend WithEvents TBNombre As CyTextBox
    Friend WithEvents TBFecha As CyTextBox
    Friend WithEvents TBDesc As CyTextBox
    Friend WithEvents TBHora As CyTextBox
    Friend WithEvents EstatusCyToggle As CyTogle_
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelDesc As Label
    Friend WithEvents LabelEtatus As Label
    Friend WithEvents LabelFecha As Label
    Friend WithEvents LabelHora As Label
    Friend WithEvents LabelPaso3 As Label
    Friend WithEvents LabelIDSucursal As Label
    Friend WithEvents CyButtonActualizar As CyButton
    Friend WithEvents CyButtonAgregar As CyButton
    Friend WithEvents CyButtonCancelar As CyButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
