using System;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a minimum value.");
            string answer = Console.ReadLine();
            int minimum;

            while (int.TryParse(answer, out minimum) == false)
            {
                Console.WriteLine($"Sorry, {minimum} is not a valid input for minimum, please try again.");
            }

            Console.WriteLine("Choose a maximum value.");
            answer = Console.ReadLine();
            int maximum;

            while (int.TryParse(answer, out maximum) == false)
            {
                Console.WriteLine($"Sorry, {maximum} is not a valid input for minimum, please try again.");

                if (int.TryParse(answer, out maximum) == true)
                {

                }
            }

            Random rand = new Random();
            int randomnbr = rand.Next(minimum, maximum);
            Console.WriteLine($"\nGuess a number between {minimum} and {maximum}.");
            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != randomnbr)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Your guess is incorrect, try again till you guess the magic number.\n");
                Console.ForegroundColor = ConsoleColor.White;
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == randomnbr)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congrats! {randomnbr} is correct!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }




        }
    }
}
