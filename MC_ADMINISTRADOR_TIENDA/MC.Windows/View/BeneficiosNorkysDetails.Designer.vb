<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeneficiosNorkysDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BeneficiosNorkysDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRegistrar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroDocumento = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtOrganizacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSituacionLaboral = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnBuscarTrabajador = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMensaje = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRegistrarConsumo = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAnio = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumeroPedido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrganizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSituacionLaboral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnRegistrar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(521, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 1
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Caption = "Registrar Beneficio"
        Me.btnRegistrar.Glyph = CType(resources.GetObject("btnRegistrar.Glyph"), System.Drawing.Image)
        Me.btnRegistrar.Id = 2
        Me.btnRegistrar.LargeGlyph = CType(resources.GetObject("btnRegistrar.LargeGlyph"), System.Drawing.Image)
        Me.btnRegistrar.Name = "btnRegistrar"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Beneficios Norkys"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 624)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(521, 31)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Numero documento"
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(109, 31)
        Me.txtNumeroDocumento.MenuManager = Me.RibbonControl
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtNumeroDocumento.TabIndex = 3
        '
        'txtNombres
        '
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(109, 67)
        Me.txtNombres.MenuManager = Me.RibbonControl
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(372, 20)
        Me.txtNombres.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Nombres"
        '
        'txtOrganizacion
        '
        Me.txtOrganizacion.Enabled = False
        Me.txtOrganizacion.Location = New System.Drawing.Point(109, 93)
        Me.txtOrganizacion.MenuManager = Me.RibbonControl
        Me.txtOrganizacion.Name = "txtOrganizacion"
        Me.txtOrganizacion.Size = New System.Drawing.Size(372, 20)
        Me.txtOrganizacion.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(3, 96)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Organización Laboral"
        '
        'txtSituacionLaboral
        '
        Me.txtSituacionLaboral.Enabled = False
        Me.txtSituacionLaboral.Location = New System.Drawing.Point(109, 119)
        Me.txtSituacionLaboral.MenuManager = Me.RibbonControl
        Me.txtSituacionLaboral.Name = "txtSituacionLaboral"
        Me.txtSituacionLaboral.Size = New System.Drawing.Size(100, 20)
        Me.txtSituacionLaboral.TabIndex = 11
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(3, 122)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Situación Laboral"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(7, 20)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(477, 192)
        Me.GridControl1.TabIndex = 12
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        '
        'btnBuscarTrabajador
        '
        Me.btnBuscarTrabajador.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarTrabajador.Appearance.Options.UseFont = True
        Me.btnBuscarTrabajador.Image = CType(resources.GetObject("btnBuscarTrabajador.Image"), System.Drawing.Image)
        Me.btnBuscarTrabajador.Location = New System.Drawing.Point(226, 20)
        Me.btnBuscarTrabajador.Name = "btnBuscarTrabajador"
        Me.btnBuscarTrabajador.Size = New System.Drawing.Size(152, 41)
        Me.btnBuscarTrabajador.TabIndex = 13
        Me.btnBuscarTrabajador.Text = "Buscar Trabajador"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMensaje)
        Me.GroupBox1.Controls.Add(Me.btnBuscarTrabajador)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.txtNumeroDocumento)
        Me.GroupBox1.Controls.Add(Me.txtSituacionLaboral)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.txtOrganizacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 179)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Trabajador"
        '
        'lblMensaje
        '
        Me.lblMensaje.Location = New System.Drawing.Point(3, 151)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(66, 13)
        Me.lblMensaje.TabIndex = 14
        Me.lblMensaje.Text = "LabelControl7"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRegistrarConsumo)
        Me.GroupBox2.Controls.Add(Me.txtAnio)
        Me.GroupBox2.Controls.Add(Me.txtNumeroPedido)
        Me.GroupBox2.Controls.Add(Me.LabelControl6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 318)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 76)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto Beneficio"
        '
        'btnRegistrarConsumo
        '
        Me.btnRegistrarConsumo.Image = CType(resources.GetObject("btnRegistrarConsumo.Image"), System.Drawing.Image)
        Me.btnRegistrarConsumo.Location = New System.Drawing.Point(230, 20)
        Me.btnRegistrarConsumo.Name = "btnRegistrarConsumo"
        Me.btnRegistrarConsumo.Size = New System.Drawing.Size(148, 35)
        Me.btnRegistrarConsumo.TabIndex = 77
        Me.btnRegistrarConsumo.Text = "Registrar Consumo"
        '
        'txtAnio
        '
        Me.txtAnio.Enabled = False
        Me.txtAnio.Location = New System.Drawing.Point(93, 26)
        Me.txtAnio.MenuManager = Me.RibbonControl
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Properties.MaxLength = 10
        Me.txtAnio.Size = New System.Drawing.Size(31, 20)
        Me.txtAnio.TabIndex = 76
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.Location = New System.Drawing.Point(130, 26)
        Me.txtNumeroPedido.MenuManager = Me.RibbonControl
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Properties.MaxLength = 8
        Me.txtNumeroPedido.Size = New System.Drawing.Size(94, 20)
        Me.txtNumeroPedido.TabIndex = 75
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 29)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "Codigo Pedido"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridControl1)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 218)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Beneficios Trabajador"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'BeneficiosNorkysDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 655)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "BeneficiosNorkysDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "BENEFICIOS NORKYS"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrganizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSituacionLaboral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOrganizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSituacionLaboral As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnRegistrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBuscarTrabajador As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblMensaje As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAnio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnRegistrarConsumo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
