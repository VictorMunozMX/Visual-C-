using System;
using static System.Console;

namespace Dragon
{
    class Dragon
    {
        static void Main()
        {   
            // using class dragon with the third contructor
            ClassDragon draComplete = new ClassDragon("Melvin", 32, 75.2f, true, "black");                        
            WriteLine(draComplete);
            // using class dragon with the second contructor
            ClassDragon dra = new ClassDragon("dewey");
            WriteLine(dra);
            ReadKey();
        }
    }
}
