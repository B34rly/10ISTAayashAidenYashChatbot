Public Class Questions
    Dim QuestionsList As New List(Of String)({
"Let's play a game!",
"Tell me a joke.",
"Tell me a fun fact.",
"Whats your name?",
"What Is the nervous system?",
"Where Is the nervous system located/what makes up the nervous system?",
"What does the nervous system Do?",
"How does the nervous system work?",
"How does the nervous system work With other systems?",
"What Is the respiratory system?",
"What makes up the respiratory system? ",
"How does the respiratory system work? ",
"What does the respiratory system Do? ",
"How does the respiratory system work With other systems?",
"What Is the circulatory system?",
"What makes up the circulatory system?",
"How does the circulatory system work?",
"What does the circulatory system Do?",
"How does the circulatory system work With other systems?",
"What Is the digestive system?",
"What makes up the digestive system?",
"How does the digestive system work?",
"What does the digestive system Do?",
"How does the digestive system work With other systems?",
"What Is the skeletal system?",
"What Is the skeletal system made up of?",
"How does the skeletal system work?",
"What does the skeletal system Do?",
"How does the skeletal system work With other systems?", ""})
    Private Sub Questions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Spacer.Size = New Size(QuestionPanel.Size.Width - QuestionPanel.Padding.Size.Width * 2, 0)
        For Each Question As String In QuestionsList
            Dim QuestionLbl = New Label
            With QuestionLbl
                .Text = Question
                .Font = New Font("Segoe UI", 10, FontStyle.Regular)
                .Parent = QuestionPanel
                .AutoSize = True
                .Padding = New Padding(3)
            End With

            Dim borderLbl = New Label
            With borderLbl
                .Parent = QuestionPanel
                .Text = ""
                .Name = "InterlabelSpacer"
                .Margin = New Padding(0)
                .AutoSize = False
                .Size = New Size(2, 1)
                .BorderStyle = BorderStyle.Fixed3D
                .Anchor = AnchorStyles.Left Or AnchorStyles.Right
            End With
        Next
    End Sub

    Private Sub QuestionsForm_Resize(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Spacer.Size = New Size(QuestionPanel.Size.Width - QuestionPanel.Padding.Size.Width * 2, 0)
    End Sub
End Class