using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task4
{
    class Program
    {
        /// <summary>
        /// Метод, рисующий заданным символом заданное число треугольников друг под другом
        /// </summary>
        /// <param name="symbol">Символ, используемый для рисования треугольников</param>
        /// <param name="trianglesNumber">Число треугольников</param>
        static void PrintNTriangles(char symbol, int trianglesNumber)
        {
            if (trianglesNumber <= 0)
            {
                Console.WriteLine("Введено некорректное значение");
                return;
            }
            int triangleLinesNumber = 1;
            int spaceNumber = trianglesNumber;
            for (int i = 1; i <= trianglesNumber; i++)
            {
                Task3.Program.PrintTriangle(symbol, triangleLinesNumber, spaceNumber);//используем метод из предыдущего задания
                triangleLinesNumber++;
                spaceNumber--;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество треугольников");
            int _trianglesNumber = Convert.ToInt32(Console.ReadLine());
            PrintNTriangles('*',_trianglesNumber);
            Console.ReadKey();
        }
    }
}
