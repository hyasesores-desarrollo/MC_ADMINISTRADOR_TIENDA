Public Class CodigoPromocionTipo
    Private Sub btnCodigoDigital_Click(sender As Object, e As EventArgs) Handles btnCodigoDigital.Click
        Dim MiForm As New CodigoEntelList
        MiForm.ShowDialog()
    End Sub

    Private Sub btnCodigoTickect_Click(sender As Object, e As EventArgs) Handles btnCodigoTickect.Click
        Dim MiForm As New PromocionCodigoTickectList
        MiForm.ShowDialog()
    End Sub

    Private Sub CodigoPromocionTipo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DesktopMain.Ribbon.SelectedPage = Me.RibbonPage1
    End Sub

    Private Sub btnCerrar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrar.ItemClick
        Me.Close()
    End Sub
End Class