using System;
using static System.Console;

namespace Grading
{
    class Grading
    {
        static void Main()
        {
            DetermineGrade scoreA = new DetermineGrade();          
            scoreA.GetSetScore=(75.0f);
            
            WriteLine("\nA score of {0:f2} is a grade of {1}", scoreA.GetSetScore, scoreA.Result());

            WriteLine(scoreA);
            ReadKey();
        }      
    }
}
