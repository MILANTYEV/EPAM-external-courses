using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task3
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
            
            SortsModule module = new SortsModule();
            arr = module.SortInThread(arr);
            Thread.Sleep(10);
            foreach (var line in arr)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
