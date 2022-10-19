using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Введите число 1");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            b = Convert.ToDouble(Console.ReadLine());

            if (a > 0)
            {
                if (b > 0)
                {
                    Console.WriteLine("1");
                }

                else
                {
                    Console.WriteLine("4");
                }
            }

            if (a < 0)
            {
                if (b < 0)
                {
                    Console.WriteLine("3");
                }

                else
                {
                    Console.WriteLine("2");
                }
            }

        }
    }
}

