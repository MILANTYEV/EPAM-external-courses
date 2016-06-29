using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Watching mode, 2-Rollback mode");
            var mode = Console.ReadKey();
            if (mode.Key == ConsoleKey.D1)
            {
                WatchingMode watchingMode = new WatchingMode(args[0]);
                watchingMode.Run();
            }
            else
            {
                RollbackMode rollbackMode = new RollbackMode(args[0]);
                Console.WriteLine("\nEnter the: year, month, day, hour, minute, second");
                int year = int.Parse(Console.ReadLine());
                int month = int.Parse(Console.ReadLine());
                int day = int.Parse(Console.ReadLine());
                int hour = int.Parse(Console.ReadLine());
                int minute = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                DateTime date = new DateTime(year, month, day, hour, minute, second);
                rollbackMode.Rollback(date);
            }
            Console.ReadKey();
        }

    }
}
