using System;

namespace FunctionMethod
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение x");
            var x = double.Parse(Console.ReadLine());

            var y = F(x);

            Console.WriteLine("f(x) = " + y);
            Console.ReadKey();
        }

        static double F(double x)
        {
            return Math.Abs(2*Math.Sin(-3*Math.Abs((x + 1)/2)));
        }
    }
}
