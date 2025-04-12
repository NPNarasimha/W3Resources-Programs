using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class QuadricEquation
    {
        //Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1
        //(using integer numbers for y, ranging from -5 to +5).
        public static void Quadric()
        {
            Console.WriteLine(" y     x");
            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine(y + "     " + x);
            }
        }
    }
}
