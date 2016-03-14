using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ArrayPrinter
    {
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("Array:");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

    }
}
