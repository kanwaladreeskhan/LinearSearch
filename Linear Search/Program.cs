using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=====Linear Searching=====");
            Console.Write("Enter the size for array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size]; int index = -1; int comparisoncount = 0;
            Console.WriteLine("Enter the elements of array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element {0}:", i + 1);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the number to search:");
            int key = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                comparisoncount++;
                if (array[i] == key)
                {
                    index = i;
                    break;
                    
                }
            }
            if (index != -1)
            {
                Console.WriteLine("The number is at index {0}!", index);
                 
            }
            else
            {
                Console.Write("The number does not exist!");
            }
            Console.WriteLine("The comparision count is  {0}", comparisoncount);
            Console.ReadLine();



        }

    }
 
}
