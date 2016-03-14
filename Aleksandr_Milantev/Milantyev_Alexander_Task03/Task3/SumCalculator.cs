using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class SumCalculator
    {
        public static int CalculatePositiveElementsSum(int[] arr)
        {
            int sum = 0;
            foreach (int element in arr)
            {
                if (element > 0)
                {
                    sum += element;
                }
            }
            return sum;
        }
    }
}
