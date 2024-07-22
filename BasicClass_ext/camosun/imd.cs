using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Console;

namespace camosun
{
    class imd
    {
        private protected string cnumber;
        private string fName;
        private string lname;
        private int term;

        // constructor
        public imd() { }
        public imd(string cn, string fn, string ln, int tr)
        {
            cnumber = cn;
            fName = fn;
            lname = ln;
            term = tr;
        }

        /*
        public string cNum
        {
            get { return cnumber; }
            set { cnumber = value; }
        }*/

        public override string ToString()
        {
            return "Hi, your c# is: " + cnumber +
                "\nYour full name is: " + fName + " " + lname +
                "\nYou are in term: " + term;
        }        
    }

    class Courses : imd
    {
        private string course;
        private int score;

        public Courses():base() { }
        public Courses(string c1, string c2, string c3, int x1, string mat, int scor) : base(c1, c2, c3, x1)
        {
            course= mat;
            score = scor;
        }

        public override string ToString()
        {
            return "Class parent:" + base.ToString() + "\n"+
                "Your course: " + course + " and your grade is: " + score + 
                ", C-number: " + cnumber;
            // para usar una variable del padre, necesito hacerla protected en su declaracion
        }
    }

}
