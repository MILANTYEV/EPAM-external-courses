using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class TwoDimensionalArrayPrinter
    {
        public static void Print(int[,] arr)
        {
            for (int i = 0; i <= arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= arr.GetLength(1) - 1; j++)
                {
                    Console.Write("{0,4}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
