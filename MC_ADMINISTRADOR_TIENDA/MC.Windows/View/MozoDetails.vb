Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraEditors
Public Class MozoDetails

    Dim MozoBE As New MozoBE

    Public Sub New()
        InitializeComponent()

        'Se inicializa la entidad
        MozoBE = New MozoBE

        'Se inicializa el formulario y Se inicializa los controles generales
        Me.Text = "MANTENIMIENTO DE MOZOS - " & SistemaDAO.NombreLocal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False
        Me.txtcodigo.Enabled = False
        Me.txtdni.Enabled = True
        Me.txtnombres.Enabled = True
        Me.txtapellidopaterno.Enabled = True
        Me.txtapellidomaterno.Enabled = True
        Me.txtusuario.Enabled = False
        Me.txtpassword.Enabled = True

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnGuardar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G, "Ctrl + G")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnGuardarCerrar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A, "Ctrl + C")

        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnsiguiente, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right, "Ctrl + → ")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnanterior, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left, "Ctrl + ←")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se configura el formato
        ControlesDevExpress.TextEditFormat(txtcodigo, ControlesDevExpress.eTextEditFormat.Ninguno)
        ControlesDevExpress.TextEditFormat(txtdni, ControlesDevExpress.eTextEditFormat.Ninguno, 10)
        ControlesDevExpress.TextEditFormat(txtnombres, ControlesDevExpress.eTextEditFormat.Ninguno)
        ControlesDevExpress.TextEditFormat(txtapellidopaterno, ControlesDevExpress.eTextEditFormat.Ninguno)
        ControlesDevExpress.TextEditFormat(txtapellidomaterno, ControlesDevExpress.eTextEditFormat.Ninguno)
        ControlesDevExpress.TextEditFormat(txtusuario, ControlesDevExpress.eTextEditFormat.Ninguno)
        ControlesDevExpress.TextEditFormat(txtpassword, ControlesDevExpress.eTextEditFormat.Ninguno)

        'Se desactiva los botones Siguiente y Anterior cuando el registro es nuevo
        If MozoDAO.CODIGO = "" Then
            btnanterior.Enabled = False
            btnsiguiente.Enabled = False
            ChkEstado.Checked = True
        End If

        'Se enlaza keypress con textbox solo numeros
        AddHandler txtdni.KeyPress, AddressOf Tools.SoloNumeros

        'Se posiciona el foco
        Me.ActiveControl = Me.txtdni

        'Se carga la entidad
        LoadEntidad()

    End Sub

    Private Sub DocumentoDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick, btnGuardarCerrar.ItemClick, btnCerrar.ItemClick, btnsiguiente.ItemClick, btnanterior.ItemClick

        Try
            Select Case e.Item.Caption
                Case "Guardar" : Guardar()
                Case "Guardar y Cerrar" : GuardarCerrar()
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
            Dim dt As New DataTable
            With dt.Columns
                .Add("nombre")
                .Add("apellidopaterno")
                .Add("apellidomaterno")
            End With

            If MozoDAO.CODIGO = "" Then
                txtcodigo.Text = ""
            Else
                'Se carga la entidad
                MozoBE = MozoDAO.GetByID()

                'Validar Nombre Compuesto
                If MozoBE.NOMBRECOMPUESTO = "" Then
                    dt.Rows.Add("", "", "")
                Else
                    dt = Tools.DivideNombresApellidos(MozoBE.NOMBRECOMPUESTO)
                End If

                With MozoBE
                    txtcodigo.Text = .CODIGO
                    txtdni.Text = .DNI
                    txtnombres.Text = dt.Rows(0).Item("nombre")
                    txtapellidopaterno.Text = dt.Rows(0).Item("apellidopaterno")
                    txtapellidomaterno.Text = dt.Rows(0).Item("apellidomaterno")
                    txtusuario.Text = .RESUMIDO
                    txtpassword.Text = Tools.Desencapsula(.PASSWORD)
                    ChkEstado.Checked = .ESTADO
                    ChkPermite.Checked = .PERMITEVER
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Guardar()

        If Me.Validar() Then
            If MozoDAO.GetByDNI(txtdni.Text, txtcodigo.Text) = 0 Then
                MozoDAO.Save(MozoBE)
                MozoList.btnRefresh.PerformClick()
            Else
                MessageBox.Show("El Dni ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        'Se obtiene el ID
        txtcodigo.Text = MozoDAO.CODIGO
    End Sub

    Public Sub GuardarCerrar()
        If MozoDAO.GetByDNI(txtdni.Text, txtcodigo.Text) = 0 Then
            If Me.Validar() Then
                MozoDAO.Save(MozoBE)
                MozoList.btnRefresh.PerformClick()
                Me.Close()
            Else
                MessageBox.Show("El Dni ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        'Se obtiene el ID
        txtcodigo.Text = MozoDAO.CODIGO

    End Sub

    Public Sub Siguiente()
        MozoList.GridView1.MoveNext()
        MozoDAO.CODIGO = MozoList.GridView1.GetFocusedRowCellValue("Codigo")
        LoadEntidad()

    End Sub

    Public Sub Anterior()
        MozoList.GridView1.MovePrev()
        MozoDAO.CODIGO = MozoList.GridView1.GetFocusedRowCellValue("Codigo")
        LoadEntidad()

    End Sub

    Public Sub Cerrar()
        Me.Close()
    End Sub

    Public Function Validar() As Boolean
        Dim Result As Boolean = False
        Dim Estado As Boolean = False

        If ChkEstado.Checked = False Then
            Result = True
            Estado = True
        Else
            'Se valida los campos obligatorios
            'If txtdni.Text.Length = 8 Then
            If Tools.CampoObligatorio(txtdni, eValidaControl.TextEdit) Then
                If Tools.CampoObligatorio(txtnombres, eValidaControl.TextEdit) Then
                    If Tools.CampoObligatorio(txtapellidopaterno, eValidaControl.TextEdit) Then
                        If Tools.CampoObligatorio(txtapellidomaterno, eValidaControl.TextEdit) Then
                            If Tools.CampoObligatorio(txtpassword, eValidaControl.TextEdit) Then
                                Result = True
                            End If
                        End If
                    End If
                End If
            End If
            'End If
        End If


        If Result Then
            'Se carga la entidad
            With MozoBE
                .CODIGO = txtcodigo.Text
                .DNI = txtdni.Text
                If Estado = True Then
                Else
                    .RESUMIDO = txtnombres.Text.Substring(0, 1) + txtapellidopaterno.Text
                    txtusuario.Text = .RESUMIDO
                    .DETALLADO = txtnombres.Text + " " + txtapellidopaterno.Text + " " + txtapellidomaterno.Text
                End If
                .PASSWORD = Tools.Encapsula(txtpassword.Text)
                .ESTADO = ChkEstado.Checked
                .PERMITEVER = ChkPermite.Checked
                .NOMBRECOMPUESTO = txtnombres.Text + "|" + txtapellidopaterno.Text + "|" + txtapellidomaterno.Text

            End With
        Else
            MessageBox.Show("El registro de datos no cumple con las reglas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return Result
    End Function

End Class