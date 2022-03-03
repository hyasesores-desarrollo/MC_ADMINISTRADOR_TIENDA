Public Class MC_clientesBE
    Public Property IdCliente As Integer
    Public Property IdTipoIdentidad As String
    Public Property NumeroDocumento As String
    Public Property Nombres As String
    Public Property Apellidos As String
    Public Property NombrePreferido As String
    Public Property Telefono As String
    Public Property Correo As String
    Public Property FechaNacimiento As DateTime
    Public Property IdGenero As Integer
    Public Property IdDistrito As Integer
    Public Property Ubigeo As String
    Public Property Direccion As String
    Public Property UrlConsentimiento As String
    Public Property Estado As Boolean
    Public Property FechaRegistro As DateTime
    Public Property Puntos As Integer
    Public Property mc_clientedetalle As List(Of MC_cliente_detalleBE)

    Public Sub New()
        mc_clientedetalle = New List(Of MC_cliente_detalleBE)
    End Sub


End Class
