//1. Write a C# Sharp program that takes email and password as input (type string).
//After 3 wrong attempts, user will be rejected.

using System;

namespace tema1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var NumberAttempts = 3;
            var tryAttempts = 0;
            for (int i = 0; i < NumberAttempts; i++)
            {
                Console.WriteLine("insert your email");
                string email = Console.ReadLine();
                Console.WriteLine("insert your password");
                string password = Console.ReadLine();
                tryAttempts++;
                if ((email == "email.log.com") && (password == "password.log"))
                {
                    Console.WriteLine("Login successfully!");
                    break;
                }
                else if (tryAttempts == NumberAttempts)
                {
                    Console.WriteLine("Login failed");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
