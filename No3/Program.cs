using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if
                (a > b && a > c)

                if
                    (b > c)
                {
                    Console.WriteLine(c + "," + b + "," + a);
                }

                else
                {
                    Console.WriteLine(b + "," + c + "," + a);
                }

            if (a < b && a < c)
                if (b < c)
                {
                    Console.WriteLine(a + "," + b + "," + c);
                }

                else
                {
                    Console.WriteLine(a + "," + c + "," + b);
                }
            if (a > b && a < c)
                if (b < c)
                {
                    Console.WriteLine(b + "," + a + "," + c);
                }

                else
                {
                    Console.WriteLine(c + "," + a + "," + b);
                }
        }
    }
}


