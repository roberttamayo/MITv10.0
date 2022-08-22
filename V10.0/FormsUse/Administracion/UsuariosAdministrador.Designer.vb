<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuariosAdministrador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuariosAdministrador))
        Me.DGVUsuarios = New System.Windows.Forms.DataGridView()
        Me.IduserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidosUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nickUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emailUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefonoUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estatusUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contrUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaCUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaMUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaCUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaMUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rolUserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CyTextBoxNombre = New V10._0.CyTextBox()
        Me.CyTextBoxApellidos = New V10._0.CyTextBox()
        Me.CyTextBoxNick = New V10._0.CyTextBox()
        Me.CyTextBoxEmail = New V10._0.CyTextBox()
        Me.CyTextBoxTelefono = New V10._0.CyTextBox()
        Me.CyTogleEstatus = New V10._0.CyTogle_()
        Me.CyTextBoxFechaC = New V10._0.CyTextBox()
        Me.CyTextBoxHoraC = New V10._0.CyTextBox()
        Me.CyTextBoxFechaM = New V10._0.CyTextBox()
        Me.CyTextBoxHoraM = New V10._0.CyTextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelApellidos = New System.Windows.Forms.Label()
        Me.LabelNick = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.LabelEstatus = New System.Windows.Forms.Label()
        Me.CyComboBoxRol = New V10._0.CyComboBox()
        Me.LabelFechac = New System.Windows.Forms.Label()
        Me.LabelFechaM = New System.Windows.Forms.Label()
        Me.LabelRol = New System.Windows.Forms.Label()
        Me.LabelContra = New System.Windows.Forms.Label()
        Me.CyTextBoxContra = New V10._0.CyTextBox()
        Me.CyButtonAgregar = New V10._0.CyButton()
        Me.CyButtonActualizar = New V10._0.CyButton()
        Me.CyButtonCancelar = New V10._0.CyButton()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.LabelPaso3 = New System.Windows.Forms.Label()
        Me.LabelPaso2 = New System.Windows.Forms.Label()
        Me.LabelPaso1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelIdUsuario = New System.Windows.Forms.Label()
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenido.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVUsuarios
        '
        Me.DGVUsuarios.AllowUserToAddRows = False
        Me.DGVUsuarios.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVUsuarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IduserColumn, Me.nombreUserColumn, Me.apellidosUserColumn, Me.nickUserColumn, Me.emailUserColumn, Me.telefonoUserColumn, Me.estatusUserColumn, Me.contrUserColumn, Me.fechaCUserColumn, Me.fechaMUserColumn, Me.horaCUserColumn, Me.horaMUserColumn, Me.rolUserColumn})
        Me.DGVUsuarios.Location = New System.Drawing.Point(12, 12)
        Me.DGVUsuarios.Name = "DGVUsuarios"
        Me.DGVUsuarios.ReadOnly = True
        Me.DGVUsuarios.RowTemplate.Height = 25
        Me.DGVUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVUsuarios.Size = New System.Drawing.Size(779, 150)
        Me.DGVUsuarios.TabIndex = 0
        '
        'IduserColumn
        '
        Me.IduserColumn.HeaderText = "iduser"
        Me.IduserColumn.Name = "IduserColumn"
        Me.IduserColumn.ReadOnly = True
        Me.IduserColumn.Visible = False
        '
        'nombreUserColumn
        '
        Me.nombreUserColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombreUserColumn.HeaderText = "Nombre"
        Me.nombreUserColumn.Name = "nombreUserColumn"
        Me.nombreUserColumn.ReadOnly = True
        '
        'apellidosUserColumn
        '
        Me.apellidosUserColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.apellidosUserColumn.HeaderText = "Apellidos"
        Me.apellidosUserColumn.Name = "apellidosUserColumn"
        Me.apellidosUserColumn.ReadOnly = True
        '
        'nickUserColumn
        '
        Me.nickUserColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nickUserColumn.HeaderText = "Nick"
        Me.nickUserColumn.Name = "nickUserColumn"
        Me.nickUserColumn.ReadOnly = True
        '
        'emailUserColumn
        '
        Me.emailUserColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.emailUserColumn.HeaderText = "Email"
        Me.emailUserColumn.Name = "emailUserColumn"
        Me.emailUserColumn.ReadOnly = True
        '
        'telefonoUserColumn
        '
        Me.telefonoUserColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.telefonoUserColumn.HeaderText = "Telefono"
        Me.telefonoUserColumn.Name = "telefonoUserColumn"
        Me.telefonoUserColumn.ReadOnly = True
        '
        'estatusUserColumn
        '
        Me.estatusUserColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.estatusUserColumn.HeaderText = "Estatus"
        Me.estatusUserColumn.Name = "estatusUserColumn"
        Me.estatusUserColumn.ReadOnly = True
        '
        'contrUserColumn
        '
        Me.contrUserColumn.HeaderText = "Contra"
        Me.contrUserColumn.Name = "contrUserColumn"
        Me.contrUserColumn.ReadOnly = True
        Me.contrUserColumn.Visible = False
        '
        'fechaCUserColumn
        '
        Me.fechaCUserColumn.HeaderText = "fechaC"
        Me.fechaCUserColumn.Name = "fechaCUserColumn"
        Me.fechaCUserColumn.ReadOnly = True
        Me.fechaCUserColumn.Visible = False
        '
        'fechaMUserColumn
        '
        Me.fechaMUserColumn.HeaderText = "FechaM"
        Me.fechaMUserColumn.Name = "fechaMUserColumn"
        Me.fechaMUserColumn.ReadOnly = True
        Me.fechaMUserColumn.Visible = False
        '
        'horaCUserColumn
        '
        Me.horaCUserColumn.HeaderText = "HoraC"
        Me.horaCUserColumn.Name = "horaCUserColumn"
        Me.horaCUserColumn.ReadOnly = True
        Me.horaCUserColumn.Visible = False
        '
        'horaMUserColumn
        '
        Me.horaMUserColumn.HeaderText = "HoraM"
        Me.horaMUserColumn.Name = "horaMUserColumn"
        Me.horaMUserColumn.ReadOnly = True
        Me.horaMUserColumn.Visible = False
        '
        'rolUserColumn
        '
        Me.rolUserColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.rolUserColumn.HeaderText = "Rol de usuario"
        Me.rolUserColumn.Name = "rolUserColumn"
        Me.rolUserColumn.ReadOnly = True
        '
        'CyTextBoxNombre
        '
        Me.CyTextBoxNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxNombre.BordeSubrrayado = True
        Me.CyTextBoxNombre.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxNombre.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CyTextBoxNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxNombre.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxNombre.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxNombre.GrosorBorde = 1
        Me.CyTextBoxNombre.Location = New System.Drawing.Point(22, 216)
        Me.CyTextBoxNombre.MultilineText = False
        Me.CyTextBoxNombre.Name = "CyTextBoxNombre"
        Me.CyTextBoxNombre.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxNombre.PassWordChar = False
        Me.CyTextBoxNombre.PlaceHolder = ""
        Me.CyTextBoxNombre.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxNombre.TabIndex = 1
        '
        'CyTextBoxApellidos
        '
        Me.CyTextBoxApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxApellidos.BordeSubrrayado = True
        Me.CyTextBoxApellidos.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxApellidos.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CyTextBoxApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxApellidos.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxApellidos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxApellidos.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxApellidos.GrosorBorde = 1
        Me.CyTextBoxApellidos.Location = New System.Drawing.Point(260, 216)
        Me.CyTextBoxApellidos.MultilineText = False
        Me.CyTextBoxApellidos.Name = "CyTextBoxApellidos"
        Me.CyTextBoxApellidos.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxApellidos.PassWordChar = False
        Me.CyTextBoxApellidos.PlaceHolder = ""
        Me.CyTextBoxApellidos.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxApellidos.TabIndex = 2
        '
        'CyTextBoxNick
        '
        Me.CyTextBoxNick.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxNick.BordeSubrrayado = True
        Me.CyTextBoxNick.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxNick.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CyTextBoxNick.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxNick.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxNick.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxNick.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxNick.GrosorBorde = 1
        Me.CyTextBoxNick.Location = New System.Drawing.Point(505, 216)
        Me.CyTextBoxNick.MultilineText = False
        Me.CyTextBoxNick.Name = "CyTextBoxNick"
        Me.CyTextBoxNick.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxNick.PassWordChar = False
        Me.CyTextBoxNick.PlaceHolder = ""
        Me.CyTextBoxNick.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxNick.TabIndex = 3
        '
        'CyTextBoxEmail
        '
        Me.CyTextBoxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxEmail.BordeSubrrayado = True
        Me.CyTextBoxEmail.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxEmail.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CyTextBoxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxEmail.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxEmail.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxEmail.GrosorBorde = 1
        Me.CyTextBoxEmail.Location = New System.Drawing.Point(22, 292)
        Me.CyTextBoxEmail.MultilineText = False
        Me.CyTextBoxEmail.Name = "CyTextBoxEmail"
        Me.CyTextBoxEmail.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxEmail.PassWordChar = False
        Me.CyTextBoxEmail.PlaceHolder = ""
        Me.CyTextBoxEmail.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxEmail.TabIndex = 4
        '
        'CyTextBoxTelefono
        '
        Me.CyTextBoxTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxTelefono.BordeSubrrayado = True
        Me.CyTextBoxTelefono.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxTelefono.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CyTextBoxTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxTelefono.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxTelefono.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxTelefono.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxTelefono.GrosorBorde = 1
        Me.CyTextBoxTelefono.Location = New System.Drawing.Point(260, 292)
        Me.CyTextBoxTelefono.MultilineText = False
        Me.CyTextBoxTelefono.Name = "CyTextBoxTelefono"
        Me.CyTextBoxTelefono.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxTelefono.PassWordChar = False
        Me.CyTextBoxTelefono.PlaceHolder = ""
        Me.CyTextBoxTelefono.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxTelefono.TabIndex = 5
        '
        'CyTogleEstatus
        '
        Me.CyTogleEstatus.AutoSize = True
        Me.CyTogleEstatus.Checked = True
        Me.CyTogleEstatus.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CyTogleEstatus.ColorFondoOff = System.Drawing.Color.Gray
        Me.CyTogleEstatus.ColorFondoOn = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CyTogleEstatus.ColorSolido = True
        Me.CyTogleEstatus.ColorToggleOff = System.Drawing.Color.Gainsboro
        Me.CyTogleEstatus.ColorToggleOn = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CyTogleEstatus.Location = New System.Drawing.Point(559, 292)
        Me.CyTogleEstatus.MinimumSize = New System.Drawing.Size(52, 22)
        Me.CyTogleEstatus.Name = "CyTogleEstatus"
        Me.CyTogleEstatus.Size = New System.Drawing.Size(52, 22)
        Me.CyTogleEstatus.TabIndex = 6
        Me.CyTogleEstatus.UseVisualStyleBackColor = True
        '
        'CyTextBoxFechaC
        '
        Me.CyTextBoxFechaC.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxFechaC.BordeSubrrayado = True
        Me.CyTextBoxFechaC.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxFechaC.ColorFocus = System.Drawing.Color.Red
        Me.CyTextBoxFechaC.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxFechaC.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CyTextBoxFechaC.Enabled = False
        Me.CyTextBoxFechaC.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxFechaC.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CyTextBoxFechaC.GrosorBorde = 1
        Me.CyTextBoxFechaC.Location = New System.Drawing.Point(22, 459)
        Me.CyTextBoxFechaC.MultilineText = False
        Me.CyTextBoxFechaC.Name = "CyTextBoxFechaC"
        Me.CyTextBoxFechaC.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxFechaC.PassWordChar = False
        Me.CyTextBoxFechaC.PlaceHolder = ""
        Me.CyTextBoxFechaC.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxFechaC.TabIndex = 7
        '
        'CyTextBoxHoraC
        '
        Me.CyTextBoxHoraC.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxHoraC.BordeSubrrayado = True
        Me.CyTextBoxHoraC.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxHoraC.ColorFocus = System.Drawing.Color.Red
        Me.CyTextBoxHoraC.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxHoraC.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CyTextBoxHoraC.Enabled = False
        Me.CyTextBoxHoraC.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxHoraC.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CyTextBoxHoraC.GrosorBorde = 1
        Me.CyTextBoxHoraC.Location = New System.Drawing.Point(22, 499)
        Me.CyTextBoxHoraC.MultilineText = False
        Me.CyTextBoxHoraC.Name = "CyTextBoxHoraC"
        Me.CyTextBoxHoraC.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxHoraC.PassWordChar = False
        Me.CyTextBoxHoraC.PlaceHolder = ""
        Me.CyTextBoxHoraC.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxHoraC.TabIndex = 8
        '
        'CyTextBoxFechaM
        '
        Me.CyTextBoxFechaM.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxFechaM.BordeSubrrayado = True
        Me.CyTextBoxFechaM.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxFechaM.ColorFocus = System.Drawing.Color.Red
        Me.CyTextBoxFechaM.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxFechaM.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CyTextBoxFechaM.Enabled = False
        Me.CyTextBoxFechaM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxFechaM.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CyTextBoxFechaM.GrosorBorde = 1
        Me.CyTextBoxFechaM.Location = New System.Drawing.Point(260, 459)
        Me.CyTextBoxFechaM.MultilineText = False
        Me.CyTextBoxFechaM.Name = "CyTextBoxFechaM"
        Me.CyTextBoxFechaM.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxFechaM.PassWordChar = False
        Me.CyTextBoxFechaM.PlaceHolder = ""
        Me.CyTextBoxFechaM.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxFechaM.TabIndex = 9
        '
        'CyTextBoxHoraM
        '
        Me.CyTextBoxHoraM.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxHoraM.BordeSubrrayado = True
        Me.CyTextBoxHoraM.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxHoraM.ColorFocus = System.Drawing.Color.Red
        Me.CyTextBoxHoraM.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxHoraM.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CyTextBoxHoraM.Enabled = False
        Me.CyTextBoxHoraM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxHoraM.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CyTextBoxHoraM.GrosorBorde = 1
        Me.CyTextBoxHoraM.Location = New System.Drawing.Point(260, 499)
        Me.CyTextBoxHoraM.MultilineText = False
        Me.CyTextBoxHoraM.Name = "CyTextBoxHoraM"
        Me.CyTextBoxHoraM.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxHoraM.PassWordChar = False
        Me.CyTextBoxHoraM.PlaceHolder = ""
        Me.CyTextBoxHoraM.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxHoraM.TabIndex = 10
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNombre.ForeColor = System.Drawing.Color.White
        Me.LabelNombre.Location = New System.Drawing.Point(22, 194)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(59, 19)
        Me.LabelNombre.TabIndex = 12
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelApellidos
        '
        Me.LabelApellidos.AutoSize = True
        Me.LabelApellidos.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelApellidos.ForeColor = System.Drawing.Color.White
        Me.LabelApellidos.Location = New System.Drawing.Point(260, 194)
        Me.LabelApellidos.Name = "LabelApellidos"
        Me.LabelApellidos.Size = New System.Drawing.Size(64, 19)
        Me.LabelApellidos.TabIndex = 13
        Me.LabelApellidos.Text = "Apellidos"
        '
        'LabelNick
        '
        Me.LabelNick.AutoSize = True
        Me.LabelNick.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNick.ForeColor = System.Drawing.Color.White
        Me.LabelNick.Location = New System.Drawing.Point(505, 194)
        Me.LabelNick.Name = "LabelNick"
        Me.LabelNick.Size = New System.Drawing.Size(35, 19)
        Me.LabelNick.TabIndex = 14
        Me.LabelNick.Text = "Nick"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelEmail.ForeColor = System.Drawing.Color.White
        Me.LabelEmail.Location = New System.Drawing.Point(22, 270)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(47, 19)
        Me.LabelEmail.TabIndex = 15
        Me.LabelEmail.Text = "E-mail"
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelTelefono.ForeColor = System.Drawing.Color.White
        Me.LabelTelefono.Location = New System.Drawing.Point(260, 270)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(60, 19)
        Me.LabelTelefono.TabIndex = 16
        Me.LabelTelefono.Text = "Telefono"
        '
        'LabelEstatus
        '
        Me.LabelEstatus.AutoSize = True
        Me.LabelEstatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelEstatus.ForeColor = System.Drawing.Color.White
        Me.LabelEstatus.Location = New System.Drawing.Point(558, 270)
        Me.LabelEstatus.Name = "LabelEstatus"
        Me.LabelEstatus.Size = New System.Drawing.Size(53, 19)
        Me.LabelEstatus.TabIndex = 17
        Me.LabelEstatus.Text = "Estatus"
        '
        'CyComboBoxRol
        '
        Me.CyComboBoxRol.BackColor = System.Drawing.Color.Blue
        Me.CyComboBoxRol.ColorBorde = System.Drawing.Color.Blue
        Me.CyComboBoxRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyComboBoxRol.ColorFondoLista = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CyComboBoxRol.ColorIcono = System.Drawing.Color.Blue
        Me.CyComboBoxRol.ColorTextLista = System.Drawing.Color.White
        Me.CyComboBoxRol.ForeColor = System.Drawing.Color.White
        Me.CyComboBoxRol.DataSource = Nothing
        Me.CyComboBoxRol.EstiloLista = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CyComboBoxRol.ForeColor = System.Drawing.Color.White
        Me.CyComboBoxRol.Location = New System.Drawing.Point(260, 367)
        Me.CyComboBoxRol.MinimumSize = New System.Drawing.Size(200, 30)
        Me.CyComboBoxRol.Name = "CyComboBoxRol"
        Me.CyComboBoxRol.Padding = New System.Windows.Forms.Padding(1)
        Me.CyComboBoxRol.Size = New System.Drawing.Size(200, 30)
        Me.CyComboBoxRol.TabIndex = 18
        Me.CyComboBoxRol.TamBorde = 1
        Me.CyComboBoxRol.Text = ""
        '
        'LabelFechac
        '
        Me.LabelFechac.AutoSize = True
        Me.LabelFechac.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelFechac.ForeColor = System.Drawing.Color.White
        Me.LabelFechac.Location = New System.Drawing.Point(22, 437)
        Me.LabelFechac.Name = "LabelFechac"
        Me.LabelFechac.Size = New System.Drawing.Size(117, 19)
        Me.LabelFechac.TabIndex = 19
        Me.LabelFechac.Text = "Fecha de creación"
        '
        'LabelFechaM
        '
        Me.LabelFechaM.AutoSize = True
        Me.LabelFechaM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelFechaM.ForeColor = System.Drawing.Color.White
        Me.LabelFechaM.Location = New System.Drawing.Point(260, 437)
        Me.LabelFechaM.Name = "LabelFechaM"
        Me.LabelFechaM.Size = New System.Drawing.Size(134, 19)
        Me.LabelFechaM.TabIndex = 20
        Me.LabelFechaM.Text = "Fecha de modificaón"
        '
        'LabelRol
        '
        Me.LabelRol.AutoSize = True
        Me.LabelRol.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelRol.ForeColor = System.Drawing.Color.White
        Me.LabelRol.Location = New System.Drawing.Point(259, 345)
        Me.LabelRol.Name = "LabelRol"
        Me.LabelRol.Size = New System.Drawing.Size(99, 19)
        Me.LabelRol.TabIndex = 21
        Me.LabelRol.Text = "Rol del usuario"
        '
        'LabelContra
        '
        Me.LabelContra.AutoSize = True
        Me.LabelContra.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelContra.ForeColor = System.Drawing.Color.White
        Me.LabelContra.Location = New System.Drawing.Point(22, 341)
        Me.LabelContra.Name = "LabelContra"
        Me.LabelContra.Size = New System.Drawing.Size(79, 19)
        Me.LabelContra.TabIndex = 23
        Me.LabelContra.Text = "Contraseña"
        '
        'CyTextBoxContra
        '
        Me.CyTextBoxContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxContra.BordeSubrrayado = True
        Me.CyTextBoxContra.ColorBorde = System.Drawing.Color.Blue
        Me.CyTextBoxContra.ColorFocus = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CyTextBoxContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.CyTextBoxContra.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxContra.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CyTextBoxContra.ForeColor = System.Drawing.Color.White
        Me.CyTextBoxContra.GrosorBorde = 1
        Me.CyTextBoxContra.Location = New System.Drawing.Point(22, 363)
        Me.CyTextBoxContra.MultilineText = False
        Me.CyTextBoxContra.Name = "CyTextBoxContra"
        Me.CyTextBoxContra.Padding = New System.Windows.Forms.Padding(7)
        Me.CyTextBoxContra.PassWordChar = False
        Me.CyTextBoxContra.PlaceHolder = ""
        Me.CyTextBoxContra.Size = New System.Drawing.Size(200, 34)
        Me.CyTextBoxContra.TabIndex = 22
        '
        'CyButtonAgregar
        '
        Me.CyButtonAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CyButtonAgregar.ColorBorde = System.Drawing.Color.MediumBlue
        Me.CyButtonAgregar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.CyButtonAgregar.ForeColor = System.Drawing.Color.White
        Me.CyButtonAgregar.FlatAppearance.BorderSize = 0
        Me.CyButtonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CyButtonAgregar.ForeColor = System.Drawing.Color.White
        Me.CyButtonAgregar.GrosorBorde = 1
        Me.CyButtonAgregar.Location = New System.Drawing.Point(691, 367)
        Me.CyButtonAgregar.Name = "CyButtonAgregar"
        Me.CyButtonAgregar.RedondeadoBorde = 0
        Me.CyButtonAgregar.Size = New System.Drawing.Size(100, 30)
        Me.CyButtonAgregar.TabIndex = 24
        Me.CyButtonAgregar.Text = "Agregar"
        Me.CyButtonAgregar.UseVisualStyleBackColor = False
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
        Me.CyButtonActualizar.Location = New System.Drawing.Point(691, 415)
        Me.CyButtonActualizar.Name = "CyButtonActualizar"
        Me.CyButtonActualizar.RedondeadoBorde = 0
        Me.CyButtonActualizar.Size = New System.Drawing.Size(100, 30)
        Me.CyButtonActualizar.TabIndex = 25
        Me.CyButtonActualizar.Text = "Actualizar"
        Me.CyButtonActualizar.UseVisualStyleBackColor = False
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
        Me.CyButtonCancelar.Location = New System.Drawing.Point(691, 503)
        Me.CyButtonCancelar.Name = "CyButtonCancelar"
        Me.CyButtonCancelar.RedondeadoBorde = 0
        Me.CyButtonCancelar.Size = New System.Drawing.Size(100, 30)
        Me.CyButtonCancelar.TabIndex = 26
        Me.CyButtonCancelar.Text = "Cancelar"
        Me.CyButtonCancelar.UseVisualStyleBackColor = False
        '
        'PanelContenido
        '
        Me.PanelContenido.Controls.Add(Me.LabelPaso3)
        Me.PanelContenido.Controls.Add(Me.LabelPaso2)
        Me.PanelContenido.Controls.Add(Me.LabelPaso1)
        Me.PanelContenido.Controls.Add(Me.PictureBox1)
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelContenido.Location = New System.Drawing.Point(833, 0)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(223, 555)
        Me.PanelContenido.TabIndex = 27
        '
        'LabelPaso3
        '
        Me.LabelPaso3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPaso3.ForeColor = System.Drawing.Color.White
        Me.LabelPaso3.Location = New System.Drawing.Point(3, 216)
        Me.LabelPaso3.Name = "LabelPaso3"
        Me.LabelPaso3.Size = New System.Drawing.Size(208, 84)
        Me.LabelPaso3.TabIndex = 3
        Me.LabelPaso3.Text = "• Todos los usuarios que vez al lado izquierdo son solo de esta sucursal si neces" &
    "itas revisar los usuarios de otra sucursal por favor selecciona la en la ventana" &
    " de inicio de sesión "
        '
        'LabelPaso2
        '
        Me.LabelPaso2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPaso2.ForeColor = System.Drawing.Color.White
        Me.LabelPaso2.Location = New System.Drawing.Point(3, 117)
        Me.LabelPaso2.Name = "LabelPaso2"
        Me.LabelPaso2.Size = New System.Drawing.Size(208, 84)
        Me.LabelPaso2.TabIndex = 2
        Me.LabelPaso2.Text = "• Para poder validar correctamente toda la información del usuario la mayoría de " &
    "los campos deben de tener al menos 8 dígitos por campo"
        '
        'LabelPaso1
        '
        Me.LabelPaso1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelPaso1.ForeColor = System.Drawing.Color.White
        Me.LabelPaso1.Location = New System.Drawing.Point(3, 12)
        Me.LabelPaso1.Name = "LabelPaso1"
        Me.LabelPaso1.Size = New System.Drawing.Size(208, 84)
        Me.LabelPaso1.TabIndex = 1
        Me.LabelPaso1.Text = "• Para seleccionar un usuario hacer doble clic en cualquiera de sus celdas o info" &
    "rmación en el cuadro de la izquierda"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.V10._0.My.Resources.Resources.users_icon
        Me.PictureBox1.Location = New System.Drawing.Point(17, 473)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LabelIdUsuario
        '
        Me.LabelIdUsuario.AutoSize = True
        Me.LabelIdUsuario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelIdUsuario.ForeColor = System.Drawing.Color.White
        Me.LabelIdUsuario.Location = New System.Drawing.Point(564, 335)
        Me.LabelIdUsuario.Name = "LabelIdUsuario"
        Me.LabelIdUsuario.Size = New System.Drawing.Size(0, 19)
        Me.LabelIdUsuario.TabIndex = 28
        Me.LabelIdUsuario.Visible = False
        '
        'UsuariosAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1056, 555)
        Me.Controls.Add(Me.LabelIdUsuario)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.CyButtonCancelar)
        Me.Controls.Add(Me.CyButtonActualizar)
        Me.Controls.Add(Me.CyButtonAgregar)
        Me.Controls.Add(Me.LabelContra)
        Me.Controls.Add(Me.CyTextBoxContra)
        Me.Controls.Add(Me.LabelRol)
        Me.Controls.Add(Me.LabelFechaM)
        Me.Controls.Add(Me.LabelFechac)
        Me.Controls.Add(Me.CyComboBoxRol)
        Me.Controls.Add(Me.LabelEstatus)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelNick)
        Me.Controls.Add(Me.LabelApellidos)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.CyTextBoxHoraM)
        Me.Controls.Add(Me.CyTextBoxFechaM)
        Me.Controls.Add(Me.CyTextBoxHoraC)
        Me.Controls.Add(Me.CyTextBoxFechaC)
        Me.Controls.Add(Me.CyTogleEstatus)
        Me.Controls.Add(Me.CyTextBoxTelefono)
        Me.Controls.Add(Me.CyTextBoxEmail)
        Me.Controls.Add(Me.CyTextBoxNick)
        Me.Controls.Add(Me.CyTextBoxApellidos)
        Me.Controls.Add(Me.CyTextBoxNombre)
        Me.Controls.Add(Me.DGVUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UsuariosAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador de Usuarios"
        CType(Me.DGVUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenido.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVUsuarios As DataGridView
    Friend WithEvents IduserColumn As DataGridViewTextBoxColumn
    Friend WithEvents nombreUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents apellidosUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents nickUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents emailUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents telefonoUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents estatusUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents contrUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents fechaCUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents fechaMUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents horaCUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents horaMUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents rolUserColumn As DataGridViewTextBoxColumn
    Friend WithEvents CyTextBoxNombre As CyTextBox
    Friend WithEvents CyTextBoxApellidos As CyTextBox
    Friend WithEvents CyTextBoxNick As CyTextBox
    Friend WithEvents CyTextBoxEmail As CyTextBox
    Friend WithEvents CyTextBoxTelefono As CyTextBox
    Friend WithEvents CyTogleEstatus As CyTogle_
    Friend WithEvents CyTextBoxFechaC As CyTextBox
    Friend WithEvents CyTextBoxHoraC As CyTextBox
    Friend WithEvents CyTextBoxFechaM As CyTextBox
    Friend WithEvents CyTextBoxHoraM As CyTextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelApellidos As Label
    Friend WithEvents LabelNick As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents LabelEstatus As Label
    Friend WithEvents CyComboBoxRol As CyComboBox
    Friend WithEvents LabelFechac As Label
    Friend WithEvents LabelFechaM As Label
    Friend WithEvents LabelRol As Label
    Friend WithEvents LabelContra As Label
    Friend WithEvents CyTextBoxContra As CyTextBox
    Friend WithEvents CyButtonAgregar As CyButton
    Friend WithEvents CyButtonActualizar As CyButton
    Friend WithEvents CyButtonCancelar As CyButton
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelIdUsuario As Label
    Friend WithEvents LabelPaso1 As Label
    Friend WithEvents LabelPaso2 As Label
    Friend WithEvents LabelPaso3 As Label
End Class
