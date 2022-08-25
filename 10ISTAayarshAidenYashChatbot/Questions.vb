Public Class Questions
    Dim QuestionsList As New List(Of String)({"well", "good", "great", "wonderful", "alright", "ok", "okay", "alright", "happy", "glad", "excellent", "exceptional", "marvelous", "positive", "superb", "wonderful"})
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