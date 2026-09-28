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

                        Console.Clear();
                        Console.WriteLine(@"Which outcome would you like to bet on?
1. Doubles
2. Not Doubles
3. Even SUM
4. Odd SUM
5. Sum of 7");

                        Console.ReadKey();

                        die1.RollDie();
                        die2.RollDie();

                        die1.DrawRoll();
                        die2.DrawRoll();

                    }
                }

                
            }


            


        }
    }
}
