Imports MC.Framework

Public Class BuscaDocumentoNC
    Dim bsBuscaDocumento As New BindingSource
    Dim tipoD As String
    Dim fechaD As Date
    Dim cajaD As String
    Dim DocumentoSeleccionado As String

    Public Sub New()

        InitializeComponent()

        'Se inicializa los controles
        Me.Text = " BUSCAR DOCUMENTO PARA NOTA DE CRÉDITO "
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False

        DocumentoSeleccionadoNc = ""
        ControlesDevExpress.InitGridControl(GridControl1)

        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NRO DOCUMENTO", "NumDoc", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA EMISIÓN", "FechaEmision", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NRO IDENTIDAD", "IDReceptor", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE O RAZÓN SOCIAL", "Receptor", 230, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE TOTAL", "Importe", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = bsBuscaDocumento
        cargarDatos()
        AddHandler Me.GridView1.DoubleClick, AddressOf Seleccionar

    End Sub

    Public Sub New(ByVal tipoDoc As String, ByVal Fecha As Date, tcaja As String)
        InitializeComponent()
        tipoD = tipoDoc
        fechaD = Fecha
        cajaD = tcaja
        DocumentoSeleccionadoNc = ""
        'Se inicializa los controles
        Me.Text = " BUSCAR DOCUMENTO PARA NOTA DE CRÉDITO "
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False

        'Se configura el control GridControl
        ControlesDevExpress.InitGridControl(GridControl1)

        'Se configura el control GridView
        ControlesDevExpress.InitGridView(GridView1)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NRO DOCUMENTO", "NumDoc", 150, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "FECHA EMISIÓN", "FechaEmision", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NRO IDENTIDAD", "IDReceptor", 80, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)
        ControlesDevExpress.InitGridViewColumn(GridView1, "NOMBRE O RAZÓN SOCIAL", "Receptor", 230, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        ControlesDevExpress.InitGridViewColumn(GridView1, "IMPORTE TOTAL", "Importe", 100, True, ControlesDevExpress.eGridViewFormato.Ninguno, False)

        Me.GridControl1.DataSource = bsBuscaDocumento

        CargarDatos()
        AddHandler Me.GridView1.DoubleClick, AddressOf Seleccionar
    End Sub

    Public Sub CargarDatos()
        bsBuscaDocumento.DataSource = NotaCreditoDAO.GetDocumentosDisponibles(tipoD, fechaD, cajaD)
    End Sub

    Public Sub Seleccionar()
        Try
            If GridView1.RowCount > 0 Then
                DocumentoSeleccionado = GridView1.GetFocusedRowCellValue("NumDoc")
                If DocumentoSeleccionado <> "" Then

                    DocumentoSeleccionadoNc = DocumentoSeleccionado

                    Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class