Imports System.Data.SqlClient

Public Class BeneficioNorkysDAO

    Public Function DatosEmpleadoDniList(ByVal NumeroDocumento As String) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_BENEFICIONORKYS_EMPLEADO_DNI"
            With .Parameters
                .Add("@NUMERODOCUMENTO", SqlDbType.VarChar, 20).Value = NumeroDocumento
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
    Public Function BeneficiosNorkysList(ByVal IdLocal As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_BENEFICIONORKYS_EMPLEADOS_LIST"
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
    Public Function RegistrarBeneficioEmpleado(ByVal IdEmpleado As Integer, ByVal IdLocal As Int32, ByVal IdCanalVenta As Int32, ByVal MedioRegistro As Int32, ByVal NumeroPedido As String, ByVal UsuarioRegistro As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim Result As Boolean = False
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_BENEFICIOS_NORKYS_EMPLEADO_INS"
            With .Parameters

                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
                .Add("@IDLOCALCONSUMO", SqlDbType.Int).Value = IdLocal
                .Add("@IDCANALVENTA", SqlDbType.Int).Value = IdCanalVenta
                .Add("@MEDIOREGISTROCONSUMO", SqlDbType.Int).Value = MedioRegistro
                .Add("@NUMEROPEDIDO", SqlDbType.VarChar, 20).Value = NumeroPedido
                .Add("@USUARIOREGISTRO", SqlDbType.VarChar, 20).Value = UsuarioRegistro
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
    Public Function BeneficiosNorkysGetIdEmpleado(ByVal IdEmpleado As Integer) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_BENEFICIONORKYS_EMPLEADOS_GET_IDEMPLEADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
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
