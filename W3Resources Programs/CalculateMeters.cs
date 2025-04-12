using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace W3Resources_Programs
{
    internal class CalculateMeters
    {
        /*Write a C# Sharp program that takes distance and time as input and displays speed in kilometres per hour and miles per hour.
        Test Data:
        Input distance(metres): 50000
        Input timeSec(hour): 1
        Input timeSec(minutes): 35
        Input timeSec(seconds): 56
        */
        public static void Distance(int meters,int hours,int min,int sec)
        {
            int totalSeconds = (hours * 3600) + (min * 60) + sec;
            double kmph = (meters / 1000.0) / (totalSeconds / 3600.0);
            double mps = meters / (double)totalSeconds;
            double mph = kmph * 1069.0;
            Console.WriteLine("Speed in km/h: " + kmph);
            Console.WriteLine("Speed in m/s: " + mps);
            Console.WriteLine("speed in m/h: "+mph);


        }


    }
}
