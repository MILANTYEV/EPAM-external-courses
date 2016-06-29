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
            DynamicArray<int> arr = new DynamicArray<int>(length);
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr.Add(random.Next(100));
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
