Imports System.Data.SqlClient

Public Class ClienteFacturadoDAO

    Public Function SaveClienteFacturado(ByVal descripcion As String, ByVal identidad As String, ByVal direccion As String, ByVal email As String) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure

            .CommandText = "MCPV_CLIENTE_FACTURADO_INS"

            With .Parameters
                .Add("@TEMPRESA", SqlDbType.NVarChar, 150).Value = descripcion
                .Add("@TIDENTIDAD", SqlDbType.NVarChar, 30).Value = identidad
                .Add("@TDIRECCION", SqlDbType.NVarChar, 300).Value = direccion
                .Add("@TCORREO", SqlDbType.NVarChar, 100).Value = email
            End With

        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                Result = 1
            End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

End Class
