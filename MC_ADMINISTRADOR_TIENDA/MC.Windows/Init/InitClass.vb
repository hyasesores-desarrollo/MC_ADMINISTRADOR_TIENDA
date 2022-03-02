Imports MC.Data
Imports DevExpress.XtraEditors
Imports System.Configuration

Module InitClass

    Public SistemaDAO As New SistemaDAO
    Public UsuarioDAO As New UsuarioDAO
    Public DocumentoDAO As New DocumentoDAO
    Public ClienteFacturadoDAO As New ClienteFacturadoDAO
    Public MozoDAO As New MozoDAO
    Public NotaCreditoDAO As New NotaCreditoDAO
    Public AsistenciaDAO As New AsistenciaDAO
    Public CajaDAO As New CajaDAO
    Public DocumentoVentaDAO As New DocumentoVentaDAO
    Public ParametroDAO As New ParametroDAO
    Public MotorizadoDAO As New MotorizadoDAO
    Public CodigoEntelDAO As New CodigoEntelDAO
    Public BeneficioNorkysDAO As New BeneficioNorkysDAO
    Public ClienteFidelizadoDAO As New ClienteFidelizadoDAO

    Public ServidorCentral As String = ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_CentralConnectionString").ConnectionString
    Public TipoConexion As Boolean


    Public tTurnoActual As String
    Public tCajaEmision As String

    'NOTA DE CREDITO
    Public DocumentoSeleccionadoNc As String
    Public idDocumentoSeleccionadoNc As Integer
    Public EstadoNotaC As String

    Public tReciboEgresoSeleccionado As String
    Public tTipoEgresoSeleccionado As String
    Public tTipoMonedaSeleccionado As String

    Public tTipoDocumentoSeleccionado As String
    Public tDocumentoSeleccionado As String
    Public fechaSeleccionado As String


    Public lCentral As String = ""
    Public ActualizarAPP As New ActualizarConfig
    Public lLocal As String
    Public nombreTienda As String = ""

    Public IdLocal As Integer = 0
    Public IPServerCentral As String = "192.168.6.97"
    Public BdCodigoEntel As String = "BD_CODIGO_ENTEL"
    Public BdCentral As String = "MC_CENTRAL"
    Public BdMarcacionLocal As String = "MC_MARCACION"
    Public bsGrilla As New DataTable

    Public Function GetUltimoCambio(ByRef objBarStatic As DevExpress.XtraBars.BarStaticItem, BE As Object) As String
        Dim UltimoCambio As String = "El último cambio fue registrado por {0} el {1} a las {2}:{3}:{4}"
        Dim Fecha As DateTime = BE.FechaRegistro

        UltimoCambio = String.Format(UltimoCambio, BE.NombreUsuario, Fecha.Date.ToString("d"), Fecha.Hour.ToString("00"), Fecha.Minute.ToString("00"), Fecha.ToString("00"))

        objBarStatic.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        objBarStatic.Caption = UltimoCambio

        Return UltimoCambio
    End Function

End Module
