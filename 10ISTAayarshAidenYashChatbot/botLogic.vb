Public Class botLogic
    Dim goodWords As New List(Of String)({"well", "good", "great", "wonderful", "alright", "not bad", "not terrible"})
    Dim badWords As New List(Of String)({"bad", "not good", "not great", "terrible", "unwell", "not doing well"})
    Dim isWords As New List(Of String)({"is", "it's"})
    Dim affirmativeWords As New List(Of String)({"yes", "please", "of course", "affirmative"})
    Dim refusalWords As New List(Of String)({"no", "not", "never"})
    Dim systemWords As New List(Of String)({"circulatory", "respiratory", "digestive", "skeletal", "nervous"})

    Dim definitionWords As New List(Of String)({"what is"})
    Dim compositionWords As New List(Of String)({"where is", "what makes up", "part"})
    Dim purposeWords As New List(Of String)({"what does", "purpose", "job"})
    Dim howWords As New List(Of String)({"how does", "work"})
    Dim integrationWords As New List(Of String)({"other", "with"})

    'For Each word As String In goodWords
    '         badWords.Add("not " + word)
    'Next
    'For Each word As String In badWords
    '       goodWords.Add("not " + word)
    'Next

    Public Function Chatbot_Respond(Input As String) As String 'put all the chatting logic in here :D
        Dim Response = "Sorry, I didn't get that"
        If MessageForm.recentChatBotMessage.Contains("How are you") Then
            Dim goodResponse
            For Each word As String In goodWords
                If Input.Contains(word) Then
                    goodResponse = True
                    Response = "That's great to hear!" & vbNewLine & "My name is Beribus, what's yours?"
                End If
            Next
            For Each word As String In badWords
                If Input.Contains(word) Then
                    goodResponse = False
                    Response = "I'm sorry to hear that!" & vbNewLine & "My name is Beribus, what's yours?"
                End If
            Next

        ElseIf MessageForm.recentChatBotMessage.Contains("name is Beribus") Then
            For Each word As String In isWords
                Dim chatterName As String = Input
                If Input.Contains(word) Then
                    chatterName = Input.Split(word)(Input.Split(word).Length - 1)
                End If
                Response = chatterName & ", huh? I like that name!"
                Response = Response & vbNewLine & "Well, " & chatterName & ", do you want to learn about the human body systems?"
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("learn about the hu") Then
            For Each word As String In refusalWords
                If Input.Contains(word) Then
                    Response = "Oh well, that's alright, do you want to play a game instead then?"
                End If
            Next
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = "Great!" & vbNewLine & "Which system do you want to hear about first? The nervous, skeletal, digestive, circulatory or respiratory system?"
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("play a game") Then
            For Each word As String In refusalWords
                If Input.Contains(word) Then
                    Response = "Well, let's continue to learn about the human body systems then!"
                End If
            Next
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = "Great!"
                    'do some gaming shit here idk i don't want it all in one file because it's so annoying to use but it seems like i'll have to
                    Return Response
                    Exit Function
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("hear about firs") Then
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
        ElseIf MessageForm.recentChatBotMessage.Contains("circulatory") Then
            For Each word As String In definitionWords

            Next
        End If

        If Input.Contains("yoo now way") Then
            Response = "whatever for now baby ily"
        End If 'yknow actually make this something

        Return Response
    End Function
End Class