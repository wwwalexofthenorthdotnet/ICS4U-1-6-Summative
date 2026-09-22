using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICS4U_Topic_5._5
{
    public class Die
    {
        private int _sides;
        private int _roll;
        private ConsoleColor _colour;
        private Random _generator;

        public Die() // Default Properties
        {
            _generator = new Random();
            _sides = 6;
            _roll = _generator.Next(1, (_sides + 1));
            _colour = ConsoleColor.Red;

        }

        // Accessor Properties

        public int Roll
        {
            get { return _roll; }
            set { _roll = value; }
        }

        public ConsoleColor Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            _roll = _generator.Next(1, _sides + 1);
        }

        public Die(int sides)
        {
            _generator = new Random();
            _sides = sides;
            _roll = _generator.Next(1, (_sides + 1));
        }

        public void DrawRoll()
        {

            ConsoleColor currentForecolor = Console.ForegroundColor;


            Console.ForegroundColor = _colour;

            Console.WriteLine("-----");
            if (Roll == 1)
            {
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");

            }
            else if (Roll == 2)
            {
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");

            }
            else if (Roll == 3)
            {
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");

            }
            else if (Roll == 4)
            {
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");

            }
            else if (Roll == 5)
            {
                Console.WriteLine("|o o|");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");

            }
            else if (Roll == 6)
            {
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");

            }


            Console.WriteLine("-----");

            Console.ForegroundColor = currentForecolor;

        }




    }
}
