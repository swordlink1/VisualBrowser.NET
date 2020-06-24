<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualBrowserNET
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualBrowserNET))
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebStrip = New System.Windows.Forms.MenuStrip()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.URLTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualView = New System.Windows.Forms.WebBrowser()
        Me.ActionStrip = New System.Windows.Forms.StatusStrip()
        Me.ThemesDropdown = New System.Windows.Forms.ToolStripDropDownButton()
        Me.LightModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrowserDropdown = New System.Windows.Forms.ToolStripDropDownButton()
        Me.IEVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IE11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IE10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IE9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IE8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IE7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebStrip.SuspendLayout()
        Me.ActionStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'WebStrip
        '
        Me.WebStrip.BackColor = System.Drawing.SystemColors.Control
        Me.WebStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem, Me.NextToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.HomeToolStripMenuItem, Me.URLTextBox, Me.GoToolStripMenuItem})
        Me.WebStrip.Location = New System.Drawing.Point(0, 0)
        Me.WebStrip.Name = "WebStrip"
        Me.WebStrip.Size = New System.Drawing.Size(496, 27)
        Me.WebStrip.TabIndex = 1
        Me.WebStrip.Text = "MenuStrip1"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(43, 23)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(58, 23)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'URLTextBox
        '
        Me.URLTextBox.Name = "URLTextBox"
        Me.URLTextBox.Size = New System.Drawing.Size(256, 23)
        '
        'GoToolStripMenuItem
        '
        Me.GoToolStripMenuItem.Name = "GoToolStripMenuItem"
        Me.GoToolStripMenuItem.Size = New System.Drawing.Size(34, 23)
        Me.GoToolStripMenuItem.Text = "Go"
        '
        'VisualView
        '
        Me.VisualView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisualView.Location = New System.Drawing.Point(0, 27)
        Me.VisualView.MinimumSize = New System.Drawing.Size(20, 20)
        Me.VisualView.Name = "VisualView"
        Me.VisualView.ScriptErrorsSuppressed = True
        Me.VisualView.Size = New System.Drawing.Size(496, 318)
        Me.VisualView.TabIndex = 2
        '
        'ActionStrip
        '
        Me.ActionStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemesDropdown, Me.BrowserDropdown})
        Me.ActionStrip.Location = New System.Drawing.Point(0, 323)
        Me.ActionStrip.Name = "ActionStrip"
        Me.ActionStrip.Size = New System.Drawing.Size(496, 22)
        Me.ActionStrip.TabIndex = 3
        Me.ActionStrip.Text = "StatusStrip1"
        '
        'ThemesDropdown
        '
        Me.ThemesDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ThemesDropdown.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LightModeToolStripMenuItem, Me.DarkModeToolStripMenuItem})
        Me.ThemesDropdown.Image = CType(resources.GetObject("ThemesDropdown.Image"), System.Drawing.Image)
        Me.ThemesDropdown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ThemesDropdown.Name = "ThemesDropdown"
        Me.ThemesDropdown.Size = New System.Drawing.Size(57, 20)
        Me.ThemesDropdown.Text = "Theme"
        '
        'LightModeToolStripMenuItem
        '
        Me.LightModeToolStripMenuItem.Name = "LightModeToolStripMenuItem"
        Me.LightModeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LightModeToolStripMenuItem.Text = "Light Mode"
        '
        'DarkModeToolStripMenuItem
        '
        Me.DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        Me.DarkModeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DarkModeToolStripMenuItem.Text = "Dark Mode"
        '
        'BrowserDropdown
        '
        Me.BrowserDropdown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BrowserDropdown.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IEVersionToolStripMenuItem})
        Me.BrowserDropdown.Image = CType(resources.GetObject("BrowserDropdown.Image"), System.Drawing.Image)
        Me.BrowserDropdown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BrowserDropdown.Name = "BrowserDropdown"
        Me.BrowserDropdown.Size = New System.Drawing.Size(62, 20)
        Me.BrowserDropdown.Text = "Browser"
        '
        'IEVersionToolStripMenuItem
        '
        Me.IEVersionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IE11ToolStripMenuItem, Me.IE10ToolStripMenuItem, Me.IE9ToolStripMenuItem, Me.IE8ToolStripMenuItem, Me.IE7ToolStripMenuItem})
        Me.IEVersionToolStripMenuItem.Name = "IEVersionToolStripMenuItem"
        Me.IEVersionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IEVersionToolStripMenuItem.Text = "IE Version"
        '
        'IE11ToolStripMenuItem
        '
        Me.IE11ToolStripMenuItem.Name = "IE11ToolStripMenuItem"
        Me.IE11ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IE11ToolStripMenuItem.Text = "IE 11"
        '
        'IE10ToolStripMenuItem
        '
        Me.IE10ToolStripMenuItem.Name = "IE10ToolStripMenuItem"
        Me.IE10ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IE10ToolStripMenuItem.Text = "IE 10"
        '
        'IE9ToolStripMenuItem
        '
        Me.IE9ToolStripMenuItem.Name = "IE9ToolStripMenuItem"
        Me.IE9ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IE9ToolStripMenuItem.Text = "IE 9"
        '
        'IE8ToolStripMenuItem
        '
        Me.IE8ToolStripMenuItem.Name = "IE8ToolStripMenuItem"
        Me.IE8ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IE8ToolStripMenuItem.Text = "IE 8"
        '
        'IE7ToolStripMenuItem
        '
        Me.IE7ToolStripMenuItem.Name = "IE7ToolStripMenuItem"
        Me.IE7ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IE7ToolStripMenuItem.Text = "IE 7"
        '
        'VisualBrowserNET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(496, 345)
        Me.Controls.Add(Me.ActionStrip)
        Me.Controls.Add(Me.VisualView)
        Me.Controls.Add(Me.WebStrip)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MainMenuStrip = Me.WebStrip
        Me.MinimumSize = New System.Drawing.Size(512, 384)
        Me.Name = "VisualBrowserNET"
        Me.Text = "VisualBrowser.NET"
        Me.WebStrip.ResumeLayout(False)
        Me.WebStrip.PerformLayout()
        Me.ActionStrip.ResumeLayout(False)
        Me.ActionStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents VisualView As System.Windows.Forms.WebBrowser
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents URLTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThemesDropdown As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LightModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrowserDropdown As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents IEVersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IE11ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IE10ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IE9ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IE8ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IE7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
