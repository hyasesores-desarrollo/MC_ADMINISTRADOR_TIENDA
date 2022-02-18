Imports MC.Data
Imports MC.Framework

Public Class NotaCreditoDetails

    Dim NotaCreditoBE As NotaCreditoBE

    Public Sub configurarGrid()
        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)

        'Se configura el control GridView
        'ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGO", "tCodigoProducto", 60, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PRODUCTO", "tDetallado", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CANTIDAD DOC", "nCantidad", 90, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "VALOR UNI", "nPrecioNeto", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PRECIO UNI", "nPrecioVenta", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IGV", "nPrecioImpuesto1", 50, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ISC", "nPrecioImpuesto2", 50, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "VALOR VENTA", "nVenta", 85, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCUENTO", "nDescuento", 70, True, ControlesDevExpress.eGridViewFormato.Numero, False)
    End Sub

    Public Sub New()
        InitializeComponent()

        cmbCajas.DisplayMember = "tCaja"
        cmbCajas.ValueMember = "tcaja"
        cmbCajas.DataSource = NotaCreditoDAO.GetCajas

        cmbTipoDocumento.DisplayMember = "Descripcion"
        cmbTipoDocumento.ValueMember = "Codigo"
        cmbTipoDocumento.DataSource = NotaCreditoDAO.GetTiposDocumento

        cmbDocIdentidad.DisplayMember = "Descripcion"
        cmbDocIdentidad.ValueMember = "Codigo"
        cmbDocIdentidad.DataSource = NotaCreditoDAO.GetTiposIdentidad
        cmbDocIdentidad.SelectedIndex = 1

        cmbMotivo.SelectedIndex = 0

        'If NotaCreditoDAO.IDNotaCredito = 0 Then
        If NotaCreditoDAO.tNotaCredito = "" Then
            txtFechaRegistro.Text = DateTime.Now.ToString()
        End If

        'Se inicializa la entidad
        NotaCreditoBE = New NotaCreditoBE

        Me.Text = " MANTENIMIENTO DE NOTAS DE CRÉDITO "
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnGuardar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G, "Ctrl + G")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnGuardarCerrar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A, "Ctrl + C")

        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnsiguiente, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right, "Ctrl + → ")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnanterior, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left, "Ctrl + ←")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        AddHandler txtCajaEmision.KeyPress, AddressOf Tools.SoloNumeros
        txtTurno.Text = tTurnoActual
        txtCajaEmision.Text = tCajaEmision
        txtNroNC.Text = ""
        txtNroDocAfectado.Text = ""
        txtFechaRegistro.Text = ""
        txtFechaEmision.Text = ""
        txtIdentidadCliente.Text = ""
        txtNombreCliente.Text = ""
        txtVentaGrabada.Text = ""
        txtVentaInafecta.Text = ""
        txtVentaExonerada.Text = ""
        txtVentaIGV.Text = ""

        txtISC.Text = ""
        txtOtrosTributos.Text = ""
        txtOtrosCargos.Text = ""
        txtDescuento.Text = ""


        configurarGrid()
        CargarEntidad()
    End Sub

    Public Sub CargarEntidad()
        Try
            btnBuscarDocumento.Enabled = False
            dtpFechaEmisionDocumento.Enabled = False

            'If NotaCreditoDAO.IDNotaCredito = 0 Then
            If NotaCreditoDAO.tNotaCredito = "" Then
                txtNroNC.Text = ""
                txtNroDocAfectado.Text = ""
                txtFechaRegistro.Text = ""
                txtFechaEmision.Text = ""
                txtIdentidadCliente.Text = ""
                txtNombreCliente.Text = ""
                txtVentaGrabada.Text = ""
                txtVentaInafecta.Text = ""
                cmbCajas.Enabled = True
                txtVentaExonerada.Text = ""
                txtVentaIGV.Text = ""
                txtISC.Text = ""
                txtOtrosTributos.Text = ""
                txtOtrosCargos.Text = ""
                txtDescuento.Text = ""

                btnBuscarDocumento.Enabled = True
                dtpFechaEmisionDocumento.Enabled = True

                cmbTipoDocumento.Enabled = True

                Bloquear_Desbloquear(True)
                'btnPublicar.Enabled = False
                btnAnular.Enabled = False
            Else
                Bloquear_Desbloquear(False)
                btnBuscarDocumento.Enabled = False
                dtpFechaEmisionDocumento.Enabled = False

                Dim dtNCCab As New DataTable
                dtNCCab = NotaCreditoDAO.GetNotaCreditoCabeceraByID
                txtNroNC.Text = dtNCCab(0)("tNotaCredito").ToString
                txtTurno.Text = dtNCCab(0)("tTurno").ToString
                txtCajaEmision.Text = dtNCCab(0)("tCaja").ToString

                cmbMotivo.SelectedValue = 0
                txtFechaRegistro.Text = dtNCCab(0)("fFecha").ToString
                txtFechaEmision.Text = dtNCCab(0)("fFecha").ToString
                txtNroDocAfectado.Text = dtNCCab(0)("tDocumento").ToString
                dtpFechaEmisionDocumento.EditValue = Format(dtNCCab(0)("FechaDocumento"), "dd/MM/yyyy")
                cmbDocIdentidad.SelectedValue = dtNCCab(0)("TipoIdentidad").ToString
                cmbCajas.Enabled = False
                cmbCajas.SelectedValue = dtNCCab(0)("tCaja").ToString
                cmbTipoDocumento.SelectedValue = dtNCCab(0)("tTipoDocumento").ToString

                txtIdentidadCliente.Text = dtNCCab(0)("tIdentidad").ToString
                txtNombreCliente.Text = dtNCCab(0)("tEmpresa").ToString

                txtVentaGrabada.Text = FormatNumber(dtNCCab(0)("Afecto").ToString, 2)
                txtVentaInafecta.Text = FormatNumber(dtNCCab(0)("Inafecto").ToString, 2)
                txtVentaExonerada.Text = "0.00" 'FormatNumber(dtNCCab(0)("tEmpresa").ToString, 2)
                txtVentaIGV.Text = FormatNumber(dtNCCab(0)("Impuesto1").ToString, 2)

                txtISC.Text = "0.00" 'FormatNumber(dtNCCab(0)(18).ToString, 2)
                txtOtrosTributos.Text = FormatNumber(dtNCCab(0)("Impuesto2").ToString, 2)
                txtOtrosCargos.Text = "0.00" 'FormatNumber(dtNCCab(0)(15).ToString, 2)
                txtDescuento.Text = FormatNumber(dtNCCab(0)("Descuento").ToString, 2)
                txtImporteTotal.Text = FormatNumber(dtNCCab(0)("Venta").ToString, 2)

                'GridControl1.DataSource = NotaCreditoDAO.GetNotaCreditoDetalleByID
                GridControl1.DataSource = NotaCreditoDAO.GetFacturaDetalle(dtNCCab(0)("tDocumento").ToString)
                btnAnular.Enabled = True
                If EstadoNotaC.ToUpper.ToString = "PUBLICADO" Or EstadoNotaC.ToString.ToUpper = "ANULADO" Then
                    'btnPublicar.Enabled = False
                Else
                    'btnPublicar.Enabled = True
                    btnAnular.Enabled = True
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Bloquear_Desbloquear(ByVal Valor As Boolean)
        cmbTipoDocumento.Enabled = Valor
        btnBuscarDocumento.Enabled = Valor
        cmbMotivo.Enabled = Valor
        btnBuscarDocumento.Enabled = Valor
        'btnPublicar.Enabled = Not Valor
        btnAnular.Enabled = Not Valor
        btnGuardar.Enabled = Valor
        btnGuardarCerrar.Enabled = Valor
    End Sub

    Private Sub Buttons_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick, btnGuardarCerrar.ItemClick, btnCerrar.ItemClick, btnAnular.ItemClick, btnPublicar.ItemClick
        Select Case e.Item.Caption
            Case "Guardar" : Guardar()
            Case "Guardar y Cerrar" : GuardarCerrar()
            Case "Cerrar" : Cerrar()
            Case "Anular" : Anular()
            Case "Publicar" : Publicar()
        End Select
    End Sub

    Public Sub Anular()
        'If NotaCreditoDAO.IDNotaCredito <> 0 Then
        If NotaCreditoDAO.tNotaCredito <> "" Then
            If MessageBox.Show("¿Realmente desea ANULAR la Nota de Credito?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'NotaCreditoDAO.AnularNotaCredito(NotaCreditoDAO.IDNotaCredito)
                NotaCreditoDAO.AnularNotaCredito(NotaCreditoDAO.tNotaCredito)
                Close()
            End If
        End If
    End Sub

    Public Function Validar() As Boolean
        Dim Result As Boolean = False

        If cmbMotivo.Text <> "" Then
            If txtNroDocAfectado.Text <> "" Then
                If cmbTipoDocumento.SelectedValue.ToString = "07" Then
                    If txtNroDocAfectado.Text.Substring(1, 1) <> "F" Then
                        Result = True
                    End If
                End If
                If cmbTipoDocumento.SelectedValue.ToString = "08" Then
                    If txtNroDocAfectado.Text.Substring(1, 1) <> "B" Then
                        Result = True
                    End If
                End If

            End If
        End If

        If Result Then

        Else
            MessageBox.Show("El registro de datos no cumple con las reglas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return Result
    End Function

    Public Sub Guardar()
        If Me.Validar() Then
            NotaCreditoDAO.SaveNotaCredito(NotaCreditoBE)
            Dim igv As Double
            Dim isc As Double

            For i As Integer = 0 To GridView1.DataRowCount - 1
                If GridView1.GetRowCellValue(i, "nIGV") Is Nothing Then
                    igv = 0
                Else
                    igv = GridView1.GetRowCellValue(i, "nIGV").ToString
                End If
                If GridView1.GetRowCellValue(i, "nISC") Is Nothing Then
                    isc = 0
                Else
                    isc = GridView1.GetRowCellValue(i, "nISC").ToString
                End If


                'NotaCreditoDAO.SaveNotaCreditoDetalle(NotaCreditoDAO.IDNotaCredito, i + 1, GridView1.GetRowCellValue(i, "tCodProducto").ToString, GridView1.GetRowCellValue(i, "tDescripcion"), GridView1.GetRowCellValue(i, "nCantidad").ToString, GridView1.GetRowCellValue(i, "nValorUnitario").ToString, GridView1.GetRowCellValue(i, "nPrecioUnitario").ToString, igv, isc, GridView1.GetRowCellValue(i, "nValorVentaItem").ToString, GridView1.GetRowCellValue(i, "nDescuentoItem").ToString)
                'NotaCreditoDAO.SaveNotaCreditoDetalle(NotaCreditoDAO.tNotaCredito, i + 1, GridView1.GetRowCellValue(i, "tCodProducto").ToString, GridView1.GetRowCellValue(i, "tDescripcion"), GridView1.GetRowCellValue(i, "nCantidad").ToString, GridView1.GetRowCellValue(i, "nValorUnitario").ToString, GridView1.GetRowCellValue(i, "nPrecioUnitario").ToString, igv, isc, GridView1.GetRowCellValue(i, "nValorVentaItem").ToString, GridView1.GetRowCellValue(i, "nDescuentoItem").ToString)

            Next i
            CargarEntidad()
        End If
    End Sub

    Public Sub GuardarCerrar()
        If Me.Validar() Then
            NotaCreditoDAO.SaveNotaCredito(NotaCreditoBE)
            'Dim igv As Double
            'Dim isc As Double

            'For i As Integer = 0 To GridView1.DataRowCount - 1
            '    If GridView1.GetRowCellValue(i, "nIGV") Is Nothing Then
            '        igv = 0
            '    Else
            '        igv = GridView1.GetRowCellValue(i, "nIGV").ToString
            '    End If
            '    If GridView1.GetRowCellValue(i, "nISC") Is Nothing Then
            '        isc = 0
            '    Else
            '        isc = GridView1.GetRowCellValue(i, "nISC").ToString
            '    End If

            '    'NotaCreditoDAO.SaveNotaCreditoDetalle(NotaCreditoDAO.IDNotaCredito, i + 1, GridView1.GetRowCellValue(i, "tCodProducto").ToString, GridView1.GetRowCellValue(i, "tDescripcion"), GridView1.GetRowCellValue(i, "nCantidad").ToString, GridView1.GetRowCellValue(i, "nValorUnitario").ToString, GridView1.GetRowCellValue(i, "nPrecioUnitario").ToString, igv, isc, GridView1.GetRowCellValue(i, "nValorVentaItem").ToString, GridView1.GetRowCellValue(i, "nDescuentoItem").ToString)
            '    'NotaCreditoDAO.SaveNotaCreditoDetalle(NotaCreditoDAO.tNotaCredito, i + 1, GridView1.GetRowCellValue(i, "tCodProducto").ToString, GridView1.GetRowCellValue(i, "tDescripcion"), GridView1.GetRowCellValue(i, "nCantidad").ToString, GridView1.GetRowCellValue(i, "nValorUnitario").ToString, GridView1.GetRowCellValue(i, "nPrecioUnitario").ToString, igv, isc, GridView1.GetRowCellValue(i, "nValorVentaItem").ToString, GridView1.GetRowCellValue(i, "nDescuentoItem").ToString)

            'Next i

            Cerrar()
        End If
    End Sub

    Public Sub Cerrar()
        Me.Close()

    End Sub

    Public Sub Publicar()
        If MessageBox.Show("¿Realmente desea Publicar la Nota de Credito?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'NotaCreditoDAO.PublicarNotaCredito(NotaCreditoDAO.IDNotaCredito, 1, txtCajaEmision.Text)
            NotaCreditoDAO.PublicarNotaCredito(NotaCreditoDAO.tNotaCredito, 1, txtCajaEmision.Text)
            Close()
        End If

    End Sub

    Private Sub grpCliente_Enter(sender As Object, e As EventArgs) Handles grpCliente.Enter

    End Sub

    Private Sub btnObtenerTurno_Click(sender As Object, e As EventArgs)
        tTurnoActual = NotaCreditoDAO.GetTurnoActivo(txtCajaEmision.Text)
        If tTurnoActual <> "" Then
            txtTurno.Text = tTurnoActual
            dtpFechaEmisionDocumento.Enabled = True
            btnBuscarDocumento.Enabled = True
            dtpFechaEmisionDocumento.Focus()
        Else
            MsgBox("No existe turno aperturado para la caja: " & txtCajaEmision.Text)
        End If
    End Sub

    Private Sub txtCajaEmision_Leave(sender As Object, e As EventArgs)
        Dim cadena As String
        cadena = txtCajaEmision.Text.Trim
        cadena = Microsoft.VisualBasic.Right(String.Concat("000", cadena), 3)

        txtCajaEmision.Text = cadena
    End Sub

    Private Sub btnBuscarDocumento_Click(sender As Object, e As EventArgs) Handles btnBuscarDocumento.Click
        If cmbMotivo.Text <> "" Then
            If cmbTipoDocumento.SelectedValue.ToString <> "" Then
                If cmbCajas.Text.ToString <> "" Then
                    If txtCajaEmision.Text.ToString <> "" Then
                        If txtTurno.Text.ToString <> "" Then
                            If dtpFechaEmisionDocumento.Text <> "" Then
                                Dim frmBuscaR As New BuscaDocumentoNC(cmbTipoDocumento.SelectedValue.ToString, dtpFechaEmisionDocumento.EditValue.ToString, cmbCajas.Text)
                                frmBuscaR.ShowDialog()
                                If DocumentoSeleccionadoNc <> "" Then
                                    If tTurnoActual <> "" Then
                                        NotaCreditoBE = New NotaCreditoBE

                                        txtNroNC.Text = NotaCreditoDAO.GetCorrelativoNotaCredito(DocumentoSeleccionadoNc.Substring(0, 6))

                                        Dim dtFacCab As New DataTable
                                        dtFacCab = NotaCreditoDAO.GetFacturaCabecera(DocumentoSeleccionadoNc)
                                        txtNroDocAfectado.Text = DocumentoSeleccionadoNc 'dtFacCab(0)("tIdentidad").ToString

                                        txtFechaRegistro.Text = DateTime.Now
                                        txtFechaEmision.Text = DateTime.Now
                                        cmbDocIdentidad.SelectedValue = dtFacCab(0)("TipoIdentidad").ToString
                                        txtIdentidadCliente.Text = dtFacCab(0)("tIdentidad").ToString
                                        txtNombreCliente.Text = dtFacCab(0)("tEmpresa").ToString
                                        txtVentaGrabada.Text = FormatNumber(dtFacCab(0)("Afecto").ToString, 2)
                                        txtVentaInafecta.Text = FormatNumber(dtFacCab(0)("Inafecto").ToString, 2)
                                        txtVentaExonerada.Text = "0.00" 'FormatNumber(dtFacCab(0)(12).ToString, 2)
                                        txtVentaIGV.Text = FormatNumber(dtFacCab(0)("nPrecioImpuesto1").ToString, 2)
                                        txtOtrosTributos.Text = FormatNumber(dtFacCab(0)("nPrecioImpuesto2").ToString, 2)
                                        txtOtrosCargos.Text = "0.00" 'FormatNumber(dtFacCab(0)(28).ToString, 2)
                                        txtDescuento.Text = FormatNumber(dtFacCab(0)("nDescuento").ToString, 2)
                                        txtImporteTotal.Text = FormatNumber(dtFacCab(0)("nVenta").ToString, 2)
                                        txtISC.Text = "0.00" 'FormatNumber(dtFacCab(0)(18).ToString, 2)

                                        NotaCreditoBE.tNotaCredito = txtNroNC.Text
                                        NotaCreditoBE.tDocumento = txtNroDocAfectado.Text
                                        NotaCreditoBE.fFecha = txtFechaRegistro.Text
                                        NotaCreditoBE.nNeto = txtVentaGrabada.Text
                                        NotaCreditoBE.nImpuesto1 = txtVentaIGV.Text
                                        NotaCreditoBE.nImpuesto2 = txtOtrosTributos.Text
                                        NotaCreditoBE.nImpuesto3 = 0
                                        NotaCreditoBE.nVenta = txtImporteTotal.Text
                                        NotaCreditoBE.tTurno = tTurnoActual
                                        NotaCreditoBE.tCaja = txtCajaEmision.Text
                                        NotaCreditoBE.tUsuario = UsuarioDAO.IDUsuario
                                        NotaCreditoBE.tObservacion = cmbMotivo.Text

                                        GridControl1.DataSource = NotaCreditoDAO.GetFacturaDetalle(DocumentoSeleccionadoNc)

                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            End If
        Else
            MessageBox.Show("Debe Seleccionar un motivo")
        End If
    End Sub

End Class