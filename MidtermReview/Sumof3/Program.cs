using System;

namespace Sumof3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers.");
            Console.WriteLine("Enter your first number.");
            double firstnumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second number.");
            double secondnumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your third number.");
            double thirdnumber = Convert.ToDouble(Console.ReadLine());

            double sum = firstnumber + secondnumber + thirdnumber;
            Console.WriteLine($"The sum of your three numbers is {sum.ToString("n3")}");

            const double MULTIPLIER = 7.777;
            double multiplied = sum * MULTIPLIER;
            Console.WriteLine($"Your sum times the magic number is {multiplied.ToString("n3")}");
        }
    }
}
