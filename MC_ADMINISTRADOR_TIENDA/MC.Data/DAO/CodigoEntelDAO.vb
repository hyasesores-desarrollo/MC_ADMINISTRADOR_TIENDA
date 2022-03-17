Imports System.Data.SqlClient

Public Class CodigoEntelDAO
#Region "Procedimientos INFOREST Codigos Promocion Digital"
    Public Function CodigoEntelPendienteGetIniCaja() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CODIGO_ENTEL_PENDIENTE_NUMERO_PEDIDO"
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
    End Function 'OK
    Public Function RegistrarCodigoEntelInforest(ByVal IdLocal As Int32, ByVal CodigoEntel As String, ByVal MedioRegistro As Int32, ByVal CodigoPedido As String, ByVal UsuarioRegistro As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_PEDIDOS_CODIGO_ENTEL_INS"
            With .Parameters
                .Add("@IdLocal", SqlDbType.Int).Value = IdLocal
                .Add("@CodigoEntel", SqlDbType.VarChar, 8).Value = CodigoEntel
                .Add("@MedioRegistro", SqlDbType.Int).Value = MedioRegistro
                .Add("@CodigoPedido", SqlDbType.NVarChar, 20).Value = CodigoPedido
                .Add("@UsuarioRegistro", SqlDbType.VarChar, 20).Value = UsuarioRegistro
            End With
        End With
        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = True
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function ValidacionNumeroPedidoTienda(ByVal NumeroPedido As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select count(tCodigoPedido) as Valor from MPEDIDO WHERE tCodigoPedido  = '" + NumeroPedido + "'"
                reader = cmd.ExecuteReader()
                While reader.Read()
                    Valor = (reader.Item(0))
                End While
                cnx.Close()
            End With
        Catch ex As Exception

        End Try

        Return Valor
    End Function
    Public Function ObteberCanalVenta(ByVal NumeroPedido As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "select tTipoPedido from MPEDIDO WHERE tCodigoPedido  = '" + NumeroPedido + "'"
                reader = cmd.ExecuteReader()
                While reader.Read()
                    Valor = (reader.Item(0))
                End While
                cnx.Close()
            End With
        Catch ex As Exception

        End Try

        Return Valor
    End Function
    Public Function ObtenerPrimerosDigitosCodigoPedido() As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim Valor As String = 0
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                cnx.Open()

                .Connection = cnx
                .CommandType = CommandType.Text
                .CommandText = "SELECT top(1) substring(tCodigoPedido,1,2) FROM MPEDIDO ORDER BY fFecha DESC"
                reader = cmd.ExecuteReader()
                While reader.Read()
                    Valor = (reader.Item(0))
                End While
                cnx.Close()
            End With
        Catch ex As Exception

        End Try

        Return Valor
    End Function
    Public Function ProcesarPendientesCodigoEntelInforest(ByVal IdPedidoCodigoEntel As Integer, ByVal NumeroPedido As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CODIGO_ENTEL_PROCESAR_PENDIENTES"
            With .Parameters
                .Add("@IdPedidoCodigoEntel", SqlDbType.Int).Value = IdPedidoCodigoEntel
                .Add("@NumeroPedido", SqlDbType.VarChar, 10).Value = NumeroPedido
            End With
        End With
        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = True
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function CodigoEntelList(ByVal FechaInicial As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_PEDIDOS_COGIGO_ENTEL_LIST"
            With .Parameters
                .Add("@FechaIinicial", SqlDbType.Date).Value = FechaInicial
                .Add("@FechaFinal", SqlDbType.Date).Value = FechaFinal
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
    End Function 'OK
    Public Function DeleteCodigoEntel(ByVal IdPedidoCodigoEntel As Integer) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CODIGO_ENTEL_DELETE"
            With .Parameters
                .Add("@IdPedidoCodigoEntel", SqlDbType.Int).Value = IdPedidoCodigoEntel
            End With
        End With
        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = True
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
#End Region
#Region "Procedimientos INFOREST Codigos Promocion Tickect"

#End Region
#Region "Procedimientos MC_VENTAS Codigos Promocion Tickect"
    Public Function CodigoPromocionTickectPendienteGetIniCaja(ByVal IdLocal As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_PROMOCION_CONSUMO_PENDIENTE_REGISTRO_GETIDLOCAL"
            With .Parameters
                .Add("@IDLOCAL", SqlDbType.Int).Value = IdLocal
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
    End Function 'OK
    Public Function ConsultaCodigoPromocionTickect(ByVal CodigoPromocion As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_PROMOCION_CONSULTA_GETCODIGO"
            With .Parameters
                .Add("@CODIGOPROMOCION", SqlDbType.VarChar, 50).Value = CodigoPromocion
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
    End Function 'OK
    Public Function DatosImpresionCodigoPromocionTickect(ByVal CodigoPromocion As String, ByVal IdLocal As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_PROMOCION_DATOS_IMPRESION"
            With .Parameters
                .Add("@CODIGOPROMOCION", SqlDbType.VarChar, 50).Value = CodigoPromocion
                .Add("@IDLOCAL", SqlDbType.Int).Value = IdLocal
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
    End Function 'OK
    Public Function RegistrarCodigoPromocionTickect(ByVal CodigoPromocion As String, ByVal NumeroPedido As String, ByVal IdLocal As Integer, ByVal UsuarioRegistro As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_PROMOCION_REGISTRO_CONSUMO" ''"BD_SP_CCR_CODIGO_ENTEL_REGISTRAR_CONSUMO"
            With .Parameters
                .Add("@CODIGOPROMOCION", SqlDbType.VarChar, 50).Value = CodigoPromocion
                .Add("@NUMEROPEDIDO", SqlDbType.VarChar, 20).Value = NumeroPedido
                .Add("@IDLOCAL", SqlDbType.Int).Value = IdLocal
                '.Add("@UsuarioRegistroConsumo", SqlDbType.VarChar, 20).Value = UsuarioRegistro
            End With
        End With
        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = True
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
#End Region
#Region "Procedimientos BD_CODIGOS_ENTEL"
    Public Function ConsultaCodigoEntel(ByVal CodigoEntel As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCodigoEntel)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BD_SP_ADT_CODIGO_ENTEL_VALIDAR" '"BD_SP_CCE_CODIGO_ENTEL_VALIDAR"
            With .Parameters
                .Add("@NumeroCodigoEntel", SqlDbType.VarChar, 8).Value = CodigoEntel
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
    End Function 'OK
    Public Function DatosImpresionCodigoEntel(ByVal CodigoEntel As String, ByVal IdLocal As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCodigoEntel)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BD_SP_ADT_CODIGO_ENTEL_DATOS_IMPRESION" '"BD_SP_CCE_CODIGO_ENTEL_VALIDAR"
            With .Parameters
                .Add("@NumeroCodigoEntel", SqlDbType.VarChar, 8).Value = CodigoEntel
                .Add("@IdLocal", SqlDbType.Int).Value = IdLocal
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
    End Function 'OK
    Public Function RegistrarCodigoEntel(ByVal IdCodigoEntelDetalle As Integer, ByVal IdLocal As Integer, ByVal CodigoEntel As String, ByVal UsuarioRegistro As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCodigoEntel)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BD_SP_ADT_CODIGO_ENTEL_REGISTRAR_CONSUMO" ''"BD_SP_CCR_CODIGO_ENTEL_REGISTRAR_CONSUMO"
            With .Parameters
                .Add("@IdCodigoEntelDetalle", SqlDbType.Int).Value = IdCodigoEntelDetalle
                .Add("@IdLocal", SqlDbType.Int).Value = IdLocal
                .Add("@CodigoEntel", SqlDbType.VarChar, 8).Value = CodigoEntel
                .Add("@UsuarioRegistroConsumo", SqlDbType.VarChar, 20).Value = UsuarioRegistro
            End With
        End With
        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = True
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function UpdateCodigoEntelNumeroPedido(ByVal CodigoEntel As String, ByVal NumeroPedido As String, ByVal CanalVenta As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCodigoEntel)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BD_SP_ADT_CODIGO_ENTEL_NUMERO_PEDIDO_UPDATE"
            With .Parameters
                .Add("@CodigoEntel", SqlDbType.VarChar, 8).Value = CodigoEntel
                .Add("@NumeroPedido", SqlDbType.VarChar, 20).Value = NumeroPedido
                .Add("@CanalVenta", SqlDbType.Int).Value = CanalVenta
            End With
        End With
        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = True
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function
    Public Function UpdateCodigoEntelEstadoConsumo(ByVal CodigoEntel As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCodigoEntel)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd

            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "BD_SP_ADT_CODIGO_ENTEL_ESTADO_CONSUMO_UPDATE"
            With .Parameters
                .Add("@CodigoEntel", SqlDbType.VarChar, 8).Value = CodigoEntel
            End With
        End With
        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Result = True
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return Result
    End Function

#End Region



End Class
