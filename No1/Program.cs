using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class Program
        {
            static void Main(string[] args)
            {
                int a;
                int b;

                Console.WriteLine("Введите число 1");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число 2");
                b = Convert.ToInt32(Console.ReadLine());

                if (a > b)
                {
                    Console.WriteLine(a + b);
                }

                else

                if

                    (a == b)

                {
                    Console.WriteLine(a * b);

                }

                else if
                    (a < b)

                {
                    Console.WriteLine(a - b);
                }
            }
        }
    }
