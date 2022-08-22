Imports System.ComponentModel

<DefaultEvent("TextChange")>
Public Class CyTextBox
    Private _BordeSubrrayado As Boolean = False
    Private _ColorBorde As Color = Color.Blue
    Private _GrosorBorde As Integer = 1
    Private _ColorFocus As Color = Color.Red
    Private _Enfocado As Boolean = False
    Public Event TextChange(sender As Object, e As EventArgs)
#Region "Propiedades"
    <Category("Cy Propiedades")>
    Public Overrides Property BackColor As Color
        Get
            Return TBContenido.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            TBContenido.BackColor = value
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Overrides Property ForeColor As Color
        Get
            Return TBContenido.ForeColor
        End Get
        Set(value As Color)
            TBContenido.ForeColor = value
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property BordeSubrrayado As Boolean
        Get
            Return _BordeSubrrayado
        End Get
        Set(value As Boolean)
            _BordeSubrrayado = value
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property ColorFocus As Color
        Get
            Return _ColorFocus
        End Get
        Set(value As Color)
            _ColorFocus = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property ColorBorde As Color
        Get
            Return _ColorBorde
        End Get
        Set(value As Color)
            _ColorBorde = value
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            TBContenido.Font = value
            MyBase.Font = value
            If DesignMode Then
                ActualizarTam()
            End If
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property GrosorBorde As Integer
        Get
            Return _GrosorBorde
        End Get
        Set(value As Integer)
            _GrosorBorde = value
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property PlaceHolder As String
        Get
            Return TBContenido.PlaceholderText
        End Get
        Set(value As String)
            TBContenido.PlaceholderText = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Overrides Property Text As String
        Get
            Return TBContenido.Text
        End Get
        Set(value As String)
            TBContenido.Text = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property MultilineText As Boolean
        Get
            Return TBContenido.Multiline
        End Get
        Set(value As Boolean)
            TBContenido.Multiline = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property PassWordChar As Boolean
        Get
            Return TBContenido.UseSystemPasswordChar
        End Get
        Set(value As Boolean)
            TBContenido.UseSystemPasswordChar = value
        End Set
    End Property
#End Region
#Region "Eventos"
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim Grafico As Graphics = e.Graphics
        'Dibujamos el borde
        Dim Pen As New Pen(ColorBorde, GrosorBorde)
        Pen.Alignment = Drawing2D.PenAlignment.Inset

        If _Enfocado = False Then
            If BordeSubrrayado Then
                Grafico.DrawLine(Pen, 0, Height - 1, Width, Height - 1)
            Else
                'si el estilo no es subrrayado colocamos el borde completo
                Grafico.DrawRectangle(Pen, 0, 0, Width - 0.5F, Height - 0.5F)
            End If
        Else
            Pen.Color = ColorFocus
            If BordeSubrrayado Then
                Grafico.DrawLine(Pen, 0, Height - 1, Width, Height - 1)
            Else
                'si el estilo no es subrrayado colocamos el borde completo
                Grafico.DrawRectangle(Pen, 0, 0, Width - 0.5F, Height - 0.5F)
            End If
        End If
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        If DesignMode Then
            ActualizarTam()
        End If
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        ActualizarTam()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TBContenido.TextChanged
        RaiseEvent TextChange(sender, e)
    End Sub
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TBContenido.Enter
        _Enfocado = True
        Me.Invalidate()
    End Sub
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TBContenido.Leave
        _Enfocado = False
        Me.Invalidate()
    End Sub
#End Region
#Region "Metodos"
    Private Sub ActualizarTam()
        If TBContenido.Multiline = False Then
            Dim TText As Integer = TextRenderer.MeasureText("text", Font).Height + 1
            MultilineText = True
            TBContenido.MinimumSize = New Size(10, TText)
            MultilineText = False
            Height = TBContenido.Height + Padding.Top + Padding.Bottom
        End If
    End Sub
#End Region
End Class
