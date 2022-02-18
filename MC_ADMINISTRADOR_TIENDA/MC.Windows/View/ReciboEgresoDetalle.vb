Imports MC.Framework

Public Class ReciboEgresoDetalle

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.Text = "RECIBO DE EGRESO"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KeyPreview = True
        'Se carga el estado del documento
        ControlesDevExpress.InitGridLookUpEdit(cboTipoEgreso, SistemaDAO.GetTipoEgresos(), "Codigo", "tResumido")
        ControlesDevExpress.InitGridLookUpEditColumns(cboTipoEgreso, "Codigo", "tResumido", 120)
        ControlesDevExpress.InitGridLookUpEdit(cboMoneda, SistemaDAO.GetTipoMoneda(), "Codigo", "tResumido")
        ControlesDevExpress.InitGridLookUpEditColumns(cboMoneda, "Codigo", "tResumido", 120)
        lblTipoActual.Text = tTipoEgresoSeleccionado
        lblMoneda.Text = tTipoMonedaSeleccionado
        AddHandler Me.KeyDown, AddressOf Tools.Teclado
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick, btnCerrar.ItemClick
        Try
            Select Case e.Item.Caption
                Case "Guardar y Cerrar" : GuardarCerrar()
                Case "Cerrar" : Cerrar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub GuardarCerrar()
        If cboTipoEgreso.Text <> "" And cboMoneda.Text <> "" Then
            SistemaDAO.SaveReciboEgreso(tReciboEgresoSeleccionado, cboTipoEgreso.EditValue, Tools.ReadAppSettings("Usuario").ToUpper, cboMoneda.EditValue)
            Cerrar()
        Else
            MessageBox.Show("Debe seleccionar Tipo Egreso y Moneda")
        End If
    End Sub

    Public Sub Cerrar()
        Me.Close()
    End Sub

End Class