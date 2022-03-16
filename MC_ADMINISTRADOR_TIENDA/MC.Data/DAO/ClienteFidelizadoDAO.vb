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

    Public Function GetbyidClienteFidelizado(id As Integer) As MC_clientesBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim Cliente As New MC_clientesBE

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
            With Cliente
                .IdCliente = dt.Rows(0).Item("IdCliente")
                .IdTipoIdentidad = dt.Rows(0).Item("IdTipoIdentidad")
                .NumeroDocumento = dt.Rows(0).Item("NumeroDocumento")
                .Nombres = dt.Rows(0).Item("Nombres")
                .ApellidoMaterno = dt.Rows(0).Item("ApellidoMaterno")
                .ApellidoPaterno = dt.Rows(0).Item("ApellidoPaterno")
                .NombrePreferido = dt.Rows(0).Item("NombrePreferido")
                .Telefono = dt.Rows(0).Item("Telefono")
                .Correo = dt.Rows(0).Item("Correo")
                .FechaNacimiento = dt.Rows(0).Item("FechaNacimiento")
                .IdGenero = dt.Rows(0).Item("IdGenero")
                .IdDistrito = dt.Rows(0).Item("IdDistrito")
                .Ubigeo = dt.Rows(0).Item("Ubigeo")
                .Direccion = dt.Rows(0).Item("Direccion")
                .UrlConsentimiento = dt.Rows(0).Item("UrlConsentimiento")
                .Estado = dt.Rows(0).Item("Estado")
                .FechaRegistro = dt.Rows(0).Item("FechaRegistro")
                .Puntos = dt.Rows(0).Item("Puntos")
            End With
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Cliente
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

    Public Function CreateClienteFidelizado(ByVal clientes As MC_clientesBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CLIENTE_FIDELIZADO_INS_OR_UPD"

            With .Parameters
                .Add("@IdCliente", SqlDbType.Int).Value = clientes.IdCliente
                .Add("@IdTipoIdentidad", SqlDbType.NVarChar, 2).Value = clientes.IdTipoIdentidad
                .Add("@NumeroDocumento", SqlDbType.NVarChar, 15).Value = clientes.NumeroDocumento
                .Add("@Nombres", SqlDbType.NVarChar, 50).Value = clientes.Nombres
                .Add("@ApellidoMaterno", SqlDbType.NVarChar, 50).Value = clientes.ApellidoMaterno
                .Add("@ApellidoPaterno", SqlDbType.NVarChar, 50).Value = clientes.ApellidoPaterno
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
                Result = True
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
    Public Function GetTipoDocumentoSUNAT() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_TIPODOCUMENTO_SUNAT"
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
    Public Function GetGenero() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "RS_SEXO_LIST"
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
    Public Function GetDistritoUbigeo() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_DISTRITO_UBIGEO"
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

    Public Function ExisteClienteDuplicado(ByVal NumeroDocumento As Integer, ByVal IdTipoIdentidad As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim result As Boolean

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_VALIDAR_CLIENTE_DUPLICADO"
            With .Parameters
                .Add("@NumeroDocumento", SqlDbType.NVarChar, 15).Value = NumeroDocumento
                .Add("@IdTipoIdentidad", SqlDbType.NVarChar, 2).Value = IdTipoIdentidad
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            If dt.Rows(0).Item("Total") > 0 Then
                result = True
            Else
                result = False
            End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return result
    End Function
End Class


