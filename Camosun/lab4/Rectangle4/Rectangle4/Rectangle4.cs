using System;
using static System.Console;

namespace Rectangle4
{
    class Rectangle4
    {
        static void Main()
        {
            // constructors
            Rectangle rect1 = new Rectangle();
            // mut
            rect1.Height=(3.2f);
            rect1.SetWidth(3.2f);
            // methods
            rect1.ComputeArea();
            rect1.ComputePerimeter();
            rect1.isSquare();
            // on screen
            WriteLine("\nCalculate Area and Perimeter about a Rectangle using \"Classes\"\n");            
            WriteLine(rect1);
            ReadKey();
        }
    }
}
