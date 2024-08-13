namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guessWord = "animal";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else { outOfGuesses = true; }
            }
            while(guess != guessWord && !outOfGuesses);

            if (outOfGuesses )
            {
                Console.WriteLine("You Lose!!");
            }
            else { Console.WriteLine("You Win!!"); }

        }
    }
}
