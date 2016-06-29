using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Sorter
    {
        private int AlphabeticCompare(string strA, string strB)
        {
            int sortOrder = 0;
            bool equalLenght = strA.Length.Equals(strB.Length);
            int isHigherInAlphabetOrder = String.Compare(strA, strB);
            if (equalLenght & (isHigherInAlphabetOrder > 0))
            {
                sortOrder = 1;
            }
            else
            {
                if (equalLenght & (isHigherInAlphabetOrder < 0))
                {
                    sortOrder = -1;
                }
            }
            return sortOrder;
        }
        
        private int CompareLengths(string strA, string strB)
        {
            int sortOrder = 0;
            if (strA.Length > strB.Length)
            {
                sortOrder = 1;
            }
            else
            {
                if (strA.Length < strB.Length)
                {
                    sortOrder = -1;
                }
            }
            return sortOrder;
        }

        private string[] Swap(string[] arr, int index)
        {
            var temp = arr[index - 1];
            arr[index - 1] = arr[index];
            arr[index] = temp;
            return arr;
        }

        public delegate int CompareStrings(string strA, string strB);

		public string[] SortWithDelegate(string[] arr, CompareStrings compareStrings)
        {
            int i = 1;
            while (i < arr.Length)
            {
                if (compareStrings(arr[i - 1], arr[i]) > 0)
                {
                    Swap(arr, i);
                    i = 1;
                }
                else
                {
                    i++;
                }
            }
            return arr;
        }

        public string[] SortStr(string[] arr)
        {
            SortWithDelegate(arr, new CompareStrings(CompareLengths));
            SortWithDelegate(arr, new CompareStrings(AlphabeticCompare));
            return arr;
        }
    }
}
