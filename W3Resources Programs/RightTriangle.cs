using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class RightTriangle
    {
        public static void Triangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for(int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    num++;
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
