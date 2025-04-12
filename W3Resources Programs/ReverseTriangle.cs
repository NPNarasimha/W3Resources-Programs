using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class ReverseTriangle
    {
        public static void Triangle(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = n - i; j >= 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
