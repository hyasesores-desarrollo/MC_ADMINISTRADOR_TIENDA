Imports MC.Data
Imports MC.Framework
Imports MC.Report
Public Class PromocionCodigoTickectDetails
    Dim bsCodigoPromocion As New BindingSource
    Sub New()
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "CONSULTA CÓDIGO PROMOCIÓN TICKECT"
        Me.KeyPreview = True

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGO PROMOCIÓN", "CodigoPromocion", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PROMOCION", "NombrePromocion", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'UsuarioRegistroConsumo
        With GridView1
            .Columns("CodigoPromocion").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NombrePromocion").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
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
            bsCodigoPromocion.DataSource = CodigoEntelDAO.CodigoPromocionTickectPendienteGetIniCaja(Tools.ReadAppSettings("IdLocal"))
            Me.GridControl1.DataSource = bsCodigoPromocion
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If validarCodigo() Then

            If My.Computer.Network.Ping(IPServerCentral) Then 'REALIZA PIN A LA CENTRAL
                If Tools.ConexionCentral(IPServerCentral, BdVentas) Then ' VERIFICA CONEXION MC_VENTAS
                    If GridView1.RowCount > 0 Then
                        For i = 0 To GridView1.RowCount - 1
                            If LTrim(txtCodigoPromocion.Text).ToUpper = GridView1.GetRowCellValue(i, "CodigoPromocion") Then
                                MessageBox.Show("El codigo " & LTrim(txtCodigoPromocion.Text).ToUpper & " ya se encuentra en el listado de asignados")
                                Exit Sub
                            End If
                        Next
                    End If
                    Dim dt As DataTable
                    dt = CodigoEntelDAO.ConsultaCodigoPromocionTickect(LTrim(txtCodigoPromocion.Text)) 'VALIDA EL ESTADO DEL CODIGO ENTEL
                    If dt.Rows.Count > 0 Then
                        txtDescripcion.Text = dt.Rows(0)("Mensaje")
                        If CInt(dt.Rows(0)("Result")) = 0 Then
                            txtDescripcion.ForeColor = Color.Green
                            btnAsignar.Visible = True
                        Else
                            txtDescripcion.ForeColor = Color.Red
                            btnAsignar.Visible = False

                            Dim dtImpresion As DataTable
                            dtImpresion = CodigoEntelDAO.DatosImpresionCodigoPromocionTickect(LTrim(txtCodigoPromocion.Text), Tools.ReadAppSettings("IdLocal"))
                            Dim reportCodigoEntel As New XR_CODIGO_ENTEL_CONSUMO
                            reportCodigoEntel.XrTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
                            reportCodigoEntel.XrTitulo.Text = dtImpresion.Rows(0)("TituloImpresion")
                            reportCodigoEntel.XrLocal.Text = dtImpresion.Rows(0)("RazonComercial") '"San Juan 2"
                            reportCodigoEntel.XrCodigoEntel.Text = LTrim(txtCodigoPromocion.Text).ToUpper
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

    Private Sub btnAsignar_Click(sender As Object, e As EventArgs) Handles btnAsignar.Click
        If validarCodigo() Then
            If My.Computer.Network.Ping(IPServerCentral) Then ' REALIZA PIN A LA CENTRAL
                If Tools.ConexionCentral(IPServerCentral, BdVentas) Then ' VERIFICA CONEXION MC_VENTAS
                    Dim dt As DataTable
                    dt = CodigoEntelDAO.ConsultaCodigoPromocionTickect(LTrim(txtCodigoPromocion.Text)) ' VERIFICA EL CODIGO PROMOCION
                    If CInt(dt.Rows(0)("Result")) = 0 Then
                        If CodigoEntelDAO.RegistrarCodigoPromocionTickect((dt.Rows(0)("CodigoPromocion")), "", Tools.ReadAppSettings("IdLocal"), SistemaDAO.UsuarioBE.tResumido) Then ' MODIFICA MC_VENTAS CONSUMIDO                       
                            txtCodigoPromocion.Text = ""
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
                        If Tools.ConexionCentral(IPServerCentral, BdVentas) Then ' VERIFICA CONEXION MC_VENTAS
                            For i = 0 To GridView1.RowCount - 1
                                Dim Codigo As String = (GridView1.GetRowCellValue(i, "CodigoPromocion"))
                                If CodigoEntelDAO.RegistrarCodigoPromocionTickect(Codigo, txtAnio.Text & txtNumeroPedido.Text, Tools.ReadAppSettings("IdLocal"), SistemaDAO.UsuarioBE.tResumido) Then ' MODIFICA MC_VENTAS CONSUMIDO  
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

    Private Sub txtNumeroPedido_LostFocus(sender As Object, e As EventArgs) Handles txtNumeroPedido.LostFocus
        txtNumeroPedido.Text = txtNumeroPedido.Text.Trim.PadLeft(8, "0")
    End Sub

    Private Function validarCodigo() As Boolean
        Dim Result As Boolean = True
        DxErrorProvider1.ClearErrors()

        If LTrim(txtCodigoPromocion.Text) = "" Then
            DxErrorProvider1.SetError(txtCodigoPromocion, "Dato obligatorio")
            Result = False
        End If
        Return Result
    End Function
    Private Function validarNumeroPedido() As Boolean
        Dim Result As Boolean = True
        DxErrorProvider1.ClearErrors()

        If LTrim(txtNumeroPedido.Text) = "" Then
            DxErrorProvider1.SetError(txtNumeroPedido, "Dato obligatorio")
            Result = False
        End If
        Return Result
    End Function
End Class