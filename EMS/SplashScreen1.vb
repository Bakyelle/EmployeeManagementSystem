Public NotInheritable Class SplashScreen1

    ' Declare Timer

    Private progressValue As Integer = 0

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Set application title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        ' Set version info
        Version.Text = System.String.Format("Version {0}.{1}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        ' Set copyright info
        Copyright.Text = My.Application.Info.Copyright

        ' Configure Timer
        Timer1.Interval = 100 ' 100 milliseconds per tick
        Timer1.Start()
    End Sub

    ' Timer Tick Event - Controls Progress Bar and Splash Duration
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If progressValue < 100 Then
            progressValue += 2 ' Increase progress
            ProgressBar1.Value = progressValue
        Else
            Timer1.Stop() ' Stop the Timer
            Me.Hide() ' Hide Splash Screen
            ScreenLogin.Show() ' Open Login Screen
        End If
    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainLayoutPanel.Paint
        ' No specific painting logic required
    End Sub

End Class
