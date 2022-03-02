Public Class MC_clientes
    Public Property IdCliente As Integer
    Public Property IdTipoIdentidad As Integer
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
    Public Property mc_clientedetalle As List(Of MC_cliente_detalle)

    Public Sub New()
        mc_clientedetalle = New List(Of MC_cliente_detalle)
    End Sub


End Class
