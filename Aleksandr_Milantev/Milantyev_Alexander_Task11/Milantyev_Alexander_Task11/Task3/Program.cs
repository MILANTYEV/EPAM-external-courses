using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDPointWithHash x1 = new TwoDPointWithHash(1, 1);
            TwoDPointWithHash x2 = new TwoDPointWithHash(10, 10);
            
            Console.WriteLine("Hash codes:\n(1,1) : {0}", x1.GetHashCode());
            Console.WriteLine("(10,10) : {0}", x2.GetHashCode());
            Console.ReadKey();
        }
    }
}
