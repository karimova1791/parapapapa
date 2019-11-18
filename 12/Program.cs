using System;

namespace Пример_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());


            if (x < b && x >= 0)
            {
                Console.WriteLine(Math.Pow(x, 2) - 1 / 4 * (Math.Pow((Math.Sqrt(b + Math.Pow(x, 3))), 3)));
            }

            else if (x < a && x >= b)
            {
                Console.WriteLine(Math.Pow((b + a * x), 2) + b * Math.Exp(a + 1));


            }
            else if (x >= a)
            {
                Console.WriteLine(Math.Atan((Math.Pow(b, 2) + (a * x))) - (Math.Sqrt(a) * Math.Log(Math.Abs(x))));

            }
        }
    }
}

