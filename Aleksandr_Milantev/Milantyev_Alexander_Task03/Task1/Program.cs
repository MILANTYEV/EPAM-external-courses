﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array's length and the upper border of value range.");
            int length =Convert.ToInt32(Console.ReadLine());
            int upperBorder = Convert.ToInt32(Console.ReadLine());
            int[] arr = ArrayCreator.CreateRandomArray(length, upperBorder * 2);
            SortMaker.QuickSort(arr, 0, arr.Length-1);
            ArrayPrinter.PrintArray(arr);
            Console.WriteLine("Minimum:{0}, Maximum:{1}",ElementsFinder.GetMinElement(arr),ElementsFinder.GetMaxElement(arr));
            Console.ReadKey();
        }
    }
}



 