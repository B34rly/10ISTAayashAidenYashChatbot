Imports System.Speech.Recognition
Imports System.Speech.Synthesis
Public Class MessageForm
    Dim WithEvents recogniser As SpeechRecognitionEngine
    Dim speaker As SpeechSynthesizer
    Dim wordOutput As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recogniser = New SpeechRecognitionEngine(New System.Globalization.CultureInfo("en-US"))
        recogniser.SetInputToDefaultAudioDevice()
        speaker = New SpeechSynthesizer()
        speaker.SetOutputToDefaultAudioDevice()

        recogniser.LoadGrammar(New DictationGrammar("grammar:dictation"))

        Spacer.Size = New Drawing.Size(MessagePanel.Size.Width - MessagePanel.Margin.Size.Width, 0)
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

    Private Sub Chatbot_Respond(Input As String) 'put all the chatting logic in here :D
        Dim Response = "placeholder message bro"
        If Input.Contains("yoo now way") Then
            Response = "whatever for now baby ily"
        End If 'yknow actually make this something
        Send_Chatbot_Message(Response)
    End Sub

    Private Sub Send_Chatbot_Message(Message)
        Dim botMsgLbl As New Label

        botMsgLbl.Parent = MessagePanel
        botMsgLbl.Text = Message
        botMsgLbl.AutoSize = True
        botMsgLbl.Dock = DockStyle.Left
        botMsgLbl.Margin = New Padding(3, 6, 3, 6)
        botMsgLbl.Padding = New Padding(3)
        botMsgLbl.Font = New Font("Segoe UI", 10, FontStyle.Regular)
        botMsgLbl.MaximumSize = New Size(MessagePanel.Size.Width / 3 * 2, 0)
        botMsgLbl.BackColor = SystemColors.ControlLight
        botMsgLbl.ForeColor = SystemColors.ControlText

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
        Chatbot_Respond(InputBox.Text.Trim)
        InputBox.Text = ""
    End Sub
End Class
