using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[length];
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter the {0} element", i);
                arr[i] = Console.ReadLine();
            }
            
            Sorter sorter = new Sorter();
            sorter.SortStr(arr);
            
            Console.WriteLine("\nSorted array:\n");
            foreach (var str in arr)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();
        }
    }
}
