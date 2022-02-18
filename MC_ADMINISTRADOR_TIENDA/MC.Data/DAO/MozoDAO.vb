Imports System.Data.SqlClient

Public Class MozoDAO

    Public Property CODIGO As String = "0000"
    Public Function Save(ByVal BE As MozoBE) As Int32
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim Result As Int32 = 0
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            If BE.CODIGO = "" Then
                .CommandText = "MCMT_MOZO_INS"
                .Parameters.Add("@tcodigo", SqlDbType.NVarChar, 4).Direction = ParameterDirection.Output
            Else
                .CommandText = "MCMT_MOZO_UPD"
                .Parameters.Add("@tcodigo", SqlDbType.NVarChar, 4).Value = BE.CODIGO
            End If
            With .Parameters
                .Add("@ttabla", SqlDbType.NVarChar, 4).Value = "MOZO"
                '.Add("@tcodigo", SqlDbType.NVarChar, 4).Value = BE.CODIGO
                .Add("@ntamano", SqlDbType.Int).Value = 0
                .Add("@tdetallado", SqlDbType.NVarChar, 50).Value = BE.DETALLADO
                .Add("@tresumido", SqlDbType.NVarChar, 24).Value = BE.RESUMIDO
                .Add("@ticono", SqlDbType.NVarChar, 50).Value = BE.DNI
                .Add("@nboton", SqlDbType.Int).Value = 0
                .Add("@tvalor", SqlDbType.NVarChar, 50).Value = BE.PASSWORD
                .Add("@nvalor", SqlDbType.Float).Value = BE.PERMITEVER
                .Add("@lactivo", SqlDbType.Int).Value = BE.ESTADO
                .Add("@lReplica", SqlDbType.Int).Value = 0
                .Add("@tvalor2", SqlDbType.NVarChar, 4000).Value = BE.NOMBRECOMPUESTO
            End With
        End With
        Try
            cnx.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                CODIGO = cmd.Parameters("@tcodigo").Value
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

    Public Function GetByMozos(ByVal tipo As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCMT_GET_ALL_MOZOS"
            .Parameters.Add("@estado", SqlDbType.Int).Value = tipo
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

    Public Function GetByID() As MozoBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim MozoBe As New MozoBE
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCMT_MOZOS_GET_ID"
            .Parameters.Add("@codigo", SqlDbType.NVarChar, 10).Value = Me.CODIGO
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            With MozoBe
                .CODIGO = dt.Rows(0).Item("Codigo")
                .DETALLADO = dt.Rows(0).Item("Detallado")
                .RESUMIDO = dt.Rows(0).Item("Resumido")
                .DNI = dt.Rows(0).Item("dni")
                .ESTADO = dt.Rows(0).Item("lactivo")
                .PERMITEVER = dt.Rows(0).Item("nvalor")
                .PASSWORD = dt.Rows(0).Item("tvalor")
                .NOMBRECOMPUESTO = dt.Rows(0).Item("tValor2")
            End With
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return MozoBe
    End Function

    Public Function GetByDNI(ByVal dni As String, ByVal codigo As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim estado As Integer
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCMT_MOZOS_GET_DNI"
            .Parameters.Add("@dni", SqlDbType.NVarChar, 50).Value = dni
            .Parameters.Add("@codigo", SqlDbType.NVarChar, 10).Value = codigo
        End With
        Try
            cnx.Open()
            estado = cmd.ExecuteScalar()
        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return estado
    End Function

End Class
