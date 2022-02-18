Imports System.Threading
Imports MC.Framework

Public Class RecibosEgreso
    Dim ipSeleccionado As String
    Dim xContLocal As Integer = 0
    Dim bsComprobantes As New BindingSource
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.Text = "RECIBOS DE EGRESO"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False
        'Se inicializa el formulario y Se inicializa los controles generales
        btnFecha.EditValue = DateTime.Now

        Me.GridControl1.DataSource = bsComprobantes
        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)

        'Se configura el control GridView
        ControlesDevExpress.InitGridView(GridView1)
        'NUM RECIBO  CAJA  TURNO FECHA MONEDA  MONTO, DESCRIPCION USUARIO ESTADO TIPO EGRESO
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUM RECIBO", "tRecibo", 75, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CAJA", "tCaja", 35, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TURNO", "tTurno", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO EGRESO", "TipoEgreso", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DESCRIPCION", "tDescripcion", 250, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONEDA", "Moneda", 70, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "MONTO", "nMonto", 70, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "Estado", 80, True, ControlesDevExpress.eGridViewFormato.Numero, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "USUARIO", "tUsuario", 90, True, ControlesDevExpress.eGridViewFormato.Numero, False)

        'Se configura eventos
        AddHandler GridView1.DoubleClick, AddressOf VerDetalleDocumento
        AddHandler btnCerrar.ItemClick, AddressOf Cerrar

    End Sub

    Public Sub VerDetalleDocumento()
        Try
            If GridView1.GetFocusedRowCellValue("tRecibo") <> "" Then
                tReciboEgresoSeleccionado = GridView1.GetFocusedRowCellValue("tRecibo")
                tTipoEgresoSeleccionado = GridView1.GetFocusedRowCellValue("TipoEgreso")
                tTipoMonedaSeleccionado = GridView1.GetFocusedRowCellValue("Moneda")

                Dim MiForm As New ReciboEgresoDetalle
                MiForm.ShowDialog()
                cargarDatos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Cerrar()
        Me.Close()
    End Sub

    Private Sub DocumentoList_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Public Sub cargarDatos()
        If btnFecha.EditValue <> Nothing Then
            bsComprobantes.DataSource = SistemaDAO.GetRecibosEgreso(btnFecha.EditValue)
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        Me.GridView1.PostEditor()
        Me.GridView1.CloseEditor()
        Me.GridView1.UpdateCurrentRow()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificar.ItemClick, btnCerrar.ItemClick
        Try
            Select Case e.Item.Caption
                Case "Modificar" : VerDetalleDocumento()
                Case "Cerrar" : Cerrar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnBuscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBuscar.ItemClick
        cargarDatos()
    End Sub

End Class