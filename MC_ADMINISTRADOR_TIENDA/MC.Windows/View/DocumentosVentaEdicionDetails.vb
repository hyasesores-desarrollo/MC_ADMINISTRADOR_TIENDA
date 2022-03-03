Imports MC.Framework
Imports MC.Data

Public Class DocumentosVentaEdicionDetails

    Dim DocumentoVentaBE As New DocumentoVentaBE
    Dim dtProducto As New DataTable

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.Text = " DOCUMENTO DE VENTA"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False

        ControlesDevExpress.InitGridControl(GridControl1)

        'Se configura el control GridView
        ControlesDevExpress.InitGridView(GridView1, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "tCodigoProducto", 60, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PRODUCTO", "Producto", 270, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PRECIO", "nPrecioNeto", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CANTIDAD", "nCantidad", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SUBTOTAL", "SubTotal", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IGV", "nImpuesto1", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RECARGA POR CONSUMO", "nImpuesto2", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TOTAL", "nVenta", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)

        LoadDocumento()

        AddHandler GridView1.DoubleClick, AddressOf Detalle
    End Sub

    Public Sub LoadDocumento()
        Try
            DocumentoVentaBE = DocumentoVentaDAO.GetByID(DocumentoVentaDAO.tDocumento)

            With DocumentoVentaBE
                lblFecha.Text = .FechaEmision
                lblCliente.Text = .Cliente
                lblRuc.Text = .Ruc
                lblTipoDocumento.Text = .TipoDocumento
                lblNumero.Text = .NumeroDocumento

                txtImporteSubTotal.Text = .SubTotal
                txtImporteImpuesto1.Text = .Impuesto1
                txtImporteImpuesto2.Text = .Impuesto2
                txtImporteTotal.Text = .Total
            End With

            CreaDataTable()
            dtProducto = DocumentoVentaDAO.GetDetalleByID(DocumentoVentaDAO.tDocumento)
            GridControl1.DataSource = dtProducto

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DocumentosVentaEdicionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFecha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFecha.ItemClick
        DocumentoVentaDAO.FlagOpc = "F"
        DocumentoVentaDAO.Valor = lblFecha.Text

        Dim MiForm As New DocumentosVentaEdicionItem
        MiForm.ShowDialog()

        lblFecha.Text = DocumentoVentaDAO.Valor
    End Sub

    Private Sub btnDocumento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDocumento.ItemClick
        DocumentoVentaDAO.FlagOpc = "D"
        DocumentoVentaDAO.Valor = lblNumero.Text

        Dim MiForm As New DocumentosVentaEdicionItem
        MiForm.ShowDialog()

        lblNumero.Text = DocumentoVentaDAO.Valor

    End Sub

    Private Sub btnDetalle_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDetalle.ItemClick
        Detalle()
    End Sub

    Sub Detalle()
        DocumentoVentaDAO.FlagOpc = "P"
        DocumentoVentaDAO.Valor = GridView1.GetFocusedRowCellValue("nVenta").ToString()
        DocumentoVentaDAO.IDProducto = GridView1.GetFocusedRowCellValue("tCodigoProducto")
        DocumentoVentaDAO.Producto = GridView1.GetFocusedRowCellValue("Producto")
        DocumentoVentaDAO.tCodigoPedido = GridView1.GetFocusedRowCellValue("tCodigoPedido")

        Dim MiForm As New DocumentosVentaEdicionItem
        MiForm.ShowDialog()
        Dim factor_base_imponible As Double
        Dim myRow() As DataRow
        myRow = dtProducto.Select("tCodigoProducto = " + DocumentoVentaDAO.IDProducto.ToString())
        myRow(0)("nVenta") = DocumentoVentaDAO.Valor
        If (ParametroDAO.GetImpuesto2_por_producto(DocumentoVentaDAO.IDProducto, DocumentoVentaDAO.tCodigoPedido)) Then
            factor_base_imponible = Format(1 + (ParametroDAO.GetIGV + ParametroDAO.GetRecargoxConsumo) / 100, "###,###,###0.00")
            myRow(0)("SubTotal") = Format(DocumentoVentaDAO.Valor / factor_base_imponible, "###,###,###0.00")
            myRow(0)("nImpuesto2") = Format((Convert.ToDouble(myRow(0)("SubTotal")) * ParametroDAO.GetRecargoxConsumo / 100), "###,###,###0.00")
        Else
            factor_base_imponible = Format(1 + (ParametroDAO.GetIGV) / 100, "###,###,###0.00")
            myRow(0)("SubTotal") = Format(DocumentoVentaDAO.Valor / factor_base_imponible, "###,###,###0.00")
            myRow(0)("nImpuesto2") = Format(0, "###,###,###0.00")
        End If

        myRow(0)("nPrecioNeto") = Format(Convert.ToDouble(myRow(0)("SubTotal")) / Convert.ToDouble(myRow(0)("nCantidad")), "###,###,###0.00")
        myRow(0)("nImpuesto1") = Format((Convert.ToDouble(myRow(0)("SubTotal")) * ParametroDAO.GetIGV / 100), "###,###,###0.00")


        dtProducto.AcceptChanges()

        SumaTotal()
    End Sub

    Sub CreaDataTable()
        With dtProducto.Columns
            .Add("tDocumento", GetType(String))
            .Add("tCodigoProducto", GetType(Integer))
            .Add("Producto", GetType(String))
            .Add("nPrecioNeto", GetType(Double))
            .Add("nCantidad", GetType(Double))
            .Add("SubTotal", GetType(Double))
            .Add("nImpuesto1", GetType(String))
            .Add("nImpuesto2", GetType(String))
            .Add("nVenta", GetType(Double))
        End With
    End Sub

    Private Sub btnGuardarCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardarCerrar.ItemClick
        If MessageBox.Show("Seguro de Actualizar los datos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Me.Validar() Then
                Dim detalle_documento_totales As New DataTable
                For i As Integer = 0 To GridView1.DataRowCount - 1
                    detalle_documento_totales = DocumentoVentaDAO.SaveDetalle(DocumentoVentaDAO.tDocumento, GridView1.GetRowCellValue(i, "tCodigoProducto").ToString, GridView1.GetRowCellValue(i, "nVenta").ToString, ParametroDAO.GetImpuesto2_por_producto(GridView1.GetRowCellValue(i, "tCodigoProducto").ToString, GridView1.GetRowCellValue(i, "tCodigoPedido").ToString))
                Next i
                DocumentoVentaDAO.Save(DocumentoVentaBE, detalle_documento_totales)

                'Elimina el documento en la replicada si es que el documento es nuevo
                If (DocumentoVentaBE.NumeroDocumento <> DocumentoVentaBE.NumeroDocumentoNew And IdLocal > 0) Then
                    DocumentoVentaDAO.DeleteReplica(IdLocal, DocumentoVentaBE.NumeroDocumento)
                End If

                Me.Close()
            Else
                MessageBox.Show("El numero de documento " + DocumentoVentaBE.NumeroDocumentoNew + " ya existe en el sistema")
            End If

        End If
    End Sub

    Public Sub GuardarCerrar()

    End Sub

    Public Function Validar() As Boolean
        Dim Result As Boolean = True

        DocumentoVentaBE.NumeroDocumento = DocumentoVentaDAO.tDocumento
        DocumentoVentaBE.NumeroDocumentoNew = lblNumero.Text
        DocumentoVentaBE.Total = txtImporteTotal.Text
         DocumentoVentaBE.FechaEmision = lblFecha.Text
        If (ParametroDAO.Validar_NumeroDocumentoNew(DocumentoVentaBE.NumeroDocumentoNew) > 0 And DocumentoVentaDAO.tDocumento <> DocumentoVentaBE.NumeroDocumentoNew.ToString) Then
            Result = False
        End If

        Return Result
    End Function

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick
        If MessageBox.Show("Seguro de Actualizar los datos?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Me.Validar() Then
                Dim detalle_documento_totales As New DataTable
                For i As Integer = 0 To GridView1.DataRowCount - 1
                    detalle_documento_totales = DocumentoVentaDAO.SaveDetalle(DocumentoVentaDAO.tDocumento, GridView1.GetRowCellValue(i, "tCodigoProducto").ToString, GridView1.GetRowCellValue(i, "nVenta").ToString, ParametroDAO.GetImpuesto2_por_producto(GridView1.GetRowCellValue(i, "tCodigoProducto").ToString, GridView1.GetRowCellValue(i, "tCodigoPedido").ToString))
                Next i
                DocumentoVentaDAO.Save(DocumentoVentaBE, detalle_documento_totales)


                'Elimina el documento en la replicada si es que el documento es nuevo
                If (DocumentoVentaBE.NumeroDocumento <> DocumentoVentaBE.NumeroDocumentoNew And IdLocal > 0) Then
                    DocumentoVentaDAO.DeleteReplica(IdLocal, DocumentoVentaBE.NumeroDocumento)
                    DocumentoVentaBE.NumeroDocumento = DocumentoVentaBE.NumeroDocumentoNew
                End If
            Else
                MessageBox.Show("El numero de documento" + DocumentoVentaBE.NumeroDocumentoNew + " ya existe en el sistema")
            End If
        End If
    End Sub

    Public Sub SumaTotal()
        Dim nVENTA As Object = dtProducto.Compute("Sum(nVenta)", "tDocumento='" + DocumentoVentaDAO.tDocumento + "'")
        Dim SUMA_IGV As Object = dtProducto.Compute("Sum(nImpuesto1)", "tDocumento='" + DocumentoVentaDAO.tDocumento + "'")
        Dim SUMA_RECARGO_POR_CONSUMO As Object = dtProducto.Compute("Sum(nImpuesto2)", "tDocumento='" + DocumentoVentaDAO.tDocumento + "'")
        Dim SUB_TOTAL As Object = dtProducto.Compute("Sum(SubTotal)", "tDocumento='" + DocumentoVentaDAO.tDocumento + "'")

        Dim factor_base_imponible As Double
        factor_base_imponible = Format(1 + (ParametroDAO.GetIGV + ParametroDAO.GetRecargoxConsumo) / 100, "###,###,###0.00")
        txtImporteTotal.Text = String.Format("{0:###,###,###0.00}", nVENTA)
        txtImporteSubTotal.Text = String.Format("{0:###,###,###0.00}", SUB_TOTAL)
        txtImporteImpuesto1.Text = String.Format("{0:###,###,###0.00}", SUMA_IGV)
        txtImporteImpuesto2.Text = String.Format("{0:###,###,###0.00}", SUMA_RECARGO_POR_CONSUMO)
    End Sub
End Class