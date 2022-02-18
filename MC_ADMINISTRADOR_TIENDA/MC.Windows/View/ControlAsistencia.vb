Imports DevExpress.XtraGrid.Views.Base
Imports MC.Data
Imports MC.Framework
Imports System.IO
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Tile.ViewInfo
Imports DevExpress.XtraSplashScreen

Public Class ControlAsistencia

    Dim AsistenciaBE As New AsistenciaBE
    Dim bsMarcacion As New BindingSource
    Dim FechaIni As DateTime
    Dim FechaFin As DateTime

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        'Se inicializa los controles
        Me.Text = "CONTROL DE ASISTENCIA"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KeyPreview = False
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage

        beFecha.EditValue = Date.Today
        beHora.EditValue = "06"

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnRefresh, System.Windows.Forms.Keys.F5, "F5")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        'Se enlace el binding con la grilla
        Me.GridControl1.DataSource = bsMarcacion

        'Se asocia los eventos
        AddHandler Me.btnRefresh.ItemClick, AddressOf Refrescar
        AddHandler Me.btnCerrar.ItemClick, AddressOf Cerrar

        'Se carga los datos
        Refrescar()
        SetupView()
    End Sub

    Protected Overridable Sub Refrescar()
        Try
            SplashScreenManager.ShowForm(GetType(WaitForm))

            FechaIni = (beFecha.EditValue).AddHours(beHora.EditValue)
            FechaFin = FechaIni.AddDays(1)
            bsMarcacion.DataSource = AsistenciaDAO.Asistencia(FechaIni, FechaFin)
            bsiRegistros.Caption = "Total Registros: " + bsMarcacion.Count.ToString()

            SplashScreenManager.CloseForm()
        Catch
        End Try
    End Sub

    Private Sub SetupView()
        Try
            ' Setup tiles options
            TileView1.BeginUpdate()
            TileView1.OptionsTiles.RowCount = 4
            TileView1.OptionsTiles.Padding = New Padding(20)
            TileView1.OptionsTiles.ItemPadding = New Padding(10)
            TileView1.OptionsTiles.IndentBetweenItems = 20
            'TileView1.OptionsTiles.ItemSize = New Size(340, 190)
            TileView1.OptionsTiles.ItemSize = New Size(528, 190)
            TileView1.Appearance.ItemNormal.ForeColor = Color.White
            TileView1.Appearance.ItemNormal.BorderColor = Color.Transparent
            'Setup tiles template
            Dim leftPanel As New TileViewItemElement()
            Dim splitLine As New TileViewItemElement()
            'Setup fields
            Dim EmpleadoCaption As New TileViewItemElement()
            Dim EmpleadoValue As New TileViewItemElement()
            Dim IngresoCaption As New TileViewItemElement()
            Dim IngresoValue As New TileViewItemElement()
            Dim SalidaCaption As New TileViewItemElement()
            Dim SalidaValue As New TileViewItemElement()
            Dim Fecha As New TileViewItemElement()
            Dim imageIng As New TileViewItemElement()
            Dim imageSal As New TileViewItemElement()

            TileView1.TileTemplate.Add(leftPanel)
            TileView1.TileTemplate.Add(splitLine)
            TileView1.TileTemplate.Add(EmpleadoCaption)
            TileView1.TileTemplate.Add(EmpleadoValue)
            TileView1.TileTemplate.Add(IngresoCaption)
            TileView1.TileTemplate.Add(IngresoValue)
            TileView1.TileTemplate.Add(SalidaCaption)
            TileView1.TileTemplate.Add(SalidaValue)
            TileView1.TileTemplate.Add(Fecha)
            TileView1.TileTemplate.Add(imageIng)
            TileView1.TileTemplate.Add(imageSal)
            '
            leftPanel.StretchVertical = True
            leftPanel.Width = 122
            leftPanel.TextLocation = New Point(-10, 0)
            leftPanel.Appearance.Normal.BackColor = Color.FromArgb(58, 166, 101)
            '
            splitLine.StretchVertical = True
            splitLine.Width = 3
            splitLine.TextAlignment = TileItemContentAlignment.Manual
            splitLine.TextLocation = New Point(110, 0)
            splitLine.Appearance.Normal.BackColor = Color.White
            '
            EmpleadoCaption.Text = "EMPLEADO"
            EmpleadoCaption.TextAlignment = TileItemContentAlignment.TopLeft
            EmpleadoCaption.Appearance.Normal.FontSizeDelta = -1
            '
            EmpleadoValue.Column = TileView1.Columns("COLABORADOR")
            EmpleadoValue.AnchorElement = EmpleadoCaption
            EmpleadoValue.AnchorIndent = 2
            EmpleadoValue.MaxWidth = 100
            EmpleadoValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold
            '
            IngresoCaption.Text = "INGRESO"
            IngresoCaption.AnchorElement = EmpleadoValue
            IngresoCaption.AnchorIndent = 14
            IngresoCaption.Appearance.Normal.FontSizeDelta = -1
            '
            IngresoValue.Column = TileView1.Columns("INGRESO")
            IngresoValue.AnchorElement = IngresoCaption
            IngresoValue.AnchorIndent = 2
            IngresoValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold
            '
            SalidaCaption.Text = "SALIDA"
            SalidaCaption.AnchorElement = IngresoValue
            SalidaCaption.AnchorIndent = 14
            SalidaCaption.Appearance.Normal.FontSizeDelta = -1
            '
            SalidaValue.Column = TileView1.Columns("SALIDA")
            SalidaValue.AnchorElement = SalidaCaption
            SalidaValue.AnchorIndent = 2
            SalidaValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold
            '
            Fecha.Column = TileView1.Columns("FECHA")
            Fecha.TextAlignment = TileItemContentAlignment.BottomLeft
            Fecha.Appearance.Normal.Font = New Font("Segoe UI Semilight", 15.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            '
            imageIng.Column = TileView1.Columns("FOTOING")
            imageIng.ImageSize = New Size(202, 220) '280,220
            imageIng.ImageAlignment = TileItemContentAlignment.MiddleLeft
            imageIng.ImageScaleMode = TileItemImageScaleMode.Stretch 'TileItemImageScaleMode.ZoomOutside
            imageIng.ImageLocation = New Point(110, 1) '10,10
            '
            imageSal.Column = TileView1.Columns("FOTOSAL")
            imageSal.ImageSize = New Size(202, 220)
            imageSal.ImageAlignment = TileItemContentAlignment.MiddleRight
            imageSal.ImageScaleMode = TileItemImageScaleMode.Stretch
            imageSal.ImageLocation = New Point(9, 1)

        Finally
            TileView1.OptionsTiles.Orientation = Orientation.Vertical
            TileView1.EndUpdate()

            TileView1 = New TileView
        End Try
    End Sub

    Sub Cerrar()
        Me.Close()
    End Sub

End Class
