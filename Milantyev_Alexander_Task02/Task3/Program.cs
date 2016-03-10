using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        /// <summary>
        /// Метод рисует заданным символом треугольник заданного размера
        /// </summary>
        /// <param name="symbol">Символ, использующийся для изображения</param>
        /// <param name="linesNumber">Количество строк в треугольнике, размер по вертикали</param>
        /// <param name="shift">Смещение треугольника от левого края</param>
        public static void PrintTriangle(char symbol, int linesNumber, int shift)
        {
            if (linesNumber <= 0)
            {
                Console.WriteLine("Введено некорректное значение");
                return;
            }
            int spaceNumber = linesNumber+shift;
            double charsNumber = 1;
            for (int i = 1; i <= linesNumber; i++)
            {
                for (int j = 1; j <= spaceNumber; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j <= charsNumber; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
                spaceNumber--;
                charsNumber+=2;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк");
            int _number = Convert.ToInt32(Console.ReadLine());
            PrintTriangle('*',_number, _number);
            Console.ReadKey();
        }
    }
}
