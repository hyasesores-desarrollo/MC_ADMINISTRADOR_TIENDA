Imports MC.Data
Imports MC.Framework
Public Class BeneficiosNorkysDetails
    Dim bsBeneficioEmpleado As New BindingSource
    Dim IdEmpleado As Integer = 0
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        lblMensaje.Text = ""
        txtNumeroPedido.Enabled = False
        txtAnio.Enabled = False
        txtAnio.Text = BeneficioNorkysDAO.ObtenerPrimerosDigitosCodigoPedido()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDBENEFICIONORKYSEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE EMPLEADO", "NOMBREEMPLEADO", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Nª DOCUMENTO", "NUMERODOCUMENTO", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA CONSUMO", "FECHACONSUMO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "LOCAL CONSUMO", "LOCALCONSUMO", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'UsuarioRegistroConsumo
        With GridView1
            '.Columns("NOMBREEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHACONSUMO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("LOCALCONSUMO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

    End Sub
    Private Sub Refrescar(id)
        Try
            bsBeneficioEmpleado.DataSource = BeneficioNorkysDAO.BeneficiosNorkysGetIdEmpleado(id)
            Me.GridControl1.DataSource = bsBeneficioEmpleado
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnBuscarTrabajador_Click(sender As Object, e As EventArgs) Handles btnBuscarTrabajador.Click
        If LTrim(txtNumeroDocumento.Text) = "" Then
            MessageBox.Show("Ingrese el numero de documento del trabajador", "Mensaje de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Limpiar()

        Else
            Dim dt As DataTable = BeneficioNorkysDAO.DatosEmpleadoDniList(LTrim(txtNumeroDocumento.Text))
            If dt.Rows.Count = 0 Then
                MessageBox.Show("El trabajador con numero de documento " & LTrim(txtNumeroDocumento.Text) & " no existe", "Mensaje de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Limpiar()
            Else
                IdEmpleado = dt.Rows(0)("IDEMPLEADO")
                txtNombres.Text = dt.Rows(0)("NOMBREEMPLEADO")
                txtOrganizacion.Text = dt.Rows(0)("RAZONCOMERCIAL")
                txtSituacionLaboral.Text = dt.Rows(0)("SITUACIONLABORAL")
                lblMensaje.Text = dt.Rows(0)("MENSAJE")
                Refrescar(IdEmpleado)
                If dt.Rows(0)("RESULT") = 1 Then

                    lblMensaje.ForeColor = Color.Blue
                    txtNumeroPedido.Enabled = True
                Else
                    txtNumeroPedido.Enabled = False
                    lblMensaje.ForeColor = Color.Red
                End If
                'Dim dtBeneficiosEmpleados As DataTable
                'dtBeneficiosEmpleados = 
            End If
        End If
    End Sub
    Private Sub Limpiar()
        IdEmpleado = 0
        txtNombres.Text = ""
        txtOrganizacion.Text = ""
        txtSituacionLaboral.Text = ""
        lblMensaje.Text = ""
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub txtNumeroPedido_LostFocus(sender As Object, e As EventArgs) Handles txtNumeroPedido.LostFocus
        txtNumeroPedido.Text = txtNumeroPedido.Text.Trim.PadLeft(8, "0")
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

    Private Sub btnRegistrarConsumo_Click(sender As Object, e As EventArgs) Handles btnRegistrarConsumo.Click
        If validarNumeroPedido() Then
            Dim numeropedido As String = LTrim(txtAnio.Text) & LTrim(txtNumeroPedido.Text)
            Dim valor As Int32 = BeneficioNorkysDAO.ValidacionNumeroPedidoTienda(numeropedido) ' VALIDA CODIGOPEDIDO EXISTA

            If valor = 0 Then
                MessageBox.Show("El numero de pedido " & numeropedido & " es incorrecto, por vafor ingrese el numero de pedido correcto", "Validación Número Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If My.Computer.Network.Ping(IPServerCentral) Then 'REALIZA PIN A LA CENTRAL
                    If Tools.ConexionCentral(IPServerCentral, BdCentral) Then ' VERIFICA CONEXION BD_CODIGO_ENTEL
                        Dim dt As DataTable = BeneficioNorkysDAO.DatosEmpleadoDniList(LTrim(txtNumeroDocumento.Text))
                        If dt.Rows.Count = 0 Then
                            MessageBox.Show("El trabajador con numero de documento " & LTrim(txtNumeroDocumento.Text) & " no existe", "Mensaje de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Limpiar()
                        Else
                            lblMensaje.Text = dt.Rows(0)("MENSAJE")

                            If dt.Rows(0)("RESULT") = 1 Then

                                lblMensaje.ForeColor = Color.Blue
                                txtNumeroPedido.Enabled = True
                                Dim canalventa As Int32 = CInt(CodigoEntelDAO.ObteberCanalVenta(numeropedido))
                                If MessageBox.Show("Estas seguro de registrar el beneficio", "Mensaje Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                                    If BeneficioNorkysDAO.RegistrarBeneficioEmpleado(dt.Rows(0)("IDEMPLEADO"), Tools.ReadAppSettings("IdLocal"), canalventa, 1, numeropedido, SistemaDAO.UsuarioBE.tResumido) Then
                                        Me.Close()
                                    End If
                                End If

                            Else
                                txtNumeroPedido.Enabled = False
                                lblMensaje.ForeColor = Color.Red
                            End If
                            'Dim dtBeneficiosEmpleados As DataTable
                            'dtBeneficiosEmpleados = 
                        End If
                    End If
                End If

            End If
        End If

    End Sub

End Class