using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to: rock paper scissors.");
            Console.WriteLine("Please choose: [1] Rock, [2] Paper or [3] Scissors");
            string input = Console.ReadLine();

            Random rnd = new Random();
            int opponent = rnd.Next(1, 3);

            if(opponent == 1)
            {
                Console.WriteLine("Opponent: Rock");
            }

            else if (opponent == 1)
            {
                Console.WriteLine("Opponent: Paper");
            }

            else
            {
                Console.WriteLine("Opponent: Scissors");
            }

            if (input == "1")
            {
                if(opponent == 1)
                {
                    Console.WriteLine("It's a draw!");
                }

                else if(opponent == 2)
                {
                    Console.WriteLine("You lost!");
                }

                else
                {
                    Console.WriteLine("You Won!");
                }
            }

            if (input == "2")
            {
                if (opponent == 2)
                {
                    Console.WriteLine("It's a draw!");
                }

                else if (opponent == 3)
                {
                    Console.WriteLine("You lost!");
                }

                else
                {
                    Console.WriteLine("You Won!");
                }
            }

            if (input == "3")
            {
                if (opponent == 3)
                {
                    Console.WriteLine("It's a draw!");
                }

                else if (opponent == 1)
                {
                    Console.WriteLine("You lost!");
                }

                else
                {
                    Console.WriteLine("You Won!");
                }
            }
        }
    }
}
