Imports System.Data.SqlClient

Public Class DocumentoDAO

    Property IDEnvio As Int32

    Public Function GetByEnvioDocumentoListado() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_LISTADO"
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

    Public Function GetByEnvioDocumentoListadoGenerado() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_LISTADO_GENERADO"
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

    Public Function SaveDocumentoProcesado(ByVal BE As DocumentoProcesadoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_INSERT"
            With .Parameters
                .Add("@IDENVIO", SqlDbType.Int).Value = BE.IDEnvio
                .Add("@FECHAINICIAL", SqlDbType.Date).Value = BE.FechaInicial
                .Add("@FECHAFINAL", SqlDbType.Date).Value = BE.FechaFinal
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

    Public Function DeleteDocumentoProcesado(ByVal IDENVIO As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_DELETE"
            With .Parameters
                .Add("@IDENVIO", SqlDbType.Int).Value = IDENVIO
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

    Public Function UpdateAsignacionDocumentoProcesadoDetalle(ByVal IDENVIODETALLE As Int32, ByVal ESTADOASIGNACION As Boolean) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_UPDATE_ESTADO_ASIGNACION"
            With .Parameters
                .Add("@IDENVIODETALLE", SqlDbType.Int).Value = IDENVIODETALLE
                .Add("@ESTADOASIGNACION", SqlDbType.Bit).Value = ESTADOASIGNACION
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

    Public Function GetByEnvioDocumentoListadoDetalleIdEnvio(ByVal IDENVIO As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_DETALLE_IDENVIO"
            With .Parameters
                .Add("@IDENVIO", SqlDbType.Int).Value = IDENVIO
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

    Public Function GetByEnvioDocumentoListadoDetalleIdEnvioAsignar(ByVal IDENVIO As Int32, ByVal ASIGNAR As Boolean) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_DETALLE_IDENVIO_UPDATE_ASIGNAR"
            With .Parameters
                .Add("@IDENVIO", SqlDbType.Int).Value = IDENVIO
                .Add("@ASIGNAR", SqlDbType.Bit).Value = ASIGNAR
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

    Public Function EnviarDocumentoProcesado(ByVal IDENVIO As Int32) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_ENVIAR"
            With .Parameters
                .Add("@IDENVIO", SqlDbType.Int).Value = IDENVIO
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

    Public Function GetByIDNotaCredito(ByVal tNotaCredito As String) As NotaCreditoBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim dr As SqlDataReader = Nothing
        Dim BE As New NotaCreditoBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_NOTA_CREDITO_GET_ID"

            With .Parameters
                .Add("@tNotaCredito", SqlDbType.NVarChar, 20).Value = tNotaCredito
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With BE
                        '.NumeroNotaCredito = dr.ReadNullAsNumeric("tNotaCredito")
                        '.TipoNotaCredito = dr.ReadNullAsNumeric("TipoNotaCredito")
                        '.Proveedor = dr.ReadNullAsNumeric("Proveedor")
                        '.Ruc = dr.ReadNullAsNumeric("Ruc")
                        '.Fecha = dr.ReadNullAsEmptyDate("fFecha")
                        '.TotalNotaCredito = dr.ReadNullAsNumeric("TotalNotaCredito")
                        '.TotalDocumento = dr.ReadNullAsNumeric("TotalDocumento")
                        '.Observacion = dr.ReadNullAsEmptyString("tObservacion")
                        '.NumeroDocumentoReferencia = dr.ReadNullAsEmptyString("tDocumento")
                        '.NetoNotaCredito = dr.ReadNullAsNumeric("nNeto")
                        '.IgvNotaCredito = dr.ReadNullAsNumeric("nImpuesto1")
                    End With

                End While

                dr.NextResult()

                dt.Load(dr)
                BE.ItemsDetalle = dt

                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return BE
    End Function

    Public Function GetByIDDocumento(ByVal tDocumento As String) As DocumentoBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim dr As SqlDataReader = Nothing
        Dim DocumentoBE As New DocumentoBE

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_DOCUMENTO_GET_ID"
            With .Parameters
                .Add("@tDocumento", SqlDbType.NVarChar, 20).Value = tDocumento
            End With
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With DocumentoBE
                        .NumeroDocumento = dr.ReadNullAsEmptyString("tDocumento")
                        .Proveedor = dr.ReadNullAsEmptyString("Proveedor")
                        .Ruc = dr.ReadNullAsEmptyString("Ruc")
                        .FechaEmision = dr.ReadNullAsEmptyDate("fEmision")
                        .Total = dr.ReadNullAsNumeric("nTotal")
                        .Glosa = dr.ReadNullAsEmptyString("tGlosa")
                        .Moneda = dr.ReadNullAsEmptyString("Moneda")
                        .Impuesto1 = dr.ReadNullAsNumeric("nImpuesto1")
                        .Impuesto2 = dr.ReadNullAsNumeric("nImpuesto2")
                        .Neto = dr.ReadNullAsNumeric("nNeto")
                        .Percepcion = dr.ReadNullAsNumeric("nPercepcion")
                        .Redondeo = dr.ReadNullAsNumeric("nRedondeo")
                        .Detraccion = 0
                    End With

                End While

                dr.NextResult()

                If dr.HasRows Then
                    While dr.Read()
                        Dim DocumentoDetalleBE As New DocumentoBE.DetalleBE
                        With DocumentoDetalleBE
                            .Articulo = dr.ReadNullAsEmptyString("Articulo")
                            .Item = dr.ReadNullAsEmptyString("nItem")
                            .Cantidad = dr.ReadNullAsNumeric("nCantidad")
                            .Precio = dr.ReadNullAsNumeric("nPrecio")
                            .UnidadMedida = dr.ReadNullAsEmptyString("UnidadMedida")
                            .ValorVenta = dr.ReadNullAsNumeric("nNeto")
                            .ValorImpuesto1 = dr.ReadNullAsNumeric("nImpuesto1")
                            .ValorImpuesto2 = dr.ReadNullAsNumeric("nImpuesto2")
                            .SubTotal = dr.ReadNullAsNumeric("nTotal")
                        End With

                        DocumentoBE.Items.Add(DocumentoDetalleBE)
                    End While
                End If

                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return DocumentoBE
    End Function

    Public Function GetByListadoDocumentosNoEnviados(ByVal IDENVIO As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_LISTADO_DOCUMENTOS_NO_ENVIADOS"
            With .Parameters
                .Add("@IDENVIO", SqlDbType.Int).Value = IDENVIO
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

    Public Function SaveDocumentoProcesadoAnexar(ByVal IDENVIO As Int32, ByVal NUMERODOCUMENTO As String, ByVal CORRELATIVODOCUMENTO As String, ByVal IDTIPODOCUMENTO As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_DETALLE_INSERT_ANEXAR"
            With .Parameters
                .Add("@IDENVIO", SqlDbType.Int).Value = IDENVIO
                .Add("@NUMERODOCUMENTO", SqlDbType.NVarChar, 20).Value = NUMERODOCUMENTO
                .Add("@CORRELATIVODOCUMENTO", SqlDbType.NVarChar, 20).Value = CORRELATIVODOCUMENTO
                .Add("@IDTIPODOCUMENTO", SqlDbType.NVarChar, 2).Value = IDTIPODOCUMENTO
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


    Public Function GetDocumentoEnvioReporte(ByVal IDENVIO As Int32) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCompras)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_ENVIO_DOCUMENTO_REPORTE"
            With .Parameters
                .Add("@IDENVIO", SqlDbType.Int).Value = IDENVIO
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

End Class
