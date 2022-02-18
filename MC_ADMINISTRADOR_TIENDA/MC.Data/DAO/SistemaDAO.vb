Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mime.MediaTypeNames
 

Public Class SistemaDAO
    Public Property UsuarioBE As UsuarioBE
    Public Property TipoCambioBE As TipoCambioBE
    Public Property NombrePC As String
    Public Property IDLocal As Int32
    Public Property IDLocalBancoCuentas As Int32
    Public Property NombreLocal As String
    Public Property NombreAplicacion As String
    Public Property NombreLocalComercial As String

    Dim estadoconexion As Boolean

    Public Enum eTipoDocumento
        Guias = 1
        OrdenCompra = 2
    End Enum

    Public Sub New()
        Me.NombreAplicacion = "ADMINISTRACION TIENDA"
    End Sub

    Public Function GetDocumentos(TipoDocumento As eTipoDocumento) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "log_documentos_get_nombrepc"
            .Parameters.Add("@nombrepc", SqlDbType.VarChar, 50).Value = Me.NombrePC
            .Parameters.Add("@tipodocumento", SqlDbType.Int).Value = TipoDocumento
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

    Public Function LoadDatos() As Boolean
        Dim Result As Boolean = False

        System.Threading.Thread.Sleep(1000)

        Result = True

        Return Result
    End Function

    Public Function conexionLocal(ByRef Conexion As String) As Boolean
        Try
            Dim cnx As New SqlConnection
            cnx = New SqlConnection(Conexion)
            cnx.Open()
            estadoconexion = True
            cnx.Close()
        Catch ex As Exception
            estadoconexion = False
        End Try
        Return (estadoconexion)
    End Function

    Public Function GetLocales() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "COE_CONTINGENCIA_LIST_LOCAL"

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

    Public Function GetTipoEgresos() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        Try
            With cmd
                .Connection = cnx
                .CommandType = CommandType.StoredProcedure
                .CommandText = "MC_ListarTiposEgreso"
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

        Catch ex As Exception

        End Try

        Return dt
    End Function

    Public Function GetTipoMoneda() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        Try
            With cmd
                .Connection = cnx
                .CommandType = CommandType.StoredProcedure
                .CommandText = "MC_ListarTiposMoneda"
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

        Catch ex As Exception

        End Try
        Return dt
    End Function

    Public Sub SaveReciboEgreso(ByVal tEgreso As String, ByVal tTipoEgreso As String, ByVal tUsuario As String, ByVal ttipoMoenda As String)
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ActualizaReciboEgreso"
            With .Parameters
                .Add("@tEgreso", SqlDbType.VarChar, 15).Value = tEgreso
                .Add("@tTipoEgreso", SqlDbType.VarChar, 3).Value = tTipoEgreso
                .Add("@tUsuario", SqlDbType.VarChar, 30).Value = tUsuario
                .Add("@tTipoMoneda", SqlDbType.VarChar, 2).Value = ttipoMoenda

            End With
        End With

        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then

            End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try

    End Sub

    Public Function GetRecibosEgreso(dFecha As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        Try
            With cmd
                .Connection = cnx
                .CommandType = CommandType.StoredProcedure
                .CommandText = "MC_ListarRecibosEgreso"

                .Parameters.Add("@FECHADOC", SqlDbType.Date).Value = dFecha
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

        Catch ex As Exception

        End Try
        Return dt

    End Function

    Public Function CambiaDocumento(ByVal tDocumentoInicial As String, ByVal tDocumentoDestino As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim valor As Integer
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_Utilitario_CambioDocumento"
            With .Parameters
                .Clear()
                .Add("@DocumentoInicial", SqlDbType.NVarChar, 20).Value = tDocumentoInicial
                .Add("@DocumentoDestino", SqlDbType.NVarChar, 20).Value = tDocumentoDestino
                .Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output
            End With
        End With

        Try
            cnx.Open()
            cmd.ExecuteScalar()
            valor = cmd.Parameters("@Resultado").Value
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return valor
    End Function

    Public Function CambiaFechaDocumento(ByVal tDocumentoInicial As String, ByVal fechaNueva As Date) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim valor As Integer
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_Utilitario_CambioFechaDocumento"
            With .Parameters
                .Clear()
                .Add("@DocumentoInicial", SqlDbType.NVarChar, 20).Value = tDocumentoInicial
                .Add("@FechaNueva", SqlDbType.Date).Value = fechaNueva

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
        Return valor
    End Function

    Public Function GetDocumentosVenta(ByVal dFecha As Date, ByVal tNumero As String, ByVal tCaja As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        Try
            With cmd
                .Connection = cnx
                .CommandType = CommandType.StoredProcedure
                .CommandText = "MC_ListarDocumentosv2"

                .Parameters.Add("@fecha", SqlDbType.Date).Value = dFecha
                .Parameters.Add("@tdocumento", SqlDbType.NVarChar, 50).Value = tNumero
                .Parameters.Add("@tcaja", SqlDbType.VarChar, 10).Value = tCaja
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

        Catch ex As Exception

        End Try

        Return dt

    End Function



End Class
