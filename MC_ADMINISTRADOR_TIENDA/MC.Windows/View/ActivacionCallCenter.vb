Public Class ActivacionCallCenter
    Public Valor As Int32
    Private Sub btnActivacion_Click(sender As Object, e As EventArgs) Handles btnActivacion.Click
        Try
            If MessageBox.Show("Esta seguro de " & btnActivacion.Text & " el enlace con Call-Center", "Estado enlace CALL-CENTER", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Dim dt As DataTable
                dt = CajaDao.GetCajaDeliveryList()
                If dt.Rows.Count > 0 Then
                    If Valor = 0 Then
                        For i As Int32 = 0 To dt.Rows.Count - 1
                            CajaDao.ActivacionDesactivacionCajaDelivery(dt.Rows(i)("tCaja"), 0, SistemaDAO.UsuarioBE.tCodigoUsuario)
                        Next

                    Else
                        For i As Int32 = 0 To dt.Rows.Count - 1
                            CajaDao.ActivacionDesactivacionCajaDelivery(dt.Rows(i)("tCaja"), 1, SistemaDAO.UsuarioBE.tCodigoUsuario)
                        Next
                    End If
                    Me.Close()
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class