// Yes as all you can notice, I got way too over excited with this project, I'm just a HUGE cat fan!!!
using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();  // We're going to need this for our Random commands!!!
        Console.WriteLine("ITS CAT QUIZ TIME!");
        Console.WriteLine("Test your cat knowledge! Answer with A, B, or C.\n");

     

        // Questions!!
        string[] questions = {
            "How many hours do cats sleep per day?",
            "What's a group of cats called?",
            "What do cats use to 'taste' the air?",
            "What sound does a happy cat make?",
            "What's a baby cat called?"
        };

        // Answer options (each question has 3 choices!)
        string[] options = {
            "A) 4-6 hours\nB) 12-16 hours\nC) 20+ hours",
            "A) A pack\nB) A clowder\nC) A herd",
            "A) Their tongue\nB) Their paws\nC) The roof of their mouth",
            "A) Barking\nB) Purring\nC) Hissing",
            "A) A kitten\nB) A puppy\nC) A cub"
        };

        // Correct answers!
        string[] correctAnswers = { "B", "B", "C", "B", "A" };

        // Correct answer messages!!! 
        string[] correctMessages = {
    "CORRECT! You know cats!",
    "Correct!! Your cat(s) will love you! (if you adopt them)",
    "Correct!! You should apply to be a vet!",
    "Correct!! You should apply to be a cat yourself!!",
    "Correct!! You're allowed to pet."

};

        // Wrong answer messages ({0} = placeholder for correct answer!!!)
        string[] wrongMessages = {
    "Nope! The answer was {0}.",
    "*Swats* Your answer was incorrect!! The correct was {0}!",
    "Wrong! The correct answer was {0}. You have no right to pet the kittens!!",
    "Wrong! The correct answer was {0}. Get your cat book on!!!",
    "Wrong! The correct answer was {0}. The great feline Gods are looking down upon you!!!"
};

        // 100% Score messages!!!!!
        string[] perfectMessages = {
    "PURR-FECT! You're a cat expert!",
    "PURRFECT!! Have this virtual kitten!! \n   /\\_/\\ \n  ( o.o )  ← He's yours now!",
};

        // 60%+ Score messages!!!
        string[] goodMessages = {
    "Pretty good! You know your cats!",
    "Not bad! The Cat Council approves... mostly!",
    "Decent! Your local strays would let you pet them! (Maybe!)"
};

        // Below 60% messages!
        string[] badMessages = {
    "Time to study more cat facts!",
    "The cats are judging you... harshly!",
    "The Cat Council has REVOKED your petting privileges... for now!"
};
       // Score tracker!
        int score = 0;

      // Quiz mechanics!!
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Question {i + 1}: {questions[i]}");
            Console.WriteLine(options[i]);
            Console.Write("Your answer (A/B/C): ");

            // Get user answer + convert to UPPERCASE!!!
            string userAnswer = Console.ReadLine().ToUpper();

            // Check if correct!!!
            if (userAnswer == correctAnswers[i])
            {
                int correctIndex = rand.Next(correctMessages.Length);   // Searches for one of the messages in CorrectMessages
                Console.WriteLine(correctMessages[correctIndex]);      //And then displays it
                score++;
            }
            else
            {
                int wrongIndex = rand.Next(wrongMessages.Length);

                // Fill in {0} with the correct answer!!
                string message = String.Format(wrongMessages[wrongIndex], correctAnswers[i]);
                Console.WriteLine(message);
            }

            Console.WriteLine($"Correct answers: {score}\n");
        }

       
       
        // FINAL RESULTS!!!!!!
        
        Console.WriteLine("\n QUIZ COMPLETE!");
        Console.WriteLine($"Final Score: {score}/{questions.Length}");

        double percentage = (double)score / questions.Length * 100;
        Console.WriteLine($"That's {percentage}%!\n");

        string[] resultMessages;   

        if (percentage == 100)
        {
            resultMessages = perfectMessages;   // Point to perfect (or shall I say: "Purrfect") array!!!!
        }
        else if (percentage >= 60)
        {
            resultMessages = goodMessages;     // Point to good array!!!
        }
        else
        {
            resultMessages = badMessages;     // Point to bad array!!
        }

        // Pick a RANDOM message from the chosen array!
        int resultIndex = rand.Next(resultMessages.Length);
        Console.WriteLine(resultMessages[resultIndex]);
    }
}
