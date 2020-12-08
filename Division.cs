using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplication
{
    class Division
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int a = r.Next(100);
            Console.WriteLine("Значение a: " + a);

            int b = r.Next(100);
            Console.WriteLine("Значение b: " + b);

            Console.WriteLine("Введите ответ: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a / b == c)
            {
                Console.WriteLine("Ответ верный!");
            }
            else
            {
                Console.WriteLine("Ответ не верный.");
                Console.WriteLine("Правильный ответ: " + (a / b));
            }
        }
    }
}
