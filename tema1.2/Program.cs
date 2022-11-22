//2.Write a C# Sharp program that takes a character as input and check the input (lowercase)
//is a vowel, a digit, or any other symbol.

using System;


namespace tema1._2
{
     class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("Insert a character: ");
            char character = Convert.ToChar(Console.ReadLine());
            if (character == vowels[0] || character == vowels[1]|| character == vowels[2] || character == vowels[3] || character == vowels[4])
           // if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine("This character is a lowercase vowel!");
            }else if((character>='0') && (character <='9'))
            {
                Console.WriteLine("This character is a digit!");
            }
            else
            {
                Console.WriteLine("This is another symbol");
            }
            Console.ReadLine();
        }
    }
}
