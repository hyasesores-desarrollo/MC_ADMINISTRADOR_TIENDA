Imports MC.Data
Imports MC.Framework
Imports System.Data.SqlClient

Public Class ControlAsistenciaHY
    'Dim bsMarcacionHY As New BindingSource
    Dim FechaIni As DateTime
    Dim FechaFin As DateTime

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        'Se inicializa los controles
        Me.Text = "CONTROL DE ASISTENCIA - HY ASESORES SAC"
        'Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Me.KeyPreview = False
        dtFechaFinal.EditValue = DateTime.Now.Date
        dtFechaInicial.EditValue = DateTime.Now.Date.AddDays(-6)
        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnExportar, System.Windows.Forms.Keys.F5, "F5")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)

        'Se configura el control GridView
        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 70, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRE", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "A.PATERNO", "APELLIDO_PATERNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "A. MATERNO", "APELLIDO_MATERNO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "N° DOCUMENTO", "NUMERO_DOCUMENTO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "LOCAL MARCACION", "RAZONCOMERCIAL", 200, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO MARCACION", "TIPOMARCACION", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA MARCACION", "FECHAMARCACION", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "HORA MARCACION", "HORAMARCACION", 130, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDLOCAL", "IDLOCAL", 130, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IPSERVER", "IPSERVER", 130, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CAMPOLLAVE", "CAMPOLLAVE", 130, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        'Filtro por cualquier campo
        With GridView1
            .Columns("NOMBRE").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDO_PATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDO_MATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERO_DOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("RAZONCOMERCIAL").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TIPOMARCACION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FECHAMARCACION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("HORAMARCACION").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        'Se enlace el binding con la grilla
        Me.GridControl1.DataSource = bsGrilla


        'Se asocia los eventos
        AddHandler Me.btnExportar.ItemClick, AddressOf Exportar
        AddHandler Me.btnCerrar.ItemClick, AddressOf Cerrar

        OcultarDatos()
    End Sub
    Private Sub OcultarDatos()
        LabelControl1.Visible = False
        LabelControl2.Visible = False
        LabelControl3.Visible = False
        LabelControl4.Visible = False
        LabelControl5.Visible = False
        lblLocalMarcacion.Visible = False
        lblTipoMarcacion.Visible = False
        lblFechaMarcacion.Visible = False
        lblHoraMarcacion.Visible = False
        lblNombreTrabajador.Visible = False
    End Sub
    Private Sub MostrarDatos()
        LabelControl1.Visible = True
        LabelControl2.Visible = True
        LabelControl3.Visible = True
        LabelControl4.Visible = True
        LabelControl5.Visible = True
        lblLocalMarcacion.Visible = True
        lblTipoMarcacion.Visible = True
        lblFechaMarcacion.Visible = True
        lblHoraMarcacion.Visible = True
        lblNombreTrabajador.Visible = True
    End Sub
    Private Sub Exportar()
        If GridView1.RowCount > 0 Then
            Try
                Dim ruta As String
                ruta = My.Application.Info.DirectoryPath() + "\AsistenaciasHY.xlsx"
                GridControl1.ExportToXlsx(ruta)
                Process.Start(ruta)
            Catch ex As Exception
                MessageBox.Show("Cerrar o guardar el archivo listado que esta siendo utilizado.")
            End Try
        End If
    End Sub

    Private Sub Cerrar()
        Me.Close()
    End Sub

    Private Sub RepositoryItemVerFoto_Click(sender As Object, e As EventArgs) Handles RepositoryItemVerFoto.Click
        Dim IdLocal As Integer
        Dim IpServer As String
        Dim CampoLlave As Integer
        Dim cnTienda As New SqlConnection
        MostrarDatos()
        IdLocal = GridView1.GetFocusedRowCellValue("IDLOCAL")
        IpServer = GridView1.GetFocusedRowCellValue("IPSERVER")
        CampoLlave = GridView1.GetFocusedRowCellValue("CAMPOLLAVE")
        cnTienda = New SqlConnection("Data Source=" + IpServer + ";Initial Catalog=" + BdMarcacionLocal + ";user ID= desarrollo ;Password= sistemas;")
        AsistenciaDAO.MostrarFotoMarcacionHyGetId(cnTienda, CampoLlave)

        PictureBox1.BackgroundImage = Nothing
        PictureBox1.Image = Nothing
        Dim ms As New IO.MemoryStream(AsistenciaDAO.FOTO)
        PictureBox1.Image = Image.FromStream(ms)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        lblLocalMarcacion.Text = GridView1.GetFocusedRowCellValue("RAZONCOMERCIAL")
        lblTipoMarcacion.Text = GridView1.GetFocusedRowCellValue("TIPOMARCACION")
        lblFechaMarcacion.Text = GridView1.GetFocusedRowCellValue("FECHAMARCACION")
        lblHoraMarcacion.Text = GridView1.GetFocusedRowCellValue("HORAMARCACION")
        lblNombreTrabajador.Text = GridView1.GetFocusedRowCellValue("NOMBRE") + " " + GridView1.GetFocusedRowCellValue("APELLIDO_PATERNO") + " " + GridView1.GetFocusedRowCellValue("APELLIDO_MATERNO")

    End Sub

End Class