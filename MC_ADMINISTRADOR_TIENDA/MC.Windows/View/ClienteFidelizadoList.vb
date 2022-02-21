Public Class ClienteFidelizadoList

    Private Sub btnNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevo.ItemClick
        Dim MiForm As New ClienteFidelizadoEdit
        MiForm.ShowDialog()
    End Sub


End Class