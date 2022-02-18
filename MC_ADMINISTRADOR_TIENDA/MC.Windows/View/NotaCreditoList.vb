#Region "Imports"
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraBars
#End Region

Public Class NotaCreditoList
    Dim bsNotaCredito As New BindingSource
    Dim PreNotaCreditoBE As New NotaCreditoBE

    Public Sub New()
        InitializeComponent()
        'Se inicializa los controles
        Me.Text = " LISTADO DE NOTAS DE CREDITO "
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnNuevo, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E, "Ctrl + N")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnEditar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E, "Ctrl + E")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnRefresh, System.Windows.Forms.Keys.F5, "F5")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)
        ControlesDevExpress.InitGridView(GridView1)

        'ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "idPreNotaCredito", 50, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "NRO NOTA CREDITO", "tNroNotaCredito", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA DE EMISIÓN", "fFechaEmision", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DOCUMENTO AFECTADO", "tNombreTipoDocumento", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "NRO DOCUMENTO AFECTADO", "tNroDocumentoAfectado", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DE IDENTIDAD", "tNombreTipoIdentidad", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "NRO DE IDENTIDAD", "tNroIdentidad", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE O RAZON SOCIAL", "tNombreRazonSocial", 180, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE TOTAL", "nImporteTotal", 90, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "tNombreEstado", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA REGISTRO", "fRegistro", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGO CREDITO", "tNotaCredito", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NRO NOTA CREDITO", "NumeroNotaCredito", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA DE EMISIÓN", "fFecha", 120, True, ControlesDevExpress.eGridViewFormato.Fecha, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO DOCUMENTO AFECTADO", "TipoDocumento", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NRO DOCUMENTO AFECTADO", "tDocumento", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE TOTAL", "nVenta", 90, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "Estado", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CAJA", "Caja", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "OBSERVACION", "tObservacion", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = bsNotaCredito

        AddHandler Me.btnNuevo.ItemClick, AddressOf Nuevo
        AddHandler Me.btnEditar.ItemClick, AddressOf Editar
        AddHandler Me.btnCerrar.ItemClick, AddressOf Cerrar
        AddHandler Me.GridView1.DoubleClick, AddressOf btnEditar.PerformClick

        'Se carga los datos
        Refrescar()
    End Sub

    Public Sub Cerrar()
        Me.Close()
    End Sub

    Private Sub NotaCreditoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Public Sub Nuevo()
        Try
            'NotaCreditoDAO.IDNotaCredito = 0
            NotaCreditoDAO.tNotaCredito = ""

            Dim MiForm As New NotaCreditoDetails
            MiForm.ShowDialog()

            Refrescar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Refrescar()
        bsNotaCredito.DataSource = NotaCreditoDAO.GetListadoNotaCredito
    End Sub

    Public Sub Editar()
        Try
            If GridView1.RowCount > 0 Then
                'NotaCreditoDAO.IDNotaCredito = GridView1.GetFocusedRowCellValue("idPreNotaCredito")
                NotaCreditoDAO.tNotaCredito = GridView1.GetFocusedRowCellValue("tNotaCredito")
                EstadoNotaC = GridView1.GetFocusedRowCellValue("Estado")

                Dim MiForm As New NotaCreditoDetails
                MiForm.ShowDialog()

                Refrescar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnRefresh.ItemClick
        Refrescar()
    End Sub
End Class