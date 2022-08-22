Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class CyButton : Inherits Button
    Private _GrosorBorde As Integer = 1
    Private _RedondeadoBorde As Integer = 0
    Private _ColorBorde As Color = Color.DarkViolet
    Private _ColorTexto As Color = Color.White
    Private _ColorFonto As Color = Color.DarkViolet
#Region "Propiedades"
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
    Public Property RedondeadoBorde As Integer
        Get
            Return _RedondeadoBorde
        End Get
        Set(value As Integer)
            _RedondeadoBorde = value
            Invalidate()
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
    Public Overrides Property ForeColor As Color
        Get
            Return _ColorTexto
        End Get
        Set(value As Color)
            _ColorTexto = value
            MyBase.ForeColor = value
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Overrides Property BackColor As Color
        Get
            Return _ColorFonto
        End Get
        Set(value As Color)
            MyBase.BackColor = value
            _ColorFonto = value
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
        End Set
    End Property
#End Region
#Region "Constructor"
    Public Sub New()
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        Size = New Size(100, 30)
    End Sub
#End Region
#Region "Funciones"
    Private Shared Function BuscarZonaBoton(rect As RectangleF, radio As Integer) As GraphicsPath
        'funcion que obtiene un rectangulo de color espesificado y los bordes un poco mas afuera
        Dim ruta As New GraphicsPath()
        ruta.StartFigure()
        ruta.AddArc(rect.X, rect.Y, radio, radio, 180, 90)
        ruta.AddArc(rect.Width - radio, rect.Y, radio, radio, 270, 90)
        ruta.AddArc(rect.Width - radio, rect.Height - radio, radio, radio, 0, 90)
        ruta.AddArc(rect.X, rect.Height - radio, radio, radio, 90, 90)
        ruta.CloseFigure()
        Return ruta
    End Function
    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        'funicion para dibujar un rectangulo en un button
        MyBase.OnPaint(pevent)
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim rectanguloBase As New RectangleF(0, 0, Me.Width, Me.Height)
        Dim rectanguloBorde As New RectangleF(1, 1, Me.Width - 0.8F, Me.Height - 1)
        If RedondeadoBorde > 2 Then
            'dibujamos un rectangulo con bordes y esquinas redondeadas
            Using SuperficieRectangulo As GraphicsPath = BuscarZonaBoton(rectanguloBase, RedondeadoBorde),
                  BordeRectangulo As GraphicsPath = BuscarZonaBoton(rectanguloBorde, RedondeadoBorde - 1.0F),
                  SuperficiePintada As New Pen(Me.Parent.BackColor, 2),
                  BordePintado As New Pen(ColorBorde, GrosorBorde)
                BordePintado.Alignment = PenAlignment.Inset
                Region = New Region(SuperficieRectangulo)
                pevent.Graphics.DrawPath(SuperficiePintada, SuperficieRectangulo)
                If GrosorBorde >= 1 Then
                    pevent.Graphics.DrawPath(BordePintado, BordeRectangulo)
                End If
            End Using
        Else
            'si el rectangulo no se necesita con borde rellenamos todo el rectangulo
            pevent.Graphics.SmoothingMode = SmoothingMode.None
            Region = New Region(rectanguloBase)
            If GrosorBorde >= 1 Then
                Using penBorder As New Pen(ColorBorde, GrosorBorde)
                    penBorder.Alignment = PenAlignment.Inset
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, Me.Width - 1, Me.Height - 1)
                End Using
            End If
        End If
    End Sub
#End Region
End Class
