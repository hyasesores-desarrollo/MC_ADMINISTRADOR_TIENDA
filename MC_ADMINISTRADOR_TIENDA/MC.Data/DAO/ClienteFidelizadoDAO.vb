Imports System.Data.SqlClient

Public Class ClienteFidelizadoDAO

    Public Property IdCliente As Integer

    Public Function GetallClienteFidelizado() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CLIENTE_FIDELIZADO_GETALL"
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

    Public Function GetbyidClienteFidelizado(id As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CLIENTE_FIDELIZADO_GETBYID"

            With .Parameters
                .Add("@IdCliente", SqlDbType.Int, 150).Value = id

            End With
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

    Public Function GetbyidClienteFidelizadoDetalle(id As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CLIENTE_FIDELIZADO_DETALLE_GETBYID"

            With .Parameters
                .Add("@IdCliente", SqlDbType.Int, 150).Value = id

            End With
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

    Public Function CreateClienteFidelizado(ByVal clientes As MC_clientes) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CLIENTE_FIDELIZADO_INS"

            With .Parameters
                .Add("@IdCliente", SqlDbType.Int).Value = clientes.IdCliente
                .Add("@IdTipoIdentidad", SqlDbType.Int).Value = clientes.IdTipoIdentidad
                .Add("@NumeroDocumento", SqlDbType.NVarChar, 15).Value = clientes.NumeroDocumento
                .Add("@Nombres", SqlDbType.NVarChar, 50).Value = clientes.Nombres
                .Add("@Apellidos", SqlDbType.NVarChar, 50).Value = clientes.Apellidos
                .Add("@NombrePreferido", SqlDbType.NVarChar, 50).Value = clientes.NombrePreferido
                .Add("@Telefono", SqlDbType.NVarChar, 50).Value = clientes.Telefono
                .Add("@Correo", SqlDbType.NVarChar, 50).Value = clientes.Correo
                .Add("@FechaNacimiento", SqlDbType.DateTime).Value = clientes.FechaNacimiento
                .Add("@IdGenero", SqlDbType.Int).Value = clientes.IdGenero
                .Add("@IdDistrito", SqlDbType.Int).Value = clientes.IdDistrito
                .Add("@Ubigeo", SqlDbType.NVarChar, 50).Value = clientes.Ubigeo
                .Add("@Direccion", SqlDbType.NVarChar, 400).Value = clientes.Direccion
                .Add("@UrlConsentimiento", SqlDbType.NVarChar, 500).Value = clientes.UrlConsentimiento
                .Add("@Estado", SqlDbType.Bit, 1).Value = clientes.Estado
                .Add("@FechaRegistro", SqlDbType.DateTime).Value = clientes.FechaRegistro
                .Add("@Puntos", SqlDbType.Int).Value = clientes.Puntos
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

    Public Function UpdateClienteFidelizado(ByVal clientes As MC_clientes) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CLIENTE_FIDELIZADO_UPD"

            With .Parameters
                .Add("@IdCliente", SqlDbType.Int).Value = clientes.IdCliente
                .Add("@IdTipoIdentidad", SqlDbType.Int).Value = clientes.IdTipoIdentidad
                .Add("@NumeroDocumento", SqlDbType.NVarChar, 15).Value = clientes.NumeroDocumento
                .Add("@Nombres", SqlDbType.NVarChar, 50).Value = clientes.Nombres
                .Add("@Apellidos", SqlDbType.NVarChar, 50).Value = clientes.Apellidos
                .Add("@NombrePreferido", SqlDbType.NVarChar, 50).Value = clientes.NombrePreferido
                .Add("@Telefono", SqlDbType.NVarChar, 50).Value = clientes.Telefono
                .Add("@Correo", SqlDbType.NVarChar, 50).Value = clientes.Correo
                .Add("@FechaNacimiento", SqlDbType.DateTime).Value = clientes.FechaNacimiento
                .Add("@IdGenero", SqlDbType.Int).Value = clientes.IdGenero
                .Add("@IdDistrito", SqlDbType.Int).Value = clientes.IdDistrito
                .Add("@Ubigeo", SqlDbType.NVarChar, 50).Value = clientes.Ubigeo
                .Add("@Direccion", SqlDbType.NVarChar, 400).Value = clientes.Direccion
                .Add("@UrlConsentimiento", SqlDbType.NVarChar, 500).Value = clientes.UrlConsentimiento
                .Add("@Estado", SqlDbType.Bit, 1).Value = clientes.Estado
                .Add("@FechaRegistro", SqlDbType.DateTime).Value = clientes.FechaRegistro
                .Add("@Puntos", SqlDbType.Int).Value = clientes.Puntos
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

    Public Function DeleteClienteFidelizado(id As Integer) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CLIENTE_FIDELIZADO_DLT"

            With .Parameters
                .Add("@IdCliente", SqlDbType.Int, 150).Value = id
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
