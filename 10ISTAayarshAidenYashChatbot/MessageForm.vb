Imports System.Speech.Recognition
Imports System.Speech.Synthesis
Public Class MessageForm
    Dim WithEvents recogniser As SpeechRecognitionEngine
    Dim speaker As SpeechSynthesizer
    Dim wordOutput As String
    Public recentChatBotMessage As String
    Dim logic As New botLogic

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        recogniser = New SpeechRecognitionEngine(New System.Globalization.CultureInfo("en-US"))
        recogniser.SetInputToDefaultAudioDevice()
        speaker = New SpeechSynthesizer()
        speaker.SetOutputToDefaultAudioDevice()

        recogniser.LoadGrammar(New DictationGrammar("grammar:dictation"))

        Spacer.Size = New Drawing.Size(MessagePanel.Size.Width - MessagePanel.Margin.Size.Width, 0)
        Send_Chatbot_Message("Hi! How are you?")
    End Sub

    Private Sub recognized_completed() Handles recogniser.RecognizeCompleted
        Console.WriteLine("complete")
    End Sub

    Private Sub on_recognized(sender As Object, e As SpeechRecognizedEventArgs) Handles recogniser.SpeechRecognized
        Console.WriteLine(e.Result.Text)
        speaker.Speak(e.Result.Text)
        wordOutput = e.Result.Text
        InputBox.Text = e.Result.Text
    End Sub

    Private Sub STT_and_Enter_Click(sender As Object, e As EventArgs) Handles STT_and_Enter.Click
        If InputBox.Text = "" Then
            recogniser.RecognizeAsyncCancel()
            recogniser.RecognizeAsync()
        Else
            Send_Message()
        End If
    End Sub



    Private Sub Send_Chatbot_Message(Message As String)
        If Not Message.Contains("Sorry, I didn't get that") Then
            recentChatBotMessage = Message
        End If
        Dim botMsgLbl As Label

        For Each individualMessage As String In Message.Split(vbNewLine)
            botMsgLbl = New Label
            botMsgLbl.Parent = MessagePanel
            botMsgLbl.Text = individualMessage.Trim()
            botMsgLbl.AutoSize = True
            botMsgLbl.Dock = DockStyle.Left
            botMsgLbl.Margin = New Padding(3, 6, 3, 6)
            botMsgLbl.Padding = New Padding(3)
            botMsgLbl.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            botMsgLbl.MaximumSize = New Size(MessagePanel.Size.Width / 3 * 2, 0)
            botMsgLbl.BackColor = SystemColors.ControlLight
            botMsgLbl.ForeColor = SystemColors.ControlText
        Next


        If TTS_Enabled.Checked Then 'add mute checkbox
            speaker.SpeakAsyncCancelAll()
            speaker.SpeakAsync(Message)
        End If
        MessagePanel.ScrollControlIntoView(botMsgLbl)
    End Sub

    Private Sub Send_Message()
        Dim userMsgLbl As New Label

        userMsgLbl.Parent = MessagePanel
        userMsgLbl.Text = InputBox.Text.Trim
        userMsgLbl.AutoSize = True
        userMsgLbl.Dock = DockStyle.Right
        userMsgLbl.Margin = New Padding(3, 6, 3, 6)
        userMsgLbl.Padding = New Padding(3)
        userMsgLbl.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        userMsgLbl.MaximumSize = New Size(MessagePanel.Size.Width / 3 * 2, 0)
        userMsgLbl.BackColor = SystemColors.Highlight
        userMsgLbl.ForeColor = SystemColors.HighlightText

        MessagePanel.ScrollControlIntoView(userMsgLbl)
        Send_Chatbot_Message(logic.Chatbot_Respond(InputBox.Text.Trim.ToLower))
        InputBox.Text = ""
    End Sub

    Private Sub TTS_Enabled_CheckedChanged(sender As Object, e As EventArgs) Handles TTS_Enabled.CheckedChanged
        TTS_Enabled.BackgroundImage = If(TTS_Enabled.Checked, My.Resources.speaker, My.Resources.speaker_mute)
    End Sub

    Private Sub InputBox_TextChanged(sender As Object, e As EventArgs) Handles InputBox.TextChanged
        STT_and_Enter.BackgroundImage = If(InputBox.Text = "", My.Resources.record, My.Resources.send)
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Questions.Show()
    End Sub
End Class
