using System;
using static System.Console;

namespace CircleApp
{
    class CircleApp
    {
        static void Main(string[] args)
        {
            // variables
            double radius, area, circumference;            

            // ask for the radius value
            Write("Enter the circle radius: ");
            radius = double.Parse(ReadLine());

            // calculate the area
            area = ComputeArea(radius);

            // calculate the circumference
            circumference = ComputeCircumference(radius);

            // dispalys the values area and circumference
            WriteLine("Circle area is: {0,2:f}",area);
            WriteLine("Circle circumference is: {0,2:f}", circumference);

            // pause to show the results
            WriteLine("Press any key to continue...thanks");
            ReadKey();
        }

        // methos to calculare the area
        static double ComputeArea(double rad)
        {            
            const double PI = 3.1416;
            double result = 0;

            result = PI * Math.Pow(rad, 2);
            return result;
        }

        // methos to calculare the circumference
        static double ComputeCircumference(double rad)
        {
            const double PI = 3.1416;
            double result = 0;

            result = 2 * PI * rad;
            return result;
        }
    }
}
