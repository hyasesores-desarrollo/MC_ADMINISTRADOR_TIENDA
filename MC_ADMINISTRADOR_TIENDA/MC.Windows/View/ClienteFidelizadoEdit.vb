Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class ClienteFidelizadoEdit
    Dim clientesBE As New MC_clientesBE
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

        'Al crear un cliente debe estar oculto la autorización de datos personales.
        Ocultar_objetos_autdatospersonales()

        'Carga de controladores
        ControlesDevExpress.InitGridLookUpEdit(cboTipoDocumento, ClienteFidelizadoDAO.GetTipoDocumentoSUNAT(), "TipoDocumento", "Descripcion", 500)
        ControlesDevExpress.InitGridLookUpEdit(cboGenero, ClienteFidelizadoDAO.GetGenero(), "IDSEXO", "DESCRIPCION", 500)
        ControlesDevExpress.InitGridLookUpEdit(cboDistrito, ClienteFidelizadoDAO.GetDistritoUbigeo(), "IdUbigeo", "Distrito", 500)

        'Se posiciona el foco
        Me.ActiveControl = Me.cboTipoDocumento

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
                Case "Cerrar" : Cancelar()
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
                            Me.Close()
                        End If
                    End If
                    End If
            End If
        End If

    End Sub

    Public Sub Cancelar()

    End Sub

    Public Function Validar() As Boolean
        Dim Result As Boolean = True

        If Result Then
            'Se carga la entidad
            With clientesBE
                .IdTipoIdentidad = cboTipoDocumento.EditValue
                .NumeroDocumento = txtNumeroDocumento.EditValue
                .Nombres = txtNombre.EditValue
                .Apellidos = txtApellidoPaterno.EditValue + " " + txtApellidoMaterno.EditValue
                .NombrePreferido = txtNombrePreferido.EditValue
                .Telefono = txtTelefono.EditValue
                .Correo = txtCorreo.EditValue
                .FechaNacimiento = dtFechaNacimiento.EditValue
                .IdGenero = cboGenero.EditValue
                .IdDistrito = cboDistrito.EditValue
                .Ubigeo = txtUbigeo.EditValue
                .Direccion = txtDireccion.EditValue
                .UrlConsentimiento = ""
                .Estado = chkActivo.EditValue
                .FechaRegistro = System.DateTime.Now()
                .Puntos = 0
            End With
        End If

        Return Result
    End Function
    Public Sub LoadEntidad()
        Try
            If ClienteFidelizadoDAO.IdCliente = -1 Then

            Else
                'Se carga la entidad
                clientesBE = ClienteFidelizadoDAO.GetbyidClienteFidelizado(ClienteFidelizadoDAO.IdCliente)
                With clientesBE
                    cboTipoDocumento.EditValue = .IdTipoIdentidad
                    txtNumeroDocumento.EditValue = .NumeroDocumento
                    txtNombre.EditValue = .Nombres
                    txtApellidoPaterno.EditValue = .Apellidos
                    txtApellidoMaterno.EditValue = .Apellidos
                    txtNombrePreferido.EditValue = .NombrePreferido
                    txtTelefono.EditValue = .Telefono
                    txtCorreo.EditValue = .Correo
                    dtFechaNacimiento.EditValue = .FechaNacimiento
                    cboGenero.EditValue = .IdGenero
                    cboDistrito.EditValue = .IdDistrito
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

End Class