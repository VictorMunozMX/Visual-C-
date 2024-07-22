using System;
using static System.Console;

namespace BoxMaker
{
    class Box
    {
        private string ch;
        private int number;

        public Box()
        {
        }
        public Box(string c, int n)
        {
            ch = c;
            number = n;
        }

        public string symbol
        {
            set { ch = value; }
        }
        public int Number
        {
            set { number = value; }
        }

        public string Caja() 
        {
            // create the box
            WriteLine("Here is your box...");
            for (int row = 0; row < number; row++)
            {
                for (int column = 0; column < number; column++)
                {
                    Write(ch);
                }
                WriteLine("");
            }
            return "";
        }
    }
}
