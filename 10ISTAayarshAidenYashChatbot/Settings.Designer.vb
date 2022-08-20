<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SettingsTable = New System.Windows.Forms.TableLayoutPanel()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SettingsTable
        '
        Me.SettingsTable.AutoSize = True
        Me.SettingsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SettingsTable.BackColor = System.Drawing.SystemColors.Window
        Me.SettingsTable.ColumnCount = 2
        Me.SettingsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.SettingsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.SettingsTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsTable.Location = New System.Drawing.Point(15, 53)
        Me.SettingsTable.Margin = New System.Windows.Forms.Padding(3, 15, 3, 3)
        Me.SettingsTable.Name = "SettingsTable"
        Me.SettingsTable.Padding = New System.Windows.Forms.Padding(12)
        Me.SettingsTable.RowCount = 1
        Me.SettingsTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SettingsTable.Size = New System.Drawing.Size(645, 24)
        Me.SettingsTable.TabIndex = 3
        '
        'SettingsLabel
        '
        Me.SettingsLabel.AutoSize = True
        Me.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsLabel.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.SettingsLabel.Location = New System.Drawing.Point(15, 9)
        Me.SettingsLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 15)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.SettingsLabel.Size = New System.Drawing.Size(124, 44)
        Me.SettingsLabel.TabIndex = 0
        Me.SettingsLabel.Text = "Settings"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(675, 259)
        Me.Controls.Add(Me.SettingsTable)
        Me.Controls.Add(Me.SettingsLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Settings"
        Me.Padding = New System.Windows.Forms.Padding(15, 9, 15, 15)
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents SettingsTable As TableLayoutPanel
    Friend WithEvents SettingsLabel As Label
End Class
