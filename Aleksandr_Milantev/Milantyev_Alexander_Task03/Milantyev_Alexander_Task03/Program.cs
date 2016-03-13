using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milantyev_Alexander_Task03
{
    class Program
    {
        static int[] CreateRandomArray(int arrayElementsNumber)
        {
            Random random = new Random();
            int [] array = new int[arrayElementsNumber];
            for (int i = 0; i <= array.Length-1; i++)
            {
                array[i] = random.Next(100);
            }
            return array;
        }
        
        static int GetMaxElement(int[] array)
        {
            int maxElement = array[0];
            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }

        static int GetMinElement(int[] array)
        {
            int minElement = array[0];
            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                }
            }
            return minElement;
        }

        static void QuickSort(int[] arr, int leftBound, int rightBound)
        {
            int bearingElement = arr[(leftBound + rightBound) / 2];
            int i = leftBound;
            int j = rightBound;
            int temp;
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
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < rightBound)
            {
                QuickSort(arr,i,rightBound);
            }
            if (j > leftBound)
            {
                QuickSort(arr, leftBound, j);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = CreateRandomArray(20);
            int maxElement = GetMaxElement(arr);
            int minElement = GetMinElement(arr);
            //Console.WriteLine("{0} {1}",maxElement.ToString(), minElement.ToString());
            QuickSort(arr, 3, 10);
            Console.WriteLine("Array:");
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
