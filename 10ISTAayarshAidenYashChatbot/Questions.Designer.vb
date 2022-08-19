<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Questions
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
        Me.QuestionsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'QuestionsLabel
        '
        Me.QuestionsLabel.AutoSize = True
        Me.QuestionsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.QuestionsLabel.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.QuestionsLabel.Location = New System.Drawing.Point(15, 9)
        Me.QuestionsLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 15)
        Me.QuestionsLabel.Name = "QuestionsLabel"
        Me.QuestionsLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.QuestionsLabel.Size = New System.Drawing.Size(175, 51)
        Me.QuestionsLabel.TabIndex = 1
        Me.QuestionsLabel.Text = "Questions"
        '
        'Questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 516)
        Me.Controls.Add(Me.QuestionsLabel)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Questions"
        Me.Padding = New System.Windows.Forms.Padding(15, 9, 15, 15)
        Me.Text = "Questions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuestionsLabel As Label
End Class
