<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MozoDetails
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MozoDetails))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGuardarCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnanterior = New DevExpress.XtraBars.BarButtonItem()
        Me.btnsiguiente = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.Datos = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtcodigo = New DevExpress.XtraEditors.TextEdit()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.ChkPermite = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkEstado = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtusuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtapellidomaterno = New DevExpress.XtraEditors.TextEdit()
        Me.txtapellidopaterno = New DevExpress.XtraEditors.TextEdit()
        Me.txtnombres = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtdni = New DevExpress.XtraEditors.TextEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.Datos.SuspendLayout()
        CType(Me.txtcodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkPermite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtusuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtapellidomaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtapellidopaterno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnGuardar, Me.btnGuardarCerrar, Me.btnCerrar, Me.btnanterior, Me.btnsiguiente})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(780, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'btnGuardar
        '
        Me.btnGuardar.Caption = "Guardar"
        Me.btnGuardar.Glyph = CType(resources.GetObject("btnGuardar.Glyph"), System.Drawing.Image)
        Me.btnGuardar.Id = 1
        Me.btnGuardar.LargeGlyph = CType(resources.GetObject("btnGuardar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardar.Name = "btnGuardar"
        '
        'btnGuardarCerrar
        '
        Me.btnGuardarCerrar.Caption = "Guardar y Cerrar"
        Me.btnGuardarCerrar.Glyph = CType(resources.GetObject("btnGuardarCerrar.Glyph"), System.Drawing.Image)
        Me.btnGuardarCerrar.Id = 2
        Me.btnGuardarCerrar.LargeGlyph = CType(resources.GetObject("btnGuardarCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnGuardarCerrar.Name = "btnGuardarCerrar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Caption = "Cerrar"
        Me.btnCerrar.Glyph = CType(resources.GetObject("btnCerrar.Glyph"), System.Drawing.Image)
        Me.btnCerrar.Id = 3
        Me.btnCerrar.LargeGlyph = CType(resources.GetObject("btnCerrar.LargeGlyph"), System.Drawing.Image)
        Me.btnCerrar.Name = "btnCerrar"
        '
        'btnanterior
        '
        Me.btnanterior.Caption = "Anterior"
        Me.btnanterior.Glyph = CType(resources.GetObject("btnanterior.Glyph"), System.Drawing.Image)
        Me.btnanterior.Id = 4
        Me.btnanterior.LargeGlyph = CType(resources.GetObject("btnanterior.LargeGlyph"), System.Drawing.Image)
        Me.btnanterior.Name = "btnanterior"
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Caption = "Siguiente"
        Me.btnsiguiente.Glyph = CType(resources.GetObject("btnsiguiente.Glyph"), System.Drawing.Image)
        Me.btnsiguiente.Id = 5
        Me.btnsiguiente.LargeGlyph = CType(resources.GetObject("btnsiguiente.LargeGlyph"), System.Drawing.Image)
        Me.btnsiguiente.Name = "btnsiguiente"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Mozos"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnGuardarCerrar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCerrar, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Formulario"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnanterior)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnsiguiente)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Registros"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 371)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(780, 31)
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 143)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.Datos
        Me.XtraTabControl1.Size = New System.Drawing.Size(780, 228)
        Me.XtraTabControl1.TabIndex = 2
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Datos})
        '
        'Datos
        '
        Me.Datos.Controls.Add(Me.LabelControl7)
        Me.Datos.Controls.Add(Me.txtcodigo)
        Me.Datos.Controls.Add(Me.txtpassword)
        Me.Datos.Controls.Add(Me.ChkPermite)
        Me.Datos.Controls.Add(Me.ChkEstado)
        Me.Datos.Controls.Add(Me.LabelControl6)
        Me.Datos.Controls.Add(Me.LabelControl5)
        Me.Datos.Controls.Add(Me.LabelControl4)
        Me.Datos.Controls.Add(Me.LabelControl3)
        Me.Datos.Controls.Add(Me.LabelControl2)
        Me.Datos.Controls.Add(Me.txtusuario)
        Me.Datos.Controls.Add(Me.txtapellidomaterno)
        Me.Datos.Controls.Add(Me.txtapellidopaterno)
        Me.Datos.Controls.Add(Me.txtnombres)
        Me.Datos.Controls.Add(Me.LabelControl1)
        Me.Datos.Controls.Add(Me.txtdni)
        Me.Datos.Name = "Datos"
        Me.Datos.Size = New System.Drawing.Size(774, 200)
        Me.Datos.Text = "Datos"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(11, 16)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(37, 14)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "Codigo"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(127, 14)
        Me.txtcodigo.MenuManager = Me.RibbonControl
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(116, 20)
        Me.txtcodigo.TabIndex = 16
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(127, 170)
        Me.txtpassword.MenuManager = Me.RibbonControl
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(360, 20)
        Me.txtpassword.TabIndex = 15
        '
        'ChkPermite
        '
        Me.ChkPermite.Location = New System.Drawing.Point(522, 67)
        Me.ChkPermite.MenuManager = Me.RibbonControl
        Me.ChkPermite.Name = "ChkPermite"
        Me.ChkPermite.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPermite.Properties.Appearance.Options.UseFont = True
        Me.ChkPermite.Properties.Caption = "Permite Ver Todas las Cuentas"
        Me.ChkPermite.Size = New System.Drawing.Size(231, 19)
        Me.ChkPermite.TabIndex = 14
        '
        'ChkEstado
        '
        Me.ChkEstado.Location = New System.Drawing.Point(522, 41)
        Me.ChkEstado.MenuManager = Me.RibbonControl
        Me.ChkEstado.Name = "ChkEstado"
        Me.ChkEstado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEstado.Properties.Appearance.Options.UseFont = True
        Me.ChkEstado.Properties.Caption = "Activo"
        Me.ChkEstado.Size = New System.Drawing.Size(75, 19)
        Me.ChkEstado.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(11, 172)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Password"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(11, 145)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 14)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Usuario"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(11, 119)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(91, 14)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Apellido Materno"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(11, 93)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(89, 14)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Apellido Paterno"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(11, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 14)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Nombres"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(127, 143)
        Me.txtusuario.MenuManager = Me.RibbonControl
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Properties.MaxLength = 24
        Me.txtusuario.Size = New System.Drawing.Size(360, 20)
        Me.txtusuario.TabIndex = 5
        '
        'txtapellidomaterno
        '
        Me.txtapellidomaterno.Location = New System.Drawing.Point(127, 117)
        Me.txtapellidomaterno.MenuManager = Me.RibbonControl
        Me.txtapellidomaterno.Name = "txtapellidomaterno"
        Me.txtapellidomaterno.Size = New System.Drawing.Size(360, 20)
        Me.txtapellidomaterno.TabIndex = 4
        '
        'txtapellidopaterno
        '
        Me.txtapellidopaterno.Location = New System.Drawing.Point(127, 91)
        Me.txtapellidopaterno.MenuManager = Me.RibbonControl
        Me.txtapellidopaterno.Name = "txtapellidopaterno"
        Me.txtapellidopaterno.Size = New System.Drawing.Size(360, 20)
        Me.txtapellidopaterno.TabIndex = 3
        '
        'txtnombres
        '
        Me.txtnombres.Location = New System.Drawing.Point(127, 65)
        Me.txtnombres.MenuManager = Me.RibbonControl
        Me.txtnombres.Name = "txtnombres"
        Me.txtnombres.Size = New System.Drawing.Size(360, 20)
        Me.txtnombres.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(11, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(20, 14)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "DNI"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(127, 40)
        Me.txtdni.MenuManager = Me.RibbonControl
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Properties.MaxLength = 10
        Me.txtdni.Size = New System.Drawing.Size(116, 20)
        Me.txtdni.TabIndex = 0
        '
        'MozoDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 402)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "MozoDetails"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "MozoDetails"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.Datos.ResumeLayout(False)
        Me.Datos.PerformLayout()
        CType(Me.txtcodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkPermite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtusuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtapellidomaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtapellidopaterno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnGuardarCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Datos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtdni As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtusuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtapellidomaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtapellidopaterno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtnombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkPermite As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkEstado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnanterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnsiguiente As DevExpress.XtraBars.BarButtonItem
End Class
