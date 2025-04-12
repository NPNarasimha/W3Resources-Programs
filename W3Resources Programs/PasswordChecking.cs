using System;
using System.Collections.Generic;
using System.Text;

namespace W3Resources_Programs
{
    internal class PasswordChecking
    {
        //Write a C# Sharp program that takes userid and password as input (string type).
        //After 3 unsuccessful attempts, the user will be rejected.
        public static void PasswordCheck()
        {
            int count= 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter user id and password");
                string userid = Console.ReadLine();
                string password = Console.ReadLine();
                if (userid == "123" && password == "krishna@123")
                {
                    Console.WriteLine("Login success");
                    return;
                }
                else
                {
                    count++;
                    if (count == 3)
                    {
                        Console.WriteLine("You have entered wrong 3 times user is rejected");
                        return;
                    }
                }
                Console.WriteLine("Enter correct data");
            }
            
            
        }
    }
}
