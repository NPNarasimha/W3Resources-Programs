using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class EligibleAge
    {
        public static void Eligible()
        {
            Console.WriteLine("Enter the Age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Eligible for Voting");
            }
            else
            {
                Console.WriteLine("Not Eligible for Voting");
            }
        }
    }
}
