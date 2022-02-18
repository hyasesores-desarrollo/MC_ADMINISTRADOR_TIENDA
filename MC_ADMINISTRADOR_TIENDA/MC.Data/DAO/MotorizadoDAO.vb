Imports System.Data.SqlClient

Public Class MotorizadoDAO
    Public Property CODIGO As String = "0000"
    Public Property IdMotorizadoDetalle As Integer
    Public Property Resultado As String = ""
    Public Property IdTipoComision As Integer
    Public Property IdTipoComisionDetalle As Integer

#Region "CENTRAL"

    Public Function GetByMotorizadoLocal(ByVal IdLocal As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_MOTORIZADO_GETIDLOCAL"
            With .Parameters
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
    Public Function GetByIDMotorizadoDetalle(ByVal IdMotorizadoDetalle As Integer) As MotorizadoBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim MotorizadoBe As New MotorizadoBE
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_MOTORIZADO_DETALLE_GETID"
            .Parameters.Add("@IdMotorizadoDetalle", SqlDbType.Int).Value = IdMotorizadoDetalle
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            With MotorizadoBe
                .CODIGO = dt.Rows(0).Item("CodigoInforest")
                .DETALLADO = dt.Rows(0).Item("Detallado")
                .RESUMIDO = dt.Rows(0).Item("Resumido")
                .ACTIVO = dt.Rows(0).Item("Estado")
                '.TIPOTARIFA = dt.Rows(0).Item("TipoTarifa")
                '.TARIFA = dt.Rows(0).Item("Tarifa")
                .IDTIPOMOTORIZADO = dt.Rows(0).Item("IdTipoMotorizado")
                .TIPOMOTORIZADO = dt.Rows(0).Item("TipoMotorizado")
                .IDTIPOCOMISION = dt.Rows(0).Item("IdTipoComisionMotorizado")
                .TIPOCOMISION = dt.Rows(0).Item("Tipocomision")

                .IDEMPLEADO = dt.Rows(0).Item("IdEmpleado")
                .NOMBREEMPLEADO = dt.Rows(0).Item("NOMBREEMPLEADO")
                .DOCUMENTOIDENTIDAD = dt.Rows(0).Item("NUMERODOCUMENTO")
            End With
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return MotorizadoBe
    End Function 'OK
    Public Function GetByEmpleado() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_GET_ALL_EMPLEADO_MOTORIZADO"
            '.Parameters.Add("@IDESTADO", SqlDbType.Int).Value = Estado
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
    Public Function GetByTipoMotorizado() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_TIPO_MOTORIZADO_LIST_ALL"
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
    Public Function GetByTipoComision() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_TIPO_COMISION_MOTORIZADO_LIST_ACTIVO"
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
    Public Function ValidarDuplicidadEmpleadoIns(ByVal IdMotorizadoDetalle As Integer, ByVal IdEmpleado As Integer, ByVal Detallado As String, ByVal IdTipoMotorizado As Integer, ByVal IdLocal As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_VALIDAR_MOTORIZADO_INS"
            With .Parameters
                .Add("@IdMotorizadoDetalle", SqlDbType.Int).Value = IdMotorizadoDetalle
                .Add("@IdEmpleado", SqlDbType.Int).Value = IdEmpleado
                .Add("@Detallado", SqlDbType.VarChar, 50).Value = Detallado
                .Add("@IdTipoMotorizado", SqlDbType.Int).Value = IdTipoMotorizado
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
    End Function
    Public Function SaveCentral(ByVal BE As MotorizadoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentasCentral)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            '.CommandText = "MC_MOTORIZADO_DETALLE_INS_ANTIGUO"
            .CommandText = "MC_MOTORIZADO_DETALLE_INS" 'Esto se ejecuta en la segunda actualizacion
            With .Parameters
                .Add("@IdMotorizadoDetalle", SqlDbType.Int).Value = BE.IDMOTORIZADODETALLE
                .Add("@IdEmpleado", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@IdLocal", SqlDbType.Int).Value = BE.IDLOCAL
                .Add("@IdTipoMotorizado", SqlDbType.Int).Value = BE.IDTIPOMOTORIZADO
                .Add("@IdTipoComision", SqlDbType.Int).Value = BE.IDTIPOCOMISION
                .Add("@CodigoInforest", SqlDbType.VarChar, 4).Value = CODIGO
                .Add("@Detallado", SqlDbType.VarChar, 50).Value = BE.DETALLADO
                .Add("@RESUMIDO", SqlDbType.VarChar, 24).Value = BE.RESUMIDO
                .Add("@Estado", SqlDbType.Bit).Value = BE.ACTIVO
                .Add("@Usuario", SqlDbType.VarChar, 20).Value = BE.USUARIO
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

#End Region
#Region "INFOREST"
    Public Function SaveInforest(ByVal BE As MotorizadoBE) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            If BE.CODIGO = "" Then
                .CommandText = "MCMT_MOTORIZADO_INS"
                .Parameters.Add("@CODIGO", SqlDbType.NVarChar, 4).Direction = ParameterDirection.Output
            Else
                .CommandText = "MCMT_MOTORIZADO_UPD"
                .Parameters.Add("@CODIGO", SqlDbType.NVarChar, 4).Value = BE.CODIGO
            End If
            With .Parameters
                '.Add("@EXTERNO", SqlDbType.Bit).Value = BE.TIPOCOMISION
                .Add("@DETALLADO", SqlDbType.NVarChar, 50).Value = BE.DETALLADO
                .Add("@RESUMIDO", SqlDbType.NVarChar, 24).Value = BE.RESUMIDO
                '.Add("@DOCUMENTOIDENTIDAD", SqlDbType.NVarChar, 40).Value = BE.DOCUMENTOIDENTIDAD
                '.Add("@TARIFA", SqlDbType.Float).Value = BE.TARIFA
                '.Add("@TIPOTARIFA", SqlDbType.Int).Value = BE.TIPOTARIFA
                '.Add("@IDEMPLEADO", SqlDbType.Int).Value = BE.IDEMPLEADO
                .Add("@ACTIVO", SqlDbType.Int).Value = BE.ACTIVO
            End With
        End With
        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                CODIGO = cmd.Parameters("@CODIGO").Value
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

#End Region

    'Public Function GetByMotorizado(ByVal tipo As Integer) As DataTable 'BORRAR
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
    '    Dim cmd As New SqlCommand
    '    Dim dt As New DataTable

    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "MCMT_GET_ALL_MOTORIZADO"
    '        .Parameters.Add("@estado", SqlDbType.Int).Value = tipo
    '    End With

    '    Try
    '        cnx.Open()
    '        dt.Load(cmd.ExecuteReader)
    '    Catch ex As Exception
    '        Throw
    '    Finally
    '        If cnx.State = ConnectionState.Open Then
    '            cnx.Close()
    '        End If
    '    End Try
    '    Return dt
    'End Function


    'Public Function GetByID() As MotorizadoBE
    '    Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
    '    Dim cmd As New SqlCommand
    '    Dim dr As SqlDataReader = Nothing
    '    Dim MotorizadoBe As New MotorizadoBE
    '    Dim dt As New DataTable
    '    With cmd
    '        .Connection = cnx
    '        .CommandType = CommandType.StoredProcedure
    '        .CommandText = "MCMT_MOTORIZADO_GET_ID"
    '        .Parameters.Add("@codigo", SqlDbType.NVarChar, 10).Value = Me.CODIGO
    '    End With
    '    Try
    '        cnx.Open()
    '        dt.Load(cmd.ExecuteReader)
    '        With MotorizadoBe
    '            .CODIGO = dt.Rows(0).Item("Codigo")
    '            .DETALLADO = dt.Rows(0).Item("Detallado")
    '            .RESUMIDO = dt.Rows(0).Item("Resumido")
    '            .ACTIVO = dt.Rows(0).Item("Activo")
    '            .TIPOTARIFA = dt.Rows(0).Item("TipoTarifa")
    '            .TARIFA = dt.Rows(0).Item("Tarifa")
    '            .DOCUMENTOIDENTIDAD = dt.Rows(0).Item("DocumentoIdentidad")
    '            .TIPOCOMISION = dt.Rows(0).Item("TipoComision")
    '            .IDEMPLEADO = dt.Rows(0).Item("IDEmpleado")

    '        End With
    '    Catch ex As Exception
    '        Throw
    '    Finally
    '        If cnx.State = ConnectionState.Open Then
    '            cnx.Close()
    '        End If
    '    End Try
    '    Return MotorizadoBe
    'End Function


End Class
