Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class MotorizadoDetails

    Dim MotorizadoBE As New MotorizadoBE

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'Se inicializa la entidad
        MotorizadoBE = New MotorizadoBE

        'Se inicializa el formulario y Se inicializa los controles generales
        Me.Text = "MANTENIMIENTO DE MOTORIZADOS - " & SistemaDAO.NombreLocal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False


        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnGuardar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G, "Ctrl + G")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnGuardarCerrar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A, "Ctrl + C")

        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnsiguiente, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right, "Ctrl + → ")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnanterior, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left, "Ctrl + ←")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se desactiva los botones Siguiente y Anterior cuando el registro es nuevo
        If MotorizadoDAO.CODIGO = "" And MotorizadoDAO.IdMotorizadoDetalle = 0 Then
            btnanterior.Enabled = False
            btnsiguiente.Enabled = False
        Else
            btnanterior.Enabled = True
            btnsiguiente.Enabled = True
        End If
        cboMotorizado.Enabled = True
        txtdni.Enabled = False
        'txtDescripcion.Enabled = False
        'chkActivo.Checked = True

        ControlesDevExpress.InitGridLookUpEditSearch(cboMotorizado, MotorizadoDAO.GetByEmpleado(), "IDEMPLEADO", "EMPLEADO", 500)
        ControlesDevExpress.InitGridLookUpEditSearchColumns(cboMotorizado, "EMPLEADO", "EMPLEADO", 150)
        ControlesDevExpress.InitGridLookUpEditSearchColumns(cboMotorizado, "DNI", "NUMERODOCUMENTO", 50)

        'ControlesDevExpress.InitGridLookUpEditSearch(cboTipoComision, MotorizadoDAO.GetByTipoComision(), "IdTipoComisionMotorizado", "Descripcion", 500)
        'ControlesDevExpress.InitGridLookUpEditSearchColumns(cboTipoComision, "COMISIÓN", "Descripcion", 150)

        ControlesDevExpress.InitGridLookUpEditSearch(cboTipoMotorizado, MotorizadoDAO.GetByTipoMotorizado(), "IdTipoMotorizado", "Descripcion", 500)
        ControlesDevExpress.InitGridLookUpEditSearchColumns(cboTipoMotorizado, "TIPO MOTORIZADO", "Descripcion", 150)

        'Se posiciona el foco
        Me.ActiveControl = Me.cboMotorizado

        CargarTipoComision()
        'Se carga la entidad
        LoadEntidad()

    End Sub
    Private Sub CargarTipoComision()
        ControlesDevExpress.InitGridViewColumn(GridViewTipoComision, "IdTipoComisionMotorizado", "IdTipoComisionMotorizado", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridViewTipoComision, "Descripcion", "Descripcion", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridViewTipoComision
            .Columns("Descripcion").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        sleTipoComision.Properties.DataSource = MotorizadoDAO.GetByTipoComision()
        sleTipoComision.Properties.DisplayMember = "Descripcion"
        sleTipoComision.Properties.ValueMember = "IdTipoComisionMotorizado"
        sleTipoComision.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub
    Private Sub DocumentoDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick, btnGuardarCerrar.ItemClick, btnCerrar.ItemClick, btnsiguiente.ItemClick, btnanterior.ItemClick

        Try
            Select Case e.Item.Caption
                Case "Guardar" : Guardar()
                'Case "Guardar y Cerrar" : GuardarCerrar()
                Case "Siguiente" : Siguiente()
                Case "Anterior" : Anterior()
                Case "Cerrar" : Cerrar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub LoadEntidad()
        Try

            If MotorizadoDAO.CODIGO = "" Then
                cboMotorizado.EditValue = ""

            Else
                'Se carga la entidad
                MotorizadoBE = MotorizadoDAO.GetByIDMotorizadoDetalle(MotorizadoDAO.IdMotorizadoDetalle)
                With MotorizadoBE
                    sleTipoComision.EditValue = .IDTIPOCOMISION
                    sleTipoComision.EditValue = .IDTIPOCOMISION
                    cboTipoMotorizado.EditValue = .IDTIPOMOTORIZADO
                    cboMotorizado.EditValue = .IDEMPLEADO
                    txtDescripcion.Text = .DETALLADO
                    txtdni.Text = .DOCUMENTOIDENTIDAD
                    chkActivo.Checked = .ACTIVO
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Guardar()

        If Me.Validar() Then
            If MessageBox.Show("Estas seguro de Grabar", "Mensaje Validadción", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If My.Computer.Network.Ping(IPServerCentral) Then 'REALIZA PIN A LA CENTRAL
                    If Tools.ConexionCentral(IPServerCentral, BdCentral) Then ' VERIFICA CONEXION BD_CODIGO_ENTEL
                        If MotorizadoDAO.SaveInforest(MotorizadoBE) Then
                            MotorizadoDAO.SaveCentral(MotorizadoBE)
                            MotorizadoList.btnRefresh.PerformClick()
                            Me.Close()
                        End If
                    Else
                        MessageBox.Show("EEROR DE CONEXIÓN CON LA BASE DE DATOS")
                    End If
                Else

                    MessageBox.Show("EEROR DE CONEXIÓN CON EL SERVIDOR")
                End If
            End If

        End If
    End Sub
    Public Sub Siguiente()
        MotorizadoList.GridView1.MoveNext()
        MotorizadoDAO.IdMotorizadoDetalle = MotorizadoList.GridView1.GetFocusedRowCellValue("IdMotorizadoDetalle")
        LoadEntidad()

    End Sub

    Public Sub Anterior()
        MotorizadoList.GridView1.MovePrev()
        MotorizadoDAO.IdMotorizadoDetalle = MotorizadoList.GridView1.GetFocusedRowCellValue("IdMotorizadoDetalle")
        LoadEntidad()

    End Sub

    Public Sub Cerrar()
        Me.Close()
    End Sub

    Public Function Validar() As Boolean
        Dim Result As Boolean = False
        Dim Estado As Boolean = False
        'Se valida los campos obligatorios
        If cboTipoMotorizado.EditValue = 1 Then
            If Tools.CampoObligatorio(cboMotorizado, eValidaControl.SearchLookUpEdit) And Tools.CampoObligatorio(sleTipoComision, eValidaControl.SearchLookUpEdit) Then
                Result = True
            End If
        Else
                If Tools.CampoObligatorio(txtDescripcion, eValidaControl.TextEdit) Then
                    Result = True
                End If
            End If

        If Result Then
            'Se carga la entidad
            With MotorizadoBE
                .IDMOTORIZADODETALLE = MotorizadoDAO.IdMotorizadoDetalle
                .CODIGO = MotorizadoDAO.CODIGO
                '.TIPOCOMISION = IIf(optColaborador.Checked, 0, 1)
                .IDTIPOMOTORIZADO = cboTipoMotorizado.EditValue
                .DETALLADO = IIf(cboMotorizado.EditValue <> 0, cboMotorizado.Text, txtDescripcion.Text)
                .RESUMIDO = IIf(cboMotorizado.EditValue <> 0, cboMotorizado.Text.PadRight(24), txtDescripcion.Text.PadRight(24))
                .DOCUMENTOIDENTIDAD = txtdni.Text
                '.TIPOTARIFA = IIf(optComisionMotorizado.Checked, 0, 1)
                .IDTIPOCOMISION = IIf(cboTipoMotorizado.EditValue = 1, sleTipoComision.EditValue, 0)
                '.TARIFA = 0
                .IDEMPLEADO = IIf(cboTipoMotorizado.EditValue =1, cboMotorizado.EditValue, 0)
                .ACTIVO = chkActivo.Checked
                .USUARIO = SistemaDAO.UsuarioBE.tResumido
                .IDLOCAL = Tools.ReadAppSettings("IdLocal")
            End With

            Dim dt As DataTable = MotorizadoDAO.ValidarDuplicidadEmpleadoIns(MotorizadoDAO.IdMotorizadoDetalle, MotorizadoBE.IDEMPLEADO, MotorizadoBE.DETALLADO, MotorizadoBE.IDTIPOMOTORIZADO, MotorizadoBE.IDLOCAL)
            If dt.Rows(0)("Result") = 1 Then
                    MessageBox.Show(dt.Rows(0)("Mensaje"))
                    Result = False
                End If

            Else
                MessageBox.Show("El registro de datos no cumple con las reglas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        Return Result
    End Function

    Private Sub cboMotorizado_EditValueChanged(sender As Object, e As EventArgs) Handles cboMotorizado.EditValueChanged
        Try
            txtdni.Text = cboMotorizado.Properties.View.GetFocusedRowCellValue("NUMERODOCUMENTO")
            txtDescripcion.Text = cboMotorizado.Text
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboTipoMotorizado_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles cboTipoMotorizado.EditValueChanging
        If e.NewValue = 1 Then
            cboMotorizado.EditValue = 0
            cboMotorizado.Enabled = True

            'sleTipoComision.EditValue = 0
            sleTipoComision.Enabled = True
            txtDescripcion.Enabled = False
            txtDescripcion.Text = ""
        Else
            txtDescripcion.Enabled = True
            txtDescripcion.Text = ""
            sleTipoComision.EditValue = 0
            sleTipoComision.Enabled = False
            cboMotorizado.EditValue = 0
            cboMotorizado.Enabled = False
        End If
    End Sub

    'Private Sub cboTipoMotorizado_EnabledChanged(sender As Object, e As EventArgs) Handles cboTipoMotorizado.EnabledChanged
    '    If sleTipoComision.EditValue = 1 Then
    '        cboMotorizado.EditValue = 0
    '        cboMotorizado.Enabled = True

    '        sleTipoComision.EditValue = 0
    '        sleTipoComision.Enabled = True
    '        txtDescripcion.Enabled = False
    '        txtDescripcion.Text = ""
    '    Else
    '        txtDescripcion.Enabled = True
    '        txtDescripcion.Text = ""
    '        sleTipoComision.EditValue = 0
    '        sleTipoComision.Enabled = False
    '        cboMotorizado.EditValue = 0
    '        cboMotorizado.Enabled = False

    '    End If
    'End Sub
End Class