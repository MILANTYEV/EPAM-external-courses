using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1;

namespace Task3
{
    class SortsModule
    {
        private delegate string[] DelSort(string[] arr);
        private string[] strArr;
        private static Sorter sorter = new Sorter();
        
        DelSort delSort = sorter.Sort;

        public event EventHandler EndSort;
        
        public string[] Sort(string[] arr)
        {
            return delSort(arr);
        }

        private void SortThisArr()
        {
            EndSort = new EventHandler(PrintEndSort);
            delSort(this.strArr);
            OnEndSort();
        }
        
        public string[] SortInThread(string[] arr)
        {
            this.strArr = arr;
            Thread thread = new Thread(SortThisArr);
            thread.Start();
            arr = this.strArr;
            return arr;
        }

        
        public void OnEndSort()
        {
            if (EndSort != null)
            {
                EndSort(this, null);
            }
        }

        private void PrintEndSort(object obj, EventArgs args)
        {
            Console.WriteLine("\nSorting is over\n");
        }

    }
}
