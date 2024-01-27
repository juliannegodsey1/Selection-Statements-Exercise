namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favNumber = 14;
            bool guessedCorrectly = false;



            while (!guessedCorrectly)
            {
                Console.WriteLine("Guess my favorite number:");
                var userGuess = int.Parse(Console.ReadLine());

                if (userGuess < favNumber)
                {
                    Console.WriteLine("Sorry, the number you guessed is too low. Try again!");
                }
                else if (userGuess > favNumber)
                {
                    Console.WriteLine("Sorry, the number you guessed is too high. Try again!");
                }
                else
                {
                    Console.WriteLine("Congrats! You have correctly guessed my favorite number.");
                    guessedCorrectly = true;
                }
            }
        }
    }
}
