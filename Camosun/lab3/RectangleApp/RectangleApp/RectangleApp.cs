using System;
using static System.Console;

namespace RectangleApp
{
    class RectangleApp
    {
        static void Main()
        {
            // variables
            double height, width, area, perimeter;

            WriteLine();

            // call methods
            height = GetHeight();
            width = GetWidth();

            // obtain area and perimeter
            area = ComputeArea(height, width);
            perimeter = ComputePerimeter(height, width);

            // show results
            DisplayResults(height, width, area, perimeter);
        }

        // read the heigth
        static double GetHeight() {
            string inValue;
            double h;
            Write("Enter the Height: ");
            inValue = ReadLine();
            h = double.Parse(inValue);
            return h;
        }

        // read the width
        static double GetWidth()
        {
            string inValue;
            double w;
            Write("Enter the Width: ");
            inValue = ReadLine();
            w = double.Parse(inValue);
            return w;
        }

        // calculate the area
        static double ComputeArea(double rectHeight, double rectWidth) {
            return (rectHeight * rectWidth);
        }

        // calculate the perimeter
        static double ComputePerimeter(double rectHeight, double rectWidth)
        {
            return 2 * (rectHeight + rectWidth);
        }

        // Show results
        static void DisplayResults(double h, double w, double a, double p) {
            WriteLine("\n\nSummary of Rectangule Measurements");
            WriteLine();
            WriteLine("Height: {0,13:f2}", h);
            WriteLine("Width: {0,14:f2}", w);
            WriteLine("Area: {0,15:f2}", a);
            WriteLine("Perimeter: {0,10:f2}", p);
            WriteLine("\nEnter to end App...");
            ReadKey();
        }

    }
}
