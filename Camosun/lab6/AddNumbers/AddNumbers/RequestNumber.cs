using System;
using static System.Console;

namespace AddNumbers
{
    class RequestNumber
    {
        private int number;        

        public RequestNumber()
        {
        }     

        public int NumberSum 
        {
            get { return number; }           
        }

        public int GetData()
        {
            string line;            
            Write("Enter number: (-99 to stop) ");

            line = ReadLine();
            while (int.TryParse(line, out number) == false)
            {
                Write("Oops !Invalid number found. Enter number: (-99 to stop) ");
                line = ReadLine();
            }
            return number;
        }
    }
}
