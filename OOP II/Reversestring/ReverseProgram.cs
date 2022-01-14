using System;
namespace OopAssignment
{
    class Reversestring
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string reversedString = string.Empty;
            foreach (char c in inputString)
            {
                reversedString = c + reversedString;
            }
            Console.Write($"Reversed String is : {reversedString} ");
            Console.ReadLine();
        }      
    }
}