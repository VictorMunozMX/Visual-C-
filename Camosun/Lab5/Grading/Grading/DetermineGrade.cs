using System;
using static System.Console;

namespace Grading
{
    class DetermineGrade
    {
        // members
        private float score;    

        // default constructor
        public DetermineGrade() 
        { 
        }
        // constructor with score
        public DetermineGrade(float scoreAlumn) 
        {
            score = scoreAlumn;       
        }

        // Accessor and mutators
        public float GetSetScore
        {
            get { return score; }
            set { score = value; }
        }

        // Methods
        public string Result() {
            string letterGrade = "F";
            if (score >= 90)
            {
                letterGrade = "A";
            }
            if (score >= 80 && score < 90)
            {
                letterGrade = "B";
            }
            if (score >= 70 && score < 80)
            {
                letterGrade = "C";
            }
            if (score >= 60 && score < 70)
            {
                letterGrade = "D";
            }
            return letterGrade;
        }

        public override string ToString()
        {
            return "\nA score of " + score + " is a grade of " + Result();
        }

    }
}
