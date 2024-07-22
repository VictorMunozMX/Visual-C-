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

            // instancia
            Box boxes = new Box();

            // array tipo class
            Box[] wareHouse = new Box[5];

            // add data to array
            wareHouse[0] = new Box(3, 4, 5);
            wareHouse[1] = new Box(4, 6, 7);
            wareHouse[2] = new Box(1.5f, 4, 6);
            wareHouse[3] = new Box(6, 4, 4);
            wareHouse[4] = new Box(2, 3.5f, 8);

            float sum = 0;
            for (int x = 0; x < wareHouse.Length; x++)
            {                
                // call values from class
                //float h = wareHouse[x].H;
                //float w = wareHouse[x].W;
                //float d = wareHouse[x].D;             
                //float vol = wareHouse[x].Volume();

                // calculate the total volume
                sum = sum + wareHouse[x].Volume();
                                                               
                WriteLine("\nBox {0}", x+1);
                WriteLine("{0}", wareHouse[x]) ;
                
                //WriteLine("\t{0}", h);
                //WriteLine("\t{0}", w);
                //WriteLine("\t {0}", d);
                //WriteLine("\tVolume: {0}\n", vol);                
            }
            WriteLine("\nTotal volume of 5 boxes is {0:f2}",sum);
            
            ReadKey();
        }
    }
}
