using System;
namespace OopAssignment
{
    class Secondlargest
    {
static void Main(string[] args)
        {
            int n, i;
            int[] arr1 = new int[20];
 
            Console.Write("\n\nFind the second largest element in an array :\n");
            Console.Write("-----------------------------------------\n");
 
            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int max1 = int.MinValue;  
    int max2 = int.MinValue;  
    foreach (int item in arr1)  
    {  
        if (item > max1)  
        {  
            max2 = max1;  
            max1 = item;  
        }  
        else if (item >= max2 && item != max1)  
        {  
            max2 = item;  
        }  
    }  
    Console.WriteLine($"The second largest integer is {max2}");
        
        Console.ReadKey();
        }
}
}