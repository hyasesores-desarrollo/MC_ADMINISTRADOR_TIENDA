Imports MC.Framework

Public Class ClienteFacturadoEdit

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = False

        'Se inicializa el control ribbon
        ControlesDevExpress.InitRibbonControl(RibbonControl)
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnGuardar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G, "Ctrl + G")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnNuevo, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N, "Ctrl + N")
        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCancelar, System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C, "Ctrl + C")

        ControlesDevExpress.InitRibbonControlBarButttonShortCut(btnCerrar, System.Windows.Forms.Keys.Escape, "Esc")

        LimpiarControles()
        HabilitarBotones(True)

        AddHandler btnGuardar.ItemClick, AddressOf Guardar
        AddHandler btnCancelar.ItemClick, AddressOf Cancelar

        AddHandler btnNuevo.ItemClick, AddressOf Nuevo
        AddHandler btnCerrar.ItemClick, AddressOf cerrar

    End Sub

    Public Sub Nuevo()
        LimpiarControles()
        HabilitarBotones(False)
        txtDescripcion.Focus()
    End Sub

    Public Sub Cancelar()
        LimpiarControles()
        HabilitarBotones(True)

    End Sub

    Private Function Validar() As Boolean
        Dim Result As Boolean = False

        If Tools.CampoObligatorio(txtDescripcion, eValidaControl.TextEdit) Then
            If Tools.CampoObligatorio(txtIdentidad, eValidaControl.TextEdit) Then
                If Tools.CampoObligatorio(txtDireccion, eValidaControl.TextEdit) Then
                    If txtIdentidad.Text.Length = 8 Then
                        Result = True
                    Else
                        MessageBox.Show("Identidad debe ser 8 Digitos")
                        txtIdentidad.Focus()
                    End If
                End If

            End If
        End If

        If txtEmail.Text.Length > 0 Then
            If txtEmail.Text.Contains("@") Then
                If Not txtEmail.Text.Contains(" ") Then
                    If txtEmail.Text.ToUpper.Contains(".COM") Then

                        Result = True
                    Else
                        Result = False
                        MessageBox.Show("Validar Formato de Correo Electrónico")
                        txtEmail.Focus()
                    End If

                Else
                    Result = False
                    MessageBox.Show("Validar Formato de Correo Electrónico")
                    txtEmail.Focus()
                End If
            Else
                Result = False
                MessageBox.Show("Validar Formato de Correo Electrónico")
                txtEmail.Focus()
            End If
        End If

        If Result = False Then
            MessageBox.Show("El registro de datos no cumple con las reglas.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Return Result
    End Function

    Public Sub Guardar()
        If Validar() = True Then
            clienteFacturadoDAO.SaveClienteFacturado(txtDescripcion.Text, txtIdentidad.Text, txtDireccion.Text, txtEmail.Text)
            MessageBox.Show("Cliente Registrado")
            Cancelar()
        End If

    End Sub

    Public Sub cerrar()
        Me.Close()
    End Sub

    Public Sub LimpiarControles()
        Me.txtDescripcion.Text = ""
        Me.txtDireccion.Text = ""
        Me.txtEmail.Text = ""
        Me.txtIdentidad.Text = ""
    End Sub

    Public Sub HabilitarBotones(ByVal estado As Boolean)
        btnNuevo.Enabled = estado
        btnGuardar.Enabled = Not estado
        btnCancelar.Enabled = Not estado
        btnCerrar.Enabled = estado
        Me.Group.Enabled = Not estado
    End Sub

    Private Sub txtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        If Asc(e.KeyChar) = 13 Then
            txtDireccion.Focus()
        End If
    End Sub


    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        Dim Presionado As String
        Presionado = Chr(Asc(e.KeyChar))



        If Asc(e.KeyChar) = 13 Then
            txtIdentidad.Focus()
        End If
        If Presionado = "," Or Presionado = "'" Or Presionado = ";" Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        Dim Presionado As String
        Presionado = Chr(Asc(e.KeyChar))



        If Asc(e.KeyChar) = 13 Then
            txtEmail.Focus()
        End If
        If Presionado = "," Or Presionado = "'" Or Presionado = ";" Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        Dim Presionado As String
        Presionado = Chr(Asc(e.KeyChar))
        Dim SearchString As String = ",;/#='?¡¿^\$%&()"
        Dim pos As Int32
        If Asc(e.KeyChar) = 13 Then
            Guardar()
        End If
        pos = InStr(SearchString, Presionado)
        If pos <> 0 Then
            e.Handled = True
        End If
    End Sub


End Class