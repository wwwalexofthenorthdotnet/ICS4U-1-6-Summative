using ICS4U_Topic_5._5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICS4U_1_6_Summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bal = 100.00;
            double bet = 0.00;

            bool finish = false;

            Die die1 = new Die();
            Thread.Sleep(100);
            Die die2 = new Die();

            while (!finish)
            {
                Console.Clear();
                bet = 0;

                Console.WriteLine("Welcome to the Great Dice Casino Game Placetopia!");
                Console.WriteLine();
                Console.WriteLine($"Balance : ${Math.Round(bal, 2)}");
                Console.WriteLine();
                Console.Write($"Input your BET : $");

                if (double.TryParse(Console.ReadLine(), out bet))
                {
                    if (bal < bet)
                    {
                        Console.WriteLine("Error - Bet can not be greater than balance");
                        Console.ReadKey();
                    }
                    else
                    {

                        die1.RollDie();
                        die2.RollDie();

                        die1.DrawRoll();
                        die2.DrawRoll();

                        if (die1.Roll == die2.Roll)
                        {
                            Console.WriteLine("You rolled a DOUBLE!");

                            bet = bet * 2;

                            Console.WriteLine($"You have gained ${Math.Round(bet, 2)}! That's double your bet!");

                            Console.WriteLine();

                            Console.WriteLine("Press any key to EXIT");

                            Console.ReadKey();
                        }
                        else if (die2.Roll - die1.Roll == 0)
                        {
                            Console.WriteLine("You rolled an EVEN SUM!");

                            bet = bet + bet * 0.5;

                            Console.WriteLine($"You have gained ${Math.Round(bet, 2)}! That's 1.5x your bet!");

                            Console.WriteLine();

                            Console.WriteLine("Press any key to EXIT");

                            Console.ReadKey();
                        }
                        else if (die2.Roll - die1.Roll == 1)
                        {
                            Console.WriteLine("You rolled an ODD SUM!");

                            bet = bet * 0.5;

                            Console.WriteLine($"You have gained ${Math.Round(bet, 2)}! That's HALF your bet!");

                            Console.WriteLine();

                            Console.WriteLine("Press any key to EXIT");

                            Console.ReadKey();
                        }
                        else if (die1.Roll == 1 && die2.Roll == 1)
                        {
                            Console.WriteLine("You rolled SNAKE EYES!");

                            bet = bet * 0;

                            Console.WriteLine($"You have gained ${Math.Round(bet, 2)}! That's NONE of your bet!");

                            Console.WriteLine();

                            Console.WriteLine("Press any key to EXIT");

                            Console.ReadKey();
                        }

                        bal = bal + bet;


                    }
                }
                else
                {
                    Console.WriteLine("Error - Valid numerical input required");
                    Console.ReadKey();
                }

                Console.Clear();

                
            }


            


        }
    }
}
