Imports System.Data.SqlClient

Public Class UsuarioBE
    Public Property IDUsuario As Int32
    Public Property Nombres As String
    Public Property ApellidoPaterno As String
    Public Property ApellidoMaterno As String
    Public Property Usuario As String
    Public Property Contrasena As String
    Public Property CorreoELectronico As String
    Public Property Login As String
    Public Property Activo As Boolean
    Public Property NombreRol As String
    Public Property IdRol As Int32
    Public Property IdRolTemporal As Int32
    Public Property FechaInicioRol As Nullable(Of Date)
    Public Property FechaFinalRol As Nullable(Of Date)
    Public Property IDUsuarioRegistro As Int32
    Public Property FechaRegistro As DateTime
    Public Property NombreUsuario As String


    'DATOS DE ALMACEN
    Public Property tCodigoUsuario As String
    Public Property tDetallado As String
    Public Property tResumido As String
    Public Property lActivo As Boolean
    Public Property tGrupoUsuario As String


    Public Property Permisos As List(Of String)

    Public Function Acceso(CodPermiso As String) As Boolean
        Dim Result As Int16 = False

        If Permisos.Where(Function(i) i = CodPermiso).Count = 1 Then
            Result = True
        End If
        Return Result

    End Function
End Class

Public Class UsuarioDAO
    Public Property IDUsuario As Int32

    Public Function GetByLoginPassword(ByVal NombreUsuario As String, Contrasena As String) As UsuarioBE
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader = Nothing
        Dim UsuarioBE As New UsuarioBE
        Dim Lista As New List(Of String)

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCMT_USUARIO_GET_LOGIN"
            .Parameters.Add("@resumido", SqlDbType.NVarChar, 15).Value = NombreUsuario
            .Parameters.Add("@tpassword", SqlDbType.NVarChar, 10).Value = Contrasena
        End With

        Try
            cnx.Open()
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read()
                    With UsuarioBE
                        .tCodigoUsuario = dr.ReadNullAsEmptyString("tCodigoUsuario")
                        .tDetallado = dr.ReadNullAsEmptyString("tDetallado")
                        .tResumido = dr.ReadNullAsEmptyString("tResumido")
                        .lActivo = dr.ReadNullAsBoolean("lActivo")
                        .tGrupoUsuario = dr.ReadNullAsEmptyString("tGrupoUsuario")
                    End With
                End While

                dr.NextResult()

                dr.Close()
            End If
        Catch ex As Exception
            Throw
        Finally
            cnx.Close()
        End Try
        Return UsuarioBE
    End Function

    Public Function GetSubModulos(ByVal idrol As String) As DataTable

        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCR_ACCESOS_ROL_SUBMODULO"
            .Parameters.Add("@idrol", SqlDbType.NVarChar, 2).Value = idrol
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
        Catch ex As Exception
            Throw ex
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try

        Return dt

    End Function

End Class
