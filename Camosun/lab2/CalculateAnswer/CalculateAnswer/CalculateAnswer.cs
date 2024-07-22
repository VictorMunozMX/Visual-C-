using System;
using static System.Console;

namespace CalculateAnswer
{
    class Program
    {
        static void Main()
        {
            const int INCHES = 12;
            int x = 100, y = 10;
            float z = 22.45f;
            double ans;
            ans = INCHES + z * x % y;
            WriteLine("\n\tThe result is {0:F2} ", ans);
            ReadKey();
        }
    }
}
