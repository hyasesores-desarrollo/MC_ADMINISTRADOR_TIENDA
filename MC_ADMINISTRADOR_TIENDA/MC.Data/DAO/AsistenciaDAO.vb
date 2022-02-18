Imports System.Data.SqlClient

Public Class AsistenciaBE    
    Public Property ID As Int32 
    Public Property DIASEMANA As STRING
    Public Property FECHA As Date 
    Public Property COLABORADOR As String
    Public Property INGRESO As String 
    Public Property SALIDA As String 
    Public Property FOTO As Byte()

End Class

Public Class AsistenciaDAO
    Public IDEMPLEADO As Integer
    Public FOTO As Byte()
#Region "ASISTENCIA LOCALES"
    Dim AsistenciaBE As New AsistenciaBE
    Public Function Asistencia(FechaIni As Date, FechaFin As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBMarcacion)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_CONTROLASISTENCIA"
            With .Parameters
                .Add("@FECHAINI", SqlDbType.DateTime).Value = FechaIni
                .Add("@FECHAFIN", SqlDbType.DateTime).Value = FechaFin
            End With

        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("Error Critico " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function

    Public Function GetFoto(ID As Int32) As AsistenciaBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBMarcacion)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_GETFOTO"
            With .Parameters
                .Add("@ID", SqlDbType.Int).Value = ID
            End With

        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    AsistenciaBE.ID = dr.ReadNullAsNumeric("ID")
                    AsistenciaBE.FOTO = dr("FOTO")
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
        Return AsistenciaBE

    End Function

#End Region
#Region "Asistencia HY"
    Public Function ColaboradoresHyList(ByVal Estado As Boolean) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_COLABORADORES_HY"
            With .Parameters
                .Add("@Estado", SqlDbType.Bit).Value = Estado
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("Error Critico " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function ColaboradoresMarcacionesHyGetId(ByVal IdEmpleado As Integer, ByVal FechaInicio As Date, ByVal FechaFinal As Date) As DataTable
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBCentral)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MC_COLABORADORES_MARCACIONES_HY_GETIDEMPLEADO"
            With .Parameters
                .Add("@IDEMPLEADO", SqlDbType.Int).Value = IdEmpleado
                .Add("@FECHAINICIO", SqlDbType.Date).Value = FechaInicio
                .Add("@FECHAFINAL", SqlDbType.Date).Value = FechaFinal
            End With
        End With
        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw New Exception("Error Critico " & vbCrLf & ex.Message)
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return dt
    End Function
    Public Function MostrarFotoMarcacionHyGetId(ByVal CnTienda As SqlConnection, ByVal IdMarcacion As String) As Byte
        Try
            Dim reader As SqlDataReader
            Dim cmd = New SqlCommand
            With cmd
                CnTienda.Open()

                .Connection = CnTienda
                .CommandType = CommandType.Text
                .CommandText = "select m.Foto from MCCBD_SINCRONIZACION_LOCAL S INNER JOIN MC_MARCACION M ON M.ID=S.CampoLLave where S.CampoLlave = " + IdMarcacion
                reader = cmd.ExecuteReader()
                While reader.Read()
                    FOTO = (reader.Item(0))
                End While
                CnTienda.Close()
            End With
        Catch ex As Exception

        End Try

        'Return ""
    End Function
#End Region
End Class
