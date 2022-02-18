Public Class DocumentoBE
    Public Property NumeroDocumento As String
    Public Property FechaEmision As DateTime
    Public Property Proveedor As String
    Public Property Ruc As String
    Public Property Moneda As String
    Public Property Glosa As String
    Public Property Percepcion As Double
    Public Property Detraccion As Double
    Public Property Redondeo As Double
    Public Property SubTotal As Double
    Public Property Total As Double
    Public Property Descuento As Double
    Public Property Impuesto1 As Double
    Public Property Impuesto2 As Double
    Public Property Neto As Double

    Public Property Items As New List(Of DocumentoBE.DetalleBE)

    Public Class DetalleBE
        Public Property Articulo As String
        Public Property UnidadMedida As String
        Public Property Item As String
        Public Property Cantidad As Double
        Public Property Precio As Double
        Public Property ValorVenta As Double
        Public Property ValorImpuesto1 As Double
        Public Property ValorImpuesto2 As Double
        Public Property SubTotal As Double
    End Class
End Class
