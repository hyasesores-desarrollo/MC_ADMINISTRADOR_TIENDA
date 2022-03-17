Imports MC.Data
Imports MC.Framework
Public Class PromocionCodigoTickectList
    Dim bsBeneficiosNorkys As New BindingSource
    Sub New()

        InitializeComponent()
        Me.Text = "CONSULTA CÓDIGO PROMOCIÓN TICKECT"
        Me.KeyPreview = True
        Me.WindowState = FormWindowState.Maximized
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDBENEFICIONORKYSEMPLEADO", 80, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE TRABAJADOR", "NOMBREEMPLEADO", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO EMPLEADO", "NUMERODOCUMENTO", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO PEDIDO", "NUMEROPEDIDO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA CONSUMO", "FECHACONSUMO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CANAL VENTA", "CANALVENTA", 250, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'UsuarioRegistroConsumo
        With GridView1
            .Columns("NOMBREEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMEROPEDIDO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHACONSUMO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CANALVENTA").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()


    End Sub
    Private Sub Refrescar()
        Try

            'bsBeneficiosNorkys.DataSource = BeneficioNorkysDAO.BeneficiosNorkysList(Tools.ReadAppSettings("IdLocal"))
            'GridControl1.DataSource = bsBeneficiosNorkys
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BeneficiosNorkys_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
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