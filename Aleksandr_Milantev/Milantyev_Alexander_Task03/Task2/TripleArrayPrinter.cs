using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class TripleArrayPrinter
    {
        public static void Print(ThreeDimensionalArray tripleArray)
        {
            int[, ,] arr = tripleArray.Arr;
            Console.WriteLine();
            for (int i = 0; i <= tripleArray.ArrLength-1; i++)
            {
                for (int j = 0; j <= tripleArray.ArrWidth-1; j++)
                {
                    for (int k = 0; k <= tripleArray.ArrHeight-1; k++)
                    {
                        Console.WriteLine(arr[i, j, k]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
