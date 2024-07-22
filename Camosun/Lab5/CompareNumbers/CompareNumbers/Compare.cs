using System;
using static System.Console;

namespace CompareNumbers
{
    class Compare
    {
        private int number;

        public Compare()
        {
        }
        public Compare(int num)
        {
            number = num;
        }

        public int Numbers
        {
            get { return number; }
            set { number = value; } 
        }

        public int NumberNo(int no)
        {
            string inVal;
            int n;
            Write("Enter the number " + no + ": ");
            inVal = ReadLine();
            int.TryParse(inVal, out n);
            return n;
        }

        public string CompareValues(int a, int b, int c)
        {
            string res = "";
            // equals values
            if (a == b && b == c)
            {
                res = "all the same.";
            }
            // differents values
            if (a != b && b != c)
            {
                res = "all different.";
            }
            // two values match
            if (a == b && a != c)
            {
                res = "two numbers macth.";
            }
            else
            {
                if (a == c && a != b)
                {
                    res = "two numbers macth.";
                }
            }
            if (b == a && b != c)
            {
                res = "two numbers macth.";
            }
            else
            {
                if (b == c && b != a)
                {
                    res = "two numbers macth.";
                }
            }
            if (c == a && c != b)
            {
                res = "two numbers macth.";
            }
            else
            {
                if (c == b && c != a)
                {
                    res = "two numbers macth.";
                }
            }
            return res;
        }
    }
}
