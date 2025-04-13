using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class IsolateTriangle
    {
        public static void FindAngles()
        {
            Console.WriteLine("Enter 1st side");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  2nd side");
            int side2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd side");
            int side3= Convert.ToInt32(Console.ReadLine());
            if(side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Triangle");
            }
            else if (side1==side3||side2==side3||side1==side2)
            {
                Console.WriteLine("Isoscales Tiangle");
            }
            else
            {
                Console.WriteLine("Scalene Triangle");
            }
        }
    }
}
