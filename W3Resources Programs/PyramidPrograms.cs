using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class PyramidPrograms
    {
        public static void pyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            int num = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num+++" ");
                }
                Console.WriteLine();
            }

        }
    }
}
