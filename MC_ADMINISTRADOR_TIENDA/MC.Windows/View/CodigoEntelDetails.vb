Imports MC.Data
Imports MC.Framework
Imports MC.Report
Public Class CodigoEntelDetails
    Dim bsCodigoEntel As New BindingSource
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "CONSULTA CÓDIGO PROMOCIÓN"
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDPEDIDOCODIGOENTEL", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CÓDIGO PROMOCIÓN", "CODIGOENTEL", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "FECHAREGISTRO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'UsuarioRegistroConsumo
        With GridView1
            .Columns("CODIGOENTEL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAREGISTRO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        btnAsignar.Visible = False
        txtAnio.Text = CodigoEntelDAO.ObtenerPrimerosDigitosCodigoPedido()
        Refrescar()

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick

        Me.Close()

    End Sub
    Private Sub Refrescar()
        Try
            bsCodigoEntel.DataSource = CodigoEntelDAO.CodigoEntelPendienteGetIniCaja()
            Me.GridControl1.DataSource = bsCodigoEntel
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        If validarCodigoEntel() Then
            If My.Computer.Network.Ping(IPServerCentral) Then ' REALIZA PIN A LA CENTRAL
                If Tools.ConexionCentral(IPServerCentral, BdCodigoEntel) Then ' VERIFICA CONEXION BD_CODIGO_ENTEL
                    Dim dt As DataTable
                    dt = CodigoEntelDAO.ConsultaCodigoEntel(LTrim(txtCodigoEntel.Text)) ' VERIFICA EL CODIGO DE ENTEL
                    If CInt(dt.Rows(0)("Result")) = 0 Then
                        If CodigoEntelDAO.RegistrarCodigoEntel(CInt(dt.Rows(0)("IdCodigoEntelDetalle")), Tools.ReadAppSettings("IdLocal"), dt.Rows(0)("CodigoEntel"), SistemaDAO.UsuarioBE.tResumido) Then ' MODIFICA BD_CODIGO_ENTEL CONSUMIDO
                            CodigoEntelDAO.RegistrarCodigoEntelInforest(Tools.ReadAppSettings("IdLocal"), dt.Rows(0)("CodigoEntel").ToString, 1, "", SistemaDAO.UsuarioBE.tResumido) ' REGISTRA INFOREST
                            txtCodigoEntel.Text = ""
                            txtDescripcion.Text = ""
                            btnAsignar.Visible = False
                        End If
                    Else
                        txtDescripcion.ForeColor = Color.Red
                        txtDescripcion.Text = dt.Rows(0)("Mensaje")
                    End If
                Else
                    MessageBox.Show("Error con conxion servidor central")
                End If
            Else
                MessageBox.Show("Error con conxion servidor central")
            End If
        End If
        Refrescar()
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

        If GridView1.RowCount = 0 Then
            MessageBox.Show("No cuenta con ningun registro de codigo de promoción asignado", "Codigo Promoción", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Refrescar()
        Dim countregistro As Int32 = 0
        If validarNumeroPedido() Then
            If GridView1.RowCount > 0 Then
                Dim numeropedido As String = LTrim(txtAnio.Text) & LTrim(txtNumeroPedido.Text)
                Dim valor As Int32 = CodigoEntelDAO.ValidacionNumeroPedidoTienda(numeropedido) ' VALIDA CODIGOPEDIDO EXISTA
                If valor = 0 Then
                    MessageBox.Show("El numero de pedido " & numeropedido & " es incorrecto, por vafor ingrese el numero de pedido correcto", "Validación Número Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If My.Computer.Network.Ping(IPServerCentral) Then 'REALIZA PIN A LA CENTRAL
                        If Tools.ConexionCentral(IPServerCentral, BdCodigoEntel) Then ' VERIFICA CONEXION BD_CODIGO_ENTEL
                            For i = 0 To GridView1.RowCount - 1
                                Dim idpedidocodigoentel As Integer = CInt(GridView1.GetRowCellValue(i, "IDPEDIDOCODIGOENTEL"))
                                Dim Codigo As String = (GridView1.GetRowCellValue(i, "CODIGOENTEL"))
                                Dim canalventa As Int32 = CInt(CodigoEntelDAO.ObteberCanalVenta(numeropedido))
                                If CodigoEntelDAO.ProcesarPendientesCodigoEntelInforest(idpedidocodigoentel, numeropedido) Then 'INFOREST
                                    CodigoEntelDAO.UpdateCodigoEntelNumeroPedido(Codigo, numeropedido, canalventa) 'BD_CODIGO_ENTEL
                                    countregistro = countregistro + 1
                                End If
                            Next
                            If countregistro = GridView1.RowCount Then
                                Me.Close()
                            End If
                        Else
                            MessageBox.Show("Error con conxion servidor central")
                        End If
                    Else
                        MessageBox.Show("Error con conxion servidor central")
                    End If
                End If
            End If
        End If

    End Sub
    Private Function validarNumeroPedido() As Boolean
        Dim Result As Boolean = True
        DxErrorProvider1.ClearErrors()

        If LTrim(txtNumeroPedido.Text) = "" Then
            DxErrorProvider1.SetError(txtNumeroPedido, "Dato obligatorio")
            Result = False
        End If
        Return Result
    End Function
    Private Function validarCodigoEntel() As Boolean
        Dim Result As Boolean = True
        DxErrorProvider1.ClearErrors()

        If LTrim(txtCodigoEntel.Text) = "" Then
            DxErrorProvider1.SetError(txtCodigoEntel, "Dato obligatorio")
            Result = False
        End If
        Return Result
    End Function

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        If validarCodigoEntel() Then

            If My.Computer.Network.Ping(IPServerCentral) Then 'REALIZA PIN A LA CENTRAL
                If Tools.ConexionCentral(IPServerCentral, BdCodigoEntel) Then ' VERIFICA CONEXION BD_CODIGO_ENTEL
                    If GridView1.RowCount > 0 Then
                        For i = 0 To GridView1.RowCount - 1
                            If LTrim(txtCodigoEntel.Text).ToUpper = GridView1.GetRowCellValue(i, "CODIGOENTEL") Then
                                MessageBox.Show("El codigo " & LTrim(txtCodigoEntel.Text).ToUpper & " ya se encuentra en el listado de asignados")
                                Exit Sub
                            End If
                        Next
                    End If
                    Dim dt As DataTable
                    dt = CodigoEntelDAO.ConsultaCodigoEntel(LTrim(txtCodigoEntel.Text)) 'VALIDA EL ESTADO DEL CODIGO ENTEL
                    If dt.Rows.Count > 0 Then
                        txtDescripcion.Text = dt.Rows(0)("Mensaje")
                        If CInt(dt.Rows(0)("Result")) = 0 Then
                            txtDescripcion.ForeColor = Color.Green
                            btnAsignar.Visible = True
                        Else
                            txtDescripcion.ForeColor = Color.Red
                            btnAsignar.Visible = False

                            Dim dtImpresion As DataTable
                            dtImpresion = CodigoEntelDAO.DatosImpresionCodigoEntel(LTrim(txtCodigoEntel.Text), Tools.ReadAppSettings("IdLocal"))
                            Dim reportCodigoEntel As New XR_CODIGO_ENTEL_CONSUMO
                            reportCodigoEntel.XrTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
                            reportCodigoEntel.XrTitulo.Text = dtImpresion.Rows(0)("TituloImpresion")
                            reportCodigoEntel.XrLocal.Text = dtImpresion.Rows(0)("RazonComercial") '"San Juan 2"
                            reportCodigoEntel.XrCodigoEntel.Text = LTrim(txtCodigoEntel.Text).ToUpper
                            reportCodigoEntel.XrProducto.Text = dtImpresion.Rows(0)("Producto")  ''"1/4 POLLO + PAPAS"
                            reportCodigoEntel.XrMensaje.Text = dt.Rows(0)("Mensaje") ' "DESCRIPCION DEL MENSAJE"
                            ReporteView.DocumentViewer1.DocumentSource = reportCodigoEntel
                            ReporteView.DocumentViewer1.Refresh()
                            ReporteView.Show()
                        End If
                    End If
                Else
                    MessageBox.Show("Error con conxion servidor central")
                End If
            Else
                MessageBox.Show("Error con conxion servidor central")
            End If
        End If
    End Sub
    Private Sub txtNumeroPedido_LostFocus(sender As Object, e As EventArgs) Handles txtNumeroPedido.LostFocus
        txtNumeroPedido.Text = txtNumeroPedido.Text.Trim.PadLeft(8, "0")
    End Sub

    Private Sub RepositoryItemButtonDesprocesar_Click(sender As Object, e As EventArgs) Handles RepositoryItemButtonDesprocesar.Click
        Dim codigoentel As String = GridView1.GetFocusedRowCellValue("CODIGOENTEL")
        Dim id As Integer = GridView1.GetFocusedRowCellValue("IDPEDIDOCODIGOENTEL")
        If MessageBox.Show("Estas seguro desprocesar el registro con codigo promoción " & codigoentel, "Desprocesar Codigo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            If My.Computer.Network.Ping(IPServerCentral) Then ' REALIZA PIN A LA CENTRAL
                If Tools.ConexionCentral(IPServerCentral, BdCodigoEntel) Then ' VERIFICA CONEXION BD_CODIGO_ENTEL
                    If CodigoEntelDAO.UpdateCodigoEntelEstadoConsumo(codigoentel) Then 'BD_CODIGO_ENTEL
                        CodigoEntelDAO.DeleteCodigoEntel(id) 'INFOREST
                    End If
                End If
            End If
            Refrescar()
        End If
    End Sub

End Class