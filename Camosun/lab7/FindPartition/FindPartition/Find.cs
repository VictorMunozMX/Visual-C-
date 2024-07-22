using System;
using static System.Console;

namespace FindPartition
{
    class Find
    {
        private int[] arr;

        public Find()
        {
        }

        public Find(int[] a)
        {
            arr = a;
        }

        public int[] Back()
        {
            return arr;
        }

        public void GetArray(int num)
        {
            int n1;

            Write("How many numbers does your {0} array have? ",num);
            n1 = int.Parse(ReadLine());
            int[] a1 = new int[n1];

            for (int i = 0; i < a1.Length; i++)
            {
                Write("Enter value {0}: ", i + 1);
                a1[i] = int.Parse(ReadLine());
            }
            arr = a1;
        }
    }    
}
