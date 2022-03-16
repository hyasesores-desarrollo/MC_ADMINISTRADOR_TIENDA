Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors

Public Enum eValidaControl
    TextEdit = 1
    SpinEdit = 2
    GridLoopUpEdit = 3
    SearchLookUpEdit = 4
    DateEdit = 5
End Enum

Public Class Tools

    'CONTROL DE VERSION
    Shared Function ValidaVersion(IdPrograma As Int32) As Boolean
        Dim query As String = "SELECT VERSION FROM MC_SISTEMA WHERE IDSISTEMA=" & IdPrograma
        Using cnx As New SqlConnection(ConfigurationManager.ConnectionStrings("MC.Windows.My.MySettings.MC_CentralConnectionString").ConnectionString)

            Dim cmd As New SqlCommand(query, cnx)
            cnx.Open()
            Try
                Dim valor As String = cmd.ExecuteScalar()
                If My.Application.Info.Version.ToString = cmd.ExecuteScalar() Then
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
            cnx.Close()
        End Using
        Return False
    End Function

    Shared Function ReadAppSettings(Key As String) As String
        Dim Value As String = String.Empty
        Try
            Value = ConfigurationManager.AppSettings(Key)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Value
    End Function

    Shared Function SaveAppSettings(Key As String, Value As String) As Boolean
        Dim Result As Boolean = False

        Try
            Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim settings = configFile.AppSettings.Settings

            If IsNothing(settings(Key)) Then
                settings.Add(Key, Value)
            Else
                settings(Key).Value = Value
            End If
            configFile.Save(ConfigurationSaveMode.Modified)

            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
        Catch ex As ConfigurationErrorsException
            MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return Result
    End Function

    Shared Function ComparaHoras(Hora1 As String, Hora2 As String) As Int16
        Dim h1 As Date, h2 As Date
        Dim Valor As Int16 = 0

        h1 = String.Format(Hora1, "hh:mm:ss")
        h2 = String.Format(Hora2, "hh:mm:ss")

        'Si la H1 es igual a H2 valor es Cero =0
        'Si la H1 es mayor a H2 valor es Uno = 1
        'Si la H1 es menor a H2 valor es Menos =-1
        If h1 = h2 Then
            Valor = 0
        ElseIf h1 > h2 Then
            Valor = 1
        Else
            Valor = -1
        End If

        Return Valor
    End Function

    Shared Function ReadNullAsEmptyString(ByVal reader As IDataReader, ByVal fieldName As String) As String
        If IsDBNull(reader(fieldName)) Then
            Return String.Empty
        Else
            Return reader(fieldName).ToString.Trim
        End If
    End Function

    Public Function ReadNullAsEmptyDate(ByVal reader As IDataReader, ByVal fieldName As String) As Nullable(Of Date)
        If IsDBNull(reader(fieldName)) Then
            Return Nothing
        Else
            Return reader(fieldName).ToString.Trim
        End If
    End Function

    Shared Function Teclado(Optional sender As Object = Nothing, Optional e As KeyEventArgs = Nothing) As KeyEventArgs

        Select Case e.KeyCode
            Case Keys.Escape
                sender.Close()

            Case Keys.F1
                MessageBox.Show("Ayuda no esta disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Case Keys.F2
                sender.btnNuevo.PerformClick()

            Case Keys.Enter
                sender.btnEditar.PerformClick()

        End Select

        Return e
    End Function

    Shared Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function

    Shared Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

    Shared Function RellenarCerosIzquierda(Cadena As String, Longitud As Int32) As String

        'Se rellena ceros a la izquierda siempre que exista al menos un caracter
        If Cadena.Trim.Length > 0 Then
            Cadena = Cadena.PadLeft(Longitud, "0")
        End If

        Return Cadena

    End Function

    Shared Sub SoloNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Shared Function CampoObligatorio(objControl As Object, Optional ByVal Tipo As eValidaControl = eValidaControl.TextEdit) As Boolean
        Dim Result As Boolean = True

        'Se valida que la propiedad Text no este vacia
        If Tipo = eValidaControl.TextEdit Then
            If objControl.Text = "" Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
            If objControl.Text = "0.00" Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
            If objControl.Text = "0" Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
        End If

        If Tipo = eValidaControl.SpinEdit Then
            Dim Control As New SpinEdit

            Control = CType(objControl, SpinEdit)

            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
        End If

        If Tipo = eValidaControl.GridLoopUpEdit Then
            Dim Control As New GridLookUpEdit

            Control = CType(objControl, GridLookUpEdit)

            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
        End If

        If Tipo = eValidaControl.SearchLookUpEdit Then
            Dim Control As New SearchLookUpEdit

            Control = CType(objControl, SearchLookUpEdit)

            If Control.EditValue = 0 Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If
        End If
        If Tipo = eValidaControl.DateEdit Then
            Dim Control As New DateEdit
            Control = CType(objControl, DateEdit)

            If Control.EditValue Is Nothing Then
                objControl.ErrorIconAlignment = ErrorIconAlignment.MiddleRight
                objControl.ErrorText = "El campo es obligatorio"
                Result = False
            End If

        End If
        Return Result
    End Function

    Shared Function Relacion(sLetra As String, iFlag As Integer)

        Dim sEnc, sDes As String

        Dim sLet As Long

        sLetra = UCase(sLetra)

        sDes = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 Ñ.*,-·$&/()=?¿!#@ºª\"

        sEnc = "!·¿ª$%&/(,.-)=?º{Ç}*<;+[]^¡5\@>:#_¬|q•1njklmr0abcdefghpoz"



        If iFlag = 1 Then

            sLet = InStr(1, sDes, sLetra)

            If sLet = 0 Then

                Relacion = "´"

            Else

                Relacion = Mid(sEnc, sLet, 1)

            End If

        Else

            sLet = InStr(1, sEnc, sLetra)

            If sLet = 0 Then

                Relacion = "´"

            Else

                Relacion = Mid(sDes, sLet, 1)

            End If

        End If

    End Function

    Shared Function Encapsula(sPalabra As String)

        Dim nlen As String

        Dim sRet As String

        Dim i As Integer

        sRet = ""

        nlen = Len(Trim(sPalabra))

        For i = 1 To nlen

            sRet = sRet & Relacion(Mid(sPalabra, i, 1), 1)

        Next

        Encapsula = sRet

    End Function

    Shared Function Desencapsula(sPalabra As String)

        Dim nlen As String

        Dim sRet As String

        Dim i As Integer

        sRet = ""

        nlen = Len(Trim(sPalabra))

        For i = 1 To nlen

            sRet = sRet & Relacion(Mid(sPalabra, i, 1), 0)

        Next

        Desencapsula = sRet

    End Function

    Shared Function DivideNombresApellidos(nombrecompleto As String) As DataTable
        Dim dt As New DataTable
        With dt.Columns
            .Add("nombre")
            .Add("apellidopaterno")
            .Add("apellidomaterno")
        End With
        Dim nombre As String = ""
        Dim apellidopaterno As String = ""
        Dim apellidomaterno As String = ""
        Dim x As Integer
        x = 0
        Dim cont As Integer
        cont = Len(nombrecompleto)
        If cont > 0 Then
            Dim v As String = ""
            For i = 1 To cont
                v = Mid(nombrecompleto, i, 1)
                If v = "|" Then
                    x = x + 1
                    v = ""
                Else
                    If x = 0 Then
                        nombre = nombre + v
                    ElseIf x = 1 Then
                        apellidopaterno = apellidopaterno + v
                    Else
                        apellidomaterno = apellidomaterno + v
                    End If
                End If
            Next
        Else

        End If

        dt.Rows.Add(nombre, apellidopaterno, apellidomaterno)
        Return dt
    End Function
    Shared Function ConexionCentral(ByVal sServidor As String, ByVal sBD As String) As Boolean
        'CONEXION Central
        Dim cnTienda As New SqlConnection
        Dim lcn_tienda As Boolean

        Try
            cnTienda = New SqlConnection("Data Source=" + sServidor + ";Initial Catalog=" + sBD + ";user ID= desarrollo ;Password= sistemas;")
            cnTienda.Open()
            lcn_tienda = True
            cnTienda.Close()
        Catch ex As Exception
            lcn_tienda = False
        End Try

        Return lcn_tienda
    End Function
    Shared Function ValidarCaracteres(control As Control, ByVal patron As String, ByVal errorvalidador As ErrorProvider, ByVal msjvalidador As String) As Boolean
        Dim result As Boolean = True
        If control.Text.Length > 0 And Not ValidarCorreo(control.Text, patron) Then
            result = False
            errorvalidador.SetError(control, msjvalidador)
        End If
        Return result
    End Function

    Shared Function ValidarCorreo(ByVal correo As String, ByVal patron As String) As Boolean
        'Dim sreg As String = "^(?("")(""+?(?<!\\)"")|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"
        'Dim sreg As String = "[0-9]"
        Dim rgx As Regex = New Regex(patron)
        Dim rgxok As Match = rgx.Match(correo)
        Return rgxok.Success
    End Function
    Shared Function NullCardString(ByVal cadena As String) As String

        Return If(cadena Is Nothing, "", cadena)
    End Function
End Class

