namespace LOTR_Trivia
{      

        class TriviaGame
        {
            static void Main(string[] args)
            {
                TriviaGame.AskQuestion("Who is the main Hobbit in the Lord of the Rings?", "Frodo", 5, "You're Late!");
            TriviaGame.AskQuestion("Who is the main Wizard in the Lord of the Rings?", "Gandalf", 5, "A wizard is never late, nor early. He arrives precisely when he means to.");

            TriviaGame.AskQuestion("Who is the main Dwarf in the Lord of the Rings?", "Gimli", 5, "Never thought I'd die fighting side by side with an elf.");

                

                TriviaGame.AskQuestion("Who is the main Elf in the Lord of the Rings", "Legolas", 5, "What about side by side with a friend");

                TriviaGame.AskQuestion("Who is the main Human in the Lord of the Rings", "Aragorn", 5, (@"One ring to rule them all, one ring to find them, one ring to bring them all and in the darkness bind them"));


            }

            static void AskQuestion(string question, string correctAnswer, int maxAttempts, string response)
            {
                Console.WriteLine(question);

                for (int attempt = 1; attempt <= maxAttempts; attempt++)
                {
                    Console.Write($"Guess {attempt}: ");
                    string userAnswer = Console.ReadLine();

                    if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Alas! {response}"); 
                        return;
                    }
                    else
                    {
                        Console.WriteLine("YOU SHALL NOT PASS!");
                    }
                }

                Console.WriteLine($"Tricksy. We knows the answer was {correctAnswer}.");
            }
        }

    

}