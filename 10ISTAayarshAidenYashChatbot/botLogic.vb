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
                        Response = "The respiratory system's really important!" & vbNewLine & "The respiratory system is the network of organs and tissues that help you breathe. It includes your airways, lungs and blood vessels. The muscles that power your lungs are also part of the respiratory system. These parts work together to move oxygen throughout the body and clean out waste gases like carbon dioxide."
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
                    Response = "Your heart and blood vessels make up the circulatory system. These blood vessels are made up of veins, arteries and capillaries. Veins are the more visible blood vessels of the body, and can be spotted on our hands, feet and many other places. They are responsible for delivering deoxygenated blood back to the heart. Arteries are not as visible as veins as they are usually deeper in the flesh. Arteries are responsible for delivering oxygenated blood around the body. Capillaries are extremely small blood vessels that cannot be seen by the naked eye at all. Capillaries are responsible for the gaseous exchange in our blood, where deoxygenated blood becomes oxygenated. "

                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = "Firstly, the deoxygenated blood will arrive from the veins to the heart. The heart will receive this blood, and pump it to the lungs, where they will enter the capillaries in the alveoli of the lungs. Here, the deoxygenated blood performs gaseous exchange, and the blood becomes oxygenated. After this process, the blood is pumped back to the heart, and all around the body through the arteries where it can deliver its oxygen to all body tissues and organs. This includes the small intestine, where it absorbs nutrients from food you have consumed. Once its oxygen is delivered, the deoxygenated blood will return through the veins, and the cycle repeats itself. "
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "The circulatory system moves blood throughout the body. This system helps tissues get enough oxygen and nutrients, and it helps them get rid of waste products, such as carbon dioxide."
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = "The respiratory system works directly with the circulatory system to provide oxygen to the body. Oxygen taken in from the respiratory system moves into blood vessels that then circulate oxygen-rich blood to tissues and cells."
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
                    Response = "The main organ of the respiratory system is the lungs. Other respiratory organs include the nose, the trachea and the breathing muscles, which are the diaphragm and the intercostal muscles, which run along the ribs, and help your chest itself expand and contract."
                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = "The respiratory system is responsible for respiration, the process of breathing. When you breathe in, air enters the body through either your mouth or nose and moves into the trachea, which runs along the back of your throat. As the air moves down your throat, it enters your lungs through the bronchial tubes. These bronchial tubes then divide into smaller bronchioles, which divide into even smaller alveoli. Alveoli are extremely small sacs inside your lungs, where the air meets with capillaries, which are extremely small blood vessels. Here,  oxygen from the air moves to your blood. At the same time, carbon dioxide, a waste gas, moves from your blood to the lungs and is breathed out. This process, called gas exchange, is essential to life. After this, the air follows the same passage it enters your lungs from, out, and you have just respirated!"
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "The respiratory system's main job is to move fresh air into your body while removing waste gases. Once in the lungs, oxygen is moved into the bloodstream and carried through your body. At each cell in your body, oxygen is exchanged for a waste gas called carbon dioxide."
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = " The respiratory system works with the circulatory system to provide this oxygen and to remove the waste products of metabolism. It also helps to regulate pH of the blood."
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
                    Response = "The main part of your skeletal system consists of your bones, hard structures that create your body’s framework — the skeleton. There are 206 bones in an adult human skeleton. The other components of your skeletal system include cartilage which is a smooth and flexible substance that covers the tips of your bones where they meet. It enables bones to move without friction (rubbing against each other). When cartilage wears away, as in arthritis, it can be painful and cause movement problems. Joints are another part of the skeletal system, where two or more bones in the body come together. There are also ligaments, which are bands of strong connective tissue holding bones together and tendons, which are bands of tissue that connect the ends of a muscle to your bone."
                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = "The skeleton provides the structural framework for the body. Brilliantly engineered, the skeletal system enables movement, stores minerals, protects internal organs, bears the body's weight, and distributes forces. In its spongy interiors it houses the mechanisms for storing and creating blood cells."
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "It gives the body its shape, allows movement, makes blood cells, provides protection for organs and stores minerals. "
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = "The Cardiovascular system and the skeletal system interrelate with each other, which plays a vital role in keeping the human body alive. The bone marrow within your bones forms new red and white blood cells and removes dirty blood cells. After making these new blood cells, it sends them to the circulatory system."
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
                    Response = "The digestive system includes the mouth, pharynx (throat), oesophagus, stomach, small intestine, large intestine, rectum, and anus. It also includes the salivary glands, liver, gallbladder, and pancreas, which make digestive juices and enzymes that help the body digest food and liquids."
                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = " The digestive system begins with the mouth, where food is grinded up by your teeth and mixed with saliva, making it soft and easier to swallow. Once it is properly chewed up, food enters the oesophagus, where it travels down to the stomach. The stomach contains many acids and enzymes to help break down the food you have just consumed. It also churns the food, breaking it down physically as well as chemically. After this, it enters the small intestine, where nutrients are absorbed from the food by cells lining the walls of the intestines called ‘villi’. These villi then pass the nutrients into the bloodstream. The pancreas and liver also work on the nutrients in food, such as breaking down sugars and fats, processing carbohydrates and proteins, as well as filtering and processing impurities, drugs and toxins. Once all nutrients have been absorbed, it travels into the large intestine, where food is made easy to be passed through and exits through the anus. "
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "The digestive system takes in food and liquids and breaks them down into substances that the body can use for energy, growth, and tissue repair. Waste products the body cannot use leave the body through bowel movements."
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = "The digestive system works with the circulatory system as the digestive system gets nutrients from food and hands it over to the blood. The circulatory system then carries those nutrients where they need to go."
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
                    Response = "The nervous system includes the central nervous system, which is made up of the brain and spinal cord, the peripheral nervous system. which are the nerves that extend from the spinal cord to the rest of the body, and other nerve tissue situated all over the body. "
                End If
            Next
            For Each word As String In howWords
                If Input.Contains(word) Then
                    Response = "The nervous system takes in information through our senses, processes the information and triggers reactions, such as making your muscles move or causing you to feel pain. For example, if you touch a hot plate, you reflexively pull back your hand and your nerves simultaneously send pain signals to your brain."
                End If
            Next
            For Each word As String In purposeWords
                If Input.Contains(word) Then
                    Response = "The nervous system helps all the parts of the body to communicate with each other. It also reacts to changes both outside and inside the body. The nervous system uses both electrical and chemical means to send and receive messages."
                End If
            Next
            For Each word As String In integrationWords
                If Input.Contains(word) Then
                    Response = "The nervous system controls various organs of the body directly. The brain also receives information from many organs of the body and adjusts signals to these organs to maintain proper functioning. It also receives and transmits signals when you consciously perform an action and instructs things like muscles to move when you want them to using signals."
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
                        If system = "respiratory" Then
                            Response = "The respiratory system is the network of organs and tissues that help you breathe. It includes your airways, lungs and blood vessels. The muscles that power your lungs are also part of the respiratory system. These parts work together to move oxygen throughout the body and clean out waste gases like carbon dioxide."
                        End If
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
