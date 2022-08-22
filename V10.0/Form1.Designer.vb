<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BotonAceptar = New V10._0.CyButton()
        Me.BotonCancelar = New V10._0.CyButton()
        Me.TBUserNick = New V10._0.CyTextBox()
        Me.TBPass = New V10._0.CyTextBox()
        Me.CBSucursales = New V10._0.CyComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.V10._0.My.Resources.Resources.Mesa_de_trabajo_1
        Me.PictureBox1.Location = New System.Drawing.Point(28, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(144, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BotonAceptar
        '
        Me.BotonAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonAceptar.ColorBorde = System.Drawing.Color.Green
        Me.BotonAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonAceptar.ForeColor = System.Drawing.Color.White
        Me.BotonAceptar.FlatAppearance.BorderSize = 0
        Me.BotonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAceptar.ForeColor = System.Drawing.Color.White
        Me.BotonAceptar.GrosorBorde = 1
        Me.BotonAceptar.Location = New System.Drawing.Point(459, 179)
        Me.BotonAceptar.Name = "BotonAceptar"
        Me.BotonAceptar.RedondeadoBorde = 0
        Me.BotonAceptar.Size = New System.Drawing.Size(100, 30)
        Me.BotonAceptar.TabIndex = 1
        Me.BotonAceptar.Text = "Aceptar"
        Me.BotonAceptar.UseVisualStyleBackColor = False
        '
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonCancelar.ColorBorde = System.Drawing.Color.Maroon
        Me.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonCancelar.ForeColor = System.Drawing.Color.White
        Me.BotonCancelar.FlatAppearance.BorderSize = 0
        Me.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCancelar.ForeColor = System.Drawing.Color.White
        Me.BotonCancelar.GrosorBorde = 1
        Me.BotonCancelar.Location = New System.Drawing.Point(344, 179)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.RedondeadoBorde = 0
        Me.BotonCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BotonCancelar.TabIndex = 2
        Me.BotonCancelar.Text = "Cancelar"
        Me.BotonCancelar.UseVisualStyleBackColor = False
        '
        'TBUserNick
        '
        Me.TBUserNick.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TBUserNick.BordeSubrrayado = True
        Me.TBUserNick.ColorBorde = System.Drawing.Color.Blue
        Me.TBUserNick.ColorFocus = System.Drawing.Color.Red
        Me.TBUserNick.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TBUserNick.ForeColor = System.Drawing.Color.White
        Me.TBUserNick.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBUserNick.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBUserNick.ForeColor = System.Drawing.Color.White
        Me.TBUserNick.GrosorBorde = 1
        Me.TBUserNick.Location = New System.Drawing.Point(270, 77)
        Me.TBUserNick.MultilineText = False
        Me.TBUserNick.Name = "TBUserNick"
        Me.TBUserNick.Padding = New System.Windows.Forms.Padding(7)
        Me.TBUserNick.PassWordChar = False
        Me.TBUserNick.PlaceHolder = "Nombre de usuario"
        Me.TBUserNick.Size = New System.Drawing.Size(259, 34)
        Me.TBUserNick.TabIndex = 3
        Me.TBUserNick.Text = "cycodes"         '
        'TBPass
        '
        Me.TBPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TBPass.BordeSubrrayado = True
        Me.TBPass.ColorBorde = System.Drawing.Color.Blue
        Me.TBPass.ColorFocus = System.Drawing.Color.Red
        Me.TBPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TBPass.ForeColor = System.Drawing.Color.White
        Me.TBPass.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBPass.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TBPass.ForeColor = System.Drawing.Color.White
        Me.TBPass.GrosorBorde = 1
        Me.TBPass.Location = New System.Drawing.Point(270, 126)
        Me.TBPass.MultilineText = False
        Me.TBPass.Name = "TBPass"
        Me.TBPass.Padding = New System.Windows.Forms.Padding(7)
        Me.TBPass.PassWordChar = True
        Me.TBPass.PlaceHolder = "Contraseña"
        Me.TBPass.Size = New System.Drawing.Size(259, 34)
        Me.TBPass.TabIndex = 4
        Me.TBPass.Text = "12345"
        '
        'CBSucursales
        '
        Me.CBSucursales.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CBSucursales.ColorBorde = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CBSucursales.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CBSucursales.ColorFondoLista = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.CBSucursales.ColorIcono = System.Drawing.Color.Blue
        Me.CBSucursales.ColorTextLista = System.Drawing.Color.WhiteSmoke
        Me.CBSucursales.ForeColor = System.Drawing.Color.White
        Me.CBSucursales.DataSource = Nothing
        Me.CBSucursales.EstiloLista = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.CBSucursales.ForeColor = System.Drawing.Color.White
        Me.CBSucursales.Location = New System.Drawing.Point(270, 24)
        Me.CBSucursales.MinimumSize = New System.Drawing.Size(200, 30)
        Me.CBSucursales.Name = "CBSucursales"
        Me.CBSucursales.Padding = New System.Windows.Forms.Padding(1)
        Me.CBSucursales.Size = New System.Drawing.Size(259, 30)
        Me.CBSucursales.TabIndex = 5
        Me.CBSucursales.TamBorde = 1
        Me.CBSucursales.Text = "Selecciona tu sucursal"
        '
        'Form1
        '
        Me.AcceptButton = Me.BotonAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CancelButton = Me.BotonCancelar
        Me.ClientSize = New System.Drawing.Size(571, 221)
        Me.Controls.Add(Me.CBSucursales)
        Me.Controls.Add(Me.TBPass)
        Me.Controls.Add(Me.TBUserNick)
        Me.Controls.Add(Me.BotonCancelar)
        Me.Controls.Add(Me.BotonAceptar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BotonAceptar As CyButton
    Friend WithEvents BotonCancelar As CyButton
    Friend WithEvents TBUserNick As CyTextBox
    Friend WithEvents TBPass As CyTextBox
    Friend WithEvents CBSucursales As CyComboBox
End Class
