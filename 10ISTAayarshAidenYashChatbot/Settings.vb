Public Class Settings
    Dim settings As New List(Of String)({"Bot_Text_to_Speech", "Music", "Send_Notifications", "Notification_Sound"})
    Dim eval As New List(Of Object)({"Aiden", 4, 4, 4, 5, 4, "Aiden's Sister", 3, 4, 4, 5, 5, "Yash", 5, 5, 5, 5, 5, "Yash's Brother", 4, 5, 6, 5, 4, "Aayarsh", 5, 4, 2, 1, 3, "Aayarsh's Sister", 5, 4, 3, 3, 3, "Peer", 5, 5, 5, 5, 5, "Junior", 4, 4, 4, 4, 4})
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

        For Each evalutian As Object In eval
            Dim evalLabel As New Label
            With evalLabel
                .Parent = EvaluationTable
                .Text = evalutian.ToString
                .Font = New Font("Segoe UI", 7, FontStyle.Regular)
                .Anchor = AnchorStyles.Right Or AnchorStyles.Left
                .Padding = New Padding(3)
            End With
        Next
        For Each RS As RowStyle In EvaluationTable.RowStyles
            RS.SizeType = SizeType.AutoSize
        Next
    End Sub
    Private Sub CheckboxValueChanged(sender As CheckBox, e As EventArgs)
        My.Settings.Item(sender.Name) = sender.Checked
        If sender.Name = "Music" Then
            If sender.Checked Then
                My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.BackgroundLoop)
            Else
                My.Computer.Audio.Stop()
            End If
        End If
        My.Settings.Save()
    End Sub
End Class