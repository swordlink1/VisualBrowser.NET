<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loader
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
        Me.BigLoadingText = New System.Windows.Forms.Label()
        Me.PleaseWait = New System.Windows.Forms.Label()
        Me.TasksText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BigLoadingText
        '
        Me.BigLoadingText.AutoSize = True
        Me.BigLoadingText.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BigLoadingText.Location = New System.Drawing.Point(25, 103)
        Me.BigLoadingText.Name = "BigLoadingText"
        Me.BigLoadingText.Size = New System.Drawing.Size(235, 55)
        Me.BigLoadingText.TabIndex = 0
        Me.BigLoadingText.Text = "Loading..."
        '
        'PleaseWait
        '
        Me.PleaseWait.AutoSize = True
        Me.PleaseWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PleaseWait.Location = New System.Drawing.Point(5, 237)
        Me.PleaseWait.Name = "PleaseWait"
        Me.PleaseWait.Size = New System.Drawing.Size(275, 15)
        Me.PleaseWait.TabIndex = 1
        Me.PleaseWait.Text = "Please wait while VisualBrowser.NET is loading..."
        '
        'TasksText
        '
        Me.TasksText.AutoSize = True
        Me.TasksText.Location = New System.Drawing.Point(107, 158)
        Me.TasksText.Name = "TasksText"
        Me.TasksText.Size = New System.Drawing.Size(70, 13)
        Me.TasksText.TabIndex = 2
        Me.TasksText.Text = "Please wait..."
        '
        'Loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TasksText)
        Me.Controls.Add(Me.PleaseWait)
        Me.Controls.Add(Me.BigLoadingText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Loader"
        Me.Text = "VisualBrowser.NET"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BigLoadingText As System.Windows.Forms.Label
    Friend WithEvents PleaseWait As System.Windows.Forms.Label
    Friend WithEvents TasksText As System.Windows.Forms.Label
End Class
