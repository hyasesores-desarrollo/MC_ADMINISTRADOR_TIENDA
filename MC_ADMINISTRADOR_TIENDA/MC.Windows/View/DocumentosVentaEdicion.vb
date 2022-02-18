Imports MC.Framework
Public Class DocumentosVentaEdicion
    Dim resultado As Integer
    Dim tDocumentoDestino As String

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = "DOCUMENTO  DE VENTA"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KeyPreview = True
        Me.WindowState = FormWindowState.Normal
        'Se carga el estado del documento
        txtDocumentoOrigen.Text = ""
        txtPrefijoD.Text = ""
        txtCorrelativoD.Text = ""
        txtSerieD.Text = ""
        dtpFechaNueva.EditValue = Now
        txtDocumentoOrigen.Text = tDocumentoSeleccionado
        lblFecha.Text = fechaSeleccionado
        AddHandler Me.KeyDown, AddressOf Tools.Teclado
        txtPrefijoD.ReadOnly = True
        txtDocumentoOrigen.ReadOnly = True

        cargarDatos()
        rdbCorrelativo.Checked = True
        rdbFecha.Checked = False

    End Sub

    Public Sub cargarDatos()
        txtPrefijoD.Text = tDocumentoSeleccionado.Substring(0, 1)
    End Sub

    Public Sub Cerrar()
        Me.Close()
    End Sub

    Public Function validar()

        If txtPrefijoD.Text.Length = 0 Or txtSerieD.Text.Length = 0 Or txtCorrelativoD.Text.Length = 0 Then
            MessageBox.Show("Prefijo, Serie y Correlativo del Documento Destino son necesarios")
            Return False
        End If

        tDocumentoDestino = String.Concat(txtPrefijoD.Text.Trim(), txtSerieD.Text.Trim(), txtCorrelativoD.Text.Trim())

        If txtDocumentoOrigen.Text = tDocumentoDestino Then
            MessageBox.Show("Documento Origen y Destino no pueden ser iguales")
            Return False
        End If

        Return True
    End Function

    Public Sub GuardarCerrar()
        If rdbCorrelativo.Checked = True Then
            If validar() = True Then
                resultado = SistemaDAO.CambiaDocumento(txtDocumentoOrigen.Text, tDocumentoDestino)
                If resultado = 1 Or resultado = 0 Then
                    MessageBox.Show("Cambio realizado")
                    Cerrar()
                ElseIf resultado = 2 Then
                    MessageBox.Show("No existe Documento Origen")
                    txtSerieD.Focus()
                ElseIf resultado = 3 Then
                    MessageBox.Show("Documento Destino Existente")
                    txtSerieD.Focus()
                End If
            End If
        ElseIf rdbFecha.Checked = True Then
            If dtpFechaNueva.Text <> "" Then
                SistemaDAO.CambiaFechaDocumento(txtDocumentoOrigen.Text, dtpFechaNueva.EditValue)
                Cerrar()
            End If
        End If

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick, btnGuardar.ItemClick
        Try
            Select Case e.Item.Caption
                Case "Guardar y Cerrar" : GuardarCerrar()
                Case "Cerrar" : Cerrar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub rdbCorrelativo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCorrelativo.CheckedChanged
        If rdbCorrelativo.Checked = True Then
            grupoCorrelativo.Enabled = True
        Else
            grupoCorrelativo.Enabled = False
        End If

    End Sub

    Private Sub rdbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFecha.CheckedChanged
        If rdbFecha.Checked = True Then
            grupoFecha.Enabled = True
        Else
            grupoFecha.Enabled = False
        End If
    End Sub

    Private Sub txtSerieD_Leave(sender As Object, e As EventArgs) Handles txtSerieD.Leave
        Dim cadena As String
        cadena = txtSerieD.Text.Trim
        cadena = Microsoft.VisualBasic.Right(String.Concat("00000", cadena), 5)
        txtSerieD.Text = cadena
    End Sub

    Private Sub txtCorrelativoD_Leave(sender As Object, e As EventArgs) Handles txtCorrelativoD.Leave
        Dim cadena As String
        cadena = txtCorrelativoD.Text.Trim
        cadena = Microsoft.VisualBasic.Right(String.Concat("000000000", cadena), 9)

        txtCorrelativoD.Text = cadena
    End Sub

End Class