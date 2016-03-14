using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array's length and the upper border of value range.");
            int length =Convert.ToInt32(Console.ReadLine());
            int upperBorder = Convert.ToInt32(Console.ReadLine());
            int[] arr = Task1.ArrayCreator.CreateRandomArray(length, upperBorder);
            int positiveElementsSum = SumCalculator.CalculatePositiveElementsSum(arr);
            Task1.ArrayPrinter.PrintArray(arr);
            Console.WriteLine("Sum of non-negative elemets:{0}", positiveElementsSum);
            Console.ReadKey();
        }
    }
}
