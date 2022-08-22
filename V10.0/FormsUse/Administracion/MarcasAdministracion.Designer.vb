<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarcasAdministracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarcasAdministracion))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMarcasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstatusMarcasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaMarcaCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraMarcasCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BAgregar = New V10._0.CyButton()
        Me.CTEstatus = New V10._0.CyTogle_()
        Me.TBNombre = New V10._0.CyTextBox()
        Me.TBFecha = New V10._0.CyTextBox()
        Me.TBHora = New V10._0.CyTextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LFechaH = New System.Windows.Forms.Label()
        Me.LEstatus = New System.Windows.Forms.Label()
        Me.LID = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NombreMarcasCol, Me.EstatusMarcasCol, Me.fechaMarcaCol, Me.HoraMarcasCol})
        Me.DataGridView1.Location = New System.Drawing.Point(23, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(504, 193)
        Me.DataGridView1.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "IDMarcas"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'NombreMarcasCol
        '
        Me.NombreMarcasCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreMarcasCol.HeaderText = "Nombre"
        Me.NombreMarcasCol.Name = "NombreMarcasCol"
        Me.NombreMarcasCol.ReadOnly = True
        '
        'EstatusMarcasCol
        '
        Me.EstatusMarcasCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EstatusMarcasCol.HeaderText = "Estatus"
        Me.EstatusMarcasCol.Name = "EstatusMarcasCol"
        Me.EstatusMarcasCol.ReadOnly = True
        '
        'fechaMarcaCol
        '
        Me.fechaMarcaCol.HeaderText = "Fecha"
        Me.fechaMarcaCol.Name = "fechaMarcaCol"
        Me.fechaMarcaCol.ReadOnly = True
        Me.fechaMarcaCol.Visible = False
        '
        'HoraMarcasCol
        '
        Me.HoraMarcasCol.HeaderText = "Hora"
        Me.HoraMarcasCol.Name = "HoraMarcasCol"
        Me.HoraMarcasCol.ReadOnly = True
        Me.HoraMarcasCol.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(577, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 450)
        Me.Panel1.TabIndex = 1
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BAgregar.ColorBorde = System.Drawing.Color.DarkBlue
        Me.BAgregar.FlatAppearance.BorderSize = 0
        Me.BAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAgregar.GrosorBorde = 1
        Me.BAgregar.Location = New System.Drawing.Point(471, 408)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.RedondeadoBorde = 0
        Me.BAgregar.Size = New System.Drawing.Size(100, 30)
        Me.BAgregar.TabIndex = 13
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = False
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
        Me.CTEstatus.Location = New System.Drawing.Point(315, 278)
        Me.CTEstatus.MinimumSize = New System.Drawing.Size(52, 22)
        Me.CTEstatus.Name = "CTEstatus"
        Me.CTEstatus.Size = New System.Drawing.Size(52, 22)
        Me.CTEstatus.TabIndex = 12
        Me.CTEstatus.UseVisualStyleBackColor = True
        '
        'TBNombre
        '
        Me.TBNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TBNombre.BordeSubrrayado = True
        Me.TBNombre.ColorBorde = System.Drawing.Color.Blue
        Me.TBNombre.ColorFocus = System.Drawing.Color.Red
        Me.TBNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBNombre.GrosorBorde = 1
        Me.TBNombre.Location = New System.Drawing.Point(23, 278)
        Me.TBNombre.MultilineText = False
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Padding = New System.Windows.Forms.Padding(7)
        Me.TBNombre.PassWordChar = False
        Me.TBNombre.PlaceHolder = ""
        Me.TBNombre.Size = New System.Drawing.Size(200, 34)
        Me.TBNombre.TabIndex = 11
        '
        'TBFecha
        '
        Me.TBFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TBFecha.BordeSubrrayado = True
        Me.TBFecha.ColorBorde = System.Drawing.Color.Blue
        Me.TBFecha.ColorFocus = System.Drawing.Color.Red
        Me.TBFecha.Enabled = False
        Me.TBFecha.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBFecha.GrosorBorde = 1
        Me.TBFecha.Location = New System.Drawing.Point(23, 353)
        Me.TBFecha.MultilineText = False
        Me.TBFecha.Name = "TBFecha"
        Me.TBFecha.Padding = New System.Windows.Forms.Padding(7)
        Me.TBFecha.PassWordChar = False
        Me.TBFecha.PlaceHolder = ""
        Me.TBFecha.Size = New System.Drawing.Size(200, 34)
        Me.TBFecha.TabIndex = 14
        '
        'TBHora
        '
        Me.TBHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TBHora.BordeSubrrayado = True
        Me.TBHora.ColorBorde = System.Drawing.Color.Blue
        Me.TBHora.ColorFocus = System.Drawing.Color.Red
        Me.TBHora.Enabled = False
        Me.TBHora.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBHora.GrosorBorde = 1
        Me.TBHora.Location = New System.Drawing.Point(23, 393)
        Me.TBHora.MultilineText = False
        Me.TBHora.Name = "TBHora"
        Me.TBHora.Padding = New System.Windows.Forms.Padding(7)
        Me.TBHora.PassWordChar = False
        Me.TBHora.PlaceHolder = ""
        Me.TBHora.Size = New System.Drawing.Size(200, 34)
        Me.TBHora.TabIndex = 15
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LNombre.Location = New System.Drawing.Point(12, 256)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(62, 19)
        Me.LNombre.TabIndex = 16
        Me.LNombre.Text = "Nombre:"
        '
        'LFechaH
        '
        Me.LFechaH.AutoSize = True
        Me.LFechaH.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LFechaH.Location = New System.Drawing.Point(12, 331)
        Me.LFechaH.Name = "LFechaH"
        Me.LFechaH.Size = New System.Drawing.Size(163, 19)
        Me.LFechaH.TabIndex = 17
        Me.LFechaH.Text = "Fecha y hora de creacion:"
        '
        'LEstatus
        '
        Me.LEstatus.AutoSize = True
        Me.LEstatus.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LEstatus.Location = New System.Drawing.Point(305, 256)
        Me.LEstatus.Name = "LEstatus"
        Me.LEstatus.Size = New System.Drawing.Size(56, 19)
        Me.LEstatus.TabIndex = 18
        Me.LEstatus.Text = "Estatus:"
        '
        'LID
        '
        Me.LID.AutoSize = True
        Me.LID.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LID.Location = New System.Drawing.Point(295, 331)
        Me.LID.Name = "LID"
        Me.LID.Size = New System.Drawing.Size(17, 19)
        Me.LID.TabIndex = 19
        Me.LID.Text = "0"
        Me.LID.Visible = False
        '
        'MarcasAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LID)
        Me.Controls.Add(Me.LEstatus)
        Me.Controls.Add(Me.LFechaH)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.TBHora)
        Me.Controls.Add(Me.TBFecha)
        Me.Controls.Add(Me.BAgregar)
        Me.Controls.Add(Me.CTEstatus)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MarcasAdministracion"
        Me.Text = "Administracion de Marcas de ropa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BAgregar As CyButton
    Friend WithEvents CTEstatus As CyTogle_
    Friend WithEvents TBNombre As CyTextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NombreMarcasCol As DataGridViewTextBoxColumn
    Friend WithEvents EstatusMarcasCol As DataGridViewTextBoxColumn
    Friend WithEvents fechaMarcaCol As DataGridViewTextBoxColumn
    Friend WithEvents HoraMarcasCol As DataGridViewTextBoxColumn
    Friend WithEvents TBFecha As CyTextBox
    Friend WithEvents TBHora As CyTextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents LFechaH As Label
    Friend WithEvents LEstatus As Label
    Friend WithEvents LID As Label
End Class
