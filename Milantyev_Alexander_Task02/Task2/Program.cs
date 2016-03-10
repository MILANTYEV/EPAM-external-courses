using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        /// <summary>
        /// Метод, рисующий заданным символом углообразную фигуру
        /// </summary>
        /// <param name="symbol">Символ, используемый для рисования</param>
        /// <param name="linesNumber">Число строк в фигуре</param>
        static void PrintChars(char symbol, int linesNumber)
        {
            if (linesNumber <= 0)
            {
                Console.WriteLine("Введено некорректное значение");
                return;
            }
            int lineLength = 1;
            for (int i = 1; i <= linesNumber; i++)
            {
                for (int j = 1; j <= lineLength; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
                lineLength++;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк");
            int _number = Convert.ToInt32(Console.ReadLine());
            PrintChars('*', _number);
            Console.ReadKey();
        }
    }
}
