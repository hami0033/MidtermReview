using System;

namespace GPA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"\nHi {name}, what is your student ID number?");
            string studentid = Console.ReadLine();

            Console.WriteLine("What is your grade percentage in Accounting?");
            string answer = Console.ReadLine();
            double accounting;

            if (double.TryParse(answer, out accounting) == false)
            {
                Console.WriteLine($"Sorry, {answer} is not a valid grade percentage.. Exiting now.");
                Environment.Exit(-1);
            }

            Console.WriteLine("What is your grade percentage in Marketing?");
            answer = Console.ReadLine();
            double marketing;

            if (double.TryParse(answer, out marketing) == false)
            {
                Console.WriteLine($"Sorry, {answer} is not a valid grade percentage.. Exiting now");
                Environment.Exit(-1);
            }

            Console.WriteLine("What is your grade percentage in MIS?");
            answer = Console.ReadLine();
            double mis;

            while (double.TryParse(answer, out mis) == false)
            {
                
                    Console.WriteLine($"Sorry, {answer} is not a valid grade percentage.. Please try again");
                    answer = Console.ReadLine();
                
            }
            Console.WriteLine($"Great, {mis} is a valid grade percentage!");


            //if (double.TryParse(answer, out mis) == false)
            //{
            //    Console.WriteLine($"Sorry, {answer} is not a valid grade percentage.. Exiting now");
            //    Environment.Exit(-1);
            //}

            char accountinglettergrade, marketinglettergrade, mislettergrade;

            if (accounting>=90)
            {
                accountinglettergrade = 'A';
            }
            else if (accounting>=80)
            {
                accountinglettergrade = 'B';
            }
            else if (accounting >= 70)
            {
                accountinglettergrade = 'C';
            }
            else if (accounting >= 60)
            {
                accountinglettergrade = 'D';
            }
            else
            {
                accountinglettergrade = 'F';
            }
            //------------------
            if (marketing >= 90)
            {
                marketinglettergrade = 'A';
            }
            else if (accounting >= 80)
            {
                marketinglettergrade = 'B';
            }
            else if (accounting >= 70)
            {
                marketinglettergrade = 'C';
            }
            else if (accounting >= 60)
            {
                marketinglettergrade = 'D';
            }
            else
            {
                marketinglettergrade = 'F';
            }
            //------------------
            if (mis >= 90)
            {
                mislettergrade = 'A';
            }
            else if (mis >= 80)
            {
                mislettergrade = 'B';
            }
            else if (mis >= 70)
            {
                mislettergrade = 'C';
            }
            else if (mis >= 60)
            {
                mislettergrade = 'D';
            }
            else
            {
                mislettergrade = 'F';
            }

            Console.WriteLine($"Your letter grade for Accounting is {accountinglettergrade}");
            Console.WriteLine($"Your letter grade for Marketing is {marketinglettergrade}");
            Console.WriteLine($"Your letter grade for MIS is {mislettergrade}");
        }
    }
}
