Public Enum eTipoImpuesto
    PrecioImpuestoIncluir = 1
    PrecioImpuestoNoIncluir = 2
End Enum
Public Enum eTipoDescuento
    PorMonto = 1
    PorPorcentaje = 2
End Enum
Public Enum eEstadoDocumento
    Generado = 1
    Revisado = 2
    Anulado = 3
End Enum
Public Enum eTipoConsulta
    TodosLosDocumentos = 1
    SoloDocumentosPendientes = 2
    DocumentosDetraccion = 3
End Enum
Public Enum eTipoDestinoDocumento
    ControlInterno = 1
    TesoreriaPagos = 2
    GerenciaAdministracion = 3
End Enum

Public Enum eTipoPagoVentas
    Efectivo = 1
    TarjetaCredito = 2
    Cheque = 3
    Varios = 4
    Puntos = 5
End Enum

Public Enum eTipoMoneda
    Soles = 1
    Dolares = 2
End Enum

Module InitEnumeraciones

End Module
