namespace GuessingGame
{
    internal class Program
    {
      
        
        
    

        

        static void Main(string[] args)
        {
            Random random = new Random();


            int randomNumber = random.Next(1, 101);
            //if (randomNumber == 100) Console.WriteLine("I found 100")

            AskQuestion("I'm thinking of a number from 0 to 100. Try to guess it!", randomNumber);
            
            
        }

        static void AskQuestion(string question, int answer)
        {
            Console.Write(question);
            int intGuess = 0;
            int counter = 0;


            while (intGuess != answer) 
            {
               
                string guess = Console.ReadLine();
                int.TryParse(guess, out intGuess);

                if (intGuess > answer)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Too high!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    
                }
                else if (intGuess < answer)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Too low! ");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    
                }
                
                else
                {
                    break;
                }
                Console.WriteLine($"{guess} is not the correct Answer. Please try again");
                Console.WriteLine();
                counter++;

            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You Win!");
            Console.Write($"You guessed {counter} times");
            Console.ResetColor();
        }


    }


    
}