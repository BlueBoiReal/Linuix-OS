Imports System.Windows.Forms

Public Class interwebs

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.Refresh()
    End Sub



    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button1.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Try
            TextBox1.Text = WebBrowser1.Url.ToString
            Me.Text = WebBrowser1.DocumentTitle + " - Interwebs Looker"
        Catch ex As Exception
            TextBox1.Text = "Type a URL here!"
            Me.Text = "Interwebs Looker"
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.GoForward()
    End Sub
End Class
' thank you