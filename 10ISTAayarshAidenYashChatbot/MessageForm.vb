Imports System.Speech.Recognition
Imports System.Speech.Synthesis
Public Class MessageForm
    Dim WithEvents recogniser As SpeechRecognitionEngine
    Dim speaker As SpeechSynthesizer
    Dim wordOutput As String
    Dim recentChatBotMessage As String

    Dim goodWords As New List(Of String)({"well", "good", "great", "wonderful", "alright"})
    Dim badWords As New List(Of String)({"bad", "terrible", "unwell"})
    Dim isWords As New List(Of String)({"is", "it's", "'s"})
    Dim affirmativeWords As New List(Of String)({"yes", "please", "of course", "affirmative"})
    Dim refusalWords As New List(Of String)({"no", "not", "never"})
    Dim systemWords As New List(Of String)({"circulatory", "respiratory", "digestive", "skeletal", "nervous"})

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each word As String In goodWords
            badWords.Add("not " + word)
        Next
        For Each word As String In badWords
            goodWords.Add("not " + word)
        Next

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

    Private Sub Chatbot_Respond(Input As String) 'put all the chatting logic in here :D
        Dim Response = "Sorry, I didn't get that"
        If recentChatBotMessage.Contains("How are you") Then
            For Each word As String In goodWords
                If Input.Contains(word) Then
                    Response = "That's great to hear!" & vbNewLine & "Oh I forgot to ask, what's your name?"
                End If
            Next
            For Each word As String In badWords
                If Input.Contains(word) Then
                    Response = "I'm sorry to hear that!" & vbNewLine & "Oh I forgot to ask, what's your name?"
                End If
            Next
        ElseIf recentChatBotMessage.Contains("your name?") Then
            For Each word As String In isWords
                Dim chatterName As String = Input
                If Input.Contains(word) Then
                    Dim wordSeparator() As String = {word}

                    chatterName = Input.Split(wordSeparator, StringSplitOptions.None)(Input.Split(wordSeparator, StringSplitOptions.None).Length - 1).Trim()
                End If
                Response = chatterName & ", huh? I like that name!"
                Response = Response & vbNewLine & "Well, " & chatterName & ", do you want to learn about the human body systems?"
            Next
        ElseIf recentChatBotMessage.Contains("learn about the hu") Then
            For Each word As String In refusalWords
                If Input.Contains(word) Then
                    Response = "Get the fuck out you troll piece of shit"
                End If
            Next
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = "Great!" & vbNewLine & "Which system do you want to hear about first? The nervous, skeletal, digestive, circulatory or respiratory system?"
                End If
            Next
        ElseIf recentChatBotMessage.Contains("hear about firs") Then
            For Each word As String In systemWords
                If Input.Contains(word) Then
                    If word = "circulatory" Then
                        Response = "Oh the circulatory system, I love this one!" & vbNewLine & "actual information"
                    ElseIf word = "respiratory" Then
                        Response = "The respiratory system's really important!" & vbNewLine & "info part 2"
                    ElseIf word = "nervous" Then
                        Response = "This one is my favourite, it's really technical!" & vbNewLine & "Oh, did you know the brain, and by extension the nervous system, is the only part of the body to have named itself?" & vbNewLine & "That's really cool, isn't it?" & "As you may have guessed, the nervous system is INFORMATION HERE"
                    ElseIf word = "skeletal" Then
                        Response = "The skeletal system is the backbone of the rest of the body!" & vbNewLine & "Haha, did you see what I did there?" & vbNewLine & "Well, the skeletal system INFORMATION HERE"
                    ElseIf word = "digestive" Then
                        Response = "The digestive system is easily the crappiest of them all. No I mean literally!" & vbNewLine & "The digestive system involves INFO TIME"
                    End If
                End If
            Next
        End If

        If Input.Contains("yoo now way") Then
            Response = "whatever for now baby ily"
        End If 'yknow actually make this something

        Send_Chatbot_Message(Response)
    End Sub

    Private Sub Send_Chatbot_Message(Message As String)
        If Not Message.Contains("Sorry, I didn't get that") Then
            recentChatBotMessage = Message
        End If

        For Each individualMessage As String In Message.Split(vbNewLine)
            Dim botMsgLbl As New Label

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
        MessagePanel.AutoScrollPosition = New Point(-1)
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
        Chatbot_Respond(InputBox.Text.Trim.ToLower)
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
