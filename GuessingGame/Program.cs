using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Guessing Game!");
            Console.WriteLine("Pick a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 7)
            {
                Console.WriteLine("You're a winner!");
            }
            else
            {
                Console.WriteLine("Sorry, wrong number");
            }
        }
    }
}
