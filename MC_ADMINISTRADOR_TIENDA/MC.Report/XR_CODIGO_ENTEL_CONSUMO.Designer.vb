<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XR_CODIGO_ENTEL_CONSUMO
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrMensaje = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrProducto = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrCodigoEntel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLocal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrMensaje, Me.XrProducto, Me.XrCodigoEntel, Me.XrLocal, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrTitulo})
        Me.Detail.Dpi = 100.0!
        Me.Detail.HeightF = 184.375!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrMensaje
        '
        Me.XrMensaje.AutoWidth = True
        Me.XrMensaje.Dpi = 100.0!
        Me.XrMensaje.LocationFloat = New DevExpress.Utils.PointFloat(88.45831!, 151.375!)
        Me.XrMensaje.Name = "XrMensaje"
        Me.XrMensaje.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrMensaje.SizeF = New System.Drawing.SizeF(285.5!, 23.0!)
        Me.XrMensaje.StylePriority.UseTextAlignment = False
        Me.XrMensaje.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrProducto
        '
        Me.XrProducto.AutoWidth = True
        Me.XrProducto.Dpi = 100.0!
        Me.XrProducto.LocationFloat = New DevExpress.Utils.PointFloat(88.45831!, 116.6667!)
        Me.XrProducto.Name = "XrProducto"
        Me.XrProducto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrProducto.SizeF = New System.Drawing.SizeF(285.5!, 17.62498!)
        Me.XrProducto.StylePriority.UseTextAlignment = False
        Me.XrProducto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrCodigoEntel
        '
        Me.XrCodigoEntel.AutoWidth = True
        Me.XrCodigoEntel.Dpi = 100.0!
        Me.XrCodigoEntel.LocationFloat = New DevExpress.Utils.PointFloat(88.45831!, 83.33334!)
        Me.XrCodigoEntel.Name = "XrCodigoEntel"
        Me.XrCodigoEntel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrCodigoEntel.SizeF = New System.Drawing.SizeF(285.5!, 23.0!)
        Me.XrCodigoEntel.StylePriority.UseTextAlignment = False
        Me.XrCodigoEntel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLocal
        '
        Me.XrLocal.AutoWidth = True
        Me.XrLocal.Dpi = 100.0!
        Me.XrLocal.LocationFloat = New DevExpress.Utils.PointFloat(88.45831!, 46.95834!)
        Me.XrLocal.Name = "XrLocal"
        Me.XrLocal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLocal.SizeF = New System.Drawing.SizeF(285.5!, 23.0!)
        Me.XrLocal.StylePriority.UseTextAlignment = False
        Me.XrLocal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel4
        '
        Me.XrLabel4.Dpi = 100.0!
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 116.6667!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(88.45833!, 17.62499!)
        Me.XrLabel4.Text = "Producto:"
        '
        'XrLabel3
        '
        Me.XrLabel3.Dpi = 100.0!
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 151.375!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(88.45833!, 22.99999!)
        Me.XrLabel3.Text = "Mensaje:"
        '
        'XrLabel2
        '
        Me.XrLabel2.Dpi = 100.0!
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 83.33334!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(88.45833!, 17.62499!)
        Me.XrLabel2.Text = "Codigo Entel:"
        '
        'XrLabel1
        '
        Me.XrLabel1.Dpi = 100.0!
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 46.95834!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(88.45833!, 23.0!)
        Me.XrLabel1.Text = "Local:"
        '
        'XrTitulo
        '
        Me.XrTitulo.AutoWidth = True
        Me.XrTitulo.Dpi = 100.0!
        Me.XrTitulo.LocationFloat = New DevExpress.Utils.PointFloat(109.375!, 0!)
        Me.XrTitulo.Name = "XrTitulo"
        Me.XrTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTitulo.SizeF = New System.Drawing.SizeF(191.6666!, 23.0!)
        Me.XrTitulo.StylePriority.UseTextAlignment = False
        Me.XrTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 100.0!
        Me.TopMargin.HeightF = 14.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 100.0!
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XR_CODIGO_ENTEL_CONSUMO
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(100, 367, 14, 100)
        Me.Version = "16.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrTitulo As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrMensaje As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrProducto As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrCodigoEntel As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents XrLocal As DevExpress.XtraReports.UI.XRLabel
End Class
