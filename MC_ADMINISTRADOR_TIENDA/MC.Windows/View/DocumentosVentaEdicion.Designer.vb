<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocumentosVentaEdicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocumentosVentaEdicion))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grupoFecha = New System.Windows.Forms.GroupBox()
        Me.grupoCorrelativo = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdbFecha = New System.Windows.Forms.RadioButton()
        Me.rdbCorrelativo = New System.Windows.Forms.RadioButton()
        Me.txtPrefijoD = New DevExpress.XtraEditors.TextEdit()
        Me.txtSerieD = New DevExpress.XtraEditors.TextEdit()
        Me.txtCorrelativoD = New DevExpress.XtraEditors.TextEdit()
        Me.dtpFechaNueva = New DevExpress.XtraEditors.DateEdit()
        Me.txtDocumentoOrigen = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.grupoFecha.SuspendLayout()
        Me.grupoCorrelativo.SuspendLayout()
        CType(Me.txtPrefijoD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerieD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorrelativoD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaNueva.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaNueva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocumentoOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(676, 143)
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 326)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(676, 31)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblFecha)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.txtDocumentoOrigen)
        Me.GroupControl1.Controls.Add(Me.grupoFecha)
        Me.GroupControl1.Controls.Add(Me.grupoCorrelativo)
        Me.GroupControl1.Controls.Add(Me.rdbFecha)
        Me.GroupControl1.Controls.Add(Me.rdbCorrelativo)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 143)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(676, 183)
        Me.GroupControl1.TabIndex = 2
        '
        'grupoFecha
        '
        Me.grupoFecha.Controls.Add(Me.Label6)
        Me.grupoFecha.Controls.Add(Me.dtpFechaNueva)
        Me.grupoFecha.Enabled = False
        Me.grupoFecha.Location = New System.Drawing.Point(387, 88)
        Me.grupoFecha.Name = "grupoFecha"
        Me.grupoFecha.Size = New System.Drawing.Size(247, 67)
        Me.grupoFecha.TabIndex = 20
        Me.grupoFecha.TabStop = False
        '
        'grupoCorrelativo
        '
        Me.grupoCorrelativo.Controls.Add(Me.Label1)
        Me.grupoCorrelativo.Controls.Add(Me.txtCorrelativoD)
        Me.grupoCorrelativo.Controls.Add(Me.txtSerieD)
        Me.grupoCorrelativo.Controls.Add(Me.txtPrefijoD)
        Me.grupoCorrelativo.Controls.Add(Me.Label5)
        Me.grupoCorrelativo.Controls.Add(Me.Label4)
        Me.grupoCorrelativo.Controls.Add(Me.Label2)
        Me.grupoCorrelativo.Location = New System.Drawing.Point(12, 88)
        Me.grupoCorrelativo.Name = "grupoCorrelativo"
        Me.grupoCorrelativo.Size = New System.Drawing.Size(356, 67)
        Me.grupoCorrelativo.TabIndex = 16
        Me.grupoCorrelativo.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(261, 19)
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
        Me.Label4.Location = New System.Drawing.Point(202, 19)
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
        Me.Label2.Location = New System.Drawing.Point(139, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Prefijo"
        '
        'rdbFecha
        '
        Me.rdbFecha.AutoSize = True
        Me.rdbFecha.Location = New System.Drawing.Point(387, 58)
        Me.rdbFecha.Name = "rdbFecha"
        Me.rdbFecha.Size = New System.Drawing.Size(54, 17)
        Me.rdbFecha.TabIndex = 15
        Me.rdbFecha.Text = "Fecha"
        Me.rdbFecha.UseVisualStyleBackColor = True
        '
        'rdbCorrelativo
        '
        Me.rdbCorrelativo.AutoSize = True
        Me.rdbCorrelativo.Checked = True
        Me.rdbCorrelativo.Location = New System.Drawing.Point(12, 58)
        Me.rdbCorrelativo.Name = "rdbCorrelativo"
        Me.rdbCorrelativo.Size = New System.Drawing.Size(78, 17)
        Me.rdbCorrelativo.TabIndex = 15
        Me.rdbCorrelativo.TabStop = True
        Me.rdbCorrelativo.Text = "Correlativo"
        Me.rdbCorrelativo.UseVisualStyleBackColor = True
        '
        'txtPrefijoD
        '
        Me.txtPrefijoD.Location = New System.Drawing.Point(134, 36)
        Me.txtPrefijoD.MenuManager = Me.RibbonControl
        Me.txtPrefijoD.Name = "txtPrefijoD"
        Me.txtPrefijoD.Size = New System.Drawing.Size(54, 20)
        Me.txtPrefijoD.TabIndex = 22
        '
        'txtSerieD
        '
        Me.txtSerieD.Location = New System.Drawing.Point(194, 36)
        Me.txtSerieD.MenuManager = Me.RibbonControl
        Me.txtSerieD.Name = "txtSerieD"
        Me.txtSerieD.Size = New System.Drawing.Size(54, 20)
        Me.txtSerieD.TabIndex = 23
        '
        'txtCorrelativoD
        '
        Me.txtCorrelativoD.Location = New System.Drawing.Point(254, 35)
        Me.txtCorrelativoD.MenuManager = Me.RibbonControl
        Me.txtCorrelativoD.Name = "txtCorrelativoD"
        Me.txtCorrelativoD.Size = New System.Drawing.Size(96, 20)
        Me.txtCorrelativoD.TabIndex = 24
        '
        'dtpFechaNueva
        '
        Me.dtpFechaNueva.EditValue = Nothing
        Me.dtpFechaNueva.Location = New System.Drawing.Point(101, 32)
        Me.dtpFechaNueva.MenuManager = Me.RibbonControl
        Me.dtpFechaNueva.Name = "dtpFechaNueva"
        Me.dtpFechaNueva.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaNueva.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaNueva.Size = New System.Drawing.Size(130, 20)
        Me.dtpFechaNueva.TabIndex = 21
        '
        'txtDocumentoOrigen
        '
        Me.txtDocumentoOrigen.Location = New System.Drawing.Point(128, 32)
        Me.txtDocumentoOrigen.MenuManager = Me.RibbonControl
        Me.txtDocumentoOrigen.Name = "txtDocumentoOrigen"
        Me.txtDocumentoOrigen.Size = New System.Drawing.Size(234, 20)
        Me.txtDocumentoOrigen.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Documento Origen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(384, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Fecha Origen:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(470, 35)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(86, 13)
        Me.lblFecha.TabIndex = 24
        Me.lblFecha.Text = "Fecha Emisión"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Documento Destino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Fecha Destino"
        '
        'DocumentosVentaEdicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 357)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DocumentosVentaEdicion"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "DOCUMENTOS DE VENTA"
        Me.TopMost = True
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.grupoFecha.ResumeLayout(False)
        Me.grupoFecha.PerformLayout()
        Me.grupoCorrelativo.ResumeLayout(False)
        Me.grupoCorrelativo.PerformLayout()
        CType(Me.txtPrefijoD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerieD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorrelativoD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaNueva.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaNueva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocumentoOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grupoFecha As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFecha As System.Windows.Forms.RadioButton
    Friend WithEvents grupoCorrelativo As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbCorrelativo As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCorrelativoD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSerieD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrefijoD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpFechaNueva As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDocumentoOrigen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
End Class
