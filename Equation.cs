using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApplication
{
    class Equation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение а: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            QEquation(a, b, c);

        }

        static void QEquation(double a, double b, double c)
        {
            double Discriminant = (double)Math.Pow(b, 2) - 4 * a * c;

            int x1 = (int)Math.Round((-b + Math.Sqrt(Discriminant)) / 2 * a);
            int x2 = (int)Math.Round((-b - Math.Sqrt(Discriminant)) / 2 * a);

            if (Discriminant < 0)
            {
                Console.WriteLine("Корней нет.");
            }
            else if (Discriminant == 0)
            {
                Console.WriteLine("Корень один: " + x1);
            }
            else
            {
                Console.WriteLine("Два корня: ");
                Console.WriteLine("первый корень {0}, второй корень {1}", x1, x2);
            }
        }
    }
}
