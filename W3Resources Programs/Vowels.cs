using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class Vowels
    {
        public static void Vowel()
        {
            
            Console.WriteLine("Enter a Char:");
            char ch =Convert.ToChar(Console.ReadLine());
            
           if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("It is a Vowels");
            }
            else
            {
                Console.WriteLine("Not a vowels");
            }

        }
    }
}
