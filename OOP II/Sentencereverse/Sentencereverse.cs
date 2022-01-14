using System;
namespace OopAssignment
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string str, RevStr = "";
Console.WriteLine("Enter a sentence to be reversed : ");
str = Console.ReadLine();
string[] newLine = str.Split(' ');
for (int x = newLine.Length - 1; x >= 0; x--)
{
    RevStr = RevStr + " " + newLine[x];
}
Console.WriteLine("Reversed sentence is : {0}", RevStr);
Console.ReadKey();
        }
    }
}