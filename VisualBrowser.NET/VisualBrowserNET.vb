Public Class VisualBrowserNET
    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        VisualView.GoBack()
    End Sub

    Private Sub VisualBrowserNET_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisualView.Navigate(My.Settings.Homepage)
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        VisualView.GoForward()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        VisualView.Refresh()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        VisualView.Navigate(My.Settings.Homepage)
    End Sub

    Private Sub GoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToolStripMenuItem.Click
        VisualView.Navigate(URLTextBox.Text)
    End Sub

    Private Sub DarkModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkModeToolStripMenuItem.Click
        WebStrip.BackColor = SystemColors.ControlDark
        ActionStrip.BackColor = SystemColors.ControlDark
        URLTextBox.BackColor = SystemColors.WindowFrame
    End Sub

    Private Sub VisualView_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles VisualView.DocumentCompleted
        Me.Text = VisualView.DocumentTitle + " - VisualBrowser.NET"
        URLTextBox.Text = VisualView.Url.ToString
    End Sub

    Private Sub VisualView_NewWindow(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VisualView.NewWindow
        Dim NewWindow As New VisualBrowserNET
        NewWindow.Show()
    End Sub

    Private Sub IE11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IE11ToolStripMenuItem.Click
        My.Settings.IEVersion = 11001
        My.Settings.Save()
        Loader.Show()
    End Sub

    Private Sub IE10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IE10ToolStripMenuItem.Click
        My.Settings.IEVersion = 10001
        My.Settings.Save()
        Loader.Show()
    End Sub

    Private Sub IE9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IE9ToolStripMenuItem.Click
        My.Settings.IEVersion = 9999
        My.Settings.Save()
        Loader.Show()
    End Sub

    Private Sub IE8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IE8ToolStripMenuItem.Click
        My.Settings.IEVersion = 8888
        My.Settings.Save()
        Loader.Show()
    End Sub

    Private Sub IE7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IE7ToolStripMenuItem.Click
        My.Settings.IEVersion = 7000
        My.Settings.Save()
        Loader.Show()
    End Sub
End Class