<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CyTextBox
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.TBContenido = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TBContenido
        '
        Me.TBContenido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBContenido.Location = New System.Drawing.Point(7, 7)
        Me.TBContenido.Name = "TBContenido"
        Me.TBContenido.Size = New System.Drawing.Size(186, 18)
        Me.TBContenido.TabIndex = 0
        '
        'CyTextBox
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.TBContenido)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Name = "CyTextBox"
        Me.Padding = New System.Windows.Forms.Padding(7)
        Me.Size = New System.Drawing.Size(200, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents TBContenido As TextBox
End Class
