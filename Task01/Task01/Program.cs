using System;

namespace Task01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первую координату первой точки");
            var x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую координату первой точки");
            var y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите первую координату второй точки");
            var x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую координату второй точки");
            var y2 = double.Parse(Console.ReadLine());

            var dx = x1 - x2;
            var dy = y1 - y2;

            var distance = Math.Round(
                    Math.Sqrt(dx * dx + dy * dy), 3);

            Console.WriteLine("Расстояние равно " + distance);

            Console.ReadKey();
        }
    }
}
