Imports System.Speech.Recognition
Public Class Form1
    Dim WithEvents recogniser As SpeechRecognitionEngine

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recogniser = New SpeechRecognitionEngine(New System.Globalization.CultureInfo("en-US"))
        recogniser.SetInputToDefaultAudioDevice()

        Dim gram As New SrgsGrammar.SrgsDocument
        Dim colorRule As New SrgsGrammar.SrgsRule("color")
        Dim colorsList As New SrgsGrammar.SrgsOneOf("red", "green", "blue")

        colorRule.Add(colorsList)
        gram.Rules.Add(colorRule)
        gram.Root = colorRule

        recogniser.LoadGrammar(New Grammar(gram))
        recogniser.RecognizeAsync()

    End Sub

    Private Sub recognized_completed(ByVal sender As Object, ByVal e As RecognizeCompletedEventArgs) Handles recogniser.RecognizeCompleted
        recogniser.RecognizeAsync()
    End Sub

    Private Sub on_recognized(sender As Object, e As SpeechRecognizedEventArgs) Handles recogniser.SpeechRecognized
        Console.WriteLine(e.Result.Text)
        Label1.Text = e.Result.Text
    End Sub
End Class
