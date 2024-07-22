using System;
using static System.Console;

namespace ExamAverage
{
    class ExamAverage
    {
        static void Main()
        {
            // Variables
            float exam1 = 82.53f, exam2 = 90.66f, exam3 = 74.52f, exam4 = 88.71f, exam5 = 80.39f;
            // const becuase when program is running always has the same value, never change
            const int NUM_SCORES = 5;

            // table of details exams 
            WriteLine("\n\tExam Average");
            WriteLine();
            WriteLine("Exam 1: {0,8:f2}", exam1);
            WriteLine("Exam 2: {0,8:f2}", exam2);
            WriteLine("Exam 3: {0,8:f2}", exam3);
            WriteLine("Exam 4: {0,8:f2}", exam4);
            WriteLine("Exam 5: {0,8:f2}", exam5);
            WriteLine("-------------");
            // Avarage of exams
            WriteLine("Avarage: {0,7:f2}", (exam1 + exam2 + exam3 + exam4 + exam5) / NUM_SCORES);
            ReadKey();
        }
    }
}
