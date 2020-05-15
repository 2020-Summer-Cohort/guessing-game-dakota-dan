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
            else if (number == 0)
            {
                Console.WriteLine("Pick a number, and if you guess correctly, you win! Enter -1 to exit.");
            }
            else if (number == -1)
            {
                Console.WriteLine("Thanks for playing!");
            }
            else
            {
                Console.WriteLine("Sorry, wrong number.");
                Console.WriteLine("Try one more time");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 7)
                {
                    Console.WriteLine("You're a winner!");
                }
                else
                {
                    Console.WriteLine("Sorry, wrong number.");
                }
            }
        }
    }
}
