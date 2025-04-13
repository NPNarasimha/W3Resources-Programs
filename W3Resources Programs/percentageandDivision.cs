using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class percentageandDivision
    {
        public static void Division()
        {
            Console.WriteLine("Enter the Roll number");
            int roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Marks of Maths");
            int Maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Science");
            int Science = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Computer science");
            int ComputerScience = Convert.ToInt32(Console.ReadLine());
            int total = Maths + Science + ComputerScience;

            int percentage = total / 3 ;
            Console.WriteLine("Roll Number: " + roll);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Percentage: " + percentage + "%");
            if (percentage >= 80)
            {
                Console.WriteLine("Division First");
            }
            else if (percentage >= 60 && percentage < 80)
            {
                Console.WriteLine("Division Second");
            }
            else if (percentage >= 40 && percentage < 60)
            {
                Console.WriteLine("Division Third");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
