using System;
using static System.Console;
namespace PlayerApp
{
    class PlayerApp
    {
        static void Main(string[] args)
        {
            // create instancer for sue and tom
            Player sue = new Player(100, "Sue", "Smith");            
            Player tom = new Player(200, "Tom", "West");            
            // assig 3 win and 2 lost for sue
            sue.ScoreGameWin();
            sue.ScoreGameWin();
            sue.ScoreGameWin();
            sue.ScoreGameLoss();
            sue.ScoreGameLoss();
            // obtain the values
            int v = sue.GetNumVictories();
            int l = sue.GetNumLosses();           
            // calculate percent of played won
            sue.CalcWinPercent();
            // print on screen
            WriteLine("\nPlayer Sue won " + v + " games and lost " + l + " games");
            WriteLine("\n" + sue);
            WriteLine(tom);

            ReadKey();
        }
    }
}
