Imports System.Data.SqlClient

Public Class ClienteFidelizadoDAO

    'Public Function GetallClienteFidelizado() As List(Of MC_clientes)
    '    Dim result As New List(Of MC_clientes)
    '    Using context As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
    '        context.Open()
    '        Dim command As New SqlCommand("select * from MC_CLIENTE", context)
    '        Using reader = command.ExecuteReader()
    '            While (reader.Read())
    '                Dim MC_cliente As New MC_clientes
    '                MC_cliente.IdCliente = Convert.ToInt32(reader.GetValue(0))
    '                MC_cliente.IdTipoIdentidad = Convert.ToInt32(reader.GetValue(1))
    '                MC_cliente.NumeroDocumento = Convert.ToString(reader.GetValue(2))
    '                MC_cliente.Nombres = Convert.ToString(reader.GetValue(3))
    '                MC_cliente.Apellidos = Convert.ToString(reader.GetValue(4))
    '                MC_cliente.NombrePreferido = Convert.ToString(reader.GetValue(5))
    '                MC_cliente.Telefono = Convert.ToString(reader.GetValue(6))
    '                MC_cliente.Correo = Convert.ToString(reader.GetValue(7))
    '                MC_cliente.FechaNacimiento = Convert.ToDateTime(reader.GetValue(8))
    '                MC_cliente.IdGenero = Convert.ToInt32(reader.GetValue(9))
    '                MC_cliente.IdDistrito = Convert.ToInt32(reader.GetValue(10))
    '                MC_cliente.Ubigeo = Convert.ToString(reader.GetValue(11))
    '                MC_cliente.Direccion = Convert.ToString(reader.GetValue(12))
    '                MC_cliente.UrlConsentimiento = Convert.ToString(reader.GetValue(13))
    '                MC_cliente.Estado = Convert.ToBoolean(reader.GetValue(14))
    '                MC_cliente.FechaRegistro = Convert.ToDateTime(reader.GetValue(15))
    '                MC_cliente.Puntos = Convert.ToInt32(reader.GetValue(16))
    '                result.Add(MC_cliente)
    '            End While
    '        End Using
    '        For Each cliente As MC_clientes In result
    '            GetClienteFidelizado_detalle(cliente, context)
    '        Next



    '    End Using

    '    Return result
    'End Function

    'Public Function GetbyidClienteFidelizado(id As Integer) As MC_clientes
    '    Dim result As New MC_clientes
    '    Using context As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
    '        context.Open()
    '        Dim command As New SqlCommand("select * from MC_CLIENTE where IdCliente = @id", context)
    '        command.Parameters.AddWithValue("@id", id)
    '        Using reader = command.ExecuteReader()
    '            reader.Read()
    '            result.IdCliente = Convert.ToInt32(reader.GetValue(0))
    '            result.IdTipoIdentidad = Convert.ToInt32(reader.GetValue(1))
    '            result.NumeroDocumento = Convert.ToString(reader.GetValue(2))
    '            result.Nombres = Convert.ToString(reader.GetValue(3))
    '            result.Apellidos = Convert.ToString(reader.GetValue(4))
    '            result.NombrePreferido = Convert.ToString(reader.GetValue(5))
    '            result.Telefono = Convert.ToString(reader.GetValue(6))
    '            result.Correo = Convert.ToString(reader.GetValue(7))
    '            result.FechaNacimiento = Convert.ToDateTime(reader.GetValue(8))
    '            result.IdGenero = Convert.ToInt32(reader.GetValue(9))
    '            result.IdDistrito = Convert.ToInt32(reader.GetValue(10))
    '            result.Ubigeo = Convert.ToString(reader.GetValue(11))
    '            result.Direccion = Convert.ToString(reader.GetValue(12))
    '            result.UrlConsentimiento = Convert.ToString(reader.GetValue(13))
    '            result.Estado = Convert.ToBoolean(reader.GetValue(14))
    '            result.FechaRegistro = Convert.ToDateTime(reader.GetValue(15))
    '            result.Puntos = Convert.ToInt32(reader.GetValue(16))
    '        End Using
    '        GetClienteFidelizado_detalle(result, context)
    '    End Using
    '    Return result
    'End Function





    'Public Sub GetClienteFidelizado_detalle(ByVal clientes As MC_clientes, ByVal context As SqlConnection)
    '    'clientes.mc_clientedetalle = New List(Of MC_cliente_detalle)
    '    Dim command As New SqlCommand("select * from MC_CLIENTE_DETALLE where IdCliente = @id", context)
    '    command.Parameters.AddWithValue("@id", clientes.IdCliente)
    '    Using reader = command.ExecuteReader()
    '        While (reader.Read())
    '            Dim cliente_detalle = New MC_cliente_detalle
    '            cliente_detalle.IdClienteDetalle = Convert.ToInt32(reader.GetValue(0))
    '            cliente_detalle.IdCliente = Convert.ToInt32(reader.GetValue(1))
    '            cliente_detalle.IdLocal = Convert.ToInt32(reader.GetValue(2))
    '            cliente_detalle.NumeroDocumento = Convert.ToString(reader.GetValue(3))
    '            cliente_detalle.Monto = Convert.ToDouble(reader.GetValue(4))
    '            cliente_detalle.Ingreso = Convert.ToInt32(reader.GetValue(5))
    '            cliente_detalle.Salida = Convert.ToInt32(reader.GetValue(6))
    '            cliente_detalle.Puntos = Convert.ToInt32(reader.GetValue(7))
    '            cliente_detalle.UsuarioRegistra = Convert.ToString(reader.GetValue(8))
    '            cliente_detalle.FechaRegistro = Convert.ToDateTime(reader.GetValue(9))
    '            clientes.mc_clientedetalle.Add(cliente_detalle)
    '        End While
    '    End Using
    'End Sub

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
