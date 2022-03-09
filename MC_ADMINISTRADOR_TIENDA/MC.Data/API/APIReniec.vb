Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Public Class APIReniec
    Public Function ValidateReniec(ByVal ndoc As String) As ResponseReniec
        Dim result As New ResponseReniec()
        Dim dt As New DataTable()
        Dim url As String = "http://api.apis.net.pe/v1/dni?numero=" + ndoc
        Dim json = New WebClient().DownloadString(url)
        result = JsonConvert.DeserializeObject(Of ResponseReniec)(json)
        Return result
    End Function
End Class
