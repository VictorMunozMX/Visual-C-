using System;
using static System.Console;

namespace BoxBuilder
{
    class BoxBuilder
    {
        static void Main()
        {
            // small method
            string theSmallBox = MakeSmallBox("0");
            WriteLine(theSmallBox);
            // medium method
            string theMediumBox = MakeMediumBox("0");
            WriteLine(theMediumBox);
            // big method
            string theBigBox = MakeBigBox("0");
            WriteLine(theBigBox);
            ReadKey();
        }

        static string MakeSmallBox(string theChart)
        {
            // variables const
            const string SPACE = " ";
            const string NEWLINE = "\n";

            // pattern
            string theBox = theChart + theChart + theChart + NEWLINE +
                            theChart + SPACE + theChart + NEWLINE +
                            theChart + theChart + theChart;
            return theBox;
        }

        static string MakeMediumBox(string theChart)
        {
            // variables const
            const string SPACE = " ";
            const string NEWLINE = "\n";

            // pattern
            string theBox = theChart + theChart + theChart + theChart + theChart + NEWLINE +
                            theChart + SPACE + SPACE + SPACE + theChart + NEWLINE +
                            theChart + SPACE + SPACE + SPACE + theChart + NEWLINE +
                            theChart + SPACE + SPACE + SPACE + theChart + NEWLINE +
                            theChart + theChart + theChart + theChart + theChart;
            return theBox;
        }

        static string MakeBigBox(string theChart)
        {
            // variables const
            const string SPACE = " ";
            const string NEWLINE = "\n";

            // pattern
            string theBox = theChart + theChart + theChart + theChart + theChart + theChart + theChart  + NEWLINE +
                            theChart + SPACE + SPACE + SPACE + SPACE + SPACE + theChart + NEWLINE +
                            theChart + SPACE + SPACE + SPACE + SPACE + SPACE + theChart + NEWLINE +
                            theChart + SPACE + SPACE + SPACE + SPACE + SPACE + theChart + NEWLINE +
                            theChart + SPACE + SPACE + SPACE + SPACE + SPACE + theChart + NEWLINE +
                            theChart + SPACE + SPACE + SPACE + SPACE + SPACE + theChart + NEWLINE +
                            theChart + theChart + theChart + theChart + theChart + theChart + theChart  + NEWLINE;
            return theBox;
        }
    }
}
