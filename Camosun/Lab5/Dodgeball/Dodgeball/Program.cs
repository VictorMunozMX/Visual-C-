using System;
using System.Data.Common;
using System.Net.NetworkInformation;
using static System.Console;

namespace Dodgeball
{
    class Program
    {
        static void Main()
        {
            string playeR = "", win;
            int locA = 0;
            float maX = 0, positionA, positionB;

            bool v1 = false;
            bool v2 = false;

            // obtain data
            GetData(ref playeR, ref maX, ref locA);
            Player player1 = new Player(playeR, maX, locA);

            GetData(ref playeR, ref maX, ref locA);
            Player player2 = new Player(playeR, maX, locA);

            // calculate the total by player
            positionA = player1.GsLocation + player1.GsMaxThrowRange;
            positionB = player2.GsLocation + player2.GsMaxThrowRange;

            WriteLine("\nGame play begins....");
            WriteLine("Player {0}, max throw range: {1}, location: {2}",
                player1.GsPlayer, player1.GsMaxThrowRange, player1.GsLocation);
            WriteLine("versus Player {0}, max throw range: {1}, location: {2}",
                player2.GsPlayer, player2.GsMaxThrowRange, player2.GsLocation);

            // determinate who is between the range            
            if (positionA >= 0 && positionA <= 20)
            {
                v1 = true;
            }
            if (positionB >= 0 && positionB <= 20)
            {
                v2 = true;
            }
            if (player1.GsMaxThrowRange == 1)
            {
                v1 = false;
            }
            if (player2.GsMaxThrowRange == 1)
            {
                v2 = false;
            }            

            if ((v1 && v2) && (positionA == positionB))
            {
                WriteLine("\tPlayer {0} knocks out player {1}!", player1.GsPlayer, player2.GsPlayer);
                WriteLine("\tPlayer {0} knocks out player {1}!", player2.GsPlayer, player1.GsPlayer);
                WriteLine("Both players win!");
            }
            if (v1 == false && v2 == false)
            {
                WriteLine("\tPlayer {0} misses player {1}!", player1.GsPlayer, player2.GsPlayer);
                WriteLine("\tPlayer {0} misses player {1}!", player2.GsPlayer, player1.GsPlayer);
                WriteLine("Nobody wins. Better luck next time.");
            }
            if (v1 && positionA < positionB)
            {
                WriteLine("\tPlayer {0} knocks out player {1}!", player1.GsPlayer, player2.GsPlayer);
                WriteLine("\tPlayer {0} misses player {1}", player2.GsPlayer, player1.GsPlayer);
                WriteLine("Player {0} wins the round.",player1.GsPlayer);
            }
            else
            {
                if (v2 && positionB > positionA)
                {
                    WriteLine("Player {0} wins the round.", player2.GsPlayer);
                }
            }            
            ReadKey();
        }

        static void GetData(ref string player, ref float max, ref int loc)
        {
            // name
            Write("\nEnter the player name: ");
            player = ReadLine();
            
            // max
            Write("Enter the max throw range: ");
            max = float.Parse(ReadLine());
            if (max < 0 || max > 20)
            {                
                Write(" oops -- MaxThrowRange of 1 is invalid. Assigning 1.0 instead.\n");
                max = 1;                
            }

            // location
            Write("Enter the location: ");
            loc = int.Parse(ReadLine());
        }    

    }
}
