using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ElementsFinder
    {
        public static int GetMinElement(int[] arr)
        {
            int minElement = arr[0];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }
            return minElement;
        }

        public static int GetMaxElement(int[] arr)
        {
            int maxElement = arr[0];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] > maxElement)
                {
                    maxElement = arr[i];
                }
            }
            return maxElement;
        }
    }
}
