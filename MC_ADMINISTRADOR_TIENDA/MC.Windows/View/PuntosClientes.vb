Imports MC.Data
Imports MC.Framework

Public Class PuntosClientes

    Dim bsClientes As New BindingSource
    Dim DocumentoPuntosBE As New DocumentoPuntosBE

    Public Sub New()
        InitializeComponent()

        'Se inicializa los controles
        Me.Text = "CLIENTES FIDELIZADOS"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False


        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)

        'Se configura el control GridView
        ControlesDevExpress.InitGridViewColumn(GridView1, "IdCliente", "IdCliente", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IdTipoIdentidad", "IdTipoIdentidad", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO IDENTIDAD", "TipoIdentidad", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NumeroDocumento", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CLIENTE", "Cliente", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TELEFONO", "Telefono", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "GENERO", "Genero", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        With GridView1
            .Columns("IdCliente").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TipoIdentidad").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NumeroDocumento").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Cliente").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Telefono").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Genero").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        Refrescar()

    End Sub

    Public Sub Refrescar()
        Try
            bsClientes.DataSource = PuntosDAO.ListadoClientesFidelizados()
            Me.GridControl1.DataSource = bsClientes

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSeleccionar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSeleccionar.ItemClick
        If Not Tools.ConexionCentral("192.168.6.97", "MC_CENTRAL") Then
            MessageBox.Show("No existe conexion a la central de clientes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If GridView1.RowCount > 0 Then
            PuntosDAO.IdCliente = GridView1.GetFocusedRowCellValue("IdCliente")

            If PuntosDAO.IDCliente <> 0 Then
                'Enlace cliente documento
                With DocumentoPuntosBE
                    .tDocumento = PuntosDAO.tDocumento
                    .IdCliente = PuntosDAO.IdCliente
                    .IdTipoIdentidad = GridView1.GetFocusedRowCellValue("IdTipoIdentidad")
                    .NumeroDocumento = GridView1.GetFocusedRowCellValue("NumeroDocumento")
                    .Cliente = GridView1.GetFocusedRowCellValue("Cliente")
                End With

                PuntosDAO.DocumentoClienteInsert(DocumentoPuntosBE)

                'Asignar puntos a cliente

                Me.Close()
            Else
                MessageBox.Show("Seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        PuntosDAO.IDCliente = 0
        Me.Close()
    End Sub

End Class