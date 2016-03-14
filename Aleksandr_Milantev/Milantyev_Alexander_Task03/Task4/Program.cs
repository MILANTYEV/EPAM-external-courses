using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length, width of array and the upper border of values range");
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int upperBorder = Convert.ToInt32(Console.ReadLine()) * 2;
            int[,] arr = TwoDimensionalArrayCreator.CreateTwoDimensionalArray(length, width, upperBorder);
            TwoDimensionalArrayPrinter.Print(arr);
            int EvenElementsSum = SumCalculator.CalculateEvenElementsSum(arr);
            Console.WriteLine("Even elements sum:{0}", EvenElementsSum);
            Console.ReadKey();
        }
    }
}
