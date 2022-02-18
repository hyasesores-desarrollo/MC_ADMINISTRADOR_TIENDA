Imports DevExpress.XtraGrid.Views.Grid
Imports MC.Data
Imports MC.Framework
Imports MC.Report

Public Class EnvioDocumentosProcesados

    Dim bsDocumentos As New BindingSource
    Dim DocumentoProcesadoBE As New DocumentoProcesadoBE

    Public Sub New()
        InitializeComponent()

        'DOCUMENTOS
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDENVIO", "IDENVIO", 90, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "LOCAL", "LOCAL", 90, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGO", "CODIGO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA INICIAL", "FECHAINICIAL", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA FINAL", "FECHAFINAL", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADO", 95, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "ESTADODESCRIPCION", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("CODIGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("ESTADODESCRIPCION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAINICIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAFINAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-7)
        btnFechaFinal.EditValue = DateTime.Now.Date

        AddHandler GridView1.DoubleClick, AddressOf Editar
        AddHandler btnEditar.ItemClick, AddressOf Editar

        Me.GridControl1.DataSource = bsDocumentos

        Refrescar()
    End Sub

    Public Sub Refrescar()
        Try
            bsDocumentos.DataSource = DocumentoDAO.GetByEnvioDocumentoListado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnvioDocumentosProcesados_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnGenerar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGenerar.ItemClick
        Dim dt As New DataTable
        dt = DocumentoDAO.GetByEnvioDocumentoListadoGenerado()

        If dt.Rows.Count > 0 Then
            MessageBox.Show("Un archivo actual se encuentra generado, no se puede generar otro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("¿Esta seguro de generar el archivo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                With DocumentoProcesadoBE
                    .IDEnvio = 0
                    .FechaInicial = btnFechaInicial.EditValue
                    .FechaFinal = btnFechaFinal.EditValue
                    .Estado = False
                End With

                DocumentoDAO.SaveDocumentoProcesado(DocumentoProcesadoBE)

                Refrescar()
            End If
        End If
    End Sub

    Private Sub btnEmitir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmitir.ItemClick
        If GridView1.GetFocusedRowCellValue("ESTADO") Then
            'EMITIR
            DocumentoDAO.IDEnvio = GridView1.GetFocusedRowCellValue("IDENVIO")

            Dim RPT As New XR_ENVIO_DOCUMENTO_REPORTE
            RPT.DataSource = DocumentoDAO.GetDocumentoEnvioReporte(DocumentoDAO.IDEnvio)

            RPT.DataMember = "Reporte"
            ReporteView.DocumentViewer1.DocumentSource = RPT

            ReporteView.DocumentViewer1.Refresh()
            ReporteView.Show()
        Else
            MessageBox.Show("El archivo actual no se encuentra enviado, no se puede emitir reporte", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminar.ItemClick
        If GridView1.GetFocusedRowCellValue("ESTADO") Then
            MessageBox.Show("El archivo actual ya se encuentra enviado, no se puede eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'ELIMINAR
            If MessageBox.Show("¿Esta seguro de eliminar el archivo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                DocumentoDAO.IDEnvio = GridView1.GetFocusedRowCellValue("IDENVIO")
                DocumentoDAO.DeleteDocumentoProcesado(DocumentoDAO.IDEnvio)

                Refrescar()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Public Sub Editar()
        If GridView1.GetFocusedRowCellValue("ESTADO") Then
            MessageBox.Show("El archivo actual ya se encuentra enviado, no se puede editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'EDITAR
            DocumentoDAO.IDEnvio = GridView1.GetFocusedRowCellValue("IDENVIO")

            Dim MiForm As New EnvioDocumentosProcesadosEdit
            MiForm.ShowDialog()

            Refrescar()

        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub EnvioDocumentosProcesados_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub
End Class