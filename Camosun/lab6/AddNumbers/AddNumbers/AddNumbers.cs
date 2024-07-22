using System;
using static System.Console;

namespace AddNumbers
{
    class AddNumbers
    {
        static void Main()
        {
            int sum = 0;
            const int SENTINEL = -99;
            
            RequestNumber num = new RequestNumber();

            int number = num.GetData();
            while (number != SENTINEL)
            {                                
                sum = sum + number;
                number = num.GetData();
            }

            WriteLine("Your sum is: {0}",sum);
            WriteLine("Press any key to continue....");
            ReadKey();            
        }

    }
}
