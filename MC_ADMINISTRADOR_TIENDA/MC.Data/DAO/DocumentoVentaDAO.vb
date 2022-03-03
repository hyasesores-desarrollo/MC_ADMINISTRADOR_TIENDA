Imports System.Data.SqlClient

Public Class DocumentoVentaDAO
    Property tDocumento As String
    Public FlagOpc As String
    Public Valor As String
    Public IDProducto As String
    Public Producto As String
    Public tCodigoPedido As String

    Public Function GetByID(ByVal tDocumento As String) As DocumentoVentaBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim dr As SqlDataReader = Nothing
        Dim DocumentoVentaBE As New DocumentoVentaBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_DOCUMENTO_VENTA_GET_IDv2"
            With .Parameters
                .Add("@tDocumento", SqlDbType.VarChar, 20).Value = tDocumento
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With DocumentoVentaBE
                        .NumeroDocumento = dr.ReadNullAsEmptyString("tDocumento")
                        .FechaEmision = dr.ReadNullAsEmptyDate("fRegistro")
                        .TipoDocumento = dr.ReadNullAsEmptyString("TipoDocumento")
                        .Cliente = dr.ReadNullAsEmptyString("tEmpresa")
                        .Ruc = dr.ReadNullAsEmptyString("tIdentidad")
                        .SubTotal = dr.ReadNullAsNumeric("nNeto")
                        .Impuesto1 = dr.ReadNullAsNumeric("nPrecioImpuesto1")
                        .Impuesto2 = dr.ReadNullAsNumeric("nPrecioImpuesto2")
                        .Total = dr.ReadNullAsNumeric("nVenta")
                    End With
                End While

                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try

        Return DocumentoVentaBE
    End Function

    Public Function GetDetalleByID(tDocumento As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_DOCUMENTO_VENTA_DETALLE_GET_IDv2"
            With .Parameters
                .Add("@tDocumento", SqlDbType.VarChar, 20).Value = tDocumento
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

    Public Function Save(ByVal BE As DocumentoVentaBE, ByVal detalle_documento_totales As DataTable) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_DOCUMENTO_UPDv2"

            With .Parameters
                .Add("@tDocumentoOld", SqlDbType.VarChar, 20).Value = BE.NumeroDocumento
                .Add("@tDocumentoNew", SqlDbType.VarChar, 20).Value = BE.NumeroDocumentoNew
                .Add("@FechaNew", SqlDbType.Date).Value = BE.FechaEmision
                .Add("@TotalNew", SqlDbType.Float).Value = BE.Total
                .Add("@nNeto", SqlDbType.Float).Value = detalle_documento_totales.Rows(0)("nNeto")
                .Add("@nPrecioImpuesto1", SqlDbType.Float).Value = detalle_documento_totales.Rows(0)("nPrecioImpuesto1")
                .Add("@nPrecioImpuesto2", SqlDbType.Float).Value = detalle_documento_totales.Rows(0)("nPrecioImpuesto2")
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

    Public Function SaveDetalle(ByVal tDocumento As String, ByVal tCodigoProducto As String, ByVal Total As Double, ByVal Imp2 As Boolean) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_DOCUMENTO_DETALLE_UPDv2"

            With .Parameters
                .Add("@tDocumento", SqlDbType.VarChar, 20).Value = tDocumento
                .Add("@tCodigoProducto", SqlDbType.VarChar, 20).Value = tCodigoProducto
                .Add("@Total", SqlDbType.Float).Value = Total
                .Add("@Imp2", SqlDbType.Bit).Value = Imp2
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

    Public Function DeleteReplica(ByVal IDLocal As Integer, ByVal tDocumento As String) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ELIMINA_DOCUMENTO_MODIFICADO"

            With .Parameters
                .Add("@IDLOCAL", SqlDbType.Int).Value = IDLocal
                .Add("@TDOCUMENTO", SqlDbType.VarChar, 30).Value = tDocumento

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

    Public Function ListadoDocumentosPuntos(FechaInicial As Date, FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandTimeout = 0
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_DOCUMENTOS_VENTAS_CLIENTE_LIST"
            .Parameters.Add("@FechaInicial", SqlDbType.Date).Value = FechaInicial
            .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = FechaFinal
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

End Class
