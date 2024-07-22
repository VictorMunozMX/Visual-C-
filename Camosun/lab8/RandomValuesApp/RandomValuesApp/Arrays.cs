using System;
using static System.Console;

namespace RandomValuesApp
{
    class Arrays
    {
        private int[,] array;

        public Arrays()
        {
        }

        public Arrays(int[,] arr)
        {
            array = arr;
        }

        public int[,] Values
        {
            get { return array; }
            set { array = value; }
        }

        public int[,] GetValues()
        {
            Random num = new Random();
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                {
                    array[x, y] = num.Next(100);
                }
            }
            return array;
        }

    }
}
