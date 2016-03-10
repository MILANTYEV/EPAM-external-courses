using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        /// <summary>
        /// Метод, рассчитывающий площадь прямоугольника по заданным длине и ширине
        /// </summary>
        /// <param name="length">Длина прямоугольника</param>
        /// <param name="width">Ширина прямоугольника</param>
        /// <returns></returns>
        static double CalculateRectangleArea(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                Console.WriteLine("Некоректный ввод. Параметры прямоугольника должны быть положительными числами");
                return 0;
            }
            return length * width;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину и ширину прямогульника");
            double _length = Convert.ToDouble(Console.ReadLine());
            double _width = Convert.ToDouble(Console.ReadLine());
            var area = CalculateRectangleArea(_length, _width);
            Console.WriteLine("Площадь равна {0}",area);
            Console.ReadKey();
        }
    }
}
