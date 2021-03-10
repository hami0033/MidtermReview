using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of product would you like to purchase?");
            string item = Console.ReadLine();

            Console.WriteLine($"How many {item}'s would you like to purchase?");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"What is the price for each {item}?");
            double price = Convert.ToDouble(Console.ReadLine());

            const double PERCENT_TAX = .085;
            double subtotal = quantity * price;
            double salestax = subtotal * PERCENT_TAX;
            double total = subtotal + salestax;

            Console.WriteLine($"\tThe subtotal for your bill is {subtotal.ToString("C")}.");
            Console.WriteLine($"\tThe sales tax for your bill is {salestax.ToString("C")}.");
            Console.WriteLine($"\tThe total for your bill is {total.ToString("C")}.");

        }
    }
}
