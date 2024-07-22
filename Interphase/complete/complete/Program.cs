using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace complete
{
    class Program
    {
        static void Main(string[] args)
        {
            // instance the class
            box figure = new box();

            // asign a value 
            figure.dimention = 5;
           
            // call the method
            WriteLine(figure.area());

            ReadKey();
        }
    }
}
