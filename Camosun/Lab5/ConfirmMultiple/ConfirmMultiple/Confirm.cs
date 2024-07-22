using System;
using static System.Console;

namespace ConfirmMultiple
{
    class Confirm
    {
        // membars
        private int numberA, numberB;
        // constructors
        public Confirm()
        {
        }
        public Confirm(int a, int b)
        {
            numberA = a;
            numberB = b;
        }
        // acc and mut
        public int NumberOne
        {
            get { return numberA; }
            set { numberA = value; }
        }
        public int NumberTwo
        {
            get { return numberB; }
            set { numberB = value; }
        }
        // Methods
        // enter values and valid an int
        public void CheckValues()
        {
            string inValue;

            Write("\nEnter the first number: ");
            inValue = ReadLine();

            if (int.TryParse(inValue, out numberA) == false)
            {
                WriteLine("You need to enter a number...!!!");
            }

            Write("Enter the second number: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out numberB) == false)
            {
                WriteLine("You need to enter a number...!!!");
            }
        }
        // calculate if is a multiple
        public bool Multiple(int numberA, int numberB)
        {
            if ((numberB % numberA) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
