<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AlertasPersonalizadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertasPersonalizadas))
        Me.PBBug = New System.Windows.Forms.PictureBox()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.LabelContenido = New System.Windows.Forms.Label()
        Me.PanelColorTi = New System.Windows.Forms.Panel()
        Me.BotonAceptar = New V10._0.CyButton()
        Me.BotonCancelar = New V10._0.CyButton()
        Me.PBAlerta = New System.Windows.Forms.PictureBox()
        Me.PBCheck = New System.Windows.Forms.PictureBox()
        Me.PBPregunta = New System.Windows.Forms.PictureBox()
        CType(Me.PBBug, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenido.SuspendLayout()
        CType(Me.PBAlerta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPregunta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBBug
        '
        Me.PBBug.Image = Global.V10._0.My.Resources.Resources.BugImageIcon
        Me.PBBug.Location = New System.Drawing.Point(12, 23)
        Me.PBBug.Name = "PBBug"
        Me.PBBug.Size = New System.Drawing.Size(116, 112)
        Me.PBBug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBBug.TabIndex = 0
        Me.PBBug.TabStop = False
        Me.PBBug.Visible = False
        '
        'PanelContenido
        '
        Me.PanelContenido.Controls.Add(Me.LabelContenido)
        Me.PanelContenido.Location = New System.Drawing.Point(159, 12)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(470, 123)
        Me.PanelContenido.TabIndex = 1
        '
        'LabelContenido
        '
        Me.LabelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelContenido.ForeColor = System.Drawing.Color.White
        Me.LabelContenido.Location = New System.Drawing.Point(0, 0)
        Me.LabelContenido.Name = "LabelContenido"
        Me.LabelContenido.Size = New System.Drawing.Size(470, 123)
        Me.LabelContenido.TabIndex = 0
        Me.LabelContenido.Text = "Label1"
        '
        'PanelColorTi
        '
        Me.PanelColorTi.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelColorTi.Location = New System.Drawing.Point(0, 0)
        Me.PanelColorTi.Name = "PanelColorTi"
        Me.PanelColorTi.Size = New System.Drawing.Size(641, 5)
        Me.PanelColorTi.TabIndex = 2
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
        Me.BotonAceptar.Location = New System.Drawing.Point(529, 141)
        Me.BotonAceptar.Name = "BotonAceptar"
        Me.BotonAceptar.RedondeadoBorde = 0
        Me.BotonAceptar.Size = New System.Drawing.Size(100, 30)
        Me.BotonAceptar.TabIndex = 3
        Me.BotonAceptar.Text = "Aceptar"
        Me.BotonAceptar.UseVisualStyleBackColor = False
        '
        'BotonCancelar
        '
        Me.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonCancelar.ColorBorde = System.Drawing.Color.Maroon
        Me.BotonCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BotonCancelar.ForeColor = System.Drawing.Color.White
        Me.BotonCancelar.Enabled = False
        Me.BotonCancelar.FlatAppearance.BorderSize = 0
        Me.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonCancelar.ForeColor = System.Drawing.Color.White
        Me.BotonCancelar.GrosorBorde = 1
        Me.BotonCancelar.Location = New System.Drawing.Point(410, 141)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.RedondeadoBorde = 0
        Me.BotonCancelar.Size = New System.Drawing.Size(100, 30)
        Me.BotonCancelar.TabIndex = 4
        Me.BotonCancelar.Text = "Cancelar"
        Me.BotonCancelar.UseVisualStyleBackColor = False
        Me.BotonCancelar.Visible = False
        '
        'PBAlerta
        '
        Me.PBAlerta.Image = Global.V10._0.My.Resources.Resources.AlertImageIcon
        Me.PBAlerta.Location = New System.Drawing.Point(12, 23)
        Me.PBAlerta.Name = "PBAlerta"
        Me.PBAlerta.Size = New System.Drawing.Size(116, 112)
        Me.PBAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBAlerta.TabIndex = 5
        Me.PBAlerta.TabStop = False
        Me.PBAlerta.Visible = False
        '
        'PBCheck
        '
        Me.PBCheck.Image = Global.V10._0.My.Resources.Resources.CheckImageIcon
        Me.PBCheck.Location = New System.Drawing.Point(12, 23)
        Me.PBCheck.Name = "PBCheck"
        Me.PBCheck.Size = New System.Drawing.Size(116, 112)
        Me.PBCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBCheck.TabIndex = 6
        Me.PBCheck.TabStop = False
        Me.PBCheck.Visible = False
        '
        'PBPregunta
        '
        Me.PBPregunta.Image = Global.V10._0.My.Resources.Resources.QuestionImageIcon
        Me.PBPregunta.Location = New System.Drawing.Point(12, 23)
        Me.PBPregunta.Name = "PBPregunta"
        Me.PBPregunta.Size = New System.Drawing.Size(116, 112)
        Me.PBPregunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBPregunta.TabIndex = 7
        Me.PBPregunta.TabStop = False
        Me.PBPregunta.Visible = False
        '
        'AlertasPersonalizadas
        '
        Me.AcceptButton = Me.BotonAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.CancelButton = Me.BotonCancelar
        Me.ClientSize = New System.Drawing.Size(641, 183)
        Me.Controls.Add(Me.PBPregunta)
        Me.Controls.Add(Me.PBCheck)
        Me.Controls.Add(Me.PBAlerta)
        Me.Controls.Add(Me.BotonCancelar)
        Me.Controls.Add(Me.BotonAceptar)
        Me.Controls.Add(Me.PanelColorTi)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PBBug)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlertasPersonalizadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AlertasPersonalizadas"
        CType(Me.PBBug, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenido.ResumeLayout(False)
        CType(Me.PBAlerta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPregunta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PBBug As PictureBox
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents LabelContenido As Label
    Friend WithEvents PanelColorTi As Panel
    Friend WithEvents BotonAceptar As CyButton
    Friend WithEvents BotonCancelar As CyButton
    Friend WithEvents PBAlerta As PictureBox
    Friend WithEvents PBCheck As PictureBox
    Friend WithEvents PBPregunta As PictureBox
End Class
