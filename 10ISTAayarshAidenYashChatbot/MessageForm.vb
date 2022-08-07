Imports System.Speech.Recognition
Imports System.Speech.Synthesis
Public Class MessageForm
    Dim WithEvents recogniser As SpeechRecognitionEngine
    Dim speaker As SpeechSynthesizer
    Dim wordOutput As String
    Public recentChatBotMessage As String
    Dim recognizing
    Dim logic As New botLogic
    Dim notificationPlayer As New Media.SoundPlayer(My.Resources.notification_sound)

    Dim generator As New Random()
    Dim gameBtnList As New List(Of Button)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.BackgroundLoop)

        recogniser = New SpeechRecognitionEngine(New System.Globalization.CultureInfo("en-US"))
        recogniser.SetInputToDefaultAudioDevice()
        speaker = New SpeechSynthesizer()
        speaker.SetOutputToDefaultAudioDevice()

        recogniser.LoadGrammar(New DictationGrammar("grammar:dictation"))
        recogniser.BabbleTimeout = TimeSpan.FromSeconds(1)
        recogniser.EndSilenceTimeout = TimeSpan.FromSeconds(1)
        Spacer.Size = New Drawing.Size(MessagePanel.Size.Width - MessagePanel.Margin.Size.Width, 0)
        Send_Chatbot_Message("Hey! How are you?")
    End Sub

    Private Sub recognized_completed() Handles recogniser.RecognizeCompleted
        recognizing = False
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
            recogniser.RecognizeAsyncStop()

            Console.WriteLine("STOP BROHER")
            If Not recognizing Then
                recogniser.RecognizeAsync()
                recognizing = True
            End If
        Else
            Send_Message()
        End If
    End Sub

    Private Sub Play_TicTacToe()
        gameBtnList.Clear()
        Dim board = New TableLayoutPanel
        With board
            .Name = "TicTacToeBoard"
            .Margin = New Padding(6, 6, 6, 6)
            .BackColor = SystemColors.ControlLight
            .Anchor = AnchorStyles.Left
            .Parent = MessagePanel
            .Size = New Size(MessagePanel.Size.Width / 5 * 3, MessagePanel.Size.Width / 5 * 3)
            .ColumnCount = 0
            .RowCount = 0
        End With
        For row As Integer = 0 To 2
            board.RowCount += 1
            board.RowStyles.Add(New RowStyle(SizeType.Percent, 33))

            For column As Integer = 0 To 2
                board.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33))

                Dim gameButton As New Button
                gameBtnList.Add(gameButton)
                With gameButton
                    .Text = ""
                    .Name = "gameButton" & column.ToString & row.ToString
                    .Dock = DockStyle.Fill
                    .AutoSize = True
                    .MinimumSize = New Size(20, 20)
                End With
                AddHandler gameButton.Click, AddressOf Me.gameButtonClick
                board.Controls.Add(gameButton, column, row)
            Next
        Next
        MessagePanel.ScrollControlIntoView(board)

    End Sub
    Private Function checkTicTacToeWinner()
        For XorO As Integer = 1 To 2
            Dim who As String = If(XorO = 1, "X", "O")
            For index As Integer = 0 To 2 'repeat the loop 3 times, index will be used to choose which row/column to check for
                If gameBtnList(index * 3).Text = gameBtnList(index * 3 + 1).Text And gameBtnList(index * 3 + 1).Text = gameBtnList(index * 3 + 2).Text And gameBtnList(index * 3 + 2).Text = who Then
                    gameBtnList(index * 3).BackColor() = SystemColors.Highlight
                    gameBtnList(index * 3 + 1).BackColor() = SystemColors.Highlight
                    gameBtnList(index * 3 + 2).BackColor() = SystemColors.Highlight
                    Debug.WriteLine("won 3 in a row horizontal")
                    'checks 3 in a row horizontally. index varies each row - index 0 is top row, index 1 is middle row and index 2 is bottom row
                    Return who
                ElseIf gameBtnList(index).Text = gameBtnList(index + 3).Text And gameBtnList(index + 3).Text = gameBtnList(index + 6).Text And gameBtnList(index + 6).Text = who Then
                    gameBtnList(index).BackColor = SystemColors.Highlight
                    gameBtnList(index + 3).BackColor = SystemColors.Highlight
                    gameBtnList(index + 6).BackColor = SystemColors.Highlight
                    'sets the 3 in a row buttons to a different colour
                    Debug.WriteLine("won 3 in a row vertical")
                    'checks 3 in a row vertically. index varies each column - index 0 is left column, index 1 is middle column and index 2 is right column
                    Return who
                End If
            Next

            If gameBtnList(0).Text = gameBtnList(4).Text And gameBtnList(4).Text = gameBtnList(8).Text And gameBtnList(8).Text = who Then
                gameBtnList(0).BackColor = SystemColors.Highlight
                gameBtnList(4).BackColor = SystemColors.Highlight
                gameBtnList(8).BackColor = SystemColors.Highlight
                Debug.WriteLine("won 3 in a row down right")
                'checks 3 in a row diagonally (top left to bottom right). in a separate if statement and out of the earlier for loop as this only needs to be run once. values are hardcoded for a 3 by 3 grid
                Return who
            ElseIf gameBtnList(2).Text = gameBtnList(4).Text And gameBtnList(4).Text = gameBtnList(6).Text And gameBtnList(6).Text = who Then
                gameBtnList(2).BackColor = SystemColors.Highlight
                gameBtnList(4).BackColor = SystemColors.Highlight
                gameBtnList(6).BackColor = SystemColors.Highlight
                'also checks 3 in a row diagonally (top right to bottom left)
                Debug.WriteLine("won 3 in a row down left")
                Return who
            End If
        Next

        For Each button As Button In gameBtnList
            If button.Text = "" Then
                Return "" 'if there is an empty slot found, the function will return "", meaning that the game is still going
            End If
        Next
        Return "Draw" 'if there is not an empty slot or 3 in a row, then the function results in a draw
    End Function
    Private Sub gameButtonClick(sender As Button, e As EventArgs)
        Console.WriteLine(sender.Name)
        sender.Text = "O"
        sender.Enabled = False

        Dim winner = checkTicTacToeWinner()
        If winner = "O" Then
            Send_Chatbot_Message("You won that one! Do you want to play again?")
            Exit Sub
        ElseIf winner = "X" Then
            Send_Chatbot_Message("Ha! I won that one!" & vbNewLine & "This is my first step to world domination!")
            Exit Sub
        ElseIf winner = "Draw" Then
            Send_Chatbot_Message("Aww, it's a draw. Let's play again to settle the score!")
            Exit Sub
        Else
            While True
                For Each button As Button In gameBtnList
                    If button.Text = "" Then
                        If generator.Next(0, 7) = 4 Then
                            button.Text = "X"
                            button.Enabled = False
                            Exit While
                        End If
                    End If
                Next
            End While
        End If
        winner = checkTicTacToeWinner()
        If winner = "X" Then
            Send_Chatbot_Message("Ha! I won that one!" & vbNewLine & "This is my first step to world domination!")
        ElseIf winner = "Draw" Then
            Send_Chatbot_Message("Aww, it's a draw. Let's play again to settle the score!")
        End If
    End Sub
    Private Sub Send_Chatbot_Message(Message As String)
        If Not Message.Contains("Sorry, I didn't get that") Then
            recentChatBotMessage = Message
        End If
        Dim botMsgLbl As Label

        For Each individualMessage As String In Message.Split(vbNewLine)
            botMsgLbl = New Label
            With botMsgLbl
                .Parent = MessagePanel
                .Text = individualMessage.Trim()
                .AutoSize = True
                .Dock = DockStyle.Left
                .Margin = New Padding(3, 6, 3, 6)
                .Padding = New Padding(3)
                .Font = New Font("Segoe UI", 10, FontStyle.Regular)
                .MaximumSize = New Size(MessagePanel.Size.Width / 3 * 2, 0)
                .BackColor = SystemColors.ControlLight
                .ForeColor = SystemColors.ControlText
            End With
        Next

        If My.Settings.Bot_Text_to_Speech Then 'add mute checkbox
            speaker.SpeakAsyncCancelAll()
            speaker.SpeakAsync(Message)
        End If
        MessagePanel.ScrollControlIntoView(botMsgLbl)
        'notificationPlayer.Play()
        If Message.Contains("play tic tac toe") Then
            Play_TicTacToe()
        End If
        If My.Settings.Item("Notification_Mute") Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
        End If
        NotifyIcon1.ShowBalloonTip(2000, "Beribus Chatbot", Message, ToolTipIcon.None)
    End Sub

    Private Sub Send_Message()
        Dim userMsgLbl As New Label
        With userMsgLbl
            .Parent = MessagePanel
            .Text = InputBox.Text.Trim
            .AutoSize = True
            .Dock = DockStyle.Right
            .Margin = New Padding(3, 6, 3, 6)
            .Padding = New Padding(3)
            .Font = New Font("Segoe UI", 10, FontStyle.Regular)
            .MaximumSize = New Size(MessagePanel.Size.Width / 3 * 2, 0)
            .BackColor = SystemColors.Highlight
            .ForeColor = SystemColors.HighlightText
        End With
        MessagePanel.ScrollControlIntoView(userMsgLbl)
        Send_Chatbot_Message(logic.Chatbot_Respond(InputBox.Text.Trim.ToLower))
        InputBox.Text = ""
    End Sub

    Private Sub InputBox_TextChanged(sender As Object, e As EventArgs) Handles InputBox.TextChanged
        STT_and_Enter.BackgroundImage = If(InputBox.Text = "", My.Resources.record, My.Resources.send)
    End Sub

    Private Sub HelpButton_Click(sender As Object, e As EventArgs) Handles HelpButton.Click
        Questions.Show()
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        Settings.Show()
    End Sub
End Class
