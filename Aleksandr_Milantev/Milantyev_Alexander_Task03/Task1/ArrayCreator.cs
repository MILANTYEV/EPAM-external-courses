using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ArrayCreator
    {
        public static int[] CreateRandomArray(int arrayElementsNumber, int valueUpperBorder)
        {
            Random random = new Random();
            int[] array = new int[arrayElementsNumber];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                array[i] = random.Next(valueUpperBorder) - valueUpperBorder/2;
            }
            return array;
        }

    }
}
