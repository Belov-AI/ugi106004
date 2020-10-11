using System;

namespace SinCos
{
    class Program
    {
        static void Main()
        {
            PrintSinCos(15);
            PrintSinCos(37);
            PrintSinCos(113);

            Console.ReadKey();
        }

        static void PrintSinCos(double angleInDegrees)
        {
            double sin, cos;
            CalulateRoundedSinCos(angleInDegrees, out sin, out cos);

            Console.WriteLine("sin " + angleInDegrees + "° = " + sin);
            Console.WriteLine("cos " + angleInDegrees + "° = " + cos);
            Console.WriteLine();
        }

        static void CalulateRoundedSinCos(double angleInDegrees, 
            out double sinus, out double cosinus)
        {
            double angleInRadians = DegreesToRadians(angleInDegrees);
            sinus = Math.Round(Math.Sin(angleInRadians), 3);
            cosinus = Math.Round(Math.Cos(angleInRadians), 3);
        }

        static double DegreesToRadians(double angleInDegrees)
        {
            return angleInDegrees * Math.PI / 180;
        }

    }
}
