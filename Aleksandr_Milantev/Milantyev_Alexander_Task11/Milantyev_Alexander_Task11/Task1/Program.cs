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
            Console.WriteLine("Enter the number for factorial calculating");
           
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", N, MathFunctions.MathFunctions.Factorial(N));

            Console.WriteLine("Enter the number and degree");
            
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}^{1} = {2}", x, y, MathFunctions.MathFunctions.Power(x, y));
            Console.ReadKey();
        }
    }
}
