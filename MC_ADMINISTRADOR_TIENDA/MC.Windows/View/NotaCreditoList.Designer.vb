﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotaCreditoList
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotaCreditoList))
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnestado = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 402)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(857, 31)
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnNuevo, Me.btnEditar, Me.btnRefresh, Me.btnCerrar, Me.btnestado})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(857, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnNuevo
        '
        Me.btnNuevo.Caption = "Nuevo"
        Me.btnNuevo.Glyph = CType(resources.GetObject("btnNuevo.Glyph"), System.Drawing.Image)
        Me.btnNuevo.Id = 1
        Me.btnNuevo.LargeGlyph = CType(resources.GetObject("btnNuevo.LargeGlyph"), System.Drawing.Image)
        Me.btnNuevo.Name = "btnNuevo"
        '
        'btnEditar
        '
        Me.btnEditar.Caption = "Editar"
        Me.btnEditar.Glyph = CType(resources.GetObject("btnEditar.Glyph"), System.Drawing.Image)
        Me.btnEditar.Id = 2
        Me.btnEditar.LargeGlyph = CType(resources.GetObject("btnEditar.LargeGlyph"), System.Drawing.Image)
        Me.btnEditar.Name = "btnEditar"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
        Me.btnRefresh.Id = 3
        Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 4
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnestado
        '
        Me.btnestado.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.btnestado.Caption = "Activos"
        Me.btnestado.Id = 5
        Me.btnestado.Name = "btnestado"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Listado de Notas de Crédito"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNuevo)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Opciones"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnRefresh)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Formulario"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 143)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(857, 259)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'NotaCreditoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 433)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "NotaCreditoList"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "NotaCreditoList"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnestado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView



End Class
