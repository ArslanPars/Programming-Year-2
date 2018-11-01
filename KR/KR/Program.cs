using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 21; 
            double[] A = new double[n];
            int i;
            double s;
            
            Console.WriteLine(" Массив A: ");
            Console.WriteLine();
            for (i = 0; i <= (n - 1); i = i + 1)
            {
                A[i] = Math.Abs(i-10)/(22-Math.Sqrt(i*i+4));
                Console.WriteLine("A[{0}]={1,7:F4} ", i, A[i]);
            }
            Console.WriteLine();
            
            Console.WriteLine("Сумма элементов массива с 12-го по 19-ый ");
            s = 0;
            for (i = 12; i <= 19; i = i + 1)
            s = s + A[i];
            Console.WriteLine("s= {0,7:F4}", s);
            Console.WriteLine();
            
            Console.WriteLine("Вывод элементов массива в обратномпорядке с 19-го по 12-ый" );
            for (i = 19; i >= 12; i = i - 1)
            Console.WriteLine("A[{0}]={1,7:F4} ", i, A[i]);
            Console.WriteLine();
            
            Console.WriteLine("Вывод четных по индексу элементов массива");
            for (i = 2; i <= 10; i = i + 2)
            Console.WriteLine("A[{0}]={1,7:F4} ", i, A[i]);
            Console.ReadLine();
        }
    }
}
