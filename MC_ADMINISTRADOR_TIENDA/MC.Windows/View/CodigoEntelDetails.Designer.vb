<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodigoEntelDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodigoEntelDetails))
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RepositoryItemArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.btnGrabar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNumeroPedido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoEntel = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAsignar = New DevExpress.XtraEditors.SimpleButton()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.btnConsultar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.txtAnio = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DESASIGNAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonDesprocesar = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLicenciaArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemCompromisoArchivo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.RepositoryItemArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoEntel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonDesprocesar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLicenciaArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCompromisoArchivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemArchivo
        '
        Me.RepositoryItemArchivo.AutoHeight = False
        Me.RepositoryItemArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, "", Nothing, Nothing, True)})
        Me.RepositoryItemArchivo.Name = "RepositoryItemArchivo"
        Me.RepositoryItemArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnCerrar, Me.btnImprimir})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 3
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(407, 143)
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
        'btnImprimir
        '
        Me.btnImprimir.Caption = "Imprimir"
        Me.btnImprimir.Glyph = CType(resources.GetObject("btnImprimir.Glyph"), System.Drawing.Image)
        Me.btnImprimir.Id = 2
        Me.btnImprimir.LargeGlyph = CType(resources.GetObject("btnImprimir.LargeGlyph"), System.Drawing.Image)
        Me.btnImprimir.Name = "btnImprimir"
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
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 434)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(407, 31)
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = CType(resources.GetObject("btnGrabar.Image"), System.Drawing.Image)
        Me.btnGrabar.Location = New System.Drawing.Point(214, 387)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(92, 39)
        Me.btnGrabar.TabIndex = 27
        Me.btnGrabar.Text = "Grabar"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.Location = New System.Drawing.Point(114, 394)
        Me.txtNumeroPedido.MenuManager = Me.RibbonControl
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Properties.MaxLength = 8
        Me.txtNumeroPedido.Size = New System.Drawing.Size(94, 20)
        Me.txtNumeroPedido.TabIndex = 26
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 397)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 25
        Me.LabelControl2.Text = "N° Pedido"
        '
        'txtCodigoEntel
        '
        Me.txtCodigoEntel.Location = New System.Drawing.Point(118, 158)
        Me.txtCodigoEntel.MenuManager = Me.RibbonControl
        Me.txtCodigoEntel.Name = "txtCodigoEntel"
        Me.txtCodigoEntel.Properties.MaxLength = 8
        Me.txtCodigoEntel.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigoEntel.TabIndex = 24
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 161)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "N° Código Promoción"
        '
        'btnAsignar
        '
        Me.btnAsignar.Image = CType(resources.GetObject("btnAsignar.Image"), System.Drawing.Image)
        Me.btnAsignar.Location = New System.Drawing.Point(313, 149)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(82, 35)
        Me.btnAsignar.TabIndex = 22
        Me.btnAsignar.Text = "Asignar"
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = CType(resources.GetObject("btnConsultar.Image"), System.Drawing.Image)
        Me.btnConsultar.Location = New System.Drawing.Point(232, 150)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 35)
        Me.btnConsultar.TabIndex = 30
        Me.btnConsultar.Text = "Buscar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 191)
        Me.txtDescripcion.MenuManager = Me.RibbonControl
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(383, 31)
        Me.txtDescripcion.TabIndex = 71
        '
        'txtAnio
        '
        Me.txtAnio.Enabled = False
        Me.txtAnio.Location = New System.Drawing.Point(77, 394)
        Me.txtAnio.MenuManager = Me.RibbonControl
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Properties.MaxLength = 10
        Me.txtAnio.Size = New System.Drawing.Size(31, 20)
        Me.txtAnio.TabIndex = 74
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(12, 229)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLicenciaArchivo, Me.RepositoryItemCompromisoArchivo, Me.RepositoryItemButtonDesprocesar})
        Me.GridControl1.Size = New System.Drawing.Size(383, 152)
        Me.GridControl1.TabIndex = 80
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
        Me.RepositoryItemButtonDesprocesar.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemButtonDesprocesar.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject10, "", Nothing, Nothing, True)})
        Me.RepositoryItemButtonDesprocesar.Name = "RepositoryItemButtonDesprocesar"
        Me.RepositoryItemButtonDesprocesar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemLicenciaArchivo
        '
        Me.RepositoryItemLicenciaArchivo.AutoHeight = False
        Me.RepositoryItemLicenciaArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemLicenciaArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject11, "", Nothing, Nothing, True)})
        Me.RepositoryItemLicenciaArchivo.Name = "RepositoryItemLicenciaArchivo"
        Me.RepositoryItemLicenciaArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemCompromisoArchivo
        '
        Me.RepositoryItemCompromisoArchivo.AutoHeight = False
        Me.RepositoryItemCompromisoArchivo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("RepositoryItemCompromisoArchivo.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject12, "", Nothing, Nothing, True)})
        Me.RepositoryItemCompromisoArchivo.Name = "RepositoryItemCompromisoArchivo"
        Me.RepositoryItemCompromisoArchivo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'CodigoEntelDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 465)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.txtNumeroPedido)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtCodigoEntel)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "CodigoEntelDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "CodigoEntelDetails"
        CType(Me.RepositoryItemArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoEntel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonDesprocesar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLicenciaArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCompromisoArchivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGrabar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNumeroPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoEntel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAsignar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents btnConsultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtAnio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DESASIGNAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonDesprocesar As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLicenciaArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemCompromisoArchivo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btnImprimir As DevExpress.XtraBars.BarButtonItem
End Class
