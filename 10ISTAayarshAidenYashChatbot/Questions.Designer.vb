<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Questions
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
        Me.QuestionsLabel = New System.Windows.Forms.Label()
        Me.QuestionPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.dom = New System.Windows.Forms.Label()
        Me.Spacer = New System.Windows.Forms.Label()
        Me.QuestionPanel.SuspendLayout()
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
        Me.QuestionsLabel.Size = New System.Drawing.Size(147, 44)
        Me.QuestionsLabel.TabIndex = 1
        Me.QuestionsLabel.Text = "Questions"
        '
        'QuestionPanel
        '
        Me.QuestionPanel.AutoScroll = True
        Me.QuestionPanel.BackColor = System.Drawing.SystemColors.Window
        Me.QuestionPanel.Controls.Add(Me.dom)
        Me.QuestionPanel.Controls.Add(Me.Spacer)
        Me.QuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QuestionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.QuestionPanel.Location = New System.Drawing.Point(15, 53)
        Me.QuestionPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuestionPanel.Name = "QuestionPanel"
        Me.QuestionPanel.Padding = New System.Windows.Forms.Padding(15, 15, 15, 40)
        Me.QuestionPanel.Size = New System.Drawing.Size(584, 316)
        Me.QuestionPanel.TabIndex = 2
        Me.QuestionPanel.WrapContents = False
        '
        'dom
        '
        Me.dom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dom.Location = New System.Drawing.Point(15, 15)
        Me.dom.Margin = New System.Windows.Forms.Padding(0)
        Me.dom.Name = "dom"
        Me.dom.Size = New System.Drawing.Size(100, 1)
        Me.dom.TabIndex = 4
        '
        'Spacer
        '
        Me.Spacer.Location = New System.Drawing.Point(15, 16)
        Me.Spacer.Margin = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.Spacer.Name = "Spacer"
        Me.Spacer.Size = New System.Drawing.Size(100, 23)
        Me.Spacer.TabIndex = 5
        Me.Spacer.Text = "Label1"
        '
        'Questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 384)
        Me.Controls.Add(Me.QuestionPanel)
        Me.Controls.Add(Me.QuestionsLabel)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Questions"
        Me.Padding = New System.Windows.Forms.Padding(15, 9, 15, 15)
        Me.Text = "Questions"
        Me.QuestionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuestionsLabel As Label
    Friend WithEvents QuestionPanel As FlowLayoutPanel
    Friend WithEvents dom As Label
    Friend WithEvents Spacer As Label
End Class
