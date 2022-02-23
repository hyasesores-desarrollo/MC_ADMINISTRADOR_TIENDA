Imports System.Data.SqlClient

Public Class CajaDAO

    Public Function GetByAll() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "usp_ObtenerCaja"
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

    Public Function ValidacionCajaActivaDelivery() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCC_Cantidad_Caja_Activa_Delivery"
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

    Public Function GetCajaDeliveryList() As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCC_Caja_Activa_Delivery_Get_lSiab"
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

    Public Function GetTurnoActivo(ByVal tCaja As String) As String
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_OBTENER_TURNO"

            With .Parameters
                .Add("@tCaja", SqlDbType.NVarChar, 3).Value = tCaja
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
        Return dt.Rows(0)(0).ToString
    End Function

    Public Function ActivacionDesactivacionCajaDelivery(ByVal TCaja As String, ByVal TipoActivacion As Int32, ByVal TCodigoUsuario As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCC_Activacion_Descativacion_Caja_Delivery"
            With .Parameters
                .Add("@TCAJA", SqlDbType.NVarChar, 3).Value = TCaja
                .Add("@TIPOACTIVACION", SqlDbType.Int).Value = TipoActivacion
                .Add("@TCODIGOUSUARIO", SqlDbType.NVarChar, 5).Value = TCodigoUsuario
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

End Class
