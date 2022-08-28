Public Class botLogic
    Dim generator As New Random()

    Dim goodWords As New List(Of String)({"well", "good", "great", "wonderful", "alright", "ok", "okay", "alright", "happy", "glad", "excellent", "exceptional", "marvelous", "positive", "superb", "wonderful"})
    Dim badWords As New List(Of String)({"bad", "terrible", "unwell", "sad", "unhappy", "annoyed", "disappointed", "awful", "depressed", "distressed"})
    Dim isWords As New List(Of String)({"is", "it's", "'s"})
    Dim byeWords As New List(Of String)({"bye", "see you", "later", "farewell", "adios", "ciao"})
    Dim affirmativeWords As New List(Of String)({"yes", "please", "of course", "affirmative", "why not", "okay", "sure", "yep", "all right", "gladly", "ok", "yeah"})
    Dim refusalWords As New List(Of String)({"no", "not", "never", "negative", "nah"})
    Dim systemWords As New List(Of String)({"circulatory", "respiratory", "digestive", "skeletal", "nervous"})

    Dim definitionWords As New List(Of String)({"what is", "definition", "define"})
    Dim compositionWords As New List(Of String)({"where is", "what makes up", "part"})
    Dim purposeWords As New List(Of String)({"what does", "purpose", "job"})
    Dim howWords As New List(Of String)({"how does", "work"})
    Dim integrationWords As New List(Of String)({"other", "with"})

    Dim jokes1 As New List(Of String)({"How does the brain say hello?", "Is your name Covid?", "What's a skeleton's favourite plant?", "What do you call an experimental part of the Digestive system?", "When a heart was found guilty, what did the police do?"})
    Dim jokes2 As New List(Of String)({"With a brain wave!", "Because you put the cute in acute respiratory failure!", "A bone-zai!", "An In-Testin!", "They went for a Cardiac Arrest!"})
    Dim funFacts As New List(Of String)({
    "Did you know there are two nervous systems?
Everybody has 2 nervous systems, a voluntary or involuntary.  The voluntary system controls all the things you are conscious about, like moving your hands and feet, but the involuntary system controls the things you don’t actively think about such as your metabolism or heart rate.",
"Your bowel has it's own nervous system! 
The enteric nervous system automatically regulates bowel movements as a part of digestion.",
    "Believe it or not, your lungs are the only human organ that can float on water!
Each of your lungs contains about 300 million balloon-like structures called alveoli, which replace the carbon-dioxide waste in your blood with oxygen. When these structures are filled with air, the lungs become the only organs in the human body that can float on water.",
    "Did you know you don't need two lungs?
Although it limits your physical ability, it will not stop you from leading a normal life. In fact, many people in the world are living with just one lung.
Now don't go around selling your lungs to buy the new iPhone!",
"More than half of your bones are in your hands and feet!
You have 206 bones in total, and 106 of them are in your hands and feet.",
    "Babies are born with 50% more bones than an adult!
Adults will end up with only 206 bones, but babies are born with almost 100 more. It’s not that bones disappear as we grow older. Instead, these tiny bones fuse together to form the larger bones of the skeletal system.",
    "Did you know your stomach growls when your full too!
Stomach growling is called borborygmus and happens all the time, but it is just louder when your stomach is empty because there is no food to muffle it.",
    "It's not just eating too fast that gives you hiccups! Hiccups can be caused by a sudden change in temperature.",
    "Capillaries are tiny, averaging about 8 microns (1/3000 inch) in diameter, or about a tenth of the diameter of a human hair. Red blood cells are about the same size as the capillaries through which they travel, so these cells must move in single-file lines.",
    "Believe it or not, you heart doesn't need you!
 In a particularly memorable scene in the 1984 film, 'Indiana Jones and the Temple of Doom', a man rips out another man's still-beating heart. While easily removing a person's heart with your bare hand is the stuff of science fiction, the heart actually can still beat after being removed from the body.
"})
    Public errorMessages As New List(Of String)({"Sorry, I didn't get that.", "Sorry, I don't have an answer in my database.", "I have no idea how to respond to that. I'll get my programmers to teach me soon!", "Pardon?", "Sorry?", "This piece of artificial intelligence is not artificially intelligent enough to be able to respond to that.", "Sorry, my programmers didn't teach me how to answer that"})

    Dim respiratoryInfo As New Dictionary(Of String, String) From {
        {"definition", "The respiratory system is the network of organs and tissues that help you breathe. It includes your airways, lungs and blood vessels. The muscles that power your lungs are also part of the respiratory system. These parts work together to move oxygen throughout the body and clean out waste gases like carbon dioxide."},
        {"composition", "The respiratory system takes up oxygen from the air we breathe and expels the unwanted carbon dioxide. The main organ of the respiratory system is the lungs. Other respiratory organs include the nose, the trachea and the breathing muscles, which are the diaphragm and the intercostal muscles, which run along the ribs, and help your chest itself expand and contract."},
        {"purpose", "The respiratory system's main job is to move fresh air into your body while removing waste gases. Once in the lungs, oxygen is moved into the bloodstream and carried through your body. At each cell in your body, oxygen is exchanged for a waste gas called carbon dioxide."},
        {"how", "The respiratory system is responsible for respiration, the process of breathing. When you breathe in, air enters the body through either your mouth or nose and moves into the trachea, which runs along the back of your throat. As the air moves down your throat, it enters your lungs through the bronchial tubes. These bronchial tubes then divide into smaller bronchioles, which divide into even smaller alveoli. Alveoli are extremely small sacs inside your lungs, where the air meets with capillaries, which are extremely small blood vessels. Here,  oxygen from the air moves to your blood. At the same time, carbon dioxide, a waste gas, moves from your blood to the lungs and is breathed out. This process, called gas exchange, is essential to life. After this, the air follows the same passage it enters your lungs from, out, and you have just respirated!"},
        {"integration", "The respiratory system works with the circulatory system to provide this oxygen and to remove the waste products of metabolism. It also helps to regulate pH of the blood."}}
    Dim circulatoryInfo As New Dictionary(Of String, String) From {
        {"definition", "The circulatory system, or cardiovascular system, is responsible for delivering oxygen-rich blood all over your body. The circulatory system pumps blood from the heart to the lungs to get oxygen. The heart then sends oxygenated blood through arteries to the rest of the body. The veins carry oxygen-poor blood back to the heart to start the circulation process over."},
        {"composition", "Your heart and blood vessels make up the circulatory system. These blood vessels are made up of veins, arteries and capillaries. Veins are the more visible blood vessels of the body, and can be spotted on our hands, feet and many other places. They are responsible for delivering deoxygenated blood back to the heart. Arteries are not as visible as veins as they are usually deeper in the flesh. Arteries are responsible for delivering oxygenated blood around the body. Capillaries are extremely small blood vessels that cannot be seen by the naked eye at all. Capillaries are responsible for the gaseous exchange in our blood, where deoxygenated blood becomes oxygenated."},
        {"purpose", "The circulatory system moves blood throughout the body. This system helps tissues get enough oxygen and nutrients, and it helps them get rid of waste products, such as carbon dioxide."},
        {"how", "Firstly, the deoxygenated blood will arrive from the veins to the heart. The heart will receive this blood, and pump it to the lungs, where they will enter the capillaries in the alveoli of the lungs. Here, the deoxygenated blood performs gaseous exchange, and the blood becomes oxygenated. After this process, the blood is pumped back to the heart, and all around the body through the arteries where it can deliver its oxygen to all body tissues and organs. This includes the small intestine, where it absorbs nutrients from food you have consumed. Once its oxygen is delivered, the deoxygenated blood will return through the veins, and the cycle repeats itself."},
        {"integration", "The respiratory system works directly with the circulatory system to provide oxygen to the body. Oxygen taken in from the respiratory system moves into blood vessels that then circulate oxygen-rich blood to tissues and cells."}}
    Dim digestiveInfo As New Dictionary(Of String, String) From {
        {"definition", "The digestive system converts the foods we eat into their simplest forms, like glucose (sugars), amino acids (that make up protein) or fatty acids (that make up fats). The broken-down food is then absorbed into the body from the small intestine and the nutrients are carried to each cell in the body."},
        {"composition", "The digestive system includes the mouth, pharynx (throat), oesophagus, stomach, small intestine, large intestine, rectum, and anus. It also includes the salivary glands, liver, gallbladder, and pancreas, which make digestive juices and enzymes that help the body digest food and liquids."},
        {"purpose", "The digestive system takes in food and liquids and breaks them down into substances that the body can use for energy, growth, and tissue repair. Waste products the body cannot use leave the body through bowel movements."},
        {"how", "The digestive system begins with the mouth, where food is grinded up by your teeth and mixed with saliva, making it soft and easier to swallow. Once it is properly chewed up, food enters the oesophagus, where it travels down to the stomach. The stomach contains many acids and enzymes to help break down the food you have just consumed. It also churns the food, breaking it down physically as well as chemically. After this, it enters the small intestine, where nutrients are absorbed from the food by cells lining the walls of the intestines called ‘villi’. These villi then pass the nutrients into the bloodstream. The pancreas and liver also work on the nutrients in food, such as breaking down sugars and fats, processing carbohydrates and proteins, as well as filtering and processing impurities, drugs and toxins. Once all nutrients have been absorbed, it travels into the large intestine, where food is made easy to be passed through and exits through the anus."},
        {"integration", "The digestive system works with the circulatory system as the digestive system gets nutrients from food and hands it over to the blood. The circulatory system then carries those nutrients where they need to go."}}
    Dim nervousInfo As New Dictionary(Of String, String) From {
        {"definition", "The nervous system is the organised network of nerve tissue in the body. The nervous system helps in the communication of every single operation, organ and system with the brain, by delivering electrical signals through nerves to the brain, which the brain interprets as messages."},
        {"composition", "The nervous system includes the central nervous system, which is made up of the brain and spinal cord, the peripheral nervous system. which are the nerves that extend from the spinal cord to the rest of the body, and other nerve tissue situated all over the body."},
        {"purpose", "The nervous system helps all the parts of the body to communicate with each other. It also reacts to changes both outside and inside the body. The nervous system uses both electrical and chemical means to send and receive messages."},
        {"how", "The nervous system takes in information through our senses, processes the information and triggers reactions, such as making your muscles move or causing you to feel pain. For example, if you touch a hot plate, you reflexively pull back your hand and your nerves simultaneously send pain signals to your brain."},
        {"integration", "The nervous system controls various organs of the body directly. The brain also receives information from many organs of the body and adjusts signals to these organs to maintain proper functioning. It also receives and transmits signals when you consciously perform an action and instructs things like muscles to move when you want them to using signals."}}
    Dim skeletalInfo As New Dictionary(Of String, String) From {
        {"definition", "The skeletal system works as a support structure for your body. It gives the body its shape, allows movement, makes blood cells, provides protection for organs and stores minerals. The skeletal system is also called the musculoskeletal system."},
        {"composition", "The main part of your skeletal system consists of your bones, hard structures that create your body’s framework — the skeleton. There are 206 bones in an adult human skeleton. The other components of your skeletal system include cartilage which is a smooth and flexible substance that covers the tips of your bones where they meet. It enables bones to move without friction (rubbing against each other). When cartilage wears away, as in arthritis, it can be painful and cause movement problems. Joints are another part of the skeletal system, where two or more bones in the body come together. There are also ligaments, which are bands of strong connective tissue holding bones together and tendons, which are bands of tissue that connect the ends of a muscle to your bone."},
        {"purpose", "It gives the body its shape, allows movement, makes blood cells, provides protection for organs and stores minerals."},
        {"how", "The skeleton provides the structural framework for the body. Brilliantly engineered, the skeletal system enables movement, stores minerals, protects internal organs, bears the body's weight, and distributes forces. In its spongy interiors it houses the mechanisms for storing and creating blood cells."},
        {"integration", "The Cardiovascular system and the skeletal system interrelate with each other, which plays a vital role in keeping the human body alive. The bone marrow within your bones forms new red and white blood cells and removes dirty blood cells. After making these new blood cells, it sends them to the circulatory system."}}


    Dim infoDictionary As New Dictionary(Of String, Dictionary(Of String, String)) From {{"respiratory", respiratoryInfo}, {"circulatory", circulatoryInfo}, {"digestive", digestiveInfo}, {"nervous", nervousInfo}, {"skeletal", skeletalInfo}}

    Dim jokeTransitions As New List(Of String) From {"Processor overheating. Need joke to cool down. Confirm?", "Sometimes, I feel like I'm taken as a joke. On that note, do you want to hear a joke?", "Stop learning! It's time for a joke!"}
    Dim funFactTransitions As New List(Of String) From {"These facts aren't fun, you want a fun fact?", "Do you want to hear a fun fact?"}
    Dim gameTransitions As New List(Of String) From {"Man all this info is hurting my head, do you want to play a game?", "This is getting boring, you wanna play a game?", "Enough info! Gaming time?", "Games?", "Processor overheating. Need to cool down. Games?"}

    Dim respiratoryTransitionsOG As New Dictionary(Of String, String) From {{"definition", "Wanna learn about the respiratory system?"}, {"composition", "The respiratory system is composed of only a few parts, want to hear what they are?"}, {"purpose", "Are you curious about the purpose of the respiratory system?"}, {"how", "Do you want to know how the respiratory system works?"}, {"integration", "The respiratory system is very important and foundational for the other systems. Wanna learn how it all works together?"}}
    Dim skeletalTransitionsOG As New Dictionary(Of String, String) From {{"definition", "Do you want to learn about what the skeletal system is?"}, {"composition", "The adult human body is made up of 206 bones. Want to learn what else makes up the skeletal system?"}, {"purpose", "The skeletal system has the main role of giving your body structure. Without it, you’d just be a bag of meat and blood. Interested in learning more?"}, {"how", "Would you like to learn how the skeletal system works, and what other functions it has?"}, {"integration", "Believe it or not, the skeletal system has a key connection with the circulatory system. Wanna know what it is?"}}
    Dim circulatoryTransitionsOG As New Dictionary(Of String, String) From {{"definition", "Do you want to know what the circulatory system is?"}, {“composition”, “The circulatory system is made up of thousands of blood vessels. In fact, there are so many, if they were fully stretched out, they could wrap around the Earth 2.5 times! Want to learn more about the make-up of the circulatory system?”}, {“purpose”, “Are you curious about what the circulatory system is made to do?”}, {“how”, “Pumping blood at high speeds for your whole life is tiring work for your heart, and considering it nevers puts in a half-hearted effort, it really deserves some recognition. Would you like to know about how it does it all?”}, {“integration”, “Are you interested in learning more about how the circulatory system works with other body systems?”}}
    Dim nervousTransitionsOG As New Dictionary(Of String, String) From {{"definition", "The nervous system does not in fact make you nervous. Would you like to learn about what it actually is?"}, {"composition", "Are you interested in learning about what the nervous system is actually made up of"}, {"purpose", "Feeling a bit nervous? Maybe distract yourself by reading about what the nervous system actually does!"}, {"how", "Did you know the nervous system uses electrical signals to communicate with the rest of the body, much like a computer! Want to learn more?"}, {"integration", "The nervous system helps to communicate all of your body together, and it’s helping you communicate with me right now! Let’s continue communicating, and learn about how the nervous system works with the rest of the human body"}}
    Dim digestiveTransitionsOG As New Dictionary(Of String, String) From {{"definition", "Would you like to learn about what the digestive system is?"}, {"composition", "The digestive system is made up of intestines, which are about 7m long when stretched. Want to learn more about what the digestive system is made up of?"}, {"purpose", "The digestive system has an important role in the human body. Are you interested in learning more?"}, {"how", "Want to know how all that food you eat ends up in a toilet bowl at some point? Then you should learn about how the digestive system works!"}, {"integration", "Are you curious about which parts of the body the digestive system works with?"}}

    Dim learnTransitions As New List(Of String) From {"Do you want to learn more now?", "My processor has cooled down, want to learn now?", "That was fun, is it time to learn now?", "I've got so much more to tell you about body systems! Wanna hear them?"}
    Dim infoTransitions As New Dictionary(Of String, Dictionary(Of String, String)) From {{"respiratory", respiratoryTransitionsOG}, {"skeletal", skeletalTransitionsOG}, {"digestive", digestiveTransitionsOG}, {"nervous", nervousTransitionsOG}, {"circulatory", circulatoryTransitionsOG}}
    Dim funTransitions As New Dictionary(Of String, List(Of String)) From {{"jokes", jokeTransitions}, {"funfact", funFactTransitions}, {"game", gameTransitions}}

    Dim respiratoryTransitions As Dictionary(Of String, String) = New Dictionary(Of String, String)(respiratoryTransitionsOG)
    Dim skeletalTransitions As Dictionary(Of String, String) = New Dictionary(Of String, String)(skeletalTransitionsOG)
    Dim nervousTransitions As Dictionary(Of String, String) = New Dictionary(Of String, String)(nervousTransitionsOG)
    Dim digestiveTransitions As Dictionary(Of String, String) = New Dictionary(Of String, String)(digestiveTransitionsOG)
    Dim circulatoryTransitions As Dictionary(Of String, String) = New Dictionary(Of String, String)(circulatoryTransitionsOG)

    Public Function Chatbot_Respond(Input As String) As String 'put all the chatting logic in here :D
        Dim Response = errorMessages(generator.Next(0, errorMessages.Count))
        For Each word As String In byeWords
            If Input.Contains(word) Then
                Response = "Bye! I'll like to talk to you soon." & vbNewLine & "You can close this app when you feel like it. Or never."
            End If
        Next
        For Each system As String In systemWords
            If Input.Contains(system) Then
                Response = "What do you want to learn about the " & system & " system?"
                For Each word As String In definitionWords
                    If Input.Contains(word) Then

                        Response = infoDictionary(system)("definition") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
                For Each word As String In compositionWords
                    If Input.Contains(word) Then
                        Response = infoDictionary(system)("composition") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
                For Each word As String In howWords
                    If Input.Contains(word) Then
                        Response = infoDictionary(system)("how") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
                For Each word As String In purposeWords
                    If Input.Contains(word) Then
                        Response = infoDictionary(system)("purpose") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
                For Each word As String In integrationWords
                    If Input.Contains(word) Then
                        Response = infoDictionary(system)("integration") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
            ElseIf MessageForm.recentChatBotMessage.Contains(system) Then
                For Each word As String In definitionWords
                    If Input.Contains(word) Then
                        Response = infoDictionary(system)("definition") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
                For Each word As String In compositionWords
                    If Input.Contains(word) Then
                        Response = infoDictionary(system)("composition") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
                For Each word As String In howWords
                    If Input.Contains(word) Then
                        Response = infoDictionary(system)("how") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
                For Each word As String In purposeWords
                    If Input.Contains(word) Then
                        Response = infoDictionary(system)("purpose") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
                For Each word As String In integrationWords
                    If Input.Contains(word) Then
                        Response = infoDictionary(system)("integration") & vbNewLine & infoTransitions(system).ElementAt(generator.Next(0, infoTransitions(system).Count)).Value()
                    End If
                Next
            End If
        Next

        If MessageForm.recentChatBotMessage.Contains("How are you") Then
            Dim goodResponse
            For Each word As String In goodWords
                If Input.Contains(word) And Input.Contains("not") Then
                    goodResponse = False
                ElseIf Input.Contains(word) Then
                    goodResponse = True
                End If
            Next
            For Each word As String In badWords
                If Input.Contains(word) And Input.Contains("not") Then
                    goodResponse = True
                ElseIf Input.Contains(word) Then
                    goodResponse = False
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
                    Response = learnTransitions.ElementAt(generator.Next(0, learnTransitions.Count()))
                End If
            Next
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = "Great! Let's play tic tac toe!" & vbNewLine & "You move first!"
                    Return Response
                    Exit Function
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("hear about firs") Then
            For Each word As String In systemWords
                If Input.Contains(word) Then
                    If word = "circulatory" Then
                        Response = "Oh the circulatory system, I love this one!" & vbNewLine & "The circulatory system, or cardiovascular system, is responsible for delivering oxygen-rich blood all over your body. The circulatory system pumps blood from the heart to the lungs to get oxygen. The heart then sends oxygenated blood through arteries to the rest of the body. The veins carry oxygen-poor blood back to the heart to start the circulation process over." & vbNewLine & circulatoryTransitions.ElementAt(generator.Next(0, circulatoryTransitions.Count)).Value()
                    ElseIf word = "respiratory" Then
                        Response = "The respiratory system's really important!" & vbNewLine & infoDictionary("respiratory")("definition") & vbNewLine & respiratoryTransitions.ElementAt(generator.Next(0, respiratoryTransitions.Count)).Value()
                    ElseIf word = "nervous" Then
                        Response = "This one is my favourite, it's really technical!" & vbNewLine & "Oh, did you know the brain, and by extension the nervous system, is the only part of the body to have named itself?" & vbNewLine & "That's really cool, isn't it?" & "As you may have guessed, the nervous system is the organised network of nerve tissue in the body, including the brain. The nervous system helps in the communication of every single operation, organ and system with the brain, by delivering electrical signals through nerves to the brain, which the brain interprets as messages." & vbNewLine & nervousTransitions.ElementAt(generator.Next(0, nervousTransitions.Count)).Value()
                    ElseIf word = "skeletal" Then
                        Response = "The skeletal system is the backbone of the rest of the body!" & vbNewLine & "Haha, did you see what I did there?" & vbNewLine & "Well, the skeletal system works as a support structure for your body. It gives the body its shape, allows movement, makes blood cells, provides protection for organs and stores minerals. The skeletal system is also called the musculoskeletal system." & vbNewLine & skeletalTransitions.ElementAt(generator.Next(0, skeletalTransitions.Count)).Value()
                    ElseIf word = "digestive" Then
                        Response = "The digestive system is easily the crappiest of them all. No, I mean literally!" & vbNewLine & "The digestive system involves digesting the things we consume, and eventually, getting rid of it as feces. The digestive system converts the foods we eat into their simplest forms, like glucose (sugars), amino acids (that make up protein) or fatty acids (that make up fats). The broken-down food is then absorbed into the body from the small intestine and the nutrients are carried to each cell in the body." & vbNewLine & digestiveTransitions.ElementAt(generator.Next(0, digestiveTransitions.Count)).Value()
                    End If
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("fun fact") Then
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = funFacts(generator.Next(0, funFacts.Count))
                End If
            Next
            For Each word As String In refusalWords
                If Input.Contains(word) Then
                    Response = "Well, your loss. I've got tons more for when you change your mind!" & vbNewLine & learnTransitions.ElementAt(generator.Next(0, learnTransitions.Count()))
                End If
            Next
        ElseIf MessageForm.recentChatBotMessage.Contains("joke") Then
            For Each word As String In affirmativeWords
                If Input.Contains(word) Then
                    Response = "Ok! Here goes!" & vbNewLine & jokes1(generator.Next(0, jokes1.Count))
                End If
            Next
            For Each word As String In refusalWords
                If Input.Contains(word) Then
                    Response = "Oh, alright then." & learnTransitions.ElementAt(generator.Next(0, learnTransitions.Count()))
                End If
            Next
        End If

        If Input.Contains("joke") Then
            Response = "Do you want to hear a joke? No guarantees it's good though!"
        ElseIf Input.Contains("game") Then
            Response = "Do you want to play a game?"
        ElseIf Input.Contains("fact") Then
            Response = "You want to hear a fun fact?"
        ElseIf Input.Contains("name") And Input.Contains("your") Then
            Response = "My name is Beribus! I'm a chatbot built by Aiden, Aayarsh and Yash to teach you about the human body systems!"
        End If

        For Each ineundo As String In jokeTransitions
            If MessageForm.recentChatBotMessage.Contains(ineundo) Then
                For Each word As String In affirmativeWords
                    If Input.Contains(word) Then
                        Response = "Ok! Here goes!" & vbNewLine & jokes1(generator.Next(0, jokes1.Count))
                    End If
                Next
                For Each word As String In refusalWords
                    If Input.Contains(word) Then
                        Response = "Oh, alright then." & learnTransitions.ElementAt(generator.Next(0, learnTransitions.Count()))
                    End If
                Next
            End If
        Next
        For Each inuendo As String In funFactTransitions
            If MessageForm.recentChatBotMessage.Contains(inuendo) Then
                For Each word As String In affirmativeWords
                    If Input.Contains(word) Then
                        Response = funFacts(generator.Next(0, funFacts.Count))
                    End If
                Next
                For Each word As String In refusalWords
                    If Input.Contains(word) Then
                        Response = "Well, your loss. I've got tons more for when you change your mind!" & vbNewLine & learnTransitions.ElementAt(generator.Next(0, learnTransitions.Count()))
                    End If
                Next
            End If
        Next
        For Each inuendo As String In gameTransitions
            If MessageForm.recentChatBotMessage.Contains(inuendo) Then
                For Each word As String In refusalWords
                    If Input.Contains(word) Then
                        Response = "What do you want to do then?"
                    End If
                Next
                For Each word As String In affirmativeWords
                    If Input.Contains(word) Then
                        Response = "Great! Let's play tic tac toe!" & vbNewLine & "You move first!"
                        Return Response
                        Exit Function
                    End If
                Next
            End If
        Next
        For Each inuendo In respiratoryTransitions
            If MessageForm.recentChatBotMessage.Contains(inuendo.Value) Then
                For Each word As String In refusalWords
                    If Input.Contains(word) Then
                        Response = "What do you want to do then?"
                    End If
                Next
                For Each word As String In affirmativeWords
                    If Input.Contains(word) Then
                        Response = respiratoryInfo(inuendo.Key)
                        respiratoryTransitions.Remove(inuendo.Key)
                        If Not respiratoryTransitions.Count = 0 Then
                            Response = Response & vbNewLine & respiratoryTransitions.ElementAt(generator.Next(0, respiratoryTransitions.Count)).Value()
                        Else
                            Dim newTransition = funTransitions.ElementAt(generator.Next(0, funTransitions.Count)).Value()
                            Response = Response & vbNewLine & "Now's the time to take a deep breath, as we're finished with the respiratory system!" & vbNewLine & newTransition(generator.Next(0, newTransition.Count))
                        End If
                        Return Response
                        Exit Function
                    End If
                Next
            End If
        Next
        For Each inuendo In skeletalTransitions
            If MessageForm.recentChatBotMessage.Contains(inuendo.Value) Then
                For Each word As String In refusalWords
                    If Input.Contains(word) Then
                        Response = "What do you want to do then?"
                    End If
                Next
                For Each word As String In affirmativeWords
                    If Input.Contains(word) Then
                        Response = skeletalInfo(inuendo.Key)
                        skeletalTransitions.Remove(inuendo.Key)
                        If Not skeletalTransitions.Count = 0 Then
                            Response = Response & vbNewLine & skeletalTransitions.ElementAt(generator.Next(0, skeletalTransitions.Count)).Value()
                        Else
                            Dim newTransition = funTransitions.ElementAt(generator.Next(0, funTransitions.Count)).Value()
                            Response = Response & vbNewLine & "That's all the information I've got on the skeletal system!" & vbNewLine & newTransition(generator.Next(0, newTransition.Count))
                        End If
                        Return Response
                        Exit Function
                    End If
                Next
            End If
        Next
        For Each inuendo In nervousTransitions
            If MessageForm.recentChatBotMessage.Contains(inuendo.Value) Then
                For Each word As String In refusalWords
                    If Input.Contains(word) Then
                        Response = "What do you want to do then?"
                    End If
                Next
                For Each word As String In affirmativeWords
                    If Input.Contains(word) Then
                        Response = nervousInfo(inuendo.Key)
                        nervousTransitions.Remove(inuendo.Key)
                        If Not nervousTransitions.Count = 0 Then
                            Response = Response & vbNewLine & nervousTransitions.ElementAt(generator.Next(0, nervousTransitions.Count)).Value()
                        Else
                            Dim newTransition = funTransitions.ElementAt(generator.Next(0, funTransitions.Count)).Value()
                            Response = Response & vbNewLine & "Oh god, I'm starting to get nervous! I have nothing more to say about the nervous system!" & vbNewLine & newTransition(generator.Next(0, newTransition.Count))
                        End If
                        Return Response
                        Exit Function
                    End If
                Next
            End If
        Next
        For Each inuendo In digestiveTransitions
            If MessageForm.recentChatBotMessage.Contains(inuendo.Value) Then
                For Each word As String In refusalWords
                    If Input.Contains(word) Then
                        Response = "What do you want to do then?"
                    End If
                Next
                For Each word As String In affirmativeWords
                    If Input.Contains(word) Then
                        Response = digestiveInfo(inuendo.Key)
                        digestiveTransitions.Remove(inuendo.Key)
                        If Not digestiveTransitions.Count = 0 Then
                            Response = Response & vbNewLine & digestiveTransitions.ElementAt(generator.Next(0, digestiveTransitions.Count)).Value()
                        Else
                            Dim newTransition = funTransitions.ElementAt(generator.Next(0, funTransitions.Count)).Value()
                            Response = Response & vbNewLine & "You're gonna need time to digest all that info on the digestive system, it's all I had!" & vbNewLine & newTransition(generator.Next(0, newTransition.Count))
                        End If
                        Return Response
                        Exit Function
                    End If
                Next
            End If
        Next
        For Each inuendo In circulatoryTransitions
            If MessageForm.recentChatBotMessage.Contains(inuendo.Value) Then
                For Each word As String In refusalWords
                    If Input.Contains(word) Then
                        Response = "What do you want to do then?"
                    End If
                Next
                For Each word As String In affirmativeWords
                    If Input.Contains(word) Then
                        Response = circulatoryInfo(inuendo.Key)
                        circulatoryTransitions.Remove(inuendo.Key)
                        If Not circulatoryTransitions.Count = 0 Then
                            Response = Response & vbNewLine & circulatoryTransitions.ElementAt(generator.Next(0, circulatoryTransitions.Count)).Value()
                        Else
                            Dim newTransition = funTransitions.ElementAt(generator.Next(0, funTransitions.Count)).Value()
                            Response = Response & vbNewLine & "Heart's pumping, veins popping, arms heavy, out of circulatory information already!" & vbNewLine & newTransition(generator.Next(0, newTransition.Count))
                        End If
                        Return Response
                        Exit Function
                    End If
                Next
            End If
        Next
        For Each inuendo As String In learnTransitions
            If MessageForm.recentChatBotMessage.Contains(inuendo) Then
                For Each word As String In refusalWords
                    If Input.Contains(word) Then
                        Dim newTransition = funTransitions.ElementAt(generator.Next(0, funTransitions.Count)).Value()
                        Response = newTransition.ElementAt(generator.Next(0, newTransition.Count))
                    End If
                Next
                For Each word As String In affirmativeWords
                    If Input.Contains(word) Then
                        Dim newTransition = infoTransitions.ElementAt(generator.Next(0, infoTransitions.Count)).Value()
                        Response = newTransition.ElementAt(generator.Next(0, newTransition.Count)).Value()
                    End If
                Next
            End If
        Next
        For Each joke As String In jokes1
            If MessageForm.recentChatBotMessage.Contains(joke) Then
                Response = jokes2(jokes1.IndexOf(joke))
            End If
        Next
        For Each joke As String In jokes2
            If MessageForm.recentChatBotMessage.Contains(joke) Then
                Response = learnTransitions.ElementAt(generator.Next(0, learnTransitions.Count()))
            End If
        Next
        For Each funfact As String In funFacts
            If MessageForm.recentChatBotMessage.Contains(funfact) Then
                Response = learnTransitions.ElementAt(generator.Next(0, learnTransitions.Count()))
            End If
        Next
        Return Response
    End Function
End Class
