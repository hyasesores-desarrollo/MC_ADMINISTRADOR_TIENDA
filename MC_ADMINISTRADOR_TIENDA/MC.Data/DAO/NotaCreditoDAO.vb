Imports System.Data.SqlClient

Public Class NotaCreditoDAO
    'Public Property IDNotaCredito As Integer
    Public Property tNotaCredito As String

    Public Function GetTiposDocumento() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "MCFE_TiPODOCUMENTO_LISTA"
            .CommandText = "MC_TIPODOCUMENTO_LISTA"
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

    Public Function GetCajas() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "COE_Obtiene_Cajas"
            .CommandText = "MC_OBTIENE_CAJAS"
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

    Public Function GetTiposIdentidad() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "MCFE_TIPOIDENTIDAD_LISTA"
            .CommandText = "MC_TIPOIDENTIDAD_LISTA"
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

    Public Function GetTipoNotaCredito() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCFE_MOTIVONOTACREDITO_LISTA"
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

    Public Function GetCorrelativoNotaCredito(SerieDoc As String) As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        Dim numero As String
        numero = ""
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "serv_coe_caja_tipodocumento_correlativo_nota_credito"
            .CommandText = "MC_NOTACREDITO_CORRELATIVO"


            With .Parameters
                .Add("@SerieDoc", SqlDbType.VarChar, 10).Value = SerieDoc
                .Add("@Correlativo", SqlDbType.NVarChar, 20).Direction = ParameterDirection.Output
            End With
        End With
        Try
            cnx.Open()
            cmd.ExecuteScalar()

            numero = cmd.Parameters("@Correlativo").Value

            'dt.Load(cmd.ExecuteReader) Then
            'numero = dt(0)(0).ToString
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If

        End Try
        Return numero
    End Function

    Public Function GetDocumentosDisponibles(ByVal tipo As String, ByVal dfecha As Date, ByVal tcaja As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "coe_ListaDocumentosActivos"
            .CommandText = "MC_DOCUMENTO_ACTIVO_LIST"

            With .Parameters
                .Add("@tTipoDoc", SqlDbType.NVarChar, 2).Value = tipo
                .Add("@fechainicial", SqlDbType.Date).Value = dfecha
                .Add("@tcaja", SqlDbType.NVarChar, 3).Value = tcaja
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

    Public Function GetFacturaCabecera(ByVal nCorrelativoFactura As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim idComprobante As Int32 = 0

        'idComprobante = GetIDComprobanteByCorrelativo(nCorrelativoFactura)
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "coe_factura_cabecera_get_id"
            .CommandText = "MC_NOTACREDITO_DOCUMENTO_GETID"

            With .Parameters
                '.Add("@IDFact", SqlDbType.Int).Value = idComprobante
                .Add("@tDocumento", SqlDbType.VarChar, 20).Value = nCorrelativoFactura
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

    Public Function GetBoletaCabecera(ByVal nCorrelativoBoleta As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim idComprobante As Int32 = 0

        idComprobante = GetIDComprobanteByCorrelativo(nCorrelativoBoleta)

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "coe_Boleta_cabecera_get_id"
            With .Parameters
                .Add("@IDBol", SqlDbType.Int).Value = idComprobante
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

    Public Function GetIDComprobanteByCorrelativo(ByVal ncorrelativo As String) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable


        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Coe_Comprobante_GET_ID_ByCorrelativo"

            With .Parameters
                .Add("@Ncorrelativo", SqlDbType.NVarChar, 30).Value = ncorrelativo

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

        If dt.Rows.Count > 0 Then

            Return Int32.Parse(dt.Rows(0)(0).ToString())
        Else
            Return 0
        End If
    End Function

    Public Function GetFacturaDetalle(ByVal nCorrelativoFactura As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim idComprobante As Int32 = 0

        'idComprobante = GetIDComprobanteByCorrelativo(nCorrelativoFactura)
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "coe_factura_detalle_get_id"
            .CommandText = "MC_NOTACREDITO_DETALLE_GETID"

            With .Parameters
                '.Add("@IDFact", SqlDbType.Int).Value = idComprobante
                .Add("@tDocumento", SqlDbType.VarChar, 20).Value = nCorrelativoFactura
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

    Public Function GetBoletaDetalle(ByVal nCorrelativoBoleta As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim idComprobante As Int32 = 0

        idComprobante = GetIDComprobanteByCorrelativo(nCorrelativoBoleta)
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "coe_boleta_detalle_get_id"

            With .Parameters
                .Add("@IDBol", SqlDbType.Int).Value = idComprobante
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

    Public Function SaveNotaCredito(ByVal BE As NotaCreditoBE) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "coe_insert_pre_nota_credito"
            .CommandText = "MC_NOTACREDITO_INSERT"

            With .Parameters
                .Add("@tNotaCredito", SqlDbType.VarChar, 20).Value = BE.tNotaCredito
                .Add("@fFecha", SqlDbType.DateTime).Value = BE.fFecha
                .Add("@tDocumento", SqlDbType.VarChar, 20).Value = BE.tDocumento
                .Add("@nNeto", SqlDbType.Float).Value = BE.nNeto
                .Add("@nImpuesto1", SqlDbType.Float).Value = BE.nImpuesto1
                .Add("@nImpuesto2", SqlDbType.Float).Value = BE.nImpuesto2
                .Add("@nImpuesto3", SqlDbType.Float).Value = BE.nImpuesto3
                .Add("@nVenta", SqlDbType.Float).Value = BE.nVenta
                .Add("@tTurno", SqlDbType.VarChar, 20).Value = BE.tTurno
                .Add("@tCaja", SqlDbType.VarChar, 10).Value = BE.tCaja
                .Add("@tUsuario", SqlDbType.VarChar, 20).Value = BE.tUsuario
                .Add("@tObservacion", SqlDbType.VarChar, 200).Value = BE.tObservacion
            End With
        End With

        Try
            cnx.Open()
            Result = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        'IDNotaCredito = Result
        tNotaCredito = Result
        Return Result
    End Function

    Public Function SaveNotaCreditoDetalle(ByVal idNotaCredito As Integer, ByVal nItem As Integer, ByVal tCodProducto As String, ByVal tDescripcion As String, ByVal nCantidad As Double, ByVal nvalorUnitario As Double, ByVal nPrecioUnitario As Double, ByVal nIGV As Double, ByVal nISC As Double, ByVal nValorVentaItem As Double, ByVal nDescuentoItem As Double) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "coe_insert_pre_nota_credito_detalle"

            With .Parameters
                .Add("@idPreNotaCredito", SqlDbType.Int).Value = idNotaCredito
                .Add("@nItem", SqlDbType.Int).Value = nItem
                .Add("@tCodProducto", SqlDbType.NVarChar, 30).Value = tCodProducto
                .Add("@tDescripcion", SqlDbType.NVarChar, 250).Value = tDescripcion

                .Add("@nCantidad", SqlDbType.Float).Value = nCantidad
                .Add("@nValorUnitario", SqlDbType.Float).Value = nvalorUnitario
                .Add("@nPrecioUnitario", SqlDbType.Float).Value = nPrecioUnitario
                .Add("@nIGV", SqlDbType.Float).Value = nIGV
                .Add("@nISC", SqlDbType.Float).Value = nISC
                .Add("@nValorVentaItem", SqlDbType.Float).Value = nValorVentaItem
                .Add("@nDescuentoItem", SqlDbType.Float).Value = nDescuentoItem

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

    Public Function GetListadoNotaCredito() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "coe_ListaNotaCredito"
            .CommandText = "MC_NOTACREDITO_LIST"
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

    Public Function AnularNotaCredito(ByVal idNotaCredito As String) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "coe_anular_pre_nota_credito"
            .CommandText = "MC_NOTACREDITO_ANULAR"

            With .Parameters

                '.Add("@idPreNotaCredito", SqlDbType.Int).Value = idNotaCredito
                .Add("@tNotaCredito", SqlDbType.VarChar, 20).Value = idNotaCredito

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
        idNotaCredito = Result
        Return Result
    End Function

    Public Function GetNotaCreditoCabeceraByID() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "coe_Listar_pre_nota_credito_byId"
            .CommandText = "MC_NOTACREDITO_LISTAR_ID"
            With .Parameters
                '.Add("@idPreNotaCredito", SqlDbType.Int).Value = IDNotaCredito
                .Add("@tNotaCredito", SqlDbType.VarChar, 20).Value = tNotaCredito
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

    Public Function GetNotaCreditoDetalleByID() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "coe_Listar_pre_nota_credito_detalle_byId"
            With .Parameters
                '.Add("@idPreNotaCredito", SqlDbType.Int).Value = IDNotaCredito
                .Add("@idPreNotaCredito", SqlDbType.Int).Value = tNotaCredito
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

    Public Function PublicarNotaCredito(ByVal idNotaCredito As Integer, ByVal idUsuario As Integer, ByVal maquina As String) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "coe_publicar_pre_nota_credito"
            With .Parameters

                .Add("@idPreNotaCredito", SqlDbType.Int).Value = idNotaCredito
                .Add("@idUsuario", SqlDbType.Int).Value = idUsuario
                .Add("@maquina", SqlDbType.NVarChar, 50).Value = maquina
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
        idNotaCredito = Result
        Return Result
    End Function

End Class
