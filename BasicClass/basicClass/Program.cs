using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace basicClass
{
    class Program
    {
        static void Main(string[] args)
        {

            medidas var = new medidas();
            var.heigth = 5;
            var.width  = 5;

            circle cir = new circle();
            cir.radio  = 10;
            cir.width  = 2;
            cir.heigth = 5;

            WriteLine(var);
            WriteLine(cir);
            ReadKey();
        }

    }
}
