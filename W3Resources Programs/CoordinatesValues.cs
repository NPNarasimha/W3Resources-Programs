using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace W3Resources_Programs
{
    internal class CoordinatesValues
    {
       public static void Coordinates()
        {
            Console.WriteLine("Enter the X coordinate");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinate");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant 1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant 2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant 3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant 4");
            }
        }
    }
}
