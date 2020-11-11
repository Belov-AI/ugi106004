using System;

namespace Task06_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координату x");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y");
            var y = double.Parse(Console.ReadLine());

            Console.WriteLine("Принадлежит ли точка области? " + IsPointInArea(x, y));

            Console.ReadKey();
        }

        static bool IsPointInArea(double x, double y)
        {
            return -2 <= x && x <= -1 && -2 <= y && y <= 1 || //точка в R1
                -1 <= x && x <= 1 && -2 <= y && y <= 2 ||     //точка в R2
                1 <= x && x <= 2 && -1 <= y && y <= 2;        //точка в R3
        }
    }
}
