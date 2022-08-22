Public Class ColortablePersonalizada : Inherits ProfessionalColorTable

    'menustrip style
    Public Overrides ReadOnly Property MenuStripGradientBegin As Color
        Get
            Return Color.FromArgb(50, 50, 50)
        End Get
    End Property
    Public Overrides ReadOnly Property MenuStripGradientEnd As Color
        Get
            Return Color.FromArgb(50, 50, 50)
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
        Get
            Return Color.FromArgb(95, 95, 95)
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
        Get
            Return Color.FromArgb(95, 95, 95)
        End Get
    End Property

    'toolstrip style
    Public Overrides ReadOnly Property ToolStripGradientBegin As Color
        Get
            Return Color.FromArgb(50, 50, 50)
        End Get
    End Property
    Public Overrides ReadOnly Property ToolStripGradientMiddle As Color
        Get
            Return Color.FromArgb(50, 50, 50)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripGradientEnd As Color
        Get
            Return Color.FromArgb(50, 50, 50)
        End Get
    End Property
    Public Overrides ReadOnly Property ToolStripBorder As Color
        Get
            Return Color.FromArgb(50, 50, 50)
        End Get
    End Property

    Public Overrides ReadOnly Property ButtonSelectedGradientBegin As Color
        Get
            Return Color.FromArgb(95, 95, 95)
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonSelectedGradientMiddle As Color
        Get
            Return Color.FromArgb(95, 95, 95)
        End Get
    End Property
    Public Overrides ReadOnly Property ButtonSelectedGradientEnd As Color
        Get
            Return Color.FromArgb(95, 95, 95)
        End Get
    End Property

    'both
    Public Overrides ReadOnly Property MenuItemBorder As Color
        Get
            Return Color.Blue
        End Get
    End Property
    Public Overrides ReadOnly Property MenuBorder As Color
        Get
            Return Color.White
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
        Get
            Return Color.FromArgb(20, 20, 20)
        End Get
    End Property
    Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
        Get
            Return Color.FromArgb(20, 20, 20)
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
        Get
            Return Color.FromArgb(20, 20, 20)
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
        Get
            Return Color.FromArgb(20, 20, 20)
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
        Get
            Return Color.FromArgb(20, 20, 20)
        End Get
    End Property
    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        Get
            Return Color.FromArgb(20, 20, 20)
        End Get
    End Property
End Class
