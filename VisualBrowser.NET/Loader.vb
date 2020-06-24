Public Class Loader
    Private Sub Loader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TasksText.Text = "Setting IE version in registry..."
        TasksText.Location = New Point(69, 158)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", Process.GetCurrentProcess.ProcessName + ".exe", My.Settings.IEVersion)
        TasksText.Text = "Loading UI..."
        TasksText.Location = New Point(108, 158)
        VisualBrowserNET.Show()
        TasksText.Text = "Closing Loader..."
        TasksText.Location = New Point(101, 158)
        Me.Close()
    End Sub
End Class