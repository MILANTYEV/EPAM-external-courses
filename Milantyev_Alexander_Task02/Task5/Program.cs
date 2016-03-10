using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        /// <summary>
        /// Метод, находящий на интервале от 1 до заданной границы все числа кратные хотя бы одному делителю из входного списка
        /// </summary>
        /// <param name="rightBound">Правая граница интервала поиска</param>
        /// <param name="dividers">Список делителей</param>
        /// <returns></returns>
        static List<int> FindMultiples(int rightBound, List<int> dividers)
        {
            List<int> multiples = new List<int>();
            for (int i = 1; i < rightBound; i++)
            {
                if (CalculateIsMultiple(i,dividers))
                {
                    multiples.Add(i);
                }
            }
            return multiples;
        }
        
        /// <summary>
        /// Метод, определяющий, является ли число кратным хотя бы одному числу из списка делителей
        /// </summary>
        /// <param name="digit">проверяемое число</param>
        /// <param name="dividers">список делителей</param>
        /// <returns></returns>
        static bool CalculateIsMultiple(int digit, List<int> dividers)
        {
            foreach (int divider in dividers)
            {
                if (digit%divider == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            List<int> _dividers = new List<int> {3,5};
            Console.WriteLine("Введите правую границу диапазона поиска кратных чисел");
            int _rightBound = Convert.ToInt32(Console.ReadLine());
            var multiples = FindMultiples(_rightBound, _dividers);
            Console.WriteLine("Список кратных чисел:");
            foreach (int multiple in multiples)
            {
                Console.WriteLine(multiple);
            }
            Console.ReadKey();
        }
    }
}
