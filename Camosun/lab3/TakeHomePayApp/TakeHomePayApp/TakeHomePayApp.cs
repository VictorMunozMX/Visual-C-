using System;
using static System.Console;

namespace TakeHomePayApp
{
    class TakeHomePayApp
    {
        static void Main()
        {
            // variables
            const double TOTALSALES = .07, FEDTAX = .08, INSURANCE = .09;
            double grossPay, tax, ei, totDed, homePay;
            string name;
            double weeklySales;

            // obtain name
            name = GetName();
            // obtain weekly sales
            weeklySales = GetWeeklySales();
            // obtain gross pay
            grossPay = GetGrossPay(weeklySales, TOTALSALES);
            // obtain fed tax
            tax = GetTax(grossPay, FEDTAX);
            // obt insurance
            ei = GetEi(grossPay, INSURANCE);

            // Display all the info
            DisplayResults(name, weeklySales, TOTALSALES, grossPay, FEDTAX, tax, INSURANCE,ei);            
        }
        // method for read name
        static string GetName()
        {
            Write("Please enter an employee name: ");
            string n = ReadLine();
            return n;
        }
        // methos for read weekly pay
        static double GetWeeklySales()
        {
            Write("Please enter this employee´s weekly sales: ");
            double c = double.Parse(ReadLine());
            return c;
        }
        // calculate groos pay
        static double GetGrossPay(double pay, double sales) {
            double p = pay * sales;
            return p;
        }
        // calculate federal taxes
        static double GetTax(double pay, double tax)
        {
            double t = pay * tax;
            return t;
        }
        // calculate insurance
        static double GetEi(double pay, double tax)
        {
            double t = pay * tax;
            return t;
        }
        // show the info on screen
        static void DisplayResults(string name, double sales, double TOTALSALES, double gross, 
                                    double fed, double tax, double ins, double ei) {
            WriteLine("\n\n\tWeekly Payroll App");
            WriteLine("\nEmployee Name: {0}", name);
            WriteLine("\nThis week's Sales: {0,23:c2}", sales);
            WriteLine("Commission Rate: {0}%", TOTALSALES * 100);
            WriteLine("\nGross Pay: {0,31:c2}", gross);           
            WriteLine("Federal Taxes Withheld:   ({0}%): {1,10:c2}", fed * 100, tax );
            WriteLine("EI Withheld               ({0}%): {1,10:c2}", ins * 100, ei);
            WriteLine("\nTotal Deductions: {0,24:c2}",tax+ei);
            WriteLine("\nTake Home Pay: {0,27:c2}", gross -(tax + ei));
            WriteLine(" Press any key to continue...");
            ReadKey();
        } 

    }
}
