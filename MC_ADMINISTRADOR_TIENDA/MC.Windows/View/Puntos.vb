Imports DevExpress.XtraReports.UI
Imports MC.Data
Imports MC.Framework

Public Class Puntos

    Dim bsDocumentos As New BindingSource
    Dim DocumentoPuntosBE As New DocumentoPuntosBE

    Public Sub New()
        InitializeComponent()

        'Se inicializa los controles
        Me.Text = "DOCUMENTOS - CLIENTES FIDELIZADOS"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False


        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnFiltrar, System.Windows.Forms.Keys.F5, "F5")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)

        'Se configura el control GridView
        ControlesDevExpress.InitGridViewColumn(GridView1, "IdCliente", "IdCliente", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "tDocumento", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CAJA", "tCaja", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TURNO", "tTurno", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FEC.EMISION", "fRegistro", 100, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TOTAL", "nVenta", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "Estado", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO IDENTIDAD", "NumeroDocumento", 160, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CLIENTE", "Cliente", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("tDocumento").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("tCaja").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("tTurno").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("fRegistro").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("nVenta").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Estado").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NumeroDocumento").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Cliente").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        btnFechaInicial.EditValue = DateTime.Now.Date.AddDays(-2)
        btnFechaFinal.EditValue = DateTime.Now.Date

        Refrescar()

    End Sub

    Public Sub Refrescar()
        Try
            bsDocumentos.DataSource = DocumentoVentaDAO.ListadoDocumentosPuntos(btnFechaInicial.EditValue, btnFechaFinal.EditValue)
            Me.GridControl1.DataSource = bsDocumentos

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFiltrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiltrar.ItemClick
        Refrescar()
    End Sub

    Private Sub btnAsignar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAsignar.ItemClick

        If Not Tools.ConexionCentral("192.168.6.97", "MC_CENTRAL") Then
            MessageBox.Show("No existe conexion a la central de clientes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If GridView1.RowCount > 0 Then
            PuntosDAO.tDocumento = GridView1.GetFocusedRowCellValue("tDocumento")

            If Not PuntosDAO.tDocumento = "" Then
                Dim MiForm As New PuntosClientes
                MiForm.ShowDialog()

                Refrescar()
            Else
                MessageBox.Show("Seleccionar un documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        End If

    End Sub

    Private Sub btnQuitar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuitar.ItemClick

        If Not Tools.ConexionCentral("192.168.6.97", "MC_CENTRAL") Then
            MessageBox.Show("No existe conexion a la central de clientes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim IdCliente As Int32

        If GridView1.RowCount > 0 Then
            PuntosDAO.tDocumento = GridView1.GetFocusedRowCellValue("tDocumento")
            IdCliente = GridView1.GetFocusedRowCellValue("IdCliente")

            If Not PuntosDAO.tDocumento = "" And Not IdCliente = 0 Then
                With DocumentoPuntosBE
                    .tDocumento = PuntosDAO.tDocumento
                    .IdCliente = IdCliente
                End With

                'Quitar cliente documento
                PuntosDAO.DocumentoClienteDelete(DocumentoPuntosBE)

                'Quitar puntos cliente

            Else
                MessageBox.Show("Seleccionar un documento que tenga cliente fidelizado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Refrescar()
        End If
    End Sub

    Private Sub btnImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnImprimir.ItemClick
        If Not Tools.ConexionCentral("192.168.6.97", "MC_CENTRAL") Then
            MessageBox.Show("No existe conexion a la central de clientes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim IdCliente As Int32

        If GridView1.RowCount > 0 Then
            PuntosDAO.tDocumento = GridView1.GetFocusedRowCellValue("tDocumento")
            IdCliente = GridView1.GetFocusedRowCellValue("IdCliente")

            If Not IdCliente = 0 Then

                ImprimePuntosNorkys("")

            Else
                MessageBox.Show("El documento seleccionado no tiene cliente fidelizado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        End If

    End Sub

    Private Sub ImprimePuntosNorkys(ByVal Impresora As String)
        Dim MiImpresion As New ImpresionPuntos

        'Dim dtImprimirPuntos As New DataTable
        'dtImprimirPuntos = PedidoDAO.ImprimirPedidoDetallePrecuenta(PedidoDAO.tCodigoPedido)

        Dim printTool As New ReportPrintTool(MiImpresion)

        Try
            printTool.Print(Impresora)

        Catch ex As Exception 'Caso de no enconctrar la impresora envia a la pre determinada
            Dim instance As New Printing.PrinterSettings

            Dim impresosaPredt As String = instance.PrinterName

            printTool.Print(impresosaPredt)
        End Try

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub


    Private Sub Puntos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

End Class