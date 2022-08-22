Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Public Class CyTogle_ : Inherits CheckBox
    Private _ColorFondoOn As Color = Color.Blue
    Private _ColorToggleOn As Color = Color.White
    Private _ColorFondoOff As Color = Color.Gray
    Private _ColorToggleOff As Color = Color.Gainsboro
    Private _ColorSolido As Boolean = True
    Public Sub New()
        Me.MinimumSize = New Size(52, 22)
    End Sub
#Region "Propiedades"
    <Category("Cy Propiedades")>
    Public Property ColorFondoOn As Color
        Get
            Return _ColorFondoOn
        End Get
        Set(value As Color)
            _ColorFondoOn = value
            Me.Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property ColorToggleOn As Color
        Get
            Return _ColorToggleOn
        End Get
        Set(value As Color)
            _ColorToggleOn = value
            Me.Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property ColorFondoOff As Color
        Get
            Return _ColorFondoOff
        End Get
        Set(value As Color)
            _ColorFondoOff = value
            Me.Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property ColorToggleOff As Color
        Get
            Return _ColorToggleOff
        End Get
        Set(value As Color)
            _ColorToggleOff = value
            Me.Invalidate()
        End Set
    End Property
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property ColorSolido As Boolean
        Get
            Return _ColorSolido
        End Get
        Set(value As Boolean)
            _ColorSolido = value
            Me.Invalidate()
        End Set
    End Property
#End Region
    Private Function RutaGrafica() As GraphicsPath
        Dim Arco As Integer = Me.Height - 1
        Dim ArcoIzquierda As New Rectangle(0, 0, Arco, Arco)
        Dim ArcoDerecho As New Rectangle(Me.Width - Me.Height - 2, 0, Arco, Arco)
        Dim Ruta As New GraphicsPath()
        Ruta.StartFigure()
        Ruta.AddArc(ArcoIzquierda, 90, 180)
        Ruta.AddArc(ArcoDerecho, 270, 180)
        Ruta.CloseFigure()
        Return Ruta
    End Function
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        Dim toggleSize As Integer = Me.Height - 5
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        pevent.Graphics.Clear(Me.Parent.BackColor)

        If Me.Checked Then 'on
            If ColorSolido Then
                pevent.Graphics.FillPath(New SolidBrush(ColorFondoOn), RutaGrafica())
            Else
                pevent.Graphics.DrawPath(New Pen(ColorFondoOn, 2), RutaGrafica())
            End If

            pevent.Graphics.FillEllipse(New SolidBrush(ColorToggleOn), New Rectangle(Me.Width - Me.Height + 1, 2, toggleSize, toggleSize))
        Else 'off desactivado
            If ColorSolido Then
                pevent.Graphics.FillPath(New SolidBrush(ColorFondoOff), RutaGrafica())
            Else
                pevent.Graphics.DrawPath(New Pen(ColorFondoOff, 2), RutaGrafica())
            End If
            pevent.Graphics.FillPath(New SolidBrush(ColorFondoOff), RutaGrafica())
            pevent.Graphics.FillEllipse(New SolidBrush(ColorToggleOff), New Rectangle(2, 2, toggleSize, toggleSize))
        End If
    End Sub
End Class
