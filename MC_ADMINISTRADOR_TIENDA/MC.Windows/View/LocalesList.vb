Imports MC.Framework

Public Class LocalesList
    Dim bsEmisores As New BindingSource

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        'Se inicializa los controles
        Me.Text = "LOCALES "
        Me.StartPosition = FormStartPosition.CenterScreen
        '  Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)

        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnRefresh, System.Windows.Forms.Keys.F5, "F5")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)


        'Se configura el control GridView
        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ID", "IDLOCAL", 40, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RAZON SOCIAL", "RAZONSOCIAL", 220, True)
        ' ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE COMERCIAL", "NOMBRECOMERCIAL", 260, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "LOCAL", "RAZONCOMERCIAL", 220, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IP", "IPSERVER", 0, False)

        'Se enlace el binding con la grilla
        Me.GridControl1.DataSource = bsEmisores

        'Se asocia los eventos

        AddHandler Me.btnRefresh.ItemClick, AddressOf Refrescar
        AddHandler Me.btnCerrar.ItemClick, AddressOf Cerrar

        AddHandler Me.GridView1.DoubleClick, AddressOf Seleccionar

        'Se carga los datos
        Refrescar()
    End Sub

    Sub Seleccionar()
        Try
            If My.Computer.Network.Ping(GridView1.GetFocusedRowCellValue("IPSERVER").ToString) Then
                ActualizarAPP.actualizaConfig(GridView1.GetFocusedRowCellValue("IPSERVER").ToString)
                nombreTienda = GridView1.GetFocusedRowCellValue("RAZONCOMERCIAL").ToString
                IdLocal = GridView1.GetFocusedRowCellValue("IDLOCAL")
                Tools.SaveAppSettings("IdLocal", IdLocal)
                Me.Hide()
                Dim LF As Login = New Login
                LF.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo problema de conexión hacia el local")
        End Try
    End Sub

    Sub Refrescar()
        Try
            'Se establece la fuente de datos del Binding
            bsEmisores.DataSource = SistemaDAO.GetLocales()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Cerrar()
        Me.Close()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick

    End Sub
End Class