using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace complete
{
    class complete
    {
        static void Main(string[] args)
        {
            testAbs cal = new testAbs();
            cal.DimenB = 10;
            cal.DimenT = 50;

            WriteLine(cal.Area());
            ReadKey();
        }
    }
}
