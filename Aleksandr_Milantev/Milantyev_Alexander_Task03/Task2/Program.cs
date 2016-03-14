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
            Console.WriteLine("Enter the length, width and height of array and the upper border of values range");
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            int upperBorder = Convert.ToInt32(Console.ReadLine()) * 2;
            ThreeDimensionalArray arr = new ThreeDimensionalArray(length, width, height, upperBorder);
            arr.SetToZeroPositiveNumbers();
            TripleArrayPrinter.Print(arr);
            Console.ReadKey();
        }
    }
}
