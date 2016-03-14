using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class TwoDimensionalArrayCreator
    {
        public static int[,] CreateTwoDimensionalArray(int length, int width, int valueUpperBorder)
        {
            int[,] arr = new int[length, width];
            Random random = new Random();
            for (int i = 0; i <= arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= arr.GetLength(1) - 1; j++)
                {
                    arr[i, j] = random.Next(valueUpperBorder) - valueUpperBorder / 2;
                }
            }
            return arr;
        }
    }
}
