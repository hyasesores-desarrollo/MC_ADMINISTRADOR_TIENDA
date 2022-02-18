Imports MC.Framework

Public Class SubMain
    <STAThread()> _
    Shared Sub Main()
        Try

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)

            lCentral = Tools.ReadAppSettings("TipoConexion")

            If lCentral = "C" Then
                Application.Run(New LocalesList)
            Else
                Application.Run(New Login)
            End If

        Catch ex As Exception
            Application.Run(New Login)
        End Try

    End Sub
End Class
