﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MessageForm
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
        Me.STT_and_Enter = New System.Windows.Forms.Button()
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.MessagePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Spacer = New System.Windows.Forms.Label()
        Me.InputLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.MessagePanel.SuspendLayout()
        Me.InputLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'STT_and_Enter
        '
        Me.STT_and_Enter.AutoSize = True
        Me.STT_and_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.STT_and_Enter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STT_and_Enter.Location = New System.Drawing.Point(454, 9)
        Me.STT_and_Enter.Name = "STT_and_Enter"
        Me.STT_and_Enter.Size = New System.Drawing.Size(77, 72)
        Me.STT_and_Enter.TabIndex = 1
        Me.STT_and_Enter.Text = "Button1"
        Me.STT_and_Enter.UseVisualStyleBackColor = True
        '
        'InputBox
        '
        Me.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBox.Location = New System.Drawing.Point(0, 9)
        Me.InputBox.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.InputBox.Multiline = True
        Me.InputBox.Name = "InputBox"
        Me.InputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InputBox.Size = New System.Drawing.Size(440, 72)
        Me.InputBox.TabIndex = 2
        '
        'MessagePanel
        '
        Me.MessagePanel.AutoScroll = True
        Me.MessagePanel.BackColor = System.Drawing.SystemColors.Window
        Me.MessagePanel.Controls.Add(Me.Spacer)
        Me.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MessagePanel.Location = New System.Drawing.Point(12, 12)
        Me.MessagePanel.Margin = New System.Windows.Forms.Padding(12)
        Me.MessagePanel.Name = "MessagePanel"
        Me.MessagePanel.Padding = New System.Windows.Forms.Padding(12)
        Me.MessagePanel.Size = New System.Drawing.Size(534, 649)
        Me.MessagePanel.TabIndex = 3
        Me.MessagePanel.WrapContents = False
        '
        'Spacer
        '
        Me.Spacer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Spacer.Location = New System.Drawing.Point(12, 12)
        Me.Spacer.Margin = New System.Windows.Forms.Padding(0)
        Me.Spacer.Name = "Spacer"
        Me.Spacer.Size = New System.Drawing.Size(503, 33)
        Me.Spacer.TabIndex = 2
        Me.Spacer.Text = "Label2"
        '
        'InputLayout
        '
        Me.InputLayout.ColumnCount = 2
        Me.InputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.4697!))
        Me.InputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.5303!))
        Me.InputLayout.Controls.Add(Me.STT_and_Enter, 1, 0)
        Me.InputLayout.Controls.Add(Me.InputBox, 0, 0)
        Me.InputLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InputLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.InputLayout.Location = New System.Drawing.Point(12, 571)
        Me.InputLayout.Name = "InputLayout"
        Me.InputLayout.Padding = New System.Windows.Forms.Padding(0, 6, 0, 6)
        Me.InputLayout.RowCount = 1
        Me.InputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.InputLayout.Size = New System.Drawing.Size(534, 90)
        Me.InputLayout.TabIndex = 4
        '
        'MessageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 673)
        Me.Controls.Add(Me.InputLayout)
        Me.Controls.Add(Me.MessagePanel)
        Me.Name = "MessageForm"
        Me.Padding = New System.Windows.Forms.Padding(12)
        Me.Text = "Beribus Chatbot"
        Me.MessagePanel.ResumeLayout(False)
        Me.InputLayout.ResumeLayout(False)
        Me.InputLayout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents STT_and_Enter As Button
    Friend WithEvents InputBox As TextBox
    Friend WithEvents InputLayout As TableLayoutPanel
    Friend WithEvents Spacer As Label
    Private WithEvents MessagePanel As FlowLayoutPanel
End Class
