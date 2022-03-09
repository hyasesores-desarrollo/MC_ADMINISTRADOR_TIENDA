Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class ClienteFidelizadoEdit
    Dim clientesBE As New MC_clientesBE
    Dim bsclientefidelizadodetalle As New BindingSource
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        clientesBE = New MC_clientesBE
        Me.Text = "CLIENTE FIDELIZADO - " & SistemaDAO.NombreLocal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnGuardar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G, "Ctrl + G")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCancelar, System.Windows.Forms.Keys.Escape, "Esc")

        'Carga de controladores
        ControlesDevExpress.InitGridLookUpEdit(cboTipoDocumento, ClienteFidelizadoDAO.GetTipoDocumentoSUNAT(), "IDTIPODOCUMENTOIDENTIDAD", "DESCRIPCION", 500)
        ControlesDevExpress.InitGridLookUpEdit(cboGenero, ClienteFidelizadoDAO.GetGenero(), "IDSEXO", "DESCRIPCION", 500)
        ControlesDevExpress.InitGridLookUpEdit(cboDistrito, ClienteFidelizadoDAO.GetDistritoUbigeo(), "IdUbigeo", "Distrito", 500)

        'Se posiciona el foco
        Me.ActiveControl = Me.cboTipoDocumento

        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)
        'Se configura el control GridView2
        ControlesDevExpress.InitGridView(GridView2)
        ControlesDevExpress.InitGridViewColumn(GridView2, "Codigo Cliente", "IdClienteDetalle", 10, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "Razon Comercial", "RAZONCOMERCIAL", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "Num. Doc.", "NumeroDocumento", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "Monto", "Monto", 50, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "Ingreso", "Ingreso", 50, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "Salida", "Salida", 50, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "Puntos", "Puntos", 50, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "Usuario", "UsuarioRegistra", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView2, "Fecha de consumo", "FechaRegistro", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'Se enlace el binding con la grilla
        Me.GridControl1.DataSource = bsclientefidelizadodetalle

        'Se carga la entidad al editar
        LoadEntidad()

    End Sub

    Public Sub Ocultar_objetos_autdatospersonales()
        chkActivo.Checked = True
        LabelControl8.Visible = False
        cboAprobacion.Visible = False
        btnAdjuntarImagen.Visible = False
        btnVerImagen.Visible = False

    End Sub

    Private Sub DocumentoDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick, btnCancelar.ItemClick
        Try
            Select Case e.Item.Caption
                Case "Guardar" : Guardar()
                Case "Cancelar" : Cancelar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub Guardar()
        If Me.Validar() Then
            If MessageBox.Show("Estas seguro de Grabar", "Mensaje Validadción", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If My.Computer.Network.Ping(IPServerCentral) Then 'REALIZA PIN A LA CENTRAL
                    If Tools.ConexionCentral(IPServerCentral, BdVentas) Then ' VERIFICA CONEXION BD_CODIGO_ENTEL
                        If ClienteFidelizadoDAO.CreateClienteFidelizado(clientesBE) Then
                            ClienteFidelizadoList.btnRefresh.PerformClick()
                            Me.Close()
                        End If
                    Else
                        MessageBox.Show("ERROR DE CONEXIÓN CON LA BASE DE DATOS")
                    End If
                Else
                    MessageBox.Show("ERROR DE CONEXIÓN CON EL SERVIDOR")
                End If
            End If
        Else
            MessageBox.Show("Tipo de documento y Número de documento ya existe")
        End If

    End Sub

    Public Sub Cancelar()
        DesktopMain.btnLocal.Enabled = True
        Me.Close()
    End Sub

    Public Function Validar() As Boolean
        Dim Result As Boolean = True
        If ClienteFidelizadoDAO.IdCliente = 0 Then
            Result = ClienteFidelizadoDAO.ValidateClienteDuplicado(txtNumeroDocumento.EditValue, cboTipoDocumento.EditValue)
        End If

        If Result Then
            'Se carga la entidad
            With clientesBE
                .IdCliente = ClienteFidelizadoDAO.IdCliente
                .IdTipoIdentidad = cboTipoDocumento.EditValue
                .NumeroDocumento = txtNumeroDocumento.EditValue
                .Nombres = txtNombre.EditValue.ToUpper()
                .ApellidoPaterno = txtApellidoPaterno.EditValue.ToUpper()
                .ApellidoMaterno = txtApellidoMaterno.EditValue.ToUpper()
                .NombrePreferido = txtNombrePreferido.EditValue.ToUpper()
                .Telefono = txtTelefono.EditValue
                .Correo = txtCorreo.EditValue
                .FechaNacimiento = dtFechaNacimiento.EditValue
                .IdGenero = cboGenero.EditValue
                .Ubigeo = cboDistrito.EditValue
                .Ubigeo = txtUbigeo.EditValue
                .Direccion = txtDireccion.EditValue.ToUpper()
                .UrlConsentimiento = ""
                .Estado = chkActivo.EditValue
                .FechaRegistro = System.DateTime.Now()
                .Puntos = .Puntos
            End With
        End If
        Return Result
    End Function
    Public Sub LoadEntidad()
        Try
            If ClienteFidelizadoDAO.IdCliente = 0 Then
                'Al crear un cliente debe estar oculto la autorización de datos personales.
                Ocultar_objetos_autdatospersonales()

            Else
                'Se carga la entidad
                clientesBE = ClienteFidelizadoDAO.GetbyidClienteFidelizado(ClienteFidelizadoDAO.IdCliente)
                clientesBE.mc_clientedetalle = ClienteFidelizadoDAO.GetbyidClienteFidelizadoDetalle(ClienteFidelizadoDAO.IdCliente)
                bsclientefidelizadodetalle.DataSource = clientesBE.mc_clientedetalle
                With clientesBE
                    txtidCliente.Text = "N°: " + .IdCliente.ToString + "| Total de puntos: " + .Puntos.ToString
                    cboTipoDocumento.EditValue = .IdTipoIdentidad
                    txtNumeroDocumento.EditValue = .NumeroDocumento
                    txtNombre.EditValue = .Nombres
                    txtApellidoPaterno.EditValue = .ApellidoPaterno
                    txtApellidoMaterno.EditValue = .ApellidoMaterno
                    txtNombrePreferido.EditValue = .NombrePreferido
                    txtTelefono.EditValue = .Telefono
                    txtCorreo.EditValue = .Correo
                    dtFechaNacimiento.EditValue = .FechaNacimiento
                    cboGenero.EditValue = .IdGenero
                    cboDistrito.EditValue = .Ubigeo
                    txtUbigeo.EditValue = .Ubigeo
                    txtDireccion.EditValue = .Direccion
                    .UrlConsentimiento = ""
                    chkActivo.EditValue = .Estado
                End With
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboDistrito_EditValueChanged(sender As Object, e As EventArgs) Handles cboDistrito.EditValueChanged
        txtUbigeo.Text = cboDistrito.EditValue
    End Sub

    Private Sub btnValidacionReniec_Click(sender As Object, e As EventArgs) Handles btnValidacionReniec.Click
        Try
            Dim api = New APIReniec()
            Dim ResponseReniec As New ResponseReniec
            ResponseReniec = api.ValidateReniec(txtNumeroDocumento.Text)
            cboTipoDocumento.EditValue = ResponseReniec.tipoDocumento
            txtNumeroDocumento.Text = ResponseReniec.numeroDocumento
            txtNombre.Text = ResponseReniec.nombres
            txtApellidoPaterno.Text = ResponseReniec.apellidoPaterno
            txtApellidoMaterno.Text = ResponseReniec.apellidoMaterno
        Catch ex As Exception
            MessageBox.Show("Numero de documento no valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
End Class