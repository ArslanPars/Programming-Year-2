using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03y2
{
    class Program
    {
        static double Function(double x)
        {
            return Math.Pow(Math.Cos((2 * x + 2 * (5 * x) + 9) / 0.666), 3) + Math.Pow(5 * x, 7);
            
        }
        static void Main(string[] args)
        {
            StartOfCalculations:
            Console.Write("Введіть початок відрізку інтегрування a: ");
            string sa = Console.ReadLine();
            double a = double.Parse(sa);
            Console.Write("Введіть початок відрізку інтегрування b: ");
            string sb = Console.ReadLine();
            double b = double.Parse(sb);
            Console.Write("Введіть кількість ділянок n: ");
            string sn = Console.ReadLine();
            double n = double.Parse(sn);
            double dx = (b - a) / n;
            double x1, x2, y1, y2;
            double IntgrlL = 0;
            double IntgrlR = 0;
            for (int i = 0; i < n; i++)
            {
                x1 = a + i * dx;
                x2 = x1 + dx;
                y1 = Function(x1);
                y2 = Function(x2);
                IntgrlL += y1 * dx;
                IntgrlR += y2 * dx;
            }
            Console.WriteLine("Iнтеграл функцiї на вiдрiзку [{0}, {1}] становить: \n Методом лівих прямокутників {2:0.0000}\n Методом правих прямокутників {3:0.0000}", a, b, IntgrlL, IntgrlR);
            Console.Write("Повторити розрахунок (O - так) ? ");
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            Console.WriteLine();
            if (pressedKey.Key == ConsoleKey.O)
            {
                Console.WriteLine();
                goto StartOfCalculations;
            }
            else Console.Write("Пока-Пока\n");
        }
    }
}
