Imports System.Configuration
Imports System.Data.SqlClient
Public Class ActualizarConfig
    Public Function GetConnectionString(connectionStringName As String) As SqlConnectionStringBuilder
        Try
            ' Obtenemos el objeto ConnectionStringSettings
            ' correspondiente al nombre de la cadena de
            ' conexión especificada.
            '
            Dim settings As ConnectionStringSettings = GetConnectionStringSettings(connectionStringName)

            ' Devolvemos el objeto SqlConnectionStringBuilder que construimos
            ' a partir de la cadena de conexión obtenida.
            '
            Return New SqlConnectionStringBuilder(settings.ConnectionString)

        Catch
            Throw

        End Try

    End Function
    Public Sub SetConnectionString(connectionStringName As String, dataSource As String, initialCatalog As String, user As String, password As String)

        ' Comprobación de los parámetros.
        '
        If (String.IsNullOrEmpty(connectionStringName)) Then _
         Throw New ArgumentNullException("connectionStringName")

        Try
            ' Obtenemos el objeto ConnectionStringSettings
            ' correspondiente al nombre de la cadena de
            ' conexión especificada.
            '
            Dim settings As ConnectionStringSettings = _
             GetConnectionStringSettings(connectionStringName)

            ' Especificamos la nueva cadena de conexión
            '
            settings.ConnectionString = _
             String.Format("Data Source={0};Initial Catalog={1};USER ID={2};Password={3}", dataSource, initialCatalog, user, password)

            ' Guardamos los valores en el archivo
            ' de configuración de nuestra aplicación.
            '
            settings.CurrentConfiguration.Save(ConfigurationSaveMode.Modified)

            'Refresca la section del app.config
            ConfigurationManager.RefreshSection("connectionStrings")

        Catch
            Throw

        End Try

    End Sub
    Public Function GetConnectionStringSettings(connectionStringName As String) As ConnectionStringSettings

        Try
            ' Obtenemos el archivo de configuración de la aplicación.
            '
            Dim config As Configuration = _
             ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            ' Obtenemos la sección connectionStrings.
            '
            Dim section As ConnectionStringsSection = config.ConnectionStrings

            ' Obtenemos el objeto ConnectionStringSettings
            ' correspondiente al nombre de la cadena de
            ' conexión especificada.
            '
            Dim settings As ConnectionStringSettings = _
             section.ConnectionStrings.Item(connectionStringName)

            If (settings Is Nothing) Then
                Throw New ArgumentException("No existe la cadena de conexión.")
            End If

            ' Devolvemos el objeto obtenido.
            '
            Return settings

        Catch
            Throw

        End Try

    End Function
    Public Sub actualizarConfigTodos(ByVal cadena As String, ByVal ipServer As String, ByVal user As String, pass As String, BD As String)
        Try
            ' Obtenemos el objeto SqlConnectionStringBuilder
            ' correspondiente al nombre de la cadena de
            ' conexión llamada 'default' existente en nuestro
            ' archivo de configuración de la aplicación.
            '
            Dim csb As SqlClient.SqlConnectionStringBuilder = GetConnectionString(cadena)

            ' Modificamos el parámetro Data Source
            '
            csb.DataSource = ipServer

            ' Modificamos la base de datos inicial
            '
            csb.InitialCatalog = BD

            ' ¿Se está utilizando la propia
            ' seguridad de SQL Server?
            '

            If (Not (csb.IntegratedSecurity)) Then
                ' Modificamos el usuario
                '
                csb.UserID = user

                ' Modificamos la contraseña del usuario
                '
                csb.Password = pass
            End If

            ' Escribimos la información en el archivo
            ' de configuración de la aplicación.
            '
            SetConnectionString(cadena, csb.DataSource, csb.InitialCatalog, csb.UserID, csb.Password)

        Catch ex As Exception
            '   MessageBox.Show(ex.Message)

        End Try

    End Sub
    Public Sub actualizaConfig(ByVal ipserver As String)
        actualizarConfigTodos("MC.Windows.My.MySettings.MC_ComprasConnectionString", ipserver, "desarrollo", "sistemas", "ALMACEN")
        actualizarConfigTodos("MC.Windows.My.MySettings.MC_VentasConnectionString", ipserver, "desarrollo", "sistemas", "INFOREST")
        actualizarConfigTodos("MC.Windows.My.MySettings.MC_MARCADORConnectionString", ipserver, "desarrollo", "sistemas", "MC_MARCACION")
    End Sub
End Class