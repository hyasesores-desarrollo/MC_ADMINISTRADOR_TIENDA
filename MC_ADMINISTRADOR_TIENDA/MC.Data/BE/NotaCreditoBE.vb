Public Class NotaCreditoBE

    Public Property tNotaCredito As String
    Public Property fFecha As Date
    Public Property tDocumento As String
    Public Property nNeto As Double
    Public Property nImpuesto1 As Double
    Public Property nImpuesto2 As Double
    Public Property nImpuesto3 As Double
    Public Property nVenta As Double
    Public Property tTurno As String
    Public Property tCaja As String
    Public Property tUsuario As String
    Public Property tObservacion As String

    '--NOTA DE CREDITO CAJA
    'Public Property idNotaCredito As Integer
    'Public Property tNroNotaCredito As String
    'Public Property fFechaEmision As Date
    'Public Property idComprobante As Integer
    'Public Property idTipoDocumentoAfectado As Integer
    'Public Property tNroDocumentoAfectado As String
    'Public Property tNroIdentidad As String
    'Public Property tNombreRazonSocial As String
    'Public Property idTipoNotaCredito As Integer
    'Public Property nTotalVentaGrabada As Double
    'Public Property nTotalVentaInafecta As Double
    'Public Property nTotalVentaExonerada As Double
    'Public Property nTotalIGV As Double
    'Public Property nTotalOtrosTributos As Double
    'Public Property nTotalOtrosCargos As Double
    'Public Property nTotalDescuento As Double
    'Public Property nImporteTotal As Double
    'Public Property idTipoIdentidad As Integer
    'Public Property tEstadoNC As String
    'Public Property fRegistro As Date
    'Public Property tDireccionAdquiriente As String
    'Public Property tEmailAdquiriente As String
    'Public Property nTotalISC As Double
    'Public Property tTurno As String
    'Public Property idNotaCreditoCoe As Integer
    'Public Property fFechaAnulado As Date
    'Public Property idCaja As String


    ''---ENVIO DOCUMENTOS ALMACEN
    'Public Property Fecha As DateTime
    'Public Property TipoNotaCredito As String
    'Public Property Proveedor As String
    'Public Property Ruc As String
    'Public Property NumeroNotaCredito As String
    'Public Property TotalNotaCredito As Double
    'Public Property TotalDocumento As Double
    'Public Property NetoNotaCredito As Double
    'Public Property IgvNotaCredito As Double
    'Public Property Observacion As String
    'Public Property NumeroDocumentoReferencia As String
    Public Property Items As New List(Of NotaCreditoDetalleBE)

    Public Property ItemsDetalle As DataTable

    Public Class NotaCreditoDetalleBE
        Public Property Articulo As String
        Public Property Cantidad As Double
        Public Property Precio As Double
        Public Property SubTotal As Double
    End Class

End Class
