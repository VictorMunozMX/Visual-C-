using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace camosun
{
    class Program
    {
        static void Main(string[] args)
        {
            imd student = new imd("c0523704","Victor","Munoz",2);
            Courses mat = new Courses("c0529898", "Frank", "Tejeda", 2, "Math-156", 85);
            
            WriteLine(student);

            WriteLine("\n" + mat);

            ReadKey();
        }
    }
}
