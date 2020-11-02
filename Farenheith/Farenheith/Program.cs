using System;

namespace Farenheith
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите температуру в °C");
            var celsiumDegrees = double.Parse(Console.ReadLine());
            
            var farenheithDegrees = ConvertCelsium2Farenheith(celsiumDegrees);

            Console.WriteLine($"Темература {celsiumDegrees:F1} °С составляет {farenheithDegrees:F1} °F");

            Console.ReadKey();
        }

        static double ConvertCelsium2Farenheith(double temperatureInC)
        {
            return temperatureInC * 9 / 5 + 32;
        }
    }
}
