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
        Me.CurrentQuestionLbl = New System.Windows.Forms.Label()
        Me.QuestionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuestionsLabel
        '
        Me.QuestionsLabel.AutoSize = True
        Me.QuestionsLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.QuestionsLabel.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold)
        Me.QuestionsLabel.Location = New System.Drawing.Point(13, 7)
        Me.QuestionsLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 12)
        Me.QuestionsLabel.Name = "QuestionsLabel"
        Me.QuestionsLabel.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.QuestionsLabel.Size = New System.Drawing.Size(175, 50)
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
        Me.QuestionPanel.Location = New System.Drawing.Point(13, 87)
        Me.QuestionPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuestionPanel.Name = "QuestionPanel"
        Me.QuestionPanel.Padding = New System.Windows.Forms.Padding(13, 12, 13, 32)
        Me.QuestionPanel.Size = New System.Drawing.Size(520, 208)
        Me.QuestionPanel.TabIndex = 3
        Me.QuestionPanel.WrapContents = False
        '
        'dom
        '
        Me.dom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dom.Location = New System.Drawing.Point(13, 12)
        Me.dom.Margin = New System.Windows.Forms.Padding(0)
        Me.dom.Name = "dom"
        Me.dom.Size = New System.Drawing.Size(89, 1)
        Me.dom.TabIndex = 4
        '
        'Spacer
        '
        Me.Spacer.Location = New System.Drawing.Point(13, 13)
        Me.Spacer.Margin = New System.Windows.Forms.Padding(0)
        Me.Spacer.Name = "Spacer"
        Me.Spacer.Size = New System.Drawing.Size(89, 18)
        Me.Spacer.TabIndex = 5
        Me.Spacer.Text = "Label1"
        '
        'CurrentQuestionLbl
        '
        Me.CurrentQuestionLbl.AutoSize = True
        Me.CurrentQuestionLbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.CurrentQuestionLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentQuestionLbl.Location = New System.Drawing.Point(13, 57)
        Me.CurrentQuestionLbl.Name = "CurrentQuestionLbl"
        Me.CurrentQuestionLbl.Size = New System.Drawing.Size(426, 30)
        Me.CurrentQuestionLbl.TabIndex = 1
        Me.CurrentQuestionLbl.Text = "Chatbot is currently awaiting a response to:"
        '
        'Questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 307)
        Me.Controls.Add(Me.QuestionPanel)
        Me.Controls.Add(Me.CurrentQuestionLbl)
        Me.Controls.Add(Me.QuestionsLabel)
        Me.Name = "Questions"
        Me.Padding = New System.Windows.Forms.Padding(13, 7, 13, 12)
        Me.Text = "Questions"
        Me.QuestionPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuestionsLabel As Label
    Friend WithEvents QuestionPanel As FlowLayoutPanel
    Friend WithEvents dom As Label
    Friend WithEvents Spacer As Label
    Friend WithEvents CurrentQuestionLbl As Label
End Class
