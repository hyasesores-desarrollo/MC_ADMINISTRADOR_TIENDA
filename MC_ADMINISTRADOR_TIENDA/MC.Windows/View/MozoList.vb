#Region "Imports"
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraBars
#End Region
Public Class MozoList

    Dim bsmozos As New BindingSource

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'Se inicializa los controles
        Me.Text = "CONFIGURAR MOZOS" & SistemaDAO.NombreLocal
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
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGO", "Codigo", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DETALLADO", "Detallado", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RESUMIDO", "Resumido", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DNI", "dni", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ESTADO", "lactivo", 60, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "PERMITEVER", "nvalor", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CLAVE", "tvalor", 550, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        'Filtro por cualquier campo
        With GridView1
            .Columns("Codigo").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Detallado").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Resumido").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("dni").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("lactivo").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("nvalor").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        'Se desactiva el boton de Locales
        DesktopMain.btnLocal.Enabled = False

        'Se enlace el binding con la grilla
        Me.GridControl1.DataSource = bsmozos

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
            'Se obtiene el ID, solo para el caso de nuevo es cero
            MozoDAO.CODIGO = ""
            'DocumentoDAO.IDDocumento = 0

            Dim MiForm As New MozoDetails
            MiForm.ShowDialog()

            Refrescar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Editar()
        Try
            'Se obtiene el ID
            MozoDAO.CODIGO = GridView1.GetFocusedRowCellValue("Codigo")

            'Se formulario de mantenimiento
            Dim MiForm As New MozoDetails
            MiForm.ShowDialog()

            Refrescar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Refrescar()

        Try
            'Se establece la fuente de datos del Binding
            bsmozos.DataSource = MozoDAO.GetByMozos(1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Cerrar()
        DesktopMain.btnLocal.Enabled = True

        Me.Close()
    End Sub

    Private Sub ConfigurarMozoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnEstado_DownChanged(sender As Object, e As ItemClickEventArgs) Handles btnestado.DownChanged

        If btnestado.Down Then
            btnestado.Caption = "Todos"
            'btnestado.LargeGlyph = My.Resources.Guias32
            bsmozos.DataSource = MozoDAO.GetByMozos(0)
        Else
            btnestado.Caption = "Activos"
            'btnestado.LargeGlyph = My.Resources.Ver32
            bsmozos.DataSource = MozoDAO.GetByMozos(1)
        End If

    End Sub

End Class