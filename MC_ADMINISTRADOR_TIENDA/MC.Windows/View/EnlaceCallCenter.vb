Public Class EnlaceCallCenter
    Dim valorfalt As Int32
    Dim bsCajas As New BindingSource
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Me.Text = "ENLACE CALL - CENTER"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.KeyPreview = False
        AddHandler Me.btnEnlace.ItemClick, AddressOf CajaDelivery
        AddHandler Me.btnCerrar.ItemClick, AddressOf Cerrar


        TipoButton()
    End Sub
    Private Sub TipoButton()
        Try
            Dim dt As DataTable
            dt = CajaDao.ValidacionCajaActivaDelivery()
            If dt.Rows(0)("FLAT") = 0 Then
                btnEnlace.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                If dt.Rows(0)("CANTIDAD") = 0 Then
                    btnEnlace.Caption = "ACTIVAR ENLACE CALL-CENTER"
                Else
                    btnEnlace.Caption = "DESACTIVAR ENLACE CALL-CENTER"
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub CajaDelivery()
        Dim MiForm As New ActivacionCallCenter
        MiForm.StartPosition = FormStartPosition.CenterScreen
        MiForm.KeyPreview = False
        MiForm.Text = "ENLACE CALL-CENTER"
        Try

            Dim dt As DataTable
            dt = CajaDao.ValidacionCajaActivaDelivery()

            If dt.Rows(0)("CANTIDAD") = 0 Then
                MiForm.btnActivacion.Text = "CONECTAR"
                MiForm.btnActivacion.ForeColor = Color.Blue
                MiForm.Valor = 1
            Else
                MiForm.btnActivacion.Text = "DESCONECTAR"
                MiForm.btnActivacion.ForeColor = Color.Red
                MiForm.Valor = 0
            End If
            MiForm.ShowDialog()
            ''' 
            TipoButton()
            '''
        Catch ex As Exception

        End Try

    End Sub
    Sub Cerrar()
        Me.Close()
    End Sub

    Private Sub CajaList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub
End Class