<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentosVentaEdicionDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentosVentaEdicionDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardarCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnanterior = New DevExpress.XtraBars.BarButtonItem()
        Me.btnsiguiente = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFecha = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDocumento = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDetalle = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtImporteSubTotal = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.lblNumero = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRuc = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTipoDocumento = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporteImpuesto1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImporteTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCliente = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtImporteImpuesto2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGuardar, Me.btnGuardarCerrar, Me.btnCerrar, Me.btnanterior, Me.btnsiguiente, Me.btnFecha, Me.btnDocumento, Me.btnDetalle})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 14
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(850, 143)
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar"
        Me.btnGuardar.Glyph = CType(resources.GetObject("btnGuardar.Glyph"), System.Drawing.Image)
        Me.btnGuardar.Id = 1
        Me.btnGuardar.LargeGlyph = CType(resources.GetObject("btnGuardar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardar.Name = "btnGuardar"
        '
        'btnGuardarCerrar
        '
        Me.btnGuardarCerrar.Caption = "Guardar y Cerrar"
        Me.btnGuardarCerrar.Glyph = CType(resources.GetObject("btnGuardarCerrar.Glyph"), System.Drawing.Image)
        Me.btnGuardarCerrar.Id = 2
        Me.btnGuardarCerrar.LargeGlyph = CType(resources.GetObject("btnGuardarCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardarCerrar.Name = "btnGuardarCerrar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 3
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnanterior
        '
        Me.btnanterior.Caption = "Anterior"
        Me.btnanterior.Id = 4
        Me.btnanterior.Name = "btnanterior"
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Caption = "Siguiente"
        Me.btnsiguiente.Id = 5
        Me.btnsiguiente.Name = "btnsiguiente"
        '
        'btnFecha
        '
        Me.btnFecha.Caption = "Fecha"
        Me.btnFecha.Id = 8
        Me.btnFecha.LargeGlyph = Global.MC.AdministracionTienda.My.Resources.Resources.Calendario32
        Me.btnFecha.Name = "btnFecha"
        '
        'btnDocumento
        '
        Me.btnDocumento.Caption = "Documento"
        Me.btnDocumento.Id = 9
        Me.btnDocumento.LargeGlyph = Global.MC.AdministracionTienda.My.Resources.Resources.Contabilidad
        Me.btnDocumento.Name = "btnDocumento"
        '
        'btnDetalle
        '
        Me.btnDetalle.Caption = "Detalle"
        Me.btnDetalle.Id = 10
        Me.btnDetalle.LargeGlyph = Global.MC.AdministracionTienda.My.Resources.Resources.Equipos32
        Me.btnDetalle.Name = "btnDetalle"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Nota de Crédito"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardarCerrar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnFecha, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDocumento)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDetalle)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Formulario"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(6, 236)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(832, 188)
        Me.GridControl1.TabIndex = 73
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ViewCaption = "Detalle de Documento"
        '
        'txtImporteSubTotal
        '
        Me.txtImporteSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteSubTotal.Location = New System.Drawing.Point(738, 431)
        Me.txtImporteSubTotal.Name = "txtImporteSubTotal"
        Me.txtImporteSubTotal.ReadOnly = True
        Me.txtImporteSubTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtImporteSubTotal.TabIndex = 72
        Me.txtImporteSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(650, 434)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(75, 16)
        Me.label16.TabIndex = 71
        Me.label16.Text = "Sub Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Fecha"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblFecha.Location = New System.Drawing.Point(59, 148)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(149, 17)
        Me.lblFecha.TabIndex = 75
        Me.lblFecha.Text = "LabelControl1"
        '
        'lblNumero
        '
        Me.lblNumero.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNumero.Appearance.Options.UseFont = True
        Me.lblNumero.Appearance.Options.UseForeColor = True
        Me.lblNumero.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblNumero.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblNumero.Location = New System.Drawing.Point(641, 148)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(112, 19)
        Me.lblNumero.TabIndex = 77
        Me.lblNumero.Text = "F000125454545"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(543, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "N° DOCUMENTO"
        '
        'lblRuc
        '
        Me.lblRuc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblRuc.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblRuc.Location = New System.Drawing.Point(59, 171)
        Me.lblRuc.Name = "lblRuc"
        Me.lblRuc.Size = New System.Drawing.Size(148, 17)
        Me.lblRuc.TabIndex = 79
        Me.lblRuc.Text = "LabelControl3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Cliente"
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTipoDocumento.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblTipoDocumento.Location = New System.Drawing.Point(641, 173)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(112, 17)
        Me.lblTipoDocumento.TabIndex = 81
        Me.lblTipoDocumento.Text = "LabelControl4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(543, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Tipo Documento"
        '
        'txtImporteImpuesto1
        '
        Me.txtImporteImpuesto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteImpuesto1.Location = New System.Drawing.Point(738, 457)
        Me.txtImporteImpuesto1.Name = "txtImporteImpuesto1"
        Me.txtImporteImpuesto1.ReadOnly = True
        Me.txtImporteImpuesto1.Size = New System.Drawing.Size(100, 22)
        Me.txtImporteImpuesto1.TabIndex = 83
        Me.txtImporteImpuesto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(650, 460)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Impuesto 1"
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteTotal.Location = New System.Drawing.Point(738, 513)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.ReadOnly = True
        Me.txtImporteTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtImporteTotal.TabIndex = 85
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(650, 516)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Total"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCliente.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lblCliente.Location = New System.Drawing.Point(59, 194)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(418, 17)
        Me.lblCliente.TabIndex = 86
        Me.lblCliente.Text = "LabelControl5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(6, 217)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(832, 19)
        Me.Panel1.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(356, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Detalle de Documento"
        '
        'txtImporteImpuesto2
        '
        Me.txtImporteImpuesto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteImpuesto2.Location = New System.Drawing.Point(738, 485)
        Me.txtImporteImpuesto2.Name = "txtImporteImpuesto2"
        Me.txtImporteImpuesto2.ReadOnly = True
        Me.txtImporteImpuesto2.Size = New System.Drawing.Size(100, 22)
        Me.txtImporteImpuesto2.TabIndex = 90
        Me.txtImporteImpuesto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(650, 488)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 16)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Impuesto 2"
        '
        'DocumentosVentaEdicionDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 547)
        Me.Controls.Add(Me.txtImporteImpuesto2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.txtImporteTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtImporteImpuesto1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTipoDocumento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRuc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtImporteSubTotal)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "DocumentosVentaEdicionDetails"
        Me.Ribbon = Me.RibbonControl
        Me.Text = "DocumentosVentaEdicionDetails"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardarCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnanterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnsiguiente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents txtImporteSubTotal As TextBox
    Private WithEvents label16 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNumero As DevExpress.XtraEditors.LabelControl
    Private WithEvents Label1 As Label
    Friend WithEvents lblRuc As DevExpress.XtraEditors.LabelControl
    Private WithEvents Label3 As Label
    Friend WithEvents lblTipoDocumento As DevExpress.XtraEditors.LabelControl
    Private WithEvents Label4 As Label
    Private WithEvents txtImporteImpuesto1 As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents txtImporteTotal As TextBox
    Private WithEvents Label6 As Label
    Friend WithEvents lblCliente As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnFecha As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDocumento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDetalle As DevExpress.XtraBars.BarButtonItem
    Private WithEvents txtImporteImpuesto2 As TextBox
    Private WithEvents Label8 As Label
End Class
