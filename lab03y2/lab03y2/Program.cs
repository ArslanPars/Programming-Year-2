using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03y2
{
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("Обчислення інтегралу методом:");
            Console.WriteLine("1. Центральних прямокутників");
            Console.WriteLine("2. Лівих прямокутників");
            Console.WriteLine("3. Правих прямокутників");
            Console.WriteLine("0. Вихід");
            var res = Console.ReadLine();
            Console.Clear();
            return Convert.ToInt32(res);
        }
        static double Function(double x)
        {
            return Math.Pow(Math.Cos((2 * x + 2 * (5 * x) + 9) / 0.666), 3) + Math.Pow(5 * x, 7);
        }
        static void M1(double a, double b, double n)
        {
            Console.WriteLine("Метод центральних прямокутників:");
            double dx = (b - a) / n;
            double y1, y2;
            double x1, x2;
            double Intgrl = 0;
            for (int i = 0; i < n; i++)
            {
                x1 = a + i * dx;
                x2 = x1 + dx;
                y1 = Function(x1);
                y2 = Function(x2);
                Intgrl += (y1 + y2) / 2 * dx;
            }
            Console.WriteLine("Iнтеграл функцiї на вiдрiзку [{0}, {1}] становить {2:0.0000}", a, b, Intgrl);

        }
        static void M2(double a, double b, double n)
        {
            Console.WriteLine("Метод лівих прямокутників:");
            double dx = (b - a) / n;
            double y1;
            double x1;
            double Intgrl = 0;
            for (int i = 0; i < n; i++)
            {
                x1 = a + i * dx;
                y1 = Function(x1);
                Intgrl += y1 * dx;
            }
            Console.WriteLine("Iнтеграл функцiї на вiдрiзку [{0}, {1}] становить {2:0.000000}", a, b, Intgrl);
        }

        static void M3(double a, double b, double n)
        {
            Console.WriteLine("Метод правих прямокутників:");
            double dx = (b - a) / n;
            double y1;
            double x1;
            double Intgrl = 0;
            for (int i = 1; i < n; i++)
            {
                x1 = a + i * dx;
                y1 = Function(x1);
                Intgrl += y1 * dx;
            }
            Console.WriteLine("Iнтеграл функцiї на вiдрiзку [{0}, {1}] становить {2:0.0000}", a, b, Intgrl);
        }
        static void Main(string[] args)
        {
            Console.Write("Введiть початок вiдрiзку iнтегрування a: ");
            string sa = Console.ReadLine();
            double a = double.Parse(sa);
            Console.Write("Введiть кiнець вiдрiзку iнтегрування b: ");
            string sb = Console.ReadLine();
            double b = double.Parse(sb);
            Console.Write("Введiть кiлькiсть дiлянок n: ");
            string sn = Console.ReadLine();
            double n = double.Parse(sn);
            bool o = true;
            while (o)
            {
                switch (Menu())
                {
                    case 1:
                        M1(a, b, n);
                        Console.ReadLine();
                        break;
                    case 2:
                        M2(a, b, n);
                        Console.ReadLine();
                        break;
                    case 3:
                        M3(a, b, n);
                        Console.ReadLine();
                        break;
                    case 0:
                        o = false;
                        Console.Write("До побачення!\n");
                        break;
                }
            }
        }
    }
}