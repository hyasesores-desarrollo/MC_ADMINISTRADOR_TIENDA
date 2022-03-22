Imports MC.Data
Imports MC.Framework
Public Class CodigoEntelList
    Dim bsCodigoEntelList As New BindingSource
    Sub New()

        InitializeComponent()
        Me.Text = "CONSULTA CÓDIGO PROMOCIÓN DIGITAL"
        Me.KeyPreview = True
        Me.WindowState = FormWindowState.Maximized
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDPEDIDOCODIGOENTEL", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Nª PEDIDO", "CODIGOPEDIDO", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGO PROMOCIÓN", "CODIGOENTEL", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MEDIO REGISTRO CONSUMO", "MedioRegistroConsumo", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CANAL DE VENTA", "canalventa", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'UsuarioRegistroConsumo
        With GridView1
            .Columns("CODIGOPEDIDO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CODIGOENTEL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("MedioRegistroConsumo").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("canalventa").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        dteFechaInicial.EditValue = DateTime.Now.Date.AddDays(-2)
        dteFechaFinal.EditValue = DateTime.Now.Date

        AddHandler dteFechaFinal.EditValueChanged, AddressOf Refrescar
        Refrescar()


    End Sub
    Private Sub Refrescar()
        Try

            bsCodigoEntelList.DataSource = CodigoEntelDAO.CodigoEntelList(dteFechaInicial.EditValue, dteFechaFinal.EditValue)
            GridControl1.DataSource = bsCodigoEntelList
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnConsultar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConsultar.ItemClick
        Dim MiForm As New CodigoEntelDetails
        MiForm.ShowDialog()
        Refrescar()
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    'Private Sub CodigoEntelList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    'End Sub

    Private Sub btnRefrescar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefrescar.ItemClick
        Refrescar()
    End Sub
End Class