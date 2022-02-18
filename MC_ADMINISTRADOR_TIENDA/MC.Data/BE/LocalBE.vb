Public Class LocalBE
    Public Property IDLocal As Int32
    Public Property Nombre As String
    Public Property BancoCuentasItems As New List(Of BancoCuentasBE)

    Public Class BancoCuentasBE
        Public Property IDLocalBancoCuentas As Int32
        Public Property IDLocal As Int32
        Public Property IDBanco As Int32
        Public Property IDBancoConvenio As Int32
        Public Property IDBancoTipoCuenta As Int32
        Public Property IDMoneda As Int32
        Public Property NumeroCuenta As String
        Public Property CorrelativoCheque As String
        Public Property Cheque As Int32
        Public Property Telebanking As Int32
        Public Property NumeroLocalTelebanking As Int32
        Public Property NumeroOrdenReporteTelebanking As Int32
        Public Property IDEstado As Int32
        Public Property IDUsuario As Int32
        Public Property FechaRegistro As DateTime
    End Class

End Class
