using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    public class MathFunctions
    {
        /// <summary>
        /// Fuction for calclulating factorial of natural number
        /// </summary>
        /// <param name="N">Number for calculating of factorial</param>
        /// <returns></returns>
        public static int Factorial(int N)
        {
            return N == 0 ? 1 : N * Factorial(N - 1);
        }

        /// <summary>
        /// Function for involution
        /// </summary>
        /// <param name="x">Base of degree</param>
        /// <param name="y">Index of degree</param>
        /// <returns></returns>
        public static double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
