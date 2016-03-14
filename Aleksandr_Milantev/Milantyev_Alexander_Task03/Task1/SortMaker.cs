using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SortMaker
    {
        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        
        public static void QuickSort(int[] arr, int leftBound, int rightBound)
        {
            int bearingElement = arr[(leftBound + rightBound) / 2];
            int i = leftBound;
            int j = rightBound;
            while (i <= j)
            {
                while (arr[i] < bearingElement)
                {
                    i++;
                }
                while (arr[j] > bearingElement)
                {
                    j--;
                }
                Swap(arr, i, j);
                i++;
                j--;
                if (i < rightBound)
                {
                    QuickSort(arr, i, rightBound);
                }
                if (leftBound < j)
                {
                    QuickSort(arr, leftBound, j);
                }
            }
        }
    }
}
