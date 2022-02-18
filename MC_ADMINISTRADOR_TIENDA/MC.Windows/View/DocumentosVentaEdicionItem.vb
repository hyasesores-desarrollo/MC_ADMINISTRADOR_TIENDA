Public Class DocumentosVentaEdicionItem

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = " MODIFICAR VALOR"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Icon = DesktopMain.Icon
        Me.KeyPreview = False

    End Sub
    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub

    Private Sub DocumentosVentaEdicionItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gruFecha.Visible = (DocumentoVentaDAO.FlagOpc = "F")
        gruDocumento.Visible = (DocumentoVentaDAO.FlagOpc = "D")
        gruProducto.Visible = (DocumentoVentaDAO.FlagOpc = "P")

        gruFecha.Dock = IIf(DocumentoVentaDAO.FlagOpc = "F", DockStyle.Fill, DockStyle.None)
        gruDocumento.Dock = IIf(DocumentoVentaDAO.FlagOpc = "D", DockStyle.Fill, DockStyle.None)
        gruProducto.Dock = IIf(DocumentoVentaDAO.FlagOpc = "P", DockStyle.Fill, DockStyle.None)

        lblFecha.Text = DocumentoVentaDAO.Valor
        lblDocumento.Text = DocumentoVentaDAO.Valor

        lblPrecio.Text = DocumentoVentaDAO.Valor
        lblProducto.Text = DocumentoVentaDAO.Producto
    End Sub

    Private Sub btnGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGuardar.ItemClick

        If (DocumentoVentaDAO.FlagOpc = "F") Then
            If (dtpFechaNueva.Text <> "") Then
                DocumentoVentaDAO.Valor = dtpFechaNueva.Text
            End If
        End If
        If (DocumentoVentaDAO.FlagOpc = "D") Then
            If (txtCorrelativoD.Text <> "") Then
                Dim CORRELATIVO As Integer = txtCorrelativoD.Text.Trim
                DocumentoVentaDAO.Valor = String.Concat(txtPrefijoD.Text.Trim(), txtSerieD.Text.Trim(), Format(CORRELATIVO, "000000000"))
            End If
        End If
        If (DocumentoVentaDAO.FlagOpc = "P") Then
            If (txtPrecioNuevo.EditValue > 0) Then
                DocumentoVentaDAO.Valor = txtPrecioNuevo.EditValue
            End If
        End If
        Me.Close()

    End Sub

    Private Sub txtSerieD_Leave(sender As Object, e As EventArgs) Handles txtSerieD.Leave
        Dim cadena As String
        cadena = txtSerieD.Text.Trim
        cadena = Microsoft.VisualBasic.Right(String.Concat("00000", cadena), 5)
        txtSerieD.Text = cadena
    End Sub

    Private Sub txtCorrelativoD_Leave(sender As Object, e As EventArgs) Handles txtCorrelativoD.Leave
        Dim cadena As String
        cadena = txtCorrelativoD.Text.Trim
        cadena = Microsoft.VisualBasic.Right(String.Concat("000000000", cadena), 9)

        txtCorrelativoD.Text = cadena
    End Sub
End Class