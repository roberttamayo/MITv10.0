Imports System.ComponentModel

Public Class AlertasPersonalizadas
    Public Response As Boolean = False
    Public Sub Alerta(titulo As String, contenido As String)
        PBAlerta.Visible = True
        Text = titulo
        LabelContenido.Text = contenido
        ShowDialog()
    End Sub
    Public Sub Bug(titulo As String, contenido As String)
        PBBug.Visible = True
        Text = titulo
        LabelContenido.Text = contenido
        ShowDialog()
    End Sub
    Public Sub Check(titulo As String, contenido As String)
        PBCheck.Visible = True
        Text = titulo
        LabelContenido.Text = contenido
        ShowDialog()
    End Sub
    Public Sub Pregunta(titulo As String, contenido As String)
        PBPregunta.Visible = True
        BotonCancelar.Visible = True
        BotonCancelar.Enabled = True
        Text = titulo
        LabelContenido.Text = contenido
        ShowDialog()
    End Sub
    Private Sub AlertasPersonalizadas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        PBPregunta.Visible = False
        BotonCancelar.Visible = False
        BotonCancelar.Enabled = False
        PBCheck.Visible = False
        PBBug.Visible = False
        PBAlerta.Visible = False
    End Sub
    Private Sub BotonAceptar_Click(sender As Object, e As EventArgs) Handles BotonAceptar.Click
        Response = True
        Close()
    End Sub
    Private Sub BotonCancelar_Click(sender As Object, e As EventArgs) Handles BotonCancelar.Click
        Response = False
        Close()
    End Sub
    Private Sub AlertasPersonalizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub
End Class