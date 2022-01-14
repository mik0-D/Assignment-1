using System;
namespace OopAssignment
{
    public class Palindrome
    {
        static void Main()
        {
            Console.Write("Enter a string to Check Palindrome : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            foreach (char c in name)
            {
                reverse = c + reverse;
            }
            if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
            Console.ReadKey();
        }
    }
}