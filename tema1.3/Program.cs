//3.Write a C# Sharp program that takes two numbers as input and returns
//true or false when both numbers are even or odd.
using System;

namespace tema1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool output = true;
            Console.WriteLine("Insert the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (((a % 2 == 0) && (b % 2 == 0)) || ((a % 2 != 0) && (b % 2 != 0)))
            {
                Console.WriteLine(output);
            }
            else
            {
                output = false;
                Console.WriteLine(output);
            }




            Console.ReadLine();
        }
    }
}
