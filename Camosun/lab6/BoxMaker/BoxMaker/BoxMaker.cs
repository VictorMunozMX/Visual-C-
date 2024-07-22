using System;
using static System.Console;

namespace BoxMaker
{
    class BoxMaker
    {
        static void Main()
        {
            // variables
            string line,ch;
            int boxSize;
            
            // enter data
            Write("\nEnter the box character: ");
            ch = ReadLine();
            Write("Enter the box of the size: ");
            
            // check numebr valid
            line = ReadLine();
            while ((int.TryParse(line, out boxSize)) == false || boxSize < 2)
            {
                Write("Oops. Looks like the number you entered: 0, is not acceptable. Please try again. Enter the box of the size: ");
                line = ReadLine();
            }
            
            // intance class and call method to print box
            Box newBox = new Box(ch,boxSize);
            newBox.Caja();  
            
            WriteLine("Press any key to continue...");
            ReadKey();
        }
    }
}
