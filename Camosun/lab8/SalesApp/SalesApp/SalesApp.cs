using System;
using static System.Console;

namespace SalesApp
{
    class SalesApp
    {
        static void Main(string[] args)
        {
            const int COUNT_OF_SALES_AREAS = 4;
            const int COUNT_OF_PRODUCTS = 3;

            double[,] sales = new double[COUNT_OF_SALES_AREAS, COUNT_OF_PRODUCTS];

            string[] salesArea = { "Victoria", "Nanaimo", "Kamloops", "Vancouver" };
            string[] productName = { "Lemon", "Apple", "Pumpkin" };

            InitializeArray(sales);

            GetSalesFigures(sales, salesArea, productName);
         
            DisplayResults(sales, salesArea, productName);
            ReadKey();

        }
        public static void InitializeArray(double[,] sales)
        {
            //  Set all sales values for each sales area and product to zero.             
            for (int x=0; x<sales.GetLength(0); x++)
            {
                for (int y=0; y<sales.GetLength(1); y++)
                {
                    sales[x, y] = 0;
                }
            }
        }

        public static void GetSalesFigures(double[,] sales, string[] salesmenName, string[] productName)
        {
            int salesNo,
                productNo;
            string inputValue;
            bool moreData = true;
            while (moreData)
            {
                salesNo = GetSalesNumber(salesmenName);
                productNo = GetProductNumber(productName);               
                sales[salesNo, productNo] += GetSalesFigures();

                /* TODO: Prompt if there are more sales.  If there are
                 *       no more sales to record, set the moreData 
                 *       sentinel to false.
                 */
                Write("Are there more sales SI / NO ? ");
                inputValue = ReadLine();
                if (inputValue.ToUpper() == "NO")
                {
                    moreData = false;
                }
            }
        }

        public static int GetSalesNumber(string[] salesAreaName)
        {
            int salesNo = -1;
            while (salesNo < 0 || salesNo > 4)
            {
                Clear();
                WriteLine("Sales Registry\n\n");
                /*
                 * TODO: show the sales area names by number: 
                 *     1. Victoria
                 *     2. Nanaimo ... etc
                 */
                for (int x=0; x<salesAreaName.Length; x++)
                {
                    WriteLine("{0}. {1}",x+1,salesAreaName[x]);
                }

                Write("\nSales are for which sales area? (1-4):  ");

                /*
                 * TODO: read in a salesNo value that is confirmed to be valid,
                 *       if it isn't, display a message, then reread the value
                 *       until it is valid.
                 */
                string intValue = ReadLine();
                int.TryParse(intValue, out salesNo);
                while (salesNo < 1 || salesNo > 4) 
                {
                    Write("You option is invalid. Enter a new valid value: ");                    
                    intValue = ReadLine();
                    int.TryParse(intValue, out salesNo);                    
                }
            }
            return salesNo - 1;
        }

        public static int GetProductNumber(string[] productName)
        {
            int productNo = -1;
            while (productNo < 0 || productNo > 3)
            {
                Clear();
                WriteLine("Products\n\n");
                /*
		        * TODO: show the product names by number: 
		        *     1. Lemon
		        *     2. Apple ... etc
                */
                for (int x=0; x< productName.Length;x++)
                {
                    WriteLine("{0}. {1}",x+1,productName[x]);
                }

                Write("\nSales are for which product?  ");

                /*
                 * TODO: read in a productNo value that is confirmed to be valid,
                 *       if it isn't, display a message, then reread the value
                 *       until it is valid.
                 */
                string intValue = ReadLine();
                int.TryParse(intValue, out productNo);
                while (productNo < 1 || productNo > 4)
                {
                    Write("You value is invalid. Enter a new valid value: ");
                    intValue = ReadLine();
                    int.TryParse(intValue, out productNo);
                }                
            }
            return productNo - 1;
        }

        public static double GetSalesFigures()
        {
            double salesAmt = 1.5f;
            Write("What was the sales amount? ");
            /*
             * TODO: read in a salesAmt value that is confirmed to be valid,
             *       if it isn't, display a message, then reread the value.
             */
            string doubleValue = ReadLine();            
            while (!double.TryParse(doubleValue, out salesAmt))
            {
                Write("You value is invalid. Enter a new valid value: ");
                doubleValue = ReadLine();
                double.TryParse(doubleValue, out salesAmt);
            }

            return salesAmt;
        }

        public static void DisplayResults(double[,] sales, string[] salesAreaName, string[] productName)
        {
            Clear();
            WriteLine("\t\tSales Summary\n\n");
            Write("{0, -15}", "Sales Area");
            for (int i = 0; i < productName.Length; i++)
            {
                Write(productName[i].PadLeft(10));
            }
            WriteLine();

            /* 
             * TODO: display the sales data in table format like this:
             *      
             *  Victoria           100.00    200.00      0.00
             *  Nanaimo              0.00      0.00      0.00
             *  etc..
             */
             for (int x = 0; x < salesAreaName.Length; x++)
            {
                Write(salesAreaName[x].PadRight(10));

                for (int y=0; y < sales.GetLength(1); y++)
                {
                    Write("{0,13:f2}", sales[x,y]);
                }
                WriteLine();
            }

        }
    }
 }
