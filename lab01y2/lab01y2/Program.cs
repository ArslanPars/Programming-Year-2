using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01y2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть початкове значення Xmin: ");
            string sxMin = Console.ReadLine();
            double xMin = Double.Parse(sxMin);
            Console.Write("Введiть кiнцеве значення Xmax: ");
            string sxMax = Console.ReadLine();
            double xMax = double.Parse(sxMax);
            Console.Write("Введiть прирiст dX: ");
            string sdx = Console.ReadLine();
            double dx = double.Parse(sdx);
            double sum = 0;
            double x = xMin;
            double y;
            while (x <= xMax)
            {
                y = Math.Sqrt(Math.Pow(x, 3) + Math.Pow(3*x, 5))/(1000 * Math.Sqrt(x + Math.Pow(3*x, 5))) + 65;
                Console.WriteLine("x = {0}\t\t y = {1}", x, y);
                x += dx;
                sum += y;
            }
            Console.WriteLine(sum);
            if (Math.Abs(x - xMax - dx) > 0.0001)
                {
                    y = Math.Pow(xMax, 2);
                    Console.WriteLine("x = {0}\t\t y = {1}", xMax, y);
                }
            Console.ReadKey();
        }
    }
}
