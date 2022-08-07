Public Class Settings
    Dim settings As New List(Of String)({"Bot_Text_to_Speech", "Music_Mute", "Notification_Mute"})
    Dim checkboxes As New List(Of CheckBox)
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each setting In settings
            Dim SettingLabel As New Label
            SettingLabel.Parent = SettingsTable
            SettingLabel.Anchor = AnchorStyles.Left
            SettingLabel.Text = setting.Replace("_", " ")
            SettingLabel.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            SettingLabel.AutoSize = True

            Dim SettingCheckbox As New CheckBox
            SettingCheckbox.Parent = SettingsTable
            SettingCheckbox.Anchor = AnchorStyles.Right
            SettingCheckbox.Checked = My.Settings.Item(setting)
            SettingCheckbox.Text = ""
            SettingCheckbox.Name = setting
            AddHandler SettingCheckbox.CheckedChanged, AddressOf Me.CheckboxValueChanged
            checkboxes.Add(SettingCheckbox)
        Next
        For Each RS As RowStyle In SettingsTable.RowStyles
            RS.SizeType = SizeType.AutoSize
        Next

    End Sub
    Private Sub CheckboxValueChanged(sender As CheckBox, e As EventArgs)
        My.Settings.Item(sender.Name) = sender.Checked
        If sender.Name = "Music_Mute" Then
            If sender.Checked Then
                My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.BackgroundLoop)
            Else
                My.Computer.Audio.Stop()
            End If
        End If
        My.Settings.Save()

    End Sub
End Class