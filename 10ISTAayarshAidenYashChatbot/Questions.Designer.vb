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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
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
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 60)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(15, 15, 30, 15)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(584, 309)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(478, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Questioblah blah blah blah blha blhab lhab lhab haoeuns Here"
        '
        'Questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 384)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.QuestionsLabel)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Questions"
        Me.Padding = New System.Windows.Forms.Padding(15, 9, 15, 15)
        Me.Text = "Questions"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuestionsLabel As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
End Class
