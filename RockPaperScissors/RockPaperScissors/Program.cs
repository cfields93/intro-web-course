using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int uWin = 0, cpuWin = 0, tie = 0;
            int x;
            Random random = new Random();
            string again = "y";
            Console.WriteLine("Let's play Rock Paper Scissors.");
            while (again == "y")
            {
                Console.Write("How many rounds would you like to play? (1 - 10) ");
                int rounds = int.Parse(Console.ReadLine());


                if (rounds <= 10 && rounds > 0)
                {



                    for (int i = 1; i <= rounds; i++)
                    {
                        Console.WriteLine("Pick an option:");
                        Console.WriteLine("  1) Rock      2) Paper      3) Scissors");
                        x = int.Parse(Console.ReadLine());
                        int y = random.Next(1, 4);

                        if (x == y)
                        {
                            Console.WriteLine("It's a TIE!");
                            tie++;
                        }
                        else if (x == 1 && y == 3)
                        {
                            Console.WriteLine("You WIN!");
                            uWin++;
                        }
                        else if (x == 2 && y == 1)
                        {
                            Console.WriteLine("You WIN!");
                            uWin++;
                        }
                        else if (x == 3 && y == 2)
                        {
                            Console.WriteLine("You WIN!");
                            uWin++;
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry you loose.");
                            cpuWin++;
                        }
                    }
                    Console.WriteLine($"Your total wins: {uWin}");
                    Console.WriteLine($"Computer total wins: {cpuWin}");
                    Console.WriteLine($"Total ties: {tie}");
                    if (uWin > cpuWin)
                    {
                        Console.WriteLine("You are the overall winner!");
                    }
                    else if (uWin < cpuWin)
                    {
                        Console.WriteLine("The computer is the overall winner");
                    }
                    else
                    {
                        Console.WriteLine("It was an overall tie.");
                    }
                    Console.Write("Would you like to play again? (y/n) ");
                    again = Console.ReadLine();
                }
            
                else
                {
                Console.WriteLine("That is not a valid input.");
                }
            }


            Console.ReadLine();
        }
    }
}
