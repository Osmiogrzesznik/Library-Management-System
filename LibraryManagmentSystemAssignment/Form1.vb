
Imports System.Net


Public Class Form1
    Public Sub Say(msg)
        RichTextBox1.AppendText(vbNewLine & msg)
    End Sub

    Private Sub getbookinfofromamazon()
        Dim sURL = "https://support.microsoft.com/en-us/help/301102/how-to-make-a-get-request-by-using-visual-basic-net-or-visual-basic-20"

        Dim webClient As New WebClient
        Dim result As String = webClient.DownloadString(sURL)

        RichTextBox1.AppendText(result)
    End Sub




End Class
