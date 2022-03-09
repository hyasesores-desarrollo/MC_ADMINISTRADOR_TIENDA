#Region "Imports"
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid
Imports MC.Data
Imports MC.Framework
Imports DevExpress.XtraBars
#End Region
Public Class MotorizadoList

    Dim bsmotorizado As New BindingSource

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'Se inicializa los controles
        Me.Text = "CONFIGURAR MOTORIZADO" & SistemaDAO.NombreLocal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
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
        ControlesDevExpress.InitGridViewColumn(GridView1, "IdMotorizadoDetalle", "IdMotorizadoDetalle", 70, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIENDA", "RAZONCOMERCIAL", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CODIGO", "CodigoInforest", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO MOTORIZADO", "TipoMotorizado", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DETALLADO", "Detallado", 300, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "RESUMIDO", "Resumido", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "DNI", "NUMERODOCUMENTO", 70, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "TIPO COMISIÓN", "Tipocomision", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "EMPLEADO", "NOMBREEMPLEADO", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "ACTIVO", "Estado", 60, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEmpleado", 100, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)


        'Filtro por cualquier campo
        With GridView1
            .Columns("CodigoInforest").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("TipoMotorizado").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Detallado").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Resumido").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Tipocomision").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NOMBREEMPLEADO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("Estado").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With

        'Se desactiva el boton de Locales
        DesktopMain.btnLocal.Enabled = False

        'Se enlace el binding con la grilla
        Me.GridControl1.DataSource = bsmotorizado

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
            MotorizadoDAO.CODIGO = ""
            MotorizadoDAO.IdMotorizadoDetalle = 0
            Dim MiForm As New MotorizadoDetails

            MiForm.ShowDialog()

            Refrescar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Editar()
        Try
            If GridView1.GetFocusedRowCellValue("CodigoInforest").ToString.Trim = "0000" Then
                MessageBox.Show("Este motorizado no puede ser editado")
            Else
                'Se obtiene el ID
                'MotorizadoDAO.CODIGO = GridView1.GetFocusedRowCellValue("Codigo")
                MotorizadoDAO.IdMotorizadoDetalle = GridView1.GetFocusedRowCellValue("IdMotorizadoDetalle")
                MotorizadoDAO.CODIGO = GridView1.GetFocusedRowCellValue("CodigoInforest")
                'Se formulario de mantenimiento
                Dim MiForm As New MotorizadoDetails
                MiForm.cboTipoMotorizado.Enabled = False
                MiForm.cboMotorizado.Enabled = False
                MiForm.txtDescripcion.Enabled = False
                'MiForm.sleTipoComision.Enabled = False
                MiForm.ShowDialog()
            End If


            Refrescar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Refrescar()
        Try
            'Se establece la fuente de datos del Binding
            bsmotorizado.DataSource = MotorizadoDAO.GetByMotorizadoLocal(Tools.ReadAppSettings("IdLocal"))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub Cerrar()
        DesktopMain.btnLocal.Enabled = True
        Me.Close()
    End Sub

    Private Sub MotorizadoList_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub



    'Private Sub btnEstado_DownChanged(sender As Object, e As ItemClickEventArgs) Handles btnestado.DownChanged

    'If btnestado.Down Then
    '    btnestado.Caption = "Todos"
    '    bsmotorizado.DataSource = MotorizadoDAO.GetByMotorizado(0)
    'Else
    '    btnestado.Caption = "Activos"
    '    bsmotorizado.DataSource = MotorizadoDAO.GetByMotorizado(1)
    'End If

    'End Sub
End Class