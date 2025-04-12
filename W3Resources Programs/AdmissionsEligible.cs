using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class AdmissionsEligible
    {
        public static void Addmissions()
        {
            Console.WriteLine("Enter maths marks");
            int mMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter physics maerks");
            int pMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter chemistry marks");
            int cMarks = Convert.ToInt32(Console.ReadLine());
            if (mMarks > 65 && pMarks > 55 && cMarks > 50)
            {
                if (mMarks + pMarks + cMarks >= 180 || mMarks + pMarks >= 140)
                {
                    Console.WriteLine("Eligible for Admission");
                }
                else
                {
                    Console.WriteLine("Not Eligible for Admission");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible for Admission");
            }
        }
    }
}
