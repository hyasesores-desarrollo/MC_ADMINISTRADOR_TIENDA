<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MotorizadoDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MotorizadoDetails))
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardarCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnanterior = New DevExpress.XtraBars.BarButtonItem()
        Me.btnsiguiente = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.chkActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdni = New DevExpress.XtraEditors.TextEdit()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.Datos = New DevExpress.XtraTab.XtraTabPage()
        Me.sleTipoComision = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridViewTipoComision = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cboTipoMotorizado = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cboMotorizado = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.Datos.SuspendLayout()
        CType(Me.sleTipoComision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewTipoComision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoMotorizado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMotorizado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(5, 35)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(125, 14)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "Motorizado-Corporativo"
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGuardar, Me.btnGuardarCerrar, Me.btnCerrar, Me.btnanterior, Me.btnsiguiente})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(698, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
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
        Me.btnanterior.Glyph = CType(resources.GetObject("btnanterior.Glyph"), System.Drawing.Image)
        Me.btnanterior.Id = 4
        Me.btnanterior.LargeGlyph = CType(resources.GetObject("btnanterior.LargeGlyph"), System.Drawing.Image)
        Me.btnanterior.Name = "btnanterior"
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Caption = "Siguiente"
        Me.btnsiguiente.Glyph = CType(resources.GetObject("btnsiguiente.Glyph"), System.Drawing.Image)
        Me.btnsiguiente.Id = 5
        Me.btnsiguiente.LargeGlyph = CType(resources.GetObject("btnsiguiente.LargeGlyph"), System.Drawing.Image)
        Me.btnsiguiente.Name = "btnsiguiente"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Motorizados"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Formulario"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnanterior)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnsiguiente)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Registros"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 341)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(698, 31)
        '
        'chkActivo
        '
        Me.chkActivo.Location = New System.Drawing.Point(561, 7)
        Me.chkActivo.MenuManager = Me.RibbonControl
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Properties.Appearance.Options.UseFont = True
        Me.chkActivo.Properties.Caption = "Activo"
        Me.chkActivo.Size = New System.Drawing.Size(75, 19)
        Me.chkActivo.TabIndex = 13
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(551, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(20, 14)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "DNI"
        '
        'txtdni
        '
        Me.txtdni.Enabled = False
        Me.txtdni.Location = New System.Drawing.Point(577, 32)
        Me.txtdni.MenuManager = Me.RibbonControl
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Properties.MaxLength = 10
        Me.txtdni.Size = New System.Drawing.Size(104, 20)
        Me.txtdni.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 143)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.Datos
        Me.XtraTabControl1.Size = New System.Drawing.Size(698, 198)
        Me.XtraTabControl1.TabIndex = 5
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Datos})
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.sleTipoComision)
        Me.Datos.Controls.Add(Me.LabelControl8)
        Me.Datos.Controls.Add(Me.cboTipoMotorizado)
        Me.Datos.Controls.Add(Me.LabelControl4)
        Me.Datos.Controls.Add(Me.txtDescripcion)
        Me.Datos.Controls.Add(Me.LabelControl6)
        Me.Datos.Controls.Add(Me.cboMotorizado)
        Me.Datos.Controls.Add(Me.LabelControl7)
        Me.Datos.Controls.Add(Me.chkActivo)
        Me.Datos.Controls.Add(Me.LabelControl1)
        Me.Datos.Controls.Add(Me.txtdni)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(692, 170)
        Me.Datos.Text = "Datos"
        '
        'sleTipoComision
        '
        Me.sleTipoComision.Location = New System.Drawing.Point(139, 83)
        Me.sleTipoComision.Name = "sleTipoComision"
        Me.sleTipoComision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.sleTipoComision.Properties.NullText = "[Seleccione]"
        Me.sleTipoComision.Properties.View = Me.GridViewTipoComision
        Me.sleTipoComision.Size = New System.Drawing.Size(395, 20)
        Me.sleTipoComision.TabIndex = 140
        '
        'GridViewTipoComision
        '
        Me.GridViewTipoComision.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridViewTipoComision.Name = "GridViewTipoComision"
        Me.GridViewTipoComision.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridViewTipoComision.OptionsView.ShowGroupPanel = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(5, 85)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 14)
        Me.LabelControl8.TabIndex = 138
        Me.LabelControl8.Text = "Tipo Comisión"
        '
        'cboTipoMotorizado
        '
        Me.cboTipoMotorizado.EditValue = "[Vacio]"
        Me.cboTipoMotorizado.Location = New System.Drawing.Point(139, 7)
        Me.cboTipoMotorizado.MenuManager = Me.RibbonControl
        Me.cboTipoMotorizado.Name = "cboTipoMotorizado"
        Me.cboTipoMotorizado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoMotorizado.Properties.View = Me.GridView1
        Me.cboTipoMotorizado.Size = New System.Drawing.Size(395, 20)
        Me.cboTipoMotorizado.TabIndex = 137
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(5, 9)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(87, 14)
        Me.LabelControl4.TabIndex = 136
        Me.LabelControl4.Text = "Tipo Motorizado"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(139, 57)
        Me.txtDescripcion.MenuManager = Me.RibbonControl
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.MaxLength = 25
        Me.txtDescripcion.Size = New System.Drawing.Size(395, 20)
        Me.txtDescripcion.TabIndex = 134
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(5, 60)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(106, 14)
        Me.LabelControl6.TabIndex = 133
        Me.LabelControl6.Text = "Nombre Motorizado"
        '
        'cboMotorizado
        '
        Me.cboMotorizado.EditValue = "[Vacio]"
        Me.cboMotorizado.Location = New System.Drawing.Point(139, 32)
        Me.cboMotorizado.MenuManager = Me.RibbonControl
        Me.cboMotorizado.Name = "cboMotorizado"
        Me.cboMotorizado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMotorizado.Properties.View = Me.SearchLookUpEdit1View
        Me.cboMotorizado.Size = New System.Drawing.Size(395, 20)
        Me.cboMotorizado.TabIndex = 18
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'MotorizadoDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 372)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "MotorizadoDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "MotorizadoDetails"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        CType(Me.sleTipoComision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewTipoComision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoMotorizado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMotorizado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardarCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnanterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnsiguiente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents chkActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Datos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cboMotorizado As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipoMotorizado As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sleTipoComision As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents GridViewTipoComision As DevExpress.XtraGrid.Views.Grid.GridView
End Class
