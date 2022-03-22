Imports MC.Data
Imports MC.Framework
Public Class PromocionCodigoTickectList
    Dim bsPromocionesCodigos As New BindingSource
    Sub New()

        InitializeComponent()
        Me.Text = "CONSULTA CÓDIGO PROMOCIÓN TICKECT"

        Me.KeyPreview = True
        Me.WindowState = FormWindowState.Maximized

        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "LOCAL", "LocalGeredadoTickect", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGO PROMOCION", "CodigoPromocion", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO PEDIDO", "NumeroPedidoCanje", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "LOCAL CANJE", "LocalCanje", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO REGISTRO CANJE", "UsuarioCanje", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA CANJE", "FechaCanje", 120, True, ControlesDevExpress.eGridViewFormato.FechaHora, False)
        'UsuarioRegistroConsumo
        With GridView1
            .Columns("LocalGeredadoTickect").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CodigoPromocion").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NumeroPedidoCanje").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("LocalCanje").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("UsuarioCanje").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FechaCanje").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()


    End Sub
    Private Sub Refrescar()
        Try

            bsPromocionesCodigos.DataSource = CodigoEntelDAO.PromocionesCodigosGetIdLocal(Tools.ReadAppSettings("IdLocal"))
            GridControl1.DataSource = bsPromocionesCodigos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Dim MiForm As New PromocionCodigoTickectDetails
        MiForm.ShowDialog()
        Refrescar()

    End Sub
End Class