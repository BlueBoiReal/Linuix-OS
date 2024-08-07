

Public Class Form1
    Dim loadprogrss As Integer = 0

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not loadprogrss = 100 Then
            loadprogrss += 1
            ProgressBar1.Value = loadprogrss
        Else
            Timer1.Enabled = False
            Me.Hide()
            OSMain.Show()
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Process.Start(WindowsApplication1.My.Resources.launchwindow)

    End Sub
    ' oagk etp[nmjg wtnj a bpxg g-p[ve
    ' imagine typing with a boxing glove

    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.bootnew, AudioPlayMode.Background)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Process.Start("taskkill", "/f /im explorer.exe")

    End Sub
End Class
