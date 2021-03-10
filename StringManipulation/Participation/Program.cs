using System;

namespace Participation
{
    class Program
    {
        static string MESSAGE = "Programming today is a race between software " +
            "engineers striving to build bigger and better idiot-proof program, and the universe" +
            " trying to build bigger and better idiots.So far, the universe is winning.";
        static void Main(string[] args)

        {
            Console.WriteLine($"{MESSAGE}");
            Console.WriteLine("What word would you like to search for?");
            string find = Console.ReadLine();

            Console.WriteLine($"What word would you like to replace {find} with?");
            string replace = Console.ReadLine();

            if (MESSAGE.Contains(find))
            {
                string newquote = MESSAGE.Replace(find, replace);
                Console.WriteLine(newquote);
            }
            else
            {
                Console.WriteLine($"Sorry, I could not find your word {find}.");

                string reversefind = string.Empty;
                for (int i = find.Length - 1; i >= 0; i--)
                {
                    reversefind = reversefind + find[i];
                    
                }
                Console.WriteLine($"{reversefind}");

            }

        }
    }
}
