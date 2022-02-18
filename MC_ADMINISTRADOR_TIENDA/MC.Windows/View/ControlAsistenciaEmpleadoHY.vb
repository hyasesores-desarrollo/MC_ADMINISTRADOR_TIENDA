Imports MC.Data
Imports MC.Framework
Public Class ControlAsistenciaEmpleadoHY
    Dim bsEmpleadosHY As New BindingSource
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        'Se inicializa los controles
        Me.Text = "LISTADO EMPLEADO HY - ASISTENCIA"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KeyPreview = False
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
        dtFechaFinal.EditValue = DateTime.Now.Date
        dtFechaInicial.EditValue = DateTime.Now.Date.AddDays(-6)
        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnRefrescar, System.Windows.Forms.Keys.F5, "F5")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)

        'Se configura el control GridView
        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IDEMPLEADO", "IDEMPLEADO", 70, False, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "SELECCIONAR", "ESTADO", 90, True, ControlesDevExpress.eGridViewFormato.Checked, True)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRES", "NOMBRES", 260, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO PATERNO", "APELLIDOPATERNO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "APELLIDO MATERNO", "APELLIDOMATERNO", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NUMERO DOCUMENTO", "NUMERODOCUMENTO", 120, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "CARGO", "CARGO", 430, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        'Filtro por cualquier campo
        With GridView1
            .Columns("NOMBRES").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOPATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("APELLIDOMATERNO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("NUMERODOCUMENTO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
            .Columns("CARGO").OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        End With
        'Se enlace el binding con la grilla
        Me.GridControl1.DataSource = bsEmpleadosHY
        'Se asocia los eventos
        AddHandler Me.btnMostrarMarcaciones.ItemClick, AddressOf MostrarMarcaciones
        AddHandler Me.btnCerrar.ItemClick, AddressOf Cerrar

        CheckEdit1.Text = "Seleccionar"

        'Se carga los datos
        Refrescar(0)
    End Sub
    Private Sub MostrarMarcaciones()
        Dim idempleado As Integer
        Dim dt As New DataTable
        Dim dtEmpleado As New DataTable
        dt = bsEmpleadosHY.DataSource
        Dim foundSeleccionados As DataRow() = dt.Select("estado=1")
        If foundSeleccionados.Length = 0 Then
            MessageBox.Show("Seleccionar emplado(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Convert.ToDateTime(dtFechaInicial.EditValue) >= Convert.ToDateTime(dtFechaFinal.EditValue) Then
            MessageBox.Show("Error en rango de fechas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        For i = 0 To foundSeleccionados.Length - 1
            Dim dtResultado As New DataTable
            idempleado = foundSeleccionados(i).Item("IDEMPLEADO")
            dtResultado = AsistenciaDAO.ColaboradoresMarcacionesHyGetId(idempleado, dtFechaInicial.EditValue, dtFechaFinal.EditValue)
            If i = 0 Then dtEmpleado = dtResultado.Clone() 'Realiza la copia de estructura 
            dtEmpleado.Merge(dtResultado)
        Next
        bsGrilla.Clear()
        bsGrilla = dtEmpleado
        Dim MiFom As New ControlAsistenciaHY
        MiFom.lblFechaInicial.Caption = "Fecha Inicial: " & dtFechaInicial.EditValue
        MiFom.lblFechaFinal.Caption = "Fecha Final: " & dtFechaFinal.EditValue
        MiFom.ShowDialog()
    End Sub
    Private Sub Refrescar(checkec)
        Try
            bsEmpleadosHY.DataSource = AsistenciaDAO.ColaboradoresHyList(checkec)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Cerrar()
        Me.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked Then
            Refrescar(1)
        Else
            Refrescar(0)
        End If
    End Sub

End Class