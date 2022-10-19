using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double x1;
            double x2;

            Console.WriteLine("Введите число 1");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число 2");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число 3");
            c = Convert.ToDouble(Console.ReadLine());

            double D = (b * b - (4 * a * c));

            if ((D == 0) || (D > 0))
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("Корень x1 = " + x1);
                Console.WriteLine("Корень x2 = " + x2);
            }

            else

            {
                Console.WriteLine("Дейстивтельных корней нет");
            }

        }
    }
}


