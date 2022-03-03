Imports System.Data.SqlClient

Public Class PuntosDAO

    Property tDocumento As String = ""
    Property IdCliente As Int32 = 0

    Public Function ListadoClientesFidelizados() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandTimeout = 0
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CLIENTE_FIDELIZADO_LIST_VENTA"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function DocumentoClienteInsert(ByVal BE As DocumentoPuntosBE) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandTimeout = 0
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_DOCUMENTOS_VENTAS_CLIENTE_INSERT"
            With .Parameters
                .Add("@tDocumento", SqlDbType.NVarChar, 20).Value = BE.tDocumento
                .Add("@IdCliente", SqlDbType.Int).Value = BE.IdCliente
                .Add("@IdTipoIdentidad", SqlDbType.Int).Value = BE.IdTipoIdentidad
                .Add("@NumeroDocumento", SqlDbType.NVarChar, 50).Value = BE.NumeroDocumento
                .Add("@Cliente", SqlDbType.NVarChar, 100).Value = BE.Cliente
            End With
        End With

        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result

    End Function

    Public Function DocumentoClienteDelete(ByVal BE As DocumentoPuntosBE) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandTimeout = 0
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_DOCUMENTOS_VENTAS_CLIENTE_DELETE"
            With .Parameters
                .Add("@tDocumento", SqlDbType.NVarChar, 20).Value = BE.tDocumento
                .Add("@IdCliente", SqlDbType.Int).Value = BE.IdCliente
            End With
        End With

        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
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
