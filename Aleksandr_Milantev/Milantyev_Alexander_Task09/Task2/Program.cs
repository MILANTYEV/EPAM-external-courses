using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i <= length; i++)
            {
                Console.WriteLine("Enter the {0} element", i);
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            DynamicArray<int> dynamicArray = new DynamicArray<int>(list);
            Console.WriteLine("\nElements:\n");
            foreach (var element in dynamicArray)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
