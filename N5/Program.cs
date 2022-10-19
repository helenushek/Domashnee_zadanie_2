using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    public class Program
    {

        public static void Main(string[] args)
        {
            bool isDigital = false;
            int digital = 0;
            while (!isDigital)
            {
                string line = Console.ReadLine();
                isDigital = int.TryParse(line, out digital);
            }

            int dozens = digital / 10;
            int units = digital % 10;
            DigitalToText(dozens, units);
        }

        public static void DigitalToText(int dozens, int units)
        {
            switch (dozens)
            {
                case 1:
                    ForFirstTens(dozens, units);
                    break;
                case 2:
                    UnitsToText("Двадцать", units);
                    break;
                case 3:
                    UnitsToText("Тридцать", units);
                    break;
                case 4:
                    UnitsToText("Сорок", units);
                    break;
                case 5:
                    UnitsToText("Пятьдесят", units);
                    break;
                case 6:
                    UnitsToText("Шестьдесят", units);
                    break;
                case 7:
                    UnitsToText("Семьдесят", units);
                    break;
                case 8:
                    UnitsToText("Восемьдесят", units);
                    break;
                case 9:
                    UnitsToText("Девяносто", units);
                    break;

            }
        }

        private static void UnitsToText(string dozens, int units)
        {

            string unitsText = string.Empty;
            switch (units)
            {
                case 1:
                    unitsText = "один";
                    break;

                case 2:
                    unitsText = "два";
                    break;
                case 3:
                    unitsText = "три";
                    break;
                case 4:
                    unitsText = "четыре";
                    break;
                case 5:
                    unitsText = "пять";
                    break;
                case 6:
                    unitsText = "шесть";
                    break;
                case 7:
                    unitsText = "семь";
                    break;
                case 8:
                    unitsText = "восемь";
                    break;
                case 9:
                    unitsText = "девять";
                    break;
            }
            Console.WriteLine($"{dozens} {unitsText}");
        }

        private static void ForFirstTens(int dozens, int units)
        {
            switch (units)
            {
                case 1:
                    Console.WriteLine("Одиннадцать");
                    break;
                case 2:
                    Console.WriteLine("Двенадцать");
                    break;
                case 3:
                    Console.WriteLine("Тринадцать");
                    break;
                case 4:
                    Console.WriteLine("Четырнадцать");
                    break;
                case 5:
                    Console.WriteLine("Пятнадцать");
                    break;
                case 6:
                    Console.WriteLine("Шестнадцать");
                    break;
                case 7:
                    Console.WriteLine("Семнадцать");
                    break;
                case 8:
                    Console.WriteLine("Восемнадцать");
                    break;
                case 9:
                    Console.WriteLine("Девятнадцать");
                    break;
            }
        }
    }
}

