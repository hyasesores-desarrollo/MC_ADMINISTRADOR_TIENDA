<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesktopMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesktopMain))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.btnComputadora = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFechaHora = New DevExpress.XtraBars.BarButtonItem()
        Me.rgbiSkins = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.btnFuente = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEmpresa = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTipoCambio = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLocal = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage7 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GalleryDropDown1 = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        CType(Me.RibbonControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GalleryDropDown1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ImageCollection1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnUsuario, Me.btnComputadora, Me.btnFechaHora, Me.rgbiSkins, Me.btnFuente, Me.btnEmpresa, Me.btnTipoCambio, Me.btnLocal})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonControl.MaxItemId = 12
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage7})
        Me.RibbonControl.Size = New System.Drawing.Size(772, 155)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Salir del programa"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"),System.Drawing.Image)
        Me.btnCerrar.Id = 2
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"),System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnUsuario
        '
        Me.btnUsuario.Caption = "Usuario"
        Me.btnUsuario.Glyph = CType(resources.GetObject("btnUsuario.Glyph"),System.Drawing.Image)
        Me.btnUsuario.Id = 3
        Me.btnUsuario.Name = "btnUsuario"
        '
        'btnComputadora
        '
        Me.btnComputadora.Caption = "Computadora"
        Me.btnComputadora.Glyph = CType(resources.GetObject("btnComputadora.Glyph"),System.Drawing.Image)
        Me.btnComputadora.Id = 4
        Me.btnComputadora.Name = "btnComputadora"
        '
        'btnFechaHora
        '
        Me.btnFechaHora.Caption = "FechaHora"
        Me.btnFechaHora.Glyph = CType(resources.GetObject("btnFechaHora.Glyph"),System.Drawing.Image)
        Me.btnFechaHora.Id = 5
        Me.btnFechaHora.Name = "btnFechaHora"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Caption = "SkinRibbonGalleryBarItem1"
        Me.rgbiSkins.Id = 6
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'btnFuente
        '
        Me.btnFuente.Caption = "Fuente"
        Me.btnFuente.Glyph = CType(resources.GetObject("btnFuente.Glyph"),System.Drawing.Image)
        Me.btnFuente.Id = 7
        Me.btnFuente.LargeGlyph = CType(resources.GetObject("btnFuente.LargeGlyph"),System.Drawing.Image)
        Me.btnFuente.Name = "btnFuente"
        '
        'btnEmpresa
        '
        Me.btnEmpresa.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnEmpresa.Caption = "Empresa"
        Me.btnEmpresa.Id = 8
        Me.btnEmpresa.Name = "btnEmpresa"
        '
        'btnTipoCambio
        '
        Me.btnTipoCambio.Caption = "Tipo de Cambio"
        Me.btnTipoCambio.Glyph = CType(resources.GetObject("btnTipoCambio.Glyph"),System.Drawing.Image)
        Me.btnTipoCambio.Id = 10
        Me.btnTipoCambio.Name = "btnTipoCambio"
        Me.btnTipoCambio.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnLocal
        '
        Me.btnLocal.Caption = "Local"
        Me.btnLocal.Glyph = CType(resources.GetObject("btnLocal.Glyph"),System.Drawing.Image)
        Me.btnLocal.Id = 11
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'RibbonPage7
        '
        Me.RibbonPage7.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage7.Name = "RibbonPage7"
        Me.RibbonPage7.Text = "Sistema"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rgbiSkins)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnFuente)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Operaciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.btnUsuario)
        Me.RibbonStatusBar.ItemLinks.Add(Me.btnComputadora)
        Me.RibbonStatusBar.ItemLinks.Add(Me.btnLocal, "F8")
        Me.RibbonStatusBar.ItemLinks.Add(Me.btnFechaHora)
        Me.RibbonStatusBar.ItemLinks.Add(Me.btnTipoCambio)
        Me.RibbonStatusBar.ItemLinks.Add(Me.btnEmpresa)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 572)
        Me.RibbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(772, 31)
        '
        'GalleryDropDown1
        '
        Me.GalleryDropDown1.Name = "GalleryDropDown1"
        Me.GalleryDropDown1.Ribbon = Me.RibbonControl
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"),DevExpress.Utils.ImageCollectionStreamer)
        '
        'DesktopMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 603)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "DesktopMain"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "DesktopMain"
        CType(Me.RibbonControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GalleryDropDown1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ImageCollection1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPage7 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnComputadora As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFechaHora As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GalleryDropDown1 As DevExpress.XtraBars.Ribbon.GalleryDropDown
    Friend WithEvents rgbiSkins As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents btnFuente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents btnEmpresa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTipoCambio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLocal As DevExpress.XtraBars.BarButtonItem


End Class
