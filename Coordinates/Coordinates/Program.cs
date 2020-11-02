using System;


namespace Coordinates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x: ");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y: ");
            var y = double.Parse(Console.ReadLine());

            if (x == 0)
            {
                if (y == 0)
                    Console.WriteLine("Точка совпадает с началом координат");
                else
                    Console.WriteLine("Точка лежит на оси Oy");
            }
            else
            {
                if (y == 0)
                    Console.WriteLine("Точка лежит на оси Ox");
                else
                {
                    if (x > 0)
                    {
                        if (y > 0)
                            Console.WriteLine("Точка лежит в I квадранте");
                        else
                            Console.WriteLine("Точка лежит в IV квадранте");
                    }
                    else
                    {
                        if (y > 0)
                            Console.WriteLine("Точка лежит в II квадранте");
                        else
                            Console.WriteLine("Точка лежит в III квадранте");
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
