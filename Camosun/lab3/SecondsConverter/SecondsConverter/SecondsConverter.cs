using System;
using static System.Console;

namespace SecondsConverter
{
    class SecondsConverter
    {
        static void Main()
        {
            int totalSecond, numHours, numMinutes, numSeconds, remainingSeconds;
            const int HOUR = 3600;

            totalSecond = InputSeconds();

            numHours = CalculateNumberOfHours(totalSecond, HOUR);

            numMinutes = CalculateNumberOfMinutes(totalSecond, HOUR, numHours);

            remainingSeconds = CalculateNumberOfRemainingSeconds(totalSecond, numHours, numMinutes);

            DisplayResults(totalSecond, numHours, numMinutes, remainingSeconds);
        }

        static int InputSeconds()
        {
            Write("\nInput the number od seconds: ");
            string n = ReadLine();
            int seconds = int.Parse(n);
            return seconds;
        }

        static int CalculateNumberOfHours(int seconds, int hour) {            
            int hours = seconds / hour;
            return hours;
        }
        
        static int CalculateNumberOfMinutes(int seconds, int hour, int numhours)
        {            
            int minutes = (seconds - (hour * numhours));
            return minutes / 60;
        }

        static int CalculateNumberOfRemainingSeconds(int seconds, int horas, int minutos)
        {
            int remaining = (seconds - (horas * 3600) - (minutos * 60));            
            return remaining;
        }

        static void DisplayResults(int totseconds, int thours, int totminutes, int seconds) {
            WriteLine("\n\n\tTime Converter\n");
            WriteLine("Total");
            WriteLine("Seconds: {0,9:n0}\n", totseconds);
            WriteLine("Hours: {0,13:n0}", thours);
            WriteLine("Minutes: {0,11:n0}", totminutes);
            WriteLine("Seconds: {0,11:n0}", seconds);
            WriteLine("\nEnter to end App...");
            ReadKey();
        }

    }
}
