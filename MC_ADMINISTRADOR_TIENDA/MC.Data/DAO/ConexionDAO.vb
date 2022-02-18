Imports MC.Framework
Imports System.Configuration

Public Class ConexionDAO

    Shared Function GetConexionDBCompras() As String
        Dim strCnx As String = ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_ComprasConnectionString").ConnectionString
        Return strCnx
    End Function

    Shared Function GetConexionDBVentas() As String
        Dim strCnx As String = ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_VENTASConnectionString").ConnectionString
        Return strCnx
    End Function

    Shared Function GetConexionDBCentral() As String
        Dim strCnx As String = ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_CentralConnectionString").ConnectionString
        Return strCnx
    End Function

    'Shared Function GetConexionDBCentralLocal() As String
    '    Dim strCnx As String = ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_CentralLocalConnectionString").ConnectionString
    '    Return strCnx
    'End Function

    Shared Function GetConexionDBMarcacion() As String
        Dim strCnx As String = ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_MARCADORConnectionString").ConnectionString
        Return strCnx
    End Function
    Shared Function GetConexionDBCodigoEntel() As String
        Dim strCnx As String = ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_CODIGOENTELConnectionString").ConnectionString
        Return strCnx
    End Function
    Shared Function GetConexionDBVentasCentral() As String
        Dim strCnx As String = ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_VentasCentralConnectionString").ConnectionString
        Return strCnx
    End Function
    Shared Function GetConexionDBComprasCentral() As String
        Dim strCnx As String = ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_ComprasCentralConnectionString").ConnectionString
        Return strCnx
    End Function
End Class
