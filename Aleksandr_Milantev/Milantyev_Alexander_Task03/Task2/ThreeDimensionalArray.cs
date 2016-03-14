using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ThreeDimensionalArray
    {
        private int[,,] arr;

        public int[,,] Arr
        {
            get { return arr; }
            set { arr = value; }
        }

        private int arrLength;

        public int ArrLength
        {
            get { return arrLength; }
            set { arrLength = value; }
        }
        private int arrWidth;

        public int ArrWidth
        {
            get { return arrWidth; }
            set { arrWidth = value; }
        }
        private int arrHeight;

        public int ArrHeight
        {
            get { return arrHeight; }
            set { arrHeight = value; }
        }

        public ThreeDimensionalArray(int arrayLength, int arrayWidth,
            int arrayHeight, int valueUpperBorder)
        {
            this.arrLength = arrayLength;
            this.arrWidth = arrayWidth;
            this.arrHeight = arrayHeight;
            this.arr = CreateThreeDimensionalArray(arrayLength, arrayWidth, arrayHeight, valueUpperBorder);
        }

        private int[,,] CreateThreeDimensionalArray(int arrayLength, int arrayWidth,
            int arrayHeight, int valueUpperBorder)
        {
            int[,,] randomArray = new int[arrayLength,arrayWidth,arrayHeight];
            Random random = new Random();
            for (int i = 0; i <= arrayLength-1; i++)
            {
                for (int j = 0; j <= arrayWidth-1; j++)
                {
                    for (int k = 0; k <= arrayHeight-1; k++)
                    {
                        randomArray[i, j, k] = random.Next(valueUpperBorder) - valueUpperBorder/2;
                    }
                }
            }
            return randomArray;
        }

        public void SetToZeroPositiveNumbers()
        {
            int[, ,] array = this.arr;
            for (int i = 0; i <= this.arrLength-1; i++)
            {
                for (int j = 0; j <= this.arrWidth-1; j++)
                {
                    for (int k = 0; k <= this.arrHeight-1; k++)
                    {
                        array[i,j,k] = array[i,j,k] > 0
                            ?0
                            :array[i,j,k];
                    }
                }
            }
        }
    }
}
