Imports System.Data.SqlClient
Public Class ParametroDAO
    Public Function GetImpuesto2_por_producto(producto As String, pedido As String) As Boolean
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim ValRet As Boolean
        If (pedido = Nothing) Then
            pedido = "xx"
        End If

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCPE_OBTENER_IMPUESTO2_POR_PRODUCTO"
            With .Parameters
                .Add("@tCodigoProducto", SqlDbType.NVarChar, 7).Value = producto
                .Add("@tCodigoPedido", SqlDbType.NVarChar, 7).Value = pedido
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                ValRet = Convert.ToBoolean(dt.Rows(0)(0))
            End If

        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ValRet
    End Function
    Public Function GetIGV() As Double
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim ValRet As Double = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCPE_OBTENER_IGV_PARAMETRO"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                ValRet = Convert.ToDouble(dt.Rows(0)(0))
            End If

        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ValRet
    End Function

    Public Function GetRecargoxConsumo() As Double
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim ValRet As Double = 0

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCPE_OBTENER_RECARGOxCONSUMO_PARAMETRO"
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                ValRet = Convert.ToDouble(dt.Rows(0)(0))
            End If

        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ValRet
    End Function

    Public Function Validar_NumeroDocumentoNew(NumeroDocumentoNew As String) As Integer
        Dim cnx As New SqlConnection(ConexionDAO.GetConexionDBVentas)
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim ValRet As Integer

        With cmd
            .Connection = cnx
            .CommandType = CommandType.StoredProcedure
            .CommandText = "MCPE_VALIDAR_NUMERODOCUMENTO"
            With .Parameters
                .Add("@tDocumentonew", SqlDbType.NVarChar, 20).Value = NumeroDocumentoNew
            End With
        End With

        Try
            cnx.Open()
            dt.Load(cmd.ExecuteReader)
            If dt.Rows.Count > 0 Then
                ValRet = Convert.ToInt32(dt.Rows(0)(0))
            End If

        Catch ex As Exception
            Throw
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
        Return ValRet
    End Function
End Class