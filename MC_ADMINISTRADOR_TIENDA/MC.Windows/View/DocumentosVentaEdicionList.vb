Imports MC.Framework
Imports DevExpress.XtraSplashScreen

Public Class DocumentosVentaEdicionList

    Dim bsComprobantes As New BindingSource
    Dim bsCaja As New BindingSource

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.


        Me.Text = "DOCUMENTOS DE VENTA"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False
        'Se inicializa el formulario y Se inicializa los controles generales
        btnFecha.EditValue = DateTime.Now
        btnDocumento.EditValue = ""

        Me.GridControl1.DataSource = bsComprobantes
        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")


        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)

        'Se configura el control GridView
        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DOCUMENTO", "TipoDocumento", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DOCUMENTO", "tDocumento", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA", "ffecha", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CLIENTE", "Cliente", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO DOCUMENTO", "estadoDocumento", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO", "nVenta", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "EnvioBizlinks", "EnvioBizlinks", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EstadoSunat", "EstadoSunat", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MensajeSunat", "MensajeSunat", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        'Configuar el dropdown de caja
        bsCaja.DataSource = CajaDao.GetByAll()

        'ControlesDevExpress.InitGridLookUpEdit(cboEstado, VentasEstadoDocumentoDAO.GetALLEstadoDocumento, "Codigo", "Descripcion", 600)
        'ControlesDevExpress.InitGridLookUpEditColumns(cboTipoReporte, "TIPO REPORTE", "TIPOREPORTE", 100)

        Dim Columna As New DevExpress.XtraGrid.Columns.GridColumn()
        With RepositoryItemGridLookUpEdit1
            .ValueMember = "tCaja"
            .DisplayMember = "tDescripcion"
            .ImmediatePopup = True
            .ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.Default
            .NullText = ""
            .PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        End With

        'Se configura la columna
        With Columna
            .Caption = "CAJA"
            .FieldName = "tDescripcion"
            .Name = "tDescripcion"
            .Visible = True
            .Width = 200
            .OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        'Se agrega la columna al GridLookUpEdit
        RepositoryItemGridLookUpEdit1.View.Columns.Add(Columna)

        RepositoryItemGridLookUpEdit1.DataSource = bsCaja
        cboCaja.EditValue = 0

        chkTodasCajas.Checked = True

        'Se configura eventos
        AddHandler GridView1.DoubleClick, AddressOf VerDetalleDocumento
        AddHandler btnCerrar.ItemClick, AddressOf Cerrar
    End Sub

    Public Sub VerDetalleDocumento()
        Try
            If GridView1.GetFocusedRowCellValue("tDocumento") <> "" Then
                'tTipoDocumentoSeleccionado = GridView1.GetFocusedRowCellValue("TipoDocumento")
                'tDocumentoSeleccionado = GridView1.GetFocusedRowCellValue("tDocumento")
                'fechaSeleccionado = GridView1.GetFocusedRowCellValue("ffecha")

                'Se muestra el comprobante
                DocumentoVentaDAO.tDocumento = GridView1.GetFocusedRowCellValue("tDocumento")

                Dim MiForm As New DocumentosVentaEdicionDetails
                MiForm.ShowDialog()
                cargarDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Cerrar()
        Me.Close()
    End Sub

    Private Sub DocumentoList_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Public Sub cargarDatos()
        SplashScreenManager.ShowForm(GetType(WaitForm))

        bsComprobantes.DataSource = SistemaDAO.GetDocumentosVenta(btnFecha.EditValue, btnDocumento.EditValue.ToString.Trim, IIf(chkTodasCajas.Checked, "000", cboCaja.EditValue))
        SplashScreenManager.CloseForm()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificar.ItemClick, btnCerrar.ItemClick
        Try
            Select Case e.Item.Caption
                Case "Modificar" : VerDetalleDocumento()
                Case "Cerrar" : Cerrar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCorrelativo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
        End If
    End Sub

    Private Sub btnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBuscar.ItemClick
        cargarDatos()
    End Sub

    Private Sub chkTodasCajas_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkTodasCajas.CheckedChanged
        cboCaja.Enabled = Not chkTodasCajas.Checked
    End Sub


End Class