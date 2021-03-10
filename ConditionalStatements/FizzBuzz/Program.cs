using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_INFO = "Hannah Hamilton";
            Random rand = new Random();
            int randomNumberBetween1And100 = rand.Next(1, 101);
            randomNumberBetween1And100 = 15;

            if (randomNumberBetween1And100 % 3 == 0
             && randomNumberBetween1And100 % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");

            }
            else if (randomNumberBetween1And100 % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomNumberBetween1And100 % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine($"{randomNumberBetween1And100}");
            }

            Console.WriteLine($"Developed by {DEVELOPER_INFO}!");
        }
    }
}
