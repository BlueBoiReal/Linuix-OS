Public Class OSMain
    Dim WallpaperFile As String
    'Dim resourceManager As New Resources.ResourceManager(GetType(TraceSource))

    Private Sub OSMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Form1.Close()

    End Sub
    Private Sub OSMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ApplySettings()
        If My.Computer.FileSystem.FileExists("C:\Program Files\Mozilla Firefox\firefox.exe") Then
            Launcher_FlameFeline.Visible = True
        Else
            Launcher_FlameFeline.Visible = False

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Launcher_LinuixSettings.Click
        LinuixSettings.ShowDialog()
        If LinuixSettings.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.ApplySettings()
        End If
    End Sub
    Public Function ApplySettings()
        ' APPLY BackgroundColour 4U
        Launcher_LinuixSettings.BackColor = My.Settings.BackgroundColour
        DesktopClock.BackColor = My.Settings.BackgroundColour
        Button2.BackColor = My.Settings.BackgroundColour
        Launcher_VirusSheild.BackColor = My.Settings.BackgroundColour
        Launcher_Interwebs.BackColor = My.Settings.BackgroundColour
        Launcher_FlameFeline.BackColor = My.Settings.BackgroundColour
        ' APPLY Wallpepper 4U
        'old
        If My.Settings.Wallpaper = "metro" Then
            Me.BackgroundImage = My.Resources.metro
        ElseIf My.Settings.Wallpaper = "Sandstone" Then
            Me.BackgroundImage = My.Resources.Sandstone
        End If
        'NEWS
        'Me.BackgroundImage = CType(resourceManager.GetObject(My.Settings.Wallpaper.ToString()), Image)
        ' APPLY Background Image Size Mode 4U
        If My.Settings.BackgroundColourSizeMode = "None" Then
            Me.BackgroundImageLayout = ImageLayout.None
        ElseIf My.Settings.BackgroundColourSizeMode = "Tile" Then
            Me.BackgroundImageLayout = ImageLayout.Tile
        ElseIf My.Settings.BackgroundColourSizeMode = "Center" Then
            Me.BackgroundImageLayout = ImageLayout.Center
        ElseIf My.Settings.BackgroundColourSizeMode = "Stretch" Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
        ElseIf My.Settings.BackgroundColourSizeMode = "Zoom" Then
            Me.BackgroundImageLayout = ImageLayout.Zoom
        End If
        ' Apply ICON Text Size Colour Choice 4U
        If My.Settings.WhiteBGIconText Then
            Launcher_LinuixSettings.ForeColor = Color.White
            Launcher_Interwebs.ForeColor = Color.White
            Launcher_VirusSheild.ForeColor = Color.White
            DesktopClock.ForeColor = Color.White
            Launcher_FlameFeline.ForeColor = Color.White
        Else
            Launcher_LinuixSettings.ForeColor = Color.Black
            Launcher_Interwebs.ForeColor = Color.Black
            Launcher_VirusSheild.ForeColor = Color.Black
            Launcher_FlameFeline.ForeColor = Color.Black
            DesktopClock.ForeColor = Color.Black
        End If
    End Function

    Private Sub UpdateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateTime.Tick
        DesktopClock.Text = DateTime.Now
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Close()
        Application.Exit()

        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Launcher_VirusSheild.Click
        VirusSheild.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Launcher_Interwebs.Click
        interwebs.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("nah nah closed.", "warngin")
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Launcher_FlameFeline.Click
        Process.Start("C:\Program Files\Mozilla Firefox\firefox.exe")
    End Sub

    Private Sub Button3_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Process.Start("explorer.exe")
    End Sub
End Class