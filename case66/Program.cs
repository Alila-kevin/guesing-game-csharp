internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int attempts = 0;
        int guess = 0;

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100.");
        Console.WriteLine("Can you guess it?");

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            attempts++;

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low. Try again!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high. Try again!");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the number correctly!");
                Console.Write("email: alilakevin4@gmail.com to get you $10 prize");
                Console.Write("it is you lucky day");
                Console.WriteLine("Number of attempts: " + attempts);
                Console.Write("Play again and more prizes like this");
            }
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
