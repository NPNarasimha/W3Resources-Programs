using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class VolumeAndAreaSpare
    {
        public static void VolumeAndArea(int radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius,3);
            double area = 4 * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Volume of the sphere: " + volume);
            Console.WriteLine("Surface area of the sphere: " + area);
        }

    }
}
