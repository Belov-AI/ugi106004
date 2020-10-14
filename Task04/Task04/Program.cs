using System;

namespace Task04
{
    class Program
    {
        static void Main()
        {
            var x = GetValue();

            Console.WriteLine("x = " + x);

            Console.ReadKey();
        }

        static double GetValue()
        {
            return F(3, 2) * F(2, 4) * F(7, 5);
        }

        /// <summary>
        /// Вычисление повторяющегося выражения
        /// </summary>
        /// <param name="a">Константа под корнем</param>
        /// <param name="b">Знаменатель дроби</param>
        /// <returns></returns>
        static double F(double a, double b)
        {
            return Math.Tan((1 + Math.Sqrt(a)) / b);
        }
    }
}
