using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

public abstract class calculate
{
    public abstract int Area();
}

namespace complete
{
    public class testAbs: calculate
    {
        private int bottom;
        private int top;

        public testAbs() { }
        public testAbs(int b, int t) { 
            bottom = b;
            top = t;
        }

        public int DimenB
        {
            get { return bottom; }
            set { bottom = value; }
        }
        public int DimenT
        { 
            get { return top; } 
            set { top = value; } 
        }

        public override int Area()
        { 
            return bottom * top; 
        }

        public override string ToString()
        {
            return "El area de tu rectangulo es: " + Area();
        }
    }
}
