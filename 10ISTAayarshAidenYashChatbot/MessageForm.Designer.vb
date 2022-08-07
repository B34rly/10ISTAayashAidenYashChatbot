<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MessageForm))
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.MessagePanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Spacer = New System.Windows.Forms.Label()
        Me.InputLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.BotNameTitle = New System.Windows.Forms.Label()
        Me.HeaderLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HelpButton = New System.Windows.Forms.Button()
        Me.STT_and_Enter = New System.Windows.Forms.Button()
        Me.MessagePanel.SuspendLayout()
        Me.InputLayout.SuspendLayout()
        Me.HeaderLayout.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputBox
        '
        Me.InputBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputBox.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBox.Location = New System.Drawing.Point(0, 12)
        Me.InputBox.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.InputBox.Multiline = True
        Me.InputBox.Name = "InputBox"
        Me.InputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InputBox.Size = New System.Drawing.Size(512, 88)
        Me.InputBox.TabIndex = 2
        '
        'MessagePanel
        '
        Me.MessagePanel.AutoScroll = True
        Me.MessagePanel.BackColor = System.Drawing.SystemColors.Window
        Me.MessagePanel.Controls.Add(Me.Spacer)
        Me.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MessagePanel.Location = New System.Drawing.Point(14, 80)
        Me.MessagePanel.Margin = New System.Windows.Forms.Padding(14, 15, 14, 15)
        Me.MessagePanel.Name = "MessagePanel"
        Me.MessagePanel.Padding = New System.Windows.Forms.Padding(14, 15, 14, 15)
        Me.MessagePanel.Size = New System.Drawing.Size(600, 634)
        Me.MessagePanel.TabIndex = 3
        Me.MessagePanel.WrapContents = False
        '
        'Spacer
        '
        Me.Spacer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Spacer.Location = New System.Drawing.Point(14, 15)
        Me.Spacer.Margin = New System.Windows.Forms.Padding(0)
        Me.Spacer.Name = "Spacer"
        Me.Spacer.Size = New System.Drawing.Size(566, 41)
        Me.Spacer.TabIndex = 2
        Me.Spacer.Text = "Label2"
        '
        'InputLayout
        '
        Me.InputLayout.ColumnCount = 2
        Me.InputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InputLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.InputLayout.Controls.Add(Me.STT_and_Enter, 1, 0)
        Me.InputLayout.Controls.Add(Me.InputBox, 0, 0)
        Me.InputLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InputLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.InputLayout.Location = New System.Drawing.Point(14, 714)
        Me.InputLayout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InputLayout.Name = "InputLayout"
        Me.InputLayout.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
        Me.InputLayout.RowCount = 1
        Me.InputLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.InputLayout.Size = New System.Drawing.Size(600, 112)
        Me.InputLayout.TabIndex = 4
        '
        'BotNameTitle
        '
        Me.BotNameTitle.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotNameTitle.Location = New System.Drawing.Point(65, 4)
        Me.BotNameTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BotNameTitle.Name = "BotNameTitle"
        Me.BotNameTitle.Size = New System.Drawing.Size(408, 61)
        Me.BotNameTitle.TabIndex = 0
        Me.BotNameTitle.Text = "Beribus"
        Me.BotNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HeaderLayout
        '
        Me.HeaderLayout.ColumnCount = 4
        Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.HeaderLayout.Controls.Add(Me.PictureBox1, 0, 0)
        Me.HeaderLayout.Controls.Add(Me.HelpButton, 2, 0)
        Me.HeaderLayout.Controls.Add(Me.BotNameTitle, 1, 0)
        Me.HeaderLayout.Controls.Add(Me.SettingsButton, 3, 0)
        Me.HeaderLayout.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderLayout.Location = New System.Drawing.Point(14, 11)
        Me.HeaderLayout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HeaderLayout.Name = "HeaderLayout"
        Me.HeaderLayout.RowCount = 1
        Me.HeaderLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.HeaderLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.HeaderLayout.Size = New System.Drawing.Size(600, 69)
        Me.HeaderLayout.TabIndex = 2
        '
        'SettingsButton
        '
        Me.SettingsButton.BackgroundImage = Global._10ISTAayarshAidenYashChatbot.My.Resources.Resources.settings
        Me.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingsButton.Location = New System.Drawing.Point(541, 3)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(56, 63)
        Me.SettingsButton.TabIndex = 4
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "New Message!"
        Me.NotifyIcon1.BalloonTipTitle = "Beribus Chatbot"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 61)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'HelpButton
        '
        Me.HelpButton.BackgroundImage = Global._10ISTAayarshAidenYashChatbot.My.Resources.Resources.help
        Me.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HelpButton.Location = New System.Drawing.Point(479, 3)
        Me.HelpButton.Name = "HelpButton"
        Me.HelpButton.Size = New System.Drawing.Size(55, 61)
        Me.HelpButton.TabIndex = 3
        Me.HelpButton.UseVisualStyleBackColor = True
        '
        'STT_and_Enter
        '
        Me.STT_and_Enter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.STT_and_Enter.AutoSize = True
        Me.STT_and_Enter.BackgroundImage = Global._10ISTAayarshAidenYashChatbot.My.Resources.Resources.record
        Me.STT_and_Enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.STT_and_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.STT_and_Enter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STT_and_Enter.Location = New System.Drawing.Point(515, 12)
        Me.STT_and_Enter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.STT_and_Enter.Name = "STT_and_Enter"
        Me.STT_and_Enter.Size = New System.Drawing.Size(82, 88)
        Me.STT_and_Enter.TabIndex = 1
        Me.STT_and_Enter.UseVisualStyleBackColor = True
        '
        'MessageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 841)
        Me.Controls.Add(Me.MessagePanel)
        Me.Controls.Add(Me.HeaderLayout)
        Me.Controls.Add(Me.InputLayout)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MessageForm"
        Me.Padding = New System.Windows.Forms.Padding(14, 11, 14, 15)
        Me.Text = "Beribus Chatbot"
        Me.MessagePanel.ResumeLayout(False)
        Me.InputLayout.ResumeLayout(False)
        Me.InputLayout.PerformLayout()
        Me.HeaderLayout.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents STT_and_Enter As Button
    Friend WithEvents InputBox As TextBox
    Friend WithEvents InputLayout As TableLayoutPanel
    Friend WithEvents Spacer As Label
    Private WithEvents MessagePanel As FlowLayoutPanel
    Friend WithEvents BotNameTitle As Label
    Friend WithEvents HelpButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HeaderLayout As TableLayoutPanel
    Friend WithEvents SettingsButton As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
