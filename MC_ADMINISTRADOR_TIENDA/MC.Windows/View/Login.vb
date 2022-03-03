Imports DevExpress.XtraSplashScreen
Imports MC.Data
Imports MC.Framework

Public Class Login
    Dim UsuarioBE As New UsuarioBE

    Public Sub New()

        Dim ClienteFidelizadoDAO = New ClienteFidelizadoDAO()
        Dim cliente = New MC_clientes()
        cliente.IdCliente = 2
        cliente.IdTipoIdentidad = 7
        cliente.NumeroDocumento = 47163511
        cliente.Nombres = "Manuel"
        cliente.Apellidos = "Velásquez Pérez"
        cliente.NombrePreferido = "Manuman"
        cliente.Telefono = "993992048"
        cliente.Correo = "mvelasquez@hyasesores.pe"
        cliente.FechaNacimiento = "01-03-2022"
        cliente.IdGenero = 1
        cliente.IdDistrito = 11
        cliente.Ubigeo = "110105"
        cliente.Direccion = "Los cactuz 148 - chaclacayo"
        cliente.UrlConsentimiento = "www.url.com"
        cliente.Estado = True
        cliente.FechaRegistro = "01-03-2022"
        cliente.Puntos = 10

        Dim result = ClienteFidelizadoDAO.GetallClienteFidelizado()
        Dim result2 = ClienteFidelizadoDAO.GetbyidClienteFidelizado(1)
        Dim result3 = ClienteFidelizadoDAO.GetbyidClienteFidelizadoDetalle(1)
        Dim result4 = ClienteFidelizadoDAO.CreateClienteFidelizado(cliente)
        Dim result5 = ClienteFidelizadoDAO.UpdateClienteFidelizado(cliente)
        Dim result6 = ClienteFidelizadoDAO.DeleteClienteFidelizado(2)

        'This call is required by the designer.
        InitializeComponent()

        SplashScreenManager.ShowForm(GetType(SplashScreenLogin), True, True)
        If (SistemaDAO.conexionLocal(ServidorCentral)) Then 'Si existe conexion a la 97 MC_CENTRAL
            TipoConexion = True
        Else
            TipoConexion = False
        End If
        SplashScreenManager.CloseForm()

        If TipoConexion Then
            'Valida Versión
            If Not Tools.ValidaVersion(7) Then
                Dim proces As New Process()
                MessageBox.Show("Se ha encontrado una versión mas actualizada del sistema" & Chr(13) & "Se esta procediendo a descargar la actualización", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Try
                    'Se pone la ruta a actualizar en duro porque puede haber errores cuando se instale los programas
                    My.Computer.Network.DownloadFile("https://actualizadores.blob.core.windows.net/administradortienda/Actualizador.zip", "actualizador.zip", "", "", True, 500, True)

                Catch ex As Exception
                    MessageBox.Show("Error al actualizar, verificar si se tiene conexión a Internet", "Actualizador", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End Try
                proces.StartInfo.FileName = “Actualizador.exe”
                proces.Start()
                Me.Close()
            End If
        End If

        'Se inicializa los controles
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KeyPreview = True

        'Se inicializa los controles generales
        txtUsuario.Properties.MaxLength = 15
        txtContrasena.Properties.MaxLength = 15

        'Se ingresa solo letras, numeros y tres caracteres especiales
        txtUsuario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        txtUsuario.Properties.Mask.EditMask = "[a-zñA-Z0-9_$@]*"
        txtContrasena.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        txtContrasena.Properties.Mask.EditMask = "[a-zñA-Z0-9_$@]*"

        'Se asocia el evento KeyDown al procedimiento Teclado
        AddHandler Me.KeyDown, AddressOf Me.Teclado

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Tools.ReadAppSettings("Usuario").Length > 0 Then
            txtUsuario.Text = Tools.ReadAppSettings("Usuario")

            chkRecordar.Checked = True
        End If
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click

        If Validar() Then

            If chkRecordar.Checked Then
                Tools.SaveAppSettings("Usuario", txtUsuario.Text.Trim)
            Else
                Tools.SaveAppSettings("Usuario", "")
            End If
            Me.Hide()
            DesktopMain.Show()
        End If
    End Sub

    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtContrasena.Text.Trim.Length > 0 Then
                btnIniciarSesion.PerformClick()
            End If
        End If
    End Sub

    Private Function Teclado(sender As Object, e As KeyEventArgs) As KeyEventArgs

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

            Case Keys.F1
                MessageBox.Show("Ayuda no esta disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select

        Return e
    End Function

    Private Function Validar() As Boolean
        Dim Result As Boolean = False
        Static NumIntentosLogin As Int16 = 0

        'Se carga la entidad
        With UsuarioBE
            .Usuario = txtUsuario.Text
            .Contrasena = txtContrasena.Text
        End With

        'Se valida los campos obligatorios
        If Tools.CampoObligatorio(txtUsuario) Then
            If Tools.CampoObligatorio(txtContrasena) Then
                Result = True
            End If
        End If

        If Result Then

            SistemaDAO.UsuarioBE = UsuarioDAO.GetByLoginPassword(UsuarioBE.Usuario, Tools.Encapsula(UsuarioBE.Contrasena))
            SistemaDAO.NombrePC = My.Computer.Name

            If NumIntentosLogin > 3 Then
                MessageBox.Show("Ha superado el numero de intentos de validación del usuario.Contacte con el área de sistemas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.Exit()
            End If

            If SistemaDAO.UsuarioBE.tCodigoUsuario = Nothing Then
                NumIntentosLogin += 1
                txtUsuario.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                txtUsuario.ErrorText = "El nombre de usuario y contraseña no existe, intente con otro."
                txtContrasena.Text = ""
                txtUsuario.Focus()
                Result = False
            End If

        End If

        Return Result
    End Function

End Class