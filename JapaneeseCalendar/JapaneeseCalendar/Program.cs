using System;
using System.Security.Cryptography.X509Certificates;

namespace JapaneeseCalendar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите год н. э.");
            var year = int.Parse(Console.ReadLine());

            var yearInCycle = (year - 1984) % 60;

            if (yearInCycle < 0)
                yearInCycle += 60;

            var color = yearInCycle / 12;
            var animal = yearInCycle % 12;

            Console.WriteLine($"{year} — год {GetColor(color)}{GetAnimal(animal)}");

            Console.ReadKey();
        }

        static string GetColor(int color)
        {
            switch (color)
            {
                case 0:
                    return "зеленo";
                case 1:
                    return "краснo";
                case 2:
                    return "желтo";
                case 3:
                    return "белo";
                default:
                    return "черно";
            }
        }

        static string GetAnimal(int animal)
        {
            throw new NotImplementedException();
        }
    }
}
