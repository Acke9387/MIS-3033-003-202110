using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lowercaseLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string firstName = "" + lowercaseLetters[0] + lowercaseLetters[3] + lowercaseLetters[0] + lowercaseLetters[12];
            firstName = lowercaseLetters[0].ToString() + lowercaseLetters[3] + lowercaseLetters[0] + lowercaseLetters[12];

            Console.WriteLine(firstName);
        }
    }
}
