Imports System.ComponentModel
Imports System.Drawing.Design
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.ComboBox

<DefaultEvent("SelectedIndexChangedCB")>
Public Class CyComboBox
    Private _ColorFondo As Color = Color.White
    Private _ColorIcono As Color = Color.Blue
    Private _ColorBorde As Color = Color.Red
    Private _ColorFondoLista As Color = Color.Purple
    Private _ColorTextLista As Color = Color.White
    Private _TamBorde As Integer = 1
#Region "Propiedades"
    <Category("Cy Propiedades")>
    Public Overrides Property BackColor As Color
        Get
            Return _ColorFondo
        End Get
        Set(value As Color)
            _ColorFondo = value
            Label1.BackColor = value
            Button1.BackColor = value
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property ColorIcono As Color
        Get
            Return _ColorIcono
        End Get
        Set(value As Color)
            _ColorIcono = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property ColorFondoLista As Color
        Get
            Return _ColorFondoLista
        End Get
        Set(value As Color)
            _ColorFondoLista = value
            ComboBox1.BackColor = _ColorFondoLista
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property ColorTextLista As Color
        Get
            Return _ColorTextLista
        End Get
        Set(value As Color)
            _ColorTextLista = value
            ComboBox1.ForeColor = _ColorFondoLista
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property TamBorde As Integer
        Get
            Return _TamBorde
        End Get
        Set(value As Integer)
            _TamBorde = value
            Padding = New Padding(_TamBorde)
            Invalidate()
            AjustarUserControl()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
            Label1.ForeColor = value
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
            MyBase.BackColor = value
            Invalidate()
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Property EstiloLista As ComboBoxStyle
        Get
            Return ComboBox1.DropDownStyle
        End Get
        Set(value As ComboBoxStyle)
            If value <> ComboBoxStyle.Simple Then
                ComboBox1.DropDownStyle = value
            End If
        End Set
    End Property
    <Category("Cy Propiedades")>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            Label1.Font = value
            ComboBox1.Font = value
        End Set
    End Property


    <Category("Cy Propiedades")>
    Public Overrides Property Text As String
        Get
            Return Label1.Text
        End Get
        Set(value As String)
            Label1.Text = value
        End Set
    End Property
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", GetType(UITypeEditor))>
    <Localizable(True)>
    <MergableProperty(False)>
    <Category("Cy Propiedades")>
    Public ReadOnly Property Items As ObjectCollection
        Get
            Return ComboBox1.Items()
        End Get
    End Property
    <Category("Cy Propiedades")>
    <AttributeProvider(GetType(IListSource))>
    Public Property DataSource As Object
        Get
            Return ComboBox1.DataSource
        End Get
        Set(value As Object)
            ComboBox1.DataSource = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    <Browsable(True)>
    <DefaultValue(AutoCompleteMode.None)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    Public Property AutoCompleteMode As AutoCompleteMode
        Get
            Return ComboBox1.AutoCompleteMode
        End Get
        Set(value As AutoCompleteMode)
            ComboBox1.AutoCompleteMode = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    <Browsable(True)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", GetType(UITypeEditor))>
    <EditorBrowsable(EditorBrowsableState.Always)>
    <Localizable(True)>
    Public Property AutoCompleteCustomSource As AutoCompleteStringCollection
        Get
            Return ComboBox1.AutoCompleteCustomSource
        End Get
        Set(value As AutoCompleteStringCollection)
            ComboBox1.AutoCompleteCustomSource = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    <Browsable(True)>
    <DefaultValue(AutoCompleteSource.None)>
    <EditorBrowsable(EditorBrowsableState.Always)>
    Public Property AutoCompleteSource As AutoCompleteSource
        Get
            Return ComboBox1.AutoCompleteSource
        End Get
        Set(value As AutoCompleteSource)
            ComboBox1.AutoCompleteSource = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    <Bindable(True)>
    <Browsable(False)> <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property SelectedItem As Object
        Get
            Return ComboBox1.SelectedItem
        End Get
        Set(value As Object)
            ComboBox1.SelectedItem = value
        End Set
    End Property
    <Category("Cy Propiedades")>
    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property SelectedText As String
        Get
            Return ComboBox1.SelectedText
        End Get
        Set(value As String)
            ComboBox1.SelectedText = value
        End Set
    End Property
#End Region
    Public Event SelectedIndexChangedCB(sender As Object, e As EventArgs)
    Public Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ComboBox1.MinimumSize = New Size(200, 5)
        AddHandler ComboBox1.TextChanged, AddressOf TextchangedComboBox
        AddHandler ComboBox1.SelectedIndexChanged, AddressOf SelectedIndexChangedComboBox

        Button1.BackColor = BackColor
        Button1.Cursor = Cursors.Hand
        AddHandler Button1.Click, AddressOf ClickButtonList
        AddHandler Button1.Paint, AddressOf PintarBoton

        Label1.BackColor = BackColor
        Label1.TextAlign = ContentAlignment.MiddleLeft
        Label1.ForeColor = MyBase.ForeColor
        Label1.Padding = New Padding(8, 0, 0, 0)
        Label1.Font = New Font(MyBase.Font.Name, 10.0F)
        AddHandler Label1.Click, AddressOf ClickTextbox

        MyBase.Padding = New Padding(TamBorde)
        MyBase.BackColor = ColorBorde
        MyBase.MinimumSize = New Size(200, 30)

        AjustarUserControl()
    End Sub
#Region "Metodos"
    Private Sub AjustarUserControl()
        ComboBox1.ForeColor = Color.White
        ComboBox1.Width = Label1.Width
        Dim X As Integer = Width - Padding.Right - ComboBox1.Width
        Dim Y As Integer = Label1.Location.X - ComboBox1.Height - 3
        ComboBox1.Location = New Point(X, Y)
    End Sub
#End Region
#Region "eventos"
    Private Sub ClickTextbox(sender As Object, e As EventArgs)
        ComboBox1.Select()
        If ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList Then
            ComboBox1.DroppedDown = True
        End If
    End Sub
    Private Sub ClickButtonList(sender As Object, e As EventArgs)
        ComboBox1.Select()
        ComboBox1.DroppedDown = True
    End Sub
    Public Sub TextchangedComboBox(sender As Object, e As EventArgs)
        Label1.Text = ComboBox1.Text
    End Sub
    Private Sub SelectedIndexChangedComboBox(sender As Object, e As EventArgs)
        RaiseEvent SelectedIndexChangedCB(sender, e)
        Label1.Text = ComboBox1.Text
    End Sub
    Private Sub PintarBoton(sender As Object, e As PaintEventArgs)
        Dim AltoIco As Integer = 6
        Dim AnchoIco As Integer = 14
        Dim rectangle As New Rectangle((Button1.Width - AnchoIco) / 2, (Button1.Height - AltoIco) / 2, AnchoIco, AltoIco)
        Dim grafico As Graphics = e.Graphics

        Dim Ruta As GraphicsPath = New GraphicsPath()
        Dim pen As New Pen(ColorIcono, 2)

        grafico.SmoothingMode = SmoothingMode.AntiAlias
        Ruta.AddLine(rectangle.X, rectangle.Y, CInt(rectangle.X + (AnchoIco / 2)), rectangle.Bottom)
        Ruta.AddLine(CInt(rectangle.X + (AnchoIco / 2)), rectangle.Bottom, rectangle.Right, rectangle.Y)
        grafico.DrawPath(pen, Ruta)
    End Sub
#End Region
End Class
