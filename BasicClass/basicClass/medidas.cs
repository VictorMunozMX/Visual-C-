using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicClass
{
    class medidas
    {
        private int b;
        private int a;

        public medidas()
        {
        }

        public medidas(int vb, int va)
        {
            this.b = vb;
            this.a = va;
        }

        public int heigth{
            get { return this.a; }
            set { this.a = value; }
        }
        public int width{
            get { return this.b; }
            set { this.b = value; }
        }

        public int area()
        {
            int r = a * b;
            return r;
        }

        public int per() {
            int r = a + 1;
            return r;
        }

        public override string ToString()
        {
            return "El area es de " + area() + " y el perimetro de " + per() ;
        }
    }

    class circle: medidas
    {
        public int r;

        public circle() :base() { }

        public circle(int vr)
        {
            this.r = vr;
        }

        public int radio
        {
            get { return r; }
            set { r = value; }
        }

        public int cRadio()
        {
            int re = r * 2;
            return re;
        }

        public override string ToString()
        {
            return "la circunferencia es " + cRadio() + " " + base.ToString();
        }
    }
}
