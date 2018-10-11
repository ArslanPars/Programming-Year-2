using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03y2
{
    public delegate double FuncDelegate(double x);
    class Program
    {
        static int Menu()
        {
            Console.WriteLine("Обчислення інтегралу методом:");
            Console.WriteLine("0. Центральних прямокутників");
            Console.WriteLine("1. Лівих прямокутників");
            Console.WriteLine("2. Правих прямокутників");
            Console.WriteLine("0. Вихід");
            var res = Console.ReadLine();
            Console.Clear();
            return Convert.ToInt32(res);
        }

        public static double QuadCentral(double a, double b, double n, FuncDelegate func)
        {
            Console.WriteLine("Метод центральних прямокутників:");
            double h = (b - a) / n;
            double q = 0;
            for (double x = a; x < b; x += h)
            {
                q += func(x + h / 2);
            }
            return q * h;
        }

        public static double QuadLeft(double a, double b, double n, FuncDelegate func)
        {
            Console.WriteLine("Метод лівих прямокутників:");
            double h = (b - a) / n;
            double y1;
            double x1;
            double Intgrl = 0;
            for (int i = 0; i < n; i++)
            {
                x1 = a + i * h;
                y1 = func(x1);
                Intgrl += y1 * h;
            }
            return Intgrl;
        }

         public static double QuadRight(double a, double b, double n, FuncDelegate func)
        {
            Console.WriteLine("Метод правих прямокутників:");
            double h = (b - a) / n;
            double y1;
            double x1;
            double Intgrl = 0;
            for (int i = 1; i <= n; i++)
            {
                x1 = a + i * h;
                y1 = func(x1);
                Intgrl += y1 * h;
            }
            return Intgrl;
        }

        delegate double QuadDelegate(double a, double b, double n, FuncDelegate func);
        static double F(double x)
        {
            return Math.Pow(Math.Cos((2 * x + 2 * (5 * x) + 9) / 0.666), 3) + Math.Pow(5 * x, 7);
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
            QuadDelegate[] menu = { QuadCentral, QuadLeft, QuadRight };
            while (true)
            {
                QuadDelegate q = menu[Menu()];
                double r = q(a, b, n, F);
                Console.WriteLine("Integral: [{0}, {1}] = {2}", a, b, r);
                Console.WriteLine();
            }
        }
    }
}
