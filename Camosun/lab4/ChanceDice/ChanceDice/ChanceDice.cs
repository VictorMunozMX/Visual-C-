using System;
using static System.Console;

namespace ChanceDice
{
    class ChanceDice
    {
        static void Main()
        {
            // instance
            ChanceCube redCube = new ChanceCube();
            // first value
            WriteLine("\nFace initial:       " + redCube);
            // value with random
            redCube.SetRandom();
            redCube.RollCube();
            WriteLine("\nFace with Ramdon(): " + redCube);
            ReadKey();
        }
    }
}
