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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.SettingsTable = New System.Windows.Forms.TableLayoutPanel()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.EvalutionLabel = New System.Windows.Forms.Label()
        Me.EvaluationTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EvaluationTable.SuspendLayout()
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
        Me.SettingsTable.Location = New System.Drawing.Point(13, 57)
        Me.SettingsTable.Margin = New System.Windows.Forms.Padding(3, 12, 3, 2)
        Me.SettingsTable.Name = "SettingsTable"
        Me.SettingsTable.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.SettingsTable.RowCount = 1
        Me.SettingsTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.SettingsTable.Size = New System.Drawing.Size(671, 20)
        Me.SettingsTable.TabIndex = 3
        '
        'SettingsLabel
        '
        Me.SettingsLabel.AutoSize = True
        Me.SettingsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsLabel.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.SettingsLabel.Location = New System.Drawing.Point(13, 7)
        Me.SettingsLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 12)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.SettingsLabel.Size = New System.Drawing.Size(147, 50)
        Me.SettingsLabel.TabIndex = 0
        Me.SettingsLabel.Text = "Settings"
        '
        'EvalutionLabel
        '
        Me.EvalutionLabel.AutoSize = True
        Me.EvalutionLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.EvalutionLabel.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.EvalutionLabel.Location = New System.Drawing.Point(13, 77)
        Me.EvalutionLabel.Margin = New System.Windows.Forms.Padding(3, 12, 3, 12)
        Me.EvalutionLabel.Name = "EvalutionLabel"
        Me.EvalutionLabel.Padding = New System.Windows.Forms.Padding(0, 6, 0, 5)
        Me.EvalutionLabel.Size = New System.Drawing.Size(180, 56)
        Me.EvalutionLabel.TabIndex = 4
        Me.EvalutionLabel.Text = "Evalutions"
        '
        'EvaluationTable
        '
        Me.EvaluationTable.AutoSize = True
        Me.EvaluationTable.BackColor = System.Drawing.SystemColors.Window
        Me.EvaluationTable.ColumnCount = 6
        Me.EvaluationTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.6988!))
        Me.EvaluationTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.06024!))
        Me.EvaluationTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.06024!))
        Me.EvaluationTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.06024!))
        Me.EvaluationTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.06024!))
        Me.EvaluationTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.06024!))
        Me.EvaluationTable.Controls.Add(Me.Label4, 4, 0)
        Me.EvaluationTable.Controls.Add(Me.Label1, 1, 0)
        Me.EvaluationTable.Controls.Add(Me.Label2, 2, 0)
        Me.EvaluationTable.Controls.Add(Me.Label3, 3, 0)
        Me.EvaluationTable.Controls.Add(Me.Label6, 0, 0)
        Me.EvaluationTable.Controls.Add(Me.Label5, 5, 0)
        Me.EvaluationTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.EvaluationTable.Location = New System.Drawing.Point(13, 133)
        Me.EvaluationTable.Name = "EvaluationTable"
        Me.EvaluationTable.RowCount = 1
        Me.EvaluationTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.EvaluationTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174.0!))
        Me.EvaluationTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174.0!))
        Me.EvaluationTable.Size = New System.Drawing.Size(671, 174)
        Me.EvaluationTable.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(168, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 168)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How would you rate the overall experience out of 5?"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(269, 3)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 168)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "How much did you learn from this chatbot?"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 168)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "How would you rate the overall look of the chatbot application?"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(471, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 168)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "How much did you enjoy the jokes from the chatbot?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Evaluee"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(572, 3)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 168)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "How would you rate the chatbot’s ability to respond to your messages?"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(697, 496)
        Me.Controls.Add(Me.EvaluationTable)
        Me.Controls.Add(Me.EvalutionLabel)
        Me.Controls.Add(Me.SettingsTable)
        Me.Controls.Add(Me.SettingsLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Settings"
        Me.Padding = New System.Windows.Forms.Padding(13, 7, 13, 16)
        Me.Text = "Settings"
        Me.EvaluationTable.ResumeLayout(False)
        Me.EvaluationTable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents SettingsTable As TableLayoutPanel
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents EvalutionLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents EvaluationTable As TableLayoutPanel
End Class
