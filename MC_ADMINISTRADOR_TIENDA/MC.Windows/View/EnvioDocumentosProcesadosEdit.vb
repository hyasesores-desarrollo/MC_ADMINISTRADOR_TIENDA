Imports DevExpress.XtraGrid.Views.Grid
Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraGrid.Views.Base

Public Class EnvioDocumentosProcesadosEdit

    Dim bsDocumentos As New BindingSource

    Dim DocumentoProcesadoBE As New DocumentoProcesadoBE
    Dim DocumentoBE As New DocumentoBE
    Dim NotaCreditoBE As New NotaCreditoBE

    Public Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'DETALLE DOCUMENTO
        ControlesDevExpress.InitGridControl(GridControl2)
        ControlesDevExpress.InitGridView(GridView4, False, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "IDITEM", "Item", 50, False)
        ControlesDevExpress.InitGridViewColumn(GridView4, "ARTICULO", "Articulo", 260, True)
        ControlesDevExpress.InitGridViewColumn(GridView4, "UNIDAD", "UnidadMedida", 60, True)
        ControlesDevExpress.InitGridViewColumn(GridView4, "CANTIDAD", "Cantidad", 80, True, ControlesDevExpress.eGridViewFormato.Numero)
        ControlesDevExpress.InitGridViewColumn(GridView4, "PRECIO", "Precio", 80, True, ControlesDevExpress.eGridViewFormato.Numero)
        ControlesDevExpress.InitGridViewColumn(GridView4, "VALOR VENTA", "ValorVenta", 80, True, ControlesDevExpress.eGridViewFormato.Numero)


        'DETALLE NOTA CREDITO
        ControlesDevExpress.InitGridControl(GridControl4)
        ControlesDevExpress.InitGridView(GridView8, False, False)
        ControlesDevExpress.InitGridViewColumn(GridView8, "IDITEM", "nItem", 50, False)
        ControlesDevExpress.InitGridViewColumn(GridView8, "ARTICULO", "Articulo", 140, True)
        ControlesDevExpress.InitGridViewColumn(GridView8, "UNIDAD", "UnidadMedida", 80, True)
        ControlesDevExpress.InitGridViewColumn(GridView8, "CANTIDAD.ORIGINAL", "Cantidad", 140, True, ControlesDevExpress.eGridViewFormato.Numero)
        ControlesDevExpress.InitGridViewColumn(GridView8, "PRECIO", "Precio", 100, True, ControlesDevExpress.eGridViewFormato.Numero)
        ControlesDevExpress.InitGridViewColumn(GridView8, "TOTAL", "Total", 100, True, ControlesDevExpress.eGridViewFormato.Numero)
        ControlesDevExpress.InitGridViewColumn(GridView8, "CANTIDAD.DESCONTAR", "CantidadDescontar", 140, True, ControlesDevExpress.eGridViewFormato.Numero, True)
        ControlesDevExpress.InitGridViewColumn(GridView8, "TOTAL.DESCUENTO", "TotalDescuento", 120, True, ControlesDevExpress.eGridViewFormato.Numero)


        'Se configura el formato
        ControlesDevExpress.TextEditFormat(txtPercepcion, ControlesDevExpress.eTextEditFormat.Fixed2D)
        ControlesDevExpress.TextEditFormat(txtDetraccion, ControlesDevExpress.eTextEditFormat.Fixed2D)
        ControlesDevExpress.TextEditFormat(txtSubTotal, ControlesDevExpress.eTextEditFormat.Fixed2D)
        ControlesDevExpress.TextEditFormat(txtDescuento, ControlesDevExpress.eTextEditFormat.Fixed2D)
        ControlesDevExpress.TextEditFormat(txtValorIGV, ControlesDevExpress.eTextEditFormat.Fixed2D)
        ControlesDevExpress.TextEditFormat(txtValorISC, ControlesDevExpress.eTextEditFormat.Fixed2D)
        ControlesDevExpress.TextEditFormat(txtTotal, ControlesDevExpress.eTextEditFormat.Fixed2D)
        ControlesDevExpress.TextEditFormat(txtRedondeoDocumento, ControlesDevExpress.eTextEditFormat.Fixed2D)



        'DOCUMENTOS
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDENVIODETALLE", "IDENVIODETALLE", 90, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CORRELATIVODOCUMENTO", "CORRELATIVODOCUMENTO", 110, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDTIPODOCUMENTO", "IDTIPODOCUMENTO", 120, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DOCUMENTO", "TIPODOCUMENTO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DOCUMENTO", "NUMERODOCUMENTO", 110, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PROVEEDOR", "PROVEEDOR", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RUC", "RUC", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TOTAL", "TOTAL", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)

        With GridView1
            .Columns("TIPODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TOTAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnSeleccionar.EditValue = True

        Me.GridControl1.DataSource = bsDocumentos

        Refrescar()

    End Sub

    Public Sub Refrescar()
        Try
            ActualizarEdicionGrilla()

            bsDocumentos.DataSource = DocumentoDAO.GetByEnvioDocumentoListadoDetalleIdEnvio(DocumentoDAO.IDEnvio)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEnviar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEnviar.ItemClick
        ActualizarEdicionGrilla()

        If MessageBox.Show("¿Esta seguro de enviar el archivo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            DocumentoDAO.EnviarDocumentoProcesado(DocumentoDAO.IDEnvio)

            Me.Close()
        End If

    End Sub

    Private Sub btnAnexar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAnexar.ItemClick
        ActualizarEdicionGrilla()

        Dim MiForm As New EnvioDocumentosAnexar
        MiForm.ShowDialog()

        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        ActualizarEdicionGrilla()

        Me.Close()
    End Sub

    Private Sub ActualizarEdicionGrilla()
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()

        GridView1.ClearColumnsFilter()
        GridView1.FindFilterText = ""
    End Sub

    Private Sub GridView1_RowUpdated(sender As Object, e As RowObjectEventArgs) Handles GridView1.RowUpdated
        Cursor = Cursors.WaitCursor

        Dim IDENVIODETALLE As Int32
        Dim ESTADOASIGNACION As Boolean

        IDENVIODETALLE = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "IDENVIODETALLE")
        ESTADOASIGNACION = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ASIGNAR")

        DocumentoDAO.UpdateAsignacionDocumentoProcesadoDetalle(IDENVIODETALLE, ESTADOASIGNACION)

        Cursor = Cursors.Default
    End Sub

    Private Sub RepositoryItemCheckEditSeleccionar_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEditSeleccionar.EditValueChanged
        If sender.checked Then
            bsDocumentos.DataSource = DocumentoDAO.GetByEnvioDocumentoListadoDetalleIdEnvioAsignar(DocumentoDAO.IDEnvio, True)
        Else
            bsDocumentos.DataSource = DocumentoDAO.GetByEnvioDocumentoListadoDetalleIdEnvioAsignar(DocumentoDAO.IDEnvio, False)
        End If
    End Sub

    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick
        Detalle()
    End Sub

    Private Sub GridView1_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged

        If GridView1.RowCount > 0 Then
            Detalle()
        End If
    End Sub

    Private Sub Detalle()

        Try
            Dim NumeroDocumento As String
            NumeroDocumento = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")

            If NumeroDocumento Is Nothing Then
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            'NOTAS DE CREDITO
            If GridView1.GetFocusedRowCellValue("IDTIPODOCUMENTO") = "07" Then
                DatosNC.PageVisible = True
                Datos.PageVisible = False

                'NotaCreditoBE = DocumentoDAO.GetByIDNotaCredito(NumeroDocumento)

                'With NotaCreditoBE
                '    txtNotaCredito.Text = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")
                '    txtProveedorNC.Text = GridView1.GetFocusedRowCellValue("PROVEEDOR")
                '    txtRucNC.Text = GridView1.GetFocusedRowCellValue("RUC")

                '    txtTipoNotaCredito.Text = .TipoNotaCredito
                '    dtFechaNC.EditValue = .Fecha

                '    txtDocumentoReferencia.Text = .NumeroDocumentoReferencia
                '    txtTotalDocumento.Text = .TotalDocumento
                '    txtTotalDocumentoNC.Text = .TotalNotaCredito
                '    txtNetoNC.Text = .NetoNotaCredito
                '    txtIgvNC.Text = .IgvNotaCredito
                '    txtObservacionNC.Text = .Observacion
                'End With

                GridControl4.DataSource = NotaCreditoBE.ItemsDetalle



            Else 'DOCUMENTOS
                DatosNC.PageVisible = False
                Datos.PageVisible = True

                DocumentoBE = DocumentoDAO.GetByIDDocumento(NumeroDocumento)

                With DocumentoBE
                    txtDocumento.Text = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")
                    txtProveedor.Text = GridView1.GetFocusedRowCellValue("PROVEEDOR")
                    txtRuc.Text = GridView1.GetFocusedRowCellValue("RUC")
                    txtGlosa.Text = .Glosa

                    dtFechaDocumento.EditValue = .FechaEmision
                    txtMonedaDocumento.Text = .Moneda
                    txtValorIGV.Text = .Impuesto1
                    txtValorISC.Text = .Impuesto2
                    txtSubTotal.Text = .Neto
                    txtTotal.Text = .Total
                    txtDescuento.Text = .Descuento
                    txtDetraccion.Text = .Detraccion
                    txtPercepcion.Text = .Percepcion
                    txtRedondeoDocumento.Text = .Redondeo
                End With

                GridControl2.DataSource = DocumentoBE.Items
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception

        End Try

    End Sub

End Class