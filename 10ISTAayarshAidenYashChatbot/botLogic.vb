Public Class botLogic
    Dim goodWords As New List(Of String)({"well", "good", "great", "wonderful", "alright", "ok", "okay", "alright", "happy", "glad", "excellent", "exceptional", "marvelous", "positive", "superb", "wonderful"})
    Dim badWords As New List(Of String)({"bad", "terrible", "unwell", "sad", "unhappy", "annoyed", "disappointed", "awful", "depressed", "distressed"})
    Dim isWords As New List(Of String)({"is", "it's", "'s"})
    Dim affirmativeWords As New List(Of String)({"yes", "please", "of course", "affirmative", "why not", "okay", "sure", "yep", "all right", "gladly", "ok"})
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
                ElseIf Input.Contains(word) And Input.Contains("not") Then
                    goodResponse = False
                End If
            Next
            For Each word As String In badWords
                If Input.Contains(word) Then
                    goodResponse = False
                ElseIf Input.Contains(word) And Input.Contains("not") Then
                    goodResponse = True
                End If
            Next
            If goodResponse IsNot Nothing Then
                If goodResponse Then
                    Response = "That's great to hear!"
                ElseIf Not goodResponse Then
                    Response = "I'm sorry to hear that! I'll do what I can to change that!"
                End If
                If Input.Contains("you") Then
                    Response = Response & vbNewLine & "I am an AI and therefore don’t have feelings, but since you asked, I’m doing great!"
                End If
                Response = Response & vbNewLine & "My name is Beribus, what's yours?"

            End If

        ElseIf MessageForm.recentChatBotMessage.Contains("name is Beribus") Then
            Dim chatterName As String = Input
            For Each word As String In isWords
                If Input.Contains(word) Then
                    Dim wordSeparator() As String = {word}
                    chatterName = Input.Split(wordSeparator, StringSplitOptions.None)(Input.Split(wordSeparator, StringSplitOptions.None).Length - 1).Trim()
                End If
                Response = chatterName & ", huh? I like that name!"
                Response = Response & vbNewLine & "Well, " & chatterName & ", do you want to learn about the human body systems?"
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("learn about the hu") Then
            For Each word As String In refusalWords
                If Input.Contains(word) Then
                    Response = "Oh well, that's alright." & vbNewLine & "Do you want to play a game instead then?"
                End If
            Next
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = "Great!" & vbNewLine & "Which system do you want to hear about first? The nervous, skeletal, digestive, circulatory or respiratory system?"
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("play a game") Or MessageForm.recentChatBotMessage.Contains("play again") Then
            For Each word As String In refusalWords
                If Input.Contains(word) Then
                    Response = "Well, let's continue to learn about the human body systems then!"
                End If
            Next
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = "Great! Let's play tic tac toe!" & vbNewLine & "You move first!"
                    'do some gaming shit here idk i don't want it all in one file because it's so annoying to use but it seems like i'll have to
                    Return Response
                    Exit Function
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("hear about firs") Then
            For Each word As String In systemWords
                If Input.Contains(word) Then
                    If word = "circulatory" Then
                        Response = "Oh the circulatory system, I love this one!" & vbNewLine & "The circulatory system, or cardiovascular system, is responsible for delivering oxygen-rich blood all over your body. The circulatory system pumps blood from the heart to the lungs to get oxygen. The heart then sends oxygenated blood through arteries to the rest of the body. The veins carry oxygen-poor blood back to the heart to start the circulation process over."
                    ElseIf word = "respiratory" Then
                        Response = "The respiratory system's really important!" & vbNewLine & "The circulatory system, or cardiovascular system, is responsible for delivering oxygen-rich blood all over your body. The circulatory system pumps blood from the heart to the lungs to get oxygen. The heart then sends oxygenated blood through arteries to the rest of the body. The veins carry oxygen-poor blood back to the heart to start the circulation process over."
                    ElseIf word = "nervous" Then
                        Response = "This one is my favourite, it's really technical!" & vbNewLine & "Oh, did you know the brain, and by extension the nervous system, is the only part of the body to have named itself?" & vbNewLine & "That's really cool, isn't it?" & "As you may have guessed, the nervous system is the organised network of nerve tissue in the body, including the brain. The nervous system helps in the communication of every single operation, organ and system with the brain, by delivering electrical signals through nerves to the brain, which the brain interprets as messages. "
                    ElseIf word = "skeletal" Then
                        Response = "The skeletal system is the backbone of the rest of the body!" & vbNewLine & "Haha, did you see what I did there?" & vbNewLine & "Well, the skeletal system works as a support structure for your body. It gives the body its shape, allows movement, makes blood cells, provides protection for organs and stores minerals. The skeletal system is also called the musculoskeletal system."
                    ElseIf word = "digestive" Then
                        Response = "The digestive system is easily the crappiest of them all. No, I mean literally!" & vbNewLine & "The digestive system involves digesting the things we consume, and eventually, getting rid of it as feces. The digestive system converts the foods we eat into their simplest forms, like glucose (sugars), amino acids (that make up protein) or fatty acids (that make up fats). The broken-down food is then absorbed into the body from the small intestine and the nutrients are carried to each cell in the body."
                    End If
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("circulatory") Then
            For Each word As String In definitionWords
                If Input.Contains(word) Then
                    Response = "The circulatory system, or cardiovascular system, is responsible for delivering oxygen-rich blood all over your body. The circulatory system pumps blood from the heart to the lungs to get oxygen. The heart then sends oxygenated blood through arteries to the rest of the body. The veins carry oxygen-poor blood back to the heart to start the circulation process over."
                End If
            Next
            For Each word As String In compositionWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "system purpose"
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = "system integration"
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("respiratory") Then
            For Each word As String In definitionWords
                If Input.Contains(word) Then
                    Response = "The respiratory system is the network of organs and tissues that help you breathe. It includes your airways, lungs and blood vessels. The muscles that power your lungs are also part of the respiratory system. These parts work together to move oxygen throughout the body and clean out waste gases like carbon dioxide."
                End If
            Next
            For Each word As String In compositionWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "system purpose"
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = "system integration"
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("skeletal") Then
            For Each word As String In definitionWords
                If Input.Contains(word) Then
                    Response = "The skeletal system works as a support structure for your body. It gives the body its shape, allows movement, makes blood cells, provides protection for organs and stores minerals. The skeletal system is also called the musculoskeletal system."
                End If
            Next
            For Each word As String In compositionWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "system purpose"
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = "system integration"
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("digestive") Then
            For Each word As String In definitionWords
                If Input.Contains(word) Then
                    Response = "The digestive system converts the foods we eat into their simplest forms, like glucose (sugars), amino acids (that make up protein) or fatty acids (that make up fats). The broken-down food is then absorbed into the body from the small intestine and the nutrients are carried to each cell in the body."
                End If
            Next
            For Each word As String In compositionWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "system purpose"
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = "system integration"
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("nervous") Then
            For Each word As String In definitionWords
                If Input.Contains(word) Then
                    Response = "The nervous system is the organised network of nerve tissue in the body. The nervous system helps in the communication of every single operation, organ and system with the brain, by delivering electrical signals through nerves to the brain, which the brain interprets as messages. "
                End If
            Next
            For Each word As String In compositionWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = "system definition"
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "system purpose"
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = "system integration"
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("fun fact") Then
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = "Did you know that the brain is the only organ to name itself?"
                End If
            Next
            For Each word As String In refusalWords
                If Input.Contains(word) Then
                    Response = "Well, your loss. I've got tons more for when you change your mind!" & vbNewLine & "For now, give me a question about our 5 body systems!"
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("a joke") Then
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = "Ok! Here goes!" & vbNewLine & "put a joke here lol haha"
                End If
            Next
            For Each word As String In refusalWords
                If Input.Contains(word) Then
                    Response = "Oh, alright then." & "Hit me with a question about some more body systems!"
                End If
            Next
        End If
        For Each system As String In systemWords
            If Input.Contains(system) Then
                For Each word As String In definitionWords
                    If Input.Contains(word) Then
                        Response = system & "system definition"
                    End If
                Next
                For Each word As String In compositionWords
                    If Input.Contains(word) Then
                        Response = system & "system definition"
                    End If
                Next
                For Each word As String In howWords
                    If Input.Contains(word) Then
                        Response = system & "system definition"
                    End If
                Next
                For Each word As String In purposeWords
                    If Input.Contains(word) Then
                        Response = system & "system purpose"
                    End If
                Next
                For Each word As String In integrationWords
                    If Input.Contains(word) Then
                        Response = system & "system integration"
                    End If
                Next
            End If
        Next

        If Input.Contains("joke") Then
            Response = "Do you want to hear a joke? No guarentees it's good though!"
        ElseIf Input.Contains("game") Then
            Response = "Do you want to play a game?"
        ElseIf Input.Contains("fact") Then
            Response = "You want to hear a fun fact?"
        End If
        'yknow actually make this something

        Return Response
    End Function
End Class
