Public Class DocumentoVentaBE
    Public Property NumeroDocumento As String
    Public Property NumeroDocumentoNew As String
    Public Property TipoDocumento As String
    Public Property FechaEmision As DateTime
    Public Property Cliente As String
    Public Property Ruc As String
    Public Property SubTotal As Double
    Public Property Impuesto1 As Double
    Public Property Impuesto2 As Double
    Public Property Total As Double

    Public Property Items As New List(Of DocumentoDetalleBE)
End Class

Public Class DocumentoDetalleBE
    Public Property ID As String
    Public Property Producto As String
    Public Property Cantidad As Double
    Public Property Precio As Double
    Public Property Igv As Double
    Public Property Total As Double
End Class
