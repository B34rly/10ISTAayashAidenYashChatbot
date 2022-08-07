<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.SettingsTable = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'SettingsTable
        '
        Me.SettingsTable.AutoSize = True
        Me.SettingsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SettingsTable.ColumnCount = 2
        Me.SettingsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.SettingsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SettingsTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsTable.Location = New System.Drawing.Point(0, 0)
        Me.SettingsTable.Name = "SettingsTable"
        Me.SettingsTable.Padding = New System.Windows.Forms.Padding(12)
        Me.SettingsTable.RowCount = 1
        Me.SettingsTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SettingsTable.Size = New System.Drawing.Size(675, 24)
        Me.SettingsTable.TabIndex = 1
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 259)
        Me.Controls.Add(Me.SettingsTable)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents SettingsTable As TableLayoutPanel
End Class
