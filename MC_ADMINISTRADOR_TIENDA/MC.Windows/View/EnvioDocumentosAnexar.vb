Imports MC.Data
Imports MC.Framework
Imports MC.Report

Public Class EnvioDocumentosAnexar

    Dim bsDocumentos As New BindingSource

    Public Sub New()
        InitializeComponent()

        'DOCUMENTOS
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CORRELATIVO", "CORRELATIVO", 90, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDTIPODOCUMENTO", "IDTIPODOCUMENTO", 120, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DOCUMENTO", "TIPODOCUMENTO", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DOCUMENTO", "NUMERODOCUMENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RUC", "RUC", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PROVEEDOR", "PROVEEDOR", 240, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("TIPODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RUC").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("PROVEEDOR").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Me.GridControl1.DataSource = bsDocumentos

        Refrescar()
    End Sub

    Public Sub Refrescar()
        Try
            bsDocumentos.DataSource = DocumentoDAO.GetByListadoDocumentosNoEnviados(DocumentoDAO.IDEnvio)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgregar.ItemClick

        If MessageBox.Show("¿Esta seguro de anexar el documento?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then

            Dim correlativo As String
            Dim numerodocumento As String
            Dim idtipodocumento As String

            correlativo = GridView1.GetFocusedRowCellValue("CORRELATIVO")
            numerodocumento = GridView1.GetFocusedRowCellValue("NUMERODOCUMENTO")
            idtipodocumento = GridView1.GetFocusedRowCellValue("IDTIPODOCUMENTO")

            DocumentoDAO.SaveDocumentoProcesadoAnexar(DocumentoDAO.IDEnvio, numerodocumento, correlativo, idtipodocumento)

            Me.Close()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

End Class