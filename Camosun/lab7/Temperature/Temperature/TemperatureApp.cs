using System;
using static System.Console;

namespace Temperature
{
    internal class TemperatureApp
    {
        private int[] weekTemp;
        private int l, h;

        public TemperatureApp()
        {
        }

        public TemperatureApp(int[] week)
        {
            weekTemp = week; 
        }        

        public int FindColdestTemp()
        {
            l = 9999;
            foreach(int v in weekTemp)
            {
                if (v < l)
                {
                    l = v;
                }
            }
            return l;
        }

        public int FindWarmestTemp()
        {
            h = 0;
            foreach (int v in weekTemp)
            {
                if (v > h)
                {
                    h = v;
                }
            }
            return h;
        }

        public override string ToString()
        {
            return "Values in the Temperature Array\n" +
                weekTemp[0] + "\t" + weekTemp[1] + "\t" + weekTemp[2] + "\n" +
                weekTemp[3] + "\t" + weekTemp[4] + "\t" + weekTemp[5] + "\n" +
                weekTemp[6] + "\n" +
                "Temperatures ranged from " + FindColdestTemp() + " to " + FindWarmestTemp();
        }

    }
}
