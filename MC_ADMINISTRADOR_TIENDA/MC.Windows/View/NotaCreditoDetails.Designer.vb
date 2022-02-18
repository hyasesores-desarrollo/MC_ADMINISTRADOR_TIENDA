<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotaCreditoDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotaCreditoDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardarCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnanterior = New DevExpress.XtraBars.BarButtonItem()
        Me.btnsiguiente = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAnular = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPublicar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.txtISC = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.grpCliente = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btnBuscarDocumento = New DevExpress.XtraEditors.SimpleButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFechaEmisionDocumento = New DevExpress.XtraEditors.DateEdit()
        Me.txtNroDocAfectado = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtNotaCredito = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cmbCajas = New System.Windows.Forms.ComboBox()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.txtIdentidadCliente = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.cmbDocIdentidad = New System.Windows.Forms.ComboBox()
        Me.txtImporteTotal = New System.Windows.Forms.TextBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.txtVentaIGV = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtVentaExonerada = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.txtOtrosCargos = New System.Windows.Forms.TextBox()
        Me.txtVentaInafecta = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.txtOtrosTributos = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.txtVentaGrabada = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNroNC = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.cmbMotivo = New System.Windows.Forms.ComboBox()
        Me.txtFechaEmision = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtFechaRegistro = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTurno = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.txtCajaEmision = New System.Windows.Forms.TextBox()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCliente.SuspendLayout()
        CType(Me.dtpFechaEmisionDocumento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEmisionDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGuardar, Me.btnGuardarCerrar, Me.btnCerrar, Me.btnanterior, Me.btnsiguiente, Me.btnAnular, Me.btnPublicar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(790, 143)
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar"
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Glyph = CType(resources.GetObject("btnGuardar.Glyph"), System.Drawing.Image)
        Me.btnGuardar.Id = 1
        Me.btnGuardar.LargeGlyph = CType(resources.GetObject("btnGuardar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        'btnAnular
        '
        Me.btnAnular.Caption = "Anular"
        Me.btnAnular.Glyph = CType(resources.GetObject("btnAnular.Glyph"), System.Drawing.Image)
        Me.btnAnular.Id = 6
        Me.btnAnular.LargeGlyph = CType(resources.GetObject("btnAnular.LargeGlyph"), System.Drawing.Image)
        Me.btnAnular.Name = "btnAnular"
        '
        'btnPublicar
        '
        Me.btnPublicar.Caption = "Publicar"
        Me.btnPublicar.Enabled = False
        Me.btnPublicar.Glyph = CType(resources.GetObject("btnPublicar.Glyph"), System.Drawing.Image)
        Me.btnPublicar.Id = 7
        Me.btnPublicar.LargeGlyph = CType(resources.GetObject("btnPublicar.LargeGlyph"), System.Drawing.Image)
        Me.btnPublicar.Name = "btnPublicar"
        Me.btnPublicar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAnular)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnPublicar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Formulario"
        '
        'txtISC
        '
        Me.txtISC.Location = New System.Drawing.Point(366, 537)
        Me.txtISC.Name = "txtISC"
        Me.txtISC.ReadOnly = True
        Me.txtISC.Size = New System.Drawing.Size(100, 21)
        Me.txtISC.TabIndex = 53
        Me.txtISC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(262, 542)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(51, 13)
        Me.label17.TabIndex = 52
        Me.label17.Text = "Total ISC"
        '
        'grpCliente
        '
        Me.grpCliente.Controls.Add(Me.Label20)
        Me.grpCliente.Controls.Add(Me.btnBuscarDocumento)
        Me.grpCliente.Controls.Add(Me.Label22)
        Me.grpCliente.Controls.Add(Me.dtpFechaEmisionDocumento)
        Me.grpCliente.Controls.Add(Me.txtNroDocAfectado)
        Me.grpCliente.Controls.Add(Me.label4)
        Me.grpCliente.Controls.Add(Me.txtNotaCredito)
        Me.grpCliente.Controls.Add(Me.Label19)
        Me.grpCliente.Controls.Add(Me.label1)
        Me.grpCliente.Controls.Add(Me.cmbCajas)
        Me.grpCliente.Controls.Add(Me.cmbTipoDocumento)
        Me.grpCliente.Controls.Add(Me.txtNombreCliente)
        Me.grpCliente.Controls.Add(Me.txtIdentidadCliente)
        Me.grpCliente.Controls.Add(Me.label8)
        Me.grpCliente.Controls.Add(Me.label6)
        Me.grpCliente.Controls.Add(Me.cmbDocIdentidad)
        Me.grpCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCliente.Location = New System.Drawing.Point(4, 207)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Size = New System.Drawing.Size(774, 115)
        Me.grpCliente.TabIndex = 49
        Me.grpCliente.TabStop = False
        Me.grpCliente.Text = "Documento Afectado"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 13)
        Me.Label20.TabIndex = 79
        Me.Label20.Text = "Fecha de Emisión"
        '
        'btnBuscarDocumento
        '
        Me.btnBuscarDocumento.Image = CType(resources.GetObject("btnBuscarDocumento.Image"), System.Drawing.Image)
        Me.btnBuscarDocumento.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBuscarDocumento.Location = New System.Drawing.Point(526, 51)
        Me.btnBuscarDocumento.Name = "btnBuscarDocumento"
        Me.btnBuscarDocumento.Size = New System.Drawing.Size(33, 23)
        Me.btnBuscarDocumento.TabIndex = 78
        Me.btnBuscarDocumento.Text = "SimpleButton1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(526, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(116, 13)
        Me.Label22.TabIndex = 77
        Me.Label22.Text = "Monto Nota Crédito"
        Me.Label22.Visible = False
        '
        'dtpFechaEmisionDocumento
        '
        Me.dtpFechaEmisionDocumento.EditValue = Nothing
        Me.dtpFechaEmisionDocumento.Enabled = False
        Me.dtpFechaEmisionDocumento.Location = New System.Drawing.Point(110, 53)
        Me.dtpFechaEmisionDocumento.Name = "dtpFechaEmisionDocumento"
        Me.dtpFechaEmisionDocumento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEmisionDocumento.Properties.Appearance.Options.UseFont = True
        Me.dtpFechaEmisionDocumento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaEmisionDocumento.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaEmisionDocumento.Size = New System.Drawing.Size(150, 20)
        Me.dtpFechaEmisionDocumento.TabIndex = 75
        '
        'txtNroDocAfectado
        '
        Me.txtNroDocAfectado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroDocAfectado.Location = New System.Drawing.Point(382, 52)
        Me.txtNroDocAfectado.Name = "txtNroDocAfectado"
        Me.txtNroDocAfectado.ReadOnly = True
        Me.txtNroDocAfectado.Size = New System.Drawing.Size(138, 21)
        Me.txtNroDocAfectado.TabIndex = 73
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(266, 56)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 13)
        Me.label4.TabIndex = 72
        Me.label4.Text = "Documento"
        '
        'txtNotaCredito
        '
        Me.txtNotaCredito.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaCredito.Location = New System.Drawing.Point(649, 22)
        Me.txtNotaCredito.MaxLength = 3
        Me.txtNotaCredito.Name = "txtNotaCredito"
        Me.txtNotaCredito.Size = New System.Drawing.Size(106, 21)
        Me.txtNotaCredito.TabIndex = 32
        Me.txtNotaCredito.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(266, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Caja"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(5, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(99, 13)
        Me.label1.TabIndex = 28
        Me.label1.Text = "Tipo Documento"
        '
        'cmbCajas
        '
        Me.cmbCajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCajas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCajas.FormattingEnabled = True
        Me.cmbCajas.Location = New System.Drawing.Point(382, 21)
        Me.cmbCajas.Name = "cmbCajas"
        Me.cmbCajas.Size = New System.Drawing.Size(138, 22)
        Me.cmbCajas.TabIndex = 27
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(110, 23)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(150, 22)
        Me.cmbTipoDocumento.TabIndex = 27
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(382, 85)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(373, 21)
        Me.txtNombreCliente.TabIndex = 3
        '
        'txtIdentidadCliente
        '
        Me.txtIdentidadCliente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentidadCliente.Location = New System.Drawing.Point(161, 85)
        Me.txtIdentidadCliente.Name = "txtIdentidadCliente"
        Me.txtIdentidadCliente.ReadOnly = True
        Me.txtIdentidadCliente.Size = New System.Drawing.Size(99, 21)
        Me.txtIdentidadCliente.TabIndex = 3
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(266, 88)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(110, 13)
        Me.label8.TabIndex = 1
        Me.label8.Text = "Nombre/Rz. Social"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(5, 88)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(89, 13)
        Me.label6.TabIndex = 1
        Me.label6.Text = "Doc. Identidad"
        '
        'cmbDocIdentidad
        '
        Me.cmbDocIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDocIdentidad.Enabled = False
        Me.cmbDocIdentidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDocIdentidad.FormattingEnabled = True
        Me.cmbDocIdentidad.Location = New System.Drawing.Point(110, 85)
        Me.cmbDocIdentidad.Name = "cmbDocIdentidad"
        Me.cmbDocIdentidad.Size = New System.Drawing.Size(50, 21)
        Me.cmbDocIdentidad.TabIndex = 0
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteTotal.Location = New System.Drawing.Point(677, 562)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.ReadOnly = True
        Me.txtImporteTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtImporteTotal.TabIndex = 47
        Me.txtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label16.Location = New System.Drawing.Point(561, 564)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(100, 16)
        Me.label16.TabIndex = 40
        Me.label16.Text = "Importe Total"
        '
        'txtVentaIGV
        '
        Me.txtVentaIGV.Location = New System.Drawing.Point(366, 511)
        Me.txtVentaIGV.Name = "txtVentaIGV"
        Me.txtVentaIGV.ReadOnly = True
        Me.txtVentaIGV.Size = New System.Drawing.Size(100, 21)
        Me.txtVentaIGV.TabIndex = 46
        Me.txtVentaIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(262, 514)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(51, 13)
        Me.label13.TabIndex = 39
        Me.label13.Text = "Total IGV"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(677, 537)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(100, 21)
        Me.txtDescuento.TabIndex = 45
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVentaExonerada
        '
        Me.txtVentaExonerada.Location = New System.Drawing.Point(135, 563)
        Me.txtVentaExonerada.Name = "txtVentaExonerada"
        Me.txtVentaExonerada.ReadOnly = True
        Me.txtVentaExonerada.Size = New System.Drawing.Size(100, 21)
        Me.txtVentaExonerada.TabIndex = 42
        Me.txtVentaExonerada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(561, 542)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(85, 13)
        Me.label15.TabIndex = 41
        Me.label15.Text = "Total Descuento"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(5, 566)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(117, 13)
        Me.label12.TabIndex = 38
        Me.label12.Text = "Total Venta Exonerada"
        '
        'txtOtrosCargos
        '
        Me.txtOtrosCargos.Location = New System.Drawing.Point(677, 511)
        Me.txtOtrosCargos.Name = "txtOtrosCargos"
        Me.txtOtrosCargos.ReadOnly = True
        Me.txtOtrosCargos.Size = New System.Drawing.Size(100, 21)
        Me.txtOtrosCargos.TabIndex = 43
        Me.txtOtrosCargos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVentaInafecta
        '
        Me.txtVentaInafecta.Location = New System.Drawing.Point(135, 537)
        Me.txtVentaInafecta.Name = "txtVentaInafecta"
        Me.txtVentaInafecta.ReadOnly = True
        Me.txtVentaInafecta.Size = New System.Drawing.Size(100, 21)
        Me.txtVentaInafecta.TabIndex = 44
        Me.txtVentaInafecta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(561, 515)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(98, 13)
        Me.label14.TabIndex = 37
        Me.label14.Text = "Total Otros Cargos"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(5, 540)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(106, 13)
        Me.label11.TabIndex = 36
        Me.label11.Text = "Total Venta Inafecta"
        '
        'txtOtrosTributos
        '
        Me.txtOtrosTributos.Location = New System.Drawing.Point(366, 563)
        Me.txtOtrosTributos.Name = "txtOtrosTributos"
        Me.txtOtrosTributos.ReadOnly = True
        Me.txtOtrosTributos.Size = New System.Drawing.Size(100, 21)
        Me.txtOtrosTributos.TabIndex = 35
        Me.txtOtrosTributos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(262, 567)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(98, 13)
        Me.label7.TabIndex = 33
        Me.label7.Text = "Total Otro Tributos"
        '
        'txtVentaGrabada
        '
        Me.txtVentaGrabada.Location = New System.Drawing.Point(135, 511)
        Me.txtVentaGrabada.Name = "txtVentaGrabada"
        Me.txtVentaGrabada.ReadOnly = True
        Me.txtVentaGrabada.Size = New System.Drawing.Size(100, 21)
        Me.txtVentaGrabada.TabIndex = 34
        Me.txtVentaGrabada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(5, 515)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(111, 13)
        Me.label10.TabIndex = 32
        Me.label10.Text = "Total Venta Grabadas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nota de Crédito"
        '
        'txtNroNC
        '
        Me.txtNroNC.BackColor = System.Drawing.SystemColors.Control
        Me.txtNroNC.Enabled = False
        Me.txtNroNC.Location = New System.Drawing.Point(114, 147)
        Me.txtNroNC.Name = "txtNroNC"
        Me.txtNroNC.Size = New System.Drawing.Size(150, 21)
        Me.txtNroNC.TabIndex = 58
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(270, 150)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(39, 13)
        Me.label9.TabIndex = 60
        Me.label9.Text = "Motivo"
        '
        'cmbMotivo
        '
        Me.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotivo.FormattingEnabled = True
        Me.cmbMotivo.Items.AddRange(New Object() {"Devolución total"})
        Me.cmbMotivo.Location = New System.Drawing.Point(386, 147)
        Me.cmbMotivo.Name = "cmbMotivo"
        Me.cmbMotivo.Size = New System.Drawing.Size(172, 21)
        Me.cmbMotivo.TabIndex = 0
        '
        'txtFechaEmision
        '
        Me.txtFechaEmision.Location = New System.Drawing.Point(386, 178)
        Me.txtFechaEmision.Name = "txtFechaEmision"
        Me.txtFechaEmision.ReadOnly = True
        Me.txtFechaEmision.Size = New System.Drawing.Size(172, 21)
        Me.txtFechaEmision.TabIndex = 66
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(270, 181)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(89, 13)
        Me.label5.TabIndex = 65
        Me.label5.Text = "Fecha de Emisión"
        '
        'txtFechaRegistro
        '
        Me.txtFechaRegistro.Location = New System.Drawing.Point(114, 178)
        Me.txtFechaRegistro.Name = "txtFechaRegistro"
        Me.txtFechaRegistro.ReadOnly = True
        Me.txtFechaRegistro.Size = New System.Drawing.Size(150, 21)
        Me.txtFechaRegistro.TabIndex = 64
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(5, 181)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(94, 13)
        Me.label3.TabIndex = 63
        Me.label3.Text = "Fecha de Registro"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(4, 328)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(774, 172)
        Me.GridControl1.TabIndex = 70
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(567, 151)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 13)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Caja de Emisión"
        '
        'txtTurno
        '
        Me.txtTurno.Location = New System.Drawing.Point(653, 178)
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.ReadOnly = True
        Me.txtTurno.Size = New System.Drawing.Size(124, 21)
        Me.txtTurno.TabIndex = 76
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.label18.Location = New System.Drawing.Point(567, 181)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(79, 13)
        Me.label18.TabIndex = 75
        Me.label18.Text = "Turno Actual"
        '
        'txtCajaEmision
        '
        Me.txtCajaEmision.Location = New System.Drawing.Point(653, 148)
        Me.txtCajaEmision.Name = "txtCajaEmision"
        Me.txtCajaEmision.ReadOnly = True
        Me.txtCajaEmision.Size = New System.Drawing.Size(124, 21)
        Me.txtCajaEmision.TabIndex = 76
        '
        'NotaCreditoDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(790, 595)
        Me.Controls.Add(Me.txtCajaEmision)
        Me.Controls.Add(Me.txtTurno)
        Me.Controls.Add(Me.label18)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtFechaEmision)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtFechaRegistro)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.cmbMotivo)
        Me.Controls.Add(Me.txtNroNC)
        Me.Controls.Add(Me.txtISC)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.grpCliente)
        Me.Controls.Add(Me.txtImporteTotal)
        Me.Controls.Add(Me.label16)
        Me.Controls.Add(Me.txtVentaIGV)
        Me.Controls.Add(Me.label13)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtVentaExonerada)
        Me.Controls.Add(Me.label15)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.txtOtrosCargos)
        Me.Controls.Add(Me.txtVentaInafecta)
        Me.Controls.Add(Me.label14)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.txtOtrosTributos)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.txtVentaGrabada)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NotaCreditoDetails"
        Me.Ribbon = Me.RibbonControl
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NotaCreditoDetails"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCliente.ResumeLayout(False)
        Me.grpCliente.PerformLayout()
        CType(Me.dtpFechaEmisionDocumento.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEmisionDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txtISC As System.Windows.Forms.TextBox
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents grpCliente As System.Windows.Forms.GroupBox
    Private WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Private WithEvents txtIdentidadCliente As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents cmbDocIdentidad As System.Windows.Forms.ComboBox
    Private WithEvents txtImporteTotal As System.Windows.Forms.TextBox
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents txtVentaIGV As System.Windows.Forms.TextBox
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents txtDescuento As System.Windows.Forms.TextBox
    Private WithEvents txtVentaExonerada As System.Windows.Forms.TextBox
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents txtOtrosCargos As System.Windows.Forms.TextBox
    Private WithEvents txtVentaInafecta As System.Windows.Forms.TextBox
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents txtOtrosTributos As System.Windows.Forms.TextBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents txtVentaGrabada As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNroNC As System.Windows.Forms.TextBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents cmbMotivo As System.Windows.Forms.ComboBox
    Private WithEvents txtFechaEmision As System.Windows.Forms.TextBox
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtFechaRegistro As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAnular As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPublicar As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEmisionDocumento As DevExpress.XtraEditors.DateEdit
    Private WithEvents txtNroDocAfectado As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents txtTurno As System.Windows.Forms.TextBox
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents txtNotaCredito As System.Windows.Forms.TextBox
    Private WithEvents txtCajaEmision As System.Windows.Forms.TextBox
    Private WithEvents cmbCajas As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscarDocumento As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label20 As Label

End Class
