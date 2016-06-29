using System;
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
            FileOwner fileOwner = new FileOwner(args[0]);
            var list = fileOwner.GetFileText();
            
            for (int i = 0; i <= list.Count - 1; i++ )
            {
                list[i] = Math.Pow(Convert.ToInt32(list[i]), 2).ToString();
            }
            
            fileOwner.RecordFile(list);
            
            Console.ReadKey();
        }
    }
}
