<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromocionCodigoTickectDetails
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
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject17 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject18 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PromocionCodigoTickectDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DESASIGNAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonDesprocesar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLicenciaArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemCompromisoArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.txtAnio = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGrabar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNumeroPedido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoPromocion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAsignar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonDesprocesar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLicenciaArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCompromisoArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPromocion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 2
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(460, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Código Promoción"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 431)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(460, 31)
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(11, 228)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLicenciaArchivo, Me.RepositoryItemCompromisoArchivo, Me.RepositoryItemButtonDesprocesar})
        Me.GridControl1.Size = New System.Drawing.Size(437, 152)
        Me.GridControl1.TabIndex = 90
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.DESASIGNAR})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: [#image] {1} {2}"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "(Count={0})")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        '
        'DESASIGNAR
        '
        Me.DESASIGNAR.Caption = "DESASIGNAR"
        Me.DESASIGNAR.ColumnEdit = Me.RepositoryItemButtonDesprocesar
        Me.DESASIGNAR.FieldName = "DESASIGNAR"
        Me.DESASIGNAR.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.DESASIGNAR.Name = "DESASIGNAR"
        Me.DESASIGNAR.Visible = True
        Me.DESASIGNAR.VisibleIndex = 0
        Me.DESASIGNAR.Width = 90
        '
        'RepositoryItemButtonDesprocesar
        '
        Me.RepositoryItemButtonDesprocesar.AutoHeight = False
        Me.RepositoryItemButtonDesprocesar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemButtonDesprocesar.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject16, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonDesprocesar.Name = "RepositoryItemButtonDesprocesar"
        Me.RepositoryItemButtonDesprocesar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemLicenciaArchivo
        '
        Me.RepositoryItemLicenciaArchivo.AutoHeight = False
        Me.RepositoryItemLicenciaArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemLicenciaArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject17, "", Nothing, Nothing, True)})
        Me.RepositoryItemLicenciaArchivo.Name = "RepositoryItemLicenciaArchivo"
        Me.RepositoryItemLicenciaArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemCompromisoArchivo
        '
        Me.RepositoryItemCompromisoArchivo.AutoHeight = False
        Me.RepositoryItemCompromisoArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemCompromisoArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject18, "", Nothing, Nothing, True)})
        Me.RepositoryItemCompromisoArchivo.Name = "RepositoryItemCompromisoArchivo"
        Me.RepositoryItemCompromisoArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'txtAnio
        '
        Me.txtAnio.Enabled = False
        Me.txtAnio.Location = New System.Drawing.Point(76, 393)
        Me.txtAnio.MenuManager = Me.RibbonControl
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Properties.MaxLength = 10
        Me.txtAnio.Size = New System.Drawing.Size(31, 20)
        Me.txtAnio.TabIndex = 89
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(11, 190)
        Me.txtDescripcion.MenuManager = Me.RibbonControl
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(437, 31)
        Me.txtDescripcion.TabIndex = 88
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(285, 150)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 35)
        Me.btnConsultar.TabIndex = 87
        Me.btnConsultar.Text = "Buscar"
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.Location = New System.Drawing.Point(213, 386)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(92, 39)
        Me.btnGrabar.TabIndex = 86
        Me.btnGrabar.Text = "Grabar"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.Location = New System.Drawing.Point(113, 393)
        Me.txtNumeroPedido.MenuManager = Me.RibbonControl
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Properties.MaxLength = 8
        Me.txtNumeroPedido.Size = New System.Drawing.Size(94, 20)
        Me.txtNumeroPedido.TabIndex = 85
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(23, 396)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 84
        Me.LabelControl2.Text = "N° Pedido"
        '
        'txtCodigoPromocion
        '
        Me.txtCodigoPromocion.Location = New System.Drawing.Point(117, 157)
        Me.txtCodigoPromocion.MenuManager = Me.RibbonControl
        Me.txtCodigoPromocion.Name = "txtCodigoPromocion"
        Me.txtCodigoPromocion.Properties.MaxLength = 15
        Me.txtCodigoPromocion.Size = New System.Drawing.Size(151, 20)
        Me.txtCodigoPromocion.TabIndex = 83
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 160)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl1.TabIndex = 82
        Me.LabelControl1.Text = "N° Código Promoción"
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = CType(resources.GetObject("btnAsignar.Image"), System.Drawing.Image)
        Me.btnAsignar.Location = New System.Drawing.Point(366, 149)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(82, 35)
        Me.btnAsignar.TabIndex = 81
        Me.btnAsignar.Text = "Asignar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 1
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'PromocionCodigoTickectDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 462)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.txtNumeroPedido)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCodigoPromocion)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "PromocionCodigoTickectDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "PromocionCodigoDetails"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonDesprocesar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLicenciaArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCompromisoArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPromocion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DESASIGNAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonDesprocesar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLicenciaArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCompromisoArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents txtAnio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGrabar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNumeroPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoPromocion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAsignar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
