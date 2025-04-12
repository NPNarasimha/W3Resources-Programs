using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class AreaOfCircle
    {
        public static void Circle(int radius)
        {
            int res=Convert.ToInt32(Math.PI)*radius*radius;
            Console.WriteLine("Area of a circle "+res);
        }
    }
}
