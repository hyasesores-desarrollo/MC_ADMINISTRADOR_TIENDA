Imports MC.Framework
Imports MC.Data

Public Class ClienteFidelizadoList
    Dim bsclientefidelizado As New BindingSource

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'Se inicializa los controles
        Me.Text = "Cliente Fidelizado Lista" & SistemaDAO.NombreLocal
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

        'Se configura el control GridView
        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Codigo", "IdCliente", 50, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Tipo Doc.", "IdTipoIdentidad", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Num. Doc.", "NumeroDocumento", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Nombres", "Nombres", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Apellidos", "Apellidos", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Nombre preferido", "NombrePreferido", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Correo", "Correo", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Ubigeo", "Ubigeo", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Fecha de nacimiento", "FechaNacimiento", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "Puntos", "Puntos", 60, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'Filtro por cualquier campo
        With GridView1
            .Columns("IdCliente").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NumeroDocumento").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Nombres").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Apellidos").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NombrePreferido").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Correo").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Ubigeo").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("FechaNacimiento").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Puntos").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        'Se desactiva el boton de Locales
        DesktopMain.btnLocal.Enabled = False

        'Se enlace el binding con la grilla
        Me.GridControl1.DataSource = bsclientefidelizado

        'Se asocia los eventos
        AddHandler Me.btnNuevo.ItemClick, AddressOf Nuevo
        AddHandler Me.btnEditar.ItemClick, AddressOf Editar
        AddHandler Me.btnRefresh.ItemClick, AddressOf Refrescar
        AddHandler Me.btnCerrar.ItemClick, AddressOf Cerrar
        AddHandler Me.GridView1.DoubleClick, AddressOf btnEditar.PerformClick

        'Se carga los datos
        Refrescar()

    End Sub
    Public Sub Nuevo()
        Try
            ClienteFidelizadoDAO.IdCliente = 0
            Dim MiForm As New ClienteFidelizadoEdit
            MiForm.ShowDialog()
            Refrescar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub Editar()
        Try
            ClienteFidelizadoDAO.IdCliente = GridView1.GetFocusedRowCellValue("IdCliente")
            Dim MiForm As New ClienteFidelizadoEdit
            MiForm.ShowDialog()
            Refrescar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Refrescar()
        Try
            'Se establece la fuente de datos del Binding
            bsclientefidelizado.DataSource = ClienteFidelizadoDAO.GetallClienteFidelizado()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Cerrar()
        DesktopMain.btnLocal.Enabled = True
        Me.Close()
    End Sub


End Class