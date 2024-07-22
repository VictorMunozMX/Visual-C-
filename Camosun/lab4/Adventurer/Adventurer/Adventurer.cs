using System;
using static System.Console;

namespace Adventurer
{
    class Adventurer
    {
        static void Main()
        {   
            // obtain data
            GetData();                              
        }
        // Method
        public static void GetData()
        {
            Adventur adv = new Adventur();
            Write("Cual es tu nombre: ");
            string n = ReadLine();
            adv.SetFullName(n);
            Write("Healt points: ");
            int i = int.Parse(ReadLine());
            adv.SetHealthPoints(i);
            Write("Are you honest (true/false): ");
            bool h = bool.Parse(ReadLine());
            adv.SetHonest(h);
            Write("Please, could you write your weight: ");
            float p = float.Parse(ReadLine());
            adv.SetWeight(p);
            Write("Please, could you write your salary: ");
            decimal d = decimal.Parse(ReadLine());
            adv.SetSalary(d);

            WriteLine(adv.ToString());
            ReadKey();
        }

    }
}
