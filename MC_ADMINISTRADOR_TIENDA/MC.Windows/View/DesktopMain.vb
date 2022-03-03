#Region "Imports"
Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraNavBar
Imports DevExpress.LookAndFeel
Imports System.Globalization
Imports DevExpress.XtraBars.Ribbon

#End Region

Public Class DesktopMain

    Dim dtsubmodulos As New DataTable

    Public Sub New()

        'Se configura la cultura de la aplicacion
        System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-PE")

        'Se carga el skin por defecto
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle(Tools.ReadAppSettings("Skin"))

        'Se actualiza la fuente de la aplicacion
        DevExpress.Utils.AppearanceObject.DefaultFont = New Font(Tools.ReadAppSettings("FuenteName"), Convert.ToSingle(Tools.ReadAppSettings("FuenteSize")), CType(Tools.ReadAppSettings("FuenteStyle"), System.Drawing.FontStyle))
        LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

        'Se inicializa los componentes del formulario
        InitializeComponent()

        'Se configura el formulario
        Me.KeyPreview = True
        AddHandler Me.KeyDown, AddressOf Me.Teclado
        Me.WindowState = FormWindowState.Maximized
        Me.Text = SistemaDAO.NombreAplicacion & " " & Application.ProductVersion
        Me.RibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always

        'Se carga los valores de la barra de estado
        btnUsuario.Caption = SistemaDAO.UsuarioBE.tResumido
        btnComputadora.Caption = My.Computer.Name
        btnEmpresa.Caption = "HY ASESORES SAC"
        btnFechaHora.Caption = DateTime.Now
        'btnTipoCambio.Caption = "Tipo Cambio Venta: " & SistemaDAO.TipoCambioBE.TipoCambioVenta & " - " & Format(SistemaDAO.TipoCambioBE.Fecha, "dd/MM/yyyy")

        dtsubmodulos = UsuarioDAO.GetSubModulos(SistemaDAO.UsuarioBE.tGrupoUsuario)
        If nombreTienda <> "" Then
            btnLocal.Caption = nombreTienda
            btnLocal.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End If
        'Se inicializa el Ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        'Se crea el control NavBar
        Dim ControlNavBar As New NavBarControl()
        Me.Controls.Add(ControlNavBar)

        ControlNavBar.BeginUpdate()
        ControlesDevExpress.InitNavBar(ControlNavBar)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"ADMINISTRACION COMPRAS", "Envio de Documentos Procesados"}, My.Resources.Administracion, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"ADMINISTRACION VENTAS", "Puntos", "Clientes Fidelizados", "Clientes Facturados", "Mantenimiento de Mozos", "Mantenimiento de Motorizados", "Nota de Credito", "Enlace Call Center", "Código de Promoción", "Beneficios Norkys"}, My.Resources.ControlInterno, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"CONTROL INTERNO", "Recibos de Egreso", "Documentos de Venta"}, My.Resources.ControlInterno, dtsubmodulos)
        ControlesDevExpress.InitNavBarMenuDesactiva(ControlNavBar, {"ASISTENCIA", "Marcacion de Asistencia", "Marcacion de Asistencia HY"}, My.Resources.Asistencia, dtsubmodulos)

        'Se enlaza evento al Control NavBar
        AddHandler ControlNavBar.LinkClicked, AddressOf DesktopMain_LinkClicked

        ControlNavBar.EndUpdate()

        'Timer1.Interval = 1500
        'Timer1.Start()

    End Sub

    Private Function Teclado(sender As Object, e As KeyEventArgs) As KeyEventArgs
        Select Case e.KeyCode
            Case Keys.F8
                btnLocal.PerformClick()
        End Select
        Return e
    End Function


    Private Sub DesktopMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub DesktopMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Update()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DesktopMain_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick, btnFuente.ItemClick
        Try
            Select Case e.Item.Caption
                Case "Fuente" : Fuente()
                Case "Salir del programa" : Salir()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DesktopMain_LinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)

        Select Case e.Link.Caption.ToString.ToUpper

            'ALMACEN
            Case "ENVIO DE DOCUMENTOS PROCESADOS" : OpenFormulario("EnvioDocumentosProcesados")

            'VENTAS
            Case "PUNTOS" : OpenFormulario("Puntos")

            Case "CLIENTES FIDELIZADOS" : OpenFormulario("ClienteFidelizadoList")
            Case "CLIENTES FACTURADOS" ': OpenFormulario("ClienteFacturadoEdit")
                Dim MiForm As New ClienteFacturadoEdit
                MiForm.ShowDialog()

            Case "MANTENIMIENTO DE MOZOS" : OpenFormulario("MozoList")
            Case "MANTENIMIENTO DE MOTORIZADOS" : OpenFormulario("MotorizadoList")
            Case "ENLACE CALL CENTER" : OpenFormulario("EnlaceCallCenter")
            Case "CÓDIGO DE PROMOCIÓN" : OpenFormulario("CodigoEntelList") 'Código de Promoción
            Case "BENEFICIOS NORKYS" : OpenFormulario("BeneficiosNorkys")
            Case "NOTA DE CREDITO"
                tCajaEmision = Tools.ReadAppSettings("Caja")
                tTurnoActual = CajaDAO.GetTurnoActivo(tCajaEmision)
                If tTurnoActual <> "" Then
                    OpenFormulario("NotaCreditoList")
                Else
                    MessageBox.Show("No existe turno aperturado para la caja : " & tCajaEmision, "Advertencia")
                End If

                'CONTROL INTERNO
            Case "RECIBOS DE EGRESO" : OpenFormulario("RecibosEgreso")
            Case "DOCUMENTOS DE VENTA" : OpenFormulario("DocumentosVentaEdicionList")

                'ASISTENCIA
            Case "MARCACION DE ASISTENCIA" : OpenFormulario("ControlAsistencia")
            Case "MARCACION DE ASISTENCIA HY" : OpenFormulario("ControlAsistenciaEmpleadoHY")

        End Select

    End Sub

    Public Sub OpenFormulario(NombreFormulario As String)
        Dim obj As Object
        Dim NombreAssembly As String = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name()

        'Se busca el formulario. Si no existe se crea la instancia, caso contrario solo se activa. 
        If Me.MdiChildren.ToList.Find(Function(Item) Item.Name = NombreFormulario) Is Nothing Then
            obj = Activator.CreateInstance(Type.GetType(NombreAssembly + "." + NombreFormulario))
            obj.MdiParent = Me
            obj.Name = NombreFormulario
            obj.WindowState = FormWindowState.Maximized
            obj.Show()
        Else
            For Each objForms In Me.MdiChildren
                If objForms.Name = NombreFormulario Then
                    objForms.WindowState = FormWindowState.Maximized
                    objForms.Show()
                End If
            Next
        End If

    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) 
        'Se muestra la fecha y hora cada 15 segundos
        btnFechaHora.Caption = DateTime.Now
    End Sub

    Private Sub rgbiSkins_GalleryItemClick(sender As Object, e As GalleryItemClickEventArgs) Handles rgbiSkins.GalleryItemClick
        Try
            'Se registra el skin que selecciona el usuario
            Tools.SaveAppSettings("Skin", e.Item.Caption)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Salir()
        If MessageBox.Show("¿Esta seguro de salir del programa?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Public Sub Fuente()
        Try
            'Se cambia la fuente de la aplicacion
            If FontDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                'Se actualiza la fuente de la aplicacion
                DevExpress.Utils.AppearanceObject.DefaultFont = New Font(FontDialog1.Font.Name, FontDialog1.Font.Size, FontDialog1.Font.Style)

                'Se reinicia estilo de la fuente
                LookAndFeelHelper.ForceDefaultLookAndFeelChanged()

                'Se registra la configuracion de la fuente
                Tools.SaveAppSettings("FuenteName", FontDialog1.Font.Name)
                Tools.SaveAppSettings("FuenteSize", FontDialog1.Font.Size)
                Tools.SaveAppSettings("FuenteStyle", FontDialog1.Font.Style)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUsuario_ItemClick(sender As Object, e As EventArgs) Handles btnUsuario.ItemClick

        If MessageBox.Show("¿Desea cerrar la sesión de usuario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then

            'Se cierra los formulario abiertos
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next

            'Se cierra la sesion de usuario y se reinicia la aplicacion
            Application.Restart()
        End If
    End Sub

    Private Sub btnLocal_ItemClick(sender As Object, e As EventArgs) Handles btnLocal.ItemClick
        'If Me.MdiChildren.Length = 0 Then
        '    MessageBox.Show("asdasd")
        'Else
        '    MessageBox.Show("Para poder cambiar de tienda, deberá cerrar todos los formularios", "Cambio de Tienda")
        'End If
    End Sub

End Class