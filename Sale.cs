using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplication
{
    class Sale
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество минут разговора");
            int CountOfMinutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите стоимость минуты");
            double MinutePrice = Convert.ToDouble(Console.ReadLine());

            double FullPrice = (double)(CountOfMinutes * MinutePrice);

            Console.WriteLine("Введите номер дня недели");
            int DayOfWeek = Convert.ToInt32(Console.ReadLine());

            double WeekendSale = (double)0.2;

            if (!(DayOfWeek == 0 || DayOfWeek == 6))
            {
                Console.WriteLine(FullPrice);
            }
            else
            {
                Console.WriteLine(FullPrice - (FullPrice * WeekendSale));
            }
        }

    }
}
