using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class ElectricalBill
    {
        public static void BillCal()
        {
            Console.WriteLine("Enter the customer id:");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the customer name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enetr the units ");
            int units = Convert.ToInt32(Console.ReadLine());
            double unitRate = 0;
            if (units <= 200)
            {
                unitRate = 1.20;
            }
            else if (units <= 400)
            {
                unitRate = 1.50;
            }
            else if (units <= 600)
            {
                unitRate = 1.80;
            }
            else
            {
                unitRate = 2.00;
            }

            double amt=units*unitRate;
            double grsAmt = 0;
            if (amt > 300)
            {
                 grsAmt = amt * 15 / 100;
            }
            double netAmt = grsAmt + amt;

            if (netAmt < 100)
            {
                netAmt = 100;
            }
            Console.WriteLine("Customer ID: " + customerId);
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Units Consumed: " + units);
            Console.WriteLine("Amount Charges: " + amt);
            Console.WriteLine("Surcharge Amount: " + grsAmt);
            Console.WriteLine("Net Amount Paid: " + netAmt);
            Console.WriteLine("-------------------------------------------------");

        }
    }
}
