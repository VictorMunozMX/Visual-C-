using System;
using static System.Console;

namespace FindPartition
{
    class FindPartition
    {
        static void Main(string[] args)
        {                        
            // arrays
            Find ar1 = new Find();
            Find ar2 = new Find();

            // first array
            ar1.GetArray(1);
            ar1.Back();

            // second array
            ar2.GetArray(2);
            ar2.Back();

            // find
            bool f = false;
            f = Found(ar1.Back(),ar2.Back());

            string cad = "";
            Write("\nFisrt Array: ");
            foreach (int i in ar1.Back())
            {
                 cad = cad + i + ",";                 
            }
            Write("{ " + cad.Substring(0,cad.Length-1) + " }");

            cad = "";
            Write("\nSecond Array: ");
            foreach (int i in ar2.Back())
            {
                cad = cad + i + ",";
            }
            Write("{ " + cad.Substring(0, cad.Length - 1) + " }");

            Write("\n\nFind Partition: " + f);
            ReadLine();
        }        

        public static bool Found(int[] a1, int[] a2)
        {
            bool val = false;
            foreach (int i in a1)
            {
                val = false;
                int n = i;
                foreach (int j in a2)
                {
                    if (n == j)
                    {
                        val = true;
                        break;
                    }
                }

                if (val == false)
                {
                    break;
                }
            }
            return val;
        }
    }
}
