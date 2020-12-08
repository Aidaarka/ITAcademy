using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplication
{
    class SecondWorldWar
    {
        static void Main(string[] args)
        {
            DateTime SecondWWDate = new DateTime(1939, 09, 1);

            Console.WriteLine("Введите дату начала Второй мировой войны \" дд.мм.гггг \"");

            DateTime YourVersion = Convert.ToDateTime(Console.ReadLine());

            if (!(YourVersion == SecondWWDate))
            {
                Console.WriteLine("Не верно!");
                Console.WriteLine("Правильный ответ " + SecondWWDate.ToShortDateString());
            }
            else
            {
                Console.WriteLine("Верно!");
            }
        }
    }
}
