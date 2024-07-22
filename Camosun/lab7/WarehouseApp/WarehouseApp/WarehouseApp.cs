using System;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using static System.Console;

namespace WarehouseApp
{
    class WarehouseApp
    {
        static void Main(string[] args)
        {
            //Box box1 = new Box(1,2,3);
            //Write(box1);

            float[] wareHouseH = { 3,4,1.5f,6,2};
            float[] wareHouseW = { 4,6,4,4,3.5f};
            float[] wareHouseD = { 5,7,6,4,8};

            float y = 0, h=0, w=0, d = 0, sum = 0, b=0;

            for (int x = 0; x < wareHouseH.Length; x++)
            {
                
                h = wareHouseH[x];
                w = wareHouseW[x];
                d = wareHouseD[x];

                Box box1 = new Box(h, w, d);
                float vol = box1.Volume();

                sum = sum + vol;
                
                b = b + 1;                               
                WriteLine("Box {0}", b);
                WriteLine("\tHeight: {0}", h);
                WriteLine("\tWidth: {0}", w);
                WriteLine("\tDepth: {0}", d);
                WriteLine("\tVolume: {0}\n", vol);                
            }

            WriteLine("Total volume of 5 boxes is {0:f2}",sum);
            ReadKey();
        }
    }
}
