using ICS4U_Topic_5._5;
using System;
using System.CodeDom;
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
            string betChoice = "";
            double bal = 100.00;
            double bet = 0.00;

            bool finish = false;

            Die die1 = new Die();
            Thread.Sleep(100);
            Die die2 = new Die();

            while (!finish)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                bet = 0;

                

                Console.WriteLine("Welcome to the Great Dice Casino Game Placetopia!");
                Console.WriteLine();
                Console.WriteLine($"Balance : ${Math.Round(bal, 2)}");
                Console.WriteLine();
                Console.Write($"Input your BET or \"0\" to exit : $");

                if (double.TryParse(Console.ReadLine(), out bet))
                {
                    if (bet == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Console.Clear();
                        Console.WriteLine("Thank you for playing!");
                        Console.WriteLine("       .---.\r\n  ___ /_____\\\r\n /\\.-`( '.' )\r\n/ /    \\_-_/_\r\n\\ `-.-\"`'V'//-.\r\n `.__,   |// , \\\r\n     |Ll //Ll|\\ \\\r\n     |__//   | \\_\\\r\n    /---|[]==| / /\r\n    \\__/ |   \\/\\/\r\n    /_   | Ll_\\|\r\n     |`^\"\"\"^`|\r\n     |   |   |\r\n     |   |   |\r\n     |   |   |\r\n     |   |   |\r\n     L___l___J\r\n jgs  |_ | _|\r\n     (___|___)\r\n      ^^^ ^^^\r\n");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to EXIT");
                        Console.ReadKey();
                        finish = true;
                    }
                    else if (bal < bet || bet < 0)
                    {
                        Console.WriteLine("Error - Bet can not be greater than balance or less than 0");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to EXIT");
                        Console.ReadKey();
                    }
                    else
                    {

                        Console.Clear();
                        Console.WriteLine("Which outcome would you like to bet on? \n 1. Doubles \n 2. Not Doubles \n 3. Even SUM \n 4. Odd SUM \n 5. Sum of 7");

                        Console.Write("Choice : ");
                        betChoice = Console.ReadLine();

                        Console.Clear();

                        if (betChoice.Trim() == "1" || betChoice.Trim() == "2" || betChoice.Trim() == "3" || betChoice.Trim() == "4" || betChoice.Trim() == "5" || betChoice.ToLower().Trim() == "doubles" || betChoice.ToLower().Trim() == "not doubles" || betChoice.ToLower().Trim() == "even sum" || betChoice.ToLower().Trim() == "odd sum" || betChoice.ToLower().Trim() == "sum of 7")
                        {
                            die1.RollDie();
                            die2.RollDie();

                            die1.DrawRoll();
                            die2.DrawRoll();

                            if (betChoice.ToLower().Trim() == "1" || betChoice.ToLower().Trim() == "doubles")
                            {
                                if (die1.Roll == die2.Roll)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;

                                    bet = bet + bet * 2;

                                    Console.WriteLine("You rolled a DOUBLE!");
                                    Console.WriteLine($"You gained ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal + bet;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;


                                    Console.WriteLine("You DID NOT roll a DOUBLE!");
                                    Console.WriteLine($"You lost ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal - bet;
                                }

                            }
                            else if (betChoice.ToLower().Trim() == "2" || betChoice.ToLower().Trim() == "not doubles")
                            {
                                if (die1.Roll != die2.Roll)
                                {
                                    bet = bet * 0.5;

                                    Console.ForegroundColor = ConsoleColor.Green;


                                    Console.WriteLine("You DID NOT roll a double!");
                                    Console.WriteLine($"You gained ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal + bet;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;


                                    Console.WriteLine("You rolled a double? UNLUCKY!");
                                    Console.WriteLine($"You lost ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal - bet;
                                }

                            }
                            else if (betChoice.ToLower().Trim() == "3" || betChoice.ToLower().Trim() == "even sum")
                            {
                                if (die2.Roll - die1.Roll == 0)
                                {
                                    bet = bet * 2;

                                    Console.ForegroundColor = ConsoleColor.Green;


                                    Console.WriteLine("You rolled an even sum!");
                                    Console.WriteLine($"You gained ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal + bet;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;


                                    Console.WriteLine("You rolled an odd sum! UNLUCKY!");
                                    Console.WriteLine($"You lost ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal - bet;
                                }

                            }
                            else if (betChoice.ToLower().Trim() == "4" || betChoice.ToLower().Trim() == "odd sum")
                            {
                                if (die2.Roll - die1.Roll != 0)
                                {
                                    bet = bet * 2;

                                    Console.ForegroundColor = ConsoleColor.Green;


                                    Console.WriteLine("You rolled an odd sum!");
                                    Console.WriteLine($"You gained ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal + bet;
                                }
                                else
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;

                                    Console.WriteLine("You rolled an even sum! UNLUCKY!");
                                    Console.WriteLine($"You lost ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal - bet;
                                }

                            }
                            else if (betChoice.ToLower().Trim() == "5" || betChoice.ToLower().Trim() == "sum of 7")
                            {
                                if (die2.Roll + die1.Roll == 7)
                                {
                                    bet = bet * 7;

                                    Console.ForegroundColor = ConsoleColor.Green;


                                    Console.WriteLine("You rolled a sum of 7!");
                                    Console.WriteLine($"You gained ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal + bet;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;


                                    Console.WriteLine("You DID NOT roll a sum of 7! UNLUCKY!");
                                    Console.WriteLine($"You lost ${bet}!");
                                    Console.WriteLine();
                                    Console.WriteLine("Press any key to EXIT");
                                    Console.ReadKey();

                                    bal = bal - bet;
                                }

                            }

                            Console.Clear();


                            if (bal <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;

                                Console.Clear();
                                Console.WriteLine("Thank you for playing! Come back with more MONEY!");
                                Console.WriteLine("       .---.\r\n  ___ /_____\\\r\n /\\.-`( '.' )\r\n/ /    \\_-_/_\r\n\\ `-.-\"`'V'//-.\r\n `.__,   |// , \\\r\n     |Ll //Ll|\\ \\\r\n     |__//   | \\_\\\r\n    /---|[]==| / /\r\n    \\__/ |   \\/\\/\r\n    /_   | Ll_\\|\r\n     |`^\"\"\"^`|\r\n     |   |   |\r\n     |   |   |\r\n     |   |   |\r\n     |   |   |\r\n     L___l___J\r\n jgs  |_ | _|\r\n     (___|___)\r\n      ^^^ ^^^\r\n");
                                Console.WriteLine();
                                Console.WriteLine("Press any key to EXIT");
                                Console.ReadKey();
                                finish = true;
                            }

                            bet = 0;
                            betChoice = "";

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid Choice");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to EXIT");
                            Console.ReadKey();

                        }


                        

                        

                    }
                }



            }


            


        }
    }
}
