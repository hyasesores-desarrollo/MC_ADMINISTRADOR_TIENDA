<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentosVentaEdicionItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentosVentaEdicionItem))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.gruFecha = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaNueva = New DevExpress.XtraEditors.DateEdit()
        Me.gruDocumento = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDocumento = New DevExpress.XtraEditors.LabelControl()
        Me.gruProducto = New System.Windows.Forms.GroupBox()
        Me.txtPrecioNuevo = New DevExpress.XtraEditors.SpinEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblProducto = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCorrelativoD = New DevExpress.XtraEditors.TextEdit()
        Me.txtSerieD = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrefijoD = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPrecio = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruFecha.SuspendLayout()
        CType(Me.dtpFechaNueva.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaNueva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gruDocumento.SuspendLayout()
        Me.gruProducto.SuspendLayout()
        CType(Me.txtPrecioNuevo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorrelativoD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrefijoD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGuardar, Me.BtnCancelar, Me.btnCerrar, Me.btnEditar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(671, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar y Cerrar"
        Me.btnGuardar.Glyph = CType(resources.GetObject("btnGuardar.Glyph"), System.Drawing.Image)
        Me.btnGuardar.Id = 1
        Me.btnGuardar.LargeGlyph = CType(resources.GetObject("btnGuardar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardar.Name = "btnGuardar"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Caption = "Cancelar"
        Me.BtnCancelar.Glyph = CType(resources.GetObject("BtnCancelar.Glyph"), System.Drawing.Image)
        Me.BtnCancelar.Id = 2
        Me.BtnCancelar.LargeGlyph = CType(resources.GetObject("BtnCancelar.LargeGlyph"), System.Drawing.Image)
        Me.BtnCancelar.Name = "BtnCancelar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 3
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnEditar
        '
        Me.btnEditar.Caption = "Editar Documento"
        Me.btnEditar.Glyph = CType(resources.GetObject("btnEditar.Glyph"), System.Drawing.Image)
        Me.btnEditar.Id = 4
        Me.btnEditar.LargeGlyph = CType(resources.GetObject("btnEditar.LargeGlyph"), System.Drawing.Image)
        Me.btnEditar.Name = "btnEditar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Modificar Documento"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 245)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(671, 31)
        '
        'gruFecha
        '
        Me.gruFecha.Controls.Add(Me.Label8)
        Me.gruFecha.Controls.Add(Me.lblFecha)
        Me.gruFecha.Controls.Add(Me.Label1)
        Me.gruFecha.Controls.Add(Me.dtpFechaNueva)
        Me.gruFecha.Location = New System.Drawing.Point(282, 151)
        Me.gruFecha.Name = "gruFecha"
        Me.gruFecha.Size = New System.Drawing.Size(227, 74)
        Me.gruFecha.TabIndex = 4
        Me.gruFecha.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(6, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Fecha"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblFecha.Location = New System.Drawing.Point(66, 19)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(129, 21)
        Me.lblFecha.TabIndex = 79
        Me.lblFecha.Text = "LabelControl2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Fecha"
        '
        'dtpFechaNueva
        '
        Me.dtpFechaNueva.EditValue = Nothing
        Me.dtpFechaNueva.Location = New System.Drawing.Point(66, 48)
        Me.dtpFechaNueva.MenuManager = Me.RibbonControl
        Me.dtpFechaNueva.Name = "dtpFechaNueva"
        Me.dtpFechaNueva.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaNueva.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaNueva.Size = New System.Drawing.Size(130, 20)
        Me.dtpFechaNueva.TabIndex = 22
        '
        'gruDocumento
        '
        Me.gruDocumento.Controls.Add(Me.Label7)
        Me.gruDocumento.Controls.Add(Me.lblDocumento)
        Me.gruDocumento.Controls.Add(Me.txtCorrelativoD)
        Me.gruDocumento.Controls.Add(Me.txtSerieD)
        Me.gruDocumento.Controls.Add(Me.txtPrefijoD)
        Me.gruDocumento.Controls.Add(Me.Label5)
        Me.gruDocumento.Controls.Add(Me.Label4)
        Me.gruDocumento.Controls.Add(Me.Label2)
        Me.gruDocumento.Location = New System.Drawing.Point(15, 149)
        Me.gruDocumento.Name = "gruDocumento"
        Me.gruDocumento.Size = New System.Drawing.Size(261, 84)
        Me.gruDocumento.TabIndex = 24
        Me.gruDocumento.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Documento"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblDocumento.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblDocumento.Location = New System.Drawing.Point(80, 15)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(168, 21)
        Me.lblDocumento.TabIndex = 77
        Me.lblDocumento.Text = "LabelControl1"
        '
        'gruProducto
        '
        Me.gruProducto.Controls.Add(Me.lblPrecio)
        Me.gruProducto.Controls.Add(Me.Label9)
        Me.gruProducto.Controls.Add(Me.txtPrecioNuevo)
        Me.gruProducto.Controls.Add(Me.Label6)
        Me.gruProducto.Controls.Add(Me.lblProducto)
        Me.gruProducto.Controls.Add(Me.Label3)
        Me.gruProducto.Location = New System.Drawing.Point(32, 115)
        Me.gruProducto.Name = "gruProducto"
        Me.gruProducto.Size = New System.Drawing.Size(582, 84)
        Me.gruProducto.TabIndex = 25
        Me.gruProducto.TabStop = False
        '
        'txtPrecioNuevo
        '
        Me.txtPrecioNuevo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecioNuevo.Location = New System.Drawing.Point(252, 49)
        Me.txtPrecioNuevo.MenuManager = Me.RibbonControl
        Me.txtPrecioNuevo.Name = "txtPrecioNuevo"
        Me.txtPrecioNuevo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPrecioNuevo.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtPrecioNuevo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtPrecioNuevo.Size = New System.Drawing.Size(122, 20)
        Me.txtPrecioNuevo.TabIndex = 78
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(188, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Precio"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblProducto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblProducto.Location = New System.Drawing.Point(79, 21)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(443, 21)
        Me.lblProducto.TabIndex = 76
        Me.lblProducto.Text = "LabelControl1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(15, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Producto"
        '
        'txtCorrelativoD
        '
        Me.txtCorrelativoD.Location = New System.Drawing.Point(129, 57)
        Me.txtCorrelativoD.MenuManager = Me.RibbonControl
        Me.txtCorrelativoD.Name = "txtCorrelativoD"
        Me.txtCorrelativoD.Size = New System.Drawing.Size(96, 20)
        Me.txtCorrelativoD.TabIndex = 24
        '
        'txtSerieD
        '
        Me.txtSerieD.Location = New System.Drawing.Point(69, 58)
        Me.txtSerieD.MenuManager = Me.RibbonControl
        Me.txtSerieD.Name = "txtSerieD"
        Me.txtSerieD.Size = New System.Drawing.Size(54, 20)
        Me.txtSerieD.TabIndex = 23
        '
        'txtPrefijoD
        '
        Me.txtPrefijoD.Location = New System.Drawing.Point(9, 58)
        Me.txtPrefijoD.MenuManager = Me.RibbonControl
        Me.txtPrefijoD.Name = "txtPrefijoD"
        Me.txtPrefijoD.Size = New System.Drawing.Size(54, 20)
        Me.txtPrefijoD.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(136, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Correlativo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(77, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Serie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Prefijo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(15, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Precio"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPrecio.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblPrecio.Location = New System.Drawing.Point(79, 49)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(108, 21)
        Me.lblPrecio.TabIndex = 80
        Me.lblPrecio.Text = "LabelControl1"
        '
        'DocumentosVentaEdicionItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 276)
        Me.Controls.Add(Me.gruProducto)
        Me.Controls.Add(Me.gruDocumento)
        Me.Controls.Add(Me.gruFecha)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "DocumentosVentaEdicionItem"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "DocumentosVentaEdicionItem"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruFecha.ResumeLayout(False)
        Me.gruFecha.PerformLayout()
        CType(Me.dtpFechaNueva.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaNueva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gruDocumento.ResumeLayout(False)
        Me.gruDocumento.PerformLayout()
        Me.gruProducto.ResumeLayout(False)
        Me.gruProducto.PerformLayout()
        CType(Me.txtPrecioNuevo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorrelativoD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrefijoD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents gruFecha As GroupBox
    Friend WithEvents dtpFechaNueva As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents gruDocumento As GroupBox
    Friend WithEvents txtCorrelativoD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSerieD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrefijoD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gruProducto As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecioNuevo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents lblProducto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As Label
    Friend WithEvents lblDocumento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPrecio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As Label
End Class
