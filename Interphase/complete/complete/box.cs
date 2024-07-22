using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complete
{
    class box:IBox
    {
        private int lado;

        public box() { }
        public box(int l) 
        { 
            lado = l;
        }

        public int dimention
        {
            get { return lado; }
            set { lado = value; }
        }

        public int area()
        {
            return lado * lado;
        }

        public override string ToString()
        {
            return "El area de tu cuadrado es: " + area();
        }
    }
}

interface IBox
{
    int area();
}
