using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using static System.Console;

namespace Inventory
{
    class Inventory
    {
        static void Main()
        {
            // Variables
            int itenNumber = 5247, quantityOnHand = 24;
            double unitCost = 4.75, sellingPrice = 9.49;
            double totalCost, totalIncome, profit;
            String itemDescription = "Claw hammers, wood handle";

            // totalCost is equal quantity x unit cost
            totalCost = quantityOnHand * unitCost;
            // total income is equal quantity x selling price
            totalIncome = quantityOnHand * sellingPrice;
            // profit is equal total income minus total cost
            profit = totalIncome - totalCost;
            
            // Report Title 
            WriteLine("\nVictor Munoz\t\tINVENTORY REPORT\tSept 24, 2022\n");
            // Detail item
            Write("Item Number: \t {0,8}",itenNumber);
            Write("\t\tDescription: {0}", itemDescription);
            WriteLine("\nQuantity: \t {0,8}", quantityOnHand);
            WriteLine("Unit Cost: \t {0,8:c2}", unitCost);
            WriteLine("Selling Price: \t {0,8:c2}", sellingPrice);
            // total profit
            WriteLine("Total Profit: \t {0,8:c2}", profit);
            // end of the report
            WriteLine("\n\nEnd of the Report");
            ReadKey();
        }
    }
}
