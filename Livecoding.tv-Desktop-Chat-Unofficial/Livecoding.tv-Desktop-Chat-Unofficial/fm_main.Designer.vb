<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_main))
        Me.tabcontrl_browser_wrap = New System.Windows.Forms.TabControl()
        Me.SuspendLayout()
        '
        'tabcontrl_browser_wrap
        '
        Me.tabcontrl_browser_wrap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrl_browser_wrap.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrl_browser_wrap.Name = "tabcontrl_browser_wrap"
        Me.tabcontrl_browser_wrap.SelectedIndex = 0
        Me.tabcontrl_browser_wrap.Size = New System.Drawing.Size(523, 515)
        Me.tabcontrl_browser_wrap.TabIndex = 0
        '
        'fm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 515)
        Me.Controls.Add(Me.tabcontrl_browser_wrap)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Livecoding.tv Chat"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabcontrl_browser_wrap As TabControl
End Class
